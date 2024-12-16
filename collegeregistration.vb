Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class collegeregistration



    Dim q1var, q2var As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("enter your details")
            Exit Sub

        End If
        q1var = "insert into collegereg(collegeid,collegename,address,emailid,phonenumber,password,confirmpassword)"
        q2var = "values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
        ' MsgBox(q1var & q2var)
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
        cmd1.ExecuteNonQuery()
        MsgBox(" register successful ")
        If conn.State = ConnectionState.Open Then conn.Close()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub TextBox5_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.Leave
        Dim phone As New Regex("^([6-9]{1})([0-9]{9})")
        TextBox5.MaxLength = 10
        If phone.IsMatch(TextBox5.Text) Then
            TextBox6.Focus()
        Else
            MsgBox("invalid phone number pattern")
            TextBox5.Clear()
            TextBox5.Focus()
        End If
    End Sub


    Private Sub TextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter
        If TextBox1.Text = "Enter your collegeID" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Enter your collegeID"
            TextBox1.ForeColor = Color.Gray
            TextBox1.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseEnter
        If TextBox2.Text = "Enter your college Name" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Crimson
            TextBox2.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseLeave
        If TextBox2.Text = "" Then
            TextBox2.Text = "Enter your college Name"
            TextBox2.ForeColor = Color.Gray
            TextBox2.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.MouseEnter
        If TextBox3.Text = "Enter your address" Then
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
            TextBox3.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.MouseLeave
        If TextBox3.Text = "" Then
            TextBox3.Text = "Enter your address"
            TextBox3.ForeColor = Color.Gray
            TextBox3.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.MouseEnter
        If TextBox4.Text = "EX ID: xyz@gmail.com" Then
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.MouseLeave
        If TextBox4.Text = "" Then
            TextBox4.Text = "EX ID:xyz@gmail.com"
            TextBox4.ForeColor = Color.Gray
            TextBox4.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.MouseEnter
        If TextBox5.Text = "Enter your contact no" Then
            TextBox5.Text = ""
            TextBox5.ForeColor = Color.Black
            TextBox5.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.MouseLeave
        If TextBox5.Text = "" Then
            TextBox5.Text = "Enter your contact no"
            TextBox5.ForeColor = Color.Gray
            TextBox5.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.MouseEnter
        If TextBox6.Text = "Enter your password" Then
            TextBox6.Text = ""
            TextBox6.ForeColor = Color.Black
            TextBox6.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.MouseLeave
        If TextBox6.Text = "" Then
            TextBox6.Text = "Enter your password"
            TextBox6.ForeColor = Color.Gray
            TextBox6.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub TextBox7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.MouseEnter
        If TextBox7.Text = "confirm your password" Then
            TextBox7.Text = ""
            TextBox7.ForeColor = Color.Black
            TextBox7.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.MouseLeave
        If TextBox7.Text = "" Then
            TextBox7.Text = "confirm your password"
            TextBox7.ForeColor = Color.Gray
            TextBox7.TextAlign = HorizontalAlignment.Center
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
        selection.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox6.UseSystemPasswordChar = False
        Else
            TextBox6.UseSystemPasswordChar = True

        End If
    End Sub


End Class