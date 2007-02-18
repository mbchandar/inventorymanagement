Public Class frmProducts
    Dim cId
    Dim rs As DataRow
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.GroupBoxComps.Enabled = True

        Me.btnAdd.Enabled = False
        Me.btnSave.Enabled = True
        Me.btnCancel.Enabled = True

        Me.txtProductName.Focus()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Trim(Me.txtProductName.Text) = "" Then
            MsgBox("Please enter the Product name")
            Return
        End If
        If Me.lbProduct.SelectedValue Then
            cId = Me.lbProduct.SelectedValue
        Else
            cId = 0
        End If
        Me.lbProduct.SelectionMode = SelectionMode.None
        If Trim(Int(cId)) <> 0 Then
            'Me.ProductsTableAdapter.UpdateQuery(Me.txtDepartmentName.Text, Me.txtProductName.Text, Me.txtInfo.Text, Me.txtDateHired.Text, Me.txtSalary.Text, Me.txtOfficeLocation.Text, cId)
            MsgBox("Successfully updated!")
        Else
            If Me.ProductsTableAdapter.InsertQuery(Me.txtProductName.Text, Me.txtProductDescription.Text, Me.txtDateOrdered.Text, Me.txtSupplier.Text, "", Me.txtUnitsInStock.Text, Me.txtUnitsOnOrder.Text, "", "", "", "", "Y") Then
                MsgBox("Successfully Added")
            Else
                MsgBox("Error Adding")
                Return
            End If
        End If

        Me.ProductsTableAdapter.Fill(Me.StockDataSet.Products)
        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False

        Me.txtProductName.Text = ""
        Me.txtProductDescription.Text = ""
        Me.txtDateOrdered.Text = ""
        Me.txtUnitsInStock.Text = ""
        Me.txtSupplier.Text = ""
        Me.txtUnitsOnOrder.Text = ""

        Me.GroupBoxComps.Enabled = False

        Me.btnAdd.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False
        Me.btnAdd.Focus()

        Me.GroupBoxComps.Enabled = False

        Me.lbProduct.SelectionMode = SelectionMode.None
        Me.txtProductName.Text = ""
        Me.txtProductDescription.Text = ""
        Me.txtDateOrdered.Text = ""
        Me.txtUnitsInStock.Text = ""
        Me.txtSupplier.Text = ""
        Me.txtUnitsOnOrder.Text = ""

    End Sub
    Private Sub lbProduct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbProduct.Click
        Me.lbProduct.SelectionMode = SelectionMode.One
        cId = Me.lbProduct.SelectedValue

        If Trim(Int(cId)) <> 0 Then
            rs = Me.StockDataSet.Products.FindByProductID(Int(cId))
            Me.txtProductName.Text = rs("Name")
            Me.txtUnitsInStock.Text = rs("OfficeLocation")
            Me.txtProductDescription.Text = rs("Info")
            Me.txtSupplier.Text = rs("Salary")
            Me.txtDateOrdered.Text = rs("DateHired")
        End If
        Me.btnSave.Enabled = True
        Me.btnAdd.Enabled = False
        Me.btnDelete.Enabled = True
        Me.btnCancel.Enabled = True

        Me.txtSupplier.Enabled = True
        Me.txtProductDescription.Enabled = True

        Me.txtDateOrdered.Enabled = True
        Me.txtUnitsInStock.Enabled = True
        Me.txtProductName.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cId = Me.lbProduct.SelectedValue
        If Trim(Int(cId)) <> 0 Then
            'Me.ProductsTableAdapter.DeleteQuery(cId)
        End If

        Me.lbProduct.SelectionMode = SelectionMode.None
        Me.ProductsTableAdapter.Fill(Me.StockDataSet.Products)

        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False

        Me.txtProductName.Enabled = False
        Me.txtSupplier.Enabled = False
        Me.txtProductDescription.Enabled = False

        Me.txtDateOrdered.Enabled = False
        Me.txtUnitsInStock.Enabled = False

        Me.txtProductName.Text = ""
        Me.txtProductDescription.Text = ""
        Me.txtDateOrdered.Text = ""
        Me.txtUnitsInStock.Text = ""
        Me.txtSupplier.Text = ""
        Me.txtUnitsOnOrder.Text = ""

        Me.btnAdd.Focus()
    End Sub

    Private Sub frmProducts_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.lbProduct.SelectionMode = SelectionMode.One
    End Sub

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.StockDataSet.Categories)
        'TODO: This line of code loads data into the 'StockDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.StockDataSet.Products)
        Me.GroupBoxComps.Enabled = False
        
        Me.btnSave.Enabled = False
        Me.btnCancel.Enabled = False
        Me.btnDelete.Enabled = False

        Me.lbProduct.SelectionMode = SelectionMode.None

        Me.btnAdd.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.lbProduct.SelectionMode = SelectionMode.One
        If MsgBox("Are you sure want to close?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    

    Private Sub txtDateOrdered_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateOrdered.GotFocus
        Me.calcOrdered.Show()
    End Sub
    Private Sub calcOrdered_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calcOrdered.DateSelected
        Me.txtDateOrdered.Text = Me.calcOrdered.SelectionRange.Start
        Me.calcOrdered.Hide()
        Me.cmbCategory.Focus()
    End Sub

    Private Sub txtDateOrdered_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDateOrdered.LostFocus
        Me.calcOrdered.Hide()
    End Sub


End Class