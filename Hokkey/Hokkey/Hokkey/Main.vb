Public Class Main
    Dim fil
    Private Sub ВыйтиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВыйтиToolStripMenuItem.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub ЗакрытьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗакрытьToolStripMenuItem.Click
        End
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Персонал_запрос". При необходимости она может быть перемещена или удалена.
        Me.Персонал_запросTableAdapter.Fill(Me.DS_hokkey.Персонал_запрос)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Игрок_запрос". При необходимости она может быть перемещена или удалена.
        Me.Игрок_запросTableAdapter.Fill(Me.DS_hokkey.Игрок_запрос)
        fil = "[Фамилия Имя] = '" & Microsoft.VisualBasic.Right(Me.Text, Me.Text.Length - 14) & "'"
        Игрок_запросBindingSource.Filter = fil
        Персонал_запросBindingSource.Filter = fil
    End Sub

    Private Sub ОбзорТаблицToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОбзорТаблицToolStripMenuItem.Click
        GV.Show()
    End Sub

    Private Sub ОбзорToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОбзорToolStripMenuItem.Click
        Players.Show()
    End Sub

    Private Sub ОбзорToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОбзорToolStripMenuItem1.Click
        Workers.Show()
    End Sub

    Private Sub ОбзорToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОбзорToolStripMenuItem2.Click
        Games.Show()
    End Sub

    Private Sub УдалитьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УдалитьToolStripMenuItem.Click
        Players_edit.Show()
    End Sub

    Private Sub УдалитьToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УдалитьToolStripMenuItem1.Click
        Workers_edit.Show()
    End Sub

    Private Sub РезервноеКопированиеБазыДанныхToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РезервноеКопированиеБазыДанныхToolStripMenuItem.Click
        Dim otchet As String
        otchet = "hello"
        Dim sfd_new As New SaveFileDialog
        sfd_new.Filter = "Word 97 Files (*.doc)|*.doc|Word 2007-2010 Files (*.docx)|*.docx"
        sfd_new.FileName = "Информация о себе"
        'If sfd_new.ShowDialog = DialogResult.OK Then
        '    IO.File.WriteAllText(sfd_new.FileName, otchet, System.Text.Encoding.Default)
        'End If


        'sfd_new.Filter = "База данных Microsoft Access(*.accdb)|*.accdb"
        'sfd_new.FileName = "Hokkey"
        'If sfd_new.ShowDialog = DialogResult.OK Then
        '    IO.File.Copy(Microsoft.VisualBasic.Left(IO.Path.GetFullPath(Application.ExecutablePath), IO.Path.GetFullPath(Application.ExecutablePath) - 10) & "hokkey-2.accdb", sfd_new.FileName)
        'End If
    End Sub
End Class