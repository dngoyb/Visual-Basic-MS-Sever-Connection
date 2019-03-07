Public Class NewUser

    Private SQL As New SQLControl

    Private Sub NewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
    End Sub

    Private Sub InsertUser()
        ' Add SQL Params and Run the Command

        SQL.AddParam("@user", txtUser.Text)
        SQL.AddParam("@pass", txtPass.Text)
        SQL.AddParam("@active", cbActive.Checked)
        SQL.AddParam("@admin", cbAdmin.Checked)

        SQL.ExecuteQuery("INSERT INTO members (username, password, active, admin, joindate) VALUES (@user, @pass, @active, @admin, GETDATE());")

        'Report and Abort on error
        If SQL.HasException(True) Then Exit Sub

        MsgBox("User Created Successfully")
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        InsertUser()
        txtUser.Clear()
        txtPass.Clear()
        cbActive.Checked = False
        cbActive.Checked = False
    End Sub

    Private Sub txtField_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged, txtPass.TextChanged
        If Not String.IsNullOrWhiteSpace(txtUser.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPass.Text) Then
            cmdSubmit.Enabled = True
        End If
    End Sub
End Class