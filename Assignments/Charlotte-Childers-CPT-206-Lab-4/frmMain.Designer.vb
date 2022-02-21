<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.ChkTrvl = New System.Windows.Forms.CheckBox()
        Me.Chk10Y = New System.Windows.Forms.CheckBox()
        Me.TxtTotal = New System.Windows.Forms.RichTextBox()
        Me.TxtCommission = New System.Windows.Forms.TextBox()
        Me.TxtAdditional = New System.Windows.Forms.TextBox()
        Me.TxtSales = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.time_date_two = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Total due salesperson:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Additional Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Commission Only:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Sales:"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Tomato
        Me.BtnExit.Location = New System.Drawing.Point(352, 93)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 19
        Me.BtnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.BtnExit, "Exit")
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnCalc.Location = New System.Drawing.Point(352, 28)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalc.TabIndex = 18
        Me.BtnCalc.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.BtnCalc, "Calculate")
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'ChkTrvl
        '
        Me.ChkTrvl.AutoSize = True
        Me.ChkTrvl.Location = New System.Drawing.Point(207, 89)
        Me.ChkTrvl.Name = "ChkTrvl"
        Me.ChkTrvl.Size = New System.Drawing.Size(70, 17)
        Me.ChkTrvl.TabIndex = 17
        Me.ChkTrvl.Text = "&Traveling"
        Me.ToolTip1.SetToolTip(Me.ChkTrvl, "Check if a Traveling Agent")
        Me.ChkTrvl.UseVisualStyleBackColor = True
        '
        'Chk10Y
        '
        Me.Chk10Y.AutoSize = True
        Me.Chk10Y.Location = New System.Drawing.Point(207, 34)
        Me.Chk10Y.Name = "Chk10Y"
        Me.Chk10Y.Size = New System.Drawing.Size(92, 17)
        Me.Chk10Y.TabIndex = 16
        Me.Chk10Y.Text = "&Over 10 years"
        Me.ToolTip1.SetToolTip(Me.Chk10Y, "Check if worked 10 years or more")
        Me.Chk10Y.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTotal.Location = New System.Drawing.Point(210, 158)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(177, 74)
        Me.TxtTotal.TabIndex = 15
        Me.TxtTotal.Text = ""
        Me.ToolTip1.SetToolTip(Me.TxtTotal, "Total for Salesperson")
        '
        'TxtCommission
        '
        Me.TxtCommission.Location = New System.Drawing.Point(40, 113)
        Me.TxtCommission.Name = "TxtCommission"
        Me.TxtCommission.ReadOnly = True
        Me.TxtCommission.Size = New System.Drawing.Size(100, 20)
        Me.TxtCommission.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.TxtCommission, "Commission for Employee")
        '
        'TxtAdditional
        '
        Me.TxtAdditional.Location = New System.Drawing.Point(40, 176)
        Me.TxtAdditional.Name = "TxtAdditional"
        Me.TxtAdditional.ReadOnly = True
        Me.TxtAdditional.Size = New System.Drawing.Size(100, 20)
        Me.TxtAdditional.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.TxtAdditional, "Additional Fees returned")
        '
        'TxtSales
        '
        Me.TxtSales.Location = New System.Drawing.Point(40, 50)
        Me.TxtSales.Name = "TxtSales"
        Me.TxtSales.Size = New System.Drawing.Size(100, 20)
        Me.TxtSales.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.TxtSales, "Input Sales Amt")
        '
        'time_date_two
        '
        Me.time_date_two.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.time_date_two.AutoSize = True
        Me.time_date_two.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_date_two.Location = New System.Drawing.Point(10, 232)
        Me.time_date_two.Name = "time_date_two"
        Me.time_date_two.Size = New System.Drawing.Size(116, 20)
        Me.time_date_two.TabIndex = 38
        Me.time_date_two.Text = "PLACE_HOLDER"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 15
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 261)
        Me.Controls.Add(Me.time_date_two)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.ChkTrvl)
        Me.Controls.Add(Me.Chk10Y)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtCommission)
        Me.Controls.Add(Me.TxtAdditional)
        Me.Controls.Add(Me.TxtSales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 300)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charlotte Childers, CPT-206 Chapter 4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnCalc As Button
    Friend WithEvents ChkTrvl As CheckBox
    Friend WithEvents Chk10Y As CheckBox
    Friend WithEvents TxtTotal As RichTextBox
    Friend WithEvents TxtCommission As TextBox
    Friend WithEvents TxtAdditional As TextBox
    Friend WithEvents TxtSales As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents time_date_two As Label
    Friend WithEvents Timer1 As Timer
End Class
