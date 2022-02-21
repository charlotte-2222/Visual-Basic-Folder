''' <summary>
''' Charlotte Childers
''' CPT-206 A80S
''' Visual Basic Chapter Six | "Donut Shoppe"
''' </summary>


Public Class FormMain
    'Checks for donuts
    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean ' <- Hide I beam Caret on disabled text boxes
    '---------
    Private Function RDBtnANDiBEAM(sender As Object, e As EventArgs) Handles RdCapp.CheckedChanged,
        RdChoco.CheckedChanged,
        RdFilled.CheckedChanged,
        RdGlazed.CheckedChanged,
        RdNone.CheckedChanged,
        RdRegular.CheckedChanged,
        RdSugar.CheckedChanged,
        TxtSalesTax.GotFocus,
        TxtSubTot.GotFocus,
        TxtTotDue.GotFocus
        'Misc. Work to make the UI work as intended

        For Each tx As TextBox In GroupTotals.Controls.OfType(Of TextBox)()
            tx.Text = "" ' clears text boxes
        Next

        HideCaret(TxtSalesTax.Handle)
        HideCaret(TxtSubTot.Handle)
        HideCaret(TxtTotDue.Handle)
        '---------


    End Function



    Private Function CalcTax(ByVal SubTot As Double)
        Return (SubTot * 0.06).ToString("c2")
    End Function
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim ShopCost As Double
        Dim SubTot As Double
        Dim TotalDue As Double
        'Glazed = 1.05, Sugar 1.05, choc 1.25, filled 1.25, regular 1.50, capp 2.75, sales tx 6%
        If RdGlazed.Checked = True Then
            ShopCost += 1.05
        End If
        If RdSugar.Checked = True Then
            ShopCost += 1.05
        End If
        If RdChoco.Checked = True Then
            ShopCost += 1.25
        End If
        If RdFilled.Checked = True Then
            ShopCost += 1.25
        End If
        If RdNone.Checked = True Then
            ShopCost += 0
        End If
        If RdRegular.Checked = True Then
            ShopCost += 1.5
        End If
        If RdCapp.Checked = True Then
            ShopCost += 2.75
        End If
        '-----
        SubTot = ShopCost
        TotalDue = (CalcTax(SubTot) + ShopCost)
        TxtSubTot.Text = SubTot.ToString("c2")
        TxtSalesTax.Text = CalcTax(SubTot)
        TxtTotDue.Text = TotalDue.ToString("c2")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim frm As New FormMain ' MsgBox popup
        MessageBox.Show("Thank you for using this application!")
        SplashScreen.Close()
    End Sub


    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you wish to exit?", "Woah!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' they decided to exit so let them
            SplashScreen.Close()
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblTime.Text = DateTime.Now.ToString("F") '<-- Clock to label
    End Sub
End Class
