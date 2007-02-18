Public Class frmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim frmMain As New frmMain
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If MsgBox("Are you sure to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        Else
            Me.txtUsername.Focus()
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtUsername.Focus()
    End Sub

End Class
