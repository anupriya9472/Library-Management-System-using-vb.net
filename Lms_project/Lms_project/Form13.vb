Imports System.Data.SqlClient
Public Class Form13
    Dim com As SqlCommand = New SqlCommand()
    Dim con As SqlConnection = New SqlConnection()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssue.Click
        Try
            con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
            con.Open()
            com.Connection = con
            com.CommandText = "Select * from student where S_id='" & txtStuId.Text & "';"
            com.ExecuteNonQuery()
            Dim oread As SqlDataReader = com.ExecuteReader()
            oread.Read()
            txtStuId.Text = oread("S_id").ToString()
            oread.Close()

            com.CommandText = "Insert into issue (Stu_id,B_id,I_date) values ('" & txtStuId.Text & "', '" & cmbbid.Text & "' , '" & idate.Text & "');"
            com.ExecuteNonQuery()
            MessageBox.Show("successfull")
            Form12.issueb += 1
            com.CommandText = "Update stock set issue='" & Form12.issueb & "' where Group_id='" & txtgid.Text & "';"
            com.ExecuteNonQuery()
            MessageBox.Show(" insert update")
        Catch ex As Exception
            MessageBox.Show("student id is wrong")
        End Try
        con.Dispose()
        com.Dispose()
        Me.Close()
    End Sub

    

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtgid.Text = Form12.cmbgid.Text
        txtgid.ReadOnly = True
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        con.Open()
        com.Connection = con
        com.CommandText = "Select B_id from Books where Group_id ='" & txtgid.Text & "' except Select B_id from issue where R_date is null;"
        Dim oread As SqlDataReader = com.ExecuteReader()
        While (oread.Read() = True)
            cmbbid.Items.Add(oread("B_id")).ToString()
        End While
        oread.Close()
        con.Dispose()
        com.Dispose()
    End Sub
End Class