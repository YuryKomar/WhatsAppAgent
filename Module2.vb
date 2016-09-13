Imports System.Runtime.InteropServices

Module Module2

	Public Declare Function ShowWindow Lib "user32.DLL" Alias "ShowWindow" (ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
	Public Declare Function IsWindowVisible Lib "User32" (ByVal hWnd As Integer) As Integer
	Public Declare Function SendMessage Lib "user32.DLL" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

	Public Declare Function SetForegroundWindow Lib "user32.DLL" Alias "SetForegroundWindow" (ByVal hwnd As Integer) As Integer

	Public Declare Function GetWindowLong Lib "user32.DLL" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
	Public Const NORMAL As Integer = 382664704
	Public Const MINIMIZED As Integer = 919535616
	Public Const MAXIMIZED As Integer = 399441920


	Public myHWND As Integer
	Public prcArgs1 As String = " --app=https://web.whatsapp.com/"

	Public Function GetChromePath() As String
		Dim Path_ As String
		Path_ = My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\ChromeHTML\shell\open\command", "", Nothing)
		If Path_ = Nothing Then Path_ = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Classes\http\shell\open\command", "", Nothing)
		My.Computer.Registry.ClassesRoot.Close()
		Path_ = Replace(Path_, Chr(34), "").Replace(" -- %1", "")
		Return Path_
	End Function

	Public Sub OpenWhatApp()
		On Error Resume Next
		Shell(GetChromePath() & prcArgs1, AppWinStyle.NormalFocus)
		Dim FOUND As Boolean = False
		Application.DoEvents()
		Do
			For Each HWND In GetActiveWindowsList()
				If Not HWND.Contains(MainWindow.Text) Then
					If HWND.Contains("Без имени") Or HWND.Contains("Untitled") Or
					 HWND.Contains("whatsapp") Or HWND.Contains("WhatsApp") Then
						myHWND = HWND.Split("%%%")(0)
						FOUND = True
					End If
				End If
			Next
		Loop While Not FOUND
		ShowWindow(myHWND, vbNormalFocus)
	End Sub

	Public Function IsNewMessage(WhatsAppHandle As Integer) As Boolean
		If myHWND <> Nothing Then
			Dim WindowText As String = Space(GetWindowTextLength(WhatsAppHandle) + 1)
			GetWindowText(WhatsAppHandle, WindowText, WindowText.Length)
			WindowText = WindowText.Trim
			If WindowText.Contains("(") And WindowText.Contains(")") Then
				Return True
			End If
		End If
		Return False
	End Function
End Module
