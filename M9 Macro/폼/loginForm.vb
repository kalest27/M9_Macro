Public Class loginForm

    ' TODO: 제공된 사용자 이름과 암호를 사용하여 사용자 지정 인증을 수행하는 코드를 삽입합니다
    ' (자세한 내용은 http://go.microsoft.com/fwlink/?LinkId=35339 참조).  
    ' 그러면 사용자 지정 보안 주체가 현재 스레드의 보안 주체에 다음과 같이 첨부될 수 있습니다. 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' 여기서 CustomPrincipal은 인증을 수행하는 데 사용되는 IPrincipal이 구현된 것입니다. 
    ' 나중에 My.User는 CustomPrincipal 개체에 캡슐화된 사용자 이름, 표시 이름 등의
    ' ID 정보를 반환합니다.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "shlee" And PasswordTextBox.Text = "rf0101" Then
            Me.Hide()
            mainForm.Show()
        Else
            MessageBox.Show("아이디와 비밀번호가 틀렸습니다.", "알림", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

End Class
