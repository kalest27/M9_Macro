Imports System.Runtime.InteropServices
Public Class MouseClass
    Private m_iDoubleClickTime As Integer = 0
    Private m_dtLastLMouseDown As DateTime = Now
    Private m_dtLastRMouseDown As DateTime = Now

    Private Shared m_iMouseHandle As Integer = 0
    Private m_clsHookCallback As MouseHookCallBack

    Private Const HC_ACTION As Integer = 0
    Private Const WH_MOUSE_LL As Integer = 14
    Private Const WM_MOUSEMOVE As Integer = &H200
    Private Const WM_LBUTTONDOWN As Integer = &H201
    Private Const WM_LBUTTONUP As Integer = &H202
    Private Const WM_LBUTTONDBLCLK As Integer = &H203
    Private Const WM_RBUTTONDOWN As Integer = &H204
    Private Const WM_RBUTTONUP As Integer = &H205
    Private Const WM_RBUTTONDBLCLK As Integer = &H206
    Private Const WM_MBUTTONDOWN As Integer = &H207
    Private Const WM_MBUTTONUP As Integer = &H208
    Private Const WM_MBUTTONDBLCLK As Integer = &H209
    Private Const WM_MOUSEWHEEL As Integer = &H20A

    Public Delegate Function MouseHookCallBack( _
        ByVal nCode As Integer, _
        ByVal wParam As IntPtr, _
        ByVal lParam As IntPtr) As Integer

    Public Declare Function GetModuleHandle Lib "kernel32.dll" _
    Alias "GetModuleHandleA" ( _
    ByVal ModuleName As String) As IntPtr

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
    Public Overloads Shared Function GetDoubleClickTime() As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
    Public Overloads Shared Function SetWindowsHookEx _
          (ByVal idHook As Integer, ByVal HookProc As MouseHookCallBack, _
           ByVal hInstance As IntPtr, ByVal wParam As Integer) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
    Public Overloads Shared Function CallNextHookEx _
          (ByVal idHook As Integer, ByVal nCode As Integer, _
           ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
    Public Overloads Shared Function UnhookWindowsHookEx _
              (ByVal idHook As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure Point
        Public x As Integer
        Public y As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MouseHookStruct
        Public pt As Point
        Public hwnd As Integer
        Public wHitTestCode As Integer
        Public dwExtraInfo As Integer
    End Structure

    Public Event MouseUp As System.Windows.Forms.MouseEventHandler
    Public Event MouseDown As System.Windows.Forms.MouseEventHandler
    Public Event MouseDoubleClick As System.Windows.Forms.MouseEventHandler

    Private Function MouseProc( _
        ByVal nCode As Integer, _
        ByVal wParam As IntPtr, _
        ByVal lParam As IntPtr) As Integer

        If (nCode = HC_ACTION) Then
            Dim uInfo As MouseHookStruct = CType(Marshal.PtrToStructure(lParam, uInfo.GetType()), MouseHookStruct)
            Select Case wParam.ToInt32()
                Case WM_LBUTTONDOWN
                    RaiseEvent MouseDown(Me, New MouseEventArgs(MouseButtons.Left, 1, uInfo.pt.x, uInfo.pt.y, 0))
                    ' double-click hack...
                    If (m_dtLastLMouseDown.AddMilliseconds(m_iDoubleClickTime).CompareTo(Now) >= 0) Then
                        RaiseEvent MouseDoubleClick(Me, New MouseEventArgs(MouseButtons.Left, 2, uInfo.pt.x, uInfo.pt.y, 0))
                    Else
                        m_dtLastLMouseDown = Now
                    End If

                    Debug.WriteLine(uInfo.pt.x & " " & uInfo.pt.y)

                Case WM_RBUTTONDOWN
                    RaiseEvent MouseDown(Me, New MouseEventArgs(MouseButtons.Right, 1, uInfo.pt.x, uInfo.pt.y, 0))
                    ' double-click hack...
                    If (m_dtLastRMouseDown.AddMilliseconds(m_iDoubleClickTime).CompareTo(Now) >= 0) Then
                        RaiseEvent MouseDoubleClick(Me, New MouseEventArgs(MouseButtons.Right, 2, uInfo.pt.x, uInfo.pt.y, 0))
                    Else
                        m_dtLastRMouseDown = Now
                    End If
                Case WM_LBUTTONUP
                    RaiseEvent MouseUp(Me, New MouseEventArgs(MouseButtons.Left, 1, uInfo.pt.x, uInfo.pt.y, 0))
                Case WM_RBUTTONUP
                    RaiseEvent MouseUp(Me, New MouseEventArgs(MouseButtons.Right, 1, uInfo.pt.x, uInfo.pt.y, 0))
                Case Else
                    If (wParam <> WM_MOUSEMOVE) Then Debug.WriteLine(wParam)
            End Select
        End If

        Return CallNextHookEx(m_iMouseHandle, nCode, wParam, lParam)

    End Function

    Public Sub HookMouse()
        m_iMouseHandle = SetWindowsHookEx(WH_MOUSE_LL, _
            New MouseHookCallBack(AddressOf MouseProc), _
            GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0)

        If m_iMouseHandle = 0 Then
            Throw New System.Exception("Mouse hook failed.")
        Else
            m_iDoubleClickTime = GetDoubleClickTime()
        End If
    End Sub

    Public Sub UnhookMouse()
        If (m_iMouseHandle <> 0) Then UnhookWindowsHookEx(m_iMouseHandle)
    End Sub
End Class
