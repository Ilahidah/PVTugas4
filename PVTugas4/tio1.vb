Public Class tio1
    Private Sub btnSayHello_Click(sender As Object, e As EventArgs) Handles btnSayHello.Click
        MessageBox.Show("Hello World!", Me.Text)
    End Sub
    Private Sub btnSayHello_MouseEnter(sender As Object, e As EventArgs) Handles btnSayHello.MouseEnter
        'Change the Button text
        btnSayHello.Text = "The mouse is here!"
    End Sub
    Private Sub btnSayHello_MouseLeave(sender As Object, e As EventArgs) Handles btnSayHello.MouseLeave
        'Change the Button text
        btnSayHello.Text = "The mouse has gone!"
    End Sub

    Private Sub SubconstantsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SubconstantsToolStripMenuItem.Click
        tio3.Show()
    End Sub
    Private Sub SubenumerationsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SubenumerationsToolStripMenuItem.Click
        tio2.Show()
    End Sub

End Class