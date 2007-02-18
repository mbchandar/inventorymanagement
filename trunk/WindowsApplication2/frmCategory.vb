Public Class frmCategories
    Dim cId
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.txtCategoryName.Enabled = True
        Me.btnAdd.Enabled = False
        Me.btnSave.Enabled = True
        Me.btnCancel.Enabled = True
        Me.txtCategoryName.Focus()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Trim(Me.txtCategoryName.Text) = "" Then
            MsgBox("Please enter the category name")
            Return
        End If
        If Me.lbCategory.SelectedValue Then
            cId = Me.lbCategory.SelectedValue
        Else
            cId = 0
        End If
        Me.lbCategory.SelectionMode = SelectionMode.None
        If Trim(Int(cId)) <> 0 Then
            Me.CategoriesTableAdapter.UpdateQuery(Me.txtCategoryName.Text, cId)
            MsgBox("Successfully updated!")
        Else
            If Me.CategoriesTableAdapter.InsertQuery(Me.txtCategoryName.Text, "Y") Then
                MsgBox("Successfully Added")
                Me.txtCategoryName.Text = ""
            Else
                MsgBox("Error Adding")
                Return
            End If
        End If
        Me.CategoriesTableAdapter.Fill(Me.StockDataSet.Categories)
        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False
        Me.txtCategoryName.Text = ""
        Me.txtCategoryName.Enabled = False
        Me.btnAdd.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.btnDelete.Enabled = False
        Me.txtCategoryName.Enabled = False
        Me.lbCategory.SelectionMode = SelectionMode.None
        Me.txtCategoryName.Text = ""
    End Sub
    Private Sub lbCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbCategory.Click
        Me.lbCategory.SelectionMode = SelectionMode.One
        cId = Me.lbCategory.SelectedValue
        If Trim(Int(cId)) <> 0 Then
            Me.txtCategoryName.Text = Me.CategoriesTableAdapter.getByCategoryID(Int(cId))
        End If
        Me.btnSave.Enabled = True
        Me.btnAdd.Enabled = False
        Me.btnDelete.Enabled = True
        Me.txtCategoryName.Enabled = False
        Me.btnCancel.Enabled = True
        Me.txtCategoryName.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim cId = Me.lbCategory.SelectedValue
        If Trim(Int(cId)) <> 0 Then
            Me.CategoriesTableAdapter.DeleteQuery("N", cId)
        End If
        Me.lbCategory.SelectionMode = SelectionMode.None
        Me.CategoriesTableAdapter.Fill(Me.StockDataSet.Categories)
        Me.btnAdd.Enabled = True
        Me.btnSave.Enabled = False
        Me.txtCategoryName.Enabled = False
        Me.btnDelete.Enabled = False
        Me.txtCategoryName.Text = ""
        Me.btnAdd.Focus()
    End Sub

    Private Sub frmCategories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.lbCategory.SelectionMode = SelectionMode.One
    End Sub

    Private Sub frmCategories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.StockDataSet.Categories)
        Me.btnDelete.Enabled = False
        Me.txtCategoryName.Enabled = False
        Me.btnSave.Enabled = False
        Me.btnCancel.Enabled = False
        Me.lbCategory.SelectionMode = SelectionMode.None
        Me.btnAdd.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.lbCategory.SelectionMode = SelectionMode.One
        If MsgBox("Are you sure want to close?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class