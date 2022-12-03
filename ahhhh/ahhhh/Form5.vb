Imports MySql.Data.MySqlClient
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        tampil()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CMD = New MySql.Data.MySqlClient.MySqlCommand
        CMD.Connection = Konek
        query = "insert into manage_mobil values ('" & txtid.Text & "','" & txtnama.Text & "','" & txttipe.Text & "','" & txtjml.Text & "','" & txthp.Text & "')"
        CMD.CommandText = query
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil ditambah", vbInformation, "Berhasil")
        tampil()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CMD = New MySqlCommand
        CMD.Connection = Konek
        query = "update manage_mobil set Nama_Driver='" & txtnama.Text & "', Tipe_Mobil='" & txttipe.Text & "', Jml_Kursi='" & txtjml.Text & "', No_Hp='" & txthp.Text & "' where id = '" & txtid.Text & "'"
        CMD.CommandText = query
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Diubah", vbInformation, "Berhasil")
        tampil()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Apakah data ini akan di hapus??", vbYesNo) = vbYes Then
            CMD = New MySqlCommand
            CMD.Connection = Konek
            query = "Delete from manage_mobil where id = '" & txtid.Text & "'"
            CMD.CommandText = query
            CMD.ExecuteNonQuery()
            MsgBox("Berhasil dihapus ya", vbInformation, "Berhasi Hore")
            tampil()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.txtid.Text = ""
        Me.txtnama.Text = ""
        Me.txttipe.Text = ""
        Me.txtjml.Text = ""
        Me.txthp.Text = ""
        tampil()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        txtid.Text = DataGridView1.Item(0, i).Value
        txtnama.Text = DataGridView1.Item(1, i).Value
        txttipe.Text = DataGridView1.Item(2, i).Value
        txtjml.Text = DataGridView1.Item(3, i).Value
        txthp.Text = DataGridView1.Item(4, i).Value

    End Sub
    Sub tampil()
        Ds = New DataSet
        query = "select * from manage_mobil"
        Da = New MySql.Data.MySqlClient.MySqlDataAdapter(query, Konek)
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class