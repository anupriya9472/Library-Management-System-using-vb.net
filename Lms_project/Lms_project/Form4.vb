Imports System.Data.SqlClient
Imports System.IO

Public Class Form4
    Dim con As SqlConnection = New SqlConnection()
    Dim com As SqlCommand = New SqlCommand()
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        con.Open()
        com.Connection = con
        
        com.CommandText = "Select Ssession From student group by Ssession;"
        Dim oread As SqlDataReader = com.ExecuteReader()
        While (oread.Read() = True)
            cmbsession.Items.Add(oread("Ssession")).ToString()
        End While
        oread.Close()
        
        con.Dispose()
        com.Dispose()

    End Sub

    Private Sub cmbsession_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsession.SelectedIndexChanged
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        con.Open()
        com.Connection = con
        cmbsid.Items.Clear()
        cmbsid.Text = ""
        txtname.Text = ""
        If (cmbsession.SelectedIndex >= 0) Then
            cmbsid.Visible = True
            Label2.Visible = True
            com.CommandText = "Select S_id from student where Ssession='" & cmbsession.SelectedItem & "';"
            Dim oread1 As SqlDataReader = com.ExecuteReader()
            While (oread1.Read() = True)
                cmbsid.Items.Add(oread1("S_id")).ToString()
            End While
            oread1.Close()
        End If
        con.Dispose()
        com.Dispose()
    End Sub

    Private Sub cmbsid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsid.SelectedIndexChanged
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        con.Open()
        com.Connection = con
        txtname.Text = ""
        If (cmbsid.SelectedIndex >= 0) Then
            Label3.Visible = True
            txtname.Visible = True
            com.CommandText = "Select Sname from student where S_id='" & cmbsid.SelectedItem & "';"
            Dim oread1 As SqlDataReader = com.ExecuteReader()
            oread1.Read()
            txtname.Text = oread1("Sname").ToString()
            oread1.Close()
        End If
        con.Dispose()
        com.Dispose()
    End Sub

    Private Sub btnenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenter.Click
        If (cmbsid.Text = "") Then
            MessageBox.Show("Plz select student id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim temp As Object = New Object
            con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
            con.Open()
            com.Connection = con
            com.CommandText = "Select *from student where S_id='" & cmbsid.Text & "';"
            Dim oread As SqlDataReader = com.ExecuteReader()
            oread.Read()
            Form15.txtname.Text = oread("Sname").ToString()
            Form15.txtfname.Text = oread("Fname").ToString()
            Form15.txtroll.Text = oread("Roll").ToString()
            Form15.txtmname.Text = oread("Mname").ToString()
            Form15.txtcity.Text = oread("City").ToString()
            Form15.txtaddress.Text = oread("Saddress").ToString()
            Form15.txtstate.Text = oread("Sstate").ToString()
            Form15.txtid.Text = oread("S_id").ToString()
            Form15.txtphone.Text = oread("phone").ToString()
            temp = oread("photo")

            Dim bytes As Byte() = CType(temp, Byte())
            Form15.stupic.Image = Image.FromStream(New MemoryStream(bytes))

            oread.Close()
            con.Dispose()
            com.Dispose()
            Form15.Show()
            Me.Close()
        End If
    End Sub
End Class