Public Class mainMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        newAccountForm.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        viewForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub


    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewForm.Close()
        newAccountForm.Close()



    End Sub
End Class
