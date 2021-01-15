'Zachary Childers
'CPT-206
'Chapter-3-Lab Assignment
Public Class FrmMain
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Try
            'Declaring variables
            Dim TwelvePack, FivePack, TwoPack, Total As Double
            Dim From_12_Input, From_5_Input, From_2_Input, NumOfInput As Integer
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

        End Try
    End Sub

    Private Sub BtnExt_Click(sender As Object, e As EventArgs) Handles BtnExt.Click
        Dim frm As New FrmMain
        MessageBox.Show("Eat my ass")
        frm.Show()
        Me.Close()
        'Exits program
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each textbox In Controls.OfType(Of TextBox)()
            textbox.Text = ""
        Next
    End Sub
End Class
