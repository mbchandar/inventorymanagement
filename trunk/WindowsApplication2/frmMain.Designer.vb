<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCategories = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEmployees = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSuppliers = New System.Windows.Forms.ToolStripMenuItem
        Me.WareHousesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AlertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ByEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ByProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StockReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CurrentInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CurrentInventoryBrokenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WarehousesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrinterSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LocalSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CurrencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegisterProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.calcDashboard = New System.Windows.Forms.MonthCalendar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SystemToolStripMenuItem, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(797, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCategories, Me.mnuEmployees, Me.mnuProducts, Me.mnuSuppliers, Me.WareHousesToolStripMenuItem1, Me.AlertToolStripMenuItem, Me.ToolStripSeparator3, Me.mnuExit})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.MenuToolStripMenuItem.Text = "&Master"
        '
        'mnuCategories
        '
        Me.mnuCategories.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuCategories.Name = "mnuCategories"
        Me.mnuCategories.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCategories.Size = New System.Drawing.Size(217, 22)
        Me.mnuCategories.Text = "&Categories"
        '
        'mnuEmployees
        '
        Me.mnuEmployees.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuEmployees.Name = "mnuEmployees"
        Me.mnuEmployees.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuEmployees.Size = New System.Drawing.Size(217, 22)
        Me.mnuEmployees.Text = "&Employees"
        '
        'mnuProducts
        '
        Me.mnuProducts.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuProducts.Name = "mnuProducts"
        Me.mnuProducts.Size = New System.Drawing.Size(217, 22)
        Me.mnuProducts.Text = "&Products"
        '
        'mnuSuppliers
        '
        Me.mnuSuppliers.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSuppliers.Name = "mnuSuppliers"
        Me.mnuSuppliers.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSuppliers.Size = New System.Drawing.Size(217, 22)
        Me.mnuSuppliers.Text = "&Suppliers"
        '
        'WareHousesToolStripMenuItem1
        '
        Me.WareHousesToolStripMenuItem1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WareHousesToolStripMenuItem1.Name = "WareHousesToolStripMenuItem1"
        Me.WareHousesToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.WareHousesToolStripMenuItem1.Text = "&WareHouses"
        '
        'AlertToolStripMenuItem
        '
        Me.AlertToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertToolStripMenuItem.Name = "AlertToolStripMenuItem"
        Me.AlertToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.AlertToolStripMenuItem.Text = "&Alert"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(214, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(217, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.StockReportToolStripMenuItem, Me.ToolStripSeparator1, Me.OrdersToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByEmployeeToolStripMenuItem, Me.ByToolStripMenuItem, Me.ByProductsToolStripMenuItem})
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SalesToolStripMenuItem.Text = "Sales Report"
        '
        'ByEmployeeToolStripMenuItem
        '
        Me.ByEmployeeToolStripMenuItem.Name = "ByEmployeeToolStripMenuItem"
        Me.ByEmployeeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ByEmployeeToolStripMenuItem.Text = "By Employee"
        '
        'ByToolStripMenuItem
        '
        Me.ByToolStripMenuItem.Name = "ByToolStripMenuItem"
        Me.ByToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ByToolStripMenuItem.Text = "By Categories"
        '
        'ByProductsToolStripMenuItem
        '
        Me.ByProductsToolStripMenuItem.Name = "ByProductsToolStripMenuItem"
        Me.ByProductsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ByProductsToolStripMenuItem.Text = "By Products"
        '
        'StockReportToolStripMenuItem
        '
        Me.StockReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentInventoryToolStripMenuItem, Me.CurrentInventoryBrokenToolStripMenuItem, Me.WarehousesToolStripMenuItem})
        Me.StockReportToolStripMenuItem.Name = "StockReportToolStripMenuItem"
        Me.StockReportToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.StockReportToolStripMenuItem.Text = "Stock"
        '
        'CurrentInventoryToolStripMenuItem
        '
        Me.CurrentInventoryToolStripMenuItem.Name = "CurrentInventoryToolStripMenuItem"
        Me.CurrentInventoryToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.CurrentInventoryToolStripMenuItem.Text = "Current Inventory"
        '
        'CurrentInventoryBrokenToolStripMenuItem
        '
        Me.CurrentInventoryBrokenToolStripMenuItem.Name = "CurrentInventoryBrokenToolStripMenuItem"
        Me.CurrentInventoryBrokenToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.CurrentInventoryBrokenToolStripMenuItem.Text = "Current Inventory Broken"
        '
        'WarehousesToolStripMenuItem
        '
        Me.WarehousesToolStripMenuItem.Name = "WarehousesToolStripMenuItem"
        Me.WarehousesToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.WarehousesToolStripMenuItem.Text = "Warehouses"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(150, 6)
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.OrdersToolStripMenuItem.Text = "Today's Sales"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrinterSettingsToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.LocalSettingsToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.CurrencyToolStripMenuItem})
        Me.SystemToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.SystemToolStripMenuItem.Text = "&System"
        '
        'PrinterSettingsToolStripMenuItem
        '
        Me.PrinterSettingsToolStripMenuItem.Name = "PrinterSettingsToolStripMenuItem"
        Me.PrinterSettingsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PrinterSettingsToolStripMenuItem.Text = "Printer Settings"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LocalSettingsToolStripMenuItem
        '
        Me.LocalSettingsToolStripMenuItem.Name = "LocalSettingsToolStripMenuItem"
        Me.LocalSettingsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LocalSettingsToolStripMenuItem.Text = "Local Settings"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'CurrencyToolStripMenuItem
        '
        Me.CurrencyToolStripMenuItem.Name = "CurrencyToolStripMenuItem"
        Me.CurrencyToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CurrencyToolStripMenuItem.Text = "Currency"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.RegisterProductToolStripMenuItem, Me.ToolStripSeparator2, Me.mnuAbout})
        Me.HelpMenu.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(396, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'RegisterProductToolStripMenuItem
        '
        Me.RegisterProductToolStripMenuItem.Name = "RegisterProductToolStripMenuItem"
        Me.RegisterProductToolStripMenuItem.Size = New System.Drawing.Size(396, 22)
        Me.RegisterProductToolStripMenuItem.Text = "Register Product"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(393, 6)
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(318, 22)
        Me.mnuAbout.Text = "&About Inventory Management 2007 Edition"
        '
        'calcDashboard
        '
        Me.calcDashboard.BackColor = System.Drawing.Color.Black
        Me.calcDashboard.ForeColor = System.Drawing.Color.Silver
        Me.calcDashboard.Location = New System.Drawing.Point(601, 38)
        Me.calcDashboard.Name = "calcDashboard"
        Me.calcDashboard.TabIndex = 13
        Me.calcDashboard.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.calcDashboard.TitleForeColor = System.Drawing.Color.White
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 213)
        Me.Panel1.TabIndex = 14
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 477)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.calcDashboard)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCategories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProducts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSuppliers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WareHousesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentInventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentInventoryBrokenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WarehousesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuEmployees As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrinterSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrencyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents calcDashboard As System.Windows.Forms.MonthCalendar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel


End Class
