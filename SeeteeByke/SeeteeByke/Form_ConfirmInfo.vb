Imports System.Data.OleDb

Public Class Form_ConfirmInfo

    Public TxtBoxArray(7) As String
    Public str_UserID As String

    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim myConnection1 As OleDbConnection = New OleDbConnection
    Dim myConnection5 As OleDbConnection = New OleDbConnection
    Dim dr As OleDbDataReader

    Dim thisDate As Date = Today

    Private Sub Form_ConfirmInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FnameTXT.Text = Form_PersonInfo.FNameTxtBox.Text
        TxtBoxArray(0) = Me.FnameTXT.Text

        Me.LnameTXT.Text = Form_PersonInfo.LNameTxtBox.Text
        TxtBoxArray(1) = Me.LnameTXT.Text

        Me.GenderComboBox.Text = Form_PersonInfo.GenderComboBox.Text
        TxtBoxArray(2) = Me.GenderComboBox.Text

        Me.DobTXT.Text = Form_PersonInfo.DateTimePicker1.Value
        TxtBoxArray(3) = Me.DobTXT.Text

        Me.AddressTXT.Text = Form_PersonInfo.AddressTxtBox.Text
        TxtBoxArray(4) = Me.AddressTXT.Text

        Me.CityTXT.Text = Form_PersonInfo.CityTxtBox.Text
        TxtBoxArray(5) = Me.CityTXT.Text

        Me.CCNumberTxtBox.Text() = Form_BillingInfo.CardNumber
        TxtBoxArray(6) = Me.CCNumberTxtBox.Text

        Me.ZIPCODETXT.Text = Form_PersonInfo.ZipTxtBox.Text
        TxtBoxArray(7) = Me.ZIPCODETXT.Text

        txtBox_DisplayBike.Text = getBikeID()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        For i As Integer = 0 To TxtBoxArray.Length - 1
            If (TxtBoxArray(i).Length < 1) Then
                MessageBox.Show("All input fields must be complete before confirming!")
                Return
            End If
        Next

        myConnection.ConnectionString = Form_LogIn.connString
        myConnection.Open()

        Dim str As String
        str = "Insert into tblInvoices([UserID],[BikeID],[InvoiceDate],[LastFourDigitsCC],[UserEmail]) Values (?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        cmd.Parameters.Add(New OleDbParameter("UserID", CType(getUserIDstring(), String)))
        cmd.Parameters.Add(New OleDbParameter("BikeID", CType(txtBox_DisplayBike.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("InvoiceDate", CType(thisDate, String)))
        'cmd.Parameters.Add(New OleDbParameter("InvoiceAmt", CType(24, String)))
        cmd.Parameters.Add(New OleDbParameter("LastFourDigitsCC", CType(CCNumberTxtBox.Text.Substring(TxtBoxArray(6).Length - 4, 4), String)))
        cmd.Parameters.Add(New OleDbParameter("UserEmail", CType(Form_LogIn.strUserEmail, String)))

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        updateBikeAvailable()
        myConnection.Close()

        Dim fin As Integer = Me.Width - picBike.Width - 15
        For i As Integer = 0 To fin
            For j As Integer = 0 To 10000
                picBike.SetBounds(i, picBike.Location.Y, picBike.Width, picBike.Height)
            Next
        Next

        Me.Hide()
        Form_OrderSummary.Show()

    End Sub

    Private Sub btnGoBack5_Click(sender As Object, e As EventArgs) Handles btnGoBack5.Click
        Me.Hide()
        Form_BillingInfo.Show()
    End Sub

    Public Function updateBikeAvailable()
        myConnection5.ConnectionString = Form_LogIn.connString
        myConnection5.Open()

        Dim str_BikeID = "Update tblBikeInventory Set [BikeAvailable]= 0 Where [BikeID]=" & txtBox_DisplayBike.Text & ""
        Dim cmd5 As OleDbCommand = New OleDbCommand(str_BikeID, myConnection5)

        Try
            cmd5.ExecuteNonQuery()
            cmd5.Dispose()
            myConnection5.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myConnection5.Close()
    End Function

    Private Function getUserIDstring() As String
        myConnection1.ConnectionString = Form_LogIn.connString
        myConnection1.Open()

        str_UserID = "Select * From tblUserData Where Email ='" & Form_LogIn.strUserEmail & "' "
        Dim cmd As OleDbCommand = New OleDbCommand(str_UserID, myConnection1)
        dr = cmd.ExecuteReader

        If dr.Read Then
            str_UserID = dr.GetValue(0)
        End If
        myConnection1.Close()
        Return str_UserID
    End Function

    Private Function getBikeID() As String
        myConnection1.ConnectionString = Form_LogIn.connString
        myConnection1.Open()

        Dim str_BikeID = "Select * From tblBikeInventory Where BikeAvailable = True"
        Dim cmd As OleDbCommand = New OleDbCommand(str_BikeID, myConnection1)
        dr = cmd.ExecuteReader

        If dr.Read Then
            str_BikeID = dr.GetValue(0)
        End If
        myConnection1.Close()
        Return str_BikeID
    End Function


End Class