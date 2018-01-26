using System;
using System.Xml;
using System.Runtime.InteropServices;

namespace MsgTrans.Library
{
    public class NtStatusToWin32 : Command
    {
        NtStatusCommand NtstatusCodes = null;
        WinerrorCommand WinerrorCodes = null;

        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string FileName);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string ProcName);

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate ulong fRtlNtStatusToDosError(ulong NtStatusCode);


        public NtStatusToWin32(MessageTranslator msgTrans,
                               string ntstatusXml,
                               string winerrorXml) :
            base(msgTrans)
        {
            NtstatusCodes = new NtStatusCommand(msgTrans, ntstatusXml);
            WinerrorCodes = new WinerrorCommand(msgTrans, winerrorXml);
        }

        public override string[] AvailableCommands
        {
            get { return new string[] { "ntstat2dos" }; }
        }

        public override bool Handle(MessageContext context,
                                    string commandName,
                                    string parameters)
        {
            string ntstatusText = parameters;
            if (ntstatusText.Equals(String.Empty))
            {
                return false;
            }

            if (!NtstatusCodes.Handle(context, commandName, parameters))
            {
                return false;
            }

            long DosCode = GetDosCodeFromNtstatus(NtstatusCodes.Number);
            if (DosCode == 0xFFFFFFFF)
            {
                return false;
            }

            if (!WinerrorCodes.Handle(context, commandName, DosCode.ToString()))
            {
                return false;
            }

            return true;
        }
        
        public override string Help()
        {
            return "blurgh <value>";
        }
        
        private long GetDosCodeFromNtstatus(long ntstatus)
        {
            ulong DosCode = 0xFFFFFFFF;
            IntPtr hModule = LoadLibrary(@"ntdll.dll");
            if (hModule != null)
            {
                IntPtr Address = GetProcAddress(hModule, "RtlNtStatusToDosError");

                fRtlNtStatusToDosError RtlNtStatusToDosError = 
                    (fRtlNtStatusToDosError)Marshal.GetDelegateForFunctionPointer(Address,
                                                                                  typeof(fRtlNtStatusToDosError));

                DosCode = RtlNtStatusToDosError((ulong)ntstatus);

                FreeLibrary(hModule);

            }
            return (long)DosCode;
        }
    }
}


/*
    DWORD Status;
    RTL_NTSTATUS_TO_DOS_ERROR pRtlNtStatusToDosError;
    HMODULE hModule = LoadLibraryW(L"ntdll.dll");
    if (hModule)
    {
        pRtlNtStatusToDosError = (RTL_NTSTATUS_TO_DOS_ERROR)GetProcAddress(hModule, "RtlNtStatusToDosError");

#define STATUS_PROCESS_IS_PROTECTED      ((NTSTATUS)0xC0000712L)
    Status = pRtlNtStatusToDosError(STATUS_PROCESS_IS_PROTECTED);
    }

    */