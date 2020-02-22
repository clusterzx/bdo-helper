Imports System.Runtime.InteropServices
Imports System.Text

Public Class frmOrb
    <DllImport("user32.dll", EntryPoint:="GetWindowThreadProcessId")> _
    Private Shared Function GetWindowThreadProcessId(<InAttribute()> ByVal hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="GetForegroundWindow")> Private Shared Function GetForegroundWindow() As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function GetWindowTextLength(ByVal hwnd As IntPtr) As Integer
    End Function

    <DllImport("user32.dll", EntryPoint:="GetWindowTextW")> _
    Private Shared Function GetWindowTextW(<InAttribute()> ByVal hWnd As IntPtr, <OutAttribute(), MarshalAs(UnmanagedType.LPWStr)> ByVal lpString As StringBuilder, ByVal nMaxCount As Integer) As Integer
    End Function
    Dim bdoRunning As Boolean = False
    Dim shown As Boolean = False
    Dim pid As Integer = 0

    Function GetForgroundWindowInfo() As Boolean
        Dim hWnd As IntPtr = GetForegroundWindow()
        If Not hWnd.Equals(IntPtr.Zero) Then

            Dim lgth As Integer = GetWindowTextLength(hWnd)
            Dim wTitle As New System.Text.StringBuilder("", lgth + 1)
            If lgth > 0 Then
                GetWindowTextW(hWnd, wTitle, wTitle.Capacity)
            End If

            Dim wProcID As Integer = Nothing
            GetWindowThreadProcessId(hWnd, wProcID)

            Dim Proc As Process = Process.GetProcessById(wProcID)
            Dim wFileName As String = ""
            Try
                wFileName = Proc.MainModule.FileName
            Catch ex As Exception
                wFileName = ""
            End Try

            If wProcID = pid Then
                Return True
            Else 
                Return False
            End If
        End If
    End Function
 Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick

        For each p As Process In Process.GetProcesses()
            If p.ProcessName = "BlackDesert64" Then
                pid = p.Id
                lblStatus.Text = "Running"
                lblStatus.ForeColor = Color.GreenYellow
                bdoRunning = True

                Me.Height = 64
                Me.Width = 79
                Dim px As Point
                px.X = 13
                px.Y = 232
                Me.Location = px
                SteamButton1.Enabled = True

                tmrForeground.Enabled = True
                tmrCheckOff.Enabled = True
                tmrCheck.Enabled = False
            End If
        Next
    End Sub
    Private Function ProcessExists(id As Integer) As Boolean
        Return Process.GetProcesses().Any(Function(x) x.Id = id)
    End Function

    Private Sub tmrCheckOff_Tick(sender As Object, e As EventArgs) Handles tmrCheckOff.Tick
        If ProcessExists(pid) = False Then
            tmrCheck.Enabled = True
            pid = 0
            bdoRunning = False
            lblStatus.Text = "Not running..."
            lblStatus.ForeColor = Color.Red
            SteamButton1.Enabled = False
            Application.Exit()
        End If
    End Sub

    Private Sub tmrForeground_Tick(sender As Object, e As EventArgs) Handles tmrForeground.Tick
        If GetForgroundWindowInfo = True And shown = False Then
            Me.Visible = True
            Me.Show()
            Me.TopMost = True
        Else 
            Me.Visible = False
            Me.Hide()
        End If
    End Sub

    Private Sub SteamButton1_Click_1(sender As Object, e As EventArgs) Handles SteamButton1.Click
        Dim newFrm As New Form1
        newFrm.StartPosition = FormStartPosition.CenterParent
        newFrm.ShowDialog(Me)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close
    End Sub

    Protected Overrides Sub SetVisibleCore(ByVal value As Boolean)
        If Not Me.IsHandleCreated Then
            Me.CreateHandle()
            value = False
        End If
        MyBase.SetVisibleCore(value)
    End Sub

    Private Sub frmOrb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class