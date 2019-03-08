Public Class EditUser

    Private SQL As New SQLControl

    Private Sub FetchUsers()
        'Refresh User list
        lbUsers.Items.Clear()

        'Add params and run
        SQL.AddParam("@users", "%" & txtFilter.Text & "%")
        SQL.ExecuteQuery("SELECT username FROM members WHERE username LIKE @users ORDER BY username ")

        'Report and abort error
        If SQL.HasException(True) Then Exit Sub

        'Loop rows and return to user
        For Each r As DataRow In SQL.DBDT.Rows
            lbUsers.Items.Add(r("username"))
        Next
    End Sub

    Private Sub GetUserDetails(username As String)
        SQL.AddParam("@user", username)
        SQL.ExecuteQuery("SELECT * FROM members WHERE username = @user")
        If SQL.RecordCount < 1 Then Exit Sub

        For Each r As DataRow In SQL.DBDT.Rows
            txtID.Text = r("ID")
            txtUser.Text = r("username")
            txtPass.Text = r("password")
            cbActive.Checked = r("active")
            cbAdmin.Checked = r("admin")
        Next

    End Sub

    Private Sub UpdateUser()
        SQL.AddParam("@pass", txtPass.Text)
        SQL.AddParam("@active", cbActive.Checked)
        SQL.AddParam("@admin", cbActive.Checked)
        SQL.AddParam("@id", txtID.Text)

        SQL.ExecuteQuery("UPDATE members SET password=@pass, active=@active, admin=@admin WHERE ID=@id")

        If SQL.HasException(True) Then Exit Sub
        MsgBox("User Updated successfully")
        cmdSubmit.Enabled = False
    End Sub

    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        FetchUsers()
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            FetchUsers()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub lbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbUsers.SelectedIndexChanged
        GetUserDetails(lbUsers.Text)
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        UpdateUser()
    End Sub
End Class