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
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblBillToPay = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUsed = New System.Windows.Forms.TextBox()
        Me.txtPay = New System.Windows.Forms.TextBox()
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
        Me.lblTitle.Size = New System.Drawing.Size(263, 60)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Electric Bill"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.BackColor = System.Drawing.Color.Transparent
        Me.lblUnits.Font = New System.Drawing.Font("Javanese Text", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(281, 71)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(237, 91)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "Units Used"
        '
        'lblBillToPay
        '
        Me.lblBillToPay.AutoSize = True
        Me.lblBillToPay.BackColor = System.Drawing.Color.Transparent
        Me.lblBillToPay.Font = New System.Drawing.Font("Javanese Text", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillToPay.Location = New System.Drawing.Point(290, 218)
        Me.lblBillToPay.Name = "lblBillToPay"
        Me.lblBillToPay.Size = New System.Drawing.Size(237, 91)
        Me.lblBillToPay.TabIndex = 2
        Me.lblBillToPay.Text = "Bill To Pay"
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
        'txtUsed
        '
        Me.txtUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsed.Location = New System.Drawing.Point(572, 99)
        Me.txtUsed.Name = "txtUsed"
        Me.txtUsed.Size = New System.Drawing.Size(250, 29)
        Me.txtUsed.TabIndex = 4
        '
        'txtPay
        '
        Me.txtPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.Location = New System.Drawing.Point(572, 246)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(250, 29)
        Me.txtPay.TabIndex = 5
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
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.txtUsed)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBillToPay)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1150, 650)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1150, 650)
        Me.Name = "frmCallCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Electric Bill"
        Me.TransparencyKey = System.Drawing.Color.HotPink
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblUnits As System.Windows.Forms.Label
    Friend WithEvents lblBillToPay As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtUsed As System.Windows.Forms.TextBox
    Friend WithEvents txtPay As System.Windows.Forms.TextBox
    Friend WithEvents btnWeekDay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
