Imports System.Data.SqlClient
Public Class Form12
    Dim con As SqlConnection = New SqlConnection()
    Dim com As SqlCommand = New SqlCommand()
    Public Shared totalb, issueb, av As Integer
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
            con.Open()
            com.CommandText = "select * from stock where Group_id='" & cmbgid.Text & "';"
            Dim oread As SqlDataReader = com.ExecuteReader()
            oread.Read()
            totalb = oread("TotalBook").ToString()
            issueb = oread("issue").ToString()
            av = totalb - issueb
            If (av < 1) Then
                MessageBox.Show("THIS BOOK IS NOT AVAILABLE IN THE STOCK", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Form13.Show()
                Me.Hide()
            End If
            oread.Close()
        Catch ex As Exception
            MessageBox.Show("Plz check your Group Id", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Dispose()
        com.Dispose()
    End Sub

    Public Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        con.Open()
        com.Connection = con
        com.CommandText = "select * from stock;"
        Dim oread As SqlDataReader = com.ExecuteReader()
        While (oread.Read() = True)
            cmbgid.Items.Add(oread("Group_id")).ToString()
        End While
        con.Dispose()
        com.Dispose()
        cmbgid.Text = ""
    End Sub
End Class