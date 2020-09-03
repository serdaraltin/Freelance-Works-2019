# PREC
Password Recovery Class for Visual Basic .NET
# Installation in your project
Add SQLiteHandler.vb and prec.vb to your project
# Example Usage
```vb.net
For Each Drive As DriveInfo In DriveInfo.GetDrives
	If Drive.RootDirectory.FullName = "C:\" Then
		Dim x As New PREC(Drive)
		With x
			.RecoverChrome()
			.RecoverFileZilla()
			.RecoverFirefox()
			.RecoverOpera()
			.RecoverPidgin()
			.RecoverThunderbird()
			.RecoverProxifier()
		End With
		For Each A As Account In x.Accounts
			MsgBox(A.ToString())
		Next
	End If
Next
```
# Recovers passwords for the following apps
* Google Chrome (45.0.2454)
* FileZilla (3.14.1.0)
* Mozilla Firefox (42.0.0.5780)
* Opera Webbrowser (33.0.1990.115)
* Pidgin (2.10.11/libpurple 2.10.11)
* Mozilla Thunderbird (38.2.0)
* Proxifier (3.15) **Does not currently decrypt passwords**
