Public Class Login
    Dim s As Integer = 0
    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        ok_click()
    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GV.Show()
        txt_login.Focus()
    End Sub

    Private Sub Login_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        GV.Show()
        GV.Hide()
        txt_login.Focus()
    End Sub

    Private Sub txt_login_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_login.KeyUp
        If e.KeyCode = Keys.Enter Then
            txt_pass.Focus()
            txt_pass.SelectAll()
        End If
    End Sub

    Private Sub txt_pass_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pass.KeyUp
        If e.KeyCode = Keys.Enter Then
            ok_click()
        ElseIf e.KeyCode = Keys.Tab Then
            txt_pass.Focus()
            txt_pass.SelectAll()
        End If
    End Sub

    Public Sub ok_click()
        s = 0
        If txt_login.Text = "" Or txt_pass.Text = "" Then
            MsgBox("Незаполнены обязательные поля")
            txt_login.Focus()
        Else
            If txt_login.Text = "antoniO" And txt_pass.Text = "antoniO" Then
                Main.Text = "Здравствуйте, Мастер"
                Main.Show()
                Main.tsi_games.Visible = True
                Main.tsi_personal.Visible = True
                Main.tsi_players.Visible = True
                Main.АдминистрированиеToolStripMenuItem.Visible = True
                s = 0
                Main.Panel1.Visible = False
                Main.Panel2.Visible = False
                Me.Hide()
            Else
                For i = 0 To GV.Игрок_запросDataGridView.Rows.Count - 1
                    If (txt_login.Text = GV.Игрок_запросDataGridView.Rows(i).Cells(1).Value And txt_pass.Text = GV.Игрок_запросDataGridView.Rows(i).Cells(16).Value) Then
                        success_login(i, 0)
                        Return
                    Else
                        s += 1
                    End If
                Next
                For i = 0 To GV.Персонал_запросDataGridView.Rows.Count - 1
                    If (txt_login.Text = GV.Персонал_запросDataGridView.Rows(i).Cells(1).Value And txt_pass.Text = GV.Персонал_запросDataGridView.Rows(i).Cells(12).Value) Then
                        success_login(i, 1)
                        Return
                    Else
                        s += 1
                    End If
                Next
                If s = GV.Игрок_запросDataGridView.Rows.Count + GV.Персонал_запросDataGridView.Rows.Count Then
                    MsgBox("Wrong name or (and) Password")
                    txt_login.Focus()
                End If
            End If
        End If
    End Sub

    Public Sub success_login(ByVal s As Integer, ByVal k As Integer)
        If k = 0 Then
            Main.Panel1.Visible = True
            Main.Panel2.Visible = False
            Main.Text = "Здравствуйте, " & GV.Игрок_запросDataGridView.Rows(s).Cells(1).Value
            If GV.Игрок_запросDataGridView.Rows(s).Cells(15).Value = 0 Then
                lb0()
            ElseIf GV.Игрок_запросDataGridView.Rows(s).Cells(15).Value = 1 Then
                lb1()
            ElseIf GV.Игрок_запросDataGridView.Rows(s).Cells(15).Value = 2 Then
                lb2()
            ElseIf GV.Игрок_запросDataGridView.Rows(s).Cells(15).Value = 3 Then
                lb3()
            End If
        Else
            Main.Panel1.Visible = False
            Main.Panel2.Visible = True
            Main.Text = "Здравствуйте, " & GV.Персонал_запросDataGridView.Rows(s).Cells(1).Value
            If GV.Персонал_запросDataGridView.Rows(s).Cells(11).Value = 0 Then
                lb0()
            ElseIf GV.Персонал_запросDataGridView.Rows(s).Cells(11).Value = 1 Then
                lb1()
            ElseIf GV.Персонал_запросDataGridView.Rows(s).Cells(11).Value = 2 Then
                lb2()
            ElseIf GV.Персонал_запросDataGridView.Rows(s).Cells(11).Value = 3 Then
                lb3()
            End If
        End If
        Main.Show()
        Me.Hide()
    End Sub

    Public Sub lb0()
        Main.tsi_games.Visible = False
        Main.tsi_personal.Visible = False
        Main.tsi_players.Visible = False
        Main.АдминистрированиеToolStripMenuItem.Visible = False
    End Sub

    Public Sub lb1()
        Main.tsi_games.Visible = True
        Main.tsi_personal.Visible = False
        Main.tsi_players.Visible = True
        Main.АдминистрированиеToolStripMenuItem.Visible = False
    End Sub

    Public Sub lb2()
        Main.tsi_games.Visible = False
        Main.tsi_personal.Visible = True
        Main.tsi_players.Visible = False
        Main.АдминистрированиеToolStripMenuItem.Visible = False
    End Sub

    Public Sub lb3()
        Main.tsi_games.Visible = True
        Main.tsi_personal.Visible = True
        Main.tsi_players.Visible = True
        Main.АдминистрированиеToolStripMenuItem.Visible = False
    End Sub

End Class
