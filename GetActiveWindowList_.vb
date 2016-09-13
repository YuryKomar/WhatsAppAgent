Module GetActiveWindowList_
#Region "   Декларации"
	Private Delegate Function CallBack(ByVal hWnd As IntPtr, ByVal lParam As Integer) As Boolean
	Private Declare Function EnumWindows Lib "user32.dll" (ByVal Adress As CallBack, ByVal y As Integer) As Integer
	Public Declare Function GetWindowTextLength Lib "user32.dll" Alias "GetWindowTextLengthA" (ByVal hwnd As IntPtr) As Int32
	Public Declare Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (ByVal hwnd As IntPtr, ByVal lpString As String, ByVal cch As Int32) As Int32
	Private ActiveWindows(0) As Integer
#End Region
#Region "   Получаем список всех активных HANDEL"
	Private Function Enumerator(ByVal hwnd As IntPtr, ByVal lParam As Integer) As Boolean
		If ActiveWindows.Length > 0 Then
			ReDim Preserve ActiveWindows(ActiveWindows.Length)
			ActiveWindows(ActiveWindows.Length - 1) = hwnd
		Else
			ActiveWindows(0) = hwnd
		End If
		Return True
	End Function
	Private Function GetActiveWindows() As Integer()
		Array.Clear(ActiveWindows, 0, ActiveWindows.Length)
		EnumWindows(AddressOf Enumerator, 0)
		Return ActiveWindows
	End Function
#End Region
	'Возращает String массив содержащий список активных окон, содержащих какой-либо текст
	'в заголовке в следующем формата:   HANDLE%%%ТЕКСТ_ЗАГОЛОВКА 
	Public Function GetActiveWindowsList() As String()
		Dim ArrayToReturn(0) As String
		For Each item In GetActiveWindows()
			If item <> 0 Then
				Dim WindowText As String = Space(GetWindowTextLength(item) + 1)
				GetWindowText(item, WindowText, WindowText.Length)
				WindowText = WindowText.Trim
				If WindowText <> vbNullChar Then
					If ArrayToReturn(0) = Nothing Then
						ArrayToReturn(0) = item & "%%%" & WindowText
					Else
						ReDim Preserve ArrayToReturn(ArrayToReturn.Length)
						ArrayToReturn(ArrayToReturn.Length - 1) = item & "%%%" & WindowText
					End If
				End If
			End If
		Next
		Return ArrayToReturn
	End Function
End Module
