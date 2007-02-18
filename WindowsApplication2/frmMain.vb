Imports System.Windows.Forms

Public Class frmMain
    Private Sub mnuCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCategories.Click
        frmCategories.MdiParent = Me
        frmCategories.WindowState = FormWindowState.Maximized
        frmCategories.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        If MsgBox("Are you sure want to close?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("Good Bye!")
            Me.Close()
        End If
    End Sub

    Private Sub mnuEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEmployees.Click
        frmEmployees.MdiParent = Me
        frmEmployees.WindowState = FormWindowState.Maximized
        frmEmployees.Show()
    End Sub

    Private Sub mnuProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProducts.Click
        frmProducts.MdiParent = Me
        frmProducts.WindowState = FormWindowState.Maximized
        frmProducts.Show()
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        frmAboutBox.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCategories.MdiParent = Me
        frmCategories.WindowState = FormWindowState.Maximized
        frmCategories.Show()
    End Sub

    Private Sub RibbonGroup1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class
