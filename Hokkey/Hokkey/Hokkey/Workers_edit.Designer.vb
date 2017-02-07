<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Workers_edit
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.УдалитьСтрокуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ПаспортBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПаспортTableAdapter = New Hokkey.DS_hokkeyTableAdapters.ПаспортTableAdapter()
        Me.TableAdapterManager = New Hokkey.DS_hokkeyTableAdapters.TableAdapterManager()
        Me.ПаспортDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Трудовой_договорBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Трудовой_договорTableAdapter = New Hokkey.DS_hokkeyTableAdapters.Трудовой_договорTableAdapter()
        Me.Трудовой_договорDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СтатусBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СтатусTableAdapter = New Hokkey.DS_hokkeyTableAdapters.СтатусTableAdapter()
        Me.СтатусDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ПерсоналBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПерсоналTableAdapter = New Hokkey.DS_hokkeyTableAdapters.ПерсоналTableAdapter()
        Me.ПерсоналDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ПаспортBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПаспортDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Трудовой_договорBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Трудовой_договорDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтатусBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтатусDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.ПерсоналBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПерсоналDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS_hokkey
        '
        Me.DS_hokkey.DataSetName = "DS_hokkey"
        Me.DS_hokkey.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
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
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Трудовой_договорDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(851, 441)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Трудовой договор"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.УдалитьСтрокуToolStripMenuItem, Me.СохранитьToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ПаспортBindingSource
        '
        Me.ПаспортBindingSource.DataMember = "Паспорт"
        Me.ПаспортBindingSource.DataSource = Me.DS_hokkey
        '
        'ПаспортTableAdapter
        '
        Me.ПаспортTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Hokkey.DS_hokkeyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ДостиженияTableAdapter = Nothing
        Me.TableAdapterManager.ИгрокTableAdapter = Nothing
        Me.TableAdapterManager.КонтрактTableAdapter = Nothing
        Me.TableAdapterManager.ПаспортTableAdapter = Me.ПаспортTableAdapter
        Me.TableAdapterManager.ПерсоналTableAdapter = Me.ПерсоналTableAdapter
        Me.TableAdapterManager.РасписаниеTableAdapter = Nothing
        Me.TableAdapterManager.СтатусTableAdapter = Me.СтатусTableAdapter
        Me.TableAdapterManager.Трудовой_договорTableAdapter = Me.Трудовой_договорTableAdapter
        Me.TableAdapterManager.Уровни_доступаTableAdapter = Nothing
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
        'Трудовой_договорBindingSource
        '
        Me.Трудовой_договорBindingSource.DataMember = "Трудовой договор"
        Me.Трудовой_договорBindingSource.DataSource = Me.DS_hokkey
        '
        'Трудовой_договорTableAdapter
        '
        Me.Трудовой_договорTableAdapter.ClearBeforeFill = True
        '
        'Трудовой_договорDataGridView
        '
        Me.Трудовой_договорDataGridView.AutoGenerateColumns = False
        Me.Трудовой_договорDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Трудовой_договорDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Трудовой_договорDataGridView.DataSource = Me.Трудовой_договорBindingSource
        Me.Трудовой_договорDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Трудовой_договорDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Трудовой_договорDataGridView.Name = "Трудовой_договорDataGridView"
        Me.Трудовой_договорDataGridView.Size = New System.Drawing.Size(845, 435)
        Me.Трудовой_договорDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Заработная плата"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Заработная плата"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Дата заключения"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Дата заключения"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'СтатусBindingSource
        '
        Me.СтатусBindingSource.DataMember = "Статус"
        Me.СтатусBindingSource.DataSource = Me.DS_hokkey
        '
        'СтатусTableAdapter
        '
        Me.СтатусTableAdapter.ClearBeforeFill = True
        '
        'СтатусDataGridView
        '
        Me.СтатусDataGridView.AutoGenerateColumns = False
        Me.СтатусDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.СтатусDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.СтатусDataGridView.DataSource = Me.СтатусBindingSource
        Me.СтатусDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.СтатусDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.СтатусDataGridView.Name = "СтатусDataGridView"
        Me.СтатусDataGridView.Size = New System.Drawing.Size(845, 435)
        Me.СтатусDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Вид статуса"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Вид статуса"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Уровень доступа"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Уровень доступа"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Пароль"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Пароль"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.ПерсоналDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(851, 441)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Персонал"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ПерсоналBindingSource
        '
        Me.ПерсоналBindingSource.DataMember = "Персонал"
        Me.ПерсоналBindingSource.DataSource = Me.DS_hokkey
        '
        'ПерсоналTableAdapter
        '
        Me.ПерсоналTableAdapter.ClearBeforeFill = True
        '
        'ПерсоналDataGridView
        '
        Me.ПерсоналDataGridView.AutoGenerateColumns = False
        Me.ПерсоналDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ПерсоналDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.ПерсоналDataGridView.DataSource = Me.ПерсоналBindingSource
        Me.ПерсоналDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ПерсоналDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ПерсоналDataGridView.Name = "ПерсоналDataGridView"
        Me.ПерсоналDataGridView.Size = New System.Drawing.Size(845, 435)
        Me.ПерсоналDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Фамилия Имя"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Фамилия Имя"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ID договор"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ID договор"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ID статус_паспорт"
        Me.DataGridViewTextBoxColumn18.HeaderText = "ID статус_паспорт"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'Workers_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(859, 491)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Workers_edit"
        Me.Text = "Редактирование сотрудников"
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ПаспортBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПаспортDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Трудовой_договорBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Трудовой_договорDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтатусBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтатусDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ПерсоналBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПерсоналDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS_hokkey As Hokkey.DS_hokkey
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents УдалитьСтрокуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ПаспортBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПаспортTableAdapter As Hokkey.DS_hokkeyTableAdapters.ПаспортTableAdapter
    Friend WithEvents TableAdapterManager As Hokkey.DS_hokkeyTableAdapters.TableAdapterManager
    Friend WithEvents ПаспортDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Трудовой_договорTableAdapter As Hokkey.DS_hokkeyTableAdapters.Трудовой_договорTableAdapter
    Friend WithEvents Трудовой_договорBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Трудовой_договорDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents СтатусTableAdapter As Hokkey.DS_hokkeyTableAdapters.СтатусTableAdapter
    Friend WithEvents СтатусBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СтатусDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ПерсоналTableAdapter As Hokkey.DS_hokkeyTableAdapters.ПерсоналTableAdapter
    Friend WithEvents ПерсоналBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПерсоналDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
