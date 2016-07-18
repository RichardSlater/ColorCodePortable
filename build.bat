@echo off

if %COMPUTERNAME%==CODEPLEX-BUILD set ArchivePath=D:\Builds\Zips\ColorCode

if "%1" == "" goto :WithoutTarget

:WithTarget
"%ProgramFiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" ColorCode.msbuild /p:Configuration=Debug /logger:Kobush.Build.Logging.XmlLogger,"3rdParty\Kobush.Build.dll";BuildResults.xml /t:%*
goto :End

:WithoutTarget
"%ProgramFiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" ColorCode.msbuild /p:Configuration=Debug /logger:Kobush.Build.Logging.XmlLogger,"3rdParty\Kobush.Build.dll";BuildResults.xml

:End
