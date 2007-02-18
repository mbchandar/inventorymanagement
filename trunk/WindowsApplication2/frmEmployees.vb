Public Class frmEmployees
    Dim cId
    Dim rs As DataRow
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.txtEmployeeName.Enabled = True
        Me.txtSalary.Enabled = True
        Me.txtInfo.Enabled = True
        Me.txtDepartmentName.Enabled = True
        Me.txtDateHired.Enabled = True
        Me.txtOfficeLocation.Enabled = True

        Me.btnAdd.Enabled = False
        Me.btnSave.Enabled = True
        Me.btnCancel.Enabled = True

        Me.txtEmployeeName.Focus()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Trim(Me.txtEmployeeName.Text) = "" Then
            MsgBox("Please enter the Employee name")
            Return
        End If
        If Me.lbEmployee.SelectedValue Then
            cId = Me.lbEmployee.SelectedValue
        Else
            cId = 0
        End If
        Me.lbEmployee.SelectionMode = SelectionMode.None
        If Trim(Int(cId)) <> 0 Then
            Me.EmployeesTableAdapter.UpdateQuery(Me.txtDepartmentName.Text, Me.txtEmployeeName.Text, Me.txtInfo.Text, Me.txtDateHired.Text, Me.txtSalary.Text, Me.txtOfficeLocation.Text, cId)
            MsgBox("Successfully updated!")
        Else
            If Me.EmployeesTableAdapter.InsertQuery(Me.txtDepartmentName.Text, Me.txtEmployeeName.Text, Me.txtInfo.Text, Me.txtDateHired.Text, Me.txtSalary.Text, Me.txtOfficeLocation.Text, "Y") Then
                MsgBox("Successfully Added")
                Me.txtEmployeeName.Text = ""
            Else
                MsgBox("Error Adding")
                Return
            End If
        End If

        Me.EmployeesTableAdapter.Fill(Me.StockDataSet.Employees)
        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False

        Me.txtEmployeeName.Text = ""
        Me.txtInfo.Text = ""
        Me.txtDateHired.Text = ""
        Me.txtDepartmentName.Text = ""
        Me.txtOfficeLocation.Text = ""
        Me.txtSalary.Text = ""

        Me.txtEmployeeName.Enabled = False
        Me.txtSalary.Enabled = False
        Me.txtInfo.Enabled = False
        Me.txtDepartmentName.Enabled = False
        Me.txtDateHired.Enabled = False
        Me.txtOfficeLocation.Enabled = False

        Me.btnAdd.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False
        Me.btnAdd.Focus()

        Me.txtEmployeeName.Enabled = False
        Me.txtSalary.Enabled = False
        Me.txtInfo.Enabled = False
        Me.txtDepartmentName.Enabled = False
        Me.txtDateHired.Enabled = False
        Me.txtOfficeLocation.Enabled = False

        Me.lbEmployee.SelectionMode = SelectionMode.None
        Me.txtEmployeeName.Text = ""
        Me.txtInfo.Text = ""
        Me.txtDateHired.Text = ""
        Me.txtDepartmentName.Text = ""
        Me.txtOfficeLocation.Text = ""
        Me.txtSalary.Text = ""

    End Sub
    Private Sub lbEmployee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbEmployee.Click
        Me.lbEmployee.SelectionMode = SelectionMode.One
        cId = Me.lbEmployee.SelectedValue

        If Trim(Int(cId)) <> 0 Then
            rs = Me.StockDataSet.Employees.FindByEmployeeID(Int(cId))
            Me.txtDepartmentName.Text = rs("DepartmentName")
            Me.txtEmployeeName.Text = rs("Name")
            Me.txtOfficeLocation.Text = rs("OfficeLocation")
            Me.txtInfo.Text = rs("Info")
            Me.txtSalary.Text = rs("Salary")
            Me.txtDateHired.Text = rs("DateHired")
        End If
        Me.btnSave.Enabled = True
        Me.btnAdd.Enabled = False
        Me.btnDelete.Enabled = True
        Me.btnCancel.Enabled = True

        Me.txtSalary.Enabled = True
        Me.txtInfo.Enabled = True
        Me.txtDepartmentName.Enabled = True
        Me.txtDateHired.Enabled = True
        Me.txtOfficeLocation.Enabled = True
        Me.txtEmployeeName.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cId = Me.lbEmployee.SelectedValue
        If Trim(Int(cId)) <> 0 Then
            Me.EmployeesTableAdapter.DeleteQuery(cId)
        End If

        Me.lbEmployee.SelectionMode = SelectionMode.None
        Me.EmployeesTableAdapter.Fill(Me.StockDataSet.Employees)

        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False

        Me.txtEmployeeName.Enabled = False
        Me.txtSalary.Enabled = False
        Me.txtInfo.Enabled = False
        Me.txtDepartmentName.Enabled = False
        Me.txtDateHired.Enabled = False
        Me.txtOfficeLocation.Enabled = False

        Me.txtEmployeeName.Text = ""
        Me.txtInfo.Text = ""
        Me.txtDateHired.Text = ""
        Me.txtDepartmentName.Text = ""
        Me.txtOfficeLocation.Text = ""
        Me.txtSalary.Text = ""

        Me.btnAdd.Focus()
    End Sub

    Private Sub frmEmployees_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.lbEmployee.SelectionMode = SelectionMode.One
    End Sub

    Private Sub frmEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.StockDataSet.Employees)

        Me.txtEmployeeName.Enabled = False
        Me.txtSalary.Enabled = False
        Me.txtInfo.Enabled = False
        Me.txtDepartmentName.Enabled = False
        Me.txtDateHired.Enabled = False
        Me.txtOfficeLocation.Enabled = False

        Me.btnSave.Enabled = False
        Me.btnCancel.Enabled = False
        Me.btnDelete.Enabled = False

        Me.lbEmployee.SelectionMode = SelectionMode.None

        Me.btnAdd.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.lbEmployee.SelectionMode = SelectionMode.One
        If MsgBox("Are you sure want to close?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub txtDateHired_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateHired.GotFocus
        Me.calcHired.Show()
    End Sub

    Private Sub calcHired_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calcHired.DateSelected
        Me.txtDateHired.Text = Me.calcHired.SelectionRange.Start
        Me.calcHired.Hide()
    End Sub

    Private Sub txtDateHired_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateHired.LostFocus
        Me.calcHired.Hide()
    End Sub

    
End Class