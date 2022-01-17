Imports System.Data.SqlClient
Imports System.IO

Public Class Form5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection()
        Dim com As SqlCommand = New SqlCommand()
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        If (txtStuId1.Text <> "") Then
            Try
                Dim temp As Object = New Object
                con.Open()
                com.Connection = con
                com.CommandText = "Select *from student where S_id= '" & txtStuId1.Text & "';"
                com.ExecuteNonQuery()
                Dim oread As SqlDataReader = com.ExecuteReader()
                oread.Read()
                Form6.lblname.Text = oread("Sname").ToString()
                Form6.lblrolln.Text = oread("Roll").ToString()
                Form6.lblid.Text = oread("S_id").ToString()
                Form6.lblf.Text = oread("Fname").ToString()
                Form6.lblm.Text = oread("Mname").ToString()
                Form6.lblsess.Text = oread("Ssession").ToString()
                Form6.lblph.Text = oread("phone").ToString()
                Form6.lbladd.Text = oread("Saddress").ToString()
                Form6.lblcity.Text = oread("city").ToString()
                Form6.lblstate.Text = oread("Sstate").ToString()
                temp = oread("photo")
                Dim bytes As Byte() = CType(temp, Byte())
                Form6.PictureBox1.Image = Image.FromStream(New MemoryStream(bytes))

                Form6.Show()
                Me.Hide()
                con.Dispose()
                com.Dispose()
            Catch ex As Exception
                MessageBox.Show(" Student id is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf (txtRoll.Text <> "" And txtSession.Text <> "") Then
            Try
                con.Open()
                com.Connection = con
                com.CommandText = "Select *from student where Roll='" & txtRoll.Text & "' and Ssession='" & txtSession.Text & "';"
                com.ExecuteNonQuery()
                Dim oread As SqlDataReader = com.ExecuteReader()
                oread.Read()
                Form6.lblname.Text = oread("Sname").ToString()
                Form6.lblrolln.Text = oread("Roll").ToString()
                Form6.lblid.Text = oread("S_id").ToString()
                Form6.lblf.Text = oread("Fname").ToString()
                Form6.lblm.Text = oread("Mname").ToString()
                Form6.lblsess.Text = oread("Ssession").ToString()
                Form6.lblph.Text = oread("phone").ToString()
                Form6.lbladd.Text = oread("Saddress").ToString()
                Form6.lblcity.Text = oread("city").ToString()
                Form6.lblstate.Text = oread("Sstate").ToString()
                Form6.Show()
                Me.Hide()
                con.Dispose()
                com.Dispose()
            Catch es As Exception
                MessageBox.Show("Roll no or session is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
                MessageBox.Show("Plz enter student id or roll and session", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtRoll.Text = ""
        txtSession.Text = ""
        txtStuId1.Text = ""
        txtStuId1.Focus()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Public Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class