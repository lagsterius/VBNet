Public Class Games_edit

    Private Sub РасписаниеBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.РасписаниеBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_hokkey)

    End Sub

    Private Sub Games_edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Расписание". При необходимости она может быть перемещена или удалена.
        Me.РасписаниеTableAdapter.Fill(Me.DS_hokkey.Расписание)

    End Sub

    Private Sub УдалитьСтрокуToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles УдалитьСтрокуToolStripMenuItem.Click
        Me.РасписаниеDataGridView.Rows.Remove(РасписаниеDataGridView.Rows(РасписаниеDataGridView.SelectedCells(0).RowIndex))
    End Sub

    Private Sub СохранитьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СохранитьToolStripMenuItem.Click
        Me.Validate()
        Me.РасписаниеBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_hokkey)
        Me.DS_hokkey.AcceptChanges()
        GV.Close()
        GV.Show()
        GV.Hide()
    End Sub
End Class