Imports MySql.Data.MySqlClient
Public Class Form9
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value

    End Sub
    Sub tampil()
        Ds = New DataSet
        query = "select id,nama,username from akun"
        Da = New MySql.Data.MySqlClient.MySqlDataAdapter(query, Konek)
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        tampil()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CMD = New MySql.Data.MySqlClient.MySqlCommand
        CMD.Connection = Konek
        query = "insert into akun values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        CMD.CommandText = query
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil ditambah", vbInformation, "Berhasil")
        tampil()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        tampil()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("select * from akun where id='" & TextBox1.Text & "'", Konek)
            Dr = CMD.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                MsgBox("Kode Admin tidak ada")
            Else
                TextBox1.Text = Dr.Item("id")
                TextBox2.Text = Dr.Item("nama")
                TextBox3.Text = Dr.Item("username")
                TextBox4.Text = Dr.Item("password")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CMD = New MySqlCommand
        CMD.Connection = Konek
        query = "update akun set nama='" & TextBox2.Text & "', username='" & TextBox3.Text & "', password='" & TextBox4.Text & "' where id = '" & TextBox1.Text & "'"
        CMD.CommandText = query
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Diubah", vbInformation, "Berhasil")
        tampil()
    End Sub
End Class