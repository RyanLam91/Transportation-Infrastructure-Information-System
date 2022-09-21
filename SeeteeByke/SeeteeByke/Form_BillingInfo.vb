Imports System.Data.OleDb
Imports System.Data


Public Class Form_BillingInfo

    Dim myConnection As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim stmt As String

    Public CardNumber, ExpDate, SecurityCode, ZipCode As String

    Private Sub ContinueBtn4_Click(sender As Object, e As EventArgs) Handles ContinueBtn4.Click
        CardNumber = CardNumberTxtBox.Text()
        ExpDate = ExpDateTextBox.Text()
        SecurityCode = SecurityCodeTxtBox.Text()
        ZipCode = ZipCodeTxtBox.Text()

        If CardNumber.Length <> 16 Then
            MessageBox.Show("Credit/Debit card should has 16 numbers only!")
            Return
        End If

        Dim myConnection4 As New OleDbConnection
        Dim cmd2 As New OleDbCommand
        Dim stmt2 As String

        myConnection4.ConnectionString = Form_LogIn.connString
        myConnection4.Open()
        stmt2 = "Update tblUserData Set [CreditCard]='" & CardNumber & "',
                                        [CardExpDate]='" & ExpDate & "',
                                        [SecurityCode]='" & SecurityCode & "',
                                        [Zip]='" & ZipCode & "'
                                    Where Email='" & Form_LogIn.strUserEmail & "'"
        cmd2 = New OleDbCommand(stmt2, myConnection4)

        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myConnection4.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim fin As Integer = Me.Width - picBike.Width - 15
        For i As Integer = 0 To fin
            For j As Integer = 0 To 10000
                picBike.SetBounds(i, picBike.Location.Y, picBike.Width, picBike.Height)
            Next
        Next


        Me.Hide()
        Form_ConfirmInfo.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ZipCodeTxtBox.Enabled = True
        CardNumberTxtBox.Enabled = True
        ExpDateTextBox.Enabled = True
        SecurityCodeTxtBox.Enabled = True
    End Sub

    Private Sub btnGoBack4_Click(sender As Object, e As EventArgs) Handles btnGoBack4.Click
        Me.Hide()
        Form_ExplainMoney.Show()
    End Sub

    Private Sub Form_BillingInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnection.ConnectionString = Form_LogIn.connString
        myConnection.Open()

        stmt = "SELECT * FROM tblUserData WHERE Email='" & Form_LogIn.txtEmailLogIn.Text & "' "
        cmd = New OleDbCommand(stmt, myConnection)
        dr = cmd.ExecuteReader

        If dr.Read Then
            'txtAccountID.Text = dr.GetValue(0)
            'FNameTxtBox.Text = dr.GetValue(1)
            'LNameTxtBox.Text = dr.GetValue(2)
            'DateTimePicker1.Value = dr.GetValue(3)
            'AddressTxtBox.Text = dr.GetValue(4)
            'CityTxtBox.Text = dr.GetValue(5)
            'ZipTxtBox.Text = dr.GetValue(6)
            'GenderComboBox.Text = dr.GetValue(7)
            'PhoneTxtBox.Text = dr.GetValue(9)
            ZipCodeTxtBox.Text = dr.GetValue(6)
            CardNumberTxtBox.Text = dr.GetValue(10)
            ExpDateTextBox.Text = dr.GetValue(12)
            SecurityCodeTxtBox.Text = dr.GetValue(13)
        End If
        myConnection.Close()
    End Sub
End Class