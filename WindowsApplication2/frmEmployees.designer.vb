<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployees))
        Me.EmployeeList = New System.Windows.Forms.GroupBox
        Me.lbEmployee = New System.Windows.Forms.ListBox
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet = New InventorManagement.stockDataSet
        Me.GroupBoxAdd = New System.Windows.Forms.GroupBox
        Me.txtOfficeLocation = New System.Windows.Forms.TextBox
        Me.txtDateHired = New System.Windows.Forms.TextBox
        Me.calcHired = New System.Windows.Forms.MonthCalendar
        Me.txtSalary = New System.Windows.Forms.TextBox
        Me.lblOfficeLocation = New System.Windows.Forms.Label
        Me.lblSalary = New System.Windows.Forms.Label
        Me.lblDatehired = New System.Windows.Forms.Label
        Me.txtInfo = New System.Windows.Forms.TextBox
        Me.lblInfo = New System.Windows.Forms.Label
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtDepartmentName = New System.Windows.Forms.TextBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtEmployeeName = New System.Windows.Forms.TextBox
        Me.lblEmployeeName = New System.Windows.Forms.Label
        Me.EmployeesTableAdapter = New InventorManagement.stockDataSetTableAdapters.EmployeesTableAdapter
        Me.EmployeeList.SuspendLayout()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeList
        '
        Me.EmployeeList.BackColor = System.Drawing.Color.Transparent
        Me.EmployeeList.Controls.Add(Me.lbEmployee)
        resources.ApplyResources(Me.EmployeeList, "EmployeeList")
        Me.EmployeeList.ForeColor = System.Drawing.Color.Black
        Me.EmployeeList.Name = "EmployeeList"
        Me.EmployeeList.TabStop = False
        '
        'lbEmployee
        '
        Me.lbEmployee.BackColor = System.Drawing.Color.White
        Me.lbEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbEmployee.DataSource = Me.EmployeesBindingSource
        Me.lbEmployee.DisplayMember = "Name"
        resources.ApplyResources(Me.lbEmployee, "lbEmployee")
        Me.lbEmployee.FormatString = "Bala"
        Me.lbEmployee.FormattingEnabled = True
        Me.lbEmployee.Name = "lbEmployee"
        Me.lbEmployee.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbEmployee.ValueMember = "EmployeeID"
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.StockDataSetBindingSource
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
        Me.GroupBoxAdd.Controls.Add(Me.txtOfficeLocation)
        Me.GroupBoxAdd.Controls.Add(Me.txtDateHired)
        Me.GroupBoxAdd.Controls.Add(Me.calcHired)
        Me.GroupBoxAdd.Controls.Add(Me.txtSalary)
        Me.GroupBoxAdd.Controls.Add(Me.lblOfficeLocation)
        Me.GroupBoxAdd.Controls.Add(Me.lblSalary)
        Me.GroupBoxAdd.Controls.Add(Me.lblDatehired)
        Me.GroupBoxAdd.Controls.Add(Me.txtInfo)
        Me.GroupBoxAdd.Controls.Add(Me.lblInfo)
        Me.GroupBoxAdd.Controls.Add(Me.lblDepartment)
        Me.GroupBoxAdd.Controls.Add(Me.btnDelete)
        Me.GroupBoxAdd.Controls.Add(Me.btnSave)
        Me.GroupBoxAdd.Controls.Add(Me.btnClose)
        Me.GroupBoxAdd.Controls.Add(Me.btnCancel)
        Me.GroupBoxAdd.Controls.Add(Me.txtDepartmentName)
        Me.GroupBoxAdd.Controls.Add(Me.btnAdd)
        Me.GroupBoxAdd.Controls.Add(Me.txtEmployeeName)
        Me.GroupBoxAdd.Controls.Add(Me.lblEmployeeName)
        resources.ApplyResources(Me.GroupBoxAdd, "GroupBoxAdd")
        Me.GroupBoxAdd.Name = "GroupBoxAdd"
        Me.GroupBoxAdd.TabStop = False
        '
        'txtOfficeLocation
        '
        resources.ApplyResources(Me.txtOfficeLocation, "txtOfficeLocation")
        Me.txtOfficeLocation.Name = "txtOfficeLocation"
        '
        'txtDateHired
        '
        resources.ApplyResources(Me.txtDateHired, "txtDateHired")
        Me.txtDateHired.Name = "txtDateHired"
        '
        'calcHired
        '
        Me.calcHired.BackColor = System.Drawing.Color.Black
        Me.calcHired.ForeColor = System.Drawing.Color.Silver
        resources.ApplyResources(Me.calcHired, "calcHired")
        Me.calcHired.Name = "calcHired"
        Me.calcHired.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'txtSalary
        '
        resources.ApplyResources(Me.txtSalary, "txtSalary")
        Me.txtSalary.Name = "txtSalary"
        '
        'lblOfficeLocation
        '
        resources.ApplyResources(Me.lblOfficeLocation, "lblOfficeLocation")
        Me.lblOfficeLocation.ForeColor = System.Drawing.Color.Black
        Me.lblOfficeLocation.Name = "lblOfficeLocation"
        '
        'lblSalary
        '
        resources.ApplyResources(Me.lblSalary, "lblSalary")
        Me.lblSalary.ForeColor = System.Drawing.Color.Black
        Me.lblSalary.Name = "lblSalary"
        '
        'lblDatehired
        '
        resources.ApplyResources(Me.lblDatehired, "lblDatehired")
        Me.lblDatehired.ForeColor = System.Drawing.Color.Black
        Me.lblDatehired.Name = "lblDatehired"
        '
        'txtInfo
        '
        resources.ApplyResources(Me.txtInfo, "txtInfo")
        Me.txtInfo.Name = "txtInfo"
        '
        'lblInfo
        '
        resources.ApplyResources(Me.lblInfo, "lblInfo")
        Me.lblInfo.ForeColor = System.Drawing.Color.Black
        Me.lblInfo.Name = "lblInfo"
        '
        'lblDepartment
        '
        resources.ApplyResources(Me.lblDepartment, "lblDepartment")
        Me.lblDepartment.ForeColor = System.Drawing.Color.Black
        Me.lblDepartment.Name = "lblDepartment"
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
        'txtDepartmentName
        '
        resources.ApplyResources(Me.txtDepartmentName, "txtDepartmentName")
        Me.txtDepartmentName.Name = "txtDepartmentName"
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtEmployeeName
        '
        resources.ApplyResources(Me.txtEmployeeName, "txtEmployeeName")
        Me.txtEmployeeName.Name = "txtEmployeeName"
        '
        'lblEmployeeName
        '
        resources.ApplyResources(Me.lblEmployeeName, "lblEmployeeName")
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeName.Name = "lblEmployeeName"
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'frmEmployees
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.GroupBoxAdd)
        Me.Controls.Add(Me.EmployeeList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmEmployees"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.EmployeeList.ResumeLayout(False)
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAdd.ResumeLayout(False)
        Me.GroupBoxAdd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StockDataSet As InventorManagement.stockDataSet
    Friend WithEvents EmployeeList As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxAdd As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents EmployeesTableAdapter As InventorManagement.stockDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lbEmployee As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtDepartmentName As System.Windows.Forms.TextBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents lblDatehired As System.Windows.Forms.Label
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents lblOfficeLocation As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtDateHired As System.Windows.Forms.TextBox
    Friend WithEvents calcHired As System.Windows.Forms.MonthCalendar
    Friend WithEvents txtOfficeLocation As System.Windows.Forms.TextBox
End Class
