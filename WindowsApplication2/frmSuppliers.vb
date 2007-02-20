Public Class frmSuppliers
    Dim cId
    Dim rs As DataRow
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.GroupBoxComps.Enabled = True

        Me.btnAdd.Enabled = False
        Me.btnSave.Enabled = True
        Me.btnCancel.Enabled = True

        Me.txtSupplierName.Focus()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Trim(Me.txtSupplierName.Text) = "" Then
            MsgBox("Please enter the Supplier name")
            Return
        End If
        If Me.lbSupplier.SelectedValue Then
            cId = Me.lbSupplier.SelectedValue
        Else
            cId = 0
        End If
        Me.lbSupplier.SelectionMode = SelectionMode.None
        If Trim(Int(cId)) <> 0 Then
            Me.SuppliersTableAdapter.UpdateQuery(Me.txtSupplierName.Text, Me.txtContactName.Text, Me.txtSupplierAddress.Text, Me.txtPhoneNumber.Text, Me.txtFaxNumber.Text, Me.ComboBox1.SelectedItem, Me.txtEmail.Text, cId)
            MsgBox("Successfully updated!")
        Else
            If Me.SuppliersTableAdapter.InsertQuery(Me.txtSupplierName.Text, Me.txtContactName.Text, Me.txtSupplierAddress.Text, Me.txtPhoneNumber.Text, Me.txtFaxNumber.Text, Me.ComboBox1.SelectedItem, Me.txtEmail.Text, "Y") Then
                MsgBox("Successfully Added")
            Else
                MsgBox("Error Adding")
                Return
            End If
        End If

        Me.SuppliersTableAdapter.Fill(Me.StockDataSet.Suppliers)
        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False

        Me.txtSupplierName.Text = ""
        Me.txtSupplierAddress.Text = ""
        Me.txtContactName.Text = ""
        Me.txtPhoneNumber.Text = ""
        Me.txtFaxNumber.Text = ""
        Me.txtEmail.Text = ""

        Me.GroupBoxComps.Enabled = False

        Me.btnAdd.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False
        Me.btnAdd.Focus()

        Me.GroupBoxComps.Enabled = False
        Me.lbSupplier.SelectionMode = SelectionMode.None

        Me.txtSupplierName.Text = ""
        Me.txtSupplierAddress.Text = ""
        Me.txtContactName.Text = ""
        Me.txtPhoneNumber.Text = ""
        Me.txtFaxNumber.Text = ""
        Me.txtEmail.Text = ""


    End Sub
    Private Sub lbSupplier_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbSupplier.Click
        Me.lbSupplier.SelectionMode = SelectionMode.One
        cId = Me.lbSupplier.SelectedValue

        If Trim(Int(cId)) <> 0 Then
            rs = Me.StockDataSet.Suppliers.FindBySupplierID(Int(cId))
            Me.txtSupplierName.Text = rs("SupplierName")
            Me.txtSupplierAddress.Text = rs("Address")
            Me.txtPhoneNumber.Text = rs("PhoneNumber")
            Me.txtContactName.Text = rs("ContactName")
            Me.ComboBox1.Text = rs("PaymentTerms")
            Me.txtEmail.Text = rs("EmailAddress")
            Me.txtFaxNumber.Text = rs("FaxNumber")
        End If
        Me.btnSave.Enabled = True
        Me.btnAdd.Enabled = False
        Me.btnDelete.Enabled = True
        Me.btnCancel.Enabled = True

        Me.GroupBoxComps.Enabled = True

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cId = Me.lbSupplier.SelectedValue
        If Trim(Int(cId)) <> 0 Then
            'Me.SuppliersTableAdapter.DeleteQuery(cId)
        End If

        Me.lbSupplier.SelectionMode = SelectionMode.None
        Me.SuppliersTableAdapter.Fill(Me.StockDataSet.Suppliers)

        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False

        Me.txtSupplierName.Enabled = False
        Me.txtPhoneNumber.Enabled = False
        Me.txtSupplierAddress.Enabled = False

        Me.txtContactName.Enabled = False


        Me.txtSupplierName.Text = ""
        Me.txtSupplierAddress.Text = ""
        Me.txtContactName.Text = ""

        Me.txtPhoneNumber.Text = ""
        Me.txtFaxNumber.Text = ""

        Me.btnAdd.Focus()
    End Sub

    Private Sub frmSuppliers_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.lbSupplier.SelectionMode = SelectionMode.One
    End Sub

    Private Sub frmSuppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.StockDataSet.Categories)
        'TODO: This line of code loads data into the 'StockDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.StockDataSet.Suppliers)
        Me.GroupBoxComps.Enabled = False

        Me.btnSave.Enabled = False
        Me.btnCancel.Enabled = False
        Me.btnDelete.Enabled = False

        Me.lbSupplier.SelectionMode = SelectionMode.None

        Me.btnAdd.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.lbSupplier.SelectionMode = SelectionMode.One
        If MsgBox("Are you sure want to close?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class