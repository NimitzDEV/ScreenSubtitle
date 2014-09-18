Public Class frmTest

    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Location = New Point((Me.Width - Label1.Width) / 2, (Me.Height - Label1.Height) / 2)
        Button1.Location = New Point((Me.Width - Button1.Width) / 2, (Me.Height * 0.7))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cleanSelForm(Me.Tag)
    End Sub
End Class