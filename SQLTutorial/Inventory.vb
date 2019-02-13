

Public Class Inventory
    Public SQL As New SQLControl

    Public Sub LoadGrid()
        SQL.ExecuteQuery("SELECT * FROM Products;")
        If SQL.HasException(True) Then Exit Sub

        dgvData.DataSource = SQL.DBDT

    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        LoadGrid()
    End Sub
End Class