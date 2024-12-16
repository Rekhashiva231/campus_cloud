Imports System.Data.SqlClient

Public Class adminDisplay


    Private Sub adminDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        displayrecords()
        dgv_styleRow()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Sub dgv_styleRow()
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If i Mod 2 = 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightBlue
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White

            End If
        Next
    End Sub

    Dim temp As String
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        temp = DataGridView1.CurrentRow.Cells(0).Value
        ' MsgBox("the event id is" & temp)
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds As New DataSet
        Dim adp As New SqlDataAdapter("select * from regevent where eventID = '" & temp & "' and colegeid = '" & collegeid & "'", conn)
        adp.Fill(ds)
        DataGridView2.DataSource = ds.Tables(0)

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
    End Sub
    Sub displayrecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim DS As New DataSet
        Dim adp As New SqlDataAdapter("select * from ADMINDISPLAY where collegeid = '" & collegeid & "'", conn)
        adp.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()

    End Sub


    Private Sub DataGridView1_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DataSourceChanged
        dgv_styleRow()

    End Sub

End Class