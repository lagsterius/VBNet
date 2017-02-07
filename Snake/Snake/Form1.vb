Public Class Form1
    Public path As String = "img\"
    Public head_img, end_img, telo(18) As String
    Public score, cur_len, sch As Integer 'Очки, и текущая длина змеи
    Public s(20) As PictureBox 'Все части змеи, начиная с головы
    Public ud, lr, rernd As Boolean 'Куда можно походить следующим шагом и будет ли проведена перевыборка будующего положения змеи
    Public loc_table(1, 20), eda_point As Point 'История ходов и смещений змеи, положение еды

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ptb_eda.Image = Image.FromFile(path + "eda.png")
        ptb_sh.Image = Image.FromFile(path + "start.png")
        Me.BackgroundImage = Image.FromFile(path + "bg.png")
        s = {ptb_sh, ptb_s1, ptb_s2, ptb_s3, ptb_s4, ptb_s5, ptb_s6, ptb_s7, ptb_s8, ptb_s9, ptb_s10, ptb_s11, ptb_s12, ptb_s13, ptb_s14, ptb_s15, ptb_s16, ptb_s17, ptb_s18, ptb_s19, ptb_s20}
        For i = 1 To 20
            s(i).BackColor = Color.Transparent
        Next
        loc_table(0, 0) = s(0).Location
        cur_len = 1
        Do
            Randomize()
            eda_point.X = Int(12 * Rnd()) * 25
            Randomize()
            eda_point.Y = Int(12 * Rnd()) * 25
        Loop While eda_point = ptb_sh.Location
        ptb_eda.Location = eda_point
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Asc("s") Or e.KeyCode = Keys.Down Or e.KeyCode = Asc("S") Or e.KeyCode = Asc("ы") Or e.KeyCode = Asc("Ы") Then
            key_press(ud, New Point(0, 1), "6")
        ElseIf e.KeyCode = Asc("a") Or e.KeyCode = Keys.Left Or e.KeyCode = Asc("A") Or e.KeyCode = Asc("ф") Or e.KeyCode = Asc("Ф") Then
            key_press(lr, New Point(-1, 0), "8")
        ElseIf e.KeyCode = Asc("w") Or e.KeyCode = Keys.Up Or e.KeyCode = Asc("W") Or e.KeyCode = Asc("ц") Or e.KeyCode = Asc("Ц") Then
            key_press(ud, New Point(0, -1), "7")
        ElseIf e.KeyCode = Asc("d") Or e.KeyCode = Keys.Right Or e.KeyCode = Asc("D") Or e.KeyCode = Asc("в") Or e.KeyCode = Asc("В") Then
            key_press(lr, New Point(1, 0), "5")
        End If
    End Sub

    Private Sub tmr_main_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_main.Tick
        ptb_sh.Left += loc_table(1, 0).X * 25
        ptb_sh.Top += loc_table(1, 0).Y * 25
        For i = 1 To cur_len
            s(i).Left += loc_table(1, i - 1).X * 25
            s(i).Top += loc_table(1, i - 1).Y * 25
        Next
        If cur_len = 1 Then
            s(0).Image = Image.FromFile(path + head_img + "-2.png")
        Else
            s(0).Image = Image.FromFile(path + head_img + ".png")
        End If

        For i = cur_len To 1 Step -1
            loc_table(0, i) = loc_table(0, i - 1)
            loc_table(1, i) = loc_table(1, i - 1)
        Next
        loc_table(0, 0) = ptb_sh.Location
        If cur_len > 2 Then
            s(cur_len - 1).Image = Image.FromFile(path + "telo.png")
            'If loc_table(0, 2).X = loc_table(0, 0).X Then
            '    telo(0) = "14"
            'ElseIf loc_table(0, 2).Y = loc_table(0, 0).Y Then
            '    telo(0) = "13"
            'ElseIf (loc_table(0, 2).X - loc_table(0, 0).X = -25 And loc_table(0, 2).Y - loc_table(0, 0).Y = 25 And loc_table(0, 2).Y = loc_table(0, 1).Y) Or (loc_table(0, 2).X - loc_table(0, 0).X = 25 And loc_table(0, 2).Y - loc_table(0, 0).Y = -25 And loc_table(0, 2).X = loc_table(0, 1).X) Then
            '    telo(0) = "1"
            'ElseIf (loc_table(0, 2).X - loc_table(0, 0).X = 25 And loc_table(0, 2).Y - loc_table(0, 0).Y = 25 And loc_table(0, 2).Y = loc_table(0, 1).Y) Or (loc_table(0, 2).X - loc_table(0, 0).X = -25 And loc_table(0, 2).Y - loc_table(0, 0).Y = -25 And loc_table(0, 2).X = loc_table(0, 1).X) Then
            '    telo(0) = "2"
            'ElseIf (loc_table(0, 2).X - loc_table(0, 0).X = -25 And loc_table(0, 2).Y - loc_table(0, 0).Y = 25 And loc_table(0, 2).X = loc_table(0, 1).X) Or (loc_table(0, 2).X - loc_table(0, 0).X = 25 And loc_table(0, 2).Y - loc_table(0, 0).Y = -25 And loc_table(0, 2).Y = loc_table(0, 1).Y) Then
            '    telo(0) = "4"
            'ElseIf (loc_table(0, 2).X - loc_table(0, 0).X = 25 And loc_table(0, 2).Y - loc_table(0, 0).Y = 25 And loc_table(0, 2).X = loc_table(0, 1).X) Or (loc_table(0, 2).X - loc_table(0, 0).X = -25 And loc_table(0, 2).Y - loc_table(0, 0).Y = -25 And loc_table(0, 2).Y = loc_table(0, 1).Y) Then
            '    telo(0) = "3"
            'End If
            's(1).Image = Image.FromFile(path + telo(0) + ".png")
            'For i = cur_len - 2 To 1
            '    telo(i) = telo(i - 1)
            '    s(cur_len - 1).Image = Image.FromFile(path + telo(i) + ".png")
            'Next
        End If
            If loc_table(1, cur_len - 1).X = 1 Then
                s(cur_len).Image = Drawing.Image.FromFile(path + "9.png")
            ElseIf loc_table(1, cur_len - 1).X = -1 Then
                s(cur_len).Image = Drawing.Image.FromFile(path + "10.png")
            ElseIf loc_table(1, cur_len - 1).Y = 1 Then
                s(cur_len).Image = Drawing.Image.FromFile(path + "11.png")
            Else
                s(cur_len).Image = Drawing.Image.FromFile(path + "12.png")
            End If

            For i = 1 To cur_len
                If s(i).Location = ptb_sh.Location Then lose()
            Next
            If ptb_sh.Top < 0 Or ptb_sh.Left < 0 Or ptb_sh.Left > 300 Or ptb_sh.Top > 300 Then lose()
            If ptb_eda.Location = ptb_sh.Location Then
                score += 1
                score_tssi.Text = "Очки: " + Str(score)
                If cur_len < 20 Then
                    cur_len += 1
                    s(cur_len).Visible = True
                    s(cur_len).Location = loc_table(0, cur_len - 1)
                End If
                eda_pos()
            End If

            If loc_table(1, 0).X = 1 Or loc_table(1, 0).X = -1 Then
                lr = True
                ud = False
            Else
                lr = False
                ud = True
            End If
    End Sub

    Private Sub tmr_ff_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_ff.Tick
        Me.Focus()
    End Sub

    Private Sub eda_pos()
        Do
            sch = 0
            Randomize()
            eda_point.X = Int(12 * Rnd()) * 25
            Randomize()
            eda_point.Y = Int(12 * Rnd()) * 25
            For i = 0 To cur_len - 1
                If s(i).Location = eda_point Then
                    rernd = True
                Else
                    sch += 1
                End If
            Next
        Loop While rernd = True And sch <> cur_len
        ptb_eda.Location = eda_point
        rernd = False
    End Sub

    Private Sub lose()
        tmr_ff.Enabled = False
        tmr_main.Enabled = False
        score = 0
        score_tssi.Text = "Проигрыш"
        MsgBox("Вы проиграли")
    End Sub

    Private Sub key_press(ByVal bl As Boolean, ByVal loc As Drawing.Point, ByVal hi As String)
        If bl = False Then
            If tmr_main.Enabled = False Then tmr_main.Enabled = True
            loc_table(1, 0) = loc
            head_img = hi
        End If
    End Sub
End Class


'If cur_len > 2 Then
'For i = 0 To cur_len - 1
'    If loc_table(1, i + 2) = loc_table(1, i) And loc_table(1, i + 2).X = 0 Then
'        telo_img(i) = "13"
'    ElseIf loc_table(1, i + 2) = loc_table(1, i) And loc_table(1, i + 2).Y = 0 Then
'        telo_img(i) = "14"
'    ElseIf (loc_table(1, i + 2) = New Drawing.Point(0, 1) And loc_table(1, i) = New Drawing.Point(1, 0)) Or (loc_table(1, i + 2) = New Drawing.Point(-1, 0) And loc_table(1, i) = New Drawing.Point(0, -1)) Then
'        telo_img(i) = "3"
'    ElseIf (loc_table(1, i + 2) = New Drawing.Point(0, 1) And loc_table(1, i) = New Drawing.Point(-1, 0)) Or (loc_table(1, i + 2) = New Drawing.Point(1, 0) And loc_table(1, i) = New Drawing.Point(0, -1)) Then
'        telo_img(i) = "4"
'    ElseIf (loc_table(1, i + 2) = New Drawing.Point(0, -1) And loc_table(1, i) = New Drawing.Point(1, 0)) Or (loc_table(1, i + 2) = New Drawing.Point(-1, 0) And loc_table(1, i) = New Drawing.Point(0, 1)) Then
'        telo_img(i) = "1"
'    ElseIf (loc_table(1, i + 2) = New Drawing.Point(0, -1) And loc_table(1, i) = New Drawing.Point(-1, 0)) Or (loc_table(1, i + 2) = New Drawing.Point(1, 0) And loc_table(1, i) = New Drawing.Point(0, 1)) Then
'        telo_img(i) = "2"
'    End If
'Next
'    For i = 0 To cur_len - 2
'        s(i + 1).Image = Drawing.Image.FromFile(path + telo_img(i) + ".png")
'    Next
'End If