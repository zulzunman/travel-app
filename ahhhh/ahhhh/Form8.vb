Imports MySql.Data.MySqlClient
Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CMD = New MySql.Data.MySqlClient.MySqlCommand
        CMD.Connection = Konek
        query = "insert into manage_destinasi values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
        CMD.CommandText = query
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil ditambah", vbInformation, "Berhasil")
        tampil()
    End Sub
    Sub tampil()
        Ds = New DataSet
        query = "select * from manage_destinasi"
        Da = New MySql.Data.MySqlClient.MySqlDataAdapter(query, Konek)
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        tampil()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Apakah data ini akan di hapus??", vbYesNo) = vbYes Then
            CMD = New MySqlCommand
            CMD.Connection = Konek
            query = "Delete from manage_destinasi where id = '" & TextBox1.Text & "'"
            CMD.CommandText = query
            CMD.ExecuteNonQuery()
            MsgBox("Berhasil dihapus ya", vbInformation, "Berhasi Hore")
            tampil()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class