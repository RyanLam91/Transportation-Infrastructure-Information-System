<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ConfirmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ConfirmInfo))
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.ZIPCODETXT = New System.Windows.Forms.TextBox()
        Me.zipcodelbl = New System.Windows.Forms.Label()
        Me.CityTXT = New System.Windows.Forms.TextBox()
        Me.citylbl = New System.Windows.Forms.Label()
        Me.DobTXT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CCNumberTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddressTXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LnameTXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FnameTXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGoBack5 = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtBox_DisplayBike = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.picBike = New System.Windows.Forms.PictureBox()
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.Enabled = False
        Me.GenderComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female", "Transgender", "Non-binary/non-conforming", "Prefer not to say"})
        Me.GenderComboBox.Location = New System.Drawing.Point(139, 164)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(174, 28)
        Me.GenderComboBox.TabIndex = 64
        '
        'ZIPCODETXT
        '
        Me.ZIPCODETXT.Enabled = False
        Me.ZIPCODETXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZIPCODETXT.Location = New System.Drawing.Point(139, 370)
        Me.ZIPCODETXT.Name = "ZIPCODETXT"
        Me.ZIPCODETXT.Size = New System.Drawing.Size(107, 29)
        Me.ZIPCODETXT.TabIndex = 63
        '
        'zipcodelbl
        '
        Me.zipcodelbl.AutoSize = True
        Me.zipcodelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zipcodelbl.Location = New System.Drawing.Point(40, 373)
        Me.zipcodelbl.Name = "zipcodelbl"
        Me.zipcodelbl.Size = New System.Drawing.Size(93, 24)
        Me.zipcodelbl.TabIndex = 62
        Me.zipcodelbl.Text = "Zip Code:"
        '
        'CityTXT
        '
        Me.CityTXT.Enabled = False
        Me.CityTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTXT.Location = New System.Drawing.Point(139, 286)
        Me.CityTXT.Name = "CityTXT"
        Me.CityTXT.Size = New System.Drawing.Size(256, 29)
        Me.CityTXT.TabIndex = 61
        '
        'citylbl
        '
        Me.citylbl.AutoSize = True
        Me.citylbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.citylbl.Location = New System.Drawing.Point(18, 287)
        Me.citylbl.Name = "citylbl"
        Me.citylbl.Size = New System.Drawing.Size(45, 24)
        Me.citylbl.TabIndex = 60
        Me.citylbl.Text = "City:"
        '
        'DobTXT
        '
        Me.DobTXT.Enabled = False
        Me.DobTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DobTXT.Location = New System.Drawing.Point(139, 204)
        Me.DobTXT.Name = "DobTXT"
        Me.DobTXT.Size = New System.Drawing.Size(187, 29)
        Me.DobTXT.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 24)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Date of Birth:"
        '
        'CCNumberTxtBox
        '
        Me.CCNumberTxtBox.Enabled = False
        Me.CCNumberTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCNumberTxtBox.Location = New System.Drawing.Point(139, 330)
        Me.CCNumberTxtBox.Name = "CCNumberTxtBox"
        Me.CCNumberTxtBox.Size = New System.Drawing.Size(187, 29)
        Me.CCNumberTxtBox.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 24)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Card Number:"
        '
        'AddressTXT
        '
        Me.AddressTXT.Enabled = False
        Me.AddressTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTXT.Location = New System.Drawing.Point(139, 245)
        Me.AddressTXT.Name = "AddressTXT"
        Me.AddressTXT.Size = New System.Drawing.Size(256, 29)
        Me.AddressTXT.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 24)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Gender:"
        '
        'LnameTXT
        '
        Me.LnameTXT.Enabled = False
        Me.LnameTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnameTXT.Location = New System.Drawing.Point(139, 123)
        Me.LnameTXT.Name = "LnameTXT"
        Me.LnameTXT.Size = New System.Drawing.Size(187, 29)
        Me.LnameTXT.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Last Name:"
        '
        'FnameTXT
        '
        Me.FnameTXT.Enabled = False
        Me.FnameTXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FnameTXT.Location = New System.Drawing.Point(139, 82)
        Me.FnameTXT.Name = "FnameTXT"
        Me.FnameTXT.Size = New System.Drawing.Size(187, 29)
        Me.FnameTXT.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 33)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Is this Information Correct?"
        '
        'btnGoBack5
        '
        Me.btnGoBack5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack5.Location = New System.Drawing.Point(12, 437)
        Me.btnGoBack5.Name = "btnGoBack5"
        Me.btnGoBack5.Size = New System.Drawing.Size(150, 62)
        Me.btnGoBack5.TabIndex = 65
        Me.btnGoBack5.Text = "Go back"
        Me.btnGoBack5.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(408, 437)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(164, 62)
        Me.btnConfirm.TabIndex = 66
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtBox_DisplayBike
        '
        Me.txtBox_DisplayBike.Enabled = False
        Me.txtBox_DisplayBike.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_DisplayBike.Location = New System.Drawing.Point(474, 118)
        Me.txtBox_DisplayBike.Name = "txtBox_DisplayBike"
        Me.txtBox_DisplayBike.Size = New System.Drawing.Size(92, 29)
        Me.txtBox_DisplayBike.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(380, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 24)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "You are going to take: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(386, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 24)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Bike #:"
        '
        'picBike
        '
        Me.picBike.Image = CType(resources.GetObject("picBike.Image"), System.Drawing.Image)
        Me.picBike.Location = New System.Drawing.Point(12, 400)
        Me.picBike.Name = "picBike"
        Me.picBike.Size = New System.Drawing.Size(35, 35)
        Me.picBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBike.TabIndex = 70
        Me.picBike.TabStop = False
        '
        'Form_ConfirmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 511)
        Me.Controls.Add(Me.picBike)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBox_DisplayBike)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnGoBack5)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.ZIPCODETXT)
        Me.Controls.Add(Me.zipcodelbl)
        Me.Controls.Add(Me.CityTXT)
        Me.Controls.Add(Me.citylbl)
        Me.Controls.Add(Me.DobTXT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CCNumberTxtBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AddressTXT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LnameTXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FnameTXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_ConfirmInfo"
        Me.Text = "Confirm your Information"
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents ZIPCODETXT As TextBox
    Friend WithEvents zipcodelbl As Label
    Friend WithEvents CityTXT As TextBox
    Friend WithEvents citylbl As Label
    Friend WithEvents DobTXT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CCNumberTxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AddressTXT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LnameTXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FnameTXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGoBack5 As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtBox_DisplayBike As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents picBike As PictureBox
End Class
