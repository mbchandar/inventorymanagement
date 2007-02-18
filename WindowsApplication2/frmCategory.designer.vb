<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategories
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategories))
        Me.CategoryList = New System.Windows.Forms.GroupBox
        Me.lbCategory = New System.Windows.Forms.ListBox
        Me.CategoriesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet = New InventorManagement.stockDataSet
        Me.GroupBoxAdd = New System.Windows.Forms.GroupBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtCategoryName = New System.Windows.Forms.TextBox
        Me.lblCategoryName = New System.Windows.Forms.Label
        Me.CategoriesTableAdapter = New InventorManagement.stockDataSetTableAdapters.CategoriesTableAdapter
        Me.CategoryList.SuspendLayout()
        CType(Me.CategoriesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'CategoryList
        '
        Me.CategoryList.BackColor = System.Drawing.Color.Transparent
        Me.CategoryList.Controls.Add(Me.lbCategory)
        resources.ApplyResources(Me.CategoryList, "CategoryList")
        Me.CategoryList.ForeColor = System.Drawing.Color.Black
        Me.CategoryList.Name = "CategoryList"
        Me.CategoryList.TabStop = False
        '
        'lbCategory
        '
        Me.lbCategory.BackColor = System.Drawing.Color.White
        Me.lbCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCategory.DataSource = Me.CategoriesBindingSource1
        Me.lbCategory.DisplayMember = "CategoryName"
        resources.ApplyResources(Me.lbCategory, "lbCategory")
        Me.lbCategory.FormatString = "Bala"
        Me.lbCategory.FormattingEnabled = True
        Me.lbCategory.Name = "lbCategory"
        Me.lbCategory.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbCategory.ValueMember = "CategoryID"
        '
        'CategoriesBindingSource1
        '
        Me.CategoriesBindingSource1.DataMember = "Categories"
        Me.CategoriesBindingSource1.DataSource = Me.StockDataSetBindingSource
        '
        'StockDataSetBindingSource
        '
        Me.StockDataSetBindingSource.DataSource = Me.StockDataSet
        Me.StockDataSetBindingSource.Position = 0
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "stockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxAdd
        '
        Me.GroupBoxAdd.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxAdd.Controls.Add(Me.btnDelete)
        Me.GroupBoxAdd.Controls.Add(Me.btnSave)
        Me.GroupBoxAdd.Controls.Add(Me.btnClose)
        Me.GroupBoxAdd.Controls.Add(Me.btnCancel)
        Me.GroupBoxAdd.Controls.Add(Me.btnAdd)
        Me.GroupBoxAdd.Controls.Add(Me.txtCategoryName)
        Me.GroupBoxAdd.Controls.Add(Me.lblCategoryName)
        resources.ApplyResources(Me.GroupBoxAdd, "GroupBoxAdd")
        Me.GroupBoxAdd.Name = "GroupBoxAdd"
        Me.GroupBoxAdd.TabStop = False
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.Name = "btnSave"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Name = "btnClose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtCategoryName
        '
        resources.ApplyResources(Me.txtCategoryName, "txtCategoryName")
        Me.txtCategoryName.Name = "txtCategoryName"
        '
        'lblCategoryName
        '
        resources.ApplyResources(Me.lblCategoryName, "lblCategoryName")
        Me.lblCategoryName.ForeColor = System.Drawing.Color.Black
        Me.lblCategoryName.Name = "lblCategoryName"
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'frmCategories
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.GroupBoxAdd)
        Me.Controls.Add(Me.CategoryList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmCategories"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CategoryList.ResumeLayout(False)
        CType(Me.CategoriesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAdd.ResumeLayout(False)
        Me.GroupBoxAdd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StockDataSet As InventorManagement.stockDataSet
    Friend WithEvents CategoryList As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxAdd As System.Windows.Forms.GroupBox
    Friend WithEvents txtCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents lblCategoryName As System.Windows.Forms.Label
    Friend WithEvents CategoriesTableAdapter As InventorManagement.stockDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents CategoriesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StockDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lbCategory As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
