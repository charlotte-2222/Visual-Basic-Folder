'Charlotte Childers
'CPT-206
'2/3/2022

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean ' <- Hide I beam Caret on disabled text boxes
    '---------
    'Variables:
    Dim Total As Integer = 0
    Dim ScoreNum As Integer = 0
    Dim Average As Double = 0.0
    'Begin main
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For lstScr As Integer = 0 To 10 Step 1 'setting integer values for lstScr/ListScore [0 - 10]
            ListScore.Items.Add(lstScr.ToString)
        Next
        ListScore.SelectedItem = "0"

    End Sub
    Private Sub BtnRecord_Click(sender As Object, e As EventArgs) Handles BtnRecord.Click
        Dim SkaterScore As Integer
        '--
        SkaterScore = ListScore.SelectedIndex
        Total = Total + ListScore.SelectedIndex
        '---
        ScoreNum = ScoreNum + 1
        Average = Total / ScoreNum
        '---
        TxtTotal.Text = Total.ToString '<- Totals converted to string
        TxtNumScore.Text = ScoreNum.ToString ' <- Number score converted to string
        TxtAverage.Text = Average.ToString("#.0") ' <- Avg converted to string
    End Sub

    Private Sub BtnNxtSkate_Click(sender As Object, e As EventArgs) Handles BtnNxtSkate.Click
        For Each tx As TextBox In scoreGrouping.Controls.OfType(Of TextBox)()
            tx.Text = String.Empty ' clears text boxes
        Next
        ListScore.SelectedItem = "0" ' <- If we don't do this, it will continue to save values even following "clear"
        Total = 0 ' <-above, notice these are the actual variables -- I assume the //
        ScoreNum = 0 ' <-above//  user's input is stored to memory in some way, and thus unless we "reset" here; the next user's run
        ' will not work as intended.
        ListScore.Focus() ' focuses on the list.
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub TxtTotal_GotFocus(sender As Object, e As EventArgs) Handles TxtTotal.GotFocus
        HideCaret(TxtTotal.Handle)
        ' Hides The IBeam cursor for Disabled text box "TxtTotal"
    End Sub

    Private Sub TxtNumScore_GotFocus(sender As Object, e As EventArgs) Handles TxtNumScore.GotFocus
        HideCaret(TxtNumScore.Handle)
        'Hides the Ibeam cursor for "NumScore"
    End Sub

    Private Sub TxtAverage_GotFocus(sender As Object, e As EventArgs) Handles TxtAverage.GotFocus
        HideCaret(TxtAverage.Handle)
        'handles the ibeam cursor hiding for "TxtAverage"
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you wish to exit this application?", "Warning:", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            MessageBox.Show("Thank you for using this application!", ":)")
            SplashScreen.Close()
            Application.Exit()
        Else
            e.Cancel = True
        End If
        'yes/no exit via GUI
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblTime.Text = DateTime.Now.ToString("F")
        ' Date / Time
        ' Name at time
    End Sub
End Class
