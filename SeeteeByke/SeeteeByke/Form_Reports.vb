Imports System.Data.OleDb
Imports System.Data

Public Class Form_Reports
    Private Sub Form_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SeeteeByke_DatabaseDataSet.tblInvoices' table. You can move, or remove it, as needed.
        TblInvoicesTableAdapter.Fill(SeeteeByke_DatabaseDataSet.tblInvoices)

    End Sub

    Private Sub btnGoBack5_Click(sender As Object, e As EventArgs) Handles btnGoBack5.Click
        Me.Hide()
        Form_LogIn.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Form_LogIn.Close()
        Me.Close()
    End Sub
End Class