<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ReturnBike
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ReturnBike))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnGoBack4 = New System.Windows.Forms.Button()
        Me.picBike = New System.Windows.Forms.PictureBox()
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(204, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Spots Available:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "spots available at the bike station"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(552, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome back, check down below for how many parking"
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(457, 424)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(115, 75)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm Return"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnGoBack4
        '
        Me.btnGoBack4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack4.Location = New System.Drawing.Point(12, 437)
        Me.btnGoBack4.Name = "btnGoBack4"
        Me.btnGoBack4.Size = New System.Drawing.Size(150, 62)
        Me.btnGoBack4.TabIndex = 37
        Me.btnGoBack4.Text = "Go back"
        Me.btnGoBack4.UseVisualStyleBackColor = True
        '
        'picBike
        '
        Me.picBike.Image = CType(resources.GetObject("picBike.Image"), System.Drawing.Image)
        Me.picBike.Location = New System.Drawing.Point(12, 366)
        Me.picBike.Name = "picBike"
        Me.picBike.Size = New System.Drawing.Size(70, 70)
        Me.picBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBike.TabIndex = 71
        Me.picBike.TabStop = False
        '
        'Form_ReturnBike
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 511)
        Me.Controls.Add(Me.picBike)
        Me.Controls.Add(Me.btnGoBack4)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_ReturnBike"
        Me.Text = "Return Your Bike!"
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnGoBack4 As Button
    Friend WithEvents picBike As PictureBox
End Class
