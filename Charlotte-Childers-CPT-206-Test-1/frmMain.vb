'Charlotte Childers
'CPT 206 A80 Test One
'SCC
'2/9/2022



Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblTime.Text = DateTime.Now.ToString("F")
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim BoxSeats As Double
        Dim PavSeats As Double
        Dim LawnSeats As Double
        '--
        Const BoxCost As Double = 75.0
        Const PavCost As Double = 30.0
        Const LawCost As Double = 21.0
        '--
        Dim BoxTotal As Double
        Dim PavTotal As Double
        Dim LawnTotal As Double
        '---
        Dim TickSold As Double
        Dim AmtDue As Double
        ''''''
        Double.TryParse(TxtBoxSeat.Text, BoxSeats)
        Double.TryParse(TxtLawnSeat.Text, LawnSeats)
        Double.TryParse(TxtPavSeat.Text, PavSeats)
        '---
        TickSold = BoxSeats + PavSeats + LawnSeats
        BoxTotal = BoxCost * BoxSeats
        PavTotal = PavCost * PavSeats
        LawnTotal = LawCost * LawnSeats
        AmtDue = LawnTotal + PavTotal + BoxTotal
        TxtAmtDue.Text = AmtDue.ToString("C2")
        TxtTickets.Text = TickSold.ToString()
        '----------------------------------------
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub ChkBoxSeat_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxSeat.CheckedChanged
        If ChkBoxSeat.Checked = True Then
            TxtBoxSeat.Visible = True
        End If
        If ChkBoxSeat.Checked = False Then
            TxtBoxSeat.Visible = False
            TxtBoxSeat.Text = String.Empty
            TxtTickets.Text = String.Empty
            TxtAmtDue.Text = String.Empty

        End If
    End Sub

    Private Sub ChkPavilion_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPavilion.CheckedChanged
        If ChkPavilion.Checked = True Then
            TxtPavSeat.Visible = True
        End If
        If ChkPavilion.Checked = False Then
            TxtPavSeat.Visible = False
            TxtPavSeat.Text = String.Empty
            TxtTickets.Text = String.Empty
            TxtAmtDue.Text = String.Empty

        End If
    End Sub

    Private Sub ChkLawn_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLawn.CheckedChanged
        If ChkLawn.Checked = True Then
            TxtLawnSeat.Visible = True
        End If
        If ChkLawn.Checked = False Then
            TxtLawnSeat.Visible = False
            TxtLawnSeat.Text = String.Empty
            TxtTickets.Text = String.Empty
            TxtAmtDue.Text = String.Empty

        End If
    End Sub

    Private Sub TxtBoxSeat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxSeat.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub TxtPavSeat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPavSeat.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub TxtLawnSeat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLawnSeat.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub


    ' I-Beam handlers and form closing handling below

    Private Sub TxtTickets_GotFocus(sender As Object, e As EventArgs) Handles TxtTickets.GotFocus
        HideCaret(TxtTickets.Handle)
    End Sub
    Private Sub TxtAmtDue_GotFocus(sender As Object, e As EventArgs) Handles TxtAmtDue.GotFocus
        HideCaret(TxtAmtDue.Handle)
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


End Class
