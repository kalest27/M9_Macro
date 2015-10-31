<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbbcbbDefaultSecondDirection = New System.Windows.Forms.ComboBox()
        Me.NmrDefaultTestNumber = New System.Windows.Forms.NumericUpDown()
        Me.NmrDefaultTestCount = New System.Windows.Forms.NumericUpDown()
        Me.NmrDefaultTime = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbbDefaultFirstDirection = New System.Windows.Forms.ComboBox()
        Me.chbDefaultAutoAdd = New System.Windows.Forms.CheckBox()
        Me.NmrDefaultNumericCount = New System.Windows.Forms.NumericUpDown()
        Me.txtDefaultFolderName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.NmrMoveYPosition = New System.Windows.Forms.NumericUpDown()
        Me.NmrMoveXPosition = New System.Windows.Forms.NumericUpDown()
        Me.NmrMoveRowCount = New System.Windows.Forms.NumericUpDown()
        Me.NmrMoveColumnCount = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnPathFolderSelect = New System.Windows.Forms.Button()
        Me.txtPathSaveFolder = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chbPremiumPositionUpdate = New System.Windows.Forms.CheckBox()
        Me.chbPremiumTargetEnd = New System.Windows.Forms.CheckBox()
        Me.chbPremiumStatusBar = New System.Windows.Forms.CheckBox()
        Me.chbPremiumRightEnd = New System.Windows.Forms.CheckBox()
        Me.btnMacroReady = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbModelName = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.종료ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.파일FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.새로만들기NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.열기OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.저장SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.다른이름으로저장ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.정보ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NmrDefaultTestNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrDefaultTestCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrDefaultTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrDefaultNumericCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.NmrMoveYPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrMoveXPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrMoveRowCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrMoveColumnCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbbcbbDefaultSecondDirection)
        Me.GroupBox2.Controls.Add(Me.NmrDefaultTestNumber)
        Me.GroupBox2.Controls.Add(Me.NmrDefaultTestCount)
        Me.GroupBox2.Controls.Add(Me.NmrDefaultTime)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbbDefaultFirstDirection)
        Me.GroupBox2.Controls.Add(Me.chbDefaultAutoAdd)
        Me.GroupBox2.Controls.Add(Me.NmrDefaultNumericCount)
        Me.GroupBox2.Controls.Add(Me.txtDefaultFolderName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'cbbcbbDefaultSecondDirection
        '
        Me.cbbcbbDefaultSecondDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbbcbbDefaultSecondDirection, "cbbcbbDefaultSecondDirection")
        Me.cbbcbbDefaultSecondDirection.FormattingEnabled = True
        Me.cbbcbbDefaultSecondDirection.Items.AddRange(New Object() {resources.GetString("cbbcbbDefaultSecondDirection.Items"), resources.GetString("cbbcbbDefaultSecondDirection.Items1"), resources.GetString("cbbcbbDefaultSecondDirection.Items2"), resources.GetString("cbbcbbDefaultSecondDirection.Items3")})
        Me.cbbcbbDefaultSecondDirection.Name = "cbbcbbDefaultSecondDirection"
        '
        'NmrDefaultTestNumber
        '
        resources.ApplyResources(Me.NmrDefaultTestNumber, "NmrDefaultTestNumber")
        Me.NmrDefaultTestNumber.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NmrDefaultTestNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NmrDefaultTestNumber.Name = "NmrDefaultTestNumber"
        Me.NmrDefaultTestNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NmrDefaultTestCount
        '
        resources.ApplyResources(Me.NmrDefaultTestCount, "NmrDefaultTestCount")
        Me.NmrDefaultTestCount.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.NmrDefaultTestCount.Name = "NmrDefaultTestCount"
        Me.NmrDefaultTestCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NmrDefaultTime
        '
        resources.ApplyResources(Me.NmrDefaultTime, "NmrDefaultTime")
        Me.NmrDefaultTime.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NmrDefaultTime.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NmrDefaultTime.Minimum = New Decimal(New Integer() {1200, 0, 0, 0})
        Me.NmrDefaultTime.Name = "NmrDefaultTime"
        Me.NmrDefaultTime.Value = New Decimal(New Integer() {1200, 0, 0, 0})
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'cbbDefaultFirstDirection
        '
        Me.cbbDefaultFirstDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbbDefaultFirstDirection, "cbbDefaultFirstDirection")
        Me.cbbDefaultFirstDirection.FormattingEnabled = True
        Me.cbbDefaultFirstDirection.Items.AddRange(New Object() {resources.GetString("cbbDefaultFirstDirection.Items"), resources.GetString("cbbDefaultFirstDirection.Items1"), resources.GetString("cbbDefaultFirstDirection.Items2"), resources.GetString("cbbDefaultFirstDirection.Items3")})
        Me.cbbDefaultFirstDirection.Name = "cbbDefaultFirstDirection"
        '
        'chbDefaultAutoAdd
        '
        resources.ApplyResources(Me.chbDefaultAutoAdd, "chbDefaultAutoAdd")
        Me.chbDefaultAutoAdd.Checked = True
        Me.chbDefaultAutoAdd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbDefaultAutoAdd.Name = "chbDefaultAutoAdd"
        Me.chbDefaultAutoAdd.UseVisualStyleBackColor = True
        '
        'NmrDefaultNumericCount
        '
        resources.ApplyResources(Me.NmrDefaultNumericCount, "NmrDefaultNumericCount")
        Me.NmrDefaultNumericCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NmrDefaultNumericCount.Name = "NmrDefaultNumericCount"
        Me.NmrDefaultNumericCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtDefaultFolderName
        '
        resources.ApplyResources(Me.txtDefaultFolderName, "txtDefaultFolderName")
        Me.txtDefaultFolderName.Name = "txtDefaultFolderName"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.NmrMoveYPosition)
        Me.GroupBox5.Controls.Add(Me.NmrMoveXPosition)
        Me.GroupBox5.Controls.Add(Me.NmrMoveRowCount)
        Me.GroupBox5.Controls.Add(Me.NmrMoveColumnCount)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'NmrMoveYPosition
        '
        Me.NmrMoveYPosition.DecimalPlaces = 1
        resources.ApplyResources(Me.NmrMoveYPosition, "NmrMoveYPosition")
        Me.NmrMoveYPosition.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NmrMoveYPosition.Name = "NmrMoveYPosition"
        '
        'NmrMoveXPosition
        '
        Me.NmrMoveXPosition.DecimalPlaces = 1
        resources.ApplyResources(Me.NmrMoveXPosition, "NmrMoveXPosition")
        Me.NmrMoveXPosition.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NmrMoveXPosition.Name = "NmrMoveXPosition"
        '
        'NmrMoveRowCount
        '
        resources.ApplyResources(Me.NmrMoveRowCount, "NmrMoveRowCount")
        Me.NmrMoveRowCount.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NmrMoveRowCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NmrMoveRowCount.Name = "NmrMoveRowCount"
        Me.NmrMoveRowCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NmrMoveColumnCount
        '
        resources.ApplyResources(Me.NmrMoveColumnCount, "NmrMoveColumnCount")
        Me.NmrMoveColumnCount.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NmrMoveColumnCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NmrMoveColumnCount.Name = "NmrMoveColumnCount"
        Me.NmrMoveColumnCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnPathFolderSelect)
        Me.GroupBox4.Controls.Add(Me.txtPathSaveFolder)
        Me.GroupBox4.Controls.Add(Me.Label11)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'btnPathFolderSelect
        '
        resources.ApplyResources(Me.btnPathFolderSelect, "btnPathFolderSelect")
        Me.btnPathFolderSelect.Name = "btnPathFolderSelect"
        Me.btnPathFolderSelect.UseVisualStyleBackColor = True
        '
        'txtPathSaveFolder
        '
        resources.ApplyResources(Me.txtPathSaveFolder, "txtPathSaveFolder")
        Me.txtPathSaveFolder.Name = "txtPathSaveFolder"
        Me.txtPathSaveFolder.ReadOnly = True
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        resources.ApplyResources(Me.TabPage5, "TabPage5")
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chbPremiumPositionUpdate)
        Me.GroupBox3.Controls.Add(Me.chbPremiumTargetEnd)
        Me.GroupBox3.Controls.Add(Me.chbPremiumStatusBar)
        Me.GroupBox3.Controls.Add(Me.chbPremiumRightEnd)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'chbPremiumPositionUpdate
        '
        resources.ApplyResources(Me.chbPremiumPositionUpdate, "chbPremiumPositionUpdate")
        Me.chbPremiumPositionUpdate.Checked = True
        Me.chbPremiumPositionUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbPremiumPositionUpdate.Name = "chbPremiumPositionUpdate"
        Me.chbPremiumPositionUpdate.UseVisualStyleBackColor = True
        '
        'chbPremiumTargetEnd
        '
        resources.ApplyResources(Me.chbPremiumTargetEnd, "chbPremiumTargetEnd")
        Me.chbPremiumTargetEnd.Checked = True
        Me.chbPremiumTargetEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbPremiumTargetEnd.Name = "chbPremiumTargetEnd"
        Me.chbPremiumTargetEnd.UseVisualStyleBackColor = True
        '
        'chbPremiumStatusBar
        '
        resources.ApplyResources(Me.chbPremiumStatusBar, "chbPremiumStatusBar")
        Me.chbPremiumStatusBar.Checked = True
        Me.chbPremiumStatusBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbPremiumStatusBar.Name = "chbPremiumStatusBar"
        Me.chbPremiumStatusBar.UseVisualStyleBackColor = True
        '
        'chbPremiumRightEnd
        '
        resources.ApplyResources(Me.chbPremiumRightEnd, "chbPremiumRightEnd")
        Me.chbPremiumRightEnd.Checked = True
        Me.chbPremiumRightEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbPremiumRightEnd.Name = "chbPremiumRightEnd"
        Me.chbPremiumRightEnd.UseVisualStyleBackColor = True
        '
        'btnMacroReady
        '
        resources.ApplyResources(Me.btnMacroReady, "btnMacroReady")
        Me.btnMacroReady.Name = "btnMacroReady"
        Me.btnMacroReady.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        resources.ApplyResources(Me.TabControl2, "TabControl2")
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbModelName)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lbModelName
        '
        resources.ApplyResources(Me.lbModelName, "lbModelName")
        Me.lbModelName.Name = "lbModelName"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.종료ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        '종료ToolStripMenuItem1
        '
        Me.종료ToolStripMenuItem1.Name = "종료ToolStripMenuItem1"
        resources.ApplyResources(Me.종료ToolStripMenuItem1, "종료ToolStripMenuItem1")
        '
        '파일FToolStripMenuItem
        '
        Me.파일FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.새로만들기NToolStripMenuItem, Me.열기OToolStripMenuItem, Me.저장SToolStripMenuItem, Me.다른이름으로저장ToolStripMenuItem, Me.ToolStripMenuItem1, Me.종료ToolStripMenuItem})
        Me.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem"
        resources.ApplyResources(Me.파일FToolStripMenuItem, "파일FToolStripMenuItem")
        '
        '새로만들기NToolStripMenuItem
        '
        Me.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem"
        resources.ApplyResources(Me.새로만들기NToolStripMenuItem, "새로만들기NToolStripMenuItem")
        '
        '열기OToolStripMenuItem
        '
        Me.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem"
        resources.ApplyResources(Me.열기OToolStripMenuItem, "열기OToolStripMenuItem")
        '
        '저장SToolStripMenuItem
        '
        resources.ApplyResources(Me.저장SToolStripMenuItem, "저장SToolStripMenuItem")
        Me.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem"
        '
        '다른이름으로저장ToolStripMenuItem
        '
        resources.ApplyResources(Me.다른이름으로저장ToolStripMenuItem, "다른이름으로저장ToolStripMenuItem")
        Me.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        '종료ToolStripMenuItem
        '
        Me.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem"
        resources.ApplyResources(Me.종료ToolStripMenuItem, "종료ToolStripMenuItem")
        '
        '도움말HToolStripMenuItem
        '
        Me.도움말HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.정보ToolStripMenuItem})
        Me.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem"
        resources.ApplyResources(Me.도움말HToolStripMenuItem, "도움말HToolStripMenuItem")
        '
        '정보ToolStripMenuItem
        '
        Me.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem"
        resources.ApplyResources(Me.정보ToolStripMenuItem, "정보ToolStripMenuItem")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일FToolStripMenuItem, Me.도움말HToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'mainForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnMacroReady)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mainForm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NmrDefaultTestNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrDefaultTestCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrDefaultTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrDefaultNumericCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.NmrMoveYPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrMoveXPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrMoveRowCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrMoveColumnCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents chbPremiumTargetEnd As System.Windows.Forms.CheckBox
    Friend WithEvents chbPremiumRightEnd As System.Windows.Forms.CheckBox
    Friend WithEvents chbPremiumStatusBar As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btnPathFolderSelect As System.Windows.Forms.Button
    Friend WithEvents txtPathSaveFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnMacroReady As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents chbPremiumPositionUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbModelName As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents 파일FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 새로만들기NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 열기OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 저장SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 종료ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 도움말HToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 정보ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 종료ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents 다른이름으로저장ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDefaultFolderName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NmrDefaultNumericCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents chbDefaultAutoAdd As System.Windows.Forms.CheckBox
    Friend WithEvents cbbDefaultFirstDirection As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NmrDefaultTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents NmrMoveRowCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents NmrMoveColumnCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents NmrDefaultTestCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents NmrDefaultTestNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbbcbbDefaultSecondDirection As System.Windows.Forms.ComboBox
    Friend WithEvents NmrMoveYPosition As System.Windows.Forms.NumericUpDown
    Friend WithEvents NmrMoveXPosition As System.Windows.Forms.NumericUpDown
End Class
