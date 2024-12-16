Imports System.Data.SqlClient

Public Class studentdisplay


    Private Sub studentdisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        displayrecords()

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




    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        displayrecords()

    End Sub

    Sub displayrecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim DS As New DataSet
        Dim adp As New SqlDataAdapter("select * from regevent where emailID='" & studemail & "'", conn)
        adp.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()


    End Sub

End Class