Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class student_form
    Dim q1var, q2var As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("enter student details")
            Exit Sub
        End If

        q1var = "insert into STUDENTPASSWORD(NAME,PHONENUMBER,EMAILID,PASSWORD,CONFIRMPASSWORD,COLLEGID)"
        q2var = "values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & collegeid & "')"
        'MsgBox(q1var & q2var)
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
        cmd1.ExecuteNonQuery()
        MsgBox(" saved  successfully ")
        If conn.State = ConnectionState.Open Then conn.Close()



    End Sub

    Private Sub TextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        Dim phone As New Regex("^([6-9]{1})([0-9]{9})")
        TextBox2.MaxLength = 10
        If phone.IsMatch(TextBox2.Text) Then
            TextBox3.Focus()
        Else
            MsgBox("invalid phone number pattern")
            TextBox2.Clear()
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter
        If TextBox1.Text = "Enter your name" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Enter your name"
            TextBox1.ForeColor = Color.Gray
            TextBox1.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseEnter
        If TextBox2.Text = "Enter your contact" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseLeave
        If TextBox2.Text = "" Then
            TextBox2.Text = "Enter your contact"
            TextBox2.ForeColor = Color.Gray
            TextBox2.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.MouseEnter
        If TextBox3.Text = "Ex ID: abc@gmail.com" Then
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.MouseLeave
        If TextBox3.Text = "" Then
            TextBox3.Text = "Ex ID: abc@gmail.com"
            TextBox3.ForeColor = Color.Gray
            TextBox3.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.MouseEnter
        If TextBox4.Text = "Create a password" Then
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.MouseLeave
        If TextBox4.Text = "" Then
            TextBox4.Text = "Create a password"
            TextBox4.ForeColor = Color.Gray
            TextBox4.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.MouseEnter
        If TextBox5.Text = "Confirm your password" Then
            TextBox5.Text = ""
            TextBox5.ForeColor = Color.Black
            TextBox5.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.MouseLeave
        If TextBox5.Text = "" Then
            TextBox5.Text = "Confirm your password"
            TextBox5.ForeColor = Color.Gray
            TextBox5.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

   
   
    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.LawnGreen
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.White
    End Sub
    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.LawnGreen
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.White
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True

        End If
    End Sub
End Class