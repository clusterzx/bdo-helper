Module Memory
    Private Declare Function MapVirtualKey Lib "user32" Alias "MapVirtualKeyA" (ByVal uCode As UInteger, ByVal uMapType As UInteger) As UInteger
    <System.Runtime.InteropServices.DllImport("user32" , charset:=Runtime.InteropServices.CharSet.Auto)> _
    Private Function PostMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101

    Public Sub SendKey(ByVal WindowTitle As String, ByVal KEY As UInteger)
        Dim handle As IntPtr = FindWindow(vbNullString, WindowTitle) 'Fensterhandle bekommen
        If handle = Nothing Then 'Kein handle bekommen
            MessageBox.Show("Can't find Window!\nCheck if the Window exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Den Key senden
            Dim lParam As Integer = MapVirtualKey(KEY, 0) << 16 Or 1
            PostMessage(handle, WM_KEYDOWN, KEY, lParam)
            PostMessage(handle, WM_KEYUP, KEY, lParam)
        End If
    End Sub
End Module