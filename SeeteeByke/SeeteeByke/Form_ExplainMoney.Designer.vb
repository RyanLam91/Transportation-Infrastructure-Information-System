<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ExplainMoney
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ExplainMoney))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGoBack3 = New System.Windows.Forms.Button()
        Me.ContinueBtn3 = New System.Windows.Forms.Button()
        Me.picBike = New System.Windows.Forms.PictureBox()
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(460, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Each additional 24 hours will be an extra $2.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(497, 25)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "SeeteeByke charges per day, with an initial charge"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "How we make money!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 25)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "of $1.00"
        '
        'btnGoBack3
        '
        Me.btnGoBack3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack3.Location = New System.Drawing.Point(12, 437)
        Me.btnGoBack3.Name = "btnGoBack3"
        Me.btnGoBack3.Size = New System.Drawing.Size(150, 62)
        Me.btnGoBack3.TabIndex = 33
        Me.btnGoBack3.Text = "Go back"
        Me.btnGoBack3.UseVisualStyleBackColor = True
        '
        'ContinueBtn3
        '
        Me.ContinueBtn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueBtn3.Location = New System.Drawing.Point(408, 437)
        Me.ContinueBtn3.Name = "ContinueBtn3"
        Me.ContinueBtn3.Size = New System.Drawing.Size(164, 62)
        Me.ContinueBtn3.TabIndex = 34
        Me.ContinueBtn3.Text = "Continue"
        Me.ContinueBtn3.UseVisualStyleBackColor = True
        '
        'picBike
        '
        Me.picBike.Image = CType(resources.GetObject("picBike.Image"), System.Drawing.Image)
        Me.picBike.Location = New System.Drawing.Point(12, 374)
        Me.picBike.Name = "picBike"
        Me.picBike.Size = New System.Drawing.Size(60, 60)
        Me.picBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBike.TabIndex = 36
        Me.picBike.TabStop = False
        '
        'Form_ExplainMoney
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 511)
        Me.Controls.Add(Me.picBike)
        Me.Controls.Add(Me.ContinueBtn3)
        Me.Controls.Add(Me.btnGoBack3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_ExplainMoney"
        Me.Text = "How we make Money"
        CType(Me.picBike, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGoBack3 As Button
    Friend WithEvents ContinueBtn3 As Button
    Friend WithEvents picBike As PictureBox
End Class
