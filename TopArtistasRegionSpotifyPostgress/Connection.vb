Imports Npgsql
Public Class Connection
    Shared cnx As New NpgsqlConnection

    Private Shared Sub Connect()
        Try
            cnx.ConnectionString = "Host=localhost;Database=topartistasregion;Username=Hector2;Password=admin"
            cnx.Open()
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub

    Private Shared Sub Disconnect()
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al desconectar de la base de datos: " & ex.Message)
        End Try
    End Sub

    ' Método para ejecutar una consulta de selección
    Public Shared Function SelectQuery(ByVal query As String) As DataTable
        Dim dt As New DataTable
        Try
            Connect()
            Dim cmd As New NpgsqlCommand(query, cnx)
            Dim da As New NpgsqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message)
        Finally
            Disconnect()
        End Try
        Return dt
    End Function
End Class
