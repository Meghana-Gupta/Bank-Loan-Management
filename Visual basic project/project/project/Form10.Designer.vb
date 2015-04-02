<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Voter_IDLabel As System.Windows.Forms.Label
        Dim Loan_IdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Database1DataSet1 = New WindowsApplication1.Database1DataSet1()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New WindowsApplication1.Database1DataSet1TableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSet1TableAdapters.TableAdapterManager()
        Me.Table1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Table1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Voter_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Loan_IdTextBox = New System.Windows.Forms.TextBox()
        Voter_IDLabel = New System.Windows.Forms.Label()
        Loan_IdLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Voter_IDLabel
        '
        Voter_IDLabel.AutoSize = True
        Voter_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Voter_IDLabel.Location = New System.Drawing.Point(106, 58)
        Voter_IDLabel.Name = "Voter_IDLabel"
        Voter_IDLabel.Size = New System.Drawing.Size(65, 18)
        Voter_IDLabel.TabIndex = 5
        Voter_IDLabel.Text = "Voter ID:"
        '
        'Loan_IdLabel
        '
        Loan_IdLabel.AutoSize = True
        Loan_IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Loan_IdLabel.Location = New System.Drawing.Point(109, 99)
        Loan_IdLabel.Name = "Loan_IdLabel"
        Loan_IdLabel.Size = New System.Drawing.Size(60, 18)
        Loan_IdLabel.TabIndex = 6
        Loan_IdLabel.Text = "Loan Id:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(184, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database1DataSet1
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.Table3TableAdapter = Nothing
        Me.TableAdapterManager.Table4TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table1BindingNavigator
        '
        Me.Table1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Table1BindingNavigator.BindingSource = Me.Table1BindingSource
        Me.Table1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Table1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Table1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Table1BindingNavigatorSaveItem})
        Me.Table1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Table1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Table1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Table1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Table1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Table1BindingNavigator.Name = "Table1BindingNavigator"
        Me.Table1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Table1BindingNavigator.Size = New System.Drawing.Size(506, 25)
        Me.Table1BindingNavigator.TabIndex = 5
        Me.Table1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Table1BindingNavigatorSaveItem
        '
        Me.Table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Table1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Table1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Table1BindingNavigatorSaveItem.Name = "Table1BindingNavigatorSaveItem"
        Me.Table1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Table1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'Voter_IDTextBox
        '
        Me.Voter_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Voter ID", True))
        Me.Voter_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voter_IDTextBox.Location = New System.Drawing.Point(199, 52)
        Me.Voter_IDTextBox.Name = "Voter_IDTextBox"
        Me.Voter_IDTextBox.Size = New System.Drawing.Size(158, 24)
        Me.Voter_IDTextBox.TabIndex = 6
        '
        'Loan_IdTextBox
        '
        Me.Loan_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Loan Id", True))
        Me.Loan_IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loan_IdTextBox.Location = New System.Drawing.Point(199, 96)
        Me.Loan_IdTextBox.Name = "Loan_IdTextBox"
        Me.Loan_IdTextBox.Size = New System.Drawing.Size(158, 24)
        Me.Loan_IdTextBox.TabIndex = 7
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(506, 227)
        Me.Controls.Add(Loan_IdLabel)
        Me.Controls.Add(Me.Loan_IdTextBox)
        Me.Controls.Add(Voter_IDLabel)
        Me.Controls.Add(Me.Voter_IDTextBox)
        Me.Controls.Add(Me.Table1BindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form10"
        Me.Text = "Provide it"
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table1BindingNavigator.ResumeLayout(False)
        Me.Table1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet1 As WindowsApplication1.Database1DataSet1
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As WindowsApplication1.Database1DataSet1TableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Table1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Table1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Voter_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Loan_IdTextBox As System.Windows.Forms.TextBox
End Class
