Imports System.Data.SqlClient

Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim cmd1 As New SqlCommand("select * from STUDENTPASSWORD where EMAILID='" & TextBox1.Text & "' and PASSWORD ='" & TextBox2.Text & "'", conn)
        Dim d1 As SqlDataReader = cmd1.ExecuteReader
        If d1.HasRows Then
            d1.Read()
            collegeid = d1(5).ToString
            studemail = TextBox1.Text
            display_1.Show()
            Me.Hide()

            Else
            MsgBox("login failed")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Panel1.BackColor = Color.FromArgb(100, 0, 0, 0)
    End Sub

    Private Sub TextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter
        If TextBox1.Text = "Ex ID: abc@gmail.com" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Ex ID: abc@gmail.com"
            TextBox1.ForeColor = Color.Gray
            TextBox1.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseEnter
        If TextBox2.Text = "Create a password" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseLeave
        If TextBox2.Text = "" Then
            TextBox2.Text = "Create a password"
            TextBox2.ForeColor = Color.Gray
            TextBox2.TextAlign = HorizontalAlignment.Center
        End If
    End Sub


    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.LawnGreen
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        CONTACTUS.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        eventslist.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Hide()
        eventslist.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Hide()
        CONTACTUS.Show()
    End Sub
End Class
