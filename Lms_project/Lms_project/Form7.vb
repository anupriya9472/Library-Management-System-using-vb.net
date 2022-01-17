Imports System.Data.SqlClient
Public Class Form7
    Dim com As SqlCommand = New SqlCommand()
    Dim con As SqlConnection = New SqlConnection()

    Private Sub btnbsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbsubmit.Click
        If (txtPrice.Text = "" Or txtPrice.Text.Trim = "" Or txtPubName.Text = "" Or txtPubName.Text.Trim = "" Or txtTitle.Text = "" Or txtTitle.Text.Trim = "" Or txtTotalPage.Text = "" Or txtTotalPage.Text.Trim = "" Or txtWName.Text = "" Or txtWName.Text.Trim = "" Or combGroupId.Text = "" Or combGroupId.Text.Trim = "") Then
            MessageBox.Show("Plz enter vaild value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
                con.Open()
                com.Connection = con
                com.CommandText = "Select TotalBook from stock where Group_id='" & combGroupId.Text & "'"
                com.ExecuteNonQuery()
                Dim oread As SqlDataReader = com.ExecuteReader()
                oread.Read()
                Dim i As Integer
                i = oread("TotalBook").ToString()
                i = i + 1
                oread.Close()
                Dim id As String
                id = combGroupId.Text + (Convert.ToString(i))
                com.CommandText = "Insert into books values('" & txtTitle.Text & "','" & txtWName.Text & "','" & id & "','" & txtPubName.Text & "','" & txtPrice.Text & "','" & txtTotalPage.Text & "','" & combGroupId.Text & "')"
                com.ExecuteNonQuery()
                com.CommandText = "update stock set TotalBook='" & i & "' where Group_id='" & combGroupId.Text & "'"
                com.ExecuteNonQuery()
                MessageBox.Show("Book Id is " & id, "successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Plz enter all record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            con.Dispose()
            com.Dispose()
            txtTitle.Text = ""
            txtPrice.Text = ""
            txtPubName.Text = ""
            txtTotalPage.Text = ""
            txtWName.Text = ""
            combGroupId.Text = ""
            txtTitle.Focus()

        End If

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        con.Open()
        com.Connection = con
        com.CommandText = "select * from stock;"
        Dim oread As SqlDataReader = com.ExecuteReader()
        While (oread.Read() = True)
            combGroupId.Items.Add(oread("Group_id")).ToString()
        End While
        con.Dispose()
        com.Dispose()

    End Sub

    Private Sub btnbcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbcancel.Click
        Me.Close()
    End Sub

    Private Sub txtTitle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTitle.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtTitle, "Plz enter alphabates with white space")
        End If
    End Sub

    Private Sub txtWName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWName.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtWName, "Plz enter alphabates with white space")
        End If
    End Sub

    Private Sub txtPubName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPubName.KeyPress
        If (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtPubName, "Plz enter alphabates with white space")
        End If
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        If (Char.IsNumber(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtPrice, "Plz enter only number")
        End If
    End Sub

    Private Sub txtTotalPage_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalPage.KeyPress
        If (Char.IsNumber(e.KeyChar) Or (e.KeyChar = ControlChars.Back)) Then
            e.Handled = False
            ErrorProvider1.Dispose()
        Else
            e.Handled = True
            ErrorProvider1.SetError(txtTotalPage, "Plz enter only number")
        End If
    End Sub
End Class