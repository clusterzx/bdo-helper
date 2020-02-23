Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Web.Script.Serialization

Public Class Form1
    Dim pLang = "de"
    Dim uriString As String = "https://bddatabase.net/ac.php?l=" + pLang + "&term=" 
    Public Shared Dim currentUrl As String = ""
' Stores the offset where the picturebox is clicked.
    Dim PointClicked As Point
    Dim Dragging As Boolean
    Private Sub pbMove_MouseDown(ByVal sender As Object, _
                                      ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbMove.MouseDown
        If e.Button = MouseButtons.Left Then
            Dragging = True
            PointClicked = New Point(e.X, e.Y)
        Else
            Dragging = False
        End If
 
    End Sub
 
    Private Sub pbMove_MouseMove(ByVal sender As Object, _
                                      ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbMove.MouseMove
 
        If Dragging Then
            Dim PointMoveTo As Point
            ' Find the current mouse position in screen coordinates.
            PointMoveTo = Me.PointToScreen(New Point(e.X, e.Y))
 
            ' Compensate for the position the control was clicked.
            PointMoveTo.Offset(-PointClicked.X, -PointClicked.Y)
            ' Move the form.
            Me.Location = PointMoveTo
        End If
 
    End Sub
 
    Private Sub pbMove_MouseUp(ByVal sender As Object, _
                                    ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbMove.MouseUp
 
        Dragging = False
 
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        lvSearchResults.View = View.Details
        lvSearchResults.FullRowSelect = true
        lvSearchResults.GridLines = True
        ComboBox1.SelectedItem = "German"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close
    End Sub
    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        MsgBox(uriString)
        lvSearchResults.Items.Clear()
            Dim uri As New Uri(uriString + txtItem.Text)
            Dim Request As HttpWebRequest = HttpWebRequest.Create(uri)
            Request.Method = "GET"
            Dim Response As HttpWebResponse = Request.GetResponse()
            Dim Read = New StreamReader(Response.GetResponseStream())
            Dim Raw As String = Read.ReadToEnd()

            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Raw)

            for each item As Object In dict
                Dim lvItem As New ListViewItem(item("icon").ToString())
                If item("grade").ToString = "0" Then
                    lvItem.SubItems.Add(item("name").ToString()).ForeColor = Color.White
                    lvItem.SubItems(1).ForeColor = Color.White
                ElseIf item("grade").ToString = "1" Then 'Grün
                    lvItem.SubItems.Add(item("name").ToString()).ForeColor = Color.Green
                    lvItem.SubItems(1).ForeColor = Color.Green
                ElseIf item("grade").ToString = "2" Then 'Blau
                    lvItem.SubItems.Add(item("name").ToString()).ForeColor = Color.DeepSkyBlue
                    lvItem.SubItems(1).ForeColor = Color.DeepSkyBlue
                ElseIf item("grade").ToString = "3" Then 'Gold
                    lvItem.SubItems.Add(item("name").ToString()).ForeColor = Color.Gold
                    lvItem.SubItems(1).ForeColor = Color.Gold
                ElseIf item("grade").ToString = "4" Then 'Rot
                    lvItem.SubItems.Add(item("name").ToString()).ForeColor = Color.DarkOrange
                    lvItem.SubItems(1).ForeColor = Color.DarkOrange
                    lvItem.SubItems(1).BackColor = Color.DarkOrange
                End If
                lvItem.SubItems.Add(item("value").ToString())
                lvSearchResults.Items.Add(lvItem)
            Next

            For Each myItem As ListViewItem In lvSearchResults.Items
                Try
                        Dim baseurl = myItem.Text

                            Dim iconURL = "https://bddatabase.net/items/" + baseurl
                            Dim request2 As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
                            Dim response2 As System.Net.HttpWebResponse = request2.GetResponse()
                            Dim stream As System.IO.Stream = response2.GetResponseStream()
                            imgIcons.Images.Add(Image.FromStream(stream))
                            myItem.ImageIndex = imgIcons.Images.Count - 1
                            myItem.Text = ""
                Catch ex As Exception

                End Try
            Next
    End Sub

    Private Sub lvSearchResults_DoubleClick(sender As Object, e As EventArgs) Handles lvSearchResults.DoubleClick
        Dim id As String = lvSearchResults.SelectedItems(0).SubItems(2).Text
        Dim url As String = "https://bddatabase.net/" + pLang + "/item/" + id + "/"
        currentUrl = url
        Dim newBrowser As New frmBrowser
        newBrowser.StartPosition = FormStartPosition.CenterParent
        newBrowser.ShowDialog(Me)
    End Sub

    Private Sub txtItem_Click(sender As Object, e As EventArgs) Handles txtItem.Click
        txtItem.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem.ToString() = "German" Then
            pLang = "de"
            uriString = "https://bddatabase.net/ac.php?l=" + pLang + "&term=" 
        ElseIf ComboBox1.SelectedItem.ToString() = "English" Then
            pLang = "us"
            uriString = "https://bddatabase.net/ac.php?l=" + pLang + "&term=" 
        ElseIf ComboBox1.SelectedItem.ToString() = "France" Then
            pLang = "fr"
            uriString = "https://bddatabase.net/ac.php?l=" + pLang + "&term=" 
        ElseIf ComboBox1.SelectedItem.ToString() = "Spain" Then
            pLang = "sp"
            uriString = "https://bddatabase.net/ac.php?l=" + pLang + "&term=" 
        ElseIf ComboBox1.SelectedItem.ToString() = "Turkish" Then
            pLang = "tr"
            uriString = "https://bddatabase.net/ac.php?l=" + pLang + "&term=" 
        ElseIf ComboBox1.SelectedItem.ToString() = "Orc" Then
            MsgBox("Ayh lat avhaav ukavupid? jiak gueukuk lat wanav avo mat!")
        End If
    End Sub

    Private Sub cmdTax_Click(sender As Object, e As EventArgs) Handles cmdTax.Click
        Dim newTax As New frmTaxCalc
        newTax.StartPosition = FormStartPosition.CenterParent
        newTax.ShowDialog(Me)
    End Sub

    Private Sub cmdInteractiveMap_Click(sender As Object, e As EventArgs) Handles cmdInteractiveMap.Click
        Dim newMap As New frmMap
        newMap.StartPosition = FormStartPosition.CenterParent
        newMap.ShowDialog(Me)
    End Sub
End Class
