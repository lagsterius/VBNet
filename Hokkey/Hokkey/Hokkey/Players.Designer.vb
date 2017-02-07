<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Players
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
        Dim АмплуаLabel As System.Windows.Forms.Label
        Dim ГражданствоLabel As System.Windows.Forms.Label
        Dim ВесLabel As System.Windows.Forms.Label
        Dim РостLabel As System.Windows.Forms.Label
        Dim Дата_рожденияLabel As System.Windows.Forms.Label
        Dim Место_рожденияLabel As System.Windows.Forms.Label
        Dim НомерLabel As System.Windows.Forms.Label
        Dim СерияLabel As System.Windows.Forms.Label
        Dim Кем_выданLabel As System.Windows.Forms.Label
        Dim Когда_выданLabel As System.Windows.Forms.Label
        Dim Дата_заключенияLabel As System.Windows.Forms.Label
        Dim СрокLabel As System.Windows.Forms.Label
        Dim Заработная_платаLabel As System.Windows.Forms.Label
        Dim МатчиLabel As System.Windows.Forms.Label
        Dim ГолыLabel As System.Windows.Forms.Label
        Dim КубкиLabel As System.Windows.Forms.Label
        Me.DataRepeater1 = New Microsoft.VisualBasic.PowerPacks.DataRepeater()
        Me.DS_hokkey = New Hokkey.DS_hokkey()
        Me.Игрок_запросBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Игрок_запросTableAdapter = New Hokkey.DS_hokkeyTableAdapters.Игрок_запросTableAdapter()
        Me.TableAdapterManager = New Hokkey.DS_hokkeyTableAdapters.TableAdapterManager()
        Me.Фамилия_ИмяLabel1 = New System.Windows.Forms.Label()
        Me.АмплуаLabel1 = New System.Windows.Forms.Label()
        Me.ГражданствоLabel1 = New System.Windows.Forms.Label()
        Me.ВесLabel1 = New System.Windows.Forms.Label()
        Me.РостLabel1 = New System.Windows.Forms.Label()
        Me.Дата_рожденияLabel1 = New System.Windows.Forms.Label()
        Me.Место_рожденияLabel1 = New System.Windows.Forms.Label()
        Me.НомерLabel1 = New System.Windows.Forms.Label()
        Me.СерияLabel1 = New System.Windows.Forms.Label()
        Me.Кем_выданLabel1 = New System.Windows.Forms.Label()
        Me.Когда_выданLabel1 = New System.Windows.Forms.Label()
        Me.Дата_заключенияLabel1 = New System.Windows.Forms.Label()
        Me.СрокLabel1 = New System.Windows.Forms.Label()
        Me.Заработная_платаLabel1 = New System.Windows.Forms.Label()
        Me.МатчиLabel1 = New System.Windows.Forms.Label()
        Me.ГолыLabel1 = New System.Windows.Forms.Label()
        Me.КубкиLabel1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Фамилия_ИмяLabel = New System.Windows.Forms.Label()
        АмплуаLabel = New System.Windows.Forms.Label()
        ГражданствоLabel = New System.Windows.Forms.Label()
        ВесLabel = New System.Windows.Forms.Label()
        РостLabel = New System.Windows.Forms.Label()
        Дата_рожденияLabel = New System.Windows.Forms.Label()
        Место_рожденияLabel = New System.Windows.Forms.Label()
        НомерLabel = New System.Windows.Forms.Label()
        СерияLabel = New System.Windows.Forms.Label()
        Кем_выданLabel = New System.Windows.Forms.Label()
        Когда_выданLabel = New System.Windows.Forms.Label()
        Дата_заключенияLabel = New System.Windows.Forms.Label()
        СрокLabel = New System.Windows.Forms.Label()
        Заработная_платаLabel = New System.Windows.Forms.Label()
        МатчиLabel = New System.Windows.Forms.Label()
        ГолыLabel = New System.Windows.Forms.Label()
        КубкиLabel = New System.Windows.Forms.Label()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Игрок_запросBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataRepeater1
        '
        Me.DataRepeater1.Dock = System.Windows.Forms.DockStyle.Bottom
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(КубкиLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.КубкиLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(ГолыLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.ГолыLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(МатчиLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.МатчиLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Заработная_платаLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Заработная_платаLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(СрокLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.СрокLabel1)
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
        Me.DataRepeater1.ItemTemplate.Controls.Add(РостLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.РостLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(ВесLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.ВесLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(ГражданствоLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.ГражданствоLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(АмплуаLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.АмплуаLabel1)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Фамилия_ИмяLabel)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Фамилия_ИмяLabel1)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(833, 150)
        Me.DataRepeater1.Location = New System.Drawing.Point(0, 79)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(841, 486)
        Me.DataRepeater1.TabIndex = 0
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'DS_hokkey
        '
        Me.DS_hokkey.DataSetName = "DS_hokkey"
        Me.DS_hokkey.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Игрок_запросBindingSource
        '
        Me.Игрок_запросBindingSource.DataMember = "Игрок_запрос"
        Me.Игрок_запросBindingSource.DataSource = Me.DS_hokkey
        '
        'Игрок_запросTableAdapter
        '
        Me.Игрок_запросTableAdapter.ClearBeforeFill = True
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
        'Фамилия_ИмяLabel
        '
        Фамилия_ИмяLabel.AutoSize = True
        Фамилия_ИмяLabel.Location = New System.Drawing.Point(3, 5)
        Фамилия_ИмяLabel.Name = "Фамилия_ИмяLabel"
        Фамилия_ИмяLabel.Size = New System.Drawing.Size(84, 13)
        Фамилия_ИмяLabel.TabIndex = 0
        Фамилия_ИмяLabel.Text = "Фамилия Имя:"
        '
        'Фамилия_ИмяLabel1
        '
        Me.Фамилия_ИмяLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Фамилия Имя", True))
        Me.Фамилия_ИмяLabel1.Location = New System.Drawing.Point(104, 5)
        Me.Фамилия_ИмяLabel1.Name = "Фамилия_ИмяLabel1"
        Me.Фамилия_ИмяLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Фамилия_ИмяLabel1.TabIndex = 1
        Me.Фамилия_ИмяLabel1.Text = "Label1"
        '
        'АмплуаLabel
        '
        АмплуаLabel.AutoSize = True
        АмплуаLabel.Location = New System.Drawing.Point(3, 25)
        АмплуаLabel.Name = "АмплуаLabel"
        АмплуаLabel.Size = New System.Drawing.Size(48, 13)
        АмплуаLabel.TabIndex = 2
        АмплуаLabel.Text = "Амплуа:"
        '
        'АмплуаLabel1
        '
        Me.АмплуаLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Номер", True))
        Me.АмплуаLabel1.Location = New System.Drawing.Point(104, 25)
        Me.АмплуаLabel1.Name = "АмплуаLabel1"
        Me.АмплуаLabel1.Size = New System.Drawing.Size(100, 23)
        Me.АмплуаLabel1.TabIndex = 3
        Me.АмплуаLabel1.Text = "Label1"
        '
        'ГражданствоLabel
        '
        ГражданствоLabel.AutoSize = True
        ГражданствоLabel.Location = New System.Drawing.Point(3, 45)
        ГражданствоLabel.Name = "ГражданствоLabel"
        ГражданствоLabel.Size = New System.Drawing.Size(77, 13)
        ГражданствоLabel.TabIndex = 4
        ГражданствоLabel.Text = "Гражданство:"
        '
        'ГражданствоLabel1
        '
        Me.ГражданствоLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Гражданство", True))
        Me.ГражданствоLabel1.Location = New System.Drawing.Point(104, 45)
        Me.ГражданствоLabel1.Name = "ГражданствоLabel1"
        Me.ГражданствоLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ГражданствоLabel1.TabIndex = 5
        Me.ГражданствоLabel1.Text = "Label1"
        '
        'ВесLabel
        '
        ВесLabel.AutoSize = True
        ВесLabel.Location = New System.Drawing.Point(3, 65)
        ВесLabel.Name = "ВесLabel"
        ВесLabel.Size = New System.Drawing.Size(29, 13)
        ВесLabel.TabIndex = 6
        ВесLabel.Text = "Вес:"
        '
        'ВесLabel1
        '
        Me.ВесLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Вес", True))
        Me.ВесLabel1.Location = New System.Drawing.Point(104, 65)
        Me.ВесLabel1.Name = "ВесLabel1"
        Me.ВесLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ВесLabel1.TabIndex = 7
        Me.ВесLabel1.Text = "Label1"
        '
        'РостLabel
        '
        РостLabel.AutoSize = True
        РостLabel.Location = New System.Drawing.Point(3, 85)
        РостLabel.Name = "РостLabel"
        РостLabel.Size = New System.Drawing.Size(34, 13)
        РостLabel.TabIndex = 8
        РостLabel.Text = "Рост:"
        '
        'РостLabel1
        '
        Me.РостLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Рост", True))
        Me.РостLabel1.Location = New System.Drawing.Point(104, 85)
        Me.РостLabel1.Name = "РостLabel1"
        Me.РостLabel1.Size = New System.Drawing.Size(100, 23)
        Me.РостLabel1.TabIndex = 9
        Me.РостLabel1.Text = "Label1"
        '
        'Дата_рожденияLabel
        '
        Дата_рожденияLabel.AutoSize = True
        Дата_рожденияLabel.Location = New System.Drawing.Point(3, 105)
        Дата_рожденияLabel.Name = "Дата_рожденияLabel"
        Дата_рожденияLabel.Size = New System.Drawing.Size(89, 13)
        Дата_рожденияLabel.TabIndex = 10
        Дата_рожденияLabel.Text = "Дата рождения:"
        '
        'Дата_рожденияLabel1
        '
        Me.Дата_рожденияLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Дата рождения", True))
        Me.Дата_рожденияLabel1.Location = New System.Drawing.Point(104, 105)
        Me.Дата_рожденияLabel1.Name = "Дата_рожденияLabel1"
        Me.Дата_рожденияLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Дата_рожденияLabel1.TabIndex = 11
        Me.Дата_рожденияLabel1.Text = "Label1"
        '
        'Место_рожденияLabel
        '
        Место_рожденияLabel.AutoSize = True
        Место_рожденияLabel.Location = New System.Drawing.Point(3, 125)
        Место_рожденияLabel.Name = "Место_рожденияLabel"
        Место_рожденияLabel.Size = New System.Drawing.Size(95, 13)
        Место_рожденияLabel.TabIndex = 12
        Место_рожденияLabel.Text = "Место рождения:"
        '
        'Место_рожденияLabel1
        '
        Me.Место_рожденияLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Место рождения", True))
        Me.Место_рожденияLabel1.Location = New System.Drawing.Point(104, 125)
        Me.Место_рожденияLabel1.Name = "Место_рожденияLabel1"
        Me.Место_рожденияLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Место_рожденияLabel1.TabIndex = 13
        Me.Место_рожденияLabel1.Text = "Label1"
        '
        'НомерLabel
        '
        НомерLabel.AutoSize = True
        НомерLabel.Location = New System.Drawing.Point(271, 5)
        НомерLabel.Name = "НомерLabel"
        НомерLabel.Size = New System.Drawing.Size(44, 13)
        НомерLabel.TabIndex = 14
        НомерLabel.Text = "Номер:"
        '
        'НомерLabel1
        '
        Me.НомерLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Номер", True))
        Me.НомерLabel1.Location = New System.Drawing.Point(352, 5)
        Me.НомерLabel1.Name = "НомерLabel1"
        Me.НомерLabel1.Size = New System.Drawing.Size(100, 23)
        Me.НомерLabel1.TabIndex = 15
        Me.НомерLabel1.Text = "Label1"
        '
        'СерияLabel
        '
        СерияLabel.AutoSize = True
        СерияLabel.Location = New System.Drawing.Point(271, 25)
        СерияLabel.Name = "СерияLabel"
        СерияLabel.Size = New System.Drawing.Size(41, 13)
        СерияLabel.TabIndex = 16
        СерияLabel.Text = "Серия:"
        '
        'СерияLabel1
        '
        Me.СерияLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Серия", True))
        Me.СерияLabel1.Location = New System.Drawing.Point(352, 25)
        Me.СерияLabel1.Name = "СерияLabel1"
        Me.СерияLabel1.Size = New System.Drawing.Size(100, 23)
        Me.СерияLabel1.TabIndex = 17
        Me.СерияLabel1.Text = "Label1"
        '
        'Кем_выданLabel
        '
        Кем_выданLabel.AutoSize = True
        Кем_выданLabel.Location = New System.Drawing.Point(271, 45)
        Кем_выданLabel.Name = "Кем_выданLabel"
        Кем_выданLabel.Size = New System.Drawing.Size(66, 13)
        Кем_выданLabel.TabIndex = 18
        Кем_выданLabel.Text = "Кем выдан:"
        '
        'Кем_выданLabel1
        '
        Me.Кем_выданLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Кем выдан", True))
        Me.Кем_выданLabel1.Location = New System.Drawing.Point(352, 45)
        Me.Кем_выданLabel1.Name = "Кем_выданLabel1"
        Me.Кем_выданLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Кем_выданLabel1.TabIndex = 19
        Me.Кем_выданLabel1.Text = "Label1"
        '
        'Когда_выданLabel
        '
        Когда_выданLabel.AutoSize = True
        Когда_выданLabel.Location = New System.Drawing.Point(271, 65)
        Когда_выданLabel.Name = "Когда_выданLabel"
        Когда_выданLabel.Size = New System.Drawing.Size(75, 13)
        Когда_выданLabel.TabIndex = 20
        Когда_выданLabel.Text = "Когда выдан:"
        '
        'Когда_выданLabel1
        '
        Me.Когда_выданLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Когда выдан", True))
        Me.Когда_выданLabel1.Location = New System.Drawing.Point(352, 65)
        Me.Когда_выданLabel1.Name = "Когда_выданLabel1"
        Me.Когда_выданLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Когда_выданLabel1.TabIndex = 21
        Me.Когда_выданLabel1.Text = "Label1"
        '
        'Дата_заключенияLabel
        '
        Дата_заключенияLabel.AutoSize = True
        Дата_заключенияLabel.Location = New System.Drawing.Point(486, 5)
        Дата_заключенияLabel.Name = "Дата_заключенияLabel"
        Дата_заключенияLabel.Size = New System.Drawing.Size(100, 13)
        Дата_заключенияLabel.TabIndex = 22
        Дата_заключенияLabel.Text = "Дата заключения:"
        '
        'Дата_заключенияLabel1
        '
        Me.Дата_заключенияLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Дата заключения", True))
        Me.Дата_заключенияLabel1.Location = New System.Drawing.Point(592, 5)
        Me.Дата_заключенияLabel1.Name = "Дата_заключенияLabel1"
        Me.Дата_заключенияLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Дата_заключенияLabel1.TabIndex = 23
        Me.Дата_заключенияLabel1.Text = "Label1"
        '
        'СрокLabel
        '
        СрокLabel.AutoSize = True
        СрокLabel.Location = New System.Drawing.Point(486, 25)
        СрокLabel.Name = "СрокLabel"
        СрокLabel.Size = New System.Drawing.Size(35, 13)
        СрокLabel.TabIndex = 24
        СрокLabel.Text = "Срок:"
        '
        'СрокLabel1
        '
        Me.СрокLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Срок", True))
        Me.СрокLabel1.Location = New System.Drawing.Point(592, 25)
        Me.СрокLabel1.Name = "СрокLabel1"
        Me.СрокLabel1.Size = New System.Drawing.Size(100, 23)
        Me.СрокLabel1.TabIndex = 25
        Me.СрокLabel1.Text = "Label1"
        '
        'Заработная_платаLabel
        '
        Заработная_платаLabel.AutoSize = True
        Заработная_платаLabel.Location = New System.Drawing.Point(484, 45)
        Заработная_платаLabel.Name = "Заработная_платаLabel"
        Заработная_платаLabel.Size = New System.Drawing.Size(102, 13)
        Заработная_платаLabel.TabIndex = 26
        Заработная_платаLabel.Text = "Заработная плата:"
        '
        'Заработная_платаLabel1
        '
        Me.Заработная_платаLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Заработная плата", True))
        Me.Заработная_платаLabel1.Location = New System.Drawing.Point(592, 45)
        Me.Заработная_платаLabel1.Name = "Заработная_платаLabel1"
        Me.Заработная_платаLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Заработная_платаLabel1.TabIndex = 27
        Me.Заработная_платаLabel1.Text = "Label1"
        '
        'МатчиLabel
        '
        МатчиLabel.AutoSize = True
        МатчиLabel.Location = New System.Drawing.Point(726, 5)
        МатчиLabel.Name = "МатчиLabel"
        МатчиLabel.Size = New System.Drawing.Size(41, 13)
        МатчиLabel.TabIndex = 28
        МатчиLabel.Text = "Матчи:"
        '
        'МатчиLabel1
        '
        Me.МатчиLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Матчи", True))
        Me.МатчиLabel1.Location = New System.Drawing.Point(773, 5)
        Me.МатчиLabel1.Name = "МатчиLabel1"
        Me.МатчиLabel1.Size = New System.Drawing.Size(100, 23)
        Me.МатчиLabel1.TabIndex = 29
        Me.МатчиLabel1.Text = "Label1"
        '
        'ГолыLabel
        '
        ГолыLabel.AutoSize = True
        ГолыLabel.Location = New System.Drawing.Point(726, 25)
        ГолыLabel.Name = "ГолыLabel"
        ГолыLabel.Size = New System.Drawing.Size(36, 13)
        ГолыLabel.TabIndex = 30
        ГолыLabel.Text = "Голы:"
        '
        'ГолыLabel1
        '
        Me.ГолыLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Голы", True))
        Me.ГолыLabel1.Location = New System.Drawing.Point(773, 23)
        Me.ГолыLabel1.Name = "ГолыLabel1"
        Me.ГолыLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ГолыLabel1.TabIndex = 31
        Me.ГолыLabel1.Text = "Label1"
        '
        'КубкиLabel
        '
        КубкиLabel.AutoSize = True
        КубкиLabel.Location = New System.Drawing.Point(726, 45)
        КубкиLabel.Name = "КубкиLabel"
        КубкиLabel.Size = New System.Drawing.Size(40, 13)
        КубкиLabel.TabIndex = 32
        КубкиLabel.Text = "Кубки:"
        '
        'КубкиLabel1
        '
        Me.КубкиLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Игрок_запросBindingSource, "Кубки", True))
        Me.КубкиLabel1.Location = New System.Drawing.Point(773, 45)
        Me.КубкиLabel1.Name = "КубкиLabel1"
        Me.КубкиLabel1.Size = New System.Drawing.Size(100, 23)
        Me.КубкиLabel1.TabIndex = 33
        Me.КубкиLabel1.Text = "Label1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(304, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Паспорт"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 19)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Основная информация"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(532, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Контракт"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(762, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Игры"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 42)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Фильтрация"
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(591, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Фильтровать"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(115, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox1.TabIndex = 2
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Значение:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(346, 13)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(236, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'Players
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(841, 565)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataRepeater1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Players"
        Me.Text = "Игроки"
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        Me.DataRepeater1.ResumeLayout(False)
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Игрок_запросBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataRepeater1 As Microsoft.VisualBasic.PowerPacks.DataRepeater
    Friend WithEvents DS_hokkey As Hokkey.DS_hokkey
    Friend WithEvents Игрок_запросBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Игрок_запросTableAdapter As Hokkey.DS_hokkeyTableAdapters.Игрок_запросTableAdapter
    Friend WithEvents TableAdapterManager As Hokkey.DS_hokkeyTableAdapters.TableAdapterManager
    Friend WithEvents КубкиLabel1 As System.Windows.Forms.Label
    Friend WithEvents ГолыLabel1 As System.Windows.Forms.Label
    Friend WithEvents МатчиLabel1 As System.Windows.Forms.Label
    Friend WithEvents Заработная_платаLabel1 As System.Windows.Forms.Label
    Friend WithEvents СрокLabel1 As System.Windows.Forms.Label
    Friend WithEvents Дата_заключенияLabel1 As System.Windows.Forms.Label
    Friend WithEvents Когда_выданLabel1 As System.Windows.Forms.Label
    Friend WithEvents Кем_выданLabel1 As System.Windows.Forms.Label
    Friend WithEvents СерияLabel1 As System.Windows.Forms.Label
    Friend WithEvents НомерLabel1 As System.Windows.Forms.Label
    Friend WithEvents Место_рожденияLabel1 As System.Windows.Forms.Label
    Friend WithEvents Дата_рожденияLabel1 As System.Windows.Forms.Label
    Friend WithEvents РостLabel1 As System.Windows.Forms.Label
    Friend WithEvents ВесLabel1 As System.Windows.Forms.Label
    Friend WithEvents ГражданствоLabel1 As System.Windows.Forms.Label
    Friend WithEvents АмплуаLabel1 As System.Windows.Forms.Label
    Friend WithEvents Фамилия_ИмяLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
