Imports System.Data.SqlClient
Public Class Form15
    Dim filename As String
    Dim OpenFileDialog1 As OpenFileDialog = New OpenFileDialog()
    Dim ErrorProvider1 As ErrorProvider = New ErrorProvider()

    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtid.ReadOnly = True
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If (txtsession1.Text = "" Or txtsession2.Text = "" Or txtroll.Text = "") Then
            MessageBox.Show("Plz enter session and roll", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim con As SqlConnection = New SqlConnection()
            Dim com As SqlCommand = New SqlCommand()
            Dim sess, id As String
            sess = txtsession1.Text + lbl.Text + txtsession2.Text
            id = txtsession1.Text + lbl.Text + txtroll.Text
            con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
            con.Open()
            com.Connection = con
            com.CommandText = "Update student set S_id='" & id & "', Roll='" & txtroll.Text & "' , Sname= '" & txtname.Text & "' , Ssession= '" & sess & "' , Fname= '" & txtfname.Text & "' , Mname='" & txtmname.Text & "' , phone='" & txtphone.Text & "', Saddress= '" & txtaddress.Text & "' ,city='" & txtcity.Text & "' , Sstate= '" & txtstate.Text & "' where S_id='" & Form6.lblid.Text & "';"
            com.ExecuteNonQuery()
            If filename <> "" Then
                com.CommandText = "Update student set photo=(Select bulkcolumn from openrowset(bulk '" & filename & "',single_blob)as image) where S_id='" & txtid.Text & "';"
                com.ExecuteNonQuery()
            End If
            MessageBox.Show("successfully updated", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            com.Dispose()
            con.Dispose()
            Me.Close()
            End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub stupic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stupic.Click
        With OpenFileDialog1
            .Filter = "JPG File(*.jpg)|*.jpg|PNG File(*.png)|*.png"
            .FileName = ""
            .InitialDirectory = "C:\"
        End With
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            filename = OpenFileDialog1.FileName
            stupic.Load(OpenFileDialog1.FileName)
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

    Private Sub txtphone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress

        If (Char.IsNumber(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtphone, "Plz enter only number")
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

    Private Sub txtname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress

        If (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtname, "Plz enter alphabates with white space")
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
End Class