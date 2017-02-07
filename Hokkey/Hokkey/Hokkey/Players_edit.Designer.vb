<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Players_edit
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
        Me.DS_hokkey = New Hokkey.DS_hokkey()
        Me.Игрок_запросDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ФамилияИмяDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.АмплуаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГражданствоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ВесDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.РостDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDСтатуспаспортDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDДостижениеконтрактDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ИгрокBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ИгрокTableAdapter = New Hokkey.DS_hokkeyTableAdapters.ИгрокTableAdapter()
        Me.TableAdapterManager = New Hokkey.DS_hokkeyTableAdapters.TableAdapterManager()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ПаспортDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПаспортBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.КонтрактDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.КонтрактBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.СтатусDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СтатусBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ПаспортTableAdapter = New Hokkey.DS_hokkeyTableAdapters.ПаспортTableAdapter()
        Me.КонтрактTableAdapter = New Hokkey.DS_hokkeyTableAdapters.КонтрактTableAdapter()
        Me.СтатусTableAdapter = New Hokkey.DS_hokkeyTableAdapters.СтатусTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.УдалитьСтрокуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ДостиженияBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ДостиженияTableAdapter = New Hokkey.DS_hokkeyTableAdapters.ДостиженияTableAdapter()
        Me.ДостиженияDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Игрок_запросDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ИгрокBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ПаспортDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПаспортBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.КонтрактDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КонтрактBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.СтатусDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтатусBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.ДостиженияBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ДостиженияDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS_hokkey
        '
        Me.DS_hokkey.DataSetName = "DS_hokkey"
        Me.DS_hokkey.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Игрок_запросDataGridView
        '
        Me.Игрок_запросDataGridView.AutoGenerateColumns = False
        Me.Игрок_запросDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Игрок_запросDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ФамилияИмяDataGridViewTextBoxColumn, Me.АмплуаDataGridViewTextBoxColumn, Me.ГражданствоDataGridViewTextBoxColumn, Me.ВесDataGridViewTextBoxColumn, Me.РостDataGridViewTextBoxColumn, Me.IDСтатуспаспортDataGridViewTextBoxColumn, Me.IDДостижениеконтрактDataGridViewTextBoxColumn})
        Me.Игрок_запросDataGridView.DataSource = Me.ИгрокBindingSource
        Me.Игрок_запросDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Игрок_запросDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Игрок_запросDataGridView.Name = "Игрок_запросDataGridView"
        Me.Игрок_запросDataGridView.Size = New System.Drawing.Size(845, 435)
        Me.Игрок_запросDataGridView.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'ФамилияИмяDataGridViewTextBoxColumn
        '
        Me.ФамилияИмяDataGridViewTextBoxColumn.DataPropertyName = "Фамилия Имя"
        Me.ФамилияИмяDataGridViewTextBoxColumn.HeaderText = "Фамилия Имя"
        Me.ФамилияИмяDataGridViewTextBoxColumn.Name = "ФамилияИмяDataGridViewTextBoxColumn"
        '
        'АмплуаDataGridViewTextBoxColumn
        '
        Me.АмплуаDataGridViewTextBoxColumn.DataPropertyName = "Амплуа"
        Me.АмплуаDataGridViewTextBoxColumn.HeaderText = "Амплуа"
        Me.АмплуаDataGridViewTextBoxColumn.Name = "АмплуаDataGridViewTextBoxColumn"
        '
        'ГражданствоDataGridViewTextBoxColumn
        '
        Me.ГражданствоDataGridViewTextBoxColumn.DataPropertyName = "Гражданство"
        Me.ГражданствоDataGridViewTextBoxColumn.HeaderText = "Гражданство"
        Me.ГражданствоDataGridViewTextBoxColumn.Name = "ГражданствоDataGridViewTextBoxColumn"
        '
        'ВесDataGridViewTextBoxColumn
        '
        Me.ВесDataGridViewTextBoxColumn.DataPropertyName = "Вес"
        Me.ВесDataGridViewTextBoxColumn.HeaderText = "Вес"
        Me.ВесDataGridViewTextBoxColumn.Name = "ВесDataGridViewTextBoxColumn"
        '
        'РостDataGridViewTextBoxColumn
        '
        Me.РостDataGridViewTextBoxColumn.DataPropertyName = "Рост"
        Me.РостDataGridViewTextBoxColumn.HeaderText = "Рост"
        Me.РостDataGridViewTextBoxColumn.Name = "РостDataGridViewTextBoxColumn"
        '
        'IDСтатуспаспортDataGridViewTextBoxColumn
        '
        Me.IDСтатуспаспортDataGridViewTextBoxColumn.DataPropertyName = "ID статус_паспорт"
        Me.IDСтатуспаспортDataGridViewTextBoxColumn.HeaderText = "ID статус_паспорт"
        Me.IDСтатуспаспортDataGridViewTextBoxColumn.Name = "IDСтатуспаспортDataGridViewTextBoxColumn"
        '
        'IDДостижениеконтрактDataGridViewTextBoxColumn
        '
        Me.IDДостижениеконтрактDataGridViewTextBoxColumn.DataPropertyName = "ID достижение_контракт"
        Me.IDДостижениеконтрактDataGridViewTextBoxColumn.HeaderText = "ID достижение_контракт"
        Me.IDДостижениеконтрактDataGridViewTextBoxColumn.Name = "IDДостижениеконтрактDataGridViewTextBoxColumn"
        '
        'ИгрокBindingSource
        '
        Me.ИгрокBindingSource.DataMember = "Игрок"
        Me.ИгрокBindingSource.DataSource = Me.DS_hokkey
        '
        'ИгрокTableAdapter
        '
        Me.ИгрокTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Hokkey.DS_hokkeyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ДостиженияTableAdapter = Nothing
        Me.TableAdapterManager.ИгрокTableAdapter = Me.ИгрокTableAdapter
        Me.TableAdapterManager.КонтрактTableAdapter = Nothing
        Me.TableAdapterManager.ПаспортTableAdapter = Nothing
        Me.TableAdapterManager.ПерсоналTableAdapter = Nothing
        Me.TableAdapterManager.РасписаниеTableAdapter = Nothing
        Me.TableAdapterManager.СтатусTableAdapter = Nothing
        Me.TableAdapterManager.Трудовой_договорTableAdapter = Nothing
        Me.TableAdapterManager.Уровни_доступаTableAdapter = Nothing
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage1)

        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(859, 467)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ПаспортDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(851, 441)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Паспорт"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ПаспортDataGridView
        '
        Me.ПаспортDataGridView.AutoGenerateColumns = False
        Me.ПаспортDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ПаспортDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ПаспортDataGridView.DataSource = Me.ПаспортBindingSource
        Me.ПаспортDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ПаспортDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ПаспортDataGridView.Name = "ПаспортDataGridView"
        Me.ПаспортDataGridView.Size = New System.Drawing.Size(845, 435)
        Me.ПаспортDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Номер"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Номер"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Серия"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Серия"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Кем выдан"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Кем выдан"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Когда выдан"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Когда выдан"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Дата рождения"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Дата рождения"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Место рождения"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Место рождения"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'ПаспортBindingSource
        '
        Me.ПаспортBindingSource.DataMember = "Паспорт"
        Me.ПаспортBindingSource.DataSource = Me.DS_hokkey
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.КонтрактDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(851, 441)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Контракт"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'КонтрактDataGridView
        '
        Me.КонтрактDataGridView.AutoGenerateColumns = False
        Me.КонтрактDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.КонтрактDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.КонтрактDataGridView.DataSource = Me.КонтрактBindingSource
        Me.КонтрактDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.КонтрактDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.КонтрактDataGridView.Name = "КонтрактDataGridView"
        Me.КонтрактDataGridView.Size = New System.Drawing.Size(845, 435)
        Me.КонтрактDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Срок"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Срок"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Заработная плата"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Заработная плата"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Дата заключения"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Дата заключения"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'КонтрактBindingSource
        '
        Me.КонтрактBindingSource.DataMember = "Контракт"
        Me.КонтрактBindingSource.DataSource = Me.DS_hokkey
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.СтатусDataGridView)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(851, 441)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Статус"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'СтатусDataGridView
        '
        Me.СтатусDataGridView.AutoGenerateColumns = False
        Me.СтатусDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.СтатусDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.СтатусDataGridView.DataSource = Me.СтатусBindingSource
        Me.СтатусDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.СтатусDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.СтатусDataGridView.Name = "СтатусDataGridView"
        Me.СтатусDataGridView.Size = New System.Drawing.Size(845, 435)
        Me.СтатусDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Вид статуса"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Вид статуса"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Уровень доступа"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Уровень доступа"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Пароль"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Пароль"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'СтатусBindingSource
        '
        Me.СтатусBindingSource.DataMember = "Статус"
        Me.СтатусBindingSource.DataSource = Me.DS_hokkey
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Игрок_запросDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(851, 441)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Игрок"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ПаспортTableAdapter
        '
        Me.ПаспортTableAdapter.ClearBeforeFill = True
        '
        'КонтрактTableAdapter
        '
        Me.КонтрактTableAdapter.ClearBeforeFill = True
        '
        'СтатусTableAdapter
        '
        Me.СтатусTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.УдалитьСтрокуToolStripMenuItem, Me.СохранитьToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'УдалитьСтрокуToolStripMenuItem
        '
        Me.УдалитьСтрокуToolStripMenuItem.Name = "УдалитьСтрокуToolStripMenuItem"
        Me.УдалитьСтрокуToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.УдалитьСтрокуToolStripMenuItem.Text = "Удалить строку"
        '
        'СохранитьToolStripMenuItem
        '
        Me.СохранитьToolStripMenuItem.Name = "СохранитьToolStripMenuItem"
        Me.СохранитьToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.СохранитьToolStripMenuItem.Text = "Сохранить"
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.ДостиженияDataGridView)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(851, 441)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Достижения"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ДостиженияBindingSource
        '
        Me.ДостиженияBindingSource.DataMember = "Достижения"
        Me.ДостиженияBindingSource.DataSource = Me.DS_hokkey
        '
        'ДостиженияTableAdapter
        '
        Me.ДостиженияTableAdapter.ClearBeforeFill = True
        '
        'ДостиженияDataGridView
        '
        Me.ДостиженияDataGridView.AutoGenerateColumns = False
        Me.ДостиженияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ДостиженияDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.ДостиженияDataGridView.DataSource = Me.ДостиженияBindingSource
        Me.ДостиженияDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ДостиженияDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ДостиженияDataGridView.Name = "ДостиженияDataGridView"
        Me.ДостиженияDataGridView.Size = New System.Drawing.Size(845, 435)
        Me.ДостиженияDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Кубки"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Кубки"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Голы"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Голы"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Матчи"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Матчи"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'Players_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(859, 491)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Players_edit"
        Me.Text = "Редактирование игроков"
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Игрок_запросDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ИгрокBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ПаспортDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПаспортBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.КонтрактDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КонтрактBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.СтатусDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтатусBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.ДостиженияBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ДостиженияDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS_hokkey As Hokkey.DS_hokkey
    Friend WithEvents Игрок_запросDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ФамилияИмяDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents АмплуаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ГражданствоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ВесDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РостDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDСтатуспаспортDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDДостижениеконтрактDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ИгрокBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ИгрокTableAdapter As Hokkey.DS_hokkeyTableAdapters.ИгрокTableAdapter
    Friend WithEvents TableAdapterManager As Hokkey.DS_hokkeyTableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ПаспортBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПаспортTableAdapter As Hokkey.DS_hokkeyTableAdapters.ПаспортTableAdapter
    Friend WithEvents ПаспортDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КонтрактBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents КонтрактTableAdapter As Hokkey.DS_hokkeyTableAdapters.КонтрактTableAdapter
    Friend WithEvents КонтрактDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents СтатусBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СтатусTableAdapter As Hokkey.DS_hokkeyTableAdapters.СтатусTableAdapter
    Friend WithEvents СтатусDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents УдалитьСтрокуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ДостиженияBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ДостиженияTableAdapter As Hokkey.DS_hokkeyTableAdapters.ДостиженияTableAdapter
    Friend WithEvents ДостиженияDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
