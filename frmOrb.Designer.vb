<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrb
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCheckOff = New System.Windows.Forms.Timer(Me.components)
        Me.tmrForeground = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SteamButton1 = New BDOHelper.SteamButton()
        Me.SuspendLayout
        '
        'tmrCheck
        '
        Me.tmrCheck.Enabled = true
        Me.tmrCheck.Interval = 1000
        '
        'tmrCheckOff
        '
        Me.tmrCheckOff.Interval = 1000
        '
        'tmrForeground
        '
        Me.tmrForeground.Interval = 1000
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = true
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(1, 49)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(71, 13)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Not running..."
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(0, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BDO-Helper"
        '
        'SteamButton1
        '
        Me.SteamButton1.Activated = BDOHelper.SteamButton._Options._true
        Me.SteamButton1.Colors = New BDOHelper.Bloom(-1) {}
        Me.SteamButton1.Customization = ""
        Me.SteamButton1.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.SteamButton1.Image = Nothing
        Me.SteamButton1.Location = New System.Drawing.Point(7, 25)
        Me.SteamButton1.Name = "SteamButton1"
        Me.SteamButton1.NoRounding = false
        Me.SteamButton1.Size = New System.Drawing.Size(60, 18)
        Me.SteamButton1.TabIndex = 3
        Me.SteamButton1.Text = "   Open"
        Me.SteamButton1.Transparent = false
        '
        'frmOrb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(79, 64)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SteamButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOrb"
        Me.Opacity = 0.9R
        Me.Text = "frmOrb"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents tmrCheck As Timer
    Friend WithEvents tmrCheckOff As Timer
    Friend WithEvents tmrForeground As Timer
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SteamButton1 As SteamButton
    Friend WithEvents Label2 As Label
End Class
