Public Class DeleteUser

    Private SQL As New SQLControl

    Public Sub FetchUsers()
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

    Private Sub DeleteUsers()
        If MsgBox("Do you really want to DELETE this: ", MsgBoxStyle.YesNo, "Delete User") Then
            'Generate a mass delete 
            Dim c As Integer = 0
            Dim DeleteString As String = ""

            For Each i In lbUsers.CheckedItems
                SQL.AddParam("@users" & c, i)
                DeleteString += "DELETE FROM members WHERE username = @users" & c & ";"
                c += 1
            Next

            SQL.ExecuteQuery(DeleteString)
            If SQL.HasException(True) Then Exit Sub

            MsgBox("Selected user deleted successfully")
            FetchUsers()
        End If
    End Sub

    Private Sub DeleteUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If lbUsers.CheckedItems.Count > 0 Then DeleteUsers()
    End Sub
End Class