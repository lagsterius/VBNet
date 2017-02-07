Public Class Games

    Private Sub РасписаниеBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.РасписаниеBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_hokkey)

    End Sub

    Private Sub Games_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Расписание". При необходимости она может быть перемещена или удалена.
        Me.РасписаниеTableAdapter.Fill(Me.DS_hokkey.Расписание)
        For i = 0 To GV.РасписаниеDataGridView.ColumnCount - 1
            ComboBox1.Items.Add(GV.РасписаниеDataGridView.Columns(i).HeaderText)
        Next
        ComboBox1.Items.RemoveAt(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        РасписаниеBindingSource.Filter = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        РасписаниеBindingSource.Filter = "[" & ComboBox1.SelectedItem & "] = '" & ComboBox2.SelectedItem & "'"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        Dim k As Integer
        Dim cmb2(), temp As String
        ReDim cmb2(GV.РасписаниеDataGridView.Rows.Count)
        For i = 0 To GV.РасписаниеDataGridView.Columns.Count - 1
            If ComboBox1.SelectedItem = GV.РасписаниеDataGridView.Columns(i).HeaderText Then
                k = i
            End If
        Next
        For i = 0 To GV.РасписаниеDataGridView.Rows.Count - 2
            cmb2(i) = GV.РасписаниеDataGridView.Rows(i).Cells(k).Value
        Next

        For i = 0 To GV.РасписаниеDataGridView.Rows.Count - 3
            For j = i + 1 To GV.РасписаниеDataGridView.Rows.Count - 2
                If cmb2(i) = cmb2(j) Then
                    cmb2(j) = ""
                End If
            Next
        Next

        For i = 0 To GV.РасписаниеDataGridView.Rows.Count - 3
            For j = i + 1 To GV.РасписаниеDataGridView.Rows.Count - 2
                If cmb2(i) > cmb2(j) Then
                    temp = cmb2(i)
                    cmb2(i) = cmb2(j)
                    cmb2(j) = temp
                End If
            Next
        Next
        For i = 0 To GV.РасписаниеDataGridView.Rows.Count - 2
            If cmb2(i) <> "" Then
                ComboBox2.Items.Add(cmb2(i))
            End If
        Next
    End Sub
End Class