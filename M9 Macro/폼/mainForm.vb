Public Class mainForm
    Private WithEvents kbHook As New KeyboardClass
    Private WithEvents msHook As New MouseClass

    '��ũ�� ����Ű
    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        If blRedayTF Then
            '��Ʈ�� Ű Ȱ��ȭ
            If Key = 162 Then
                blCtrlKeyTF = True
            End If
            '��ũ�� ���� Ȯ��
            If blMacroStatus Then
                '��ũ�� �Ͻ�����
                If Key = 40 Then
                    MacroPause()
                End If
                '��ũ�� ����
                If Key = 39 Then
                    MacroStop()
                End If
            Else
                '(��Ʈ��) + 1, 2
                If blCtrlKeyTF And blMacroStatus = False Then
                    If Key = 49 Then
                        intMacroType = 1
                        Call MacroStart()
                    ElseIf Key = 50 Then
                        intMacroType = 2

                        If NmrDefaultTestNumber.Value > 1 Then
                            MessageShow("2�� �̻� �˻��ϴ� ��� ���� ������ ���� �ʽ��ϴ�")
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

    '�غ� ��ư Ŭ��
    Private Sub btnMacroReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMacroReady.Click
        If TabControl2.SelectedTab.Text = "" Then
            MessageShow("�غ� ���·� ��ȯ�� �� �����ϴ�. �𵨸��� �ҷ��� �ֽñ� �ٶ��ϴ�.")
        Else
            btnMacroReady.Text = "�غ�"
            blRedayTF = True
        End If
    End Sub

    '��ũ�� ����
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = NmrDefaultTime.Value

        '�� ������ �����ϰų� ��ǥ ������ �����ϸ� ����
        If intTestNumber < intTestNumberTotal And intCheckNumber < NmrDefaultTestCount.Value - 1 Then
            '��ũ�� ���� �κ�

            '���� ĸ��
            If intMacroType = 2 Then
                If ((intTestNumber - 1) \ NmrMoveColumnCount.Value) Mod 2 = 0 Then
                    'Ȧ�� �� (����)
                    Call CaptureScreen(2, 147, 1512, 864, txtPathSaveFolder.Text & "\" & txtDefaultFolderName.Text & "_" & NmrDefaultNumericCount.Value & "\" & intTestNumber & ".jpg")
                Else
                    '¦�� �� (����)
                    Call CaptureScreen(2, 147, 1512, 864, txtPathSaveFolder.Text & "\" & txtDefaultFolderName.Text & "_" & NmrDefaultNumericCount.Value & "\" & (intTestNumber + intAddNumber) & ".jpg")

                    '2 ����
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

            '��ũ�� ���� ���⿡ ���� Ŭ��
            Call MacroDirection(cbbDefaultFirstDirection.SelectedIndex)

            '�� ��ȣ ī��Ʈ
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
                '���� ĸ��
                If intMacroType = 2 Then
                    'Call ScreenCapture()
                End If
            End If

            '�ڵ� ���� üũ ��
            If chbDefaultAutoAdd.Checked Then
                NmrDefaultNumericCount.Value += 1
            End If
        End If
    End Sub

    '�޴� - ���� �����
    Private Sub ���θ����NToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ���θ����NToolStripMenuItem.Click
        Me.Hide()
        newForm.Show()
    End Sub

    '�޴� - ����
    Private Sub ����OToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����OToolStripMenuItem.Click
        '���� ����
        Call CreateSettingFolder(Application.StartupPath & "\Setting Files")

        '�˾� â ���̱�
        With OpenFileDialog1
            .InitialDirectory = Application.StartupPath & "\Setting Files"
            .FileName = ""
            .Filter = filterName
            .ShowDialog()

            '������ �����ϸ� Ȱ��ȭ
            If .FileName <> "" Then
                strIOPath = .FileName
                strIOFile = .SafeFileName

                '�� �̸� ����
                TabControl2.SelectedTab.Text = strIOFile

                'm9m ���� ���� �б�
                Call SettingFileLoad()

                '��ü Ȱ��ȭ
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

                ����SToolStripMenuItem.Enabled = True
                �ٸ��̸���������ToolStripMenuItem.Enabled = True
            End If
        End With
    End Sub

    '�޴� - ����
    Private Sub ����SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����SToolStripMenuItem.Click
        '���� ����
        Call CreateSettingFolder(Application.StartupPath & "\Setting Files")

        '���� ����
        SettingFileSave(lbModelName.Text, NmrDefaultTime.Value, cbbDefaultFirstDirection.SelectedIndex, NmrDefaultTestCount.Value, NmrDefaultTestNumber.Value, txtDefaultFolderName.Text, NmrDefaultNumericCount.Value, chbDefaultAutoAdd.Checked, NmrMoveColumnCount.Value, NmrMoveRowCount.Value, NmrMoveXPosition.Text, NmrMoveYPosition.Text, txtPathSaveFolder.Text, chbPremiumStatusBar.Checked, chbPremiumRightEnd.Checked, chbPremiumTargetEnd.Checked, chbPremiumPositionUpdate.Checked)

        '�� �̸� ���� ����
        TabControl2.SelectedTab.Text = strIOFile
    End Sub

    '�޴� - �ٸ� �̸����� ����
    Private Sub �ٸ��̸���������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �ٸ��̸���������ToolStripMenuItem.Click
        '���� ����
        Call CreateSettingFolder(Application.StartupPath & "\Setting Files")

        With SaveFileDialog1
            .InitialDirectory = Application.StartupPath & "\Setting Files"
            .FileName = ""
            .Filter = filterName
            .ShowDialog()

            If .FileName <> "" Then
                strIOPath = .FileName
                strIOFile = IO.Path.GetFileName(.FileName)

                '�� �̸� ����
                TabControl2.SelectedTab.Text = strIOFile

                '���� ����
                SettingFileSave(lbModelName.Text, NmrDefaultTime.Value, cbbDefaultFirstDirection.SelectedIndex, NmrDefaultTestCount.Value, NmrDefaultTestNumber.Value, txtDefaultFolderName.Text, NmrDefaultNumericCount.Value, chbDefaultAutoAdd.Checked, NmrMoveColumnCount.Value, NmrMoveRowCount.Value, NmrMoveXPosition.Text, NmrMoveYPosition.Text, txtPathSaveFolder.Text, chbPremiumStatusBar.Checked, chbPremiumRightEnd.Checked, chbPremiumTargetEnd.Checked, chbPremiumPositionUpdate.Checked)

                '�� �̸� ���� ����
                TabControl2.SelectedTab.Text = strIOFile
            End If
        End With
    End Sub

    '�޴� - ����
    Private Sub ����ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ����ToolStripMenuItem.Click
        End
    End Sub

    '������ �׽�Ʈ
    Private Sub mainForm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub

    '���� �� ����
    Private Sub mainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        tdMtx.ReleaseMutex()

        If TabControl2.SelectedTab.Text <> "" Then
            '���� ����
            Call CreateSettingFolder(Application.StartupPath & "\Setting Files")

            '���� ����
            SettingFileSave(lbModelName.Text, NmrDefaultTime.Value, cbbDefaultFirstDirection.SelectedIndex, NmrDefaultTestCount.Value, NmrDefaultTestNumber.Value, txtDefaultFolderName.Text, NmrDefaultNumericCount.Value, chbDefaultAutoAdd.Checked, NmrMoveColumnCount.Value, NmrMoveRowCount.Value, NmrMoveXPosition.Text, NmrMoveYPosition.Text, txtPathSaveFolder.Text, chbPremiumStatusBar.Checked, chbPremiumRightEnd.Checked, chbPremiumTargetEnd.Checked, chbPremiumPositionUpdate.Checked)
        End If
    End Sub

    '���� �� ���� �ε�
    Private Sub mainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '���ؽ��� ���������� �������� �ʾ����� ���� �̸��� ���ؽ��� �ִ°����� �Ǵ�
        If Not blCreated Then
            MessageShow("�ߺ� ���� ������ �����մϴ�.")
            Application.ExitThread()
        End If
    End Sub

    '��� ���� - ���� ���
    Private Sub btnPathFolderSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathFolderSelect.Click
        '���� ����
        Call CreateSettingFolder(Application.StartupPath & "\Setting Files")

        With FolderBrowserDialog1
            .ShowDialog()
            txtPathSaveFolder.Text = .SelectedPath
        End With
    End Sub

    '** �߰� ��� **
    Private Sub txtDefaultFolderName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDefaultFolderName.KeyPress
        NmrDefaultNumericCount.Value = 1
        Call ModelAddStar()
    End Sub

    '���� ǥ�� (*)
    Private Sub NmrDefaultTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NmrDefaultTime.ValueChanged, NmrMoveXPosition.ValueChanged, NmrMoveYPosition.ValueChanged, cbbDefaultFirstDirection.SelectedIndexChanged, NmrDefaultTestCount.ValueChanged, NmrDefaultTestNumber.ValueChanged, NmrDefaultNumericCount.ValueChanged, chbDefaultAutoAdd.CheckedChanged, txtPathSaveFolder.TextChanged, chbPremiumStatusBar.CheckedChanged, chbPremiumRightEnd.CheckedChanged, chbPremiumTargetEnd.CheckedChanged, chbPremiumPositionUpdate.CheckedChanged
        If blChange Then
            Call ModelAddStar()
        End If
    End Sub

    '�⺻ ���� - �˻� ����
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