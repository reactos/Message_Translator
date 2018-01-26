using System;
using System.Xml;

namespace MsgTrans.Library
{
    public class NtStatusCommand : XmlCommand
    {
        public NtStatusCommand(MessageTranslator msgTrans,
                               string ntstatusXml)
            : base(msgTrans, ntstatusXml)
        {
        }

        public override string[] AvailableCommands
        {
            get { return new string[] { "ntstatus" }; }
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

            long dec;
            string hex;
            NumberParser np = new NumberParser();
            if (np.Parse(ntstatusText))
            {
                dec = np.Decimal;
                hex = np.Hex;
            }
            else
            {
                dec = GetNtStatusNumber(ntstatusText);
                if (dec == -1)
                {
                    return false;
                }
                hex = dec.ToString("X");
            }

            string description = GetNtstatusDescription(dec);
            if (description != null)
            {
                AddMessage(MessageType.NTSTATUS,
                           dec,
                           hex,
                           description,
                           null);

                return true;
            }

            return false;
        }

        public override string Help()
        {
            return "ntstatus <value>";
        }
        
        public string GetNtstatusDescription(long ntstatus)
        {
            XmlElement root = base.m_XmlDocument.DocumentElement;
            XmlNode node = root.SelectSingleNode(String.Format("Ntstatus[@value='{0}']",
                                                               ntstatus.ToString("X8")));
            if (node != null)
            {
                XmlAttribute text = node.Attributes["text"];
                if (text == null)
                    throw new Exception("Node has no text attribute.");
                return text.Value;
            }
            else
                return null;
        }

        private long GetNtStatusNumber(string ntstatus)
        {
            XmlElement root = base.m_XmlDocument.DocumentElement;
            XmlNode node = root.SelectSingleNode(String.Format("Ntstatus[@text='{0}']",
                                                               ntstatus));
            if (node != null)
            {
                XmlAttribute value = node.Attributes["value"];
                if (value == null)
                    throw new Exception("Node has no value attribute.");

                string hex = value.Value;

                return Convert.ToInt64(hex, 16);
            }
            else
                return -1;
        }
    }
}
