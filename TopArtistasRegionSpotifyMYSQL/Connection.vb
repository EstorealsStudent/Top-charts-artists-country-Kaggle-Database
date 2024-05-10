Imports MySql.Data.MySqlClient

Public Class Connection
    Shared cnx As New MySqlConnection

    Private Shared Sub Connect()
        Try
            cnx.ConnectionString = "Server=localhost;Database=topartistasregion;Uid=root;Pwd=admin"
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
            Dim cmd As New MySqlCommand(query, cnx)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message)
        Finally
            Disconnect()
        End Try
        Return dt
    End Function
End Class
