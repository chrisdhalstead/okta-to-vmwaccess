Imports System.Windows.Forms

Public Class dlgCert

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub lblWarningText_Click(sender As Object, e As EventArgs) Handles lblWarningText.Click

    End Sub

    Private Sub dlgCert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblWarningText.Text = "WARNING: The certificate on server is not trusted. If you trust this server, click ACCEPT to continue and save an exception.  If you don't trust this server Click CANCEL"

    End Sub
End Class
