<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPassw1 = New System.Windows.Forms.TextBox()
        Me.txtPassw2 = New System.Windows.Forms.TextBox()
        Me.txtPassw3 = New System.Windows.Forms.TextBox()
        Me.txtPassw6 = New System.Windows.Forms.TextBox()
        Me.txtPassw5 = New System.Windows.Forms.TextBox()
        Me.txtPassw4 = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.bntGenerete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvPassword = New System.Windows.Forms.DataGridView()
        Me.User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbNumber = New System.Windows.Forms.CheckBox()
        Me.cbLetters = New System.Windows.Forms.CheckBox()
        Me.cbSpecial = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassw1
        '
        Me.txtPassw1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPassw1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassw1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassw1.ForeColor = System.Drawing.Color.White
        Me.txtPassw1.Location = New System.Drawing.Point(36, 78)
        Me.txtPassw1.Name = "txtPassw1"
        Me.txtPassw1.Size = New System.Drawing.Size(40, 41)
        Me.txtPassw1.TabIndex = 0
        Me.txtPassw1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassw2
        '
        Me.txtPassw2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPassw2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassw2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassw2.ForeColor = System.Drawing.Color.White
        Me.txtPassw2.Location = New System.Drawing.Point(88, 78)
        Me.txtPassw2.Name = "txtPassw2"
        Me.txtPassw2.Size = New System.Drawing.Size(40, 41)
        Me.txtPassw2.TabIndex = 1
        Me.txtPassw2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassw3
        '
        Me.txtPassw3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPassw3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassw3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassw3.ForeColor = System.Drawing.Color.White
        Me.txtPassw3.Location = New System.Drawing.Point(140, 78)
        Me.txtPassw3.Name = "txtPassw3"
        Me.txtPassw3.Size = New System.Drawing.Size(40, 41)
        Me.txtPassw3.TabIndex = 2
        Me.txtPassw3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassw6
        '
        Me.txtPassw6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPassw6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassw6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassw6.ForeColor = System.Drawing.Color.White
        Me.txtPassw6.Location = New System.Drawing.Point(299, 78)
        Me.txtPassw6.Name = "txtPassw6"
        Me.txtPassw6.Size = New System.Drawing.Size(40, 41)
        Me.txtPassw6.TabIndex = 3
        Me.txtPassw6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassw5
        '
        Me.txtPassw5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPassw5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassw5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassw5.ForeColor = System.Drawing.Color.White
        Me.txtPassw5.Location = New System.Drawing.Point(245, 78)
        Me.txtPassw5.Name = "txtPassw5"
        Me.txtPassw5.Size = New System.Drawing.Size(40, 41)
        Me.txtPassw5.TabIndex = 4
        Me.txtPassw5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassw4
        '
        Me.txtPassw4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtPassw4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassw4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassw4.ForeColor = System.Drawing.Color.White
        Me.txtPassw4.Location = New System.Drawing.Point(194, 78)
        Me.txtPassw4.Name = "txtPassw4"
        Me.txtPassw4.Size = New System.Drawing.Size(40, 41)
        Me.txtPassw4.TabIndex = 5
        Me.txtPassw4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(36, 41)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(303, 22)
        Me.txtUser.TabIndex = 6
        '
        'lbUser
        '
        Me.lbUser.AutoSize = True
        Me.lbUser.ForeColor = System.Drawing.Color.White
        Me.lbUser.Location = New System.Drawing.Point(33, 22)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(36, 16)
        Me.lbUser.TabIndex = 7
        Me.lbUser.Text = "User"
        '
        'bntGenerete
        '
        Me.bntGenerete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntGenerete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.bntGenerete.Location = New System.Drawing.Point(36, 135)
        Me.bntGenerete.Name = "bntGenerete"
        Me.bntGenerete.Size = New System.Drawing.Size(131, 37)
        Me.bntGenerete.TabIndex = 8
        Me.bntGenerete.Text = "Generete"
        Me.bntGenerete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(263, 135)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 37)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dgvPassword
        '
        Me.dgvPassword.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPassword.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPassword.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.User, Me.Password})
        Me.dgvPassword.GridColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.dgvPassword.Location = New System.Drawing.Point(36, 284)
        Me.dgvPassword.Name = "dgvPassword"
        Me.dgvPassword.RowHeadersWidth = 51
        Me.dgvPassword.RowTemplate.Height = 24
        Me.dgvPassword.Size = New System.Drawing.Size(303, 381)
        Me.dgvPassword.TabIndex = 10
        '
        'User
        '
        Me.User.HeaderText = "User"
        Me.User.MinimumWidth = 6
        Me.User.Name = "User"
        Me.User.Width = 80
        '
        'Password
        '
        Me.Password.HeaderText = "Password"
        Me.Password.MinimumWidth = 6
        Me.Password.Name = "Password"
        Me.Password.Width = 125
        '
        'cbNumber
        '
        Me.cbNumber.AutoSize = True
        Me.cbNumber.ForeColor = System.Drawing.Color.White
        Me.cbNumber.Location = New System.Drawing.Point(36, 194)
        Me.cbNumber.Name = "cbNumber"
        Me.cbNumber.Size = New System.Drawing.Size(84, 20)
        Me.cbNumber.TabIndex = 11
        Me.cbNumber.Text = "Numbers"
        Me.cbNumber.UseVisualStyleBackColor = True
        '
        'cbLetters
        '
        Me.cbLetters.AutoSize = True
        Me.cbLetters.ForeColor = System.Drawing.Color.White
        Me.cbLetters.Location = New System.Drawing.Point(131, 194)
        Me.cbLetters.Name = "cbLetters"
        Me.cbLetters.Size = New System.Drawing.Size(69, 20)
        Me.cbLetters.TabIndex = 12
        Me.cbLetters.Text = "Letters"
        Me.cbLetters.UseVisualStyleBackColor = True
        '
        'cbSpecial
        '
        Me.cbSpecial.AutoSize = True
        Me.cbSpecial.ForeColor = System.Drawing.Color.White
        Me.cbSpecial.Location = New System.Drawing.Point(215, 194)
        Me.cbSpecial.Name = "cbSpecial"
        Me.cbSpecial.Size = New System.Drawing.Size(141, 20)
        Me.cbSpecial.TabIndex = 13
        Me.cbSpecial.Text = "Special charecters"
        Me.cbSpecial.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Format of the password:"
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Location = New System.Drawing.Point(255, 243)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(84, 35)
        Me.btnDeleteAll.TabIndex = 15
        Me.btnDeleteAll.Text = "Delete All"
        Me.btnDeleteAll.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(36, 243)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 35)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(379, 691)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnDeleteAll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbSpecial)
        Me.Controls.Add(Me.cbLetters)
        Me.Controls.Add(Me.cbNumber)
        Me.Controls.Add(Me.dgvPassword)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.bntGenerete)
        Me.Controls.Add(Me.lbUser)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPassw4)
        Me.Controls.Add(Me.txtPassw5)
        Me.Controls.Add(Me.txtPassw6)
        Me.Controls.Add(Me.txtPassw3)
        Me.Controls.Add(Me.txtPassw2)
        Me.Controls.Add(Me.txtPassw1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPassw1 As TextBox
    Friend WithEvents txtPassw2 As TextBox
    Friend WithEvents txtPassw3 As TextBox
    Friend WithEvents txtPassw6 As TextBox
    Friend WithEvents txtPassw5 As TextBox
    Friend WithEvents txtPassw4 As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lbUser As Label
    Friend WithEvents bntGenerete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvPassword As DataGridView
    Friend WithEvents cbNumber As CheckBox
    Friend WithEvents cbLetters As CheckBox
    Friend WithEvents cbSpecial As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents User As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteAll As Button
    Friend WithEvents btnDelete As Button
End Class
