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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.FraseTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.Close2TSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LngTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.RusTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTSMI, Me.FraseTSMI, Me.Close2TSMI, Me.MinTSMI, Me.LngTSMI})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(264, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileTSMI
        '
        Me.FileTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartTSMI, Me.StopTSMI, Me.CloseTSMI})
        Me.FileTSMI.Name = "FileTSMI"
        Me.FileTSMI.Size = New System.Drawing.Size(48, 20)
        Me.FileTSMI.Text = "Файл"
        '
        'StartTSMI
        '
        Me.StartTSMI.Name = "StartTSMI"
        Me.StartTSMI.Size = New System.Drawing.Size(152, 22)
        Me.StartTSMI.Text = "Начать"
        '
        'StopTSMI
        '
        Me.StopTSMI.Name = "StopTSMI"
        Me.StopTSMI.Size = New System.Drawing.Size(152, 22)
        Me.StopTSMI.Text = "Остановить"
        '
        'CloseTSMI
        '
        Me.CloseTSMI.Name = "CloseTSMI"
        Me.CloseTSMI.Size = New System.Drawing.Size(152, 22)
        Me.CloseTSMI.Text = "Закрыть"
        '
        'FraseTSMI
        '
        Me.FraseTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTSMI, Me.DeleteTSMI, Me.ChangeTSMI})
        Me.FraseTSMI.Name = "FraseTSMI"
        Me.FraseTSMI.Size = New System.Drawing.Size(52, 20)
        Me.FraseTSMI.Text = "Фраза"
        '
        'AddTSMI
        '
        Me.AddTSMI.Name = "AddTSMI"
        Me.AddTSMI.Size = New System.Drawing.Size(152, 22)
        Me.AddTSMI.Text = "Добавить"
        '
        'DeleteTSMI
        '
        Me.DeleteTSMI.Name = "DeleteTSMI"
        Me.DeleteTSMI.Size = New System.Drawing.Size(152, 22)
        Me.DeleteTSMI.Text = "Удалить"
        '
        'ChangeTSMI
        '
        Me.ChangeTSMI.Name = "ChangeTSMI"
        Me.ChangeTSMI.Size = New System.Drawing.Size(152, 22)
        Me.ChangeTSMI.Text = "Изменить"
        '
        'Close2TSMI
        '
        Me.Close2TSMI.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Close2TSMI.Name = "Close2TSMI"
        Me.Close2TSMI.Size = New System.Drawing.Size(26, 20)
        Me.Close2TSMI.Text = "X"
        '
        'MinTSMI
        '
        Me.MinTSMI.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.MinTSMI.Name = "MinTSMI"
        Me.MinTSMI.Size = New System.Drawing.Size(24, 20)
        Me.MinTSMI.Text = "-"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackgroundImage = CType(resources.GetObject("StatusStrip1.BackgroundImage"), System.Drawing.Image)
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 73)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(264, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'LngTSMI
        '
        Me.LngTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RusTSMI, Me.EnTSMI})
        Me.LngTSMI.Name = "LngTSMI"
        Me.LngTSMI.Size = New System.Drawing.Size(46, 20)
        Me.LngTSMI.Text = "Язык"
        '
        'RusTSMI
        '
        Me.RusTSMI.Name = "RusTSMI"
        Me.RusTSMI.Size = New System.Drawing.Size(152, 22)
        Me.RusTSMI.Text = "Русский"
        '
        'EnTSMI
        '
        Me.EnTSMI.Name = "EnTSMI"
        Me.EnTSMI.Size = New System.Drawing.Size(152, 22)
        Me.EnTSMI.Text = "English"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(264, 95)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JustText"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FraseTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Close2TSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LngTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RusTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnTSMI As System.Windows.Forms.ToolStripMenuItem

End Class
