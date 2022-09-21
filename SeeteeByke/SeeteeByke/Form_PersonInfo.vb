Imports System.Data.OleDb
Imports System.Data

Public Class Form_PersonInfo

    Public fName As String
    Public lName As String
    Public Res_Address As String
    Public City As String
    Public ZipCode As String
    Public CompleteAddress As String
    Public Dob As String

    Dim connString As String = Form_LogIn.provider & Form_LogIn.DBdataFile
    Dim myConnection As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim stmt As String


    Private Sub Form_PersonInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnection.ConnectionString = connString
        myConnection.Open()

        stmt = "SELECT * FROM tblUserData WHERE Email='" & Form_LogIn.txtEmailLogIn.Text & "' "
        cmd = New OleDbCommand(stmt, myConnection)
        dr = cmd.ExecuteReader

        If dr.Read Then
            'txtAccountID.Text = dr.GetValue(0)
            FNameTxtBox.Text = dr.GetValue(1)
            LNameTxtBox.Text = dr.GetValue(2)
            DateTimePicker1.Value = dr.GetValue(3)
            AddressTxtBox.Text = dr.GetValue(4)
            CityTxtBox.Text = dr.GetValue(5)
            ZipTxtBox.Text = dr.GetValue(6)
            GenderComboBox.Text = dr.GetValue(7)
            PhoneTxtBox.Text = dr.GetValue(9)
            'txtCreditCardNumber.Text = dr.GetValue(10)
        End If
        myConnection.Close()
    End Sub

    Private Sub btnGoBack2_Click(sender As Object, e As EventArgs) Handles btnGoBack2.Click
        Me.Hide()
        Form_LogIn.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        FNameTxtBox.Enabled = True
        LNameTxtBox.Enabled = True
        AddressTxtBox.Enabled = True
        CityTxtBox.Enabled = True
        ZipTxtBox.Enabled = True
        GenderComboBox.Enabled = True
        DateTimePicker1.Enabled = True
        PhoneTxtBox.Enabled = True
    End Sub

    Private Sub ContinueBtn_Click(sender As Object, e As EventArgs) Handles ContinueBtn.Click

        'Dim temp As String = DateTimePicker1.Value()
        'temp = temp.Substring(0, 10)


        Dim myConnection3 As New OleDbConnection
        Dim cmd2 As New OleDbCommand
        Dim stmt2 As String

        myConnection3.ConnectionString = Form_LogIn.connString
        myConnection3.Open()
        stmt2 = "Update tblUserData Set [FirstName]='" & FNameTxtBox.Text & "', 
                                        [LastName]='" & LNameTxtBox.Text & "',
                                        [Address]='" & AddressTxtBox.Text & "',
                                        [City]='" & CityTxtBox.Text & "',
                                        [Zip]='" & ZipTxtBox.Text & "',
                                        [Phone]='" & PhoneTxtBox.Text & "',
                                        [Gender] ='" & GenderComboBox.Text & "',
                                        [DOB] = '" & DateTimePicker1.Text & "'
                                   Where Email='" & Form_LogIn.strUserEmail & "'"
        cmd2 = New OleDbCommand(stmt2, myConnection3)

        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myConnection3.Close()
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
        Form_ExplainMoney.Show()
    End Sub
End Class