Public Class frm_main
    Public W, S, Pw, P As Double
    Private Sub ЗагрузитьДанныеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗагрузитьДанныеToolStripMenuItem.Click
        W = 0.4
        S = 180
        Pw = 75
        P = 25
        lbl_w.Text = W
        lbl_s.Text = S
        lbl_pw.Text = Pw
        lbl_p.Text = P
        ОпределитьФибрилляциюToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ОпределитьФибрилляциюToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ОпределитьФибрилляциюToolStripMenuItem.Click
Str1:
        If W <= 0.35 Then
            NSHRS()
        Else
            If W <= 0.45 And W > 0.35 Then
                If S >= 800 Or Pw > 110 Then
                    NSHRS()
                Else
                    If P < 25 And Pw > 75 And S >= 800 Then
                        NSHRS()
                    Else
                        SHRS()
                    End If
                End If
            Else
                If W > 0.45 Then
                    If Pw < 75 Or S < 200 Then
                        SHRS()
                    Else
                        If P < 25 And Pw > 75 And S >= 800 Then
                            NSHRS()
                        Else
                            SHRS()
                        End If
                    End If
                Else
                    GoTo str1
                End If
            End If
        End If
    End Sub

    Sub SHRS()
        MsgBox("SHRS")
    End Sub

    Sub NSHRS()
        MsgBox("NSHRS")
    End Sub
End Class
