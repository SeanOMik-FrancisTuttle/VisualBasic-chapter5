<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicConvention
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radConventionAutograph = New System.Windows.Forms.RadioButton()
        Me.radConventionSuper = New System.Windows.Forms.RadioButton()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblTxtCost = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comic Convention Tickets"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radConvention)
        Me.GroupBox1.Controls.Add(Me.radConventionAutograph)
        Me.GroupBox1.Controls.Add(Me.radConventionSuper)
        Me.GroupBox1.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 94)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Ticket"
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConvention.Location = New System.Drawing.Point(20, 65)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(134, 25)
        Me.radConvention.TabIndex = 4
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention ($209)"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radConventionAutograph
        '
        Me.radConventionAutograph.AutoSize = True
        Me.radConventionAutograph.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConventionAutograph.Location = New System.Drawing.Point(20, 42)
        Me.radConventionAutograph.Name = "radConventionAutograph"
        Me.radConventionAutograph.Size = New System.Drawing.Size(217, 25)
        Me.radConventionAutograph.TabIndex = 3
        Me.radConventionAutograph.TabStop = True
        Me.radConventionAutograph.Text = "Convention + Autographs ($275)"
        Me.radConventionAutograph.UseVisualStyleBackColor = True
        '
        'radConventionSuper
        '
        Me.radConventionSuper.AutoSize = True
        Me.radConventionSuper.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConventionSuper.Location = New System.Drawing.Point(20, 19)
        Me.radConventionSuper.Name = "radConventionSuper"
        Me.radConventionSuper.Size = New System.Drawing.Size(278, 25)
        Me.radConventionSuper.TabIndex = 2
        Me.radConventionSuper.TabStop = True
        Me.radConventionSuper.Text = "Convention + Superhero Experience ($380)"
        Me.radConventionSuper.UseVisualStyleBackColor = True
        '
        'btnCost
        '
        Me.btnCost.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(63, 247)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(110, 40)
        Me.btnCost.TabIndex = 2
        Me.btnCost.Text = "Get Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(223, 248)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 40)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(191, 90)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 20)
        Me.txtSize.TabIndex = 4
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.Location = New System.Drawing.Point(105, 90)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(75, 21)
        Me.lblSize.TabIndex = 5
        Me.lblSize.Text = "Group Size:"
        '
        'lblTxtCost
        '
        Me.lblTxtCost.AutoSize = True
        Me.lblTxtCost.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxtCost.Location = New System.Drawing.Point(144, 219)
        Me.lblTxtCost.Name = "lblTxtCost"
        Me.lblTxtCost.Size = New System.Drawing.Size(40, 21)
        Me.lblTxtCost.TabIndex = 6
        Me.lblTxtCost.Text = "Cost:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(190, 219)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(62, 21)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "$0000.00"
        '
        'frmComicConvention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 316)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTxtCost)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmComicConvention"
        Me.Text = "Comic Convention"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radConventionAutograph As RadioButton
    Friend WithEvents radConventionSuper As RadioButton
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblSize As Label
    Friend WithEvents lblTxtCost As Label
    Friend WithEvents lblCost As Label
End Class
