<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowser
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SteamTheme1 = New BDOHelper.SteamTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SteamTheme1.SuspendLayout
        Me.SuspendLayout
        '
        'SteamTheme1
        '
        Me.SteamTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SteamTheme1.Colors = New BDOHelper.Bloom(-1) {}
        Me.SteamTheme1.Controls.Add(Me.Label1)
        Me.SteamTheme1.Controls.Add(Me.WebBrowser1)
        Me.SteamTheme1.Customization = ""
        Me.SteamTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SteamTheme1.Font = New System.Drawing.Font("Segoe UI", 7!)
        Me.SteamTheme1.Image = Nothing
        Me.SteamTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SteamTheme1.Movable = true
        Me.SteamTheme1.Name = "SteamTheme1"
        Me.SteamTheme1.NoRounding = false
        Me.SteamTheme1.Sizable = true
        Me.SteamTheme1.Size = New System.Drawing.Size(1082, 799)
        Me.SteamTheme1.SmartBounds = true
        Me.SteamTheme1.TabIndex = 0
        Me.SteamTheme1.Text = "Browser"
        Me.SteamTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.SteamTheme1.Transparent = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1051, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 33)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = true
        Me.WebBrowser1.Size = New System.Drawing.Size(1058, 754)
        Me.WebBrowser1.TabIndex = 0
        '
        'frmBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 799)
        Me.Controls.Add(Me.SteamTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBrowser"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBrowser"
        Me.SteamTheme1.ResumeLayout(false)
        Me.SteamTheme1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents SteamTheme1 As SteamTheme
    Friend WithEvents Label1 As Label
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
