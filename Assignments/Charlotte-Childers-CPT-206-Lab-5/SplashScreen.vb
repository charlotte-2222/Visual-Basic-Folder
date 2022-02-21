Option Explicit On
Option Strict On
Option Infer Off

Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prgSplah.Increment(1)
        If prgSplah.Value = 100 Then
            Me.Hide()
            frmMain.Show()
        End If
        date_time.Text = DateTime.Now.ToString("F")
        ' Shows a splash screen depicting
        ' Along with Date / Time
        ' Name at time
    End Sub
End Class