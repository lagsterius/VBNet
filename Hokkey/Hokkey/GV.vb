﻿Public Class GV

    Private Sub GV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Расписание". При необходимости она может быть перемещена или удалена.
        Me.РасписаниеTableAdapter.Fill(Me.DS_hokkey.Расписание)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Персонал_запрос". При необходимости она может быть перемещена или удалена.
        Me.Персонал_запросTableAdapter.Fill(Me.DS_hokkey.Персонал_запрос)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DS_hokkey.Игрок_запрос". При необходимости она может быть перемещена или удалена.
        Me.Игрок_запросTableAdapter.Fill(Me.DS_hokkey.Игрок_запрос)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "HokkeyDataSet.Расписание". При необходимости она может быть перемещена или удалена.
        Me.РасписаниеTableAdapter.Fill(Me.DS_hokkey.Расписание)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "HokkeyDataSet.Персонал_запрос". При необходимости она может быть перемещена или удалена.
        Me.Персонал_запросTableAdapter.Fill(Me.DS_hokkey.Персонал_запрос)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "HokkeyDataSet.Игрок_запрос". При необходимости она может быть перемещена или удалена.
        Me.Игрок_запросTableAdapter.Fill(Me.DS_hokkey.Игрок_запрос)

    End Sub
End Class