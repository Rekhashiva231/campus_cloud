Imports System.Net.Mail
Public Class CONTACTUS


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyMessage As New MailMessage
        Try
            MyMessage.From = New MailAddress("example@gmail.com")
            MyMessage.To.Add("example@gmail.com")
            MyMessage.Body = TextBox4.Text
            Dim SMPT As New SmtpClient("smtp.gmail.com")
            SMPT.Port = 587
            SMPT.EnableSsl = True
            SMPT.Credentials = New System.Net.NetworkCredential("example@gmail.com", "email password")
            SMPT.Send(MyMessage)
        Catch ex As Exception
            Me.Hide()
            thankyou.Show()

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure you want to clear the contents of your form?", MsgBoxStyle.YesNoCancel, "clearing the form")
        If ask = MsgBoxResult.Yes Then
            MsgBox("Your form is cleared!")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox4.Clear()
        ElseIf ask = MsgBoxResult.No Then
            MsgBox("You have decided to cancel")
        End If
    End Sub

    Private Sub TextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseEnter
        If TextBox1.Text = "Ex:Riya" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
            TextBox1.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Ex:Riya"
            TextBox1.ForeColor = Color.Gray
            TextBox1.TextAlign = HorizontalAlignment.Center
        End If
    End Sub
    Private Sub TextBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseEnter
        If TextBox2.Text = "Ex Id: abc@gmail.com" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseLeave
        If TextBox2.Text = "" Then
            TextBox2.Text = "Ex Id: abc@gmail.com"
            TextBox2.ForeColor = Color.Gray
            TextBox2.TextAlign = HorizontalAlignment.Center
        End If
    End Sub


    Private Sub TextBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.MouseEnter
        If TextBox4.Text = "Give your feedback here" Then
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.Black
            TextBox4.TextAlign = HorizontalAlignment.Center

        End If
    End Sub

  

    Private Sub TextBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.MouseLeave
        If TextBox4.Text = "" Then
            TextBox4.Text = "Give your feedback here"
            TextBox4.ForeColor = Color.Gray
            TextBox4.TextAlign = HorizontalAlignment.Center
        End If
    End Sub


    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.LawnGreen
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Black
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.LawnGreen
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Black
    End Sub




End Class