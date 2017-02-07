Public Class Workers_edit

    Private Sub ПаспортBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ПаспортBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_hokkey)

    End Sub

    Private Sub Workers_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Персонал". При необходимости она может быть перемещена или удалена.
        Me.ПерсоналTableAdapter.Fill(Me.DS_hokkey.Персонал)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Статус". При необходимости она может быть перемещена или удалена.
        Me.СтатусTableAdapter.Fill(Me.DS_hokkey.Статус)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Трудовой_договор". При необходимости она может быть перемещена или удалена.
        Me.Трудовой_договорTableAdapter.Fill(Me.DS_hokkey.Трудовой_договор)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Паспорт". При необходимости она может быть перемещена или удалена.
        Me.ПаспортTableAdapter.Fill(Me.DS_hokkey.Паспорт)

    End Sub

    Private Sub СохранитьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СохранитьToolStripMenuItem.Click
        Me.Validate()
        Me.ПерсоналBindingSource.EndEdit()
        Me.ПаспортBindingSource.EndEdit()
        Me.СтатусBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_hokkey)
        Me.DS_hokkey.AcceptChanges()
        GV.Close()
        GV.Show()
        GV.Hide()
    End Sub

    Private Sub УдалитьСтрокуToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УдалитьСтрокуToolStripMenuItem.Click
        If TabControl1.SelectedIndex = 0 Then
            Me.ПаспортDataGridView.Rows.Remove(ПаспортDataGridView.Rows(ПаспортDataGridView.SelectedCells(0).RowIndex))
        ElseIf TabControl1.SelectedIndex = 1 Then
            Me.Трудовой_договорDataGridView.Rows.Remove(Трудовой_договорDataGridView.Rows(Трудовой_договорDataGridView.SelectedCells(0).RowIndex))
        ElseIf TabControl1.SelectedIndex = 2 Then
            Me.СтатусDataGridView.Rows.Remove(СтатусDataGridView.Rows(СтатусDataGridView.SelectedCells(0).RowIndex))
        Else
            Me.ПерсоналDataGridView.Rows.Remove(ПерсоналDataGridView.Rows(ПерсоналDataGridView.SelectedCells(0).RowIndex))
        End If
    End Sub
End Class