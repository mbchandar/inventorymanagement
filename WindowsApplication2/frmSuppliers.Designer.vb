<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuppliers))
        Me.SupplierList = New System.Windows.Forms.GroupBox
        Me.lbSupplier = New System.Windows.Forms.ListBox
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet = New InventorManagement.stockDataSet
        Me.GroupBoxAdd = New System.Windows.Forms.GroupBox
        Me.GroupBoxComps = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblPaymentTerms = New System.Windows.Forms.Label
        Me.txtFaxNumber = New System.Windows.Forms.TextBox
        Me.lblFaxNumber = New System.Windows.Forms.Label
        Me.txtContactName = New System.Windows.Forms.TextBox
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox
        Me.lblPhoneNumber = New System.Windows.Forms.Label
        Me.lblContactName = New System.Windows.Forms.Label
        Me.txtSupplierAddress = New System.Windows.Forms.TextBox
        Me.lblSupplierAddress = New System.Windows.Forms.Label
        Me.txtSupplierName = New System.Windows.Forms.TextBox
        Me.lblSupplierName = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New InventorManagement.stockDataSetTableAdapters.SuppliersTableAdapter
        Me.CategoriesTableAdapter = New InventorManagement.stockDataSetTableAdapters.CategoriesTableAdapter
        Me.SupplierList.SuspendLayout()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAdd.SuspendLayout()
        Me.GroupBoxComps.SuspendLayout()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupplierList
        '
        Me.SupplierList.BackColor = System.Drawing.Color.Transparent
        Me.SupplierList.Controls.Add(Me.lbSupplier)
        resources.ApplyResources(Me.SupplierList, "SupplierList")
        Me.SupplierList.ForeColor = System.Drawing.Color.Black
        Me.SupplierList.Name = "SupplierList"
        Me.SupplierList.TabStop = False
        '
        'lbSupplier
        '
        Me.lbSupplier.BackColor = System.Drawing.Color.White
        Me.lbSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSupplier.DataSource = Me.SuppliersBindingSource
        Me.lbSupplier.DisplayMember = "Name"
        resources.ApplyResources(Me.lbSupplier, "lbSupplier")
        Me.lbSupplier.FormatString = "Bala"
        Me.lbSupplier.FormattingEnabled = True
        Me.lbSupplier.Name = "lbSupplier"
        Me.lbSupplier.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbSupplier.ValueMember = "SupplierID"
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.StockDataSetBindingSource
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
        Me.GroupBoxComps.Controls.Add(Me.ComboBox1)
        Me.GroupBoxComps.Controls.Add(Me.txtEmail)
        Me.GroupBoxComps.Controls.Add(Me.lblEmail)
        Me.GroupBoxComps.Controls.Add(Me.lblPaymentTerms)
        Me.GroupBoxComps.Controls.Add(Me.txtFaxNumber)
        Me.GroupBoxComps.Controls.Add(Me.lblFaxNumber)
        Me.GroupBoxComps.Controls.Add(Me.txtContactName)
        Me.GroupBoxComps.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBoxComps.Controls.Add(Me.lblPhoneNumber)
        Me.GroupBoxComps.Controls.Add(Me.lblContactName)
        Me.GroupBoxComps.Controls.Add(Me.txtSupplierAddress)
        Me.GroupBoxComps.Controls.Add(Me.lblSupplierAddress)
        Me.GroupBoxComps.Controls.Add(Me.txtSupplierName)
        Me.GroupBoxComps.Controls.Add(Me.lblSupplierName)
        Me.GroupBoxComps.Name = "GroupBoxComps"
        Me.GroupBoxComps.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1"), resources.GetString("ComboBox1.Items2"), resources.GetString("ComboBox1.Items3")})
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        '
        'txtEmail
        '
        resources.ApplyResources(Me.txtEmail, "txtEmail")
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Tag = ""
        '
        'lblEmail
        '
        resources.ApplyResources(Me.lblEmail, "lblEmail")
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Name = "lblEmail"
        '
        'lblPaymentTerms
        '
        resources.ApplyResources(Me.lblPaymentTerms, "lblPaymentTerms")
        Me.lblPaymentTerms.ForeColor = System.Drawing.Color.Black
        Me.lblPaymentTerms.Name = "lblPaymentTerms"
        '
        'txtFaxNumber
        '
        resources.ApplyResources(Me.txtFaxNumber, "txtFaxNumber")
        Me.txtFaxNumber.Name = "txtFaxNumber"
        '
        'lblFaxNumber
        '
        resources.ApplyResources(Me.lblFaxNumber, "lblFaxNumber")
        Me.lblFaxNumber.ForeColor = System.Drawing.Color.Black
        Me.lblFaxNumber.Name = "lblFaxNumber"
        '
        'txtContactName
        '
        resources.ApplyResources(Me.txtContactName, "txtContactName")
        Me.txtContactName.Name = "txtContactName"
        '
        'txtPhoneNumber
        '
        resources.ApplyResources(Me.txtPhoneNumber, "txtPhoneNumber")
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        '
        'lblPhoneNumber
        '
        resources.ApplyResources(Me.lblPhoneNumber, "lblPhoneNumber")
        Me.lblPhoneNumber.ForeColor = System.Drawing.Color.Black
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        '
        'lblContactName
        '
        resources.ApplyResources(Me.lblContactName, "lblContactName")
        Me.lblContactName.ForeColor = System.Drawing.Color.Black
        Me.lblContactName.Name = "lblContactName"
        '
        'txtSupplierAddress
        '
        resources.ApplyResources(Me.txtSupplierAddress, "txtSupplierAddress")
        Me.txtSupplierAddress.Name = "txtSupplierAddress"
        '
        'lblSupplierAddress
        '
        resources.ApplyResources(Me.lblSupplierAddress, "lblSupplierAddress")
        Me.lblSupplierAddress.ForeColor = System.Drawing.Color.Black
        Me.lblSupplierAddress.Name = "lblSupplierAddress"
        '
        'txtSupplierName
        '
        resources.ApplyResources(Me.txtSupplierName, "txtSupplierName")
        Me.txtSupplierName.Name = "txtSupplierName"
        '
        'lblSupplierName
        '
        resources.ApplyResources(Me.lblSupplierName, "lblSupplierName")
        Me.lblSupplierName.ForeColor = System.Drawing.Color.Black
        Me.lblSupplierName.Name = "lblSupplierName"
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
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.StockDataSetBindingSource
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'frmSuppliers
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.GroupBoxAdd)
        Me.Controls.Add(Me.SupplierList)
        Me.Name = "frmSuppliers"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SupplierList.ResumeLayout(False)
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAdd.ResumeLayout(False)
        Me.GroupBoxComps.ResumeLayout(False)
        Me.GroupBoxComps.PerformLayout()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StockDataSet As InventorManagement.stockDataSet
    Friend WithEvents SupplierList As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxAdd As System.Windows.Forms.GroupBox
    Friend WithEvents SuppliersTableAdapter As InventorManagement.stockDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lbSupplier As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriesTableAdapter As InventorManagement.stockDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents GroupBoxComps As System.Windows.Forms.GroupBox
    Friend WithEvents txtFaxNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblFaxNumber As System.Windows.Forms.Label
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblContactName As System.Windows.Forms.Label
    Friend WithEvents txtSupplierAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblSupplierAddress As System.Windows.Forms.Label
    Friend WithEvents txtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents lblSupplierName As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPaymentTerms As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
