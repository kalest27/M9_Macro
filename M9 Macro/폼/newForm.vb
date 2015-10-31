Public Class newForm
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtModelName.Text = "" Then
            MessageShow("모델명을 작성해주세요")
        ElseIf NmrDefaultTestCount.Value = 0 Then
            MessageShow("검사 수량을 작성해주세요")
        ElseIf txtDefaultFolderName.Text = "" Then
            MessageShow("폴더명을 작성해주세요")
        ElseIf NmrMoveXPosition.Text = 0 Then
            MessageShow("X 좌표를 작성해주세요")
        ElseIf NmrMoveYPosition.Text = 0 Then
            MessageShow("Y 좌표를 작성해주세요")
        ElseIf txtPathSaveFolder.Text = "" Then
            MessageShow("폴더 경로를 설정해주세요")
            btnPathFolderSelect.PerformClick()
        Else
            '폴더 생성
            Call CreateSettingFolder(Application.StartupPath & "\Setting Files")

            With mainForm.SaveFileDialog1
                .InitialDirectory = Application.StartupPath & "\Setting Files"
                .FileName = ""
                .Filter = filterName
                .ShowDialog()

                '파일명이 있으면 저장
                If .FileName <> "" Then
                    strIOPath = .FileName

                    '파일 저장
                    SettingFileSave(txtModelName.Text, NmrDefaultTime.Value, cbbDefaultFirstDirection.SelectedIndex, NmrDefaultTestCount.Value, NmrDefaultTestNumber.Value, txtDefaultFolderName.Text, NmrDefaultNumericCount.Value, chbDefaultAutoAdd.Checked, NmrMoveColumnCount.Value, NmrMoveRowCount.Value, NmrMoveXPosition.Text, NmrMoveYPosition.Text, txtPathSaveFolder.Text, chbPremiumStatusBar.Checked, chbPremiumRightEnd.Checked, chbPremiumTargetEnd.Checked, chbPremiumPositionUpdate.Checked)

                    '뉴 폼 종료
                    Me.Close()
                End If
            End With
        End If
    End Sub

    '뉴 폼 종료 이벤트
    Private Sub newForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        mainForm.Show()
    End Sub

    '기본 설정 - 검사 수량
    Private Sub NmrMoveColumnCount_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NmrMoveColumnCount.ValueChanged, NmrMoveRowCount.ValueChanged
        NmrDefaultTestCount.Minimum = 1
        NmrDefaultTestCount.Maximum = NmrMoveColumnCount.Value * NmrMoveRowCount.Value
        NmrDefaultTestCount.Value = NmrMoveColumnCount.Value * NmrMoveRowCount.Value
    End Sub

    '경로 설정 - 폴더 설정 버튼
    Private Sub btnPathFolderSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathFolderSelect.Click
        With mainForm.FolderBrowserDialog1
            .ShowDialog()
            txtPathSaveFolder.Text = .SelectedPath
        End With
    End Sub

End Class