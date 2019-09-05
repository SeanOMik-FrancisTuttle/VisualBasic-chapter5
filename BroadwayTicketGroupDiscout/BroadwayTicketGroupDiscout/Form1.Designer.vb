<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroadwayTicketGroupDiscount
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
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblTxtCost = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Broadway Ticket Group Discount"
        '
        'btnCost
        '
        Me.btnCost.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(63, 156)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(110, 40)
        Me.btnCost.TabIndex = 2
        Me.btnCost.Text = "Get Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(223, 157)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 40)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(215, 84)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 20)
        Me.txtSize.TabIndex = 4
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.Location = New System.Drawing.Point(82, 84)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(123, 21)
        Me.lblSize.TabIndex = 5
        Me.lblSize.Text = "Number of Tickets:"
        '
        'lblTxtCost
        '
        Me.lblTxtCost.AutoSize = True
        Me.lblTxtCost.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxtCost.Location = New System.Drawing.Point(144, 128)
        Me.lblTxtCost.Name = "lblTxtCost"
        Me.lblTxtCost.Size = New System.Drawing.Size(40, 21)
        Me.lblTxtCost.TabIndex = 6
        Me.lblTxtCost.Text = "Cost:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Haettenschweiler", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(190, 128)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(62, 21)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "$0000.00"
        '
        'frmBroadwayTicketGroupDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 214)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTxtCost)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBroadwayTicketGroupDiscount"
        Me.Text = "London Tube Tickets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblSize As Label
    Friend WithEvents lblTxtCost As Label
    Friend WithEvents lblCost As Label
End Class
