Public Class EditUser

    Private SQL As New SQLControl

    Private Sub FetchUsers()
        'Refresh User list
        lbUsers.Items.Clear()

        'Add params and run
        SQL.AddParam("@users", "%" & txtFilter.Text & "%")
        SQL.ExecuteQuery("SELECT username FROM members WHERE username LIKE @users")

        'Report and abort error
        If SQL.HasException(True) Then Exit Sub

        'Loop rows and return to user
        For Each r As DataRow In SQL.DBDT.Rows
            lbUsers.Items.Add(r("username"))
        Next
    End Sub
    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        FetchUsers()
    End Sub
End Class