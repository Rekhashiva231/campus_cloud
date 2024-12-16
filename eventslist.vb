Imports System.Data.SqlClient

Public Class eventslist
    Sub displayrecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim DS As New DataSet
        Dim adp As New SqlDataAdapter("select * from ADMINDISPLAY", conn)
        adp.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()


    End Sub
    Private Sub eventslist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        displayrecords()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

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
        Me.Hide()
        selection.Show()
    End Sub
End Class