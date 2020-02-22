Public Class frmBrowser
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close
    End Sub

    Private Sub frmBrowser_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True
        Dim uri As New Uri(Form1.currentUrl)
        WebBrowser1.Navigate(uri)
    End Sub
End Class