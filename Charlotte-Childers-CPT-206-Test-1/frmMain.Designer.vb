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
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.RdGroup = New System.Windows.Forms.GroupBox()
        Me.TxtPavSeat = New System.Windows.Forms.TextBox()
        Me.ChkLawn = New System.Windows.Forms.CheckBox()
        Me.ChkPavilion = New System.Windows.Forms.CheckBox()
        Me.ChkBoxSeat = New System.Windows.Forms.CheckBox()
        Me.TxtBoxSeat = New System.Windows.Forms.TextBox()
        Me.TxtLawnSeat = New System.Windows.Forms.TextBox()
        Me.LblAmtDue = New System.Windows.Forms.Label()
        Me.TxtAmtDue = New System.Windows.Forms.TextBox()
        Me.LblSold = New System.Windows.Forms.Label()
        Me.TxtTickets = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RdGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCalc
        '
        Me.BtnCalc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCalc.BackColor = System.Drawing.Color.AliceBlue
        Me.BtnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCalc.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnCalc.FlatAppearance.BorderSize = 3
        Me.BtnCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.BtnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalc.Location = New System.Drawing.Point(8, 370)
        Me.BtnCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(127, 30)
        Me.BtnCalc.TabIndex = 21
        Me.BtnCalc.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.BtnCalc, "Calculate Total for Ticket Purchase")
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'RdGroup
        '
        Me.RdGroup.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RdGroup.Controls.Add(Me.TxtPavSeat)
        Me.RdGroup.Controls.Add(Me.ChkLawn)
        Me.RdGroup.Controls.Add(Me.ChkPavilion)
        Me.RdGroup.Controls.Add(Me.ChkBoxSeat)
        Me.RdGroup.Controls.Add(Me.TxtBoxSeat)
        Me.RdGroup.Controls.Add(Me.TxtLawnSeat)
        Me.RdGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdGroup.Location = New System.Drawing.Point(93, 79)
        Me.RdGroup.Name = "RdGroup"
        Me.RdGroup.Size = New System.Drawing.Size(255, 146)
        Me.RdGroup.TabIndex = 28
        Me.RdGroup.TabStop = False
        Me.RdGroup.Text = "Tickets"
        Me.ToolTip1.SetToolTip(Me.RdGroup, "Check which ticket type you wish to purchase & the amount of tickets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'TxtPavSeat
        '
        Me.TxtPavSeat.Location = New System.Drawing.Point(94, 99)
        Me.TxtPavSeat.Name = "TxtPavSeat"
        Me.TxtPavSeat.Size = New System.Drawing.Size(52, 22)
        Me.TxtPavSeat.TabIndex = 4
        Me.TxtPavSeat.Visible = False
        '
        'ChkLawn
        '
        Me.ChkLawn.AutoSize = True
        Me.ChkLawn.Location = New System.Drawing.Point(182, 37)
        Me.ChkLawn.Name = "ChkLawn"
        Me.ChkLawn.Size = New System.Drawing.Size(61, 20)
        Me.ChkLawn.TabIndex = 2
        Me.ChkLawn.Text = "&Lawn"
        Me.ChkLawn.UseVisualStyleBackColor = True
        '
        'ChkPavilion
        '
        Me.ChkPavilion.AutoSize = True
        Me.ChkPavilion.Location = New System.Drawing.Point(94, 37)
        Me.ChkPavilion.Name = "ChkPavilion"
        Me.ChkPavilion.Size = New System.Drawing.Size(82, 20)
        Me.ChkPavilion.TabIndex = 1
        Me.ChkPavilion.Text = "&Pavilion"
        Me.ChkPavilion.UseVisualStyleBackColor = True
        '
        'ChkBoxSeat
        '
        Me.ChkBoxSeat.AutoSize = True
        Me.ChkBoxSeat.Location = New System.Drawing.Point(18, 37)
        Me.ChkBoxSeat.Name = "ChkBoxSeat"
        Me.ChkBoxSeat.Size = New System.Drawing.Size(52, 20)
        Me.ChkBoxSeat.TabIndex = 0
        Me.ChkBoxSeat.Text = "&Box"
        Me.ChkBoxSeat.UseVisualStyleBackColor = True
        '
        'TxtBoxSeat
        '
        Me.TxtBoxSeat.Location = New System.Drawing.Point(18, 99)
        Me.TxtBoxSeat.Name = "TxtBoxSeat"
        Me.TxtBoxSeat.Size = New System.Drawing.Size(52, 22)
        Me.TxtBoxSeat.TabIndex = 3
        Me.TxtBoxSeat.Visible = False
        '
        'TxtLawnSeat
        '
        Me.TxtLawnSeat.Location = New System.Drawing.Point(169, 99)
        Me.TxtLawnSeat.Name = "TxtLawnSeat"
        Me.TxtLawnSeat.Size = New System.Drawing.Size(54, 22)
        Me.TxtLawnSeat.TabIndex = 5
        Me.TxtLawnSeat.Visible = False
        '
        'LblAmtDue
        '
        Me.LblAmtDue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblAmtDue.AutoSize = True
        Me.LblAmtDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmtDue.Location = New System.Drawing.Point(74, 310)
        Me.LblAmtDue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAmtDue.Name = "LblAmtDue"
        Me.LblAmtDue.Size = New System.Drawing.Size(130, 16)
        Me.LblAmtDue.TabIndex = 27
        Me.LblAmtDue.Text = "Total Amount Due"
        '
        'TxtAmtDue
        '
        Me.TxtAmtDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmtDue.Location = New System.Drawing.Point(218, 308)
        Me.TxtAmtDue.Name = "TxtAmtDue"
        Me.TxtAmtDue.ReadOnly = True
        Me.TxtAmtDue.Size = New System.Drawing.Size(100, 22)
        Me.TxtAmtDue.TabIndex = 25
        '
        'LblSold
        '
        Me.LblSold.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSold.AutoSize = True
        Me.LblSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSold.Location = New System.Drawing.Point(42, 264)
        Me.LblSold.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSold.Name = "LblSold"
        Me.LblSold.Size = New System.Drawing.Size(169, 16)
        Me.LblSold.TabIndex = 26
        Me.LblSold.Text = "Number of Tickets Sold"
        '
        'TxtTickets
        '
        Me.TxtTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTickets.Location = New System.Drawing.Point(218, 261)
        Me.TxtTickets.Name = "TxtTickets"
        Me.TxtTickets.ReadOnly = True
        Me.TxtTickets.Size = New System.Drawing.Size(100, 22)
        Me.TxtTickets.TabIndex = 24
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnExit.BackColor = System.Drawing.Color.AliceBlue
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnExit.FlatAppearance.BorderSize = 3
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(315, 370)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(127, 30)
        Me.BtnExit.TabIndex = 22
        Me.BtnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.BtnExit, "Exit the Program")
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'LblTime
        '
        Me.LblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTime.AutoSize = True
        Me.LblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.Location = New System.Drawing.Point(13, 18)
        Me.LblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(43, 16)
        Me.LblTime.TabIndex = 23
        Me.LblTime.Text = "TIME"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 15
        '
        'frmMain
        '
        Me.AcceptButton = Me.BtnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnExit
        Me.ClientSize = New System.Drawing.Size(455, 436)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.RdGroup)
        Me.Controls.Add(Me.LblAmtDue)
        Me.Controls.Add(Me.TxtAmtDue)
        Me.Controls.Add(Me.LblSold)
        Me.Controls.Add(Me.TxtTickets)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LblTime)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charlotte Childers Visual Basic Test 1"
        Me.RdGroup.ResumeLayout(False)
        Me.RdGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCalc As Button
    Friend WithEvents RdGroup As GroupBox
    Friend WithEvents TxtPavSeat As TextBox
    Friend WithEvents ChkLawn As CheckBox
    Friend WithEvents ChkPavilion As CheckBox
    Friend WithEvents ChkBoxSeat As CheckBox
    Friend WithEvents TxtBoxSeat As TextBox
    Friend WithEvents TxtLawnSeat As TextBox
    Friend WithEvents LblAmtDue As Label
    Friend WithEvents TxtAmtDue As TextBox
    Friend WithEvents LblSold As Label
    Friend WithEvents TxtTickets As TextBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
End Class
