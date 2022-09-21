<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_PersonInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_PersonInfo))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LNameTxtBox = New System.Windows.Forms.TextBox()
        Me.FNameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ZipTxtBox = New System.Windows.Forms.TextBox()
        Me.CityTxtBox = New System.Windows.Forms.TextBox()
        Me.AddressTxtBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PhoneTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGoBack2 = New System.Windows.Forms.Button()
        Me.ContinueBtn = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.picBike = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First Name:"
        '
        'LNameTxtBox
        '
        Me.LNameTxtBox.Enabled = False
        Me.LNameTxtBox.Location = New System.Drawing.Point(195, 71)
        Me.LNameTxtBox.Name = "LNameTxtBox"
        Me.LNameTxtBox.Size = New System.Drawing.Size(170, 20)
        Me.LNameTxtBox.TabIndex = 5
        '
        'FNameTxtBox
        '
        Me.FNameTxtBox.Enabled = False
        Me.FNameTxtBox.Location = New System.Drawing.Point(195, 44)
        Me.FNameTxtBox.Name = "FNameTxtBox"
        Me.FNameTxtBox.Size = New System.Drawing.Size(170, 20)
        Me.FNameTxtBox.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(146, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Zip Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "City:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Residental Address:"
        '
        'ZipTxtBox
        '
        Me.ZipTxtBox.Enabled = False
        Me.ZipTxtBox.Location = New System.Drawing.Point(229, 352)
        Me.ZipTxtBox.Name = "ZipTxtBox"
        Me.ZipTxtBox.Size = New System.Drawing.Size(136, 20)
        Me.ZipTxtBox.TabIndex = 15
        '
        'CityTxtBox
        '
        Me.CityTxtBox.Enabled = False
        Me.CityTxtBox.Location = New System.Drawing.Point(229, 321)
        Me.CityTxtBox.Name = "CityTxtBox"
        Me.CityTxtBox.Size = New System.Drawing.Size(136, 20)
        Me.CityTxtBox.TabIndex = 14
        '
        'AddressTxtBox
        '
        Me.AddressTxtBox.Enabled = False
        Me.AddressTxtBox.Location = New System.Drawing.Point(229, 290)
        Me.AddressTxtBox.Name = "AddressTxtBox"
        Me.AddressTxtBox.Size = New System.Drawing.Size(270, 20)
        Me.AddressTxtBox.TabIndex = 13
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.Enabled = False
        Me.GenderComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female", "Transgender", "Non-binary/non-conforming", "Prefer not to say"})
        Me.GenderComboBox.Location = New System.Drawing.Point(25, 57)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(174, 28)
        Me.GenderComboBox.TabIndex = 46
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GenderComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(72, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 135)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose your Gender:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(342, 161)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 21
        Me.DateTimePicker1.Value = New Date(2022, 5, 17, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(338, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Enter your Date of Birth:"
        '
        'PhoneTxtBox
        '
        Me.PhoneTxtBox.Enabled = False
        Me.PhoneTxtBox.Location = New System.Drawing.Point(342, 233)
        Me.PhoneTxtBox.Name = "PhoneTxtBox"
        Me.PhoneTxtBox.Size = New System.Drawing.Size(176, 20)
        Me.PhoneTxtBox.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(338, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Phone Number:"
        '
        'btnGoBack2
        '
        Me.btnGoBack2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack2.Location = New System.Drawing.Point(12, 437)
        Me.btnGoBack2.Name = "btnGoBack2"
        Me.btnGoBack2.Size = New System.Drawing.Size(150, 62)
        Me.btnGoBack2.TabIndex = 32
        Me.btnGoBack2.Text = "Go back"
        Me.btnGoBack2.UseVisualStyleBackColor = True
        '
        'ContinueBtn
        '
        Me.ContinueBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueBtn.Location = New System.Drawing.Point(408, 437)
        Me.ContinueBtn.Name = "ContinueBtn"
        Me.ContinueBtn.Size = New System.Drawing.Size(164, 62)
        Me.ContinueBtn.TabIndex = 33
        Me.ContinueBtn.Text = "Continue"
        Me.ContinueBtn.UseVisualStyleBackColor = True
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
        'picBike
        '
        Me.picBike.Image = CType(resources.GetObject("picBike.Image"), System.Drawing.Image)
        Me.picBike.Location = New System.Drawing.Point(12, 375)
        Me.picBike.Name = "picBike"
        Me.picBike.Size = New System.Drawing.Size(60, 60)
        Me.picBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBike.TabIndex = 35
        Me.picBike.TabStop = False
        '
        'Form_PersonInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 511)
        Me.Controls.Add(Me.picBike)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.ContinueBtn)
        Me.Controls.Add(Me.btnGoBack2)
        Me.Controls.Add(Me.PhoneTxtBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ZipTxtBox)
        Me.Controls.Add(Me.CityTxtBox)
        Me.Controls.Add(Me.AddressTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LNameTxtBox)
        Me.Controls.Add(Me.FNameTxtBox)
        Me.Name = "Form_PersonInfo"
        Me.Text = "Enter Personal Information"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LNameTxtBox As TextBox
    Friend WithEvents FNameTxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ZipTxtBox As TextBox
    Friend WithEvents CityTxtBox As TextBox
    Friend WithEvents AddressTxtBox As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents PhoneTxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGoBack2 As Button
    Friend WithEvents ContinueBtn As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents picBike As PictureBox
End Class
