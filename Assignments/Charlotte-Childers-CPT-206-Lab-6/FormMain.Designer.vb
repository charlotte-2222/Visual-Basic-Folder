<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.GroupDoughnut = New System.Windows.Forms.GroupBox()
        Me.RdFilled = New System.Windows.Forms.RadioButton()
        Me.RdChoco = New System.Windows.Forms.RadioButton()
        Me.RdSugar = New System.Windows.Forms.RadioButton()
        Me.RdGlazed = New System.Windows.Forms.RadioButton()
        Me.GroupCoffee = New System.Windows.Forms.GroupBox()
        Me.RdCapp = New System.Windows.Forms.RadioButton()
        Me.RdRegular = New System.Windows.Forms.RadioButton()
        Me.RdNone = New System.Windows.Forms.RadioButton()
        Me.GroupTotals = New System.Windows.Forms.GroupBox()
        Me.LblTotDue = New System.Windows.Forms.Label()
        Me.LblSalesTax = New System.Windows.Forms.Label()
        Me.LblSubTot = New System.Windows.Forms.Label()
        Me.TxtTotDue = New System.Windows.Forms.TextBox()
        Me.TxtSalesTax = New System.Windows.Forms.TextBox()
        Me.TxtSubTot = New System.Windows.Forms.TextBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupDoughnut.SuspendLayout()
        Me.GroupCoffee.SuspendLayout()
        Me.GroupTotals.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupDoughnut
        '
        Me.GroupDoughnut.BackColor = System.Drawing.Color.LightPink
        Me.GroupDoughnut.Controls.Add(Me.RdFilled)
        Me.GroupDoughnut.Controls.Add(Me.RdChoco)
        Me.GroupDoughnut.Controls.Add(Me.RdSugar)
        Me.GroupDoughnut.Controls.Add(Me.RdGlazed)
        Me.GroupDoughnut.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDoughnut.Location = New System.Drawing.Point(43, 77)
        Me.GroupDoughnut.Name = "GroupDoughnut"
        Me.GroupDoughnut.Size = New System.Drawing.Size(200, 125)
        Me.GroupDoughnut.TabIndex = 0
        Me.GroupDoughnut.TabStop = False
        Me.GroupDoughnut.Text = "Doughnut Choices"
        Me.ToolTip1.SetToolTip(Me.GroupDoughnut, "Choose your favorite donut")
        '
        'RdFilled
        '
        Me.RdFilled.AutoSize = True
        Me.RdFilled.Location = New System.Drawing.Point(6, 90)
        Me.RdFilled.Name = "RdFilled"
        Me.RdFilled.Size = New System.Drawing.Size(108, 23)
        Me.RdFilled.TabIndex = 4
        Me.RdFilled.TabStop = True
        Me.RdFilled.Text = "&Filled ($1.25)"
        Me.RdFilled.UseVisualStyleBackColor = True
        '
        'RdChoco
        '
        Me.RdChoco.AutoSize = True
        Me.RdChoco.Location = New System.Drawing.Point(6, 65)
        Me.RdChoco.Name = "RdChoco"
        Me.RdChoco.Size = New System.Drawing.Size(137, 23)
        Me.RdChoco.TabIndex = 3
        Me.RdChoco.TabStop = True
        Me.RdChoco.Text = "C&hocolate ($1.25)"
        Me.RdChoco.UseVisualStyleBackColor = True
        '
        'RdSugar
        '
        Me.RdSugar.AutoSize = True
        Me.RdSugar.Location = New System.Drawing.Point(6, 42)
        Me.RdSugar.Name = "RdSugar"
        Me.RdSugar.Size = New System.Drawing.Size(110, 23)
        Me.RdSugar.TabIndex = 2
        Me.RdSugar.TabStop = True
        Me.RdSugar.Text = "&Sugar ($1.05)"
        Me.RdSugar.UseVisualStyleBackColor = True
        '
        'RdGlazed
        '
        Me.RdGlazed.AutoSize = True
        Me.RdGlazed.Location = New System.Drawing.Point(6, 19)
        Me.RdGlazed.Name = "RdGlazed"
        Me.RdGlazed.Size = New System.Drawing.Size(117, 23)
        Me.RdGlazed.TabIndex = 1
        Me.RdGlazed.TabStop = True
        Me.RdGlazed.Text = "&Glazed ($1.05)"
        Me.RdGlazed.UseVisualStyleBackColor = True
        '
        'GroupCoffee
        '
        Me.GroupCoffee.BackColor = System.Drawing.Color.LightPink
        Me.GroupCoffee.Controls.Add(Me.RdCapp)
        Me.GroupCoffee.Controls.Add(Me.RdRegular)
        Me.GroupCoffee.Controls.Add(Me.RdNone)
        Me.GroupCoffee.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupCoffee.Location = New System.Drawing.Point(43, 221)
        Me.GroupCoffee.Name = "GroupCoffee"
        Me.GroupCoffee.Size = New System.Drawing.Size(200, 114)
        Me.GroupCoffee.TabIndex = 1
        Me.GroupCoffee.TabStop = False
        Me.GroupCoffee.Text = "Coffee Choices"
        Me.ToolTip1.SetToolTip(Me.GroupCoffee, "Want some coffee?")
        '
        'RdCapp
        '
        Me.RdCapp.AutoSize = True
        Me.RdCapp.Location = New System.Drawing.Point(6, 77)
        Me.RdCapp.Name = "RdCapp"
        Me.RdCapp.Size = New System.Drawing.Size(150, 23)
        Me.RdCapp.TabIndex = 2
        Me.RdCapp.TabStop = True
        Me.RdCapp.Text = "Ca&ppuccino ($2.75)"
        Me.RdCapp.UseVisualStyleBackColor = True
        '
        'RdRegular
        '
        Me.RdRegular.AutoSize = True
        Me.RdRegular.Location = New System.Drawing.Point(6, 49)
        Me.RdRegular.Name = "RdRegular"
        Me.RdRegular.Size = New System.Drawing.Size(122, 23)
        Me.RdRegular.TabIndex = 1
        Me.RdRegular.TabStop = True
        Me.RdRegular.Text = "&Regular ($1.50)"
        Me.RdRegular.UseVisualStyleBackColor = True
        '
        'RdNone
        '
        Me.RdNone.AutoSize = True
        Me.RdNone.Location = New System.Drawing.Point(3, 16)
        Me.RdNone.Name = "RdNone"
        Me.RdNone.Size = New System.Drawing.Size(61, 23)
        Me.RdNone.TabIndex = 0
        Me.RdNone.TabStop = True
        Me.RdNone.Text = "&None"
        Me.RdNone.UseVisualStyleBackColor = True
        '
        'GroupTotals
        '
        Me.GroupTotals.BackColor = System.Drawing.Color.LightPink
        Me.GroupTotals.Controls.Add(Me.LblTotDue)
        Me.GroupTotals.Controls.Add(Me.LblSalesTax)
        Me.GroupTotals.Controls.Add(Me.LblSubTot)
        Me.GroupTotals.Controls.Add(Me.TxtTotDue)
        Me.GroupTotals.Controls.Add(Me.TxtSalesTax)
        Me.GroupTotals.Controls.Add(Me.TxtSubTot)
        Me.GroupTotals.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTotals.Location = New System.Drawing.Point(313, 77)
        Me.GroupTotals.Name = "GroupTotals"
        Me.GroupTotals.Size = New System.Drawing.Size(216, 125)
        Me.GroupTotals.TabIndex = 2
        Me.GroupTotals.TabStop = False
        Me.ToolTip1.SetToolTip(Me.GroupTotals, "Total before and after tax, as well as 6% tax rate")
        '
        'LblTotDue
        '
        Me.LblTotDue.AutoSize = True
        Me.LblTotDue.Location = New System.Drawing.Point(8, 82)
        Me.LblTotDue.Name = "LblTotDue"
        Me.LblTotDue.Size = New System.Drawing.Size(72, 19)
        Me.LblTotDue.TabIndex = 5
        Me.LblTotDue.Text = "Total Due:"
        '
        'LblSalesTax
        '
        Me.LblSalesTax.AutoSize = True
        Me.LblSalesTax.Location = New System.Drawing.Point(8, 53)
        Me.LblSalesTax.Name = "LblSalesTax"
        Me.LblSalesTax.Size = New System.Drawing.Size(66, 19)
        Me.LblSalesTax.TabIndex = 4
        Me.LblSalesTax.Text = "Sales Tax"
        '
        'LblSubTot
        '
        Me.LblSubTot.AutoSize = True
        Me.LblSubTot.Location = New System.Drawing.Point(8, 27)
        Me.LblSubTot.Name = "LblSubTot"
        Me.LblSubTot.Size = New System.Drawing.Size(62, 19)
        Me.LblSubTot.TabIndex = 3
        Me.LblSubTot.Text = "Subtotal"
        '
        'TxtTotDue
        '
        Me.TxtTotDue.Location = New System.Drawing.Point(98, 83)
        Me.TxtTotDue.Name = "TxtTotDue"
        Me.TxtTotDue.ReadOnly = True
        Me.TxtTotDue.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotDue.TabIndex = 2
        '
        'TxtSalesTax
        '
        Me.TxtSalesTax.Location = New System.Drawing.Point(98, 51)
        Me.TxtSalesTax.Name = "TxtSalesTax"
        Me.TxtSalesTax.ReadOnly = True
        Me.TxtSalesTax.Size = New System.Drawing.Size(100, 26)
        Me.TxtSalesTax.TabIndex = 1
        '
        'TxtSubTot
        '
        Me.TxtSubTot.Location = New System.Drawing.Point(98, 19)
        Me.TxtSubTot.Name = "TxtSubTot"
        Me.TxtSubTot.ReadOnly = True
        Me.TxtSubTot.Size = New System.Drawing.Size(100, 26)
        Me.TxtSubTot.TabIndex = 0
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.Color.Pink
        Me.BtnCalc.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnCalc.FlatAppearance.BorderSize = 3
        Me.BtnCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.BtnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalc.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalc.Location = New System.Drawing.Point(283, 278)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(130, 44)
        Me.BtnCalc.TabIndex = 3
        Me.BtnCalc.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.BtnCalc, "Calculate the total")
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Pink
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnExit.FlatAppearance.BorderSize = 3
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(438, 278)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(130, 44)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.BtnExit, "Exit and wait for your order")
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'LblTime
        '
        Me.LblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTime.AutoSize = True
        Me.LblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.Location = New System.Drawing.Point(13, 425)
        Me.LblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(43, 16)
        Me.LblTime.TabIndex = 10
        Me.LblTime.Text = "TIME"
        Me.ToolTip1.SetToolTip(Me.LblTime, "What time is it today?")
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Azure
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(542, 30)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Our doughnuts and coffee are the best in town!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(522, 379)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'FormMain
        '
        Me.AcceptButton = Me.BtnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.BtnExit
        Me.ClientSize = New System.Drawing.Size(598, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.GroupTotals)
        Me.Controls.Add(Me.GroupCoffee)
        Me.Controls.Add(Me.GroupDoughnut)
        Me.DoubleBuffered = True
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donut Shoppe"
        Me.GroupDoughnut.ResumeLayout(False)
        Me.GroupDoughnut.PerformLayout()
        Me.GroupCoffee.ResumeLayout(False)
        Me.GroupCoffee.PerformLayout()
        Me.GroupTotals.ResumeLayout(False)
        Me.GroupTotals.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupDoughnut As GroupBox
    Friend WithEvents RdFilled As RadioButton
    Friend WithEvents RdChoco As RadioButton
    Friend WithEvents RdSugar As RadioButton
    Friend WithEvents RdGlazed As RadioButton
    Friend WithEvents GroupCoffee As GroupBox
    Friend WithEvents RdCapp As RadioButton
    Friend WithEvents RdRegular As RadioButton
    Friend WithEvents RdNone As RadioButton
    Friend WithEvents GroupTotals As GroupBox
    Friend WithEvents LblTotDue As Label
    Friend WithEvents LblSalesTax As Label
    Friend WithEvents LblSubTot As Label
    Friend WithEvents TxtTotDue As TextBox
    Friend WithEvents TxtSalesTax As TextBox
    Friend WithEvents TxtSubTot As TextBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
