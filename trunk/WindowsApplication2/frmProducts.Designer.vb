<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducts))
        Me.ProductList = New System.Windows.Forms.GroupBox
        Me.lbProduct = New System.Windows.Forms.ListBox
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet = New InventorManagement.stockDataSet
        Me.GroupBoxAdd = New System.Windows.Forms.GroupBox
        Me.GroupBoxComps = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.lblReOrde = New System.Windows.Forms.Label
        Me.txtUnitPrice = New System.Windows.Forms.TextBox
        Me.lblUnitPrice = New System.Windows.Forms.Label
        Me.txtUnitsOnOrder = New System.Windows.Forms.TextBox
        Me.lblUnitsOnOrder = New System.Windows.Forms.Label
        Me.calcOrdered = New System.Windows.Forms.MonthCalendar
        Me.cmbCategory = New System.Windows.Forms.ComboBox
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtUnitsInStock = New System.Windows.Forms.TextBox
        Me.txtDateOrdered = New System.Windows.Forms.TextBox
        Me.txtSupplier = New System.Windows.Forms.TextBox
        Me.lblUnitsInStock = New System.Windows.Forms.Label
        Me.lblSupplier = New System.Windows.Forms.Label
        Me.lblDateOrdered = New System.Windows.Forms.Label
        Me.txtProductDescription = New System.Windows.Forms.TextBox
        Me.lblProductDescription = New System.Windows.Forms.Label
        Me.lblCategory = New System.Windows.Forms.Label
        Me.txtProductName = New System.Windows.Forms.TextBox
        Me.lblProductName = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.ProductsTableAdapter = New InventorManagement.stockDataSetTableAdapters.ProductsTableAdapter
        Me.CategoriesTableAdapter = New InventorManagement.stockDataSetTableAdapters.CategoriesTableAdapter
        Me.ProductList.SuspendLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAdd.SuspendLayout()
        Me.GroupBoxComps.SuspendLayout()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductList
        '
        Me.ProductList.BackColor = System.Drawing.Color.Transparent
        Me.ProductList.Controls.Add(Me.lbProduct)
        resources.ApplyResources(Me.ProductList, "ProductList")
        Me.ProductList.ForeColor = System.Drawing.Color.Black
        Me.ProductList.Name = "ProductList"
        Me.ProductList.TabStop = False
        '
        'lbProduct
        '
        Me.lbProduct.BackColor = System.Drawing.Color.White
        Me.lbProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbProduct.DataSource = Me.ProductsBindingSource
        Me.lbProduct.DisplayMember = "Name"
        resources.ApplyResources(Me.lbProduct, "lbProduct")
        Me.lbProduct.FormatString = "Bala"
        Me.lbProduct.FormattingEnabled = True
        Me.lbProduct.Name = "lbProduct"
        Me.lbProduct.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbProduct.ValueMember = "ProductID"
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.StockDataSetBindingSource
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
        Me.GroupBoxAdd.Controls.Add(Me.GroupBoxComps)
        Me.GroupBoxAdd.Controls.Add(Me.btnDelete)
        Me.GroupBoxAdd.Controls.Add(Me.btnSave)
        Me.GroupBoxAdd.Controls.Add(Me.btnClose)
        Me.GroupBoxAdd.Controls.Add(Me.btnCancel)
        Me.GroupBoxAdd.Controls.Add(Me.btnAdd)
        resources.ApplyResources(Me.GroupBoxAdd, "GroupBoxAdd")
        Me.GroupBoxAdd.Name = "GroupBoxAdd"
        Me.GroupBoxAdd.TabStop = False
        '
        'GroupBoxComps
        '
        Me.GroupBoxComps.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.GroupBoxComps, "GroupBoxComps")
        Me.GroupBoxComps.Controls.Add(Me.TextBox2)
        Me.GroupBoxComps.Controls.Add(Me.lblReOrde)
        Me.GroupBoxComps.Controls.Add(Me.txtUnitPrice)
        Me.GroupBoxComps.Controls.Add(Me.lblUnitPrice)
        Me.GroupBoxComps.Controls.Add(Me.txtUnitsOnOrder)
        Me.GroupBoxComps.Controls.Add(Me.lblUnitsOnOrder)
        Me.GroupBoxComps.Controls.Add(Me.calcOrdered)
        Me.GroupBoxComps.Controls.Add(Me.cmbCategory)
        Me.GroupBoxComps.Controls.Add(Me.txtUnitsInStock)
        Me.GroupBoxComps.Controls.Add(Me.txtDateOrdered)
        Me.GroupBoxComps.Controls.Add(Me.txtSupplier)
        Me.GroupBoxComps.Controls.Add(Me.lblUnitsInStock)
        Me.GroupBoxComps.Controls.Add(Me.lblSupplier)
        Me.GroupBoxComps.Controls.Add(Me.lblDateOrdered)
        Me.GroupBoxComps.Controls.Add(Me.txtProductDescription)
        Me.GroupBoxComps.Controls.Add(Me.lblProductDescription)
        Me.GroupBoxComps.Controls.Add(Me.lblCategory)
        Me.GroupBoxComps.Controls.Add(Me.txtProductName)
        Me.GroupBoxComps.Controls.Add(Me.lblProductName)
        Me.GroupBoxComps.Name = "GroupBoxComps"
        Me.GroupBoxComps.TabStop = False
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Tag = ""
        '
        'lblReOrde
        '
        resources.ApplyResources(Me.lblReOrde, "lblReOrde")
        Me.lblReOrde.ForeColor = System.Drawing.Color.Black
        Me.lblReOrde.Name = "lblReOrde"
        '
        'txtUnitPrice
        '
        resources.ApplyResources(Me.txtUnitPrice, "txtUnitPrice")
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Tag = ""
        '
        'lblUnitPrice
        '
        resources.ApplyResources(Me.lblUnitPrice, "lblUnitPrice")
        Me.lblUnitPrice.ForeColor = System.Drawing.Color.Black
        Me.lblUnitPrice.Name = "lblUnitPrice"
        '
        'txtUnitsOnOrder
        '
        resources.ApplyResources(Me.txtUnitsOnOrder, "txtUnitsOnOrder")
        Me.txtUnitsOnOrder.Name = "txtUnitsOnOrder"
        '
        'lblUnitsOnOrder
        '
        resources.ApplyResources(Me.lblUnitsOnOrder, "lblUnitsOnOrder")
        Me.lblUnitsOnOrder.ForeColor = System.Drawing.Color.Black
        Me.lblUnitsOnOrder.Name = "lblUnitsOnOrder"
        '
        'calcOrdered
        '
        Me.calcOrdered.BackColor = System.Drawing.Color.Black
        Me.calcOrdered.ForeColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.calcOrdered, "calcOrdered")
        Me.calcOrdered.Name = "calcOrdered"
        Me.calcOrdered.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.White
        Me.cmbCategory.DataSource = Me.CategoriesBindingSource
        Me.cmbCategory.DisplayMember = "CategoryName"
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        resources.ApplyResources(Me.cmbCategory, "cmbCategory")
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.ValueMember = "CategoryID"
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.StockDataSetBindingSource
        '
        'txtUnitsInStock
        '
        resources.ApplyResources(Me.txtUnitsInStock, "txtUnitsInStock")
        Me.txtUnitsInStock.Name = "txtUnitsInStock"
        Me.txtUnitsInStock.Tag = ""
        '
        'txtDateOrdered
        '
        resources.ApplyResources(Me.txtDateOrdered, "txtDateOrdered")
        Me.txtDateOrdered.Name = "txtDateOrdered"
        '
        'txtSupplier
        '
        resources.ApplyResources(Me.txtSupplier, "txtSupplier")
        Me.txtSupplier.Name = "txtSupplier"
        '
        'lblUnitsInStock
        '
        resources.ApplyResources(Me.lblUnitsInStock, "lblUnitsInStock")
        Me.lblUnitsInStock.ForeColor = System.Drawing.Color.Black
        Me.lblUnitsInStock.Name = "lblUnitsInStock"
        '
        'lblSupplier
        '
        resources.ApplyResources(Me.lblSupplier, "lblSupplier")
        Me.lblSupplier.ForeColor = System.Drawing.Color.Black
        Me.lblSupplier.Name = "lblSupplier"
        '
        'lblDateOrdered
        '
        resources.ApplyResources(Me.lblDateOrdered, "lblDateOrdered")
        Me.lblDateOrdered.ForeColor = System.Drawing.Color.Black
        Me.lblDateOrdered.Name = "lblDateOrdered"
        '
        'txtProductDescription
        '
        resources.ApplyResources(Me.txtProductDescription, "txtProductDescription")
        Me.txtProductDescription.Name = "txtProductDescription"
        '
        'lblProductDescription
        '
        resources.ApplyResources(Me.lblProductDescription, "lblProductDescription")
        Me.lblProductDescription.ForeColor = System.Drawing.Color.Black
        Me.lblProductDescription.Name = "lblProductDescription"
        '
        'lblCategory
        '
        resources.ApplyResources(Me.lblCategory, "lblCategory")
        Me.lblCategory.ForeColor = System.Drawing.Color.Black
        Me.lblCategory.Name = "lblCategory"
        '
        'txtProductName
        '
        resources.ApplyResources(Me.txtProductName, "txtProductName")
        Me.txtProductName.Name = "txtProductName"
        '
        'lblProductName
        '
        resources.ApplyResources(Me.lblProductName, "lblProductName")
        Me.lblProductName.ForeColor = System.Drawing.Color.Black
        Me.lblProductName.Name = "lblProductName"
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
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'frmProducts
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.GroupBoxAdd)
        Me.Controls.Add(Me.ProductList)
        Me.Name = "frmProducts"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ProductList.ResumeLayout(False)
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAdd.ResumeLayout(False)
        Me.GroupBoxComps.ResumeLayout(False)
        Me.GroupBoxComps.PerformLayout()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StockDataSet As InventorManagement.stockDataSet
    Friend WithEvents ProductList As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxAdd As System.Windows.Forms.GroupBox
    Friend WithEvents ProductsTableAdapter As InventorManagement.stockDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lbProduct As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriesTableAdapter As InventorManagement.stockDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents GroupBoxComps As System.Windows.Forms.GroupBox
    Friend WithEvents txtUnitsOnOrder As System.Windows.Forms.TextBox
    Friend WithEvents lblUnitsOnOrder As System.Windows.Forms.Label
    Friend WithEvents calcOrdered As System.Windows.Forms.MonthCalendar
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtUnitsInStock As System.Windows.Forms.TextBox
    Friend WithEvents txtDateOrdered As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents lblUnitsInStock As System.Windows.Forms.Label
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents lblDateOrdered As System.Windows.Forms.Label
    Friend WithEvents txtProductDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblProductDescription As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblReOrde As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblUnitPrice As System.Windows.Forms.Label
End Class
