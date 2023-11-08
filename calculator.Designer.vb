<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculator
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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btOne = New System.Windows.Forms.Button()
        Me.btTwo = New System.Windows.Forms.Button()
        Me.btThree = New System.Windows.Forms.Button()
        Me.btFour = New System.Windows.Forms.Button()
        Me.btFive = New System.Windows.Forms.Button()
        Me.btSix = New System.Windows.Forms.Button()
        Me.btSeven = New System.Windows.Forms.Button()
        Me.btEight = New System.Windows.Forms.Button()
        Me.btNine = New System.Windows.Forms.Button()
        Me.btZero = New System.Windows.Forms.Button()
        Me.btEquals = New System.Windows.Forms.Button()
        Me.btPlus = New System.Windows.Forms.Button()
        Me.btMinus = New System.Windows.Forms.Button()
        Me.btMultiply = New System.Windows.Forms.Button()
        Me.btDivide = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.btDot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.Lime
        Me.lblDisplay.ForeColor = System.Drawing.Color.Black
        Me.lblDisplay.Location = New System.Drawing.Point(12, 9)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(205, 42)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btOne
        '
        Me.btOne.BackColor = System.Drawing.Color.Black
        Me.btOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btOne.ForeColor = System.Drawing.Color.Lime
        Me.btOne.Location = New System.Drawing.Point(12, 65)
        Me.btOne.Name = "btOne"
        Me.btOne.Size = New System.Drawing.Size(43, 43)
        Me.btOne.TabIndex = 1
        Me.btOne.Text = "1"
        Me.btOne.UseVisualStyleBackColor = False
        '
        'btTwo
        '
        Me.btTwo.BackColor = System.Drawing.Color.Black
        Me.btTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTwo.ForeColor = System.Drawing.Color.Lime
        Me.btTwo.Location = New System.Drawing.Point(61, 65)
        Me.btTwo.Name = "btTwo"
        Me.btTwo.Size = New System.Drawing.Size(43, 43)
        Me.btTwo.TabIndex = 2
        Me.btTwo.Text = "2"
        Me.btTwo.UseVisualStyleBackColor = False
        '
        'btThree
        '
        Me.btThree.BackColor = System.Drawing.Color.Black
        Me.btThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThree.ForeColor = System.Drawing.Color.Lime
        Me.btThree.Location = New System.Drawing.Point(110, 65)
        Me.btThree.Name = "btThree"
        Me.btThree.Size = New System.Drawing.Size(43, 43)
        Me.btThree.TabIndex = 3
        Me.btThree.Text = "3"
        Me.btThree.UseVisualStyleBackColor = False
        '
        'btFour
        '
        Me.btFour.BackColor = System.Drawing.Color.Black
        Me.btFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFour.ForeColor = System.Drawing.Color.Lime
        Me.btFour.Location = New System.Drawing.Point(12, 114)
        Me.btFour.Name = "btFour"
        Me.btFour.Size = New System.Drawing.Size(43, 43)
        Me.btFour.TabIndex = 4
        Me.btFour.Text = "4"
        Me.btFour.UseVisualStyleBackColor = False
        '
        'btFive
        '
        Me.btFive.BackColor = System.Drawing.Color.Black
        Me.btFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFive.ForeColor = System.Drawing.Color.Lime
        Me.btFive.Location = New System.Drawing.Point(61, 114)
        Me.btFive.Name = "btFive"
        Me.btFive.Size = New System.Drawing.Size(43, 43)
        Me.btFive.TabIndex = 5
        Me.btFive.Text = "5"
        Me.btFive.UseVisualStyleBackColor = False
        '
        'btSix
        '
        Me.btSix.BackColor = System.Drawing.Color.Black
        Me.btSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSix.ForeColor = System.Drawing.Color.Lime
        Me.btSix.Location = New System.Drawing.Point(110, 114)
        Me.btSix.Name = "btSix"
        Me.btSix.Size = New System.Drawing.Size(43, 43)
        Me.btSix.TabIndex = 6
        Me.btSix.Text = "6"
        Me.btSix.UseVisualStyleBackColor = False
        '
        'btSeven
        '
        Me.btSeven.BackColor = System.Drawing.Color.Black
        Me.btSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSeven.ForeColor = System.Drawing.Color.Lime
        Me.btSeven.Location = New System.Drawing.Point(12, 163)
        Me.btSeven.Name = "btSeven"
        Me.btSeven.Size = New System.Drawing.Size(43, 43)
        Me.btSeven.TabIndex = 7
        Me.btSeven.Text = "7"
        Me.btSeven.UseVisualStyleBackColor = False
        '
        'btEight
        '
        Me.btEight.BackColor = System.Drawing.Color.Black
        Me.btEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEight.ForeColor = System.Drawing.Color.Lime
        Me.btEight.Location = New System.Drawing.Point(61, 163)
        Me.btEight.Name = "btEight"
        Me.btEight.Size = New System.Drawing.Size(43, 43)
        Me.btEight.TabIndex = 8
        Me.btEight.Text = "8"
        Me.btEight.UseVisualStyleBackColor = False
        '
        'btNine
        '
        Me.btNine.BackColor = System.Drawing.Color.Black
        Me.btNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNine.ForeColor = System.Drawing.Color.Lime
        Me.btNine.Location = New System.Drawing.Point(110, 163)
        Me.btNine.Name = "btNine"
        Me.btNine.Size = New System.Drawing.Size(43, 43)
        Me.btNine.TabIndex = 9
        Me.btNine.Text = "9"
        Me.btNine.UseVisualStyleBackColor = False
        '
        'btZero
        '
        Me.btZero.BackColor = System.Drawing.Color.Black
        Me.btZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btZero.ForeColor = System.Drawing.Color.Lime
        Me.btZero.Location = New System.Drawing.Point(12, 212)
        Me.btZero.Name = "btZero"
        Me.btZero.Size = New System.Drawing.Size(43, 43)
        Me.btZero.TabIndex = 10
        Me.btZero.Text = "0"
        Me.btZero.UseVisualStyleBackColor = False
        '
        'btEquals
        '
        Me.btEquals.BackColor = System.Drawing.Color.Black
        Me.btEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEquals.ForeColor = System.Drawing.Color.Lime
        Me.btEquals.Location = New System.Drawing.Point(110, 212)
        Me.btEquals.Name = "btEquals"
        Me.btEquals.Size = New System.Drawing.Size(43, 43)
        Me.btEquals.TabIndex = 11
        Me.btEquals.Text = "="
        Me.btEquals.UseVisualStyleBackColor = False
        '
        'btPlus
        '
        Me.btPlus.BackColor = System.Drawing.Color.Black
        Me.btPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPlus.ForeColor = System.Drawing.Color.Lime
        Me.btPlus.Location = New System.Drawing.Point(174, 65)
        Me.btPlus.Name = "btPlus"
        Me.btPlus.Size = New System.Drawing.Size(43, 43)
        Me.btPlus.TabIndex = 12
        Me.btPlus.Text = "+"
        Me.btPlus.UseVisualStyleBackColor = False
        '
        'btMinus
        '
        Me.btMinus.BackColor = System.Drawing.Color.Black
        Me.btMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMinus.ForeColor = System.Drawing.Color.Lime
        Me.btMinus.Location = New System.Drawing.Point(174, 114)
        Me.btMinus.Name = "btMinus"
        Me.btMinus.Size = New System.Drawing.Size(43, 43)
        Me.btMinus.TabIndex = 13
        Me.btMinus.Text = "-"
        Me.btMinus.UseVisualStyleBackColor = False
        '
        'btMultiply
        '
        Me.btMultiply.BackColor = System.Drawing.Color.Black
        Me.btMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMultiply.ForeColor = System.Drawing.Color.Lime
        Me.btMultiply.Location = New System.Drawing.Point(174, 163)
        Me.btMultiply.Name = "btMultiply"
        Me.btMultiply.Size = New System.Drawing.Size(43, 43)
        Me.btMultiply.TabIndex = 14
        Me.btMultiply.Text = "*"
        Me.btMultiply.UseVisualStyleBackColor = False
        '
        'btDivide
        '
        Me.btDivide.BackColor = System.Drawing.Color.Black
        Me.btDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDivide.ForeColor = System.Drawing.Color.Lime
        Me.btDivide.Location = New System.Drawing.Point(174, 212)
        Me.btDivide.Name = "btDivide"
        Me.btDivide.Size = New System.Drawing.Size(43, 43)
        Me.btDivide.TabIndex = 15
        Me.btDivide.Text = "/"
        Me.btDivide.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.Black
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClear.ForeColor = System.Drawing.Color.Lime
        Me.cmdClear.Location = New System.Drawing.Point(128, 261)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(92, 32)
        Me.cmdClear.TabIndex = 16
        Me.cmdClear.Text = "CLEAR"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'btDot
        '
        Me.btDot.BackColor = System.Drawing.Color.Black
        Me.btDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDot.ForeColor = System.Drawing.Color.Lime
        Me.btDot.Location = New System.Drawing.Point(61, 212)
        Me.btDot.Name = "btDot"
        Me.btDot.Size = New System.Drawing.Size(43, 43)
        Me.btDot.TabIndex = 17
        Me.btDot.Text = "."
        Me.btDot.UseVisualStyleBackColor = False
        '
        'calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(232, 305)
        Me.Controls.Add(Me.btDot)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.btDivide)
        Me.Controls.Add(Me.btMultiply)
        Me.Controls.Add(Me.btMinus)
        Me.Controls.Add(Me.btPlus)
        Me.Controls.Add(Me.btEquals)
        Me.Controls.Add(Me.btZero)
        Me.Controls.Add(Me.btNine)
        Me.Controls.Add(Me.btEight)
        Me.Controls.Add(Me.btSeven)
        Me.Controls.Add(Me.btSix)
        Me.Controls.Add(Me.btFive)
        Me.Controls.Add(Me.btFour)
        Me.Controls.Add(Me.btThree)
        Me.Controls.Add(Me.btTwo)
        Me.Controls.Add(Me.btOne)
        Me.Controls.Add(Me.lblDisplay)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDisplay As Label
    Friend WithEvents btOne As Button
    Friend WithEvents btTwo As Button
    Friend WithEvents btThree As Button
    Friend WithEvents btFour As Button
    Friend WithEvents btFive As Button
    Friend WithEvents btSix As Button
    Friend WithEvents btSeven As Button
    Friend WithEvents btEight As Button
    Friend WithEvents btNine As Button
    Friend WithEvents btZero As Button
    Friend WithEvents btEquals As Button
    Friend WithEvents btPlus As Button
    Friend WithEvents btMinus As Button
    Friend WithEvents btMultiply As Button
    Friend WithEvents btDivide As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents btDot As Button
End Class
