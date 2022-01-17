Imports System.Data.SqlClient
Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        i = 0
        Dim con As SqlConnection = New SqlConnection()
        Dim com As SqlCommand = New SqlCommand()
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        con.Open()
        com.Connection = con
        com.CommandText = "Select B_id from issue where Stu_id='" & lblid.Text & "' And R_date is null;"
        Dim oread As SqlDataReader = com.ExecuteReader()
        While (oread.Read() = True)
            cmbissue.Items.Add((oread("B_id")).ToString())
            i += 1
        End While
        cmbissue.Text = i.ToString()
        oread.Close()
        con.Dispose()
        com.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form15.txtname.Text = lblname.Text
        Form15.txtid.Text = lblid.Text
        Form15.txtroll.Text = lblrolln.Text
        Form15.txtcity.Text = lblcity.Text
        Form15.txtstate.Text = lblstate.Text
        Form15.txtaddress.Text = lbladd.Text
        Form15.txtmname.Text = lblm.Text
        Form15.txtfname.Text = lblf.Text
        Form15.txtphone.Text = lblph.Text
        Form15.stupic.Image = PictureBox1.Image
        Form15.Show()
        Me.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class