Imports MySql.Data.MySqlClient
Module Module1

    Public Konek As MySqlConnection
    Public Da As MySqlDataAdapter
    Public Dr As MySqlDataReader
    Public Ds As DataSet
    Public CMD As MySqlCommand
    Public query As String
    Public num As Integer

    Sub Koneksi()
        Try
            Dim sqlconn As String
            sqlconn = "server=localhost; uid=root;pwd=;database=vb_travel"
            Konek = New MySqlConnection(sqlconn)
            If Konek.State = ConnectionState.Closed Then
                Konek.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal", vbCritical, "Koneksi Gagal")
        End Try
    End Sub

End Module
