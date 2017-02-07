<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Games
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
        Dim ЗабитоLabel As System.Windows.Forms.Label
        Dim ПропущеноLabel As System.Windows.Forms.Label
        Dim Первый_игрокLabel As System.Windows.Forms.Label
        Dim Второй_игрокLabel As System.Windows.Forms.Label
        Dim Третий_игрокLabel As System.Windows.Forms.Label
        Dim Четвертый_игрокLabel As System.Windows.Forms.Label
        Dim Пятый_игрокLabel As System.Windows.Forms.Label
        Dim ВратарьLabel As System.Windows.Forms.Label
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.ВратарьLabel1 = New System.Windows.Forms.Label()
        Me.РасписаниеBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_hokkey = New Hokkey.DS_hokkey()
        Me.Пятый_игрокLabel1 = New System.Windows.Forms.Label()
        Me.Четвертый_игрокLabel1 = New System.Windows.Forms.Label()
        Me.Третий_игрокLabel1 = New System.Windows.Forms.Label()
        Me.Второй_игрокLabel1 = New System.Windows.Forms.Label()
        Me.Первый_игрокLabel1 = New System.Windows.Forms.Label()
        Me.ПропущеноLabel1 = New System.Windows.Forms.Label()
        Me.ЗабитоLabel1 = New System.Windows.Forms.Label()
        Me.Дата_проведениеLabel1 = New System.Windows.Forms.Label()
        Me.СоперникLabel1 = New System.Windows.Forms.Label()
        Me.РасписаниеTableAdapter = New Hokkey.DS_hokkeyTableAdapters.РасписаниеTableAdapter()
        Me.TableAdapterManager = New Hokkey.DS_hokkeyTableAdapters.TableAdapterManager()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        ЗабитоLabel = New System.Windows.Forms.Label()
        ПропущеноLabel = New System.Windows.Forms.Label()
        Первый_игрокLabel = New System.Windows.Forms.Label()
        Второй_игрокLabel = New System.Windows.Forms.Label()
        Третий_игрокLabel = New System.Windows.Forms.Label()
        Четвертый_игрокLabel = New System.Windows.Forms.Label()
        Пятый_игрокLabel = New System.Windows.Forms.Label()
        ВратарьLabel = New System.Windows.Forms.Label()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.РасписаниеBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ЗабитоLabel
        '
        ЗабитоLabel.AutoSize = True
        ЗабитоLabel.Location = New System.Drawing.Point(227, 5)
        ЗабитоLabel.Name = "ЗабитоLabel"
        ЗабитоLabel.Size = New System.Drawing.Size(46, 13)
        ЗабитоLabel.TabIndex = 4
        ЗабитоLabel.Text = "Забито:"
        '
        'ПропущеноLabel
        '
        ПропущеноLabel.AutoSize = True
        ПропущеноLabel.Location = New System.Drawing.Point(227, 28)
        ПропущеноLabel.Name = "ПропущеноLabel"
        ПропущеноLabel.Size = New System.Drawing.Size(68, 13)
        ПропущеноLabel.TabIndex = 5
        ПропущеноLabel.Text = "Пропущено:"
        '
        'Первый_игрокLabel
        '
        Первый_игрокLabel.AutoSize = True
        Первый_игрокLabel.Location = New System.Drawing.Point(371, 5)
        Первый_игрокLabel.Name = "Первый_игрокLabel"
        Первый_игрокLabel.Size = New System.Drawing.Size(82, 13)
        Первый_игрокLabel.TabIndex = 6
        Первый_игрокLabel.Text = "Первый игрок:"
        '
        'Второй_игрокLabel
        '
        Второй_игрокLabel.AutoSize = True
        Второй_игрокLabel.Location = New System.Drawing.Point(371, 28)
        Второй_игрокLabel.Name = "Второй_игрокLabel"
        Второй_игрокLabel.Size = New System.Drawing.Size(78, 13)
        Второй_игрокLabel.TabIndex = 8
        Второй_игрокLabel.Text = "Второй игрок:"
        '
        'Третий_игрокLabel
        '
        Третий_игрокLabel.AutoSize = True
        Третий_игрокLabel.Location = New System.Drawing.Point(371, 51)
        Третий_игрокLabel.Name = "Третий_игрокLabel"
        Третий_игрокLabel.Size = New System.Drawing.Size(78, 13)
        Третий_игрокLabel.TabIndex = 10
        Третий_игрокLabel.Text = "Третий игрок:"
        '
        'Четвертый_игрокLabel
        '
        Четвертый_игрокLabel.AutoSize = True
        Четвертый_игрокLabel.Location = New System.Drawing.Point(589, 5)
        Четвертый_игрокLabel.Name = "Четвертый_игрокLabel"
        Четвертый_игрокLabel.Size = New System.Drawing.Size(98, 13)
        Четвертый_игрокLabel.TabIndex = 12
        Четвертый_игрокLabel.Text = "Четвертый игрок:"
        '
        'Пятый_игрокLabel
        '
        Пятый_игрокLabel.AutoSize = True
        Пятый_игрокLabel.Location = New System.Drawing.Point(589, 28)
        Пятый_игрокLabel.Name = "Пятый_игрокLabel"
        Пятый_игрокLabel.Size = New System.Drawing.Size(75, 13)
        Пятый_игрокLabel.TabIndex = 14
        Пятый_игрокLabel.Text = "Пятый игрок:"
        '
        'ВратарьLabel
        '
        ВратарьLabel.AutoSize = True
        ВратарьLabel.Location = New System.Drawing.Point(589, 51)
        ВратарьLabel.Name = "ВратарьLabel"
        ВратарьLabel.Size = New System.Drawing.Size(52, 13)
        ВратарьLabel.TabIndex = 16
        ВратарьLabel.Text = "Вратарь:"
        '
        'DataRepeater1
        '
        Me.DataRepeater1.Dock = System.Windows.Forms.DockStyle.Bottom
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(ВратарьLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.ВратарьLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Пятый_игрокLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Пятый_игрокLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Четвертый_игрокLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Четвертый_игрокLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Третий_игрокLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Третий_игрокLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Второй_игрокLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Второй_игрокLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Первый_игрокLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Первый_игрокLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(ПропущеноLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.ПропущеноLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(ЗабитоLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.ЗабитоLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Дата_проведениеLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.СоперникLabel1)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(851, 144)
        Me.DataRepeater1.Location = New System.Drawing.Point(0, 78)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(859, 407)
        Me.DataRepeater1.TabIndex = 0
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'ВратарьLabel1
        '
        Me.ВратарьLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Вратарь", True))
        Me.ВратарьLabel1.Location = New System.Drawing.Point(693, 51)
        Me.ВратарьLabel1.Name = "ВратарьLabel1"
        Me.ВратарьLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ВратарьLabel1.TabIndex = 17
        Me.ВратарьLabel1.Text = "Label1"
        '
        'РасписаниеBindingSource
        '
        Me.РасписаниеBindingSource.DataMember = "Расписание"
        Me.РасписаниеBindingSource.DataSource = Me.DS_hokkey
        '
        'DS_hokkey
        '
        Me.DS_hokkey.DataSetName = "DS_hokkey"
        Me.DS_hokkey.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Пятый_игрокLabel1
        '
        Me.Пятый_игрокLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Пятый игрок", True))
        Me.Пятый_игрокLabel1.Location = New System.Drawing.Point(693, 28)
        Me.Пятый_игрокLabel1.Name = "Пятый_игрокLabel1"
        Me.Пятый_игрокLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Пятый_игрокLabel1.TabIndex = 15
        Me.Пятый_игрокLabel1.Text = "Label1"
        '
        'Четвертый_игрокLabel1
        '
        Me.Четвертый_игрокLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Четвертый игрок", True))
        Me.Четвертый_игрокLabel1.Location = New System.Drawing.Point(693, 5)
        Me.Четвертый_игрокLabel1.Name = "Четвертый_игрокLabel1"
        Me.Четвертый_игрокLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Четвертый_игрокLabel1.TabIndex = 13
        Me.Четвертый_игрокLabel1.Text = "Label1"
        '
        'Третий_игрокLabel1
        '
        Me.Третий_игрокLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Третий игрок", True))
        Me.Третий_игрокLabel1.Location = New System.Drawing.Point(459, 51)
        Me.Третий_игрокLabel1.Name = "Третий_игрокLabel1"
        Me.Третий_игрокLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Третий_игрокLabel1.TabIndex = 11
        Me.Третий_игрокLabel1.Text = "Label1"
        '
        'Второй_игрокLabel1
        '
        Me.Второй_игрокLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Второй игрок", True))
        Me.Второй_игрокLabel1.Location = New System.Drawing.Point(459, 28)
        Me.Второй_игрокLabel1.Name = "Второй_игрокLabel1"
        Me.Второй_игрокLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Второй_игрокLabel1.TabIndex = 9
        Me.Второй_игрокLabel1.Text = "Label1"
        '
        'Первый_игрокLabel1
        '
        Me.Первый_игрокLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Первый игрок", True))
        Me.Первый_игрокLabel1.Location = New System.Drawing.Point(459, 5)
        Me.Первый_игрокLabel1.Name = "Первый_игрокLabel1"
        Me.Первый_игрокLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Первый_игрокLabel1.TabIndex = 7
        Me.Первый_игрокLabel1.Text = "Label1"
        '
        'ПропущеноLabel1
        '
        Me.ПропущеноLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Пропущено", True))
        Me.ПропущеноLabel1.Location = New System.Drawing.Point(301, 28)
        Me.ПропущеноLabel1.Name = "ПропущеноLabel1"
        Me.ПропущеноLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ПропущеноLabel1.TabIndex = 6
        Me.ПропущеноLabel1.Text = "Label1"
        '
        'ЗабитоLabel1
        '
        Me.ЗабитоLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Забито", True))
        Me.ЗабитоLabel1.Location = New System.Drawing.Point(301, 5)
        Me.ЗабитоLabel1.Name = "ЗабитоLabel1"
        Me.ЗабитоLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ЗабитоLabel1.TabIndex = 5
        Me.ЗабитоLabel1.Text = "Label1"
        '
        'Дата_проведениеLabel1
        '
        Me.Дата_проведениеLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Дата проведение", True))
        Me.Дата_проведениеLabel1.Location = New System.Drawing.Point(121, 5)
        Me.Дата_проведениеLabel1.Name = "Дата_проведениеLabel1"
        Me.Дата_проведениеLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Дата_проведениеLabel1.TabIndex = 3
        Me.Дата_проведениеLabel1.Text = "Label1"
        '
        'СоперникLabel1
        '
        Me.СоперникLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Соперник", True))
        Me.СоперникLabel1.Location = New System.Drawing.Point(15, 5)
        Me.СоперникLabel1.Name = "СоперникLabel1"
        Me.СоперникLabel1.Size = New System.Drawing.Size(100, 23)
        Me.СоперникLabel1.TabIndex = 1
        Me.СоперникLabel1.Text = "Label1"
        '
        'РасписаниеTableAdapter
        '
        Me.РасписаниеTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Hokkey.DS_hokkeyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ДостиженияTableAdapter = Nothing
        Me.TableAdapterManager.ИгрокTableAdapter = Nothing
        Me.TableAdapterManager.КонтрактTableAdapter = Nothing
        Me.TableAdapterManager.ПаспортTableAdapter = Nothing
        Me.TableAdapterManager.ПерсоналTableAdapter = Nothing
        Me.TableAdapterManager.РасписаниеTableAdapter = Me.РасписаниеTableAdapter
        Me.TableAdapterManager.СтатусTableAdapter = Nothing
        Me.TableAdapterManager.Трудовой_договорTableAdapter = Nothing
        Me.TableAdapterManager.Уровни_доступаTableAdapter = Nothing
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 19)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Соперник"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Дата"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Результаты"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(540, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Состав"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 42)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Фильтрация"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(346, 13)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Значение:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Поле:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(115, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(633, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Фильтровать"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(736, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Снять фильтр"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Games
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(859, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataRepeater1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Games"
        Me.Text = "Игры"
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.РасписаниеBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataRepeater1 As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents DS_hokkey As Hokkey.DS_hokkey
    Friend WithEvents РасписаниеBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РасписаниеTableAdapter As Hokkey.DS_hokkeyTableAdapters.РасписаниеTableAdapter
    Friend WithEvents TableAdapterManager As Hokkey.DS_hokkeyTableAdapters.TableAdapterManager
    Friend WithEvents СоперникLabel1 As System.Windows.Forms.Label
    Friend WithEvents ВратарьLabel1 As System.Windows.Forms.Label
    Friend WithEvents Пятый_игрокLabel1 As System.Windows.Forms.Label
    Friend WithEvents Четвертый_игрокLabel1 As System.Windows.Forms.Label
    Friend WithEvents Третий_игрокLabel1 As System.Windows.Forms.Label
    Friend WithEvents Второй_игрокLabel1 As System.Windows.Forms.Label
    Friend WithEvents Первый_игрокLabel1 As System.Windows.Forms.Label
    Friend WithEvents ПропущеноLabel1 As System.Windows.Forms.Label
    Friend WithEvents ЗабитоLabel1 As System.Windows.Forms.Label
    Friend WithEvents Дата_проведениеLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
