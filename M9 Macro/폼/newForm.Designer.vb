<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newForm))
        Me.txtModelName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnPathFolderSelect = New System.Windows.Forms.Button()
        Me.txtPathSaveFolder = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chbPremiumPositionUpdate = New System.Windows.Forms.CheckBox()
        Me.chbPremiumTargetEnd = New System.Windows.Forms.CheckBox()
        Me.chbPremiumStatusBar = New System.Windows.Forms.CheckBox()
        Me.chbPremiumRightEnd = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NmrDefaultTestNumber = New System.Windows.Forms.NumericUpDown()
        Me.cbbcbbDefaultSecondDirection = New System.Windows.Forms.ComboBox()
        Me.NmrDefaultTestCount = New System.Windows.Forms.NumericUpDown()
        Me.NmrDefaultTime = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbbDefaultFirstDirection = New System.Windows.Forms.ComboBox()
        Me.chbDefaultAutoAdd = New System.Windows.Forms.CheckBox()
        Me.NmrDefaultNumericCount = New System.Windows.Forms.NumericUpDown()
        Me.txtDefaultFolderName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.NmrMoveRowCount = New System.Windows.Forms.NumericUpDown()
        Me.NmrMoveColumnCount = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NmrMoveYPosition = New System.Windows.Forms.NumericUpDown()
        Me.NmrMoveXPosition = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NmrDefaultTestNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrDefaultTestCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrDefaultTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrDefaultNumericCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NmrMoveRowCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrMoveColumnCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrMoveYPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrMoveXPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtModelName
        '
        Me.txtModelName.Location = New System.Drawing.Point(46, 20)
        Me.txtModelName.Name = "txtModelName"
        Me.txtModelName.Size = New System.Drawing.Size(100, 21)
        Me.txtModelName.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtModelName)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 53)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "모델명"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "이름 :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(553, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "저장"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnPathFolderSelect)
        Me.GroupBox4.Controls.Add(Me.txtPathSaveFolder)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 203)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(306, 130)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "경로 설정"
        '
        'btnPathFolderSelect
        '
        Me.btnPathFolderSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPathFolderSelect.Location = New System.Drawing.Point(271, 15)
        Me.btnPathFolderSelect.Name = "btnPathFolderSelect"
        Me.btnPathFolderSelect.Size = New System.Drawing.Size(25, 23)
        Me.btnPathFolderSelect.TabIndex = 5
        Me.btnPathFolderSelect.Text = "..."
        Me.btnPathFolderSelect.UseVisualStyleBackColor = True
        '
        'txtPathSaveFolder
        '
        Me.txtPathSaveFolder.Location = New System.Drawing.Point(98, 16)
        Me.txtPathSaveFolder.Name = "txtPathSaveFolder"
        Me.txtPathSaveFolder.ReadOnly = True
        Me.txtPathSaveFolder.Size = New System.Drawing.Size(167, 21)
        Me.txtPathSaveFolder.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(7, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 12)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "자동 캡쳐 폴더:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chbPremiumPositionUpdate)
        Me.GroupBox3.Controls.Add(Me.chbPremiumTargetEnd)
        Me.GroupBox3.Controls.Add(Me.chbPremiumStatusBar)
        Me.GroupBox3.Controls.Add(Me.chbPremiumRightEnd)
        Me.GroupBox3.Location = New System.Drawing.Point(321, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(306, 130)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "고급 설정"
        '
        'chbPremiumPositionUpdate
        '
        Me.chbPremiumPositionUpdate.AutoSize = True
        Me.chbPremiumPositionUpdate.Checked = True
        Me.chbPremiumPositionUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbPremiumPositionUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chbPremiumPositionUpdate.Location = New System.Drawing.Point(9, 79)
        Me.chbPremiumPositionUpdate.Name = "chbPremiumPositionUpdate"
        Me.chbPremiumPositionUpdate.Size = New System.Drawing.Size(144, 16)
        Me.chbPremiumPositionUpdate.TabIndex = 6
        Me.chbPremiumPositionUpdate.Text = "이동 좌표의 자동 갱신"
        Me.chbPremiumPositionUpdate.UseVisualStyleBackColor = True
        '
        'chbPremiumTargetEnd
        '
        Me.chbPremiumTargetEnd.AutoSize = True
        Me.chbPremiumTargetEnd.Checked = True
        Me.chbPremiumTargetEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbPremiumTargetEnd.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbPremiumTargetEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chbPremiumTargetEnd.Location = New System.Drawing.Point(9, 59)
        Me.chbPremiumTargetEnd.Name = "chbPremiumTargetEnd"
        Me.chbPremiumTargetEnd.Size = New System.Drawing.Size(246, 16)
        Me.chbPremiumTargetEnd.TabIndex = 5
        Me.chbPremiumTargetEnd.Text = "검사 수량에 도달하면 자동 종료 (미작동)"
        Me.chbPremiumTargetEnd.UseVisualStyleBackColor = True
        '
        'chbPremiumStatusBar
        '
        Me.chbPremiumStatusBar.AutoSize = True
        Me.chbPremiumStatusBar.Checked = True
        Me.chbPremiumStatusBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbPremiumStatusBar.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbPremiumStatusBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chbPremiumStatusBar.Location = New System.Drawing.Point(9, 19)
        Me.chbPremiumStatusBar.Name = "chbPremiumStatusBar"
        Me.chbPremiumStatusBar.Size = New System.Drawing.Size(166, 16)
        Me.chbPremiumStatusBar.TabIndex = 3
        Me.chbPremiumStatusBar.Text = "진행 상황 보이기 (미작동)"
        Me.chbPremiumStatusBar.UseVisualStyleBackColor = True
        '
        'chbPremiumRightEnd
        '
        Me.chbPremiumRightEnd.AutoSize = True
        Me.chbPremiumRightEnd.Checked = True
        Me.chbPremiumRightEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbPremiumRightEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chbPremiumRightEnd.Location = New System.Drawing.Point(9, 39)
        Me.chbPremiumRightEnd.Name = "chbPremiumRightEnd"
        Me.chbPremiumRightEnd.Size = New System.Drawing.Size(210, 16)
        Me.chbPremiumRightEnd.TabIndex = 4
        Me.chbPremiumRightEnd.Text = "(→) 키를 누르면 X-Ray 자동 종료"
        Me.chbPremiumRightEnd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NmrDefaultTestNumber)
        Me.GroupBox2.Controls.Add(Me.cbbcbbDefaultSecondDirection)
        Me.GroupBox2.Controls.Add(Me.NmrDefaultTestCount)
        Me.GroupBox2.Controls.Add(Me.NmrDefaultTime)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbbDefaultFirstDirection)
        Me.GroupBox2.Controls.Add(Me.chbDefaultAutoAdd)
        Me.GroupBox2.Controls.Add(Me.NmrDefaultNumericCount)
        Me.GroupBox2.Controls.Add(Me.txtDefaultFolderName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 130)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "기본 설정"
        '
        'NmrDefaultTestNumber
        '
        Me.NmrDefaultTestNumber.Location = New System.Drawing.Point(131, 71)
        Me.NmrDefaultTestNumber.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NmrDefaultTestNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NmrDefaultTestNumber.Name = "NmrDefaultTestNumber"
        Me.NmrDefaultTestNumber.Size = New System.Drawing.Size(40, 21)
        Me.NmrDefaultTestNumber.TabIndex = 31
        Me.NmrDefaultTestNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NmrDefaultTestNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbbcbbDefaultSecondDirection
        '
        Me.cbbcbbDefaultSecondDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbcbbDefaultSecondDirection.Enabled = False
        Me.cbbcbbDefaultSecondDirection.FormattingEnabled = True
        Me.cbbcbbDefaultSecondDirection.Items.AddRange(New Object() {"→", "←", "↓", "↑"})
        Me.cbbcbbDefaultSecondDirection.Location = New System.Drawing.Point(131, 45)
        Me.cbbcbbDefaultSecondDirection.Name = "cbbcbbDefaultSecondDirection"
        Me.cbbcbbDefaultSecondDirection.Size = New System.Drawing.Size(40, 20)
        Me.cbbcbbDefaultSecondDirection.TabIndex = 31
        '
        'NmrDefaultTestCount
        '
        Me.NmrDefaultTestCount.Location = New System.Drawing.Point(70, 71)
        Me.NmrDefaultTestCount.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NmrDefaultTestCount.Name = "NmrDefaultTestCount"
        Me.NmrDefaultTestCount.ReadOnly = True
        Me.NmrDefaultTestCount.Size = New System.Drawing.Size(56, 21)
        Me.NmrDefaultTestCount.TabIndex = 28
        Me.NmrDefaultTestCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NmrDefaultTestCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NmrDefaultTime
        '
        Me.NmrDefaultTime.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NmrDefaultTime.Location = New System.Drawing.Point(70, 18)
        Me.NmrDefaultTime.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NmrDefaultTime.Minimum = New Decimal(New Integer() {1200, 0, 0, 0})
        Me.NmrDefaultTime.Name = "NmrDefaultTime"
        Me.NmrDefaultTime.Size = New System.Drawing.Size(56, 21)
        Me.NmrDefaultTime.TabIndex = 27
        Me.NmrDefaultTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NmrDefaultTime.Value = New Decimal(New Integer() {1200, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(6, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 12)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "시작 방향:"
        '
        'cbbDefaultFirstDirection
        '
        Me.cbbDefaultFirstDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbDefaultFirstDirection.FormattingEnabled = True
        Me.cbbDefaultFirstDirection.Items.AddRange(New Object() {"→", "←", "↓", "↑"})
        Me.cbbDefaultFirstDirection.Location = New System.Drawing.Point(70, 45)
        Me.cbbDefaultFirstDirection.Name = "cbbDefaultFirstDirection"
        Me.cbbDefaultFirstDirection.Size = New System.Drawing.Size(56, 20)
        Me.cbbDefaultFirstDirection.TabIndex = 25
        '
        'chbDefaultAutoAdd
        '
        Me.chbDefaultAutoAdd.AutoSize = True
        Me.chbDefaultAutoAdd.Checked = True
        Me.chbDefaultAutoAdd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbDefaultAutoAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chbDefaultAutoAdd.Location = New System.Drawing.Point(177, 101)
        Me.chbDefaultAutoAdd.Name = "chbDefaultAutoAdd"
        Me.chbDefaultAutoAdd.Size = New System.Drawing.Size(76, 16)
        Me.chbDefaultAutoAdd.TabIndex = 24
        Me.chbDefaultAutoAdd.Text = "자동 증가"
        Me.chbDefaultAutoAdd.UseVisualStyleBackColor = True
        '
        'NmrDefaultNumericCount
        '
        Me.NmrDefaultNumericCount.Location = New System.Drawing.Point(131, 98)
        Me.NmrDefaultNumericCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NmrDefaultNumericCount.Name = "NmrDefaultNumericCount"
        Me.NmrDefaultNumericCount.Size = New System.Drawing.Size(40, 21)
        Me.NmrDefaultNumericCount.TabIndex = 23
        Me.NmrDefaultNumericCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NmrDefaultNumericCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtDefaultFolderName
        '
        Me.txtDefaultFolderName.Location = New System.Drawing.Point(70, 98)
        Me.txtDefaultFolderName.Name = "txtDefaultFolderName"
        Me.txtDefaultFolderName.Size = New System.Drawing.Size(56, 21)
        Me.txtDefaultFolderName.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(22, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 12)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "폴더명:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 12)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "검사 수량:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 12)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "이동 속도:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(130, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 12)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ms"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.NmrMoveYPosition)
        Me.GroupBox5.Controls.Add(Me.NmrMoveXPosition)
        Me.GroupBox5.Controls.Add(Me.NmrMoveRowCount)
        Me.GroupBox5.Controls.Add(Me.NmrMoveColumnCount)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(321, 67)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(306, 130)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "이동 설정"
        '
        'NmrMoveRowCount
        '
        Me.NmrMoveRowCount.Location = New System.Drawing.Point(43, 45)
        Me.NmrMoveRowCount.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NmrMoveRowCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NmrMoveRowCount.Name = "NmrMoveRowCount"
        Me.NmrMoveRowCount.Size = New System.Drawing.Size(68, 21)
        Me.NmrMoveRowCount.TabIndex = 10
        Me.NmrMoveRowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NmrMoveRowCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NmrMoveColumnCount
        '
        Me.NmrMoveColumnCount.Location = New System.Drawing.Point(43, 18)
        Me.NmrMoveColumnCount.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NmrMoveColumnCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NmrMoveColumnCount.Name = "NmrMoveColumnCount"
        Me.NmrMoveColumnCount.Size = New System.Drawing.Size(68, 21)
        Me.NmrMoveColumnCount.TabIndex = 9
        Me.NmrMoveColumnCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NmrMoveColumnCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(7, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 12)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "세로:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(7, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 12)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "가로:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(23, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "X:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(23, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 12)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Y:"
        '
        'NmrMoveYPosition
        '
        Me.NmrMoveYPosition.DecimalPlaces = 1
        Me.NmrMoveYPosition.Location = New System.Drawing.Point(43, 99)
        Me.NmrMoveYPosition.Name = "NmrMoveYPosition"
        Me.NmrMoveYPosition.Size = New System.Drawing.Size(68, 21)
        Me.NmrMoveYPosition.TabIndex = 14
        Me.NmrMoveYPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NmrMoveXPosition
        '
        Me.NmrMoveXPosition.DecimalPlaces = 1
        Me.NmrMoveXPosition.Location = New System.Drawing.Point(43, 72)
        Me.NmrMoveXPosition.Name = "NmrMoveXPosition"
        Me.NmrMoveXPosition.Size = New System.Drawing.Size(68, 21)
        Me.NmrMoveXPosition.TabIndex = 13
        Me.NmrMoveXPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'newForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 371)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "M9 Macro - 새로 만들기"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NmrDefaultTestNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrDefaultTestCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrDefaultTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrDefaultNumericCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NmrMoveRowCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrMoveColumnCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrMoveYPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrMoveXPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtModelName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPathFolderSelect As System.Windows.Forms.Button
    Friend WithEvents txtPathSaveFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chbPremiumPositionUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents chbPremiumTargetEnd As System.Windows.Forms.CheckBox
    Friend WithEvents chbPremiumStatusBar As System.Windows.Forms.CheckBox
    Friend WithEvents chbPremiumRightEnd As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NmrDefaultTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbbDefaultFirstDirection As System.Windows.Forms.ComboBox
    Friend WithEvents chbDefaultAutoAdd As System.Windows.Forms.CheckBox
    Friend WithEvents NmrDefaultNumericCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDefaultFolderName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents NmrMoveRowCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents NmrMoveColumnCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NmrDefaultTestCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbbcbbDefaultSecondDirection As System.Windows.Forms.ComboBox
    Friend WithEvents NmrDefaultTestNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents NmrMoveYPosition As System.Windows.Forms.NumericUpDown
    Friend WithEvents NmrMoveXPosition As System.Windows.Forms.NumericUpDown
End Class
