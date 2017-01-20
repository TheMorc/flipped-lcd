Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text = TextBox1.Text
        text.Remove(0, TextBox1.Text.Count - 1)
        MsgBox(text)
        MsgBox(TextBox1.Text.Count - 1)
    End Sub
End Class
