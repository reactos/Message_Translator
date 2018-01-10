# WM message list - http://blog.airesoft.co.uk/2009/11/wm_messages/

clear-host
$Start = "<?xml version=""1.0"" ?>`r`n<WindowMessageList>`r`n"
$End = '</WindowMessageList>'
$Pre = "`t<WindowMessage text="""
$Mid = """ value="""
$Post = """ />`r`n"

$ParentFolder = Join-Path $MyInvocation.MyCommand.Path ".."
$OutputFile = "$ParentFolder\..\GUI\Resources\wm.xml"

$Output = $Start
foreach($line in (Get-Content $ParentFolder\wm_messages.txt)){

    $nline = $line.Split(" ")
    $decimal =  [Convert]::ToInt64($nline[2],16)
    $output += $Pre + $nline[1] + $Mid + $decimal + $Post
}
$Output += $End
$Output | Out-File $OutputFile