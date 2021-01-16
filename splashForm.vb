Public Class splashForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prgSplah.Increment(1)
        If prgSplah.Value = 100 Then
            Me.Hide()
            FrmMain.Show()
        End If
        date_time.Text = DateTime.Now.ToString("M/d/yyyy h:mm tt")
        ' Shows a splash screen depicting
        ' An image of a popular kids/teen video game
        ' Along with Date / Time
        ' Name at tome
    End Sub
End Class