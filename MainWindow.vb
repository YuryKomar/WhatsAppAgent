Imports System.Threading
Public Class MainWindow
	Dim sz As Size = New Size(0, 0)
	Dim Slide As Boolean = False
	Dim AnimIsNewMsg As Boolean = False
	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.MinimumSize = New Size(0, 0)
		Me.Size = New Size(0, 0)
		Me.Hide()
		On Error Resume Next
		Settings("LOAD")
		Me.TransparencyKey = Me.BackColor
		If GetChromePath() = Nothing Then
			MsgBox("На компьютере не найден Google Chome Browser" & vbCrLf & "Приложение не может продолжить свою работу", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WEB.WhatsApp.Error")
			Application.ExitThread()
		End If
		Me.trayICO.Visible = True
		Me.trayICO.Icon = Me.Icon
		Label5.Text = Application.ProductName & " v" & Application.ProductVersion
		CopyRightLabel.Text = My.Application.Info.Copyright
	End Sub


	Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
		If GetWindowLong(myHWND, -1) = vbNullString Then myHWND = Nothing

		If myHWND <> Nothing Then
			SwWEB.Visible = True
			ОткрытьWhatsAppToolStripMenuItem.Visible = False

			If SwWEB.Text = "Показать WhatsApp" And GetWindowLong(myHWND, -16) = NORMAL Then SwWEB_Click(sender, e)
			Me.trayICO.Text = Application.ProductName & " - ONLINE"
		Else
			AnimIcon.Stop()
			SwWEB.Visible = False
			ОткрытьWhatsAppToolStripMenuItem.Visible = True
			trayICO.Icon = My.Resources.OffLine
			Me.trayICO.Text = Application.ProductName & " - OFFLINE"
		End If

		If set_3.Checked And GetWindowLong(myHWND, -16) = MINIMIZED Then SwWEB_Click(sender, e)

	End Sub

	Private Sub Settings(Action As String)
		On Error Resume Next
		If Action = "LOAD" Then
			set_1.Checked = CBool(GetSetting("WhatsAppAgent", "Settings", "OpenWhatsAppOnStartup", "False"))
			set_2.Checked = CBool(GetSetting("WhatsAppAgent", "Settings", "CloseWhatsAppOnExit", "False"))
			set_3.Checked = CBool(GetSetting("WhatsAppAgent", "Settings", "MinimizeWindows", "False"))
			'=======================
			If set_1.Checked Then
				OpenWhatApp()
				AnimIcon.Start()
			End If

		ElseIf Action = "SAVE" Then
			SaveSetting("WhatsAppAgent", "Settings", "OpenWhatsAppOnStartup", set_1.Checked)
			SaveSetting("WhatsAppAgent", "Settings", "CloseWhatsAppOnExit", set_2.Checked)
			SaveSetting("WhatsAppAgent", "Settings", "MinimizeWindows", set_3.Checked)

			'=======================
			If set_2.Checked Then
				If myHWND <> Nothing Then SendMessage(myHWND, &H10, 0, 0)
			End If
		End If
	End Sub
	Private Sub MainWindow_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		On Error Resume Next
		Me.trayICO.Dispose()
		ShowWindow(myHWND, vbNormalFocus)
		Settings("SAVE")
	End Sub

	Private Sub SwWEB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwWEB.Click
		On Error Resume Next
		If SwWEB.Text = "Скрыть WhatsApp" Then
			ShowWindow(myHWND, vbMinimizedNoFocus)
			ShowWindow(myHWND, vbHide)
			SwWEB.Text = "Показать WhatsApp"

		ElseIf SwWEB.Text = "Показать WhatsApp" Then
			ShowWindow(myHWND, vbNormalFocus)
			SetForegroundWindow(myHWND)
			SwWEB.Text = "Скрыть WhatsApp"

		Else
			SwWEB.Text = "Скрыть WhatsApp"
		End If
	End Sub

	Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
		Me.Close()
	End Sub
	Private Sub ОткрытьWhatsAppToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОткрытьWhatsAppToolStripMenuItem.Click
		On Error Resume Next
		OpenWhatApp()
		ОткрытьWhatsAppToolStripMenuItem.Visible = False
		AnimIcon.Start()
	End Sub
	Private Sub trayICO_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trayICO.MouseClick
		On Error Resume Next
		If e.Button = MouseButtons.Left Then
			If myHWND <> Nothing Then
				If SwWEB.Text = "Скрыть WhatsApp" Then
					ShowWindow(myHWND, vbMinimizedNoFocus)
					ShowWindow(myHWND, vbHide)
					SwWEB.Text = "Показать WhatsApp"

				ElseIf SwWEB.Text = "Показать WhatsApp" Then
					ShowWindow(myHWND, vbNormalFocus)
					SetForegroundWindow(myHWND)
					SwWEB.Text = "Скрыть WhatsApp"

				End If
			Else
				OpenWhatApp()
				AnimIcon.Start()
			End If

		ElseIf e.Button = MouseButtons.Right Then
			trayICO.ContextMenuStrip.Show()
		End If
	End Sub

	Private Sub НастрокиToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles НастрокиToolStripMenuItem.Click
		Me.MinimumSize = New Size(433, 221)
		Me.Size = New Size(433, 221)
		Me.Show()
		НастрокиToolStripMenuItem.Visible = False
	End Sub

	Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
		Me.Hide()
		НастрокиToolStripMenuItem.Visible = True
	End Sub

	Private Sub MainWindow_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
		e.Graphics.TranslateTransform(4, 60)
		e.Graphics.RotateTransform(-45)
		e.Graphics.DrawString("Версия " & ProductVersion, New Font("Segoe UI Light", 10, FontStyle.Bold), Brushes.White, New Point(0, 0))
	End Sub


	Private Sub MainWindow_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
		Me.Capture = False
		Me.WndProc(Message.Create(Me.Handle, &HA1, 2, IntPtr.Zero)) 'Двигать форму не за заголовок
	End Sub

	Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
		Slide = Not Slide
		Timer3.Start()
	End Sub

	Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
		If Slide Then
			If Me.Width < 700 Then
				Me.Width = Me.Width + 10
			Else
				Me.Width = 700
				Timer3.Stop()
			End If
		Else
			If Me.Width > 433 Then
				Me.Width = Me.Width - 10
			Else
				Me.Width = 433
				Timer3.Stop()
			End If
		End If
	End Sub

	Private Sub AnimIcon_Tick(sender As Object, e As EventArgs) Handles AnimIcon.Tick
		If IsNewMessage(myHWND) Then

			AnimIsNewMsg = Not AnimIsNewMsg
			If AnimIsNewMsg Then trayICO.Icon = My.Resources.NewMsg Else trayICO.Icon = My.Resources.icon

		Else
			trayICO.Icon = My.Resources.icon
		End If
	End Sub

	Private Sub CopyRightLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CopyRightLabel.LinkClicked
		Process.Start("mailto: komar.yury@gmail.com")
	End Sub
End Class

