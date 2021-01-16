<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.lb_tot = New System.Windows.Forms.Label()
        Me.lbl_2_pk = New System.Windows.Forms.Label()
        Me.lbl_5_pk = New System.Windows.Forms.Label()
        Me.lbl_12_pk = New System.Windows.Forms.Label()
        Me.TxtTotQuant = New System.Windows.Forms.TextBox()
        Me.TxtTot = New System.Windows.Forms.TextBox()
        Me.Txt2Pack = New System.Windows.Forms.TextBox()
        Me.Txt5Pack = New System.Windows.Forms.TextBox()
        Me.Txt12Pack = New System.Windows.Forms.TextBox()
        Me.BtnExt = New System.Windows.Forms.Button()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.time_date_two = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lb_tot
        '
        Me.lb_tot.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lb_tot.AutoSize = True
        Me.lb_tot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_tot.Font = New System.Drawing.Font("Segoe UI", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tot.Location = New System.Drawing.Point(43, 179)
        Me.lb_tot.Name = "lb_tot"
        Me.lb_tot.Size = New System.Drawing.Size(49, 17)
        Me.lb_tot.TabIndex = 21
        Me.lb_tot.Text = "Totals:"
        '
        'lbl_2_pk
        '
        Me.lbl_2_pk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_2_pk.AutoSize = True
        Me.lbl_2_pk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_2_pk.Font = New System.Drawing.Font("Segoe UI", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2_pk.Location = New System.Drawing.Point(43, 135)
        Me.lbl_2_pk.Name = "lbl_2_pk"
        Me.lbl_2_pk.Size = New System.Drawing.Size(52, 17)
        Me.lbl_2_pk.TabIndex = 20
        Me.lbl_2_pk.Text = "2 Pack:"
        '
        'lbl_5_pk
        '
        Me.lbl_5_pk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_5_pk.AutoSize = True
        Me.lbl_5_pk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_5_pk.Font = New System.Drawing.Font("Segoe UI", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_5_pk.Location = New System.Drawing.Point(43, 91)
        Me.lbl_5_pk.Name = "lbl_5_pk"
        Me.lbl_5_pk.Size = New System.Drawing.Size(52, 17)
        Me.lbl_5_pk.TabIndex = 19
        Me.lbl_5_pk.Text = "5 Pack:"
        '
        'lbl_12_pk
        '
        Me.lbl_12_pk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_12_pk.AutoSize = True
        Me.lbl_12_pk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_12_pk.Font = New System.Drawing.Font("Segoe UI", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_12_pk.Location = New System.Drawing.Point(43, 44)
        Me.lbl_12_pk.Name = "lbl_12_pk"
        Me.lbl_12_pk.Size = New System.Drawing.Size(59, 17)
        Me.lbl_12_pk.TabIndex = 18
        Me.lbl_12_pk.Text = "12 Pack:"
        '
        'TxtTotQuant
        '
        Me.TxtTotQuant.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTotQuant.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TxtTotQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotQuant.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtTotQuant.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotQuant.ForeColor = System.Drawing.Color.Black
        Me.TxtTotQuant.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtTotQuant.Location = New System.Drawing.Point(300, 177)
        Me.TxtTotQuant.Name = "TxtTotQuant"
        Me.TxtTotQuant.ReadOnly = True
        Me.TxtTotQuant.Size = New System.Drawing.Size(77, 22)
        Me.TxtTotQuant.TabIndex = 17
        Me.TxtTotQuant.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TxtTotQuant, "Quantity of Items Ordered")
        '
        'TxtTot
        '
        Me.TxtTot.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTot.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTot.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtTot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTot.ForeColor = System.Drawing.Color.Black
        Me.TxtTot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtTot.Location = New System.Drawing.Point(112, 176)
        Me.TxtTot.Name = "TxtTot"
        Me.TxtTot.ReadOnly = True
        Me.TxtTot.Size = New System.Drawing.Size(102, 22)
        Me.TxtTot.TabIndex = 3
        Me.TxtTot.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TxtTot, "Total Price")
        '
        'Txt2Pack
        '
        Me.Txt2Pack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt2Pack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt2Pack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt2Pack.Location = New System.Drawing.Point(112, 132)
        Me.Txt2Pack.Name = "Txt2Pack"
        Me.Txt2Pack.Size = New System.Drawing.Size(92, 22)
        Me.Txt2Pack.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Txt2Pack, "Enter quantity for 2-Pack")
        '
        'Txt5Pack
        '
        Me.Txt5Pack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt5Pack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt5Pack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt5Pack.Location = New System.Drawing.Point(112, 88)
        Me.Txt5Pack.Name = "Txt5Pack"
        Me.Txt5Pack.Size = New System.Drawing.Size(92, 22)
        Me.Txt5Pack.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Txt5Pack, "Enter quantity for 5-Pack" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Txt12Pack
        '
        Me.Txt12Pack.AcceptsReturn = True
        Me.Txt12Pack.AccessibleRole = System.Windows.Forms.AccessibleRole.HotkeyField
        Me.Txt12Pack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txt12Pack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt12Pack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt12Pack.Location = New System.Drawing.Point(112, 44)
        Me.Txt12Pack.Name = "Txt12Pack"
        Me.Txt12Pack.Size = New System.Drawing.Size(92, 22)
        Me.Txt12Pack.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Txt12Pack, "Enter Quantity for 12-Pack")
        '
        'BtnExt
        '
        Me.BtnExt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnExt.BackColor = System.Drawing.Color.LightCoral
        Me.BtnExt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExt.FlatAppearance.BorderSize = 2
        Me.BtnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExt.Location = New System.Drawing.Point(258, 236)
        Me.BtnExt.Name = "BtnExt"
        Me.BtnExt.Size = New System.Drawing.Size(125, 43)
        Me.BtnExt.TabIndex = 6
        Me.BtnExt.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.BtnExt, "End program")
        Me.BtnExt.UseVisualStyleBackColor = False
        '
        'BtnCalc
        '
        Me.BtnCalc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCalc.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCalc.FlatAppearance.BorderSize = 2
        Me.BtnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalc.Location = New System.Drawing.Point(38, 236)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(125, 43)
        Me.BtnCalc.TabIndex = 4
        Me.BtnCalc.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.BtnCalc, "Calculate totals")
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Quantity:"
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnClear.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClear.Location = New System.Drawing.Point(318, 8)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(76, 35)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clea&r"
        Me.ToolTip1.SetToolTip(Me.BtnClear, "Clear text boxes")
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'time_date_two
        '
        Me.time_date_two.AutoSize = True
        Me.time_date_two.Location = New System.Drawing.Point(6, 4)
        Me.time_date_two.Name = "time_date_two"
        Me.time_date_two.Size = New System.Drawing.Size(89, 13)
        Me.time_date_two.TabIndex = 23
        Me.time_date_two.Text = "PLACE_HOLDER"
        '
        'FrmMain
        '
        Me.AcceptButton = Me.BtnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton = Me.BtnExt
        Me.ClientSize = New System.Drawing.Size(415, 318)
        Me.Controls.Add(Me.time_date_two)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_tot)
        Me.Controls.Add(Me.lbl_2_pk)
        Me.Controls.Add(Me.lbl_5_pk)
        Me.Controls.Add(Me.lbl_12_pk)
        Me.Controls.Add(Me.TxtTotQuant)
        Me.Controls.Add(Me.TxtTot)
        Me.Controls.Add(Me.Txt2Pack)
        Me.Controls.Add(Me.Txt5Pack)
        Me.Controls.Add(Me.Txt12Pack)
        Me.Controls.Add(Me.BtnExt)
        Me.Controls.Add(Me.BtnCalc)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zach Childers, Chapter 3/Assignment 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_tot As Label
    Friend WithEvents lbl_2_pk As Label
    Friend WithEvents lbl_5_pk As Label
    Friend WithEvents lbl_12_pk As Label
    Friend WithEvents TxtTotQuant As TextBox
    Friend WithEvents TxtTot As TextBox
    Friend WithEvents Txt2Pack As TextBox
    Friend WithEvents Txt5Pack As TextBox
    Friend WithEvents Txt12Pack As TextBox
    Friend WithEvents BtnExt As Button
    Friend WithEvents BtnCalc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents time_date_two As Label
End Class
