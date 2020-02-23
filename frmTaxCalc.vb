Imports System.Globalization

Public Class frmTaxCalc
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
    Private Sub SteamTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SteamTextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub SteamTextBox2_Click(sender As Object, e As EventArgs) Handles SteamTextBox2.Click
        SteamTextBox2.Text = ""
    End Sub

    Private Sub cmdCalc_Click(sender As Object, e As EventArgs) Handles cmdCalc.Click
        Try
            Dim result15 As Int64 = Convert.ToInt64(SteamTextBox2.Text) * 0.650
            Dim result30 As Int64 = Convert.ToInt64(SteamTextBox2.Text) * 0.845

            lblWithVP.Text = "With Value Pack: " + result30.ToString("C", CultureInfo.CurrentCulture)
            lblWithoutVP.Text = "Without Value Pack: " + result15.ToString("C", CultureInfo.CurrentCulture)
        Catch ex As Exception
            MsgBox("An error occured... Maybe you fucked the mathematics up (ô,O)")
        End Try
    End Sub


End Class