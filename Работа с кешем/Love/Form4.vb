Public Class Form4
    Public shag, start As Integer
    Public ssize As System.Drawing.Size
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

    Private Sub Form4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        shag = 20
        start = 12
        ssize = New System.Drawing.Size(355, 20)
        Form1.start_split()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox1.Location = New System.Drawing.Point(start, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = ssize
        Me.Controls.Add(Me.TextBox1)
    End Sub
End Class