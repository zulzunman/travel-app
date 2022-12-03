Imports MySql.Data.MySqlClient
Public Class Form4
    Sub autoincreament()
        Call Koneksi()
        query = "select max(id) from pesanan"
        CMD = New MySqlCommand(query, Konek)
        Dr = CMD.ExecuteReader()
        Dr.Read()
        On Error GoTo Err
        If Dr.HasRows Then
            TextBox1.Text = Format(Val(Dr.Item(0)) + 1)
        End If
        Exit Sub
Err:
        TextBox1.Text = 1
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        CMD = New MySql.Data.MySqlClient.MySqlCommand
        CMD.Connection = Konek
        query = "insert into pesanan values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox6.Text & "')"
        CMD.CommandText = query
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil ditambah", vbInformation, "Berhasil")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox4.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox2.Text = ""
        Me.TextBox6.Text = ""
    End Sub
End Class