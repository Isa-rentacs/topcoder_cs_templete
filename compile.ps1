Param(
[string]$fileName,
[switch]$debug
)
if(!$debug)
{
	csc /o /warnaserror+ /checked+ /nologo /out:a.exe $fileName
}
else
{
	csc /debug+ /debug:full /warnaserror+ /checked+ /nologo /out:a.exe /define:DEBUGGER $fileName
}
./a.exe