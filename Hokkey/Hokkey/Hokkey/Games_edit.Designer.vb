<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Games_edit
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.УдалитьСтрокуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DS_hokkey = New Hokkey.DS_hokkey()
        Me.РасписаниеBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РасписаниеTableAdapter = New Hokkey.DS_hokkeyTableAdapters.РасписаниеTableAdapter()
        Me.TableAdapterManager = New Hokkey.DS_hokkeyTableAdapters.TableAdapterManager()
        Me.РасписаниеDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.УдалитьСтрокуToolStripMenuItem, Me.СохранитьToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 24)
        Me.MenuStrip1.TabIndex = 4
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
        'DS_hokkey
        '
        Me.DS_hokkey.DataSetName = "DS_hokkey"
        Me.DS_hokkey.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'РасписаниеBindingSource
        '
        Me.РасписаниеBindingSource.DataMember = "Расписание"
        Me.РасписаниеBindingSource.DataSource = Me.DS_hokkey
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
        'РасписаниеDataGridView
        '
        Me.РасписаниеDataGridView.AutoGenerateColumns = False
        Me.РасписаниеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.РасписаниеDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.РасписаниеDataGridView.DataSource = Me.РасписаниеBindingSource
        Me.РасписаниеDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.РасписаниеDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.РасписаниеDataGridView.Name = "РасписаниеDataGridView"
        Me.РасписаниеDataGridView.Size = New System.Drawing.Size(859, 521)
        Me.РасписаниеDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Соперник"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Соперник"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Дата проведение"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Дата проведение"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Забито"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Забито"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Пропущено"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Пропущено"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Первый игрок"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Первый игрок"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Второй игрок"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Второй игрок"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Третий игрок"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Третий игрок"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Четвертый игрок"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Четвертый игрок"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Пятый игрок"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Пятый игрок"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Вратарь"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Вратарь"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Games_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(859, 545)
        Me.Controls.Add(Me.РасписаниеDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Games_edit"
        Me.Text = "Редактирование игр"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DS_hokkey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents УдалитьСтрокуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СохранитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DS_hokkey As Hokkey.DS_hokkey
    Friend WithEvents РасписаниеBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РасписаниеTableAdapter As Hokkey.DS_hokkeyTableAdapters.РасписаниеTableAdapter
    Friend WithEvents TableAdapterManager As Hokkey.DS_hokkeyTableAdapters.TableAdapterManager
    Friend WithEvents РасписаниеDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
