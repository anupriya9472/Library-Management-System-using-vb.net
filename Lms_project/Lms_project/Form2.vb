Imports System.Data.SqlClient
Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddmision.Click
        dglist.Visible = False
        Form3.Show()
    End Sub

    Private Sub btnAllStu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllStu.Click
        dglist.Visible = True
        Dim con As SqlConnection = New SqlConnection()
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        Dim oad As SqlDataAdapter = New SqlDataAdapter("Select Sname As Name,Roll As RollNo, Ssession As Session,S_id As Id, Fname As Father_Name,Mname As Mother_Name,phone As PhoneNo,Saddress As Address,city As City,Sstate As State from student order by Ssession,Roll asc;", con)
        Dim oset As DataSet = New DataSet()
        oad.Fill(oset)
        dglist.DataSource = oset.Tables(0)
        oad.Dispose()
        oset.Dispose()
        con.Dispose()
    End Sub

    Private Sub btnSearchStu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchStu.Click
        dglist.Visible = False
        Form5.Show()

    End Sub

    Private Sub btnEditStuDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStuDel.Click
        dglist.Visible = False
        Form4.Show()

    End Sub

    Private Sub btnBookEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookEntery.Click
        btns.Visible = False
        dgstock1.Visible = False
        Label1.Visible = False
        cmbgid.Visible = False
        Form7.Show()
        dgbook.Visible = False
    End Sub

    Private Sub btnAllBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllBook.Click
        dgstock1.Visible = False
        Label1.Visible = False
        cmbgid.Visible = False
        btns.Visible = False
        dgbook.Visible = True
        Dim con As SqlConnection = New SqlConnection()
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        Dim oad As SqlDataAdapter = New SqlDataAdapter("Select Title,B_id As Id,Group_id,WritterName As Author,Publication,Price,T_page As TotalPage from books;", con)
        Dim oset As DataSet = New DataSet()
        oad.Fill(oset)
        dgbook.DataSource = oset.Tables(0)
        oad.Dispose()
        oset.Dispose()
        con.Close()
    End Sub

    Private Sub btnSearchBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchBook.Click
        dgbook.Visible = False
        dgstock1.Visible = False
        btns.Visible = True
        Label1.Visible = True
        cmbgid.Visible = True
        cmbgid.Items.Clear()
        Dim con As SqlConnection = New SqlConnection()
        Dim com As SqlCommand = New SqlCommand()
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
        oread.Close()
    End Sub

    Private Sub btnIssuedBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssuedBook.Click
        dgstock1.Visible = False
        Label1.Visible = False
        cmbgid.Visible = False
        dgbook.Visible = True
        btns.Visible = False
        Dim con As SqlConnection = New SqlConnection()
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        Dim oad As SqlDataAdapter = New SqlDataAdapter("select Sname,issue.Stu_id,Title,issue.B_id,Group_id,I_date,R_date from student,Books,issue where student.S_id= issue.Stu_id And Books.B_id=issue.B_id;", con)
        Dim oset As DataSet = New DataSet()
        oad.Fill(oset)
        dgbook.DataSource = oset.Tables(0)
        oad.Dispose()
        oset.Dispose()
        con.Close()

    End Sub

    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click
        dgstock1.Visible = True
        btns.Visible = False
        Label1.Visible = False
        cmbgid.Visible = False
        dgbook.Visible = False
        Dim con As SqlConnection = New SqlConnection()
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        Dim oad As SqlDataAdapter = New SqlDataAdapter("Select Group_id,TotalBook,issue,TotalBook-issue As available from stock;", con)
        Dim oset As DataSet = New DataSet()
        oad.Fill(oset)
        dgstock1.DataSource = oset.Tables(0)
        oad.Dispose()
        oset.Dispose()
        con.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssueB.Click
        dgstock.Visible = False
        Form12.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStockB.Click
        dgstock.Visible = True
        Dim con As SqlConnection = New SqlConnection()
        con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
        Dim oad As SqlDataAdapter = New SqlDataAdapter("Select Group_id,TotalBook,issue,TotalBook-issue As available from stock ;", con)
        Dim oset As DataSet = New DataSet()
        oad.Fill(oset)
        dgstock.DataSource = oset.Tables(0)
        oad.Dispose()
        oset.Dispose()
        con.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnB.Click
        dgstock.Visible = False

        Form14.Show()

    End Sub

    Private Sub btns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btns.Click
        If (cmbgid.Text = "") Then
            MessageBox.Show("plz choose group id ", "Enter Group Id", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            dgbook.Visible = True
            Dim con As SqlConnection = New SqlConnection()
            con.ConnectionString = "Data Source=DESKTOP-AEMCQNO\SQLEXPRESS;Initial Catalog=tpc;Integrated Security=True"
            Dim oad As SqlDataAdapter = New SqlDataAdapter("Select Title,B_id As Id,Group_id,WritterName As Author,Publication,Price,T_page As TotalPage from books where Group_id='" & cmbgid.Text & "';", con)
            Dim oset As DataSet = New DataSet()
            oad.Fill(oset)
            dgbook.DataSource = oset.Tables(0)
            oad.Dispose()
            oset.Dispose()
            con.Dispose()
        End If
    End Sub

    Private Sub Form2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        dgstock.Visible = False
        btns.Visible = False
        dgbook.Visible = False
        dglist.Visible = False

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgstock1.Visible = False
        btns.Visible = False
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub Form2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
       

    End Sub

    Private Sub TabStuD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabStuD.Click
        dglist.Visible = False
    End Sub

    Private Sub TabBookD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabBookD.Click
        dgbook.Visible = False
        dgstock1.Visible = False
        btns.Visible = False
        Label1.Visible = False
        cmbgid.Visible = False

    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click
        dgstock.Visible = False
    End Sub
End Class