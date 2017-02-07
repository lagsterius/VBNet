<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.tmr_main = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_ff = New System.Windows.Forms.Timer(Me.components)
        Me.ptb_sh = New System.Windows.Forms.PictureBox()
        Me.ptb_eda = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.score_tssi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ptb_s1 = New System.Windows.Forms.PictureBox()
        Me.ptb_s2 = New System.Windows.Forms.PictureBox()
        Me.ptb_s3 = New System.Windows.Forms.PictureBox()
        Me.ptb_s4 = New System.Windows.Forms.PictureBox()
        Me.ptb_s5 = New System.Windows.Forms.PictureBox()
        Me.ptb_s6 = New System.Windows.Forms.PictureBox()
        Me.ptb_s20 = New System.Windows.Forms.PictureBox()
        Me.ptb_s16 = New System.Windows.Forms.PictureBox()
        Me.ptb_s15 = New System.Windows.Forms.PictureBox()
        Me.ptb_s14 = New System.Windows.Forms.PictureBox()
        Me.ptb_s13 = New System.Windows.Forms.PictureBox()
        Me.ptb_s12 = New System.Windows.Forms.PictureBox()
        Me.ptb_s11 = New System.Windows.Forms.PictureBox()
        Me.ptb_s10 = New System.Windows.Forms.PictureBox()
        Me.ptb_s9 = New System.Windows.Forms.PictureBox()
        Me.ptb_s8 = New System.Windows.Forms.PictureBox()
        Me.ptb_s7 = New System.Windows.Forms.PictureBox()
        Me.ptb_s19 = New System.Windows.Forms.PictureBox()
        Me.ptb_s18 = New System.Windows.Forms.PictureBox()
        Me.ptb_s17 = New System.Windows.Forms.PictureBox()
        CType(Me.ptb_sh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_eda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ptb_s1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_s17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmr_main
        '
        Me.tmr_main.Interval = 500
        '
        'tmr_ff
        '
        Me.tmr_ff.Enabled = True
        '
        'ptb_sh
        '
        Me.ptb_sh.BackColor = System.Drawing.Color.Transparent
        Me.ptb_sh.Location = New System.Drawing.Point(150, 150)
        Me.ptb_sh.Name = "ptb_sh"
        Me.ptb_sh.Size = New System.Drawing.Size(25, 25)
        Me.ptb_sh.TabIndex = 0
        Me.ptb_sh.TabStop = False
        '
        'ptb_eda
        '
        Me.ptb_eda.BackColor = System.Drawing.Color.Transparent
        Me.ptb_eda.Location = New System.Drawing.Point(0, 0)
        Me.ptb_eda.Name = "ptb_eda"
        Me.ptb_eda.Size = New System.Drawing.Size(25, 25)
        Me.ptb_eda.TabIndex = 1
        Me.ptb_eda.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.score_tssi})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 325)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(325, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.Stretch = False
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "Очки: 0"
        '
        'score_tssi
        '
        Me.score_tssi.Name = "score_tssi"
        Me.score_tssi.Size = New System.Drawing.Size(48, 17)
        Me.score_tssi.Text = "Очки: 0"
        '
        'ptb_s1
        '
        Me.ptb_s1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s1.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s1.Name = "ptb_s1"
        Me.ptb_s1.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s1.TabIndex = 3
        Me.ptb_s1.TabStop = False
        Me.ptb_s1.Visible = False
        '
        'ptb_s2
        '
        Me.ptb_s2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s2.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s2.Name = "ptb_s2"
        Me.ptb_s2.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s2.TabIndex = 4
        Me.ptb_s2.TabStop = False
        Me.ptb_s2.Visible = False
        '
        'ptb_s3
        '
        Me.ptb_s3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s3.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s3.Name = "ptb_s3"
        Me.ptb_s3.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s3.TabIndex = 5
        Me.ptb_s3.TabStop = False
        Me.ptb_s3.Visible = False
        '
        'ptb_s4
        '
        Me.ptb_s4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s4.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s4.Name = "ptb_s4"
        Me.ptb_s4.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s4.TabIndex = 6
        Me.ptb_s4.TabStop = False
        Me.ptb_s4.Visible = False
        '
        'ptb_s5
        '
        Me.ptb_s5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s5.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s5.Name = "ptb_s5"
        Me.ptb_s5.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s5.TabIndex = 7
        Me.ptb_s5.TabStop = False
        Me.ptb_s5.Visible = False
        '
        'ptb_s6
        '
        Me.ptb_s6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s6.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s6.Name = "ptb_s6"
        Me.ptb_s6.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s6.TabIndex = 8
        Me.ptb_s6.TabStop = False
        Me.ptb_s6.Visible = False
        '
        'ptb_s20
        '
        Me.ptb_s20.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s20.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s20.Name = "ptb_s20"
        Me.ptb_s20.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s20.TabIndex = 9
        Me.ptb_s20.TabStop = False
        Me.ptb_s20.Visible = False
        '
        'ptb_s16
        '
        Me.ptb_s16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s16.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s16.Name = "ptb_s16"
        Me.ptb_s16.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s16.TabIndex = 10
        Me.ptb_s16.TabStop = False
        Me.ptb_s16.Visible = False
        '
        'ptb_s15
        '
        Me.ptb_s15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s15.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s15.Name = "ptb_s15"
        Me.ptb_s15.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s15.TabIndex = 11
        Me.ptb_s15.TabStop = False
        Me.ptb_s15.Visible = False
        '
        'ptb_s14
        '
        Me.ptb_s14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s14.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s14.Name = "ptb_s14"
        Me.ptb_s14.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s14.TabIndex = 12
        Me.ptb_s14.TabStop = False
        Me.ptb_s14.Visible = False
        '
        'ptb_s13
        '
        Me.ptb_s13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s13.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s13.Name = "ptb_s13"
        Me.ptb_s13.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s13.TabIndex = 13
        Me.ptb_s13.TabStop = False
        Me.ptb_s13.Visible = False
        '
        'ptb_s12
        '
        Me.ptb_s12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s12.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s12.Name = "ptb_s12"
        Me.ptb_s12.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s12.TabIndex = 14
        Me.ptb_s12.TabStop = False
        Me.ptb_s12.Visible = False
        '
        'ptb_s11
        '
        Me.ptb_s11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s11.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s11.Name = "ptb_s11"
        Me.ptb_s11.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s11.TabIndex = 15
        Me.ptb_s11.TabStop = False
        Me.ptb_s11.Visible = False
        '
        'ptb_s10
        '
        Me.ptb_s10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s10.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s10.Name = "ptb_s10"
        Me.ptb_s10.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s10.TabIndex = 16
        Me.ptb_s10.TabStop = False
        Me.ptb_s10.Visible = False
        '
        'ptb_s9
        '
        Me.ptb_s9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s9.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s9.Name = "ptb_s9"
        Me.ptb_s9.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s9.TabIndex = 17
        Me.ptb_s9.TabStop = False
        Me.ptb_s9.Visible = False
        '
        'ptb_s8
        '
        Me.ptb_s8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s8.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s8.Name = "ptb_s8"
        Me.ptb_s8.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s8.TabIndex = 18
        Me.ptb_s8.TabStop = False
        Me.ptb_s8.Visible = False
        '
        'ptb_s7
        '
        Me.ptb_s7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s7.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s7.Name = "ptb_s7"
        Me.ptb_s7.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s7.TabIndex = 19
        Me.ptb_s7.TabStop = False
        Me.ptb_s7.Visible = False
        '
        'ptb_s19
        '
        Me.ptb_s19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s19.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s19.Name = "ptb_s19"
        Me.ptb_s19.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s19.TabIndex = 20
        Me.ptb_s19.TabStop = False
        Me.ptb_s19.Visible = False
        '
        'ptb_s18
        '
        Me.ptb_s18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s18.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s18.Name = "ptb_s18"
        Me.ptb_s18.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s18.TabIndex = 21
        Me.ptb_s18.TabStop = False
        Me.ptb_s18.Visible = False
        '
        'ptb_s17
        '
        Me.ptb_s17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ptb_s17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ptb_s17.Location = New System.Drawing.Point(300, 0)
        Me.ptb_s17.Name = "ptb_s17"
        Me.ptb_s17.Size = New System.Drawing.Size(25, 25)
        Me.ptb_s17.TabIndex = 22
        Me.ptb_s17.TabStop = False
        Me.ptb_s17.Visible = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(325, 347)
        Me.Controls.Add(Me.ptb_sh)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ptb_s17)
        Me.Controls.Add(Me.ptb_s18)
        Me.Controls.Add(Me.ptb_s19)
        Me.Controls.Add(Me.ptb_s7)
        Me.Controls.Add(Me.ptb_s8)
        Me.Controls.Add(Me.ptb_s9)
        Me.Controls.Add(Me.ptb_s10)
        Me.Controls.Add(Me.ptb_s11)
        Me.Controls.Add(Me.ptb_s12)
        Me.Controls.Add(Me.ptb_s13)
        Me.Controls.Add(Me.ptb_s14)
        Me.Controls.Add(Me.ptb_s15)
        Me.Controls.Add(Me.ptb_s16)
        Me.Controls.Add(Me.ptb_s20)
        Me.Controls.Add(Me.ptb_s6)
        Me.Controls.Add(Me.ptb_s5)
        Me.Controls.Add(Me.ptb_s4)
        Me.Controls.Add(Me.ptb_s3)
        Me.Controls.Add(Me.ptb_s2)
        Me.Controls.Add(Me.ptb_s1)
        Me.Controls.Add(Me.ptb_eda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Змейка"
        CType(Me.ptb_sh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_eda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ptb_s1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_s17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmr_main As System.Windows.Forms.Timer
    Friend WithEvents tmr_ff As System.Windows.Forms.Timer
    Friend WithEvents ptb_sh As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_eda As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents score_tssi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ptb_s1 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s2 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s3 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s4 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s5 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s6 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s20 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s16 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s15 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s14 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s13 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s12 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s11 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s10 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s9 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s8 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s7 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s19 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s18 As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_s17 As System.Windows.Forms.PictureBox

End Class
