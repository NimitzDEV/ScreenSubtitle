Public Class frmSubtitle
    Dim ok As Boolean = False
    Private Sub frmSubtitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = subScreen.Bounds.Location
        Me.Width = subScreen.WorkingArea.Width
        Me.Height = subScreen.WorkingArea.Height * (frmMain.tbHeight.Value / 50)
        Me.Top = subScreen.WorkingArea.Height * (frmMain.tbLocation.Value / 100)
        adjust()
        ok = True
    End Sub



    Private Sub frmSubtitle_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If ok = False Then Exit Sub
        adjust()
    End Sub
End Class