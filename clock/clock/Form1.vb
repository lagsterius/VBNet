Public Class Form1
    Public k(10, 13), chet As Boolean
    Public p(13, 4) As PictureBox
    Public z(4), rrr(3), HH, MM, SS, OS As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        k = {{1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1}, {0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1}, {1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1}, {1, 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1}, {1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 1}, {1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1}, {1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1}}
        p = {{p_001, p_011, p_021, p_101, p_121, p_201, p_211, p_221, p_301, p_321, p_401, p_411, p_421}, {p_002, p_012, p_022, p_102, p_122, p_202, p_212, p_222, p_302, p_322, p_402, p_412, p_422}, {p_003, p_013, p_023, p_103, p_123, p_203, p_213, p_223, p_303, p_323, p_403, p_413, p_423}, {p_004, p_014, p_024, p_104, p_124, p_204, p_214, p_224, p_304, p_324, p_404, p_414, p_424}}
        For i = 0 To 2
            Randomize()
            rrr(i) = Int(Rnd() * 235) + 20
        Next
        For i = 0 To 3
            For j = 0 To 12
                If Not (j = 6) Then
                    p(i, j).Visible = True
                    p(i, j).BackColor = Color.FromArgb(rrr(0), rrr(1), rrr(2))
                End If
            Next
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i = 0 To 2
            Randomize()
            rrr(i) = Int(Rnd() * 235) + 20
        Next



        SS += 1

        If SS = 60 Then
            SS = 0
            MM += 1
            If MM = 60 Then
                MM = 0
                HH += 1
                If HH = 24 Then HH = 0
            End If
        End If

        If HH < 10 Then
            z(0) = 0
        Else : z(0) = Math.Floor(HH / 10)
        End If
        z(1) = HH Mod 10
        If MM < 10 Then
            z(2) = 0
        Else : z(2) = Math.Floor(MM / 10)
        End If
        z(3) = MM Mod 10



        For i = 0 To 3
            For j = 0 To 12
                If k(z(i), j) = True Then
                    p(i, j).Visible = True
                    p(i, j).BackColor = Color.FromArgb(rrr(0), rrr(1), rrr(2))
                Else : p(i, j).Visible = False
                End If
            Next
        Next
        p_t1.Visible = Not (p_t1.Visible)
        p_t2.Visible = Not (p_t2.Visible)
        p_t1.BackColor = Color.FromArgb(rrr(0), rrr(1), rrr(2))
        p_t2.BackColor = Color.FromArgb(rrr(0), rrr(1), rrr(2))
    End Sub

    Private Sub btn_zzz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_zzz.Click
        Timer1.Enabled = Not (Timer1.Enabled)
        Timer2.Enabled = Not (Timer2.Enabled)
        SS = 0
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        For i = 0 To 12
            If chet = 0 Then
                p(OS, i).Visible = 0
            Else : p(OS, i).Visible = k(z(OS), i)
            End If
        Next
        chet = Not (chet)
        p_t1.Visible = Not (p_t1.Visible)
        p_t2.Visible = Not (p_t2.Visible)
    End Sub

    Private Sub btn_prev_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prev.Click
        pn(False)
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        pn(True)
    End Sub

    Private Sub pn(ByVal x As Boolean)
        If Timer2.Enabled = True Then
            For j = 0 To 12
                If k(z(OS), j) = True Then
                    p(OS, j).Visible = True
                    p(OS, j).BackColor = Color.FromArgb(rrr(0), rrr(1), rrr(2))
                Else : p(OS, j).Visible = False
                End If
            Next
            If x = True Then
                OS = (OS + 1) Mod 4
            Else
                If OS = 0 Then
                    OS = 3
                Else : OS -= 1
                End If
            End If
        End If
    End Sub

    Private Sub btn_plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plus.Click
        If Timer2.Enabled = True Then
            Select Case (OS)
                Case 0 : HH = (HH + 10) Mod 30
                Case 1
                    If HH > 19 Then
                        If HH Mod 10 = 3 Then
                            HH -= 3
                        Else : HH = (HH + 1)
                        End If
                    Else
                        If HH Mod 10 = 9 Then
                            HH -= 9
                        Else : HH = (HH + 1)
                        End If
                    End If
                Case 2 : MM = (MM + 10) Mod 60
                Case 3
                    If MM Mod 10 = 9 Then
                        MM -= 9
                    Else : MM = (MM + 1)
                    End If
            End Select
            pm()
        End If
    End Sub

    Private Sub btn_minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_minus.Click
        If Timer2.Enabled = True Then
            Select Case (OS)
                Case 0
                    If HH < 10 Then
                        HH = 20 + HH Mod 10
                    Else : HH -= 10
                    End If
                Case 1
                    If HH > 19 Then
                        If HH Mod 10 = 0 Then
                            HH += 3
                        Else
                            HH = (HH - 1)
                        End If
                    Else
                        If HH Mod 10 = 0 Then
                            HH += 9
                        Else
                            HH = (HH - 1)
                        End If
                    End If
                Case 2
                    If MM < 10 Then
                        MM = 50 + MM Mod 10
                    Else : MM -= 10
                    End If
                Case 3
                    If MM Mod 10 = 0 Then
                        MM += 9
                    Else : MM = (MM - 1)
                    End If
            End Select
            pm()
        End If
    End Sub

    Private Sub pm()
        If HH < 10 Then
            z(0) = 0
        Else : z(0) = Math.Floor(HH / 10)
        End If
        z(1) = HH Mod 10
        If MM < 10 Then
            z(2) = 0
        Else : z(2) = Math.Floor(MM / 10)
        End If
        z(3) = MM Mod 10
        For i = 0 To 12
            If k(z(OS), i) = True Then
                p(OS, i).Visible = True
                p(OS, i).BackColor = Color.FromArgb(rrr(0), rrr(1), rrr(2))
            Else : p(OS, i).Visible = False
            End If
        Next
    End Sub
End Class
