<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Confirm_ReturnBike
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Confirm_ReturnBike))
        Me.txtboxTotalCharge = New System.Windows.Forms.TextBox()
        Me.txtboxBikeID = New System.Windows.Forms.TextBox()
        Me.txtboxDaysRented = New System.Windows.Forms.TextBox()
        Me.txtboxEmail = New System.Windows.Forms.TextBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.picBike = New System.Windows.Forms.PictureBox()
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtboxTotalCharge
        '
        Me.txtboxTotalCharge.Enabled = False
        Me.txtboxTotalCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxTotalCharge.Location = New System.Drawing.Point(278, 294)
        Me.txtboxTotalCharge.Name = "txtboxTotalCharge"
        Me.txtboxTotalCharge.Size = New System.Drawing.Size(255, 29)
        Me.txtboxTotalCharge.TabIndex = 21
        '
        'txtboxBikeID
        '
        Me.txtboxBikeID.Enabled = False
        Me.txtboxBikeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxBikeID.Location = New System.Drawing.Point(278, 242)
        Me.txtboxBikeID.Name = "txtboxBikeID"
        Me.txtboxBikeID.Size = New System.Drawing.Size(255, 29)
        Me.txtboxBikeID.TabIndex = 20
        '
        'txtboxDaysRented
        '
        Me.txtboxDaysRented.Enabled = False
        Me.txtboxDaysRented.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxDaysRented.Location = New System.Drawing.Point(278, 206)
        Me.txtboxDaysRented.Name = "txtboxDaysRented"
        Me.txtboxDaysRented.Size = New System.Drawing.Size(255, 29)
        Me.txtboxDaysRented.TabIndex = 19
        '
        'txtboxEmail
        '
        Me.txtboxEmail.Enabled = False
        Me.txtboxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxEmail.Location = New System.Drawing.Point(278, 170)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.Size = New System.Drawing.Size(255, 29)
        Me.txtboxEmail.TabIndex = 18
        '
        'txtboxName
        '
        Me.txtboxName.Enabled = False
        Me.txtboxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxName.Location = New System.Drawing.Point(278, 134)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(255, 29)
        Me.txtboxName.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(135, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(135, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Bike Rented:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Days Rented:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Total Charge:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Billing Summary"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(408, 437)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(164, 62)
        Me.btnClose.TabIndex = 68
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'picBike
        '
        Me.picBike.Image = CType(resources.GetObject("picBike.Image"), System.Drawing.Image)
        Me.picBike.Location = New System.Drawing.Point(4, 445)
        Me.picBike.Name = "picBike"
        Me.picBike.Size = New System.Drawing.Size(70, 70)
        Me.picBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBike.TabIndex = 69
        Me.picBike.TabStop = False
        '
        'Form_Confirm_ReturnBike
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 511)
        Me.Controls.Add(Me.picBike)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtboxTotalCharge)
        Me.Controls.Add(Me.txtboxBikeID)
        Me.Controls.Add(Me.txtboxDaysRented)
        Me.Controls.Add(Me.txtboxEmail)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Confirm_ReturnBike"
        Me.Text = "Billing Summary"
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxTotalCharge As TextBox
    Friend WithEvents txtboxBikeID As TextBox
    Friend WithEvents txtboxDaysRented As TextBox
    Friend WithEvents txtboxEmail As TextBox
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents picBike As PictureBox
End Class
