Public Class Players_edit

    Private Sub Players_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Достижения". При необходимости она может быть перемещена или удалена.
        Me.ДостиженияTableAdapter.Fill(Me.DS_hokkey.Достижения)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Статус". При необходимости она может быть перемещена или удалена.
        Me.СтатусTableAdapter.Fill(Me.DS_hokkey.Статус)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Контракт". При необходимости она может быть перемещена или удалена.
        Me.КонтрактTableAdapter.Fill(Me.DS_hokkey.Контракт)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Паспорт". При необходимости она может быть перемещена или удалена.
        Me.ПаспортTableAdapter.Fill(Me.DS_hokkey.Паспорт)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Игрок". При необходимости она может быть перемещена или удалена.
        Me.ИгрокTableAdapter.Fill(Me.DS_hokkey.Игрок)
    End Sub

    Private Sub Персонал_запросBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub УдалитьСтрокуToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УдалитьСтрокуToolStripMenuItem.Click
        If TabControl1.SelectedIndex = 0 Then
            Me.ПаспортDataGridView.Rows.Remove(ПаспортDataGridView.Rows(ПаспортDataGridView.SelectedCells(0).RowIndex))
        ElseIf TabControl1.SelectedIndex = 1 Then
            Me.КонтрактDataGridView.Rows.Remove(КонтрактDataGridView.Rows(КонтрактDataGridView.SelectedCells(0).RowIndex))
        ElseIf TabControl1.SelectedIndex = 2 Then
            Me.СтатусDataGridView.Rows.Remove(СтатусDataGridView.Rows(СтатусDataGridView.SelectedCells(0).RowIndex))
        ElseIf TabControl1.SelectedIndex = 3 Then
            Me.ДостиженияDataGridView.Rows.Remove(ДостиженияDataGridView.Rows(ДостиженияDataGridView.SelectedCells(0).RowIndex))
        Else
            Me.Игрок_запросDataGridView.Rows.Remove(Игрок_запросDataGridView.Rows(Игрок_запросDataGridView.SelectedCells(0).RowIndex))
        End If


    End Sub

    Private Sub СохранитьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СохранитьToolStripMenuItem.Click

        Me.Validate()
        Me.ИгрокBindingSource.EndEdit()
        Me.ПаспортBindingSource.EndEdit()
        Me.КонтрактDataGridView.EndEdit()
        Me.СтатусBindingSource.EndEdit()
        Me.ДостиженияDataGridView.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_hokkey)
        Me.DS_hokkey.AcceptChanges()
        GV.Close()
        GV.Show()
        GV.Hide()
    End Sub
End Class