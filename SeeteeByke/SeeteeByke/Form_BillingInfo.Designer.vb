<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BillingInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BillingInfo))
        Me.ZipCodeTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SecurityCodeTxtBox = New System.Windows.Forms.TextBox()
        Me.ExpDateTextBox = New System.Windows.Forms.TextBox()
        Me.CardNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnGoBack4 = New System.Windows.Forms.Button()
        Me.ContinueBtn4 = New System.Windows.Forms.Button()
        Me.picBike = New System.Windows.Forms.PictureBox()
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ZipCodeTxtBox
        '
        Me.ZipCodeTxtBox.Enabled = False
        Me.ZipCodeTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipCodeTxtBox.Location = New System.Drawing.Point(249, 283)
        Me.ZipCodeTxtBox.Name = "ZipCodeTxtBox"
        Me.ZipCodeTxtBox.Size = New System.Drawing.Size(135, 26)
        Me.ZipCodeTxtBox.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Zip Code:"
        '
        'SecurityCodeTxtBox
        '
        Me.SecurityCodeTxtBox.Enabled = False
        Me.SecurityCodeTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityCodeTxtBox.Location = New System.Drawing.Point(249, 236)
        Me.SecurityCodeTxtBox.Name = "SecurityCodeTxtBox"
        Me.SecurityCodeTxtBox.Size = New System.Drawing.Size(135, 26)
        Me.SecurityCodeTxtBox.TabIndex = 31
        '
        'ExpDateTextBox
        '
        Me.ExpDateTextBox.Enabled = False
        Me.ExpDateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpDateTextBox.Location = New System.Drawing.Point(249, 186)
        Me.ExpDateTextBox.Name = "ExpDateTextBox"
        Me.ExpDateTextBox.Size = New System.Drawing.Size(135, 26)
        Me.ExpDateTextBox.TabIndex = 30
        '
        'CardNumberTxtBox
        '
        Me.CardNumberTxtBox.Enabled = False
        Me.CardNumberTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardNumberTxtBox.Location = New System.Drawing.Point(249, 142)
        Me.CardNumberTxtBox.Name = "CardNumberTxtBox"
        Me.CardNumberTxtBox.Size = New System.Drawing.Size(226, 26)
        Me.CardNumberTxtBox.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Enter Security Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Enter Card Exp Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Enter your Card Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Billing Information:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(497, 12)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 55)
        Me.btnUpdate.TabIndex = 34
        Me.btnUpdate.Text = "Update Personal Information"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnGoBack4
        '
        Me.btnGoBack4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack4.Location = New System.Drawing.Point(12, 437)
        Me.btnGoBack4.Name = "btnGoBack4"
        Me.btnGoBack4.Size = New System.Drawing.Size(150, 62)
        Me.btnGoBack4.TabIndex = 36
        Me.btnGoBack4.Text = "Go back"
        Me.btnGoBack4.UseVisualStyleBackColor = True
        '
        'ContinueBtn4
        '
        Me.ContinueBtn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueBtn4.Location = New System.Drawing.Point(408, 437)
        Me.ContinueBtn4.Name = "ContinueBtn4"
        Me.ContinueBtn4.Size = New System.Drawing.Size(164, 62)
        Me.ContinueBtn4.TabIndex = 35
        Me.ContinueBtn4.Text = "Continue"
        Me.ContinueBtn4.UseVisualStyleBackColor = True
        '
        'picBike
        '
        Me.picBike.Image = CType(resources.GetObject("picBike.Image"), System.Drawing.Image)
        Me.picBike.Location = New System.Drawing.Point(12, 374)
        Me.picBike.Name = "picBike"
        Me.picBike.Size = New System.Drawing.Size(60, 60)
        Me.picBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBike.TabIndex = 37
        Me.picBike.TabStop = False
        '
        'Form_BillingInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 511)
        Me.Controls.Add(Me.picBike)
        Me.Controls.Add(Me.btnGoBack4)
        Me.Controls.Add(Me.ContinueBtn4)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.ZipCodeTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SecurityCodeTxtBox)
        Me.Controls.Add(Me.ExpDateTextBox)
        Me.Controls.Add(Me.CardNumberTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_BillingInfo"
        Me.Text = "Enter Card Information"
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ZipCodeTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SecurityCodeTxtBox As TextBox
    Friend WithEvents ExpDateTextBox As TextBox
    Friend WithEvents CardNumberTxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnGoBack4 As Button
    Friend WithEvents ContinueBtn4 As Button
    Friend WithEvents picBike As PictureBox
End Class
