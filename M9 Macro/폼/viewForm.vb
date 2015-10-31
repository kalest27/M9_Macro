Public Class viewForm

    Private Sub viewForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 1 To mainForm.NmrMoveRowCount.Value
            For j = 1 To mainForm.NmrMoveColumnCount.Value
                Label1.Text &= "+  "
            Next
            Label1.Text &= vbCrLf
        Next
        Me.Location = New Point((Screen.PrimaryScreen.Bounds.Width) - Me.Width, (Screen.PrimaryScreen.Bounds.Height) - Me.Height - 30)
    End Sub
End Class