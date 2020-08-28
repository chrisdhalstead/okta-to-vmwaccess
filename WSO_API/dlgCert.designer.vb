<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCert
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgCert))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lblWarningText = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl256fp = New System.Windows.Forms.Label()
        Me.lblvalidfrom = New System.Windows.Forms.Label()
        Me.lblIssuedBy = New System.Windows.Forms.Label()
        Me.lblsn = New System.Windows.Forms.Label()
        Me.lblIssuedto = New System.Windows.Forms.Label()
        Me.lblCertError = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(439, 225)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Accept"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'lblWarningText
        '
        Me.lblWarningText.Location = New System.Drawing.Point(11, 12)
        Me.lblWarningText.Name = "lblWarningText"
        Me.lblWarningText.Size = New System.Drawing.Size(571, 31)
        Me.lblWarningText.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl256fp)
        Me.GroupBox1.Controls.Add(Me.lblvalidfrom)
        Me.GroupBox1.Controls.Add(Me.lblIssuedBy)
        Me.GroupBox1.Controls.Add(Me.lblsn)
        Me.GroupBox1.Controls.Add(Me.lblIssuedto)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 146)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Certificate Details:"
        '
        'lbl256fp
        '
        Me.lbl256fp.AutoSize = True
        Me.lbl256fp.Location = New System.Drawing.Point(15, 118)
        Me.lbl256fp.Name = "lbl256fp"
        Me.lbl256fp.Size = New System.Drawing.Size(108, 13)
        Me.lbl256fp.TabIndex = 4
        Me.lbl256fp.Text = "SHA-256 Fingerprint:"
        '
        'lblvalidfrom
        '
        Me.lblvalidfrom.AutoSize = True
        Me.lblvalidfrom.Location = New System.Drawing.Point(15, 95)
        Me.lblvalidfrom.Name = "lblvalidfrom"
        Me.lblvalidfrom.Size = New System.Drawing.Size(60, 13)
        Me.lblvalidfrom.TabIndex = 3
        Me.lblvalidfrom.Text = "Valid From:"
        '
        'lblIssuedBy
        '
        Me.lblIssuedBy.AutoSize = True
        Me.lblIssuedBy.Location = New System.Drawing.Point(15, 72)
        Me.lblIssuedBy.Name = "lblIssuedBy"
        Me.lblIssuedBy.Size = New System.Drawing.Size(58, 13)
        Me.lblIssuedBy.TabIndex = 2
        Me.lblIssuedBy.Text = "Issued By:"
        '
        'lblsn
        '
        Me.lblsn.AutoSize = True
        Me.lblsn.Location = New System.Drawing.Point(15, 49)
        Me.lblsn.Name = "lblsn"
        Me.lblsn.Size = New System.Drawing.Size(77, 13)
        Me.lblsn.TabIndex = 1
        Me.lblsn.Text = "Serial Number:"
        '
        'lblIssuedto
        '
        Me.lblIssuedto.AutoSize = True
        Me.lblIssuedto.Location = New System.Drawing.Point(15, 26)
        Me.lblIssuedto.Name = "lblIssuedto"
        Me.lblIssuedto.Size = New System.Drawing.Size(56, 13)
        Me.lblIssuedto.TabIndex = 0
        Me.lblIssuedto.Text = "Issued to:"
        '
        'lblCertError
        '
        Me.lblCertError.Location = New System.Drawing.Point(11, 48)
        Me.lblCertError.Name = "lblCertError"
        Me.lblCertError.Size = New System.Drawing.Size(571, 19)
        Me.lblCertError.TabIndex = 3
        '
        'dlgCert
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(597, 266)
        Me.Controls.Add(Me.lblCertError)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblWarningText)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCert"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Certificate Not Trusted"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblWarningText As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl256fp As System.Windows.Forms.Label
    Friend WithEvents lblvalidfrom As System.Windows.Forms.Label
    Friend WithEvents lblIssuedBy As System.Windows.Forms.Label
    Friend WithEvents lblsn As System.Windows.Forms.Label
    Friend WithEvents lblIssuedto As System.Windows.Forms.Label
    Friend WithEvents lblCertError As System.Windows.Forms.Label

End Class
