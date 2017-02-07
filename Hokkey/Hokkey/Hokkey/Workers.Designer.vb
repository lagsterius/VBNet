<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Workers
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
        Dim Фамилия_ИмяLabel As System.Windows.Forms.Label
        Dim Вид_статусаLabel As System.Windows.Forms.Label
        Dim Дата_рожденияLabel As System.Windows.Forms.Label
        Dim Место_рожденияLabel As System.Windows.Forms.Label
        Dim НомерLabel As System.Windows.Forms.Label
        Dim СерияLabel As System.Windows.Forms.Label
        Dim Кем_выданLabel As System.Windows.Forms.Label
        Dim Когда_выданLabel As System.Windows.Forms.Label
        Dim Дата_заключенияLabel As System.Windows.Forms.Label
        Dim Заработная_платаLabel As System.Windows.Forms.Label
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.Заработная_платаLabel1 = New System.Windows.Forms.Label()
        Me.Персонал_запросBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_hokkey = New Hokkey.DS_hokkey()
        Me.Дата_заключенияLabel1 = New System.Windows.Forms.Label()
        Me.Когда_выданLabel1 = New System.Windows.Forms.Label()
        Me.Кем_выданLabel1 = New System.Windows.Forms.Label()
        Me.СерияLabel1 = New System.Windows.Forms.Label()
        Me.НомерLabel1 = New System.Windows.Forms.Label()
        Me.Место_рожденияLabel1 = New System.Windows.Forms.Label()
        Me.Дата_рожденияLabel1 = New System.Windows.Forms.Label()
        Me.Вид_статусаLabel1 = New System.Windows.Forms.Label()
        Me.Фамилия_ИмяLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Персонал_запросTableAdapter = New Hokkey.DS_hokkeyTableAdapters.Персонал_запросTableAdapter()
        Me.TableAdapterManager = New Hokkey.DS_hokkeyTableAdapters.TableAdapterManager()
        Фамилия_ИмяLabel = New System.Windows.Forms.Label()
        Вид_статусаLabel = New System.Windows.Forms.Label()
        Дата_рожденияLabel = New System.Windows.Forms.Label()
        Место_рожденияLabel = New System.Windows.Forms.Label()
        НомерLabel = New System.Windows.Forms.Label()
        СерияLabel = New System.Windows.Forms.Label()
        Кем_выданLabel = New System.Windows.Forms.Label()
        Когда_выданLabel = New System.Windows.Forms.Label()
        Дата_заключенияLabel = New System.Windows.Forms.Label()
        Заработная_платаLabel = New System.Windows.Forms.Label()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.Персонал_запросBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Фамилия_ИмяLabel
        '
        Фамилия_ИмяLabel.AutoSize = True
        Фамилия_ИмяLabel.Location = New System.Drawing.Point(9, 5)
        Фамилия_ИмяLabel.Name = "Фамилия_ИмяLabel"
        Фамилия_ИмяLabel.Size = New System.Drawing.Size(84, 13)
        Фамилия_ИмяLabel.TabIndex = 0
        Фамилия_ИмяLabel.Text = "Фамилия Имя:"
        '
        'Вид_статусаLabel
        '
        Вид_статусаLabel.AutoSize = True
        Вид_статусаLabel.Location = New System.Drawing.Point(9, 25)
        Вид_статусаLabel.Name = "Вид_статусаLabel"
        Вид_статусаLabel.Size = New System.Drawing.Size(68, 13)
        Вид_статусаLabel.TabIndex = 2
        Вид_статусаLabel.Text = "Должность:"
        '
        'Дата_рожденияLabel
        '
        Дата_рожденияLabel.AutoSize = True
        Дата_рожденияLabel.Location = New System.Drawing.Point(9, 45)
        Дата_рожденияLabel.Name = "Дата_рожденияLabel"
        Дата_рожденияLabel.Size = New System.Drawing.Size(89, 13)
        Дата_рожденияLabel.TabIndex = 4
        Дата_рожденияLabel.Text = "Дата рождения:"
        '
        'Место_рожденияLabel
        '
        Место_рожденияLabel.AutoSize = True
        Место_рожденияLabel.Location = New System.Drawing.Point(9, 65)
        Место_рожденияLabel.Name = "Место_рожденияLabel"
        Место_рожденияLabel.Size = New System.Drawing.Size(95, 13)
        Место_рожденияLabel.TabIndex = 6
        Место_рожденияLabel.Text = "Место рождения:"
        '
        'НомерLabel
        '
        НомерLabel.AutoSize = True
        НомерLabel.Location = New System.Drawing.Point(275, 5)
        НомерLabel.Name = "НомерLabel"
        НомерLabel.Size = New System.Drawing.Size(44, 13)
        НомерLabel.TabIndex = 8
        НомерLabel.Text = "Номер:"
        '
        'СерияLabel
        '
        СерияLabel.AutoSize = True
        СерияLabel.Location = New System.Drawing.Point(275, 25)
        СерияLabel.Name = "СерияLabel"
        СерияLabel.Size = New System.Drawing.Size(41, 13)
        СерияLabel.TabIndex = 10
        СерияLabel.Text = "Серия:"
        '
        'Кем_выданLabel
        '
        Кем_выданLabel.AutoSize = True
        Кем_выданLabel.Location = New System.Drawing.Point(275, 45)
        Кем_выданLabel.Name = "Кем_выданLabel"
        Кем_выданLabel.Size = New System.Drawing.Size(66, 13)
        Кем_выданLabel.TabIndex = 12
        Кем_выданLabel.Text = "Кем выдан:"
        '
        'Когда_выданLabel
        '
        Когда_выданLabel.AutoSize = True
        Когда_выданLabel.Location = New System.Drawing.Point(275, 65)
        Когда_выданLabel.Name = "Когда_выданLabel"
        Когда_выданLabel.Size = New System.Drawing.Size(75, 13)
        Когда_выданLabel.TabIndex = 14
        Когда_выданLabel.Text = "Когда выдан:"
        '
        'Дата_заключенияLabel
        '
        Дата_заключенияLabel.AutoSize = True
        Дата_заключенияLabel.Location = New System.Drawing.Point(551, 5)
        Дата_заключенияLabel.Name = "Дата_заключенияLabel"
        Дата_заключенияLabel.Size = New System.Drawing.Size(100, 13)
        Дата_заключенияLabel.TabIndex = 16
        Дата_заключенияLabel.Text = "Дата заключения:"
        '
        'Заработная_платаLabel
        '
        Заработная_платаLabel.AutoSize = True
        Заработная_платаLabel.Location = New System.Drawing.Point(549, 25)
        Заработная_платаLabel.Name = "Заработная_платаLabel"
        Заработная_платаLabel.Size = New System.Drawing.Size(102, 13)
        Заработная_платаLabel.TabIndex = 18
        Заработная_платаLabel.Text = "Заработная плата:"
        '
        'DataRepeater1
        '
        Me.DataRepeater1.Dock = System.Windows.Forms.DockStyle.Bottom
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Заработная_платаLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Заработная_платаLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Дата_заключенияLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Дата_заключенияLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Когда_выданLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Когда_выданLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Кем_выданLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Кем_выданLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(СерияLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.СерияLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(НомерLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.НомерLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Место_рожденияLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Место_рожденияLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Дата_рожденияLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Дата_рожденияLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Вид_статусаLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Вид_статусаLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Фамилия_ИмяLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Фамилия_ИмяLabel1)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(795, 116)
        Me.DataRepeater1.Location = New System.Drawing.Point(0, 86)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(803, 486)
        Me.DataRepeater1.TabIndex = 0
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'Заработная_платаLabel1
        '
        Me.Заработная_платаLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Персонал_запросBindingSource, "Заработная плата", True))
        Me.Заработная_платаLabel1.Location = New System.Drawing.Point(657, 25)
        Me.Заработная_платаLabel1.Name = "Заработная_платаLabel1"
        Me.Заработная_платаLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Заработная_платаLabel1.TabIndex = 19
        Me.Заработная_платаLabel1.Text = "Label2"
        '
        'Персонал_запросBindingSource
        '
        Me.Персонал_запросBindingSource.DataMember = "Персонал_запрос"
        Me.Персонал_запросBindingSource.DataSource = Me.DS_hokkey
        '
        'DS_hokkey
        '
        Me.DS_hokkey.DataSetName = "DS_hokkey"
        Me.DS_hokkey.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Дата_заключенияLabel1
        '
        Me.Дата_заключенияLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Персонал_запросBindingSource, "Дата заключения", True))
        Me.Дата_заключенияLabel1.Location = New System.Drawing.Point(657, 5)
        Me.Дата_заключенияLabel1.Name = "Дата_заключенияLabel1"
        Me.Дата_заключенияLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Дата_заключенияLabel1.TabIndex = 17
        Me.Дата_заключенияLabel1.Text = "Label2"
        '
        'Когда_выданLabel1
        '
        Me.Когда_выданLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Персонал_запросBindingSource, "Когда выдан", True))
        Me.Когда_выданLabel1.Location = New System.Drawing.Point(347, 65)
        Me.Когда_выданLabel1.Name = "Когда_выданLabel1"
        Me.Когда_выданLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Когда_выданLabel1.TabIndex = 15
        Me.Когда_выданLabel1.Text = "Label2"
        '
        'Кем_выданLabel1
        '
        Me.Кем_выданLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Персонал_запросBindingSource, "Кем выдан", True))
        Me.Кем_выданLabel1.Location = New System.Drawing.Point(347, 45)
        Me.Кем_выданLabel1.Name = "Кем_выданLabel1"
        Me.Кем_выданLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Кем_выданLabel1.TabIndex = 13
        Me.Кем_выданLabel1.Text = "Label2"
        '
        'СерияLabel1
        '
        Me.СерияLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Персонал_запросBindingSource, "Серия", True))
        Me.СерияLabel1.Location = New System.Drawing.Point(347, 25)
        Me.СерияLabel1.Name = "СерияLabel1"
        Me.СерияLabel1.Size = New System.Drawing.Size(100, 23)
        Me.СерияLabel1.TabIndex = 11
        Me.СерияLabel1.Text = "Label2"
        '
        'НомерLabel1
        '
        Me.НомерLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Персонал_запросBindingSource, "Номер", True))
        Me.НомерLabel1.Location = New System.Drawing.Point(347, 5)
        Me.НомерLabel1.Name = "НомерLabel1"
        Me.НомерLabel1.Size = New System.Drawing.Size(100, 23)
        Me.НомерLabel1.TabIndex = 9
        Me.НомерLabel1.Text = "Label2"
        '
        'Место_рожденияLabel1
        '
        Me.Место_рожденияLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Персонал_запросBindingSource, "Место рождения", True))
        Me.Место_рожденияLabel1.Location = New System.Drawing.Point(110, 65)
        Me.Место_рожденияLabel1.Name = "Место_рожденияLabel1"
        Me.Место_рожденияLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Место_рожденияLabel1.TabIndex = 7
        Me.Место_рожденияLabel1.Text = "Label2"
        '
        'Дата_рожденияLabel1
        '
        Me.Дата_рожденияLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Персонал_запросBindingSource, "Дата рождения", True))
        Me.Дата_рожденияLabel1.Location = New System.Drawing.Point(110, 45)
        Me.Дата_рожденияLabel1.Name = "Дата_рожденияLabel1"
        Me.Дата_рожденияLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Дата_рожденияLabel1.TabIndex = 5
        Me.Дата_рожденияLabel1.Text = "Label2"
        '
        'Вид_статусаLabel1
        '
        Me.Вид_статусаLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Персонал_запросBindingSource, "Вид статуса", True))
        Me.Вид_статусаLabel1.Location = New System.Drawing.Point(110, 25)
        Me.Вид_статусаLabel1.Name = "Вид_статусаLabel1"
        Me.Вид_статусаLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Вид_статусаLabel1.TabIndex = 3
        Me.Вид_статусаLabel1.Text = "Label2"
        '
        'Фамилия_ИмяLabel1
        '
        Me.Фамилия_ИмяLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Персонал_запросBindingSource, "Фамилия Имя", True))
        Me.Фамилия_ИмяLabel1.Location = New System.Drawing.Point(110, 5)
        Me.Фамилия_ИмяLabel1.Name = "Фамилия_ИмяLabel1"
        Me.Фамилия_ИмяLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Фамилия_ИмяLabel1.TabIndex = 1
        Me.Фамилия_ИмяLabel1.Text = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 42)
        Me.GroupBox1.TabIndex = 36
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Поле:"
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
        Me.Button2.Location = New System.Drawing.Point(591, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Фильтровать"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(690, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Снять фильтр"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(569, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 19)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Трудовой договор"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(318, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Паспорт"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Основная информация"
        '
        'Персонал_запросTableAdapter
        '
        Me.Персонал_запросTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Hokkey.DS_hokkeyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ДостиженияTableAdapter = Nothing
        Me.TableAdapterManager.ИгрокTableAdapter = Nothing
        Me.TableAdapterManager.КонтрактTableAdapter = Nothing
        Me.TableAdapterManager.ПаспортTableAdapter = Nothing
        Me.TableAdapterManager.ПерсоналTableAdapter = Nothing
        Me.TableAdapterManager.РасписаниеTableAdapter = Nothing
        Me.TableAdapterManager.СтатусTableAdapter = Nothing
        Me.TableAdapterManager.Трудовой_договорTableAdapter = Nothing
        Me.TableAdapterManager.Уровни_доступаTableAdapter = Nothing
        '
        'Workers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(803, 572)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataRepeater1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Workers"
        Me.Text = "Сотрудники"
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.Персонал_запросBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataRepeater1 As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DS_hokkey As Hokkey.DS_hokkey
    Friend WithEvents Персонал_запросBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Персонал_запросTableAdapter As Hokkey.DS_hokkeyTableAdapters.Персонал_запросTableAdapter
    Friend WithEvents TableAdapterManager As Hokkey.DS_hokkeyTableAdapters.TableAdapterManager
    Friend WithEvents Фамилия_ИмяLabel1 As System.Windows.Forms.Label
    Friend WithEvents Заработная_платаLabel1 As System.Windows.Forms.Label
    Friend WithEvents Дата_заключенияLabel1 As System.Windows.Forms.Label
    Friend WithEvents Когда_выданLabel1 As System.Windows.Forms.Label
    Friend WithEvents Кем_выданLabel1 As System.Windows.Forms.Label
    Friend WithEvents СерияLabel1 As System.Windows.Forms.Label
    Friend WithEvents НомерLabel1 As System.Windows.Forms.Label
    Friend WithEvents Место_рожденияLabel1 As System.Windows.Forms.Label
    Friend WithEvents Дата_рожденияLabel1 As System.Windows.Forms.Label
    Friend WithEvents Вид_статусаLabel1 As System.Windows.Forms.Label
End Class
