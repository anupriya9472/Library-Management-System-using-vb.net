<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnIssue = New System.Windows.Forms.Button
        Me.txtStuId = New System.Windows.Forms.TextBox
        Me.idate = New System.Windows.Forms.DateTimePicker
        Me.txtgid = New System.Windows.Forms.TextBox
        Me.cmbbid = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Group Id:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date:"
        '
        'btnIssue
        '
        Me.btnIssue.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnIssue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssue.Location = New System.Drawing.Point(198, 284)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(135, 40)
        Me.btnIssue.TabIndex = 4
        Me.btnIssue.Text = "Issue"
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'txtStuId
        '
        Me.txtStuId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStuId.Location = New System.Drawing.Point(292, 62)
        Me.txtStuId.Name = "txtStuId"
        Me.txtStuId.Size = New System.Drawing.Size(162, 29)
        Me.txtStuId.TabIndex = 6
        '
        'idate
        '
        Me.idate.Location = New System.Drawing.Point(292, 228)
        Me.idate.Name = "idate"
        Me.idate.Size = New System.Drawing.Size(162, 20)
        Me.idate.TabIndex = 8
        '
        'txtgid
        '
        Me.txtgid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgid.Location = New System.Drawing.Point(292, 169)
        Me.txtgid.Name = "txtgid"
        Me.txtgid.Size = New System.Drawing.Size(162, 29)
        Me.txtgid.TabIndex = 9
        '
        'cmbbid
        '
        Me.cmbbid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbid.FormattingEnabled = True
        Me.cmbbid.Location = New System.Drawing.Point(292, 116)
        Me.cmbbid.Name = "cmbbid"
        Me.cmbbid.Size = New System.Drawing.Size(162, 32)
        Me.cmbbid.TabIndex = 10
        '
        'Form13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(568, 381)
        Me.Controls.Add(Me.cmbbid)
        Me.Controls.Add(Me.txtgid)
        Me.Controls.Add(Me.idate)
        Me.Controls.Add(Me.txtStuId)
        Me.Controls.Add(Me.btnIssue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form13"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter all Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents txtStuId As System.Windows.Forms.TextBox
    Friend WithEvents idate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtgid As System.Windows.Forms.TextBox
    Friend WithEvents cmbbid As System.Windows.Forms.ComboBox
End Class
