Imports System.Data.OleDb

Public Class Form_RegisterAcct
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public strGender As String
    Public strMyDOB As String
    Private blnByPassValidation As Boolean = False

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        strGender = ComboBox1.SelectedItem
        strMyDOB = DateTimePicker1.Text
        connString = Form_LogIn.provider & Form_LogIn.DBdataFile

        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into 
                tblUserData([FirstName],[LastName],[DOB],[Address],[City],[Zip],[Gender],[Email],[Phone],[CreditCard],[Password],[CardExpDate],[SecurityCode]) 
                Values (?,?,?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("FirstName", CType(txtSignUpFirstName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LastName", CType(txtSignUpLastName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("DOB", CType(strMyDOB, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(txtSignUpAddress.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("City", CType(txtSignUpCity.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Zip", CType(txtSignUpZip.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType(strGender, String)))
        cmd.Parameters.Add(New OleDbParameter("Email", CType(txtSignUpEmail.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone", CType(txtSignUpPhone.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CreditCard", CType(txtSignUpCreditCard.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(txtSignUpPassword.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CardExpDate", CType(txtCardExpDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("SecurityCode", CType(TxtSecurityCode.Text, String)))

        If txtSignUpLastName.Text = String.Empty Then
            MessageBox.Show("Please enter Last name")
            txtSignUpLastName.Focus()
        ElseIf txtSignUpEmail.Text = String.Empty Then
            MessageBox.Show("Please enter Email address ")
            txtSignUpEmail.Focus()
        ElseIf txtSignUpPassword.Text = String.Empty Then
            MessageBox.Show("Please enter a Password address ")
            txtSignUpPassword.Focus()
        ElseIf txtSignUpAddress.Text = String.Empty Then
            MessageBox.Show("Please enter an Address ")
            txtSignUpAddress.Focus()
        ElseIf txtSignUpCity.Text = String.Empty Then
            MessageBox.Show("Please enter a City ")
            txtSignUpCity.Focus()
        ElseIf txtSignUpZip.Text = String.Empty Then
            MessageBox.Show("Please enter a Zip code ")
            txtSignUpZip.Focus()
        ElseIf txtSignUpPhone.Text = String.Empty Then
            MessageBox.Show("Please enter a Phone number ")
            txtSignUpPhone.Focus()
        ElseIf txtSignUpCreditCard.Text = String.Empty Then
            MessageBox.Show("Please enter a Credit card number ")
            txtSignUpCreditCard.Focus()
        Else
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MessageBox.Show("User Created")
            txtSignUpFirstName.Clear()
            txtSignUpLastName.Clear()
            txtSignUpAddress.Clear()
            txtSignUpCity.Clear()
            txtSignUpZip.Clear()
            txtSignUpEmail.Clear()
            txtSignUpPhone.Clear()
            txtSignUpCreditCard.Clear()
            txtSignUpPassword.Clear()

            Me.Hide()
            Form_LogIn.Show()
        End If
        myConnection.Close()
    End Sub

    Private Sub btnSignUpBackButton_Click(sender As Object, e As EventArgs) Handles btnSignUpBackButton.Click
        txtSignUpFirstName.Clear()
        txtSignUpLastName.Clear()
        txtSignUpAddress.Clear()
        txtSignUpCity.Clear()
        txtSignUpZip.Clear()
        txtSignUpEmail.Clear()
        txtSignUpPhone.Clear()
        txtSignUpCreditCard.Clear()
        txtSignUpPassword.Clear()
        Me.Hide()
        Form_LogIn.Show()
    End Sub

    Private Sub Form_RegisterAcct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 0
        End If
        txtSignUpFirstName.Focus()
        txtSignUpZip.MaxLength = 5
        txtSignUpPhone.MaxLength = 10
        txtSignUpCreditCard.MaxLength = 16
    End Sub

    Private Sub btnSignUpBackButton_MouseEnter(sender As Object, e As EventArgs) Handles btnSignUpBackButton.MouseEnter
        blnByPassValidation = True
    End Sub

    Private Sub btnSignUpBackButton_MouseLeave(sender As Object, e As EventArgs) Handles btnSignUpBackButton.MouseLeave
        blnByPassValidation = False
    End Sub

    Private Sub txtSignUpFirstName_Leave(sender As Object, e As EventArgs) Handles txtSignUpFirstName.Leave
        If blnByPassValidation = False Then
            If txtSignUpFirstName.Text = String.Empty Then
                MessageBox.Show("First Name Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                txtSignUpFirstName.Focus()
            End If
        End If
    End Sub

    Private Sub txtSignUpLastName_Leave(sender As Object, e As EventArgs) Handles txtSignUpLastName.Leave
        If blnByPassValidation = False Then
            If txtSignUpLastName.Text = String.Empty Then
                MessageBox.Show("Last Name Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                txtSignUpLastName.Focus()
            End If
        End If
    End Sub

    Private Sub txtSignUpEmail_Leave(sender As Object, e As EventArgs) Handles txtSignUpEmail.Leave
        If blnByPassValidation = False Then
            If txtSignUpEmail.Text = String.Empty Then
                MessageBox.Show("Email Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                txtSignUpEmail.Focus()
            End If
        End If
    End Sub

    Private Sub txtSignUpPassword_Leave(sender As Object, e As EventArgs) Handles txtSignUpPassword.Leave
        If blnByPassValidation = False Then
            If txtSignUpPassword.Text = String.Empty Then
                MessageBox.Show("Password Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                txtSignUpPassword.Focus()
            End If
        End If
    End Sub

    Private Sub txtSignUpAddress_Leave(sender As Object, e As EventArgs) Handles txtSignUpAddress.Leave
        If blnByPassValidation = False Then
            If txtSignUpAddress.Text = String.Empty Then
                MessageBox.Show("Address Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                txtSignUpAddress.Focus()
            End If
        End If
    End Sub

    Private Sub txtSignUpCity_Leave(sender As Object, e As EventArgs) Handles txtSignUpCity.Leave
        If blnByPassValidation = False Then
            If txtSignUpCity.Text = String.Empty Then
                MessageBox.Show("City Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                txtSignUpCity.Focus()
            End If
        End If
    End Sub

    Private Sub txtSignUpZip_Leave(sender As Object, e As EventArgs) Handles txtSignUpZip.Leave
        If blnByPassValidation = False Then
            If txtSignUpZip.Text = String.Empty Then
                MessageBox.Show("Zip Code Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                txtSignUpZip.Focus()
            End If
        End If
    End Sub

    Private Sub txtSignUpPhone_Leave(sender As Object, e As EventArgs) Handles txtSignUpPhone.Leave
        If blnByPassValidation = False Then
            If txtSignUpPhone.Text = String.Empty Then
                MessageBox.Show("Phone Number Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                txtSignUpPhone.Focus()
            End If
        End If
    End Sub

    Private Sub txtSignUpCreditCard_Leave(sender As Object, e As EventArgs) Handles txtSignUpCreditCard.Leave
        If blnByPassValidation = False Then
            If txtSignUpCreditCard.Text = String.Empty Then
                MessageBox.Show("Credit Card Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                txtSignUpCreditCard.Focus()
            End If
        End If
    End Sub

    Private Sub txtCardExpDate_Leave(sender As Object, e As EventArgs) Handles txtCardExpDate.Leave
        If blnByPassValidation = False Then
            If txtCardExpDate.Text = String.Empty Then
                MessageBox.Show("Card Expiration Date Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                txtCardExpDate.Focus()
            End If
        End If
    End Sub

    Private Sub TxtSecurityCode_Leave(sender As Object, e As EventArgs) Handles TxtSecurityCode.Leave
        If blnByPassValidation = False Then
            If TxtSecurityCode.Text = String.Empty Then
                MessageBox.Show("Card Security Code Must Be Entered; It Cannot Be Blank", "Invalid Data Entry")
                TxtSecurityCode.Focus()
            End If
        End If
    End Sub

    Private Sub txtSignUpFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSignUpFirstName.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> Chr(32) AndAlso
               e.KeyChar <> Chr(8) Then
            e.Handled = True
            MessageBox.Show("Invalid Character; Name May Contain Only Letters And Space(s)", "Invalid Data Entry")
        End If
    End Sub

    Private Sub txtSignUpLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSignUpLastName.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> Chr(32) AndAlso
               e.KeyChar <> Chr(8) Then
            e.Handled = True
            MessageBox.Show("Invalid Character; Name May Contain Only Letters And Space(s)", "Invalid Data Entry")
        End If
    End Sub

    Private Sub txtSignUpCity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSignUpCity.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> Chr(32) AndAlso
               e.KeyChar <> Chr(8) Then
            e.Handled = True
            MessageBox.Show("Invalid Character; City May Contain Only Letters And Space(s)", "Invalid Data Entry")
        End If
    End Sub

    Private Sub txtSignUpZip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSignUpZip.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
            MessageBox.Show("Invalid Character, only numbers 0 to 9 maybe entered")
        End If
    End Sub

    Private Sub txtSignUpPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSignUpPhone.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
            MessageBox.Show("Invalid Character, only numbers 0 to 9 maybe entered")
        End If
    End Sub

    Private Sub txtSignUpCreditCard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSignUpCreditCard.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True
            MessageBox.Show("Invalid Character, only numbers 0 to 9 maybe entered")
        End If
    End Sub


End Class