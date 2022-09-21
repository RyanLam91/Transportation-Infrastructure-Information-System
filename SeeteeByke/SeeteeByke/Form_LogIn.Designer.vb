<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_LogIn))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.txtPasswordLogIn = New System.Windows.Forms.TextBox()
        Me.txtEmailLogIn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReturnBikeBtn = New System.Windows.Forms.Button()
        Me.RentBikeBtn = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.picBike = New System.Windows.Forms.PictureBox()
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "You are now logged in!"
        Me.Label3.Visible = False
        '
        'btnSignUp
        '
        Me.btnSignUp.Location = New System.Drawing.Point(475, 45)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(75, 23)
        Me.btnSignUp.TabIndex = 16
        Me.btnSignUp.Text = "Register"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(475, 16)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogIn.TabIndex = 15
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'txtPasswordLogIn
        '
        Me.txtPasswordLogIn.Location = New System.Drawing.Point(312, 32)
        Me.txtPasswordLogIn.Name = "txtPasswordLogIn"
        Me.txtPasswordLogIn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordLogIn.Size = New System.Drawing.Size(119, 20)
        Me.txtPasswordLogIn.TabIndex = 14
        '
        'txtEmailLogIn
        '
        Me.txtEmailLogIn.Location = New System.Drawing.Point(99, 32)
        Me.txtEmailLogIn.Name = "txtEmailLogIn"
        Me.txtEmailLogIn.Size = New System.Drawing.Size(127, 20)
        Me.txtEmailLogIn.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username:"
        '
        'ReturnBikeBtn
        '
        Me.ReturnBikeBtn.Enabled = False
        Me.ReturnBikeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnBikeBtn.Location = New System.Drawing.Point(140, 287)
        Me.ReturnBikeBtn.Name = "ReturnBikeBtn"
        Me.ReturnBikeBtn.Size = New System.Drawing.Size(305, 132)
        Me.ReturnBikeBtn.TabIndex = 10
        Me.ReturnBikeBtn.Text = "Return Bike"
        Me.ReturnBikeBtn.UseVisualStyleBackColor = True
        '
        'RentBikeBtn
        '
        Me.RentBikeBtn.Enabled = False
        Me.RentBikeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentBikeBtn.Location = New System.Drawing.Point(140, 137)
        Me.RentBikeBtn.Name = "RentBikeBtn"
        Me.RentBikeBtn.Size = New System.Drawing.Size(305, 132)
        Me.RentBikeBtn.TabIndex = 9
        Me.RentBikeBtn.Text = "Rent Bike"
        Me.RentBikeBtn.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(497, 476)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(75, 23)
        Me.btnReports.TabIndex = 18
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'picBike
        '
        Me.picBike.Image = CType(resources.GetObject("picBike.Image"), System.Drawing.Image)
        Me.picBike.Location = New System.Drawing.Point(-2, 457)
        Me.picBike.Name = "picBike"
        Me.picBike.Size = New System.Drawing.Size(70, 70)
        Me.picBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBike.TabIndex = 19
        Me.picBike.TabStop = False
        '
        'Form_LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 511)
        Me.Controls.Add(Me.picBike)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPasswordLogIn)
        Me.Controls.Add(Me.txtEmailLogIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReturnBikeBtn)
        Me.Controls.Add(Me.RentBikeBtn)
        Me.Name = "Form_LogIn"
        Me.Text = "Rent/Return"
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents txtPasswordLogIn As TextBox
    Friend WithEvents txtEmailLogIn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReturnBikeBtn As Button
    Friend WithEvents RentBikeBtn As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents picBike As PictureBox
End Class
