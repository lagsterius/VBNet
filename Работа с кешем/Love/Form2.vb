Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox(Form1.lng(Form1.lang, 4))
        Else
            IO.File.AppendAllText(Form1.path, TextBox1.Text + Form1.sep, System.Text.Encoding.Default)
            TextBox1.Text = ""
            Form1.start_split()
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Form1.start_split()
    End Sub
End Class