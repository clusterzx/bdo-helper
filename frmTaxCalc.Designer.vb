<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaxCalc
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
        Me.SteamSeparator1 = New BDOHelper.SteamSeparator()
        Me.SteamButton1 = New BDOHelper.SteamButton()
        Me.pbMove = New System.Windows.Forms.PictureBox()
        Me.SteamTextBox2 = New BDOHelper.SteamTextBox()
        Me.lblWithoutVP = New System.Windows.Forms.Label()
        Me.lblWithVP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCalc = New BDOHelper.SteamButton()
        CType(Me.pbMove,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'SteamSeparator1
        '
        Me.SteamSeparator1.Colors = New BDOHelper.Bloom(-1) {}
        Me.SteamSeparator1.Customization = ""
        Me.SteamSeparator1.Font = New System.Drawing.Font("Verdana", 8!)
        Me.SteamSeparator1.Image = Nothing
        Me.SteamSeparator1.Location = New System.Drawing.Point(0, 207)
        Me.SteamSeparator1.Name = "SteamSeparator1"
        Me.SteamSeparator1.NoRounding = false
        Me.SteamSeparator1.Size = New System.Drawing.Size(374, 10)
        Me.SteamSeparator1.TabIndex = 13
        Me.SteamSeparator1.Text = "SteamSeparator1"
        Me.SteamSeparator1.Transparent = false
        '
        'SteamButton1
        '
        Me.SteamButton1.Activated = BDOHelper.SteamButton._Options._true
        Me.SteamButton1.Colors = New BDOHelper.Bloom(-1) {}
        Me.SteamButton1.Customization = ""
        Me.SteamButton1.Enabled = false
        Me.SteamButton1.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.SteamButton1.Image = Nothing
        Me.SteamButton1.Location = New System.Drawing.Point(0, 41)
        Me.SteamButton1.Name = "SteamButton1"
        Me.SteamButton1.NoRounding = false
        Me.SteamButton1.Size = New System.Drawing.Size(373, 176)
        Me.SteamButton1.TabIndex = 12
        Me.SteamButton1.Transparent = false
        '
        'pbMove
        '
        Me.pbMove.BackColor = System.Drawing.Color.Transparent
        Me.pbMove.BackgroundImage = Global.BDOHelper.My.Resources.Resources.BDOUi
        Me.pbMove.Location = New System.Drawing.Point(0, 0)
        Me.pbMove.Name = "pbMove"
        Me.pbMove.Size = New System.Drawing.Size(373, 41)
        Me.pbMove.TabIndex = 16
        Me.pbMove.TabStop = false
        '
        'SteamTextBox2
        '
        Me.SteamTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.SteamTextBox2.Colors = New BDOHelper.Bloom(-1) {}
        Me.SteamTextBox2.Customization = ""
        Me.SteamTextBox2.Font = New System.Drawing.Font("Verdana", 8!)
        Me.SteamTextBox2.Image = Nothing
        Me.SteamTextBox2.Location = New System.Drawing.Point(87, 84)
        Me.SteamTextBox2.MaxCharacters = 0
        Me.SteamTextBox2.Name = "SteamTextBox2"
        Me.SteamTextBox2.NoRounding = false
        Me.SteamTextBox2.Size = New System.Drawing.Size(192, 22)
        Me.SteamTextBox2.TabIndex = 17
        Me.SteamTextBox2.Transparent = true
        Me.SteamTextBox2.UsePasswordMask = false
        '
        'lblWithoutVP
        '
        Me.lblWithoutVP.BackColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.lblWithoutVP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblWithoutVP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.lblWithoutVP.Location = New System.Drawing.Point(8, 139)
        Me.lblWithoutVP.Name = "lblWithoutVP"
        Me.lblWithoutVP.Size = New System.Drawing.Size(360, 18)
        Me.lblWithoutVP.TabIndex = 19
        Me.lblWithoutVP.Text = "Without Value Pack:"
        '
        'lblWithVP
        '
        Me.lblWithVP.BackColor = System.Drawing.Color.FromArgb(CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer), CType(CType(75,Byte),Integer))
        Me.lblWithVP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblWithVP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.lblWithVP.Location = New System.Drawing.Point(8, 157)
        Me.lblWithVP.Name = "lblWithVP"
        Me.lblWithVP.Size = New System.Drawing.Size(360, 18)
        Me.lblWithVP.TabIndex = 20
        Me.lblWithVP.Text = "With Value Pack:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43,Byte),Integer), CType(CType(44,Byte),Integer), CType(CType(49,Byte),Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Label2.Location = New System.Drawing.Point(80, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Market Tax Calculator"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43,Byte),Integer), CType(CType(44,Byte),Integer), CType(CType(49,Byte),Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(343, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "X"
        '
        'cmdCalc
        '
        Me.cmdCalc.Activated = BDOHelper.SteamButton._Options._true
        Me.cmdCalc.Colors = New BDOHelper.Bloom(-1) {}
        Me.cmdCalc.Customization = ""
        Me.cmdCalc.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.cmdCalc.Image = Nothing
        Me.cmdCalc.Location = New System.Drawing.Point(11, 180)
        Me.cmdCalc.Name = "cmdCalc"
        Me.cmdCalc.NoRounding = false
        Me.cmdCalc.Size = New System.Drawing.Size(357, 21)
        Me.cmdCalc.TabIndex = 23
        Me.cmdCalc.Text = "                                         Calculate"
        Me.cmdCalc.Transparent = false
        '
        'frmTaxCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 217)
        Me.Controls.Add(Me.cmdCalc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblWithVP)
        Me.Controls.Add(Me.lblWithoutVP)
        Me.Controls.Add(Me.SteamTextBox2)
        Me.Controls.Add(Me.SteamSeparator1)
        Me.Controls.Add(Me.SteamButton1)
        Me.Controls.Add(Me.pbMove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTaxCalc"
        Me.Text = "frmTaxCalc"
        CType(Me.pbMove,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents pbMove As PictureBox
    Friend WithEvents SteamSeparator1 As SteamSeparator
    Friend WithEvents SteamButton1 As SteamButton
    Friend WithEvents SteamTextBox2 As SteamTextBox
    Friend WithEvents lblWithoutVP As Label
    Friend WithEvents lblWithVP As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdCalc As SteamButton
End Class
