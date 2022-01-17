<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TabIR = New System.Windows.Forms.TabControl
        Me.TabHome = New System.Windows.Forms.TabPage
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.TabStuD = New System.Windows.Forms.TabPage
        Me.dglist = New System.Windows.Forms.DataGridView
        Me.btnEditStuDel = New System.Windows.Forms.Button
        Me.btnSearchStu = New System.Windows.Forms.Button
        Me.btnAllStu = New System.Windows.Forms.Button
        Me.btnAddmision = New System.Windows.Forms.Button
        Me.TabBookD = New System.Windows.Forms.TabPage
        Me.dgstock1 = New System.Windows.Forms.DataGridView
        Me.btns = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbgid = New System.Windows.Forms.ComboBox
        Me.dgbook = New System.Windows.Forms.DataGridView
        Me.btnIssuedBook = New System.Windows.Forms.Button
        Me.btnStock = New System.Windows.Forms.Button
        Me.btnSearchBook = New System.Windows.Forms.Button
        Me.btnAllBook = New System.Windows.Forms.Button
        Me.btnBookEntery = New System.Windows.Forms.Button
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.dgstock = New System.Windows.Forms.DataGridView
        Me.btnStockB = New System.Windows.Forms.Button
        Me.btnReturnB = New System.Windows.Forms.Button
        Me.btnIssueB = New System.Windows.Forms.Button
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.TabIR.SuspendLayout()
        Me.TabHome.SuspendLayout()
        Me.TabStuD.SuspendLayout()
        CType(Me.dglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabBookD.SuspendLayout()
        CType(Me.dgstock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabIR
        '
        Me.TabIR.Controls.Add(Me.TabHome)
        Me.TabIR.Controls.Add(Me.TabStuD)
        Me.TabIR.Controls.Add(Me.TabBookD)
        Me.TabIR.Controls.Add(Me.TabPage4)
        Me.TabIR.Controls.Add(Me.TabPage5)
        Me.TabIR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabIR.Location = New System.Drawing.Point(0, 0)
        Me.TabIR.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabIR.Name = "TabIR"
        Me.TabIR.SelectedIndex = 0
        Me.TabIR.Size = New System.Drawing.Size(1318, 636)
        Me.TabIR.TabIndex = 0
        '
        'TabHome
        '
        Me.TabHome.BackColor = System.Drawing.Color.Transparent
        Me.TabHome.BackgroundImage = CType(resources.GetObject("TabHome.BackgroundImage"), System.Drawing.Image)
        Me.TabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabHome.Controls.Add(Me.MonthCalendar1)
        Me.TabHome.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabHome.Location = New System.Drawing.Point(4, 33)
        Me.TabHome.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabHome.Size = New System.Drawing.Size(1310, 599)
        Me.TabHome.TabIndex = 0
        Me.TabHome.Text = "Home"
        Me.TabHome.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(527, 55)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'TabStuD
        '
        Me.TabStuD.BackgroundImage = CType(resources.GetObject("TabStuD.BackgroundImage"), System.Drawing.Image)
        Me.TabStuD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabStuD.Controls.Add(Me.dglist)
        Me.TabStuD.Controls.Add(Me.btnEditStuDel)
        Me.TabStuD.Controls.Add(Me.btnSearchStu)
        Me.TabStuD.Controls.Add(Me.btnAllStu)
        Me.TabStuD.Controls.Add(Me.btnAddmision)
        Me.TabStuD.Location = New System.Drawing.Point(4, 33)
        Me.TabStuD.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabStuD.Name = "TabStuD"
        Me.TabStuD.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabStuD.Size = New System.Drawing.Size(1310, 599)
        Me.TabStuD.TabIndex = 1
        Me.TabStuD.Text = "Students Details"
        Me.TabStuD.UseVisualStyleBackColor = True
        '
        'dglist
        '
        Me.dglist.AllowUserToAddRows = False
        Me.dglist.AllowUserToDeleteRows = False
        Me.dglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dglist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglist.Location = New System.Drawing.Point(481, 61)
        Me.dglist.Name = "dglist"
        Me.dglist.Size = New System.Drawing.Size(795, 462)
        Me.dglist.TabIndex = 4
        Me.dglist.Visible = False
        '
        'btnEditStuDel
        '
        Me.btnEditStuDel.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEditStuDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStuDel.Location = New System.Drawing.Point(108, 278)
        Me.btnEditStuDel.Name = "btnEditStuDel"
        Me.btnEditStuDel.Size = New System.Drawing.Size(206, 50)
        Me.btnEditStuDel.TabIndex = 3
        Me.btnEditStuDel.Text = "Edit Details"
        Me.btnEditStuDel.UseVisualStyleBackColor = False
        '
        'btnSearchStu
        '
        Me.btnSearchStu.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSearchStu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchStu.Location = New System.Drawing.Point(106, 382)
        Me.btnSearchStu.Name = "btnSearchStu"
        Me.btnSearchStu.Size = New System.Drawing.Size(208, 47)
        Me.btnSearchStu.TabIndex = 2
        Me.btnSearchStu.Text = "Search Student"
        Me.btnSearchStu.UseVisualStyleBackColor = False
        '
        'btnAllStu
        '
        Me.btnAllStu.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAllStu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllStu.Location = New System.Drawing.Point(132, 166)
        Me.btnAllStu.Name = "btnAllStu"
        Me.btnAllStu.Size = New System.Drawing.Size(168, 46)
        Me.btnAllStu.TabIndex = 1
        Me.btnAllStu.Text = "All Students"
        Me.btnAllStu.UseVisualStyleBackColor = False
        '
        'btnAddmision
        '
        Me.btnAddmision.BackColor = System.Drawing.Color.SkyBlue
        Me.btnAddmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddmision.Location = New System.Drawing.Point(132, 50)
        Me.btnAddmision.Name = "btnAddmision"
        Me.btnAddmision.Size = New System.Drawing.Size(168, 54)
        Me.btnAddmision.TabIndex = 0
        Me.btnAddmision.Text = "Addmision"
        Me.btnAddmision.UseVisualStyleBackColor = False
        '
        'TabBookD
        '
        Me.TabBookD.BackgroundImage = CType(resources.GetObject("TabBookD.BackgroundImage"), System.Drawing.Image)
        Me.TabBookD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabBookD.Controls.Add(Me.dgstock1)
        Me.TabBookD.Controls.Add(Me.btns)
        Me.TabBookD.Controls.Add(Me.Label1)
        Me.TabBookD.Controls.Add(Me.cmbgid)
        Me.TabBookD.Controls.Add(Me.dgbook)
        Me.TabBookD.Controls.Add(Me.btnIssuedBook)
        Me.TabBookD.Controls.Add(Me.btnStock)
        Me.TabBookD.Controls.Add(Me.btnSearchBook)
        Me.TabBookD.Controls.Add(Me.btnAllBook)
        Me.TabBookD.Controls.Add(Me.btnBookEntery)
        Me.TabBookD.Location = New System.Drawing.Point(4, 33)
        Me.TabBookD.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabBookD.Name = "TabBookD"
        Me.TabBookD.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabBookD.Size = New System.Drawing.Size(1310, 599)
        Me.TabBookD.TabIndex = 2
        Me.TabBookD.Text = "Books Details"
        Me.TabBookD.UseVisualStyleBackColor = True
        '
        'dgstock1
        '
        Me.dgstock1.AllowUserToAddRows = False
        Me.dgstock1.AllowUserToDeleteRows = False
        Me.dgstock1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgstock1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgstock1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgstock1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgstock1.Location = New System.Drawing.Point(750, 131)
        Me.dgstock1.Name = "dgstock1"
        Me.dgstock1.ReadOnly = True
        Me.dgstock1.Size = New System.Drawing.Size(429, 385)
        Me.dgstock1.TabIndex = 9
        '
        'btns
        '
        Me.btns.Location = New System.Drawing.Point(979, 46)
        Me.btns.Name = "btns"
        Me.btns.Size = New System.Drawing.Size(109, 32)
        Me.btns.TabIndex = 8
        Me.btns.Text = "search"
        Me.btns.UseVisualStyleBackColor = True
        Me.btns.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(599, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter Group id:"
        Me.Label1.Visible = False
        '
        'cmbgid
        '
        Me.cmbgid.FormattingEnabled = True
        Me.cmbgid.Location = New System.Drawing.Point(783, 46)
        Me.cmbgid.Name = "cmbgid"
        Me.cmbgid.Size = New System.Drawing.Size(121, 32)
        Me.cmbgid.TabIndex = 6
        Me.cmbgid.Visible = False
        '
        'dgbook
        '
        Me.dgbook.AllowUserToAddRows = False
        Me.dgbook.AllowUserToDeleteRows = False
        Me.dgbook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgbook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbook.Location = New System.Drawing.Point(603, 131)
        Me.dgbook.Name = "dgbook"
        Me.dgbook.ReadOnly = True
        Me.dgbook.Size = New System.Drawing.Size(699, 472)
        Me.dgbook.StandardTab = True
        Me.dgbook.TabIndex = 5
        Me.dgbook.Visible = False
        '
        'btnIssuedBook
        '
        Me.btnIssuedBook.Location = New System.Drawing.Point(36, 367)
        Me.btnIssuedBook.Name = "btnIssuedBook"
        Me.btnIssuedBook.Size = New System.Drawing.Size(214, 47)
        Me.btnIssuedBook.TabIndex = 4
        Me.btnIssuedBook.Text = "Issued Books"
        Me.btnIssuedBook.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.Location = New System.Drawing.Point(289, 366)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(234, 48)
        Me.btnStock.TabIndex = 3
        Me.btnStock.Text = "Books in Stock"
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Location = New System.Drawing.Point(289, 197)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(227, 48)
        Me.btnSearchBook.TabIndex = 2
        Me.btnSearchBook.Text = "Search Book"
        Me.btnSearchBook.UseVisualStyleBackColor = True
        '
        'btnAllBook
        '
        Me.btnAllBook.Location = New System.Drawing.Point(36, 197)
        Me.btnAllBook.Name = "btnAllBook"
        Me.btnAllBook.Size = New System.Drawing.Size(214, 48)
        Me.btnAllBook.TabIndex = 1
        Me.btnAllBook.Text = "All Books"
        Me.btnAllBook.UseVisualStyleBackColor = True
        '
        'btnBookEntery
        '
        Me.btnBookEntery.Location = New System.Drawing.Point(162, 79)
        Me.btnBookEntery.Name = "btnBookEntery"
        Me.btnBookEntery.Size = New System.Drawing.Size(221, 49)
        Me.btnBookEntery.TabIndex = 0
        Me.btnBookEntery.Text = "Book Entry"
        Me.btnBookEntery.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage4.Controls.Add(Me.dgstock)
        Me.TabPage4.Controls.Add(Me.btnStockB)
        Me.TabPage4.Controls.Add(Me.btnReturnB)
        Me.TabPage4.Controls.Add(Me.btnIssueB)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage4.Size = New System.Drawing.Size(1310, 599)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Issue and Return Details"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgstock
        '
        Me.dgstock.AllowUserToAddRows = False
        Me.dgstock.AllowUserToDeleteRows = False
        Me.dgstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgstock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgstock.Location = New System.Drawing.Point(607, 81)
        Me.dgstock.Name = "dgstock"
        Me.dgstock.ReadOnly = True
        Me.dgstock.Size = New System.Drawing.Size(429, 385)
        Me.dgstock.TabIndex = 3
        Me.dgstock.Visible = False
        '
        'btnStockB
        '
        Me.btnStockB.BackColor = System.Drawing.Color.Pink
        Me.btnStockB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockB.Location = New System.Drawing.Point(79, 344)
        Me.btnStockB.Name = "btnStockB"
        Me.btnStockB.Size = New System.Drawing.Size(244, 66)
        Me.btnStockB.TabIndex = 2
        Me.btnStockB.Text = "Stock"
        Me.btnStockB.UseVisualStyleBackColor = False
        '
        'btnReturnB
        '
        Me.btnReturnB.BackColor = System.Drawing.Color.Pink
        Me.btnReturnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnB.Location = New System.Drawing.Point(79, 193)
        Me.btnReturnB.Name = "btnReturnB"
        Me.btnReturnB.Size = New System.Drawing.Size(244, 66)
        Me.btnReturnB.TabIndex = 1
        Me.btnReturnB.Text = "Return"
        Me.btnReturnB.UseVisualStyleBackColor = False
        '
        'btnIssueB
        '
        Me.btnIssueB.BackColor = System.Drawing.Color.Pink
        Me.btnIssueB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueB.Location = New System.Drawing.Point(79, 60)
        Me.btnIssueB.Name = "btnIssueB"
        Me.btnIssueB.Size = New System.Drawing.Size(244, 66)
        Me.btnIssueB.TabIndex = 0
        Me.btnIssueB.Text = "Issue"
        Me.btnIssueB.UseVisualStyleBackColor = False
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Silver
        Me.TabPage5.Location = New System.Drawing.Point(4, 33)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage5.Size = New System.Drawing.Size(1310, 599)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Help"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 636)
        Me.Controls.Add(Me.TabIR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Welcome to LMS"
        Me.TabIR.ResumeLayout(False)
        Me.TabHome.ResumeLayout(False)
        Me.TabStuD.ResumeLayout(False)
        CType(Me.dglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabBookD.ResumeLayout(False)
        Me.TabBookD.PerformLayout()
        CType(Me.dgstock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabIR As System.Windows.Forms.TabControl
    Friend WithEvents TabHome As System.Windows.Forms.TabPage
    Friend WithEvents TabStuD As System.Windows.Forms.TabPage
    Friend WithEvents TabBookD As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents btnAllStu As System.Windows.Forms.Button
    Friend WithEvents btnAddmision As System.Windows.Forms.Button
    Friend WithEvents btnIssuedBook As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents btnSearchBook As System.Windows.Forms.Button
    Friend WithEvents btnAllBook As System.Windows.Forms.Button
    Friend WithEvents btnBookEntery As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnStockB As System.Windows.Forms.Button
    Friend WithEvents btnReturnB As System.Windows.Forms.Button
    Friend WithEvents btnIssueB As System.Windows.Forms.Button
    Friend WithEvents dglist As System.Windows.Forms.DataGridView
    Friend WithEvents dgbook As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbgid As System.Windows.Forms.ComboBox
    Friend WithEvents btns As System.Windows.Forms.Button
    Friend WithEvents dgstock As System.Windows.Forms.DataGridView
    Friend WithEvents dgstock1 As System.Windows.Forms.DataGridView
    Protected WithEvents btnEditStuDel As System.Windows.Forms.Button
    Protected WithEvents btnSearchStu As System.Windows.Forms.Button
End Class
