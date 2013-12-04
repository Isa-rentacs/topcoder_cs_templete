Templete and Script for C# in Topcoder

06/30/2013 Initial Commit
12/05/2013 Modified compile.ps1 to run.ps1

templete.cs
 > Just copy and paste to the templete code for C# in Arena

compile.ps1
 > Use for local tests.
 > Before execute, type command "Set-ExecutionPolicy unrestricted" on PowerShell (with Administrator)

 usage : run.ps1 -fileName <file name> [-debug]

 -fileName <file name>
   > Provide the file name which you would like to test.

 -debug
   > If you added the paramter, Debugger.Launch() will be called and you can debug on Visual Studio.

  