Imports System.Data.SqlClient
Public Class Form3
    Dim ErrorProvider1 As ErrorProvider = New ErrorProvider()
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmname.TextChanged

    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If (txtname.Text = "" Or txtname.Text.Trim = "" Or txtaddress.Text = "" Or txtaddress.Text.Trim = "" Or txtcity.Text = "" Or txtcity.Text.Trim.Trim = "" Or txtfname.Text = "" Or txtfname.Text.Trim = "" Or txtmname.Text = "" Or txtmname.Text.Trim = "" Or txtphone.Text = "" Or txtphone.Text.Trim = "" Or txtroll.Text = "" Or txtroll.Text.Trim = "" Or txtsession1.Text = "" Or txtsession1.Text.Trim = "" Or txtsession2.Text = "" Or txtsession2.Text.Trim = "" Or txtstate.Text = "" Or txtstate.Text.Trim = "" Or txtphone.Text.Length < 10 Or OpenFileDialog1.FileName = "") Then
            If (txtphone.Text.Length < 10) Then
                MessageBox.Show("Plz enter valid phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Plz enter all value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Try
                Dim temp, id As String
                temp = txtsession1.Text + lbl.Text + txtsession2.Text
                id = txtsession1.Text + lbl.Text + txtroll.Text
                Dim con As SqlConnection = New SqlConnection()
                con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
                con.Open()
                Dim com As SqlCommand = New SqlCommand()
                com.Connection = con
                ' com.CommandText = "Insert into student values ('" & txtname.Text & "','" & txtroll.Text & "','" & temp & "','" & txtfname.Text & "','" & txtmname.Text & "','" & id & "','" & txtphone.Text & "','" & txtaddress.Text & "','" & txtcity.Text & "','" & txtstate.Text & "','" & stupic.Name & "')"

                com.CommandText = "insert into student(Sname,Roll,Ssession,Fname,Mname,S_id,phone,Saddress,City,Sstate,photo)Select '" & txtname.Text & "','" & txtroll.Text & "','" & temp & "','" & txtfname.Text & "','" & txtmname.Text & "','" & id & "','" & txtphone.Text & "','" & txtaddress.Text & "','" & txtcity.Text & "','" & txtstate.Text & "',bulkcolumn from openrowset(bulk '" & OpenFileDialog1.FileName & "',single_blob)as image;"

                com.ExecuteNonQuery()
                MessageBox.Show("student id is " & id, "successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Dispose()
                com.Dispose()
                txtname.Text = ""
                txtroll.Text = ""
                txtfname.Text = ""
                txtmname.Text = ""
                txtaddress.Text = ""
                txtphone.Text = ""
                txtsession1.Text = ""
                txtsession2.Text = ""
                txtcity.Text = ""
                txtstate.Text = ""
                stupic.Image = Nothing
                txtname.Focus()
            Catch ex As Exception
                MessageBox.Show("Please Enter All valid Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl.Click

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub txtphone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress

        If (Char.IsNumber(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtphone, "Plz enter only number")
        End If
    End Sub

    Private Sub txtsession1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsession1.KeyPress

        If (Char.IsNumber(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtsession1, "Plz enter only number")
        End If
    End Sub

    Private Sub txtsession2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsession2.KeyPress

        If (Char.IsNumber(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtsession2, "Plz enter only number")
        End If
    End Sub

    Private Sub txtroll_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtroll.KeyPress

        If (Char.IsNumber(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtroll, "Plz enter only number")
        End If
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress

        If (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtname, "Plz enter alphabates with white space")
        End If
    End Sub

    Private Sub txtfname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress

        If (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtfname, "Plz enter alphabates with white space")
        End If
    End Sub

    Private Sub txtmname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmname.KeyPress

        If (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtmname, "Plz enter alphabates with white space")
        End If
    End Sub

    Private Sub txtcity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcity.KeyPress

        If (Char.IsLetter(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtcity, "Plz enter only alphabates")
        End If
    End Sub

    Private Sub txtstate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstate.KeyPress

        If (Char.IsLetter(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtstate, "Plz enter only alphabates")
        End If
    End Sub

    Private Sub txtfname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfname.TextChanged

    End Sub

    Private Sub stupic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stupic.Click
        With OpenFileDialog1
            .Filter = "JPG File(*.jpg)|*.jpg|PNG File(*.png)|*.png"
            .FileName = ""
            .InitialDirectory = "C:\"
        End With
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            stupic.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    'Private Sub txtsession1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsession1.Enter
    '    txtsession2.Focus()
    'End Sub
End Class