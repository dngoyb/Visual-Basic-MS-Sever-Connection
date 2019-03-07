Imports System.Data.SqlClient

'Going to handle db connection and data set
Public Class SQLControl
    Private DBCon As New SqlConnection("Server = LOANLPT; Database = SQLTutorial;  User Id = sa; Password= $flexi14")
    Private DBCmd As SqlCommand

    'DB DATA
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    'Query parameters
    Public Params As New List(Of SqlParameter)

    'Query Statistic
    Public RecordCount As Integer
    Public Exception As String

    Public Sub New()
    End Sub

    'Allow Connection String Overrride
    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    'Execute Query SUb
    Public Sub ExecuteQuery(Query As String)
        'Reset Query Stats
        RecordCount = 0
        Exception = ""

        Try
            DBCon.Open()

            'Create DB Command
            DBCmd = New SqlCommand(Query, DBCon)

            'Load Params Into DB Command
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Clear Params List
            Params.Clear()

            'Execute the command and feel dataset
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)
        Catch ex As Exception

            'Captchure Error
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message

        Finally
            'Close Connection
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    'Add Params
    Public Sub AddParam(name As String, value As String)
        Dim NewParam As New SqlParameter(name, value)
        Params.Add(NewParam)
    End Sub

    'Error Checking
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception")
        Return True
    End Function


    'Error checker function
    Function CheckError() As Boolean
       If String.IsNullOrEmpty(Exception) Then
           Return False
       End If 
        MsgBox(Exception, MsgBoxStyle.Critical, "Exception")
       Return True
   End Function
End Class
