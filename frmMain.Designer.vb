<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnShow = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnFull = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbHeight = New System.Windows.Forms.TrackBar()
        Me.tbLocation = New System.Windows.Forms.TrackBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbXML = New System.Windows.Forms.CheckBox()
        Me.cbBackTrans = New System.Windows.Forms.CheckBox()
        Me.btnChangeKC = New System.Windows.Forms.Button()
        Me.pbKC = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTK = New System.Windows.Forms.CheckBox()
        Me.pbBackPreview = New System.Windows.Forms.PictureBox()
        Me.btnBackColor = New System.Windows.Forms.Button()
        Me.pbFCPreview = New System.Windows.Forms.PictureBox()
        Me.btnFontColor = New System.Windows.Forms.Button()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.lbFontName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rbList = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnAddList = New System.Windows.Forms.Button()
        Me.tbAdd = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAddFile = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnUpdateSingle = New System.Windows.Forms.Button()
        Me.txtSubtitle = New System.Windows.Forms.TextBox()
        Me.rbSingle = New System.Windows.Forms.RadioButton()
        Me.fdStyle = New System.Windows.Forms.FontDialog()
        Me.cdStyle = New System.Windows.Forms.ColorDialog()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbKC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBackPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFCPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(400, 2)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 22)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "隐藏"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUndo)
        Me.GroupBox1.Controls.Add(Me.btnFull)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbHeight)
        Me.GroupBox1.Controls.Add(Me.tbLocation)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 143)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "位置设置"
        '
        'btnUndo
        '
        Me.btnUndo.Enabled = False
        Me.btnUndo.Location = New System.Drawing.Point(87, 114)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnUndo.TabIndex = 5
        Me.btnUndo.Text = "还原更改"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnFull
        '
        Me.btnFull.Location = New System.Drawing.Point(6, 114)
        Me.btnFull.Name = "btnFull"
        Me.btnFull.Size = New System.Drawing.Size(75, 23)
        Me.btnFull.TabIndex = 4
        Me.btnFull.Text = "快速全屏"
        Me.btnFull.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "字幕最大横向屏占比"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "字幕位置"
        '
        'tbHeight
        '
        Me.tbHeight.BackColor = System.Drawing.Color.White
        Me.tbHeight.LargeChange = 2
        Me.tbHeight.Location = New System.Drawing.Point(136, 61)
        Me.tbHeight.Maximum = 50
        Me.tbHeight.Name = "tbHeight"
        Me.tbHeight.Size = New System.Drawing.Size(318, 45)
        Me.tbHeight.TabIndex = 1
        Me.tbHeight.Value = 2
        '
        'tbLocation
        '
        Me.tbLocation.BackColor = System.Drawing.Color.White
        Me.tbLocation.Location = New System.Drawing.Point(76, 20)
        Me.tbLocation.Maximum = 100
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Size = New System.Drawing.Size(378, 45)
        Me.tbLocation.TabIndex = 0
        Me.tbLocation.Value = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(477, 345)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(469, 319)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "外观控制"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbXML)
        Me.GroupBox2.Controls.Add(Me.cbBackTrans)
        Me.GroupBox2.Controls.Add(Me.btnChangeKC)
        Me.GroupBox2.Controls.Add(Me.pbKC)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbTK)
        Me.GroupBox2.Controls.Add(Me.pbBackPreview)
        Me.GroupBox2.Controls.Add(Me.btnBackColor)
        Me.GroupBox2.Controls.Add(Me.pbFCPreview)
        Me.GroupBox2.Controls.Add(Me.btnFontColor)
        Me.GroupBox2.Controls.Add(Me.btnFont)
        Me.GroupBox2.Controls.Add(Me.lbFontName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 161)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "颜色与字体"
        '
        'cbXML
        '
        Me.cbXML.AutoSize = True
        Me.cbXML.Location = New System.Drawing.Point(87, 109)
        Me.cbXML.Name = "cbXML"
        Me.cbXML.Size = New System.Drawing.Size(114, 16)
        Me.cbXML.TabIndex = 15
        Me.cbXML.Text = "启用XML符号转义"
        Me.cbXML.UseVisualStyleBackColor = True
        '
        'cbBackTrans
        '
        Me.cbBackTrans.AutoSize = True
        Me.cbBackTrans.Enabled = False
        Me.cbBackTrans.Location = New System.Drawing.Point(238, 104)
        Me.cbBackTrans.Name = "cbBackTrans"
        Me.cbBackTrans.Size = New System.Drawing.Size(96, 16)
        Me.cbBackTrans.TabIndex = 14
        Me.cbBackTrans.Text = "锁定背景透明"
        Me.cbBackTrans.UseVisualStyleBackColor = True
        '
        'btnChangeKC
        '
        Me.btnChangeKC.Enabled = False
        Me.btnChangeKC.Location = New System.Drawing.Point(361, 73)
        Me.btnChangeKC.Name = "btnChangeKC"
        Me.btnChangeKC.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeKC.TabIndex = 13
        Me.btnChangeKC.Text = "更改"
        Me.btnChangeKC.UseVisualStyleBackColor = True
        '
        'pbKC
        '
        Me.pbKC.BackColor = System.Drawing.SystemColors.Control
        Me.pbKC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbKC.Location = New System.Drawing.Point(331, 73)
        Me.pbKC.Name = "pbKC"
        Me.pbKC.Size = New System.Drawing.Size(24, 23)
        Me.pbKC.TabIndex = 12
        Me.pbKC.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "当前 Key Color"
        '
        'cbTK
        '
        Me.cbTK.AutoSize = True
        Me.cbTK.Location = New System.Drawing.Point(219, 51)
        Me.cbTK.Name = "cbTK"
        Me.cbTK.Size = New System.Drawing.Size(144, 16)
        Me.cbTK.TabIndex = 10
        Me.cbTK.Text = "启用 Transparent Key"
        Me.cbTK.UseVisualStyleBackColor = True
        '
        'pbBackPreview
        '
        Me.pbBackPreview.BackColor = System.Drawing.SystemColors.Control
        Me.pbBackPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbBackPreview.Location = New System.Drawing.Point(87, 80)
        Me.pbBackPreview.Name = "pbBackPreview"
        Me.pbBackPreview.Size = New System.Drawing.Size(24, 23)
        Me.pbBackPreview.TabIndex = 9
        Me.pbBackPreview.TabStop = False
        '
        'btnBackColor
        '
        Me.btnBackColor.Location = New System.Drawing.Point(6, 80)
        Me.btnBackColor.Name = "btnBackColor"
        Me.btnBackColor.Size = New System.Drawing.Size(75, 23)
        Me.btnBackColor.TabIndex = 8
        Me.btnBackColor.Text = "背景颜色"
        Me.btnBackColor.UseVisualStyleBackColor = True
        '
        'pbFCPreview
        '
        Me.pbFCPreview.BackColor = System.Drawing.Color.Black
        Me.pbFCPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbFCPreview.Location = New System.Drawing.Point(87, 51)
        Me.pbFCPreview.Name = "pbFCPreview"
        Me.pbFCPreview.Size = New System.Drawing.Size(24, 23)
        Me.pbFCPreview.TabIndex = 7
        Me.pbFCPreview.TabStop = False
        '
        'btnFontColor
        '
        Me.btnFontColor.Location = New System.Drawing.Point(6, 51)
        Me.btnFontColor.Name = "btnFontColor"
        Me.btnFontColor.Size = New System.Drawing.Size(75, 23)
        Me.btnFontColor.TabIndex = 6
        Me.btnFontColor.Text = "字体颜色"
        Me.btnFontColor.UseVisualStyleBackColor = True
        '
        'btnFont
        '
        Me.btnFont.Location = New System.Drawing.Point(6, 22)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(75, 23)
        Me.btnFont.TabIndex = 5
        Me.btnFont.Text = "选择字体"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'lbFontName
        '
        Me.lbFontName.AutoSize = True
        Me.lbFontName.Location = New System.Drawing.Point(87, 27)
        Me.lbFontName.Name = "lbFontName"
        Me.lbFontName.Size = New System.Drawing.Size(53, 12)
        Me.lbFontName.TabIndex = 4
        Me.lbFontName.Text = "Segoe UI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "*字体大小为自动计算，不支持更改"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rbList)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.rbSingle)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(469, 319)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "字幕控制"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'rbList
        '
        Me.rbList.AutoSize = True
        Me.rbList.Location = New System.Drawing.Point(16, 111)
        Me.rbList.Name = "rbList"
        Me.rbList.Size = New System.Drawing.Size(71, 16)
        Me.rbList.TabIndex = 2
        Me.rbList.TabStop = True
        Me.rbList.Text = "列表控制"
        Me.rbList.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnClean)
        Me.GroupBox4.Controls.Add(Me.btnAddList)
        Me.GroupBox4.Controls.Add(Me.tbAdd)
        Me.GroupBox4.Controls.Add(Me.btnPrevious)
        Me.GroupBox4.Controls.Add(Me.btnNext)
        Me.GroupBox4.Controls.Add(Me.btnAddFile)
        Me.GroupBox4.Controls.Add(Me.ListBox1)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(16, 122)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(435, 194)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(112, 165)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 23)
        Me.btnClean.TabIndex = 6
        Me.btnClean.Text = "清空列表"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnAddList
        '
        Me.btnAddList.Location = New System.Drawing.Point(112, 72)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(75, 23)
        Me.btnAddList.TabIndex = 5
        Me.btnAddList.Text = "添加"
        Me.btnAddList.UseVisualStyleBackColor = True
        '
        'tbAdd
        '
        Me.tbAdd.Location = New System.Drawing.Point(6, 11)
        Me.tbAdd.Multiline = True
        Me.tbAdd.Name = "tbAdd"
        Me.tbAdd.Size = New System.Drawing.Size(181, 55)
        Me.tbAdd.TabIndex = 4
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(273, 171)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.Text = "上一条"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(354, 171)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "下一条"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnAddFile
        '
        Me.btnAddFile.Location = New System.Drawing.Point(6, 165)
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.Size = New System.Drawing.Size(92, 23)
        Me.btnAddFile.TabIndex = 1
        Me.btnAddFile.Text = "添加txt文件"
        Me.btnAddFile.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(193, 11)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(236, 160)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnUpdateSingle)
        Me.GroupBox3.Controls.Add(Me.txtSubtitle)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(435, 77)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'btnUpdateSingle
        '
        Me.btnUpdateSingle.Location = New System.Drawing.Point(354, 46)
        Me.btnUpdateSingle.Name = "btnUpdateSingle"
        Me.btnUpdateSingle.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateSingle.TabIndex = 1
        Me.btnUpdateSingle.Text = "更新"
        Me.btnUpdateSingle.UseVisualStyleBackColor = True
        '
        'txtSubtitle
        '
        Me.txtSubtitle.Location = New System.Drawing.Point(6, 20)
        Me.txtSubtitle.Name = "txtSubtitle"
        Me.txtSubtitle.Size = New System.Drawing.Size(423, 21)
        Me.txtSubtitle.TabIndex = 0
        Me.txtSubtitle.Text = "Subtitle initial"
        '
        'rbSingle
        '
        Me.rbSingle.AutoSize = True
        Me.rbSingle.Checked = True
        Me.rbSingle.Location = New System.Drawing.Point(16, 6)
        Me.rbSingle.Name = "rbSingle"
        Me.rbSingle.Size = New System.Drawing.Size(71, 16)
        Me.rbSingle.TabIndex = 0
        Me.rbSingle.TabStop = True
        Me.rbSingle.Text = "单独控制"
        Me.rbSingle.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.LinkLabel8)
        Me.TabPage3.Controls.Add(Me.LinkLabel2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(469, 319)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "关于"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(77, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Powered by "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 42.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(66, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(336, 75)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "NimitzDEV"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkLabel8.Location = New System.Drawing.Point(137, 101)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(29, 12)
        Me.LinkLabel8.TabIndex = 20
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "知乎"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LinkLabel2.Location = New System.Drawing.Point(78, 101)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(53, 12)
        Me.LinkLabel2.TabIndex = 19
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "新浪微博"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.分屏字幕.My.Resources.Resources.alipayqrcode
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(263, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(17, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 24)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "如果你喜欢本软件" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "欢迎通过手机支付宝扫描二维码给我捐助哦~"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 351)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "控制器"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbKC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBackPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFCPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbHeight As System.Windows.Forms.TrackBar
    Friend WithEvents tbLocation As System.Windows.Forms.TrackBar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnFont As System.Windows.Forms.Button
    Friend WithEvents lbFontName As System.Windows.Forms.Label
    Friend WithEvents fdStyle As System.Windows.Forms.FontDialog
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbList As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdateSingle As System.Windows.Forms.Button
    Friend WithEvents txtSubtitle As System.Windows.Forms.TextBox
    Friend WithEvents rbSingle As System.Windows.Forms.RadioButton
    Friend WithEvents pbFCPreview As System.Windows.Forms.PictureBox
    Friend WithEvents btnFontColor As System.Windows.Forms.Button
    Friend WithEvents cdStyle As System.Windows.Forms.ColorDialog
    Friend WithEvents pbBackPreview As System.Windows.Forms.PictureBox
    Friend WithEvents btnBackColor As System.Windows.Forms.Button
    Friend WithEvents pbKC As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbTK As System.Windows.Forms.CheckBox
    Friend WithEvents cbBackTrans As System.Windows.Forms.CheckBox
    Friend WithEvents btnChangeKC As System.Windows.Forms.Button
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents btnFull As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnAddFile As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnAddList As System.Windows.Forms.Button
    Friend WithEvents tbAdd As System.Windows.Forms.TextBox
    Friend WithEvents btnClean As System.Windows.Forms.Button
    Friend WithEvents cbXML As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
