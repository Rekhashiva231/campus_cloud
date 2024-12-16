Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class adminform
    Dim q1var, q2var As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim cmd2 As New SqlCommand(" select * from collegereg where collegeid='" & TextBox1.Text & "' and password ='" & TextBox2.Text & "'", conn)
        Dim d2 As SqlDataReader = cmd2.ExecuteReader
        If d2.HasRows Then
            Me.Hide()
            collegeid = TextBox1.Text
            adminhome.Show()
            TextBox1.Clear()
            TextBox2.Clear()

        Else
            MsgBox("login failed")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If



    End Sub

    Private Sub TextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter
        If TextBox1.Text = "Ex ID:1001" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Ex ID:1001"
            TextBox1.ForeColor = Color.Gray
            TextBox1.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseEnter
        If TextBox2.Text = "enter your password" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseLeave
        If TextBox2.Text = "" Then
            TextBox2.Text = "enter your password"
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

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        selection.Show()
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub
    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.LawnGreen
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.White
    End Sub

End Class