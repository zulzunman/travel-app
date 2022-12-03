Imports MySql.Data.MySqlClient
Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "X"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!!")
        Else
            Call Koneksi()
            CMD = New MySqlCommand("select * from akun where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", Konek)
            Dr = CMD.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.Close()
                Form2.Show()
            Else
                MsgBox("Username dan Password salah!!")
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "X"
        End If
    End Sub
End Class