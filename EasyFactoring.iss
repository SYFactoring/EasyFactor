; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "EasyFactoring�ױ�"
#define MyAppVersion "4.12.23.14"
#define MyAppPublisher "Easy Company, Inc."
#define MyAppExeName "EasyFactoring.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{C9602A4A-117B-4E1B-883B-FCE6C0D4BCBB}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename=EasyFactoring
Compression=lzma
SolidCompression=yes
EnableDirDoesntExistWarning=True
ArchitecturesInstallIn64BitMode=x64

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "Dll\DevComponents.DotNetBar2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "Dll\ICSharpCode.SharpZipLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\EasyFactoring.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\EasyFactoring.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\EasyFactoring.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\EasyFactoring.vshost.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\EasyFactoring.vshost.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\EasyFactoring.vshost.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
