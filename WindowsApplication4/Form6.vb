Public Class viewForm

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainMenu.Hide()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mainMenu.Show()
    End Sub
End Class