<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeckingCostCalc
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSquareFootage = New System.Windows.Forms.Label()
        Me.txtFootage = New System.Windows.Forms.TextBox()
        Me.grpDeckType = New System.Windows.Forms.GroupBox()
        Me.radRedWood = New System.Windows.Forms.RadioButton()
        Me.radLumber = New System.Windows.Forms.RadioButton()
        Me.radComposite = New System.Windows.Forms.RadioButton()
        Me.lblTextCostEstimate = New System.Windows.Forms.Label()
        Me.lblCostEstimate = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.picDeck = New System.Windows.Forms.PictureBox()
        Me.grpDeckType.SuspendLayout()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Sienna
        Me.lblHeading.Location = New System.Drawing.Point(12, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(337, 37)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Decking Cost Calculator"
        '
        'lblSquareFootage
        '
        Me.lblSquareFootage.AutoSize = True
        Me.lblSquareFootage.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquareFootage.ForeColor = System.Drawing.Color.Sienna
        Me.lblSquareFootage.Location = New System.Drawing.Point(83, 54)
        Me.lblSquareFootage.Name = "lblSquareFootage"
        Me.lblSquareFootage.Size = New System.Drawing.Size(149, 25)
        Me.lblSquareFootage.TabIndex = 1
        Me.lblSquareFootage.Text = "Square Footage:"
        '
        'txtFootage
        '
        Me.txtFootage.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFootage.ForeColor = System.Drawing.Color.Sienna
        Me.txtFootage.Location = New System.Drawing.Point(238, 51)
        Me.txtFootage.Name = "txtFootage"
        Me.txtFootage.Size = New System.Drawing.Size(40, 33)
        Me.txtFootage.TabIndex = 2
        Me.txtFootage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpDeckType
        '
        Me.grpDeckType.BackColor = System.Drawing.Color.AliceBlue
        Me.grpDeckType.Controls.Add(Me.radComposite)
        Me.grpDeckType.Controls.Add(Me.radLumber)
        Me.grpDeckType.Controls.Add(Me.radRedWood)
        Me.grpDeckType.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDeckType.ForeColor = System.Drawing.Color.Sienna
        Me.grpDeckType.Location = New System.Drawing.Point(58, 90)
        Me.grpDeckType.Name = "grpDeckType"
        Me.grpDeckType.Size = New System.Drawing.Size(244, 106)
        Me.grpDeckType.TabIndex = 4
        Me.grpDeckType.TabStop = False
        Me.grpDeckType.Text = "Decking Type"
        '
        'radRedWood
        '
        Me.radRedWood.AutoSize = True
        Me.radRedWood.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRedWood.ForeColor = System.Drawing.Color.Sienna
        Me.radRedWood.Location = New System.Drawing.Point(16, 49)
        Me.radRedWood.Name = "radRedWood"
        Me.radRedWood.Size = New System.Drawing.Size(102, 27)
        Me.radRedWood.TabIndex = 0
        Me.radRedWood.Text = "Redwood"
        Me.radRedWood.UseVisualStyleBackColor = True
        '
        'radLumber
        '
        Me.radLumber.AutoSize = True
        Me.radLumber.Checked = True
        Me.radLumber.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLumber.ForeColor = System.Drawing.Color.Sienna
        Me.radLumber.Location = New System.Drawing.Point(16, 24)
        Me.radLumber.Name = "radLumber"
        Me.radLumber.Size = New System.Drawing.Size(222, 27)
        Me.radLumber.TabIndex = 1
        Me.radLumber.TabStop = True
        Me.radLumber.Text = "Pressure-Treated Lumber"
        Me.radLumber.UseVisualStyleBackColor = True
        '
        'radComposite
        '
        Me.radComposite.AutoSize = True
        Me.radComposite.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radComposite.ForeColor = System.Drawing.Color.Sienna
        Me.radComposite.Location = New System.Drawing.Point(16, 73)
        Me.radComposite.Name = "radComposite"
        Me.radComposite.Size = New System.Drawing.Size(112, 27)
        Me.radComposite.TabIndex = 2
        Me.radComposite.Text = "Composite"
        Me.radComposite.UseVisualStyleBackColor = True
        '
        'lblTextCostEstimate
        '
        Me.lblTextCostEstimate.AutoSize = True
        Me.lblTextCostEstimate.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextCostEstimate.ForeColor = System.Drawing.Color.Sienna
        Me.lblTextCostEstimate.Location = New System.Drawing.Point(65, 267)
        Me.lblTextCostEstimate.Name = "lblTextCostEstimate"
        Me.lblTextCostEstimate.Size = New System.Drawing.Size(130, 25)
        Me.lblTextCostEstimate.TabIndex = 5
        Me.lblTextCostEstimate.Text = "Cost Estimate"
        '
        'lblCostEstimate
        '
        Me.lblCostEstimate.AutoSize = True
        Me.lblCostEstimate.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostEstimate.ForeColor = System.Drawing.Color.Sienna
        Me.lblCostEstimate.Location = New System.Drawing.Point(201, 267)
        Me.lblCostEstimate.Name = "lblCostEstimate"
        Me.lblCostEstimate.Size = New System.Drawing.Size(94, 25)
        Me.lblCostEstimate.TabIndex = 6
        Me.lblCostEstimate.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Sienna
        Me.btnCalculate.Location = New System.Drawing.Point(41, 339)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 41)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Sienna
        Me.btnClear.Location = New System.Drawing.Point(207, 339)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 41)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'picDeck
        '
        Me.picDeck.Image = Global.DeckingCostCalculator.My.Resources.Resources.deck
        Me.picDeck.Location = New System.Drawing.Point(365, 1)
        Me.picDeck.Name = "picDeck"
        Me.picDeck.Size = New System.Drawing.Size(338, 390)
        Me.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeck.TabIndex = 9
        Me.picDeck.TabStop = False
        '
        'frmDeckingCostCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 392)
        Me.Controls.Add(Me.picDeck)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostEstimate)
        Me.Controls.Add(Me.lblTextCostEstimate)
        Me.Controls.Add(Me.grpDeckType)
        Me.Controls.Add(Me.txtFootage)
        Me.Controls.Add(Me.lblSquareFootage)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmDeckingCostCalc"
        Me.Text = "Decking Cost Calculator"
        Me.grpDeckType.ResumeLayout(False)
        Me.grpDeckType.PerformLayout()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSquareFootage As Label
    Friend WithEvents txtFootage As TextBox
    Friend WithEvents grpDeckType As GroupBox
    Friend WithEvents radComposite As RadioButton
    Friend WithEvents radLumber As RadioButton
    Friend WithEvents radRedWood As RadioButton
    Friend WithEvents lblTextCostEstimate As Label
    Friend WithEvents lblCostEstimate As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents picDeck As PictureBox
End Class
