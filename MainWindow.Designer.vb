<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Является обязательной для конструктора форм Windows Forms
	Private components As System.ComponentModel.IContainer

	'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
	'Для ее изменения используйте конструктор форм Windows Form.  
	'Не изменяйте ее в редакторе исходного кода.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
		Me.trayICO = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.TrayMENU = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ОткрытьWhatsAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SwWEB = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.НастрокиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Button1 = New System.Windows.Forms.Button()
		Me.set_2 = New System.Windows.Forms.CheckBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.set_3 = New System.Windows.Forms.CheckBox()
		Me.set_1 = New System.Windows.Forms.CheckBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.AnimIcon = New System.Windows.Forms.Timer(Me.components)
		Me.Label6 = New System.Windows.Forms.Label()
		Me.CopyRightLabel = New System.Windows.Forms.LinkLabel()
		Me.TrayMENU.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'trayICO
		'
		Me.trayICO.BalloonTipText = "WhatsApp Agent"
		Me.trayICO.BalloonTipTitle = "WhatsApp Agent"
		Me.trayICO.ContextMenuStrip = Me.TrayMENU
		Me.trayICO.Text = "NotifyIcon1"
		'
		'TrayMENU
		'
		Me.TrayMENU.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОткрытьWhatsAppToolStripMenuItem, Me.SwWEB, Me.ToolStripSeparator1, Me.НастрокиToolStripMenuItem, Me.ToolStripMenuItem2})
		Me.TrayMENU.Name = "TrayMENU"
		Me.TrayMENU.ShowImageMargin = False
		Me.TrayMENU.ShowItemToolTips = False
		Me.TrayMENU.Size = New System.Drawing.Size(160, 98)
		'
		'ОткрытьWhatsAppToolStripMenuItem
		'
		Me.ОткрытьWhatsAppToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
		Me.ОткрытьWhatsAppToolStripMenuItem.Name = "ОткрытьWhatsAppToolStripMenuItem"
		Me.ОткрытьWhatsAppToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
		Me.ОткрытьWhatsAppToolStripMenuItem.Text = "Открыть WhatsApp"
		'
		'SwWEB
		'
		Me.SwWEB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
		Me.SwWEB.Name = "SwWEB"
		Me.SwWEB.Size = New System.Drawing.Size(159, 22)
		Me.SwWEB.Text = "Скрыть WhatsApp"
		Me.SwWEB.Visible = False
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(156, 6)
		'
		'НастрокиToolStripMenuItem
		'
		Me.НастрокиToolStripMenuItem.Name = "НастрокиToolStripMenuItem"
		Me.НастрокиToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
		Me.НастрокиToolStripMenuItem.Text = "Настройки"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(159, 22)
		Me.ToolStripMenuItem2.Text = "ВЫХОД"
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 10
		'
		'Button1
		'
		Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Button1.Location = New System.Drawing.Point(356, 183)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(61, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Скрыть"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'set_2
		'
		Me.set_2.AutoSize = True
		Me.set_2.BackColor = System.Drawing.Color.Transparent
		Me.set_2.Location = New System.Drawing.Point(6, 42)
		Me.set_2.Name = "set_2"
		Me.set_2.Size = New System.Drawing.Size(272, 17)
		Me.set_2.TabIndex = 2
		Me.set_2.Text = "Закрывать окно WhatsApp при закрытии агента"
		Me.set_2.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.MediumSeaGreen
		Me.Label1.Location = New System.Drawing.Point(287, 28)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(135, 24)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "НАСТРОЙКИ"
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox1.Controls.Add(Me.set_3)
		Me.GroupBox1.Controls.Add(Me.set_1)
		Me.GroupBox1.Controls.Add(Me.set_2)
		Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.GroupBox1.Location = New System.Drawing.Point(12, 119)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(328, 87)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Общие настройки"
		'
		'set_3
		'
		Me.set_3.AutoSize = True
		Me.set_3.Location = New System.Drawing.Point(6, 65)
		Me.set_3.Name = "set_3"
		Me.set_3.Size = New System.Drawing.Size(153, 17)
		Me.set_3.TabIndex = 4
		Me.set_3.Text = "Сворачивать окно в трей"
		Me.set_3.UseVisualStyleBackColor = True
		'
		'set_1
		'
		Me.set_1.AutoSize = True
		Me.set_1.Location = New System.Drawing.Point(6, 19)
		Me.set_1.Name = "set_1"
		Me.set_1.Size = New System.Drawing.Size(257, 17)
		Me.set_1.TabIndex = 3
		Me.set_1.Text = "Открывать окно WhatsApp при старте агента"
		Me.set_1.UseVisualStyleBackColor = True
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel1.BackColor = System.Drawing.SystemColors.Control
		Me.Panel1.Controls.Add(Me.CopyRightLabel)
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Controls.Add(Me.Label6)
		Me.Panel1.Location = New System.Drawing.Point(433, 15)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(0, 199)
		Me.Panel1.TabIndex = 9
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(-124, 66)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(250, 97)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = resources.GetString("Label4.Text")
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label5
		'
		Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.Black
		Me.Label5.Location = New System.Drawing.Point(-127, 13)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(64, 17)
		Me.Label5.TabIndex = 2
		Me.Label5.Text = "Версия: "
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.Transparent
		Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button4.ForeColor = System.Drawing.Color.Blue
		Me.Button4.Location = New System.Drawing.Point(418, 100)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(15, 27)
		Me.Button4.TabIndex = 10
		Me.Button4.Text = "?"
		Me.ToolTip1.SetToolTip(Me.Button4, "О Программе...")
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Timer3
		'
		Me.Timer3.Interval = 10
		'
		'AnimIcon
		'
		Me.AnimIcon.Interval = 500
		'
		'Label6
		'
		Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.Red
		Me.Label6.Location = New System.Drawing.Point(-127, 37)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(176, 17)
		Me.Label6.TabIndex = 2
		Me.Label6.Text = "Лицензия: FREEWARE"
		'
		'CopyRightLabel
		'
		Me.CopyRightLabel.ActiveLinkColor = System.Drawing.Color.Blue
		Me.CopyRightLabel.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.CopyRightLabel.AutoSize = True
		Me.CopyRightLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.CopyRightLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
		Me.CopyRightLabel.Location = New System.Drawing.Point(-127, 178)
		Me.CopyRightLabel.Name = "CopyRightLabel"
		Me.CopyRightLabel.Size = New System.Drawing.Size(70, 14)
		Me.CopyRightLabel.TabIndex = 3
		Me.CopyRightLabel.TabStop = True
		Me.CopyRightLabel.Text = "Copyright ©"
		Me.ToolTip1.SetToolTip(Me.CopyRightLabel, "Отправить автору письмо")
		Me.CopyRightLabel.VisitedLinkColor = System.Drawing.Color.Blue
		'
		'MainWindow
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Honeydew
		Me.BackgroundImage = Global.WhatsAppAgent.My.Resources.Resources.gift_box_landscape
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(433, 221)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(700, 221)
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(433, 221)
		Me.Name = "MainWindow"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "WhatsApp Agent (by Komar Yury)"
		Me.TopMost = True
		Me.TrayMENU.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents prcArgs As System.Windows.Forms.TextBox
	Friend WithEvents trayICO As System.Windows.Forms.NotifyIcon
	Friend WithEvents TrayMENU As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents SwWEB As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ОткрытьWhatsAppToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents НастрокиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents set_2 As System.Windows.Forms.CheckBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents Timer1 As System.Windows.Forms.Timer
	Friend WithEvents set_1 As System.Windows.Forms.CheckBox
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents Button4 As System.Windows.Forms.Button
	Friend WithEvents Timer3 As System.Windows.Forms.Timer
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents set_3 As CheckBox
	Friend WithEvents AnimIcon As Timer
	Friend WithEvents Label6 As Label
	Friend WithEvents CopyRightLabel As LinkLabel
End Class
