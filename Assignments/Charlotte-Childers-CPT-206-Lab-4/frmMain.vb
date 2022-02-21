'Charlotte Childers
'CPT 206 A80
'SCC
'1/30/2022



Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    ' This is to stop the IBeam from appearing in disabled textboxes
    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
    Private Sub TxtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSales.KeyPress
        'Accepts only numbers, backspace, period.
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back And e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub


    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim sales, commission,
            additional, travel,
            over10, total, comm As Double

        Double.TryParse(TxtSales.Text, sales)

        Select Case True
            Case Chk10Y.Checked
                If sales >= 10000 Then
                    additional += 500
                End If
            Case ChkTrvl.Checked
                additional += 700
        End Select



        Select Case sales
            Case 1 To 5999.99
                commission = 10%
            Case 6000 To 29999.99
                commission = 13%
                additional += 600
            Case <= 30000
                commission = 14%
                additional += 3720
        End Select

        'If sales >= 1 Or sales = 5999.99 Then
        '    commission = 1.1
        'ElseIf sales >= 6000 Or sales = 29999.99 Then
        '    additional += 600
        '    commission = 1.13
        'ElseIf sales >= 30000 Then
        '    additional += 3720
        '    commission = 1.19
        'End If

        comm = sales / commission

        total = (sales / commission) + additional

        TxtTotal.Text = total.ToString("C0")
        TxtCommission.Text = comm.ToString("C0")
        TxtAdditional.Text = additional.ToString("C0")

    End Sub


    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you wish to exit this application?", "Warning:", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            MessageBox.Show("Thank you for using this application!", ":)")
            splashScreen.Close()
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time_date_two.Text = DateTime.Now.ToString("M/d/yyyy h:mm:stt")
    End Sub

End Class

