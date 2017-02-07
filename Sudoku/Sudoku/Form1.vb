Public Class Form1
    Dim st_font As Integer = 20
    Dim zn, otstup, x, ar(9, 9), r, ss As Integer
    Private mouseOffset As Point
    Private isMouseDown As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 8
            For j = 0 To 8
                With Me.Controls("btn_" & i + 1 & j + 1)
                    .Font = New Font(Drawing.FontFamily.GenericMonospace, st_font)
                    .Location = New Drawing.Point(12 + 66 * j, 36 + 66 * i)
                    .Size = New System.Drawing.Size(60, 60)
                End With
                If i > -1 And i < 3 Then
                    If j > -1 And j < 3 Then
                        Me.Controls("btn_" & i + 1 & j + 1).BackColor = Color.Aqua
                    ElseIf j > 2 And j < 6 Then
                        Me.Controls("btn_" & i + 1 & j + 1).BackColor = Color.LightCyan
                    Else
                        Me.Controls("btn_" & i + 1 & j + 1).BackColor = Color.Aqua
                    End If
                ElseIf i > 2 And i < 6 Then
                    If j > -1 And j < 3 Then
                        Me.Controls("btn_" & i + 1 & j + 1).BackColor = Color.LightCyan
                    ElseIf j > 2 And j < 6 Then
                        Me.Controls("btn_" & i + 1 & j + 1).BackColor = Color.Aqua
                    Else
                        Me.Controls("btn_" & i + 1 & j + 1).BackColor = Color.LightCyan
                    End If
                Else
                    If j > -1 And j < 3 Then
                        Me.Controls("btn_" & i + 1 & j + 1).BackColor = Color.Aqua
                    ElseIf j > 2 And j < 6 Then
                        Me.Controls("btn_" & i + 1 & j + 1).BackColor = Color.LightCyan
                    Else
                        Me.Controls("btn_" & i + 1 & j + 1).BackColor = Color.Aqua
                    End If
                End If
            Next
        Next

        For i = 0 To 8
            For j = 0 To 8
rernd:
                ss += 1
                If ss = 1000 Then
                    i = 0
                    j = 0
                    ss = 0
                End If
                Randomize()
                x = Int(Rnd() * 9) + 1
                ar(i, j) = x
                If j > 0 Then
                    For k = 0 To j - 1
                        If ar(i, k) = x Then GoTo rernd
                    Next
                End If
                If i > 0 Then
                    For k = 0 To i - 1
                        If ar(k, j) = x Then
                            r += 1
                            If r = 50 Then
                                i -= 1
                                r = 0
                            End If
                            GoTo rernd
                        End If
                    Next
                End If
                If i <> 0 And i <> 3 And i <> 6 Then
                    If i = 1 Or i = 2 Then
                        If j = 0 Or j = 1 Or j = 2 Then
                            For k = 0 To i
                                If k = i Then
                                    For l = 0 To j - 1
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                Else
                                    For l = 0 To 2
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                End If
                            Next
                        ElseIf j = 4 Or j = 5 Then
                            For k = 0 To i
                                If k = i Then
                                    For l = 3 To j - 1
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                Else
                                    For l = 3 To 5
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                End If
                            Next
                        ElseIf j = 7 Or j = 8 Then
                            For k = 0 To i
                                If k = i Then
                                    For l = 6 To j - 1
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                Else
                                    For l = 6 To 8
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    ElseIf i = 4 Or i = 5 Then
                        If j = 0 Or j = 1 Or j = 2 Then
                            For k = 3 To i
                                If k = i Then
                                    For l = 0 To j - 1
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                Else
                                    For l = 0 To 2
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                End If
                            Next
                        ElseIf j = 3 Or j = 4 Or j = 5 Then
                            For k = 3 To i
                                If k = i Then
                                    For l = 3 To j - 1
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                Else
                                    For l = 3 To 5
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                End If
                            Next
                        ElseIf j = 6 Or j = 7 Or j = 8 Then
                            For k = 3 To i
                                If k = i Then
                                    For l = 6 To j - 1
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                Else
                                    For l = 6 To 8
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    ElseIf i = 7 Or i = 8 Then
                        If j = 0 Or j = 1 Or j = 2 Then
                            For k = 6 To i
                                If k = i Then
                                    For l = 0 To j - 1
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                Else
                                    For l = 0 To 2
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                End If
                            Next
                        ElseIf j = 3 Or j = 4 Or j = 5 Then
                            For k = 6 To i
                                If k = i Then
                                    For l = 3 To j - 1
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                Else
                                    For l = 3 To 5
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                End If
                            Next
                        ElseIf j = 6 Or j = 7 Or j = 8 Then
                            For k = 6 To i
                                If k = i Then
                                    For l = 6 To j - 1
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                Else
                                    For l = 6 To 8
                                        If ar(k, l) = ar(i, j) Then
                                            r += 1
                                            If r = 50 Then
                                                i -= 1
                                                r = 0
                                            End If
                                            GoTo rernd
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    End If
                End If
            Next
        Next

        For i = 0 To 8
            For j = 0 To 8
                Me.Controls("btn_" & i + 1 & j + 1).Text = ar(i, j)
            Next
        Next
    End Sub

    Private Sub ОToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Maximized Then
            zn = 60
            otstup = 12
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
            zn = (Me.Height - 48) / 98 * 10
            otstup = (Me.Width - 9.8 * zn) / 2
        End If
        For i = 1 To 9
            For j = 1 To 9
                With Me.Controls("btn_" & i & j)
                    .Font = New Font(Drawing.FontFamily.GenericMonospace, Int(st_font * (zn / 60)))
                    .Location = New Drawing.Point(otstup + (1.1 * zn) * (i - 1), 36 + (1.1 * zn) * (j - 1))
                    .Size = New System.Drawing.Size(zn, zn)
                End With
            Next
        Next
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ХToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ХToolStripMenuItem.Click
        End
    End Sub

    Private Sub ЗакрытьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗакрытьToolStripMenuItem.Click
        End
    End Sub

    Private Sub ms_main_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ms_main.MouseDown
        Dim xOffset As Integer
        Dim yOffset As Integer
        If e.Button = MouseButtons.Left Then
            xOffset = -e.X
            yOffset = -e.Y
            mouseOffset = New Point(xOffset, yOffset)
            isMouseDown = True
        End If
    End Sub

    Private Sub ms_main_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ms_main.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub ms_main_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ms_main.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

End Class
