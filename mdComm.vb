Module mdComm
    'SETTINGS
    Public fontName As String = "Segoe UI"
    '====
    Public subScreen As Screen
    Public mainScreen As Screen
    Dim frm1 As New frmTest
    Dim frm2 As New frmTest
    Public Sub cleanSelForm(ByVal tagV As Integer)
        subScreen = Screen.AllScreens(tagV)
        mainScreen = Screen.AllScreens(IIf(Screen.AllScreens.Count < 2, 0, IIf(tagV = 0, 1, 0)))
        frm1.Dispose()
        frm2.Dispose()
        frmMain.Location = mainScreen.Bounds.Location
        frmMain.Enabled = True
        frmMain.Show()
        frmSubtitle.Show()
        Debug.Print(tagV)
    End Sub
    Public Sub showScreenSel()
        frmMain.Enabled = False
        frm1.Tag = 0
        frm2.Tag = 1
        Dim screens As Screen
        screens = Screen.AllScreens(0)
        frm1.Location = screens.Bounds.Location + New Point((screens.WorkingArea.Width - frm1.Width) / 2, (screens.WorkingArea.Height - frm1.Height) / 2)
        frm1.Show()
        If Screen.AllScreens.Count < 2 Then Exit Sub
        screens = Screen.AllScreens(1)
        frm2.Location = screens.Bounds.Location + New Point((screens.WorkingArea.Width - frm1.Width) / 2, (screens.WorkingArea.Height - frm1.Height) / 2)
        frm2.Show()
        frm2.Label1.Text = "2"
    End Sub
    Public Sub adjust()
        With frmSubtitle
            Dim counter As Integer = 1
            .Label1.Visible = False
            Do
                .Label1.Font = New Font(fontName, counter)
                If .Label1.Width >= .ClientSize.Width Or .Label1.Height >= .ClientSize.Height Then
                    If counter - 5 > 1 Then counter -= 5
                    Exit Do
                End If
                If .Label1.Width < .ClientSize.Width And .Label1.Height < .ClientSize.Height Then
                    counter += 5
                End If
                Application.DoEvents()
            Loop
            .Label1.Font = New Font(fontName, counter)
            .Label1.Top = (frmSubtitle.Height - .Label1.Height) / 2
            .Label1.Left = (.Width - .Label1.Width) / 2
            .Label1.Visible = True
            Debug.Print(counter / .Width)
            Debug.Print(counter / .Height)
        End With
    End Sub
End Module
