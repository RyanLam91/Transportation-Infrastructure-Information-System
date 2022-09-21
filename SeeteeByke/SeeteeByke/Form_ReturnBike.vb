Imports System.Data.OleDb

Public Class Form_ReturnBike

    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim dr As OleDbDataReader
    Dim myConnection2 As OleDbConnection = New OleDbConnection

    Private Sub Form_ReturnBike_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text() = CountParkingSpots()
    End Sub

    Private Function CountParkingSpots() As Integer
        myConnection.ConnectionString = Form_LogIn.connString
        myConnection.Open()

        Dim count = "Select COUNT(BikeAvailable) from tblBikeInventory
                        Where BikeAvailable = 0"
        Dim cmd As OleDbCommand = New OleDbCommand(count, myConnection)
        count = cmd.ExecuteScalar

        myConnection.Close()
        Return count
    End Function

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        myConnection.ConnectionString = Form_LogIn.connString
        myConnection.Open()

        Dim str_BikeID = "Update tblBikeInventory Set [BikeAvailable]= 1 Where [BikeID]= " & Label4.Text & ""
        Dim cmd2 As OleDbCommand = New OleDbCommand(str_BikeID, myConnection)

        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myConnection.Close()

        Dim fin As Integer = Me.Width - picBike.Width - 15
        For i As Integer = 0 To fin
            For j As Integer = 0 To 10000
                picBike.SetBounds(i, picBike.Location.Y, picBike.Width, picBike.Height)
            Next
        Next

        Me.Hide()
        Form_Confirm_ReturnBike.Show()
    End Sub

    Private Function getBikeID2() As String
        myConnection2.ConnectionString = Form_LogIn.connString
        myConnection2.Open()

        Dim str_BikeID2 = "Select * From tblBikeInventory Where BikeAvailable == 0"
        Dim cmd As OleDbCommand = New OleDbCommand(str_BikeID2, myConnection2)
        dr = cmd.ExecuteReader

        If dr.Read Then
            str_BikeID2 = dr.GetValue(0)
        End If
        myConnection2.Close()
        Return str_BikeID2

    End Function
    Private Sub btnGoBack4_Click(sender As Object, e As EventArgs) Handles btnGoBack4.Click
        Me.Hide()
        Form_LogIn.Show()
    End Sub
End Class