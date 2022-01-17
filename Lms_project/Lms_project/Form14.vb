Imports System.Data.SqlClient
Public Class Form14
    Dim con As SqlConnection = New SqlConnection()
    Dim com As SqlCommand = New SqlCommand()

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        con.Open()
        com.Connection = con
        com.CommandText = "select * from stock;"
        Dim oread As SqlDataReader = com.ExecuteReader()
        While (oread.Read() = True)
            cmbbid.Items.Add(oread("Group_id")).ToString()
        End While
        con.Dispose()
        com.Dispose()

    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Try
            con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
            con.Open()
            com.Connection = con
            com.CommandText = "select * from stock,issue where Group_id='" & cmbbid.Text & "' And B_id='" & txtbid.Text & "' And Stu_id='" & txtsid.Text & "' And R_date is null;"
            com.ExecuteNonQuery()
            Dim oread As SqlDataReader = com.ExecuteReader()
            Dim i As Integer
            oread.Read()
            i = oread("issue").ToString()
            txtsid.Text = oread("Stu_id").ToString()
            txtbid.Text = oread("B_id").ToString()
            oread.Close()
            com.CommandText = "Update Issue set R_date='" & rdate.Text & "' where Stu_id='" & txtsid.Text & "' And B_id='" & txtbid.Text & "' And R_date is null;"
            com.ExecuteNonQuery()
            i = i - 1
            com.CommandText = "Update stock set issue='" & i & "' where Group_id='" & cmbbid.Text & "';"
            com.ExecuteNonQuery()
            MessageBox.Show("Book id " & txtbid.Text & " is returned", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Dispose()
            com.Dispose()
        Catch ex As Exception
            MessageBox.Show("plz enter all valid id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class