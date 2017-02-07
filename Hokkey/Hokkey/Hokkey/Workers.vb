﻿Public Class Workers

    Private Sub Workers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Персонал_запрос". При необходимости она может быть перемещена или удалена.
        Me.Персонал_запросTableAdapter.Fill(Me.DS_hokkey.Персонал_запрос)
        For i = 0 To GV.Персонал_запросDataGridView.ColumnCount - 1
            ComboBox1.Items.Add(GV.Персонал_запросDataGridView.Columns(i).HeaderText)
        Next
        ComboBox1.Items.RemoveAt(0)
        ComboBox1.Items.RemoveAt(1)
        ComboBox1.Items.RemoveAt(1)
        ComboBox1.Items.RemoveAt(8)
        ComboBox1.Items.RemoveAt(8)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Персонал_запросBindingSource.Filter = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Персонал_запросBindingSource.Filter = "[" & ComboBox1.SelectedItem & "] = '" & ComboBox2.SelectedItem & "'"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        Dim k As Integer
        Dim cmb2(), temp As String
        ReDim cmb2(GV.Персонал_запросDataGridView.Rows.Count)
        For i = 0 To GV.Персонал_запросDataGridView.Columns.Count - 1
            If ComboBox1.SelectedItem = GV.Персонал_запросDataGridView.Columns(i).HeaderText Then
                k = i
            End If
        Next
        For i = 0 To GV.Персонал_запросDataGridView.Rows.Count - 2
            cmb2(i) = GV.Персонал_запросDataGridView.Rows(i).Cells(k).Value
        Next

        For i = 0 To GV.Персонал_запросDataGridView.Rows.Count - 3
            For j = i + 1 To GV.Персонал_запросDataGridView.Rows.Count - 2
                If cmb2(i) = cmb2(j) Then
                    cmb2(j) = ""
                End If
            Next
        Next

        For i = 0 To GV.Персонал_запросDataGridView.Rows.Count - 3
            For j = i + 1 To GV.Персонал_запросDataGridView.Rows.Count - 2
                If cmb2(i) > cmb2(j) Then
                    temp = cmb2(i)
                    cmb2(i) = cmb2(j)
                    cmb2(j) = temp
                End If
            Next
        Next
        For i = 0 To GV.Персонал_запросDataGridView.Rows.Count - 2
            If cmb2(i) <> "" Then
                ComboBox2.Items.Add(cmb2(i))
            End If
        Next
    End Sub
End Class