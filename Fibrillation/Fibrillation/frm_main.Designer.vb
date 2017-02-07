<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗагрузитьДанныеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОпределитьФибрилляциюToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыйтиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_w1 = New System.Windows.Forms.Label()
        Me.lbl_w = New System.Windows.Forms.Label()
        Me.lbl_s = New System.Windows.Forms.Label()
        Me.lbl_s1 = New System.Windows.Forms.Label()
        Me.lbl_pw = New System.Windows.Forms.Label()
        Me.lbl_pw1 = New System.Windows.Forms.Label()
        Me.lbl_p = New System.Windows.Forms.Label()
        Me.lbl_p1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(487, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗагрузитьДанныеToolStripMenuItem, Me.ОпределитьФибрилляциюToolStripMenuItem, Me.ВыйтиToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'ЗагрузитьДанныеToolStripMenuItem
        '
        Me.ЗагрузитьДанныеToolStripMenuItem.Name = "ЗагрузитьДанныеToolStripMenuItem"
        Me.ЗагрузитьДанныеToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ЗагрузитьДанныеToolStripMenuItem.Text = "Загрузить данные"
        '
        'ОпределитьФибрилляциюToolStripMenuItem
        '
        Me.ОпределитьФибрилляциюToolStripMenuItem.Enabled = False
        Me.ОпределитьФибрилляциюToolStripMenuItem.Name = "ОпределитьФибрилляциюToolStripMenuItem"
        Me.ОпределитьФибрилляциюToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ОпределитьФибрилляциюToolStripMenuItem.Text = "Определить фибрилляцию"
        '
        'ВыйтиToolStripMenuItem
        '
        Me.ВыйтиToolStripMenuItem.Name = "ВыйтиToolStripMenuItem"
        Me.ВыйтиToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ВыйтиToolStripMenuItem.Text = "Выйти"
        '
        'lbl_w1
        '
        Me.lbl_w1.AutoSize = True
        Me.lbl_w1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_w1.Location = New System.Drawing.Point(12, 45)
        Me.lbl_w1.Name = "lbl_w1"
        Me.lbl_w1.Size = New System.Drawing.Size(334, 32)
        Me.lbl_w1.TabIndex = 1
        Me.lbl_w1.Text = "Относительная частота попадания сигнала" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "вне информативного интервала:"
        '
        'lbl_w
        '
        Me.lbl_w.AutoSize = True
        Me.lbl_w.Location = New System.Drawing.Point(270, 64)
        Me.lbl_w.Name = "lbl_w"
        Me.lbl_w.Size = New System.Drawing.Size(76, 13)
        Me.lbl_w.TabIndex = 2
        Me.lbl_w.Text = "не загружена"
        '
        'lbl_s
        '
        Me.lbl_s.AutoSize = True
        Me.lbl_s.Location = New System.Drawing.Point(257, 124)
        Me.lbl_s.Name = "lbl_s"
        Me.lbl_s.Size = New System.Drawing.Size(70, 13)
        Me.lbl_s.TabIndex = 4
        Me.lbl_s.Text = "не загружен"
        '
        'lbl_s1
        '
        Me.lbl_s1.AutoSize = True
        Me.lbl_s1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_s1.Location = New System.Drawing.Point(12, 105)
        Me.lbl_s1.Name = "lbl_s1"
        Me.lbl_s1.Size = New System.Drawing.Size(268, 32)
        Me.lbl_s1.TabIndex = 3
        Me.lbl_s1.Text = "Критический параметр для метода" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "вычитания составного сингала:"
        '
        'lbl_pw
        '
        Me.lbl_pw.AutoSize = True
        Me.lbl_pw.Location = New System.Drawing.Point(406, 184)
        Me.lbl_pw.Name = "lbl_pw"
        Me.lbl_pw.Size = New System.Drawing.Size(70, 13)
        Me.lbl_pw.TabIndex = 6
        Me.lbl_pw.Text = "не загружен"
        '
        'lbl_pw1
        '
        Me.lbl_pw1.AutoSize = True
        Me.lbl_pw1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_pw1.Location = New System.Drawing.Point(12, 165)
        Me.lbl_pw1.Name = "lbl_pw1"
        Me.lbl_pw1.Size = New System.Drawing.Size(388, 32)
        Me.lbl_pw1.TabIndex = 5
        Me.lbl_pw1.Text = "Критический параметр для метода отношения" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "мощностей фильтрованного и исходного с" & _
            "игналов:"
        '
        'lbl_p
        '
        Me.lbl_p.AutoSize = True
        Me.lbl_p.Location = New System.Drawing.Point(289, 244)
        Me.lbl_p.Name = "lbl_p"
        Me.lbl_p.Size = New System.Drawing.Size(70, 13)
        Me.lbl_p.TabIndex = 8
        Me.lbl_p.Text = "не загружен"
        '
        'lbl_p1
        '
        Me.lbl_p1.AutoSize = True
        Me.lbl_p1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_p1.Location = New System.Drawing.Point(12, 225)
        Me.lbl_p1.Name = "lbl_p1"
        Me.lbl_p1.Size = New System.Drawing.Size(306, 32)
        Me.lbl_p1.TabIndex = 7
        Me.lbl_p1.Text = "Среднеарифметическое значение семи" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "последних определенных R-зубцов:"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 274)
        Me.Controls.Add(Me.lbl_p)
        Me.Controls.Add(Me.lbl_p1)
        Me.Controls.Add(Me.lbl_pw)
        Me.Controls.Add(Me.lbl_pw1)
        Me.Controls.Add(Me.lbl_s)
        Me.Controls.Add(Me.lbl_s1)
        Me.Controls.Add(Me.lbl_w)
        Me.Controls.Add(Me.lbl_w1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_main"
        Me.Text = "Определение фибрилляции"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗагрузитьДанныеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВыйтиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_w1 As System.Windows.Forms.Label
    Friend WithEvents lbl_w As System.Windows.Forms.Label
    Friend WithEvents lbl_s As System.Windows.Forms.Label
    Friend WithEvents lbl_s1 As System.Windows.Forms.Label
    Friend WithEvents ОпределитьФибрилляциюToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_pw As System.Windows.Forms.Label
    Friend WithEvents lbl_pw1 As System.Windows.Forms.Label
    Friend WithEvents lbl_p As System.Windows.Forms.Label
    Friend WithEvents lbl_p1 As System.Windows.Forms.Label

End Class
