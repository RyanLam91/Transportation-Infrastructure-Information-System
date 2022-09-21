Imports System.Data.OleDb
Imports System.Data

Public Class Form_LogIn

    Public provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    Public DBdataFile As String = "C:\Users\RyanPC\Documents\College\SP2022\CIS 251\SeeteeByke test\SeeteeByke\SeeteeByke\bin\Debug\SeeteeByke_Database.accdb"
    Public connString As String = provider + DBdataFile
    Dim myConnection As New OleDbConnection
    Public strUserEmail, strUserID As String

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        myConnection.ConnectionString = connString
        myConnection.Open()

        If txtEmailLogIn.Text = Nothing Or txtPasswordLogIn.Text = Nothing Then
            MessageBox.Show("Please Enter User Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If myConnection.State = ConnectionState.Closed Then
            myConnection.Open()
        End If

        Using login As New OleDbCommand("SELECT COUNT(*) FROM tblUserData WHERE [Email] = @email AND [Password] = @password ", myConnection)
            login.Parameters.AddWithValue("@email", OleDbType.VarChar).Value = txtEmailLogIn.Text.Trim
            login.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = txtPasswordLogIn.Text.Trim

            Dim logincount = Convert.ToInt32(login.ExecuteScalar())
            strUserEmail = txtEmailLogIn.Text

            If logincount > 0 Then
                RentBikeBtn.Enabled = True
                ReturnBikeBtn.Enabled = True
                btnLogIn.Enabled = False
                btnSignUp.Enabled = False
                Label3.Visible = True
            Else
                MessageBox.Show("Invalid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Using
        myConnection.Close()

        If (txtEmailLogIn.Text() = "management@seeteebike.com") Then
            btnReports.Show()
        End If

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        Form_RegisterAcct.Show()
    End Sub

    Private Sub Form_LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnReports.Hide()
    End Sub

    Private Sub ReturnBikeBtn_Click(sender As Object, e As EventArgs) Handles ReturnBikeBtn.Click
        myConnection.ConnectionString = connString
        myConnection.Open()

        strUserID = "Select UserID from tblUserData
                            Where Email='" & txtEmailLogIn.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(strUserID, myConnection)
        strUserID = cmd.ExecuteScalar
        myConnection.Close()

        picBike.Enabled = True

        Dim fin As Integer = Me.Width - picBike.Width - 15
        For i As Integer = 0 To fin
            For j As Integer = 0 To 10000
                picBike.SetBounds(i, picBike.Location.Y, picBike.Width, picBike.Height)
            Next
        Next

        Me.Hide()       'hides the current form
        Form_ReturnBike.Show()    'loads the next form
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Me.Hide()
        Form_Reports.Show()
    End Sub

    Private Sub RentBikeBtn_Click(sender As Object, e As EventArgs) Handles RentBikeBtn.Click
        picBike.Enabled = True

        Dim fin As Integer = Me.Width - picBike.Width - 15
        For i As Integer = 0 To fin
            For j As Integer = 0 To 10000
                picBike.SetBounds(i, picBike.Location.Y, picBike.Width, picBike.Height)
            Next
        Next


        Me.Hide()
        Form_PersonInfo.Show()
    End Sub
End Class
