Public Class Form_OrderSummary

    Private Sub Form_OrderSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim t As Timer = New Timer()
        t.Interval = 10000
        AddHandler t.Tick, AddressOf HandleTimerTick
        t.Start()
    End Sub

    Private Sub HandleTimerTick()
        Form_LogIn.Close()
        Form_PersonInfo.Close()
        Form_ExplainMoney.Close()
        Form_BillingInfo.Close()
        Form_ConfirmInfo.Close()
        Me.Close()
    End Sub

End Class