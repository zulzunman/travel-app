Imports MySql.Data.MySqlClient
Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        tampil()
    End Sub
    Sub tampil()
        Ds = New DataSet
        query = "select * from pesanan"
        Da = New MySql.Data.MySqlClient.MySqlDataAdapter(query, Konek)
        Da.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Form4.TextBox1.Text = DataGridView1.Item(0, i).Value
        Form4.TextBox2.Text = DataGridView1.Item(1, i).Value
        Form4.TextBox3.Text = DataGridView1.Item(2, i).Value
        Form4.TextBox4.Text = DataGridView1.Item(3, i).Value
        Form4.TextBox5.Text = DataGridView1.Item(4, i).Value
        Form4.ComboBox1.Text = DataGridView1.Item(5, i).Value
        Form4.ComboBox2.Text = DataGridView1.Item(6, i).Value
        Form4.TextBox6.Text = DataGridView1.Item(7, i).Value

    End Sub
End Class