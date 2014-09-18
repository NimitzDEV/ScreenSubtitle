Imports System.Text.RegularExpressions.Regex
Public Class frmMain
    Public now As Integer = -1
    Dim fontStyle As FontStyle
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Screen.AllScreens.Count < 2 Then
            If MsgBox("需要两个显示设备才能使用本程序，继续使用点击是", vbInformation + vbOKCancel, "TIPS") = MsgBoxResult.Cancel Then
                Application.Exit()
            End If
        End If
        showScreenSel()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If frmSubtitle.Visible = True Then
            btnShow.Text = "显示"
            frmSubtitle.Visible = False
        Else
            btnShow.Text = "隐藏"
            frmSubtitle.Visible = True
        End If
    End Sub

    Private Sub tbLocation_Scroll(sender As Object, e As EventArgs) Handles tbLocation.Scroll
        frmSubtitle.Top = subScreen.WorkingArea.Height * (tbLocation.Value / 100)
    End Sub

    Private Sub tbHeight_Scroll(sender As Object, e As EventArgs) Handles tbHeight.Scroll
        frmSubtitle.Height = subScreen.WorkingArea.Height * (tbHeight.Value / 50)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmSubtitle.Show()
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        fdStyle.ShowDialog()
        lbFontName.Text = (fdStyle.Font.Name)
        If fdStyle.Font.Bold Then fontStyle += Drawing.FontStyle.Bold
        If fdStyle.Font.Italic Then fontStyle += Drawing.FontStyle.Italic
        If fdStyle.Font.Underline Then fontStyle += Drawing.FontStyle.Underline
        applyChange()
    End Sub

    Private Sub applyChange()
        With frmSubtitle
            .Label1.Font = New Font(lbFontName.Text, .Label1.Font.Size, fontStyle)
        End With
        fontName = lbFontName.Text
        adjust()
    End Sub
    Private Sub applyNewText(ByVal TEXT As String)
        frmSubtitle.Label1.Text = IIf(cbXML.Checked, Unescape(TEXT.Trim), TEXT.Trim)
        adjust()
    End Sub

    Private Sub rbList_CheckedChanged(sender As Object, e As EventArgs) Handles rbList.CheckedChanged
        GroupBox4.Enabled = rbList.Checked
    End Sub

    Private Sub rbSingle_CheckedChanged(sender As Object, e As EventArgs) Handles rbSingle.CheckedChanged
        GroupBox3.Enabled = rbSingle.Checked
    End Sub

    Private Sub btnUpdateSingle_Click(sender As Object, e As EventArgs) Handles btnUpdateSingle.Click
        applyNewText(txtSubtitle.Text)
    End Sub

    Private Sub btnFontColor_Click(sender As Object, e As EventArgs) Handles btnFontColor.Click
        cdStyle.ShowDialog()
        pbFCPreview.BackColor = cdStyle.Color
        frmSubtitle.Label1.ForeColor = cdStyle.Color
    End Sub

    Private Sub btnBackColor_Click(sender As Object, e As EventArgs) Handles btnBackColor.Click
        cdStyle.ShowDialog()
        pbBackPreview.BackColor = cdStyle.Color
        frmSubtitle.BackColor = cdStyle.Color
    End Sub


    Private Sub btnChangeKC_Click(sender As Object, e As EventArgs) Handles btnChangeKC.Click
        cdStyle.ShowDialog()
        pbKC.BackColor = cdStyle.Color
        frmSubtitle.TransparencyKey = cdStyle.Color
    End Sub

    Private Sub cbTK_CheckedChanged(sender As Object, e As EventArgs) Handles cbTK.CheckedChanged
        btnChangeKC.Enabled = cbTK.Checked
        cbBackTrans.Enabled = cbTK.Checked
        If cbTK.Checked = False Then
            frmSubtitle.TransparencyKey = Color.Transparent
            btnBackColor.Enabled = True
            cbBackTrans.Checked = False
            frmSubtitle.AllowTransparency = False
        End If
        If cbTK.Checked = True Then
            frmSubtitle.TransparencyKey = pbKC.BackColor
            frmSubtitle.AllowTransparency = True
        End If
    End Sub

    Private Sub cbBackTrans_CheckedChanged(sender As Object, e As EventArgs) Handles cbBackTrans.CheckedChanged
        If cbTK.Checked = False Then Exit Sub
        btnBackColor.Enabled = Not cbBackTrans.Checked
        btnChangeKC.Enabled = btnBackColor.Enabled
        frmSubtitle.TransparencyKey = pbBackPreview.BackColor
        If cbBackTrans.Checked = False Then
            frmSubtitle.TransparencyKey = pbKC.BackColor
        End If
    End Sub

    Private Sub btnFull_Click(sender As Object, e As EventArgs) Handles btnFull.Click
        btnFull.Tag = tbHeight.Value
        btnUndo.Tag = tbLocation.Value
        btnUndo.Enabled = True
        tbHeight.Value = 50
        tbLocation.Value = 0
        frmSubtitle.Top = subScreen.WorkingArea.Height * (tbLocation.Value / 100)
        frmSubtitle.Height = subScreen.WorkingArea.Height * (tbHeight.Value / 50)
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        tbHeight.Value = btnFull.Tag
        tbLocation.Value = btnUndo.Tag
        btnUndo.Enabled = False
        frmSubtitle.Top = subScreen.WorkingArea.Height * (tbLocation.Value / 100)
        frmSubtitle.Height = subScreen.WorkingArea.Height * (tbHeight.Value / 50)
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.Text = "" Then Exit Sub
        applyNewText(ListBox1.Text)
        now = ListBox1.SelectedIndex
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click
        If ListBox1.Items.Count = 0 Then
            MsgBox("列表空")
            Exit Sub
        End If
        now += 1
        If now = ListBox1.Items.Count Then now = 0
        ListBox1.SetSelected(now, True)
        applyNewText(ListBox1.Text)
    End Sub

    Private Sub btnAddFile_Click(sender As Object, e As EventArgs) Handles btnAddFile.Click
        ofd.Multiselect = False
        ofd.Title = "选择txt文件"
        ofd.Filter = "文本文档 | *.txt"
        ofd.ShowDialog()
        If ofd.FileName = "" Then Exit Sub
        FileOpen(1, ofd.FileName, OpenMode.Input, OpenAccess.Read, OpenShare.Shared)
        Do Until EOF(1)
            ListBox1.Items.Add(LineInput(1).Trim)
            Application.DoEvents()
        Loop
        FileClose(1)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If ListBox1.Items.Count = 0 Then
            MsgBox("列表空")
            Exit Sub
        End If
        now -= 1
        If now < 0 Then now = ListBox1.Items.Count - 1
        ListBox1.SetSelected(now, True)
        applyNewText(ListBox1.Text)
    End Sub

    Private Sub btnAddList_Click(sender As Object, e As EventArgs) Handles btnAddList.Click
        If tbAdd.Text.Trim = "" Then
            MsgBox("内容为空")
            Exit Sub
        End If
        ListBox1.Items.Add(tbAdd.Text.Trim)
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://weibo.com/NimitzDEV")
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Process.Start("http://www.zhihu.com/people/NimitzDEV")
    End Sub

    Private Sub llbDetail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbDetail.LinkClicked
        Process.Start("http://baike.baidu.com/view/73.htm?fr=aladdin#6")
    End Sub

    Private Sub llbUpdate_Click(sender As Object, e As EventArgs) Handles llbUpdate.Click
        frmUpdate.ShowDialog()
    End Sub
End Class
