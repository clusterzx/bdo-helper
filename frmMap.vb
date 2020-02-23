Imports CefSharp
Imports CefSharp.WinForms
Public Class frmMap
    Public Shared Dim browser As ChromiumWebBrowser
    Private Sub frmMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitBrowser()
    End Sub
    Public Sub InitBrowser()
        CefSharp.Cef.Initialize(New CefSettings())
        browser = New ChromiumWebBrowser("http://www.somethinglovely.net/bdo/")
        Me.Controls.Add(browser)
        browser.Dock = DockStyle.Fill
    End Sub
End Class