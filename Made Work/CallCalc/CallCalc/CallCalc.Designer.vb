<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCallCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCallCalc))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblNoOfMins = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.TextBox()
        Me.btnWeekDay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(430, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(320, 60)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "VAT Calculator"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Javanese Text", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(236, 71)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(282, 91)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "NET Amount"
        '
        'lblNoOfMins
        '
        Me.lblNoOfMins.AutoSize = True
        Me.lblNoOfMins.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfMins.Font = New System.Drawing.Font("Javanese Text", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfMins.Location = New System.Drawing.Point(243, 218)
        Me.lblNoOfMins.Name = "lblNoOfMins"
        Me.lblNoOfMins.Size = New System.Drawing.Size(275, 91)
        Me.lblNoOfMins.TabIndex = 2
        Me.lblNoOfMins.Text = "VAT Amount"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(1130, 620)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 10)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(572, 99)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(250, 29)
        Me.txtAmount.TabIndex = 4
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(572, 246)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(250, 29)
        Me.lblResult.TabIndex = 5
        '
        'btnWeekDay
        '
        Me.btnWeekDay.BackColor = System.Drawing.Color.Violet
        Me.btnWeekDay.Font = New System.Drawing.Font("Javanese Text", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeekDay.Location = New System.Drawing.Point(449, 357)
        Me.btnWeekDay.Name = "btnWeekDay"
        Me.btnWeekDay.Size = New System.Drawing.Size(292, 77)
        Me.btnWeekDay.TabIndex = 6
        Me.btnWeekDay.Text = "Calculate"
        Me.btnWeekDay.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Violet
        Me.btnExit.Font = New System.Drawing.Font("Javanese Text", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(449, 522)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(292, 77)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmCallCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1134, 611)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnWeekDay)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNoOfMins)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1150, 650)
        Me.MinimumSize = New System.Drawing.Size(1150, 650)
        Me.Name = "frmCallCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VAT Calc"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblNoOfMins As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.TextBox
    Friend WithEvents btnWeekDay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
