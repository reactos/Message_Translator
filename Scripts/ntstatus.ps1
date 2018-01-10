clear-host
$Start = "<?xml version=""1.0"" ?>`r`n<NtstatusList>`r`n"
$End = '</NtstatusList>'
# XML formatting
$Pre = "`t<Ntstatus text="""
$Mid = """ value="""
$Post = """ />`r`n"

# Paths and the regex
$ParentFolder = Join-Path $MyInvocation.MyCommand.Path ".."
$OutputFile = "$ParentFolder\..\GUI\Resources\ntstatus.xml"
$regex = '^#define\s(\w[A-Z_0-9]+)\s+\(\(NTSTATUS\)0x(\w[0-9A-F]+)L\)'
$Run = $false

# Loop through all the lines in the header file and match against the regex
# Add any matches to our output using the XML formatting
$Output = $Start
foreach($line in (Get-Content "c:\Program Files (x86)\Windows Kits\10\Include\10.0.16299.0\shared\ntstatus.h")) {
    if ($line -match $regex)     {
        # Don't start to write until we hit the STATUS_SUCCESS define
        if ($Run -eq $false -and ($matches[1] -eq 'STATUS_SUCCESS')) {
            $Run = $true;
        }

        if ($Run -eq $true) {
            $output += $Pre + $matches[1] + $Mid + $matches[2] + $Post
        }       
    }
}
$Output += $End
$Output | Out-File $OutputFile