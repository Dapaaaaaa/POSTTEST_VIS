Imports MySqlConnector

Module ConnectionModule
    Public ReadOnly ConnectionString As String =
    "Server=localhost;Port=3306;Database=Data_Perpustakaan;UserID=root;Password=;"
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module
