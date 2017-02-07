Public Class Form1
    Friend WithEvents btn1 As New Button
    Public Frases, Settings, y(100), y2(100), txt, sep, path, path2 As String
    Public l1 As Boolean
    Public lang As Integer
    Public lng(2, 50) As String
    'Form
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lng = {
            {"Программа приостановлена", "Начать", "Остановить", "Текущая фраза: ", "Введите строку для добавления", "Файл", "Закрыть", "Фраза", "Добавить", "Удалить", "Изменить", "Язык", "Очистить", "ОК", "Добавить фразу", "Удалить фразу"},
            {"Program is stopped", "Start", "Stop", "Current frase: ", "Enter string to addition", "File", "Close", "Frase", "Add", "Delete", "Change", "Language", "Clear", "OK", "Add frase", "Delete frase"}
        }
        path = "..\Msg.txt"
        path2 = "..\Params.txt"
        sep = "|"
        l1 = False
        ToolStripStatusLabel1.Text = lng(lang, 0)
        Frases = IO.File.ReadAllText(path, System.Text.Encoding.Default)
        'Settings = IO.File.ReadAllText(path2, System.Text.Encoding.Default)
        y = Split(Frases, sep)
        y2 = Split(Settings, sep)
        'lang = y2(0)
        btn1 = New System.Windows.Forms.Button
        btn1.Name = "btn1"
        btn1.Text = lng(lang, 1)
        btn1.Size = New System.Drawing.Size(120, 30)
        btn1.Location = New System.Drawing.Point(12, 32)
        btn1.Left = Int((Me.Width - btn1.Width) / 2)
        Me.Controls.Add(Me.btn1)
    End Sub
    '


    'Buttons
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If l1 = False Then
            Timer1.Enabled = True
            start_split()
            btn1.Text = lng(lang, 2)
        Else
            btn1.Text = lng(lang, 1)
            Timer1.Enabled = False
            ToolStripStatusLabel1.Text = lng(lang, 0)
        End If
        l1 = Not (l1)
    End Sub
    '

    'Menu
    Private Sub StartTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartTSMI.Click
        Timer1.Enabled = True
        btn1.Text = lng(lang, 2)
        start_split()
    End Sub

    Private Sub StopTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopTSMI.Click
        Timer1.Enabled = False
        btn1.Text = lng(lang, 1)
        Timer1.Enabled = False
        ToolStripStatusLabel1.Text = lng(lang, 0)
    End Sub

    Private Sub CloseTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTSMI.Click
        End
    End Sub

    Private Sub AddTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTSMI.Click
        Timer1.Enabled = False
        Form2.Show()
    End Sub

    Private Sub DeleteTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteTSMI.Click
        Timer1.Enabled = False
        ToolStripStatusLabel1.Text = lng(lang, 0)
        btn1.Text = lng(lang, 1)
        Form3.Show()
    End Sub

    Private Sub ChangeTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeTSMI.Click
        Form4.Show()
    End Sub
    '


    'Timers
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Clipboard.Clear()
        txt = y(irnd(0, y.Length - 1))
        Clipboard.SetText(txt)
        ToolStripStatusLabel1.Text = lng(lang, 3) + txt
    End Sub
    '


    'Functions
    Public Sub start_split()
        Frases = IO.File.ReadAllText(path, System.Text.Encoding.Default)
        y = Split(Frases, sep)
        For i = 0 To y.Length - 1
            y(i) = Mid(y(i), 1, y(i).Length)
        Next
    End Sub

    Public Function irnd(ByVal x1, ByVal x2) As Integer
        Dim rev As Integer
        Randomize()
        rev = Int((x2 - x1) * Rnd()) + x1
        Return rev
    End Function
    '

    Private Sub Close2TSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close2TSMI.Click
        End
    End Sub

    Private Sub MinTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinTSMI.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub RusTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RusTSMI.Click
        langset(0)
    End Sub

    Private Sub EnTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnTSMI.Click
        langset(1)
    End Sub

    Private Sub langset(ByVal l As Integer)
        IO.File.Delete(path2)
        IO.File.AppendAllText("..\temp2.txt", +Str(l) + "|", System.Text.Encoding.Default)
        IO.File.Copy("..\temp2.txt", path2)
        IO.File.Delete("..\temp2.txt")
        Settings = IO.File.ReadAllText(path2, System.Text.Encoding.Default)
        y2 = Split(Settings, sep)
        FileTSMI.Text = lng(l, 5)
        StartTSMI.Text = lng(l, 1)
        StopTSMI.Text = lng(l, 2)
        CloseTSMI.Text = lng(l, 2)
    End Sub
End Class
