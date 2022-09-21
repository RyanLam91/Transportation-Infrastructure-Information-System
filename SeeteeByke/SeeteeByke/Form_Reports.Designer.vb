<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Reports
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InvoiceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BikeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceAmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastFourDigitsCCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysRentedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblInvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeeteeByke_DatabaseDataSet = New SeeteeByke.SeeteeByke_DatabaseDataSet()
        Me.TblInvoicesTableAdapter = New SeeteeByke.SeeteeByke_DatabaseDataSetTableAdapters.tblInvoicesTableAdapter()
        Me.btnGoBack5 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeeteeByke_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceIDDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn, Me.BikeIDDataGridViewTextBoxColumn, Me.InvoiceDateDataGridViewTextBoxColumn, Me.InvoiceAmtDataGridViewTextBoxColumn, Me.LastFourDigitsCCDataGridViewTextBoxColumn, Me.ReturnDateDataGridViewTextBoxColumn, Me.DaysRentedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblInvoicesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(843, 336)
        Me.DataGridView1.TabIndex = 0
        '
        'InvoiceIDDataGridViewTextBoxColumn
        '
        Me.InvoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID"
        Me.InvoiceIDDataGridViewTextBoxColumn.HeaderText = "InvoiceID"
        Me.InvoiceIDDataGridViewTextBoxColumn.Name = "InvoiceIDDataGridViewTextBoxColumn"
        Me.InvoiceIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BikeIDDataGridViewTextBoxColumn
        '
        Me.BikeIDDataGridViewTextBoxColumn.DataPropertyName = "BikeID"
        Me.BikeIDDataGridViewTextBoxColumn.HeaderText = "BikeID"
        Me.BikeIDDataGridViewTextBoxColumn.Name = "BikeIDDataGridViewTextBoxColumn"
        Me.BikeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvoiceDateDataGridViewTextBoxColumn
        '
        Me.InvoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate"
        Me.InvoiceDateDataGridViewTextBoxColumn.HeaderText = "InvoiceDate"
        Me.InvoiceDateDataGridViewTextBoxColumn.Name = "InvoiceDateDataGridViewTextBoxColumn"
        Me.InvoiceDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvoiceAmtDataGridViewTextBoxColumn
        '
        Me.InvoiceAmtDataGridViewTextBoxColumn.DataPropertyName = "InvoiceAmt"
        Me.InvoiceAmtDataGridViewTextBoxColumn.HeaderText = "InvoiceAmt"
        Me.InvoiceAmtDataGridViewTextBoxColumn.Name = "InvoiceAmtDataGridViewTextBoxColumn"
        Me.InvoiceAmtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastFourDigitsCCDataGridViewTextBoxColumn
        '
        Me.LastFourDigitsCCDataGridViewTextBoxColumn.DataPropertyName = "LastFourDigitsCC"
        Me.LastFourDigitsCCDataGridViewTextBoxColumn.HeaderText = "LastFourDigitsCC"
        Me.LastFourDigitsCCDataGridViewTextBoxColumn.Name = "LastFourDigitsCCDataGridViewTextBoxColumn"
        Me.LastFourDigitsCCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReturnDateDataGridViewTextBoxColumn
        '
        Me.ReturnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate"
        Me.ReturnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate"
        Me.ReturnDateDataGridViewTextBoxColumn.Name = "ReturnDateDataGridViewTextBoxColumn"
        Me.ReturnDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DaysRentedDataGridViewTextBoxColumn
        '
        Me.DaysRentedDataGridViewTextBoxColumn.DataPropertyName = "DaysRented"
        Me.DaysRentedDataGridViewTextBoxColumn.HeaderText = "DaysRented"
        Me.DaysRentedDataGridViewTextBoxColumn.Name = "DaysRentedDataGridViewTextBoxColumn"
        Me.DaysRentedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblInvoicesBindingSource
        '
        Me.TblInvoicesBindingSource.DataMember = "tblInvoices"
        Me.TblInvoicesBindingSource.DataSource = Me.SeeteeByke_DatabaseDataSet
        '
        'SeeteeByke_DatabaseDataSet
        '
        Me.SeeteeByke_DatabaseDataSet.DataSetName = "SeeteeByke_DatabaseDataSet"
        Me.SeeteeByke_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInvoicesTableAdapter
        '
        Me.TblInvoicesTableAdapter.ClearBeforeFill = True
        '
        'btnGoBack5
        '
        Me.btnGoBack5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack5.Location = New System.Drawing.Point(12, 437)
        Me.btnGoBack5.Name = "btnGoBack5"
        Me.btnGoBack5.Size = New System.Drawing.Size(150, 62)
        Me.btnGoBack5.TabIndex = 66
        Me.btnGoBack5.Text = "Go back"
        Me.btnGoBack5.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(691, 437)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(164, 62)
        Me.btnClose.TabIndex = 67
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnGoBack5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form_Reports"
        Me.Text = "Manage Reports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeeteeByke_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SeeteeByke_DatabaseDataSet As SeeteeByke_DatabaseDataSet
    Friend WithEvents TblInvoicesBindingSource As BindingSource
    Friend WithEvents TblInvoicesTableAdapter As SeeteeByke_DatabaseDataSetTableAdapters.tblInvoicesTableAdapter
    Friend WithEvents InvoiceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BikeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceAmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastFourDigitsCCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DaysRentedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnGoBack5 As Button
    Friend WithEvents btnClose As Button
End Class
