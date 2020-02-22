<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbMove = New System.Windows.Forms.PictureBox()
        Me.lvSearchResults = New System.Windows.Forms.ListView()
        Me.colIcon = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.imgIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.txtItem = New BDOHelper.SteamTextBox()
        Me.SteamTextBox1 = New BDOHelper.SteamTextBox()
        Me.SteamSeparator1 = New BDOHelper.SteamSeparator()
        Me.SteamButton1 = New BDOHelper.SteamButton()
        Me.cmdSearch = New BDOHelper.SteamButton()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbMove,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(555, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 19)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = false
        '
        'pbMove
        '
        Me.pbMove.BackColor = System.Drawing.Color.Transparent
        Me.pbMove.Location = New System.Drawing.Point(3, 4)
        Me.pbMove.Name = "pbMove"
        Me.pbMove.Size = New System.Drawing.Size(546, 41)
        Me.pbMove.TabIndex = 4
        Me.pbMove.TabStop = false
        '
        'lvSearchResults
        '
        Me.lvSearchResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.lvSearchResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colIcon, Me.colName, Me.colID})
        Me.lvSearchResults.ForeColor = System.Drawing.Color.White
        Me.lvSearchResults.HideSelection = false
        Me.lvSearchResults.Location = New System.Drawing.Point(11, 128)
        Me.lvSearchResults.Name = "lvSearchResults"
        Me.lvSearchResults.Size = New System.Drawing.Size(568, 193)
        Me.lvSearchResults.SmallImageList = Me.imgIcons
        Me.lvSearchResults.TabIndex = 5
        Me.lvSearchResults.UseCompatibleStateImageBehavior = false
        '
        'colIcon
        '
        Me.colIcon.Text = "Icon"
        '
        'colName
        '
        Me.colName.Text = "Item Name"
        Me.colName.Width = 300
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'imgIcons
        '
        Me.imgIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imgIcons.ImageSize = New System.Drawing.Size(48, 48)
        Me.imgIcons.TransparentColor = System.Drawing.Color.Transparent
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.Transparent
        Me.txtItem.Colors = New BDOHelper.Bloom(-1) {}
        Me.txtItem.Customization = ""
        Me.txtItem.Font = New System.Drawing.Font("Verdana", 8!)
        Me.txtItem.Image = Nothing
        Me.txtItem.Location = New System.Drawing.Point(12, 100)
        Me.txtItem.MaxCharacters = 0
        Me.txtItem.Name = "txtItem"
        Me.txtItem.NoRounding = false
        Me.txtItem.Size = New System.Drawing.Size(161, 22)
        Me.txtItem.TabIndex = 6
        Me.txtItem.Text = "Item Name"
        Me.txtItem.Transparent = true
        Me.txtItem.UsePasswordMask = false
        '
        'SteamTextBox1
        '
        Me.SteamTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.SteamTextBox1.Colors = New BDOHelper.Bloom(-1) {}
        Me.SteamTextBox1.Customization = ""
        Me.SteamTextBox1.Enabled = false
        Me.SteamTextBox1.Font = New System.Drawing.Font("Verdana", 8!)
        Me.SteamTextBox1.Image = Nothing
        Me.SteamTextBox1.Location = New System.Drawing.Point(220, 13)
        Me.SteamTextBox1.MaxCharacters = 0
        Me.SteamTextBox1.Name = "SteamTextBox1"
        Me.SteamTextBox1.NoRounding = false
        Me.SteamTextBox1.Size = New System.Drawing.Size(156, 22)
        Me.SteamTextBox1.TabIndex = 2
        Me.SteamTextBox1.Text = "BDO-Helper (by Clusterz)"
        Me.SteamTextBox1.Transparent = true
        Me.SteamTextBox1.UsePasswordMask = false
        '
        'SteamSeparator1
        '
        Me.SteamSeparator1.Colors = New BDOHelper.Bloom(-1) {}
        Me.SteamSeparator1.Customization = ""
        Me.SteamSeparator1.Font = New System.Drawing.Font("Verdana", 8!)
        Me.SteamSeparator1.Image = Nothing
        Me.SteamSeparator1.Location = New System.Drawing.Point(1, 461)
        Me.SteamSeparator1.Name = "SteamSeparator1"
        Me.SteamSeparator1.NoRounding = false
        Me.SteamSeparator1.Size = New System.Drawing.Size(590, 10)
        Me.SteamSeparator1.TabIndex = 1
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
        Me.SteamButton1.Location = New System.Drawing.Point(3, 50)
        Me.SteamButton1.Name = "SteamButton1"
        Me.SteamButton1.NoRounding = false
        Me.SteamButton1.Size = New System.Drawing.Size(586, 415)
        Me.SteamButton1.TabIndex = 0
        Me.SteamButton1.Transparent = false
        '
        'cmdSearch
        '
        Me.cmdSearch.Activated = BDOHelper.SteamButton._Options._true
        Me.cmdSearch.Colors = New BDOHelper.Bloom(-1) {}
        Me.cmdSearch.Customization = ""
        Me.cmdSearch.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.cmdSearch.Image = Nothing
        Me.cmdSearch.Location = New System.Drawing.Point(179, 100)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.NoRounding = false
        Me.cmdSearch.Size = New System.Drawing.Size(67, 22)
        Me.cmdSearch.TabIndex = 7
        Me.cmdSearch.Text = "  Suchen"
        Me.cmdSearch.Transparent = false
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.BackgroundImage = Global.BDOHelper.My.Resources.Resources.BDOUi
        Me.ClientSize = New System.Drawing.Size(593, 525)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lvSearchResults)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SteamTextBox1)
        Me.Controls.Add(Me.SteamSeparator1)
        Me.Controls.Add(Me.SteamButton1)
        Me.Controls.Add(Me.pbMove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.Text = "Form1"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbMove,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents SteamButton1 As SteamButton
    Friend WithEvents SteamSeparator1 As SteamSeparator
    Friend WithEvents SteamTextBox1 As SteamTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbMove As PictureBox
    Friend WithEvents lvSearchResults As ListView
    Friend WithEvents colIcon As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents txtItem As SteamTextBox
    Friend WithEvents imgIcons As ImageList
    Friend WithEvents cmdSearch As SteamButton
End Class
