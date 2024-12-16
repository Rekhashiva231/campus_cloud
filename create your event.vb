Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class create_your_event

    Dim q1var, q2var As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim date1 As String
        date1 = DateTimePicker1.Value
        date1 = date1.Substring(0, 10)
        MsgBox(date1)

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("enter event details")
            Exit Sub
        End If
        q1var = "insert into ADMINDISPLAY(EVENTID,EVENTNAME,VENUE,DATE,COORDINATORNAME,CONTACTNUMBER,collegeid)"
        q2var = "values('" & TextBox5.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & date1 & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & collegeid & "')"
        ' MsgBox(q1var & q2var)
        Dim cmd1 As New SqlCommand(q1var & q2var, conn)
        cmd1.ExecuteNonQuery()
        MsgBox("data saved successfully")
        If conn.State = ConnectionState.Open Then conn.Close()


        displayRecords()



    End Sub


    Dim temp As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd As New SqlCommand("delete from ADMINDISPLAY where EVENTID  ='" & temp & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("your data has been deleted")
        displayRecords()

    End Sub

    Private Sub create_your_event_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = Date.Now
        displayRecords()
    End Sub
    Sub displayRecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim DS As New DataSet
        Dim adp As New SqlDataAdapter("select* from ADMINDISPLAY  where collegeid = '" & collegeid & "'", conn)
        adp.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        displayRecords()

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        temp = DataGridView1.CurrentRow.Cells(0).Value
        'MsgBox("the name is" & temp)
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd As New SqlCommand("select * from ADMINDISPLAY where EVENTID = '" & temp & "'", conn)
        Dim ex As SqlDataReader = cmd.ExecuteReader()
        If ex.HasRows Then
            ex.Read()
            TextBox1.Text = ex(1).ToString
            TextBox2.Text = ex(2).ToString

            TextBox3.Text = ex(4).ToString
            TextBox4.Text = ex(5).ToString
            TextBox5.Text = ex(0).ToString



        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd As New SqlCommand("update ADMINDISPLAY set EVENTID='" & TextBox5.Text & "',EVENTNAME='" & TextBox1.Text & "',VENUE='" & TextBox2.Text & "',COORDINATORNAME = '" & TextBox3.Text & "',CONTACTNUMBER= '" & TextBox4.Text & "'where EVENTID='" & temp & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data modified sucessfully")
        displayRecords()

    End Sub

    Private Sub TextBox4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.Leave
        Dim phone As New Regex("^([6-9]{1})([0-9]{9})")
        TextBox4.MaxLength = 10
        If phone.IsMatch(TextBox4.Text) Then
            TextBox5.Focus()
        Else
            MsgBox("invalid phone number pattern")
            TextBox4.Clear()
            TextBox4.Focus()
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
    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.LawnGreen
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.White
    End Sub
    Private Sub Button4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseHover
        Button4.BackColor = Color.LawnGreen
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.White
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
End Class
