Public Class Form3
    Public sl As Integer
    Public newtext As String
    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Form1.start_split()
        For i = 0 To Form1.y.Length - 2
            ComboBox1.Items.Add(Form1.y(i))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text <> "" Then
            newtext = ""
            ComboBox1.Items.Remove(ComboBox1.SelectedItem)
            ComboBox1.Text = ""
            For i = 0 To ComboBox1.Items.Count - 1
                newtext += ComboBox1.Items(i) + Form1.sep
            Next
            IO.File.Delete(Form1.path)
            IO.File.AppendAllText("..\temp.txt", newtext, System.Text.Encoding.Default)
            IO.File.Copy("..\temp.txt", Form1.path)
            IO.File.Delete("..\temp.txt")
        End If
    End Sub
End Class