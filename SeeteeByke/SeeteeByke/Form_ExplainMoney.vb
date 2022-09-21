Public Class Form_ExplainMoney
    Private Sub btnGoBack3_Click(sender As Object, e As EventArgs) Handles btnGoBack3.Click
        Me.Hide()
        Form_PersonInfo.Show()
    End Sub

    Private Sub ContinueBtn3_Click(sender As Object, e As EventArgs) Handles ContinueBtn3.Click

        Dim fin As Integer = Me.Width - picBike.Width - 15
        For i As Integer = 0 To fin
            For j As Integer = 0 To 10000
                picBike.SetBounds(i, picBike.Location.Y, picBike.Width, picBike.Height)
            Next
        Next

        Me.Hide()
        Form_BillingInfo.Show()
    End Sub
End Class