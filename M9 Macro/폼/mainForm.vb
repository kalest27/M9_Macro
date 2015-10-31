Public Class mainForm
    Private WithEvents kbHook As New KeyboardClass
    Private WithEvents msHook As New MouseClass

    '매크로 단축키
    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        If blRedayTF Then
            '컨트롤 키 활성화
            If Key = 162 Then
                blCtrlKeyTF = True
            End If
            '매크로 상태 확인
            If blMacroStatus Then
                '매크로 일시정지
                If Key = 40 Then
                    MacroPause()
                End If
                '매크로 정지
                If Key = 39 Then
                    MacroStop()
                End If
            Else
                '(컨트롤) + 1, 2
                If blCtrlKeyTF And blMacroStatus = False Then
                    If Key = 49 Then
                        intMacroType = 1
                        Call MacroStart()
                    ElseIf Key = 50 Then
                        intMacroType = 2

                        If NmrDefaultTestNumber.Value > 1 Then
                            MessageShow("2개 이상 검사하는 경우 사진 저장이 되지 않습니다")
                        Else
                            Call MacroStart()
                        End If
                        End If
                End If
            End If
        End If
    End Sub
    Private Sub kbHook_KeyUp(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyUp
        blCtrlKeyTF = False
    End Sub

    '준비 버튼 클릭
    Private Sub btnMacroReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMacroReady.Click
        If TabControl2.SelectedTab.Text = "" Then
            MessageShow("준비 상태로 전환할 수 없습니다. 모델명을 불러와 주시기 바랍니다.")
        Else
            btnMacroReady.Text = "준비"
            blRedayTF = True
        End If
    End Sub

    '매크로 실행
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = NmrDefaultTime.Value

        '총 수량에 도달하거나 목표 수량에 도달하면 종료
        If intTestNumber < intTestNumberTotal And intCheckNumber < NmrDefaultTestCount.Value - 1 Then
            '매크로 진입 부분

            '사진 캡쳐
            If intMacroType = 2 Then
                If ((intTestNumber - 1) \ NmrMoveColumnCount.Value) Mod 2 = 0 Then
                    '홀수 행 (기존)
                    Call CaptureScreen(2, 147, 1512, 864, txtPathSaveFolder.Text & "\" & txtDefaultFolderName.Text & "_" & NmrDefaultNumericCount.Value & "\" & intTestNumber & ".jpg")
                Else
                    '짝수 행 (조건)
                    Call CaptureScreen(2, 147, 1512, 864, txtPathSaveFolder.Text & "\" & txtDefaultFolderName.Text & "_" & NmrDefaultNumericCount.Value & "\" & (intTestNumber + intAddNumber) & ".jpg")

                    '2 감소
                    intAddNumber -= 2

                    If intAddNumber = -11 Then
                        Select Case cbbDefaultFirstDirection.SelectedIndex
                            Case 0, 1
                                intAddNumber = NmrMoveColumnCount.Value - 1
                            Case 2, 3
                                intAddNumber = NmrMoveRowCount.Value - 1
                        End Select
                    End If
                End If

                If FileCheck(strSavePath) Then
                    intCheckNumber += 1
                End If
            End If

            '매크로 설정 방향에 따라 클릭
            Call MacroDirection(cbbDefaultFirstDirection.SelectedIndex)

            '모델 번호 카운트
            intTestNumber += 1
        Else
            If intTestNumber = intTestNumberTotal Then
                If ((intTestNumber - 1) \ NmrMoveColumnCount.Value) Mod 2 = 0 Then
                    Call CaptureScreen(2, 147, 1512, 864, txtPathSaveFolder.Text & "\" & txtDefaultFolderName.Text & "_" & NmrDefaultNumericCount.Value & "\" & intTestNumber & ".jpg")
                Else
                    Call CaptureScreen(2, 147, 1512, 864, txtPathSaveFolder.Text & "\" & txtDefaultFolderName.Text & "_" & NmrDefaultNumericCount.Value & "\" & (intTestNumber + intAddNumber) & ".jpg")
                End If
            End If

            Call MacroStop()

            If intCheckNumber <> NmrDefaultTestCount.Value Then
                '사진 캡쳐
                If intMacroType = 2 Then
                    'Call ScreenCapture()
                End If
            End If

            '자동 증가 체크 유
            If chbDefaultAutoAdd.Checked Then
                NmrDefaultNumericCount.Value += 1
            End If
        End If
    End Sub

    '메뉴 - 새로 만들기
    Private Sub 새로만들기NToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 새로만들기NToolStripMenuItem.Click
        Me.Hide()
        newForm.Show()
    End Sub

    '메뉴 - 열기
    Private Sub 열기OToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 열기OToolStripMenuItem.Click
        '폴더 생성
        Call CreateSettingFolder(Application.StartupPath & "\Setting Files")

        '팝업 창 보이기
        With OpenFileDialog1
            .InitialDirectory = Application.StartupPath & "\Setting Files"
            .FileName = ""
            .Filter = filterName
            .ShowDialog()

            '파일을 선택하면 활성화
            If .FileName <> "" Then
                strIOPath = .FileName
                strIOFile = .SafeFileName

                '탭 이름 변경
                TabControl2.SelectedTab.Text = strIOFile

                'm9m 설정 파일 읽기
                Call SettingFileLoad()

                '객체 활성화
                NmrDefaultTime.Enabled = True
                cbbDefaultFirstDirection.Enabled = True
                NmrDefaultTestCount.Enabled = True
                txtDefaultFolderName.Enabled = True
                NmrDefaultNumericCount.Enabled = True
                NmrDefaultTestNumber.Enabled = True
                chbDefaultAutoAdd.Enabled = True

                NmrMoveColumnCount.Enabled = True
                NmrMoveRowCount.Enabled = True
                NmrMoveXPosition.Enabled = True
                NmrMoveYPosition.Enabled = True

                txtPathSaveFolder.Enabled = True
                btnPathFolderSelect.Enabled = True

                chbPremiumStatusBar.Enabled = True
                chbPremiumRightEnd.Enabled = True
                chbPremiumTargetEnd.Enabled = True
                chbPremiumPositionUpdate.Enabled = True

                btnMacroReady.Enabled = True

                저장SToolStripMenuItem.Enabled = True
                다른이름으로저장ToolStripMenuItem.Enabled = True
            End If
        End With
    End Sub

    '메뉴 - 저장
    Private Sub 저장SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 저장SToolStripMenuItem.Click
        '폴더 생성
        Call CreateSettingFolder(Application.StartupPath & "\Setting Files")

        '파일 저장
        SettingFileSave(lbModelName.Text, NmrDefaultTime.Value, cbbDefaultFirstDirection.SelectedIndex, NmrDefaultTestCount.Value, NmrDefaultTestNumber.Value, txtDefaultFolderName.Text, NmrDefaultNumericCount.Value, chbDefaultAutoAdd.Checked, NmrMoveColumnCount.Value, NmrMoveRowCount.Value, NmrMoveXPosition.Text, NmrMoveYPosition.Text, txtPathSaveFolder.Text, chbPremiumStatusBar.Checked, chbPremiumRightEnd.Checked, chbPremiumTargetEnd.Checked, chbPremiumPositionUpdate.Checked)

        '탭 이름 원상 복귀
        TabControl2.SelectedTab.Text = strIOFile
    End Sub

    '메뉴 - 다른 이름으로 저장
    Private Sub 다른이름으로저장ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 다른이름으로저장ToolStripMenuItem.Click
        '폴더 생성
        Call CreateSettingFolder(Application.StartupPath & "\Setting Files")

        With SaveFileDialog1
            .InitialDirectory = Application.StartupPath & "\Setting Files"
            .FileName = ""
            .Filter = filterName
            .ShowDialog()

            If .FileName <> "" Then
                strIOPath = .FileName
                strIOFile = IO.Path.GetFileName(.FileName)

                '탭 이름 변경
                TabControl2.SelectedTab.Text = strIOFile

                '파일 저장
                SettingFileSave(lbModelName.Text, NmrDefaultTime.Value, cbbDefaultFirstDirection.SelectedIndex, NmrDefaultTestCount.Value, NmrDefaultTestNumber.Value, txtDefaultFolderName.Text, NmrDefaultNumericCount.Value, chbDefaultAutoAdd.Checked, NmrMoveColumnCount.Value, NmrMoveRowCount.Value, NmrMoveXPosition.Text, NmrMoveYPosition.Text, txtPathSaveFolder.Text, chbPremiumStatusBar.Checked, chbPremiumRightEnd.Checked, chbPremiumTargetEnd.Checked, chbPremiumPositionUpdate.Checked)

                '탭 이름 원상 복귀
                TabControl2.SelectedTab.Text = strIOFile
            End If
        End With
    End Sub

    '메뉴 - 종료
    Private Sub 종료ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 종료ToolStripMenuItem.Click
        End
    End Sub

    '개발자 테스트
    Private Sub mainForm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub

    '메인 폼 종료
    Private Sub mainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        tdMtx.ReleaseMutex()

        If TabControl2.SelectedTab.Text <> "" Then
            '폴더 생성
            Call CreateSettingFolder(Application.StartupPath & "\Setting Files")

            '파일 저장
            SettingFileSave(lbModelName.Text, NmrDefaultTime.Value, cbbDefaultFirstDirection.SelectedIndex, NmrDefaultTestCount.Value, NmrDefaultTestNumber.Value, txtDefaultFolderName.Text, NmrDefaultNumericCount.Value, chbDefaultAutoAdd.Checked, NmrMoveColumnCount.Value, NmrMoveRowCount.Value, NmrMoveXPosition.Text, NmrMoveYPosition.Text, txtPathSaveFolder.Text, chbPremiumStatusBar.Checked, chbPremiumRightEnd.Checked, chbPremiumTargetEnd.Checked, chbPremiumPositionUpdate.Checked)
        End If
    End Sub

    '메인 폼 시작 로드
    Private Sub mainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '뮤텍스가 정상적으로 생성되지 않았으면 같은 이름의 뮤텍스가 있는것으로 판단
        If Not blCreated Then
            MessageShow("중복 실행 방지로 종료합니다.")
            Application.ExitThread()
        End If
    End Sub

    '경로 설정 - 폴더 경로
    Private Sub btnPathFolderSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathFolderSelect.Click
        '폴더 생성
        Call CreateSettingFolder(Application.StartupPath & "\Setting Files")

        With FolderBrowserDialog1
            .ShowDialog()
            txtPathSaveFolder.Text = .SelectedPath
        End With
    End Sub

    '** 추가 기능 **
    Private Sub txtDefaultFolderName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDefaultFolderName.KeyPress
        NmrDefaultNumericCount.Value = 1
        Call ModelAddStar()
    End Sub

    '변경 표시 (*)
    Private Sub NmrDefaultTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NmrDefaultTime.ValueChanged, NmrMoveXPosition.ValueChanged, NmrMoveYPosition.ValueChanged, cbbDefaultFirstDirection.SelectedIndexChanged, NmrDefaultTestCount.ValueChanged, NmrDefaultTestNumber.ValueChanged, NmrDefaultNumericCount.ValueChanged, chbDefaultAutoAdd.CheckedChanged, txtPathSaveFolder.TextChanged, chbPremiumStatusBar.CheckedChanged, chbPremiumRightEnd.CheckedChanged, chbPremiumTargetEnd.CheckedChanged, chbPremiumPositionUpdate.CheckedChanged
        If blChange Then
            Call ModelAddStar()
        End If
    End Sub

    '기본 설정 - 검사 수량
    Private Sub NmrMoveColumnCount_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NmrMoveColumnCount.ValueChanged, NmrMoveRowCount.ValueChanged
        'If blChange Then
        NmrDefaultTestCount.Minimum = 1
        NmrDefaultTestCount.Maximum = NmrMoveColumnCount.Value * NmrMoveRowCount.Value
        NmrDefaultTestCount.Value = NmrMoveColumnCount.Value * NmrMoveRowCount.Value
        'End If
    End Sub

    Private Sub NmrMoveX_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class