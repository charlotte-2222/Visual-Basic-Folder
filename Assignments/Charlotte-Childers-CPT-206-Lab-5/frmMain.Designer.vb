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
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnNxtSkate = New System.Windows.Forms.Button()
        Me.BtnRecord = New System.Windows.Forms.Button()
        Me.scoreGrouping = New System.Windows.Forms.GroupBox()
        Me.LblAvg = New System.Windows.Forms.Label()
        Me.LblNumScore = New System.Windows.Forms.Label()
        Me.LblTotScore = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtAverage = New System.Windows.Forms.TextBox()
        Me.TxtNumScore = New System.Windows.Forms.TextBox()
        Me.ListScore = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.scoreGrouping.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTime
        '
        Me.LblTime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTime.AutoSize = True
        Me.LblTime.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.Location = New System.Drawing.Point(1, 337)
        Me.LblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(44, 20)
        Me.LblTime.TabIndex = 15
        Me.LblTime.Text = "TIME"
        '
        'LblScore
        '
        Me.LblScore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblScore.AutoSize = True
        Me.LblScore.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScore.Location = New System.Drawing.Point(26, 40)
        Me.LblScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(47, 20)
        Me.LblScore.TabIndex = 14
        Me.LblScore.Text = "&Score"
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
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(379, 243)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(127, 30)
        Me.BtnExit.TabIndex = 13
        Me.BtnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.BtnExit, "Exit the Program")
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnNxtSkate
        '
        Me.BtnNxtSkate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNxtSkate.BackColor = System.Drawing.Color.AliceBlue
        Me.BtnNxtSkate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnNxtSkate.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnNxtSkate.FlatAppearance.BorderSize = 3
        Me.BtnNxtSkate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnNxtSkate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine
        Me.BtnNxtSkate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNxtSkate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNxtSkate.Location = New System.Drawing.Point(379, 167)
        Me.BtnNxtSkate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNxtSkate.Name = "BtnNxtSkate"
        Me.BtnNxtSkate.Size = New System.Drawing.Size(127, 30)
        Me.BtnNxtSkate.TabIndex = 11
        Me.BtnNxtSkate.Text = "&Next Skater"
        Me.ToolTip1.SetToolTip(Me.BtnNxtSkate, "Reset and Move to Next skater")
        Me.BtnNxtSkate.UseVisualStyleBackColor = False
        '
        'BtnRecord
        '
        Me.BtnRecord.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRecord.BackColor = System.Drawing.Color.AliceBlue
        Me.BtnRecord.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnRecord.FlatAppearance.BorderSize = 3
        Me.BtnRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine
        Me.BtnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecord.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecord.Location = New System.Drawing.Point(379, 86)
        Me.BtnRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRecord.Name = "BtnRecord"
        Me.BtnRecord.Size = New System.Drawing.Size(127, 30)
        Me.BtnRecord.TabIndex = 10
        Me.BtnRecord.Text = "&Record Score"
        Me.ToolTip1.SetToolTip(Me.BtnRecord, "Record Score")
        Me.BtnRecord.UseVisualStyleBackColor = False
        '
        'scoreGrouping
        '
        Me.scoreGrouping.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.scoreGrouping.BackColor = System.Drawing.Color.Honeydew
        Me.scoreGrouping.Controls.Add(Me.LblAvg)
        Me.scoreGrouping.Controls.Add(Me.LblNumScore)
        Me.scoreGrouping.Controls.Add(Me.LblTotScore)
        Me.scoreGrouping.Controls.Add(Me.TxtTotal)
        Me.scoreGrouping.Controls.Add(Me.TxtAverage)
        Me.scoreGrouping.Controls.Add(Me.TxtNumScore)
        Me.scoreGrouping.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.scoreGrouping.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreGrouping.ForeColor = System.Drawing.Color.Black
        Me.scoreGrouping.Location = New System.Drawing.Point(159, 52)
        Me.scoreGrouping.Margin = New System.Windows.Forms.Padding(4)
        Me.scoreGrouping.Name = "scoreGrouping"
        Me.scoreGrouping.Padding = New System.Windows.Forms.Padding(4)
        Me.scoreGrouping.Size = New System.Drawing.Size(172, 260)
        Me.scoreGrouping.TabIndex = 12
        Me.scoreGrouping.TabStop = False
        '
        'LblAvg
        '
        Me.LblAvg.AutoSize = True
        Me.LblAvg.Location = New System.Drawing.Point(16, 171)
        Me.LblAvg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAvg.Name = "LblAvg"
        Me.LblAvg.Size = New System.Drawing.Size(112, 20)
        Me.LblAvg.TabIndex = 8
        Me.LblAvg.Text = "Average Score:"
        '
        'LblNumScore
        '
        Me.LblNumScore.AutoSize = True
        Me.LblNumScore.Location = New System.Drawing.Point(16, 101)
        Me.LblNumScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNumScore.Name = "LblNumScore"
        Me.LblNumScore.Size = New System.Drawing.Size(136, 20)
        Me.LblNumScore.TabIndex = 7
        Me.LblNumScore.Text = "Number of Scores:"
        '
        'LblTotScore
        '
        Me.LblTotScore.AutoSize = True
        Me.LblTotScore.Location = New System.Drawing.Point(16, 27)
        Me.LblTotScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTotScore.Name = "LblTotScore"
        Me.LblTotScore.Size = New System.Drawing.Size(88, 20)
        Me.LblTotScore.TabIndex = 6
        Me.LblTotScore.Text = "Total Score:"
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.White
        Me.TxtTotal.Location = New System.Drawing.Point(20, 48)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(132, 27)
        Me.TxtTotal.TabIndex = 0
        Me.TxtTotal.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TxtTotal, "Total Score for All Skaters")
        '
        'TxtAverage
        '
        Me.TxtAverage.BackColor = System.Drawing.Color.White
        Me.TxtAverage.Location = New System.Drawing.Point(20, 205)
        Me.TxtAverage.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAverage.Name = "TxtAverage"
        Me.TxtAverage.ReadOnly = True
        Me.TxtAverage.Size = New System.Drawing.Size(132, 27)
        Me.TxtAverage.TabIndex = 2
        Me.TxtAverage.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TxtAverage, "Average of all Skaters")
        '
        'TxtNumScore
        '
        Me.TxtNumScore.BackColor = System.Drawing.Color.White
        Me.TxtNumScore.Location = New System.Drawing.Point(20, 129)
        Me.TxtNumScore.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumScore.Name = "TxtNumScore"
        Me.TxtNumScore.ReadOnly = True
        Me.TxtNumScore.Size = New System.Drawing.Size(132, 27)
        Me.TxtNumScore.TabIndex = 1
        Me.TxtNumScore.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TxtNumScore, "Number of Skaters Scored")
        '
        'ListScore
        '
        Me.ListScore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListScore.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListScore.FormattingEnabled = True
        Me.ListScore.ItemHeight = 19
        Me.ListScore.Location = New System.Drawing.Point(26, 61)
        Me.ListScore.Margin = New System.Windows.Forms.Padding(4)
        Me.ListScore.Name = "ListScore"
        Me.ListScore.Size = New System.Drawing.Size(89, 213)
        Me.ListScore.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.ListScore, "Select Scores to Assign Skaters")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Mills Skating Rink"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(458, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.BtnRecord
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.CancelButton = Me.BtnExit
        Me.ClientSize = New System.Drawing.Size(532, 359)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnNxtSkate)
        Me.Controls.Add(Me.BtnRecord)
        Me.Controls.Add(Me.scoreGrouping)
        Me.Controls.Add(Me.ListScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charlotte Childers, CPT 206 Lab 5"
        Me.scoreGrouping.ResumeLayout(False)
        Me.scoreGrouping.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTime As Label
    Friend WithEvents LblScore As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnNxtSkate As Button
    Friend WithEvents BtnRecord As Button
    Friend WithEvents scoreGrouping As GroupBox
    Friend WithEvents LblAvg As Label
    Friend WithEvents LblNumScore As Label
    Friend WithEvents LblTotScore As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtAverage As TextBox
    Friend WithEvents TxtNumScore As TextBox
    Friend WithEvents ListScore As ListBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
