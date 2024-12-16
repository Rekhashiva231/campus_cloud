Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class registration

    Sub displayrecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim DS As New DataSet
        Dim adp As New SqlDataAdapter("select * from ADMINDISPLAY order by eventid", conn)
        adp.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        displayrecords()

    End Sub

    Dim q1var, q2var As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        If TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
            MsgBox("enter your details")
            Exit Sub
        End If
        q1var = "insert into regevent( eventID,eventname,venue,COLEGEID,eventdate,regID,teamname,collegename,REGCOLLEGEID,contactnumber,department,emailID)"
        q2var = "values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox11.Text & "','" & TextBox10.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & collegeid & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')"
        ' MsgBox(q1var & q2var)
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
        cmd1.ExecuteNonQuery()
        MsgBox("your registration is complete")
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub


    Dim temp As String
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        temp = DataGridView1.CurrentRow.Cells(0).Value
        'MsgBox("the name is" & temp)
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd As New SqlCommand("select * from ADMINDISPLAY where eventid ='" & temp & "'", conn)
        Dim ex As SqlDataReader = cmd.ExecuteReader()
        If ex.HasRows Then
            ex.Read()

            TextBox1.Text = ex(0).ToString
            TextBox2.Text = ex(1).ToString
            TextBox3.Text = ex(2).ToString
            TextBox10.Text = ex(3).ToString
            TextBox11.Text = ex(6).ToString

        End If
    End Sub

    

    Private Sub TextBox7_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.Leave
        Dim phone As New Regex("^([6-9]{1})([0-9]{9})")
        TextBox7.MaxLength = 10
        If phone.IsMatch(TextBox7.Text) Then
            TextBox8.Focus()
        Else
            MsgBox("invalid phone number pattern")
            TextBox7.Clear()
            TextBox7.Focus()
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


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()

    End Sub
    
End Class