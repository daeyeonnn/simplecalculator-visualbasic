<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBMI
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
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Weight in kg:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(176, 35)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(118, 29)
        Me.txtWeight.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Height in Meter:"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(176, 70)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(118, 29)
        Me.txtHeight.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "BMI:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Status:"
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.Location = New System.Drawing.Point(103, 155)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(191, 33)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBMI
        '
        Me.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBMI.Location = New System.Drawing.Point(103, 111)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(191, 33)
        Me.lblBMI.TabIndex = 8
        Me.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(71, 207)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(121, 35)
        Me.cmdCalculate.TabIndex = 9
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(198, 207)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(96, 35)
        Me.cmdClear.TabIndex = 10
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'frmBMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 258)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmBMI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents cmdCalculate As Button
    Friend WithEvents cmdClear As Button
End Class
