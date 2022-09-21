Imports System.Data.OleDb

Public Class Form_Confirm_ReturnBike

    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim myConnection1 As OleDbConnection = New OleDbConnection
    Dim myConnection2 As OleDbConnection = New OleDbConnection
    Dim thisDate As Date = Today
    Dim str_invoiceID As String



    Private Sub Form_Confirm_ReturnBike_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtboxEmail.Text = Form_LogIn.txtEmailLogIn.Text

        myConnection.ConnectionString = Form_LogIn.connString
        myConnection.Open()


        ' FIND THE USER NAME AND DISPLAY IT
        Dim name = "Select FirstName & ' ' & LastName 
                    From tblUserData
                    Where Email='" & txtboxEmail.Text() & "' "

        Dim cmd As OleDbCommand = New OleDbCommand(name, myConnection)
        name = cmd.ExecuteScalar
        txtboxName.Text = name
        myConnection.Close()


        updateReturnDate()
        getInvoiceID()
        getDaysRented()


        myConnection.Open()
        ' EXTRACTS THE BIKE_ID THAT WAS RENTED
        Dim bike_rented = " Select BikeID
                            From tblInvoices
                            WHERE InvoiceID = " & str_invoiceID
        Dim cmd2 = New OleDbCommand(bike_rented, myConnection)
        bike_rented = cmd2.ExecuteScalar
        txtboxBikeID.Text = bike_rented
        myConnection.Close()


        myConnection2.ConnectionString = Form_LogIn.connString
        myConnection2.Open()
        ' EXTRACTS THE TOTAL CHARGE FOR THE INVOICE
        Dim total_charge = "Select InvoiceAmt From tblInvoices
                                WHERE InvoiceID = " & str_invoiceID
        Dim cmd3 = New OleDbCommand(total_charge, myConnection2)
        total_charge = cmd3.ExecuteScalar


        txtboxTotalCharge.Text = "$" & total_charge & ".00"

    End Sub

    Private Function getInvoiceID() As Nullable
        myConnection.Open()

        Dim stmt = "Select * from tblInvoices Where UserEmail = '" & txtboxEmail.Text() & "' Order By ReturnDate DESC"
        Dim cmd6 As OleDbCommand = New OleDbCommand(stmt, myConnection)
        str_invoiceID = cmd6.ExecuteScalar
        myConnection.Close()
    End Function

    Private Function updateReturnDate() As Nullable
        myConnection.Open()
        Dim dayReturned = " UPDATE tblInvoices
                            SET ReturnDate = '" & thisDate & "'
                            WHERE UserEmail = '" & txtboxEmail.Text() & "'"

        Dim cmd1 As OleDbCommand = New OleDbCommand(dayReturned, myConnection)
        dayReturned = cmd1.ExecuteScalar
        myConnection.Close()
    End Function



    Private Function getDaysRented() As Nullable
        myConnection1.ConnectionString = Form_LogIn.connString
        myConnection1.Open()
        ' FIND THE AMOUNT OF DAYS RENTED TO CALCULATE THE PRICE ***** NOT WORKING
        Dim daysRented = "SELECT DaysRented
                            FROM tblInvoices
                            WHERE InvoiceID = " & str_invoiceID
        'WHERE UserEmail = '" & txtboxEmail.Text() & "'AND ReturnDate = '" & thisDate & "'"
        Dim cmd2 As OleDbCommand = New OleDbCommand(daysRented, myConnection1)
        daysRented = cmd2.ExecuteScalar
        txtboxDaysRented.Text = daysRented
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim fin As Integer = Me.Width - picBike.Width - 200
        For i As Integer = 0 To fin
            For j As Integer = 0 To 10000
                picBike.SetBounds(i, picBike.Location.Y, picBike.Width, picBike.Height)
            Next
        Next

        Form_LogIn.Close()
        Form_ReturnBike.Close()
        Me.Close()
    End Sub
End Class