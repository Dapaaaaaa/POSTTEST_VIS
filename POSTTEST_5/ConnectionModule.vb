Imports MySqlConnector
Module ConnectionModule
    Public ReadOnly ConnectionString As String =
    "server=localhost;
    port=3306;
    database=geturcoffe;
    user=root;
    password="

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module
