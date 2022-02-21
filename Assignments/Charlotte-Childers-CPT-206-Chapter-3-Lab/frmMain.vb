'Charlotte Childers
'CPT-206
'Chapter-3-Lab Assignment

'Option Explicit On
'Option Strict On
'Option Infer Off
Imports System.IO
Public Class frmMain
    ' This is to stop the IBeam from appearing in disabled textboxes
    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Try
            'Declaring variables
            Dim TwelvePack,
                FivePack, TwoPack,
                Total As Double

            Dim From_12_Input,
                From_5_Input,
                From_2_Input,
                NumOfInput As Integer

            'Declaring Values
            TwelvePack = 14.99
            FivePack = 6.99
            TwoPack = 2.5

            'Converting and consuming
            From_12_Input = Convert.ToInt32(Txt12Pack.Text)
            From_5_Input = Convert.ToInt32(Txt5Pack.Text)
            From_2_Input = Convert.ToInt32(Txt2Pack.Text)
            'Start Calculations
            NumOfInput = (From_12_Input +
                From_5_Input +
                From_2_Input)
            Total = (TwelvePack * From_12_Input) +
                (FivePack * From_5_Input) +
                (TwoPack * From_2_Input)
            'End Calculations
            TxtTotQuant.Text = NumOfInput.ToString
            TxtTot.Text = Total.ToString("C2")
            'Calculations to text boxes
        Catch
            MessageBox.Show("Error, Please try again.")
            ' Error Handle
        End Try
    End Sub
    Private Sub BtnExt_Click(sender As Object, e As EventArgs) Handles BtnExt.Click
        Me.Close()
    End Sub
    ' Below marks additional code I threw together for learning purposes
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        For Each tx In Controls.OfType(Of TextBox)()
            tx.Text = ""
        Next
        Txt12Pack.Focus()
    End Sub
    Private Sub TxtTot_GotFocus(sender As Object, e As EventArgs) Handles TxtTot.GotFocus
        HideCaret(TxtTot.Handle)
        ' Hides The IBeam cursor for Disabled text box "TxtToT"
    End Sub
    Private Sub TxtTotQuant_GotFocus(sender As Object, e As EventArgs) Handles TxtTotQuant.GotFocus
        HideCaret(TxtTotQuant.Handle)
        ' Hides The IBeam cursor for Disabled text box "TxtToTQuant"
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time_date_two.Text = DateTime.Now.ToString("M/d/yyyy h:mm:stt")
    End Sub
End Class
