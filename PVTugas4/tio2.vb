Public Class tio2
    ''' <summary>
    ''' Count the characters in a block of text
    ''' </summary>
    ''' <param name="text">The string containing the text
    ''' to count characters in</param>
    Private Function CountCharacters(ByVal text As String) As Integer
        Return text.Length
    End Function

    '" <summary>
    '" Count the number of words in a block of text
    '" </summary>
    '" <param name="text">The string containing the text to count</param>
    '" <returns>The number of words in the string</returns>
    '" <remarks></remarks>
    Private Function CountWords(text As String) As Integer
        'Is the text empty?
        If text.Trim.Length = 0 Then Return 0
        'Split the words
        Dim strWords() As String = text.Split(" "c)
        'Return the number of words
        Return strWords.Length
    End Function
    Private Sub UpdateDisplay()
        'Do we want to count words?
        If radCountWords.Checked Then
            'Update the results with words
            lblResults.Text = CountWords(txtWords.Text) & " words"
        Else
            'Update the results with characters
            lblResults.Text = CountCharacters(txtWords.Text) & " characters"
        End If
    End Sub

    Private Sub txtWords_TextChanged(sender As Object, e As EventArgs) Handles txtWords.TextChanged
        'Count the number of characters
        Dim intChars As Integer =
        CountCharacters(txtWords.Text)
        'Display the results
        lblResults.Text = intChars & " characters"
        UpdateDisplay()
    End Sub

    Private Sub radCountWords_CheckedChanged(sender As Object, e As EventArgs) Handles radCountWords.CheckedChanged
        UpdateDisplay()
    End Sub

    Private Sub radCountChars_CheckedChanged(sender As Object, e As EventArgs) Handles radCountChars.CheckedChanged
        UpdateDisplay()
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        tio1.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        tio3.Show()
    End Sub
End Class