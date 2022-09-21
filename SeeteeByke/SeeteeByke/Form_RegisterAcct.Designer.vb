<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_RegisterAcct
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
        Me.TxtSecurityCode = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCardExpDate = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSignUpBackButton = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSignUpCreditCard = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSignUpPhone = New System.Windows.Forms.TextBox()
        Me.txtSignUpZip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSignUpCity = New System.Windows.Forms.TextBox()
        Me.txtSignUpAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSignUpPassword = New System.Windows.Forms.TextBox()
        Me.txtSignUpEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSignUpLastName = New System.Windows.Forms.TextBox()
        Me.txtSignUpFirstName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtSecurityCode
        '
        Me.TxtSecurityCode.Location = New System.Drawing.Point(377, 350)
        Me.TxtSecurityCode.Name = "TxtSecurityCode"
        Me.TxtSecurityCode.Size = New System.Drawing.Size(58, 20)
        Me.TxtSecurityCode.TabIndex = 91
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(295, 353)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Security Code:"
        '
        'txtCardExpDate
        '
        Me.txtCardExpDate.Location = New System.Drawing.Point(221, 350)
        Me.txtCardExpDate.Name = "txtCardExpDate"
        Me.txtCardExpDate.Size = New System.Drawing.Size(58, 20)
        Me.txtCardExpDate.TabIndex = 89
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(136, 353)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "Card Exp Date:"
        '
        'btnSignUpBackButton
        '
        Me.btnSignUpBackButton.Location = New System.Drawing.Point(12, 476)
        Me.btnSignUpBackButton.Name = "btnSignUpBackButton"
        Me.btnSignUpBackButton.Size = New System.Drawing.Size(75, 23)
        Me.btnSignUpBackButton.TabIndex = 87
        Me.btnSignUpBackButton.Text = "< Back"
        Me.btnSignUpBackButton.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(220, 184)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 20)
        Me.DateTimePicker1.TabIndex = 73
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Transgender", "Non-binary/non-conforming", "Prefer not to say"})
        Me.ComboBox1.Location = New System.Drawing.Point(220, 210)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(174, 21)
        Me.ComboBox1.TabIndex = 75
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(167, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "DOB:"
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(220, 395)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(174, 31)
        Me.btnSignUp.TabIndex = 77
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(155, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Gender:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(253, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "It's quick and easy!"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(261, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 24)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Sign Up"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(153, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Credit #:"
        '
        'txtSignUpCreditCard
        '
        Me.txtSignUpCreditCard.Location = New System.Drawing.Point(220, 317)
        Me.txtSignUpCreditCard.Name = "txtSignUpCreditCard"
        Me.txtSignUpCreditCard.Size = New System.Drawing.Size(174, 20)
        Me.txtSignUpCreditCard.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(159, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Phone:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(298, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Zip:"
        '
        'txtSignUpPhone
        '
        Me.txtSignUpPhone.Location = New System.Drawing.Point(220, 291)
        Me.txtSignUpPhone.Name = "txtSignUpPhone"
        Me.txtSignUpPhone.Size = New System.Drawing.Size(174, 20)
        Me.txtSignUpPhone.TabIndex = 71
        '
        'txtSignUpZip
        '
        Me.txtSignUpZip.Location = New System.Drawing.Point(329, 265)
        Me.txtSignUpZip.Name = "txtSignUpZip"
        Me.txtSignUpZip.Size = New System.Drawing.Size(65, 20)
        Me.txtSignUpZip.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "City:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(152, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Address:"
        '
        'txtSignUpCity
        '
        Me.txtSignUpCity.Location = New System.Drawing.Point(220, 265)
        Me.txtSignUpCity.Name = "txtSignUpCity"
        Me.txtSignUpCity.Size = New System.Drawing.Size(72, 20)
        Me.txtSignUpCity.TabIndex = 67
        '
        'txtSignUpAddress
        '
        Me.txtSignUpAddress.Location = New System.Drawing.Point(220, 242)
        Me.txtSignUpAddress.Name = "txtSignUpAddress"
        Me.txtSignUpAddress.Size = New System.Drawing.Size(174, 20)
        Me.txtSignUpAddress.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Email:"
        '
        'txtSignUpPassword
        '
        Me.txtSignUpPassword.Location = New System.Drawing.Point(220, 158)
        Me.txtSignUpPassword.Name = "txtSignUpPassword"
        Me.txtSignUpPassword.Size = New System.Drawing.Size(174, 20)
        Me.txtSignUpPassword.TabIndex = 65
        '
        'txtSignUpEmail
        '
        Me.txtSignUpEmail.Location = New System.Drawing.Point(220, 135)
        Me.txtSignUpEmail.Name = "txtSignUpEmail"
        Me.txtSignUpEmail.Size = New System.Drawing.Size(174, 20)
        Me.txtSignUpEmail.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Last name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "First name:"
        '
        'txtSignUpLastName
        '
        Me.txtSignUpLastName.Location = New System.Drawing.Point(220, 112)
        Me.txtSignUpLastName.Name = "txtSignUpLastName"
        Me.txtSignUpLastName.Size = New System.Drawing.Size(174, 20)
        Me.txtSignUpLastName.TabIndex = 63
        '
        'txtSignUpFirstName
        '
        Me.txtSignUpFirstName.Location = New System.Drawing.Point(220, 89)
        Me.txtSignUpFirstName.Name = "txtSignUpFirstName"
        Me.txtSignUpFirstName.Size = New System.Drawing.Size(174, 20)
        Me.txtSignUpFirstName.TabIndex = 62
        '
        'Form_RegisterAcct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 511)
        Me.Controls.Add(Me.TxtSecurityCode)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCardExpDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnSignUpBackButton)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSignUpCreditCard)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSignUpPhone)
        Me.Controls.Add(Me.txtSignUpZip)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSignUpCity)
        Me.Controls.Add(Me.txtSignUpAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSignUpPassword)
        Me.Controls.Add(Me.txtSignUpEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSignUpLastName)
        Me.Controls.Add(Me.txtSignUpFirstName)
        Me.Name = "Form_RegisterAcct"
        Me.Text = "Register Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSecurityCode As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCardExpDate As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSignUpBackButton As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSignUpCreditCard As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSignUpPhone As TextBox
    Friend WithEvents txtSignUpZip As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSignUpCity As TextBox
    Friend WithEvents txtSignUpAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSignUpPassword As TextBox
    Friend WithEvents txtSignUpEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSignUpLastName As TextBox
    Friend WithEvents txtSignUpFirstName As TextBox
End Class
