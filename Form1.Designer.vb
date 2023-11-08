<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsnum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoDivision = New System.Windows.Forms.RadioButton()
        Me.rdoMultiplication = New System.Windows.Forms.RadioButton()
        Me.rdoSubtract = New System.Windows.Forms.RadioButton()
        Me.rdoAddition = New System.Windows.Forms.RadioButton()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdCalc = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Number:"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(194, 39)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(154, 29)
        Me.txtfname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Second Number:"
        '
        'txtsnum
        '
        Me.txtsnum.Location = New System.Drawing.Point(194, 83)
        Me.txtsnum.Name = "txtsnum"
        Me.txtsnum.Size = New System.Drawing.Size(154, 29)
        Me.txtsnum.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TOTAL:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(194, 134)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(154, 32)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoDivision)
        Me.GroupBox1.Controls.Add(Me.rdoMultiplication)
        Me.GroupBox1.Controls.Add(Me.rdoSubtract)
        Me.GroupBox1.Controls.Add(Me.rdoAddition)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 159)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operator"
        '
        'rdoDivision
        '
        Me.rdoDivision.AutoSize = True
        Me.rdoDivision.Location = New System.Drawing.Point(27, 124)
        Me.rdoDivision.Name = "rdoDivision"
        Me.rdoDivision.Size = New System.Drawing.Size(94, 26)
        Me.rdoDivision.TabIndex = 3
        Me.rdoDivision.TabStop = True
        Me.rdoDivision.Text = "Division"
        Me.rdoDivision.UseVisualStyleBackColor = True
        '
        'rdoMultiplication
        '
        Me.rdoMultiplication.AutoSize = True
        Me.rdoMultiplication.Location = New System.Drawing.Point(27, 92)
        Me.rdoMultiplication.Name = "rdoMultiplication"
        Me.rdoMultiplication.Size = New System.Drawing.Size(135, 26)
        Me.rdoMultiplication.TabIndex = 2
        Me.rdoMultiplication.TabStop = True
        Me.rdoMultiplication.Text = "Multiplication"
        Me.rdoMultiplication.UseVisualStyleBackColor = True
        '
        'rdoSubtract
        '
        Me.rdoSubtract.AutoSize = True
        Me.rdoSubtract.Location = New System.Drawing.Point(27, 60)
        Me.rdoSubtract.Name = "rdoSubtract"
        Me.rdoSubtract.Size = New System.Drawing.Size(123, 26)
        Me.rdoSubtract.TabIndex = 1
        Me.rdoSubtract.TabStop = True
        Me.rdoSubtract.Text = "Subtraction"
        Me.rdoSubtract.UseVisualStyleBackColor = True
        '
        'rdoAddition
        '
        Me.rdoAddition.AutoSize = True
        Me.rdoAddition.Location = New System.Drawing.Point(27, 28)
        Me.rdoAddition.Name = "rdoAddition"
        Me.rdoAddition.Size = New System.Drawing.Size(97, 26)
        Me.rdoAddition.TabIndex = 0
        Me.rdoAddition.TabStop = True
        Me.rdoAddition.Text = "Addition"
        Me.rdoAddition.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(224, 232)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(124, 33)
        Me.cmdClear.TabIndex = 8
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(224, 271)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(124, 33)
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdCalc
        '
        Me.cmdCalc.Location = New System.Drawing.Point(224, 193)
        Me.cmdCalc.Name = "cmdCalc"
        Me.cmdCalc.Size = New System.Drawing.Size(124, 33)
        Me.cmdCalc.TabIndex = 10
        Me.cmdCalc.Text = "Calculate"
        Me.cmdCalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 457)
        Me.Controls.Add(Me.cmdCalc)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtsnum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsnum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoDivision As RadioButton
    Friend WithEvents rdoMultiplication As RadioButton
    Friend WithEvents rdoSubtract As RadioButton
    Friend WithEvents rdoAddition As RadioButton
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdCalc As Button
End Class
