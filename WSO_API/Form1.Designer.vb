<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tmrOkta = New System.Windows.Forms.Timer(Me.components)
        Me.cmdMonitor = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpvIDM = New System.Windows.Forms.GroupBox()
        Me.cmdHCFix = New System.Windows.Forms.Button()
        Me.cmdRefreshIDM = New System.Windows.Forms.Button()
        Me.cmdDeleteIDM = New System.Windows.Forms.Button()
        Me.lstvIDM = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpOkta = New System.Windows.Forms.GroupBox()
        Me.cmdRefreshOkta = New System.Windows.Forms.Button()
        Me.cmdImporttoIDM = New System.Windows.Forms.Button()
        Me.lstOkta = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmdRefreshEvents = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstoktaevents = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtalertrecipients = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtsubjectprefix = New System.Windows.Forms.TextBox()
        Me.txtSendFrom = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.txtsmtpport = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtsmtppw = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsmtpuser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsmtpserver = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdSaveAPIToken = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmdgetsaml = New System.Windows.Forms.Button()
        Me.txtsamlmetadata = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtoktahash = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtoktaurl = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbSAMLAlgorithm = New System.Windows.Forms.ComboBox()
        Me.cmdSaveSS = New System.Windows.Forms.Button()
        Me.txtoauthaccesstoken = New System.Windows.Forms.TextBox()
        Me.txtoauthtoken = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtoauthss = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtoauthclient = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtidmserver = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusokta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrProcessEvents = New System.Windows.Forms.Timer(Me.components)
        Me.openSAMLxml = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpvIDM.SuspendLayout()
        Me.grpOkta.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrOkta
        '
        Me.tmrOkta.Interval = 10000
        '
        'cmdMonitor
        '
        Me.cmdMonitor.Location = New System.Drawing.Point(173, 499)
        Me.cmdMonitor.Name = "cmdMonitor"
        Me.cmdMonitor.Size = New System.Drawing.Size(294, 26)
        Me.cmdMonitor.TabIndex = 14
        Me.cmdMonitor.Text = "Start Monitoring Okta"
        Me.cmdMonitor.UseVisualStyleBackColor = True
        Me.cmdMonitor.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(637, 469)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.grpvIDM)
        Me.TabPage1.Controls.Add(Me.grpOkta)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(629, 443)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Applications"
        '
        'grpvIDM
        '
        Me.grpvIDM.Controls.Add(Me.cmdHCFix)
        Me.grpvIDM.Controls.Add(Me.cmdRefreshIDM)
        Me.grpvIDM.Controls.Add(Me.cmdDeleteIDM)
        Me.grpvIDM.Controls.Add(Me.lstvIDM)
        Me.grpvIDM.Location = New System.Drawing.Point(6, 6)
        Me.grpvIDM.Name = "grpvIDM"
        Me.grpvIDM.Size = New System.Drawing.Size(612, 206)
        Me.grpvIDM.TabIndex = 15
        Me.grpvIDM.TabStop = False
        Me.grpvIDM.Text = "Identity Manager Applications"
        '
        'cmdHCFix
        '
        Me.cmdHCFix.Location = New System.Drawing.Point(311, 176)
        Me.cmdHCFix.Name = "cmdHCFix"
        Me.cmdHCFix.Size = New System.Drawing.Size(155, 23)
        Me.cmdHCFix.TabIndex = 24
        Me.cmdHCFix.Text = "UPN Fix for Horizon Cloud"
        Me.cmdHCFix.UseVisualStyleBackColor = True
        Me.cmdHCFix.Visible = False
        '
        'cmdRefreshIDM
        '
        Me.cmdRefreshIDM.Location = New System.Drawing.Point(472, 174)
        Me.cmdRefreshIDM.Name = "cmdRefreshIDM"
        Me.cmdRefreshIDM.Size = New System.Drawing.Size(120, 25)
        Me.cmdRefreshIDM.TabIndex = 23
        Me.cmdRefreshIDM.Text = "Refresh IDM Apps"
        Me.cmdRefreshIDM.UseVisualStyleBackColor = True
        '
        'cmdDeleteIDM
        '
        Me.cmdDeleteIDM.Location = New System.Drawing.Point(10, 177)
        Me.cmdDeleteIDM.Name = "cmdDeleteIDM"
        Me.cmdDeleteIDM.Size = New System.Drawing.Size(154, 22)
        Me.cmdDeleteIDM.TabIndex = 20
        Me.cmdDeleteIDM.Text = "Delete Selected IDM Apps"
        Me.cmdDeleteIDM.UseVisualStyleBackColor = True
        '
        'lstvIDM
        '
        Me.lstvIDM.CheckBoxes = True
        Me.lstvIDM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstvIDM.GridLines = True
        Me.lstvIDM.Location = New System.Drawing.Point(10, 20)
        Me.lstvIDM.Name = "lstvIDM"
        Me.lstvIDM.Size = New System.Drawing.Size(586, 153)
        Me.lstvIDM.TabIndex = 17
        Me.lstvIDM.UseCompatibleStateImageBehavior = False
        Me.lstvIDM.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Label"
        Me.ColumnHeader5.Width = 350
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.Width = 0
        '
        'grpOkta
        '
        Me.grpOkta.Controls.Add(Me.cmdRefreshOkta)
        Me.grpOkta.Controls.Add(Me.cmdImporttoIDM)
        Me.grpOkta.Controls.Add(Me.lstOkta)
        Me.grpOkta.Location = New System.Drawing.Point(6, 220)
        Me.grpOkta.Name = "grpOkta"
        Me.grpOkta.Size = New System.Drawing.Size(612, 211)
        Me.grpOkta.TabIndex = 14
        Me.grpOkta.TabStop = False
        Me.grpOkta.Text = "Okta SAML Applications"
        '
        'cmdRefreshOkta
        '
        Me.cmdRefreshOkta.Location = New System.Drawing.Point(473, 176)
        Me.cmdRefreshOkta.Name = "cmdRefreshOkta"
        Me.cmdRefreshOkta.Size = New System.Drawing.Size(120, 25)
        Me.cmdRefreshOkta.TabIndex = 22
        Me.cmdRefreshOkta.Text = "Refresh Okta Apps"
        Me.cmdRefreshOkta.UseVisualStyleBackColor = True
        '
        'cmdImporttoIDM
        '
        Me.cmdImporttoIDM.Location = New System.Drawing.Point(10, 176)
        Me.cmdImporttoIDM.Name = "cmdImporttoIDM"
        Me.cmdImporttoIDM.Size = New System.Drawing.Size(200, 22)
        Me.cmdImporttoIDM.TabIndex = 21
        Me.cmdImporttoIDM.Text = "Import Selected Okta Apps to IDM"
        Me.cmdImporttoIDM.UseVisualStyleBackColor = True
        '
        'lstOkta
        '
        Me.lstOkta.CheckBoxes = True
        Me.lstOkta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader7})
        Me.lstOkta.GridLines = True
        Me.lstOkta.Location = New System.Drawing.Point(10, 20)
        Me.lstOkta.Name = "lstOkta"
        Me.lstOkta.Size = New System.Drawing.Size(583, 153)
        Me.lstOkta.TabIndex = 16
        Me.lstOkta.UseCompatibleStateImageBehavior = False
        Me.lstOkta.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Label"
        Me.ColumnHeader2.Width = 176
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "OktaURL"
        Me.ColumnHeader26.Width = 0
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "oktaicon"
        Me.ColumnHeader27.Width = 0
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "users"
        Me.ColumnHeader28.Width = 0
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "groups"
        Me.ColumnHeader7.Width = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.cmdRefreshEvents)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.lstoktaevents)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(629, 443)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Events"
        '
        'cmdRefreshEvents
        '
        Me.cmdRefreshEvents.Location = New System.Drawing.Point(503, 3)
        Me.cmdRefreshEvents.Name = "cmdRefreshEvents"
        Me.cmdRefreshEvents.Size = New System.Drawing.Size(120, 25)
        Me.cmdRefreshEvents.TabIndex = 24
        Me.cmdRefreshEvents.Text = "Refresh Events"
        Me.cmdRefreshEvents.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Recent Events"
        '
        'lstoktaevents
        '
        Me.lstoktaevents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader8})
        Me.lstoktaevents.GridLines = True
        Me.lstoktaevents.Location = New System.Drawing.Point(6, 31)
        Me.lstoktaevents.Name = "lstoktaevents"
        Me.lstoktaevents.Size = New System.Drawing.Size(617, 385)
        Me.lstoktaevents.TabIndex = 18
        Me.lstoktaevents.UseCompatibleStateImageBehavior = False
        Me.lstoktaevents.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Level"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Date/Time"
        Me.ColumnHeader10.Width = 130
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Description"
        Me.ColumnHeader8.Width = 373
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(629, 443)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtalertrecipients)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtsubjectprefix)
        Me.GroupBox1.Controls.Add(Me.txtSendFrom)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.txtsmtpport)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtsmtppw)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsmtpuser)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtsmtpserver)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(8, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 205)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Email Settings - *Future Feature*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(171, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Separate addresses with a Comma"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(41, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Alert Recipients:"
        '
        'txtalertrecipients
        '
        Me.txtalertrecipients.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalertrecipients.Location = New System.Drawing.Point(128, 123)
        Me.txtalertrecipients.Multiline = True
        Me.txtalertrecipients.Name = "txtalertrecipients"
        Me.txtalertrecipients.Size = New System.Drawing.Size(266, 57)
        Me.txtalertrecipients.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(45, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Subject Prefix:"
        '
        'txtsubjectprefix
        '
        Me.txtsubjectprefix.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubjectprefix.Location = New System.Drawing.Point(128, 97)
        Me.txtsubjectprefix.Name = "txtsubjectprefix"
        Me.txtsubjectprefix.Size = New System.Drawing.Size(266, 21)
        Me.txtsubjectprefix.TabIndex = 24
        '
        'txtSendFrom
        '
        Me.txtSendFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSendFrom.Location = New System.Drawing.Point(128, 71)
        Me.txtSendFrom.Name = "txtSendFrom"
        Me.txtSendFrom.Size = New System.Drawing.Size(266, 21)
        Me.txtSendFrom.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(61, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Send From:"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(407, 21)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(118, 17)
        Me.CheckBox4.TabIndex = 21
        Me.CheckBox4.Text = "Use TLS Encryption"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'txtsmtpport
        '
        Me.txtsmtpport.Location = New System.Drawing.Point(347, 20)
        Me.txtsmtpport.Name = "txtsmtpport"
        Me.txtsmtpport.Size = New System.Drawing.Size(47, 21)
        Me.txtsmtpport.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(314, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Port:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(407, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 29)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Send Test Email"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtsmtppw
        '
        Me.txtsmtppw.Location = New System.Drawing.Point(265, 46)
        Me.txtsmtppw.Name = "txtsmtppw"
        Me.txtsmtppw.Size = New System.Drawing.Size(129, 21)
        Me.txtsmtppw.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "PW:"
        '
        'txtsmtpuser
        '
        Me.txtsmtpuser.Location = New System.Drawing.Point(128, 45)
        Me.txtsmtpuser.Name = "txtsmtpuser"
        Me.txtsmtpuser.Size = New System.Drawing.Size(106, 21)
        Me.txtsmtpuser.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "SMTP Server:"
        '
        'txtsmtpserver
        '
        Me.txtsmtpserver.Location = New System.Drawing.Point(128, 19)
        Me.txtsmtpserver.Name = "txtsmtpserver"
        Me.txtsmtpserver.Size = New System.Drawing.Size(180, 21)
        Me.txtsmtpserver.TabIndex = 12
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdSaveAPIToken)
        Me.GroupBox4.Controls.Add(Me.CheckBox3)
        Me.GroupBox4.Controls.Add(Me.CheckBox2)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Controls.Add(Me.cmdgetsaml)
        Me.GroupBox4.Controls.Add(Me.txtsamlmetadata)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtoktahash)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtoktaurl)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(612, 108)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Okta"
        '
        'cmdSaveAPIToken
        '
        Me.cmdSaveAPIToken.Location = New System.Drawing.Point(400, 44)
        Me.cmdSaveAPIToken.Name = "cmdSaveAPIToken"
        Me.cmdSaveAPIToken.Size = New System.Drawing.Size(127, 23)
        Me.cmdSaveAPIToken.TabIndex = 25
        Me.cmdSaveAPIToken.Text = "Save API Token"
        Me.cmdSaveAPIToken.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(461, 64)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(146, 17)
        Me.CheckBox3.TabIndex = 24
        Me.CheckBox3.Text = "Sync Entitlements to IDM"
        Me.CheckBox3.UseVisualStyleBackColor = True
        Me.CheckBox3.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(461, 41)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(151, 17)
        Me.CheckBox2.TabIndex = 23
        Me.CheckBox2.Text = "Sync Weblink Apps to IDM"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(462, 18)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(140, 17)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.Text = "Sync SAML Apps to IDM"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'cmdgetsaml
        '
        Me.cmdgetsaml.Location = New System.Drawing.Point(355, 71)
        Me.cmdgetsaml.Name = "cmdgetsaml"
        Me.cmdgetsaml.Size = New System.Drawing.Size(39, 23)
        Me.cmdgetsaml.TabIndex = 21
        Me.cmdgetsaml.Text = "..."
        Me.cmdgetsaml.UseVisualStyleBackColor = True
        '
        'txtsamlmetadata
        '
        Me.txtsamlmetadata.Location = New System.Drawing.Point(128, 73)
        Me.txtsamlmetadata.Name = "txtsamlmetadata"
        Me.txtsamlmetadata.Size = New System.Drawing.Size(221, 21)
        Me.txtsamlmetadata.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "SAML Metadata:"
        '
        'txtoktahash
        '
        Me.txtoktahash.Location = New System.Drawing.Point(128, 46)
        Me.txtoktahash.Name = "txtoktahash"
        Me.txtoktahash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoktahash.Size = New System.Drawing.Size(266, 21)
        Me.txtoktahash.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Okta API Token:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Okta Address:"
        '
        'txtoktaurl
        '
        Me.txtoktaurl.Location = New System.Drawing.Point(128, 19)
        Me.txtoktaurl.Name = "txtoktaurl"
        Me.txtoktaurl.Size = New System.Drawing.Size(266, 21)
        Me.txtoktaurl.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.cmbSAMLAlgorithm)
        Me.GroupBox3.Controls.Add(Me.cmdSaveSS)
        Me.GroupBox3.Controls.Add(Me.txtoauthaccesstoken)
        Me.GroupBox3.Controls.Add(Me.txtoauthtoken)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtoauthss)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtoauthclient)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtidmserver)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(612, 112)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Identity Manager"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(442, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "SAML Encryption:"
        '
        'cmbSAMLAlgorithm
        '
        Me.cmbSAMLAlgorithm.DisplayMember = "True"
        Me.cmbSAMLAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSAMLAlgorithm.FormattingEnabled = True
        Me.cmbSAMLAlgorithm.Items.AddRange(New Object() {"SHA1", "SHA256"})
        Me.cmbSAMLAlgorithm.Location = New System.Drawing.Point(535, 26)
        Me.cmbSAMLAlgorithm.MaxDropDownItems = 2
        Me.cmbSAMLAlgorithm.Name = "cmbSAMLAlgorithm"
        Me.cmbSAMLAlgorithm.Size = New System.Drawing.Size(69, 21)
        Me.cmbSAMLAlgorithm.Sorted = True
        Me.cmbSAMLAlgorithm.TabIndex = 21
        '
        'cmdSaveSS
        '
        Me.cmdSaveSS.Location = New System.Drawing.Point(400, 79)
        Me.cmdSaveSS.Name = "cmdSaveSS"
        Me.cmdSaveSS.Size = New System.Drawing.Size(127, 23)
        Me.cmdSaveSS.TabIndex = 20
        Me.cmdSaveSS.Text = "Save Shared Secret"
        Me.cmdSaveSS.UseVisualStyleBackColor = True
        '
        'txtoauthaccesstoken
        '
        Me.txtoauthaccesstoken.Location = New System.Drawing.Point(463, 83)
        Me.txtoauthaccesstoken.Name = "txtoauthaccesstoken"
        Me.txtoauthaccesstoken.Size = New System.Drawing.Size(141, 21)
        Me.txtoauthaccesstoken.TabIndex = 19
        '
        'txtoauthtoken
        '
        Me.txtoauthtoken.Location = New System.Drawing.Point(409, 56)
        Me.txtoauthtoken.Name = "txtoauthtoken"
        Me.txtoauthtoken.Size = New System.Drawing.Size(195, 21)
        Me.txtoauthtoken.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "oAuth2 Shared Secret:"
        '
        'txtoauthss
        '
        Me.txtoauthss.Location = New System.Drawing.Point(130, 79)
        Me.txtoauthss.Name = "txtoauthss"
        Me.txtoauthss.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoauthss.Size = New System.Drawing.Size(264, 21)
        Me.txtoauthss.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "oAuth2 ClientID:"
        '
        'txtoauthclient
        '
        Me.txtoauthclient.Location = New System.Drawing.Point(130, 53)
        Me.txtoauthclient.Name = "txtoauthclient"
        Me.txtoauthclient.Size = New System.Drawing.Size(264, 21)
        Me.txtoauthclient.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "IDM Address:"
        '
        'txtidmserver
        '
        Me.txtidmserver.Location = New System.Drawing.Point(130, 26)
        Me.txtidmserver.Name = "txtidmserver"
        Me.txtidmserver.Size = New System.Drawing.Size(264, 21)
        Me.txtidmserver.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusokta})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 497)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(765, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusokta
        '
        Me.statusokta.Name = "statusokta"
        Me.statusokta.Size = New System.Drawing.Size(0, 17)
        '
        'tmrProcessEvents
        '
        Me.tmrProcessEvents.Interval = 10000
        '
        'openSAMLxml
        '
        Me.openSAMLxml.Filter = "XML Files|*.xml"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(765, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStripMain"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 519)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdMonitor)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VMware Identity Manager to Okta Service Bridge"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpvIDM.ResumeLayout(False)
        Me.grpOkta.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrOkta As Timer
    Friend WithEvents cmdMonitor As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents grpvIDM As GroupBox
    Friend WithEvents lstvIDM As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents grpOkta As GroupBox
    Friend WithEvents lstOkta As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusokta As ToolStripStatusLabel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lstoktaevents As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents tmrProcessEvents As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents ColumnHeader26 As ColumnHeader
    Friend WithEvents ColumnHeader27 As ColumnHeader
    Friend WithEvents cmdDeleteIDM As Button
    Friend WithEvents cmdImporttoIDM As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtoktahash As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtoktaurl As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtoauthaccesstoken As TextBox
    Friend WithEvents txtoauthtoken As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtoauthss As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtoauthclient As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtidmserver As TextBox
    Friend WithEvents cmdRefreshOkta As Button
    Friend WithEvents cmdRefreshIDM As Button
    Friend WithEvents ColumnHeader28 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtsmtppw As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsmtpuser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsmtpserver As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmdgetsaml As Button
    Friend WithEvents txtsamlmetadata As TextBox
    Friend WithEvents openSAMLxml As OpenFileDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents txtsmtpport As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Label13 As Label
    Friend WithEvents txtsubjectprefix As TextBox
    Friend WithEvents txtSendFrom As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtalertrecipients As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdSaveAPIToken As Button
    Friend WithEvents cmdSaveSS As Button
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents cmdRefreshEvents As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbSAMLAlgorithm As ComboBox
    Friend WithEvents cmdHCFix As Button
End Class
