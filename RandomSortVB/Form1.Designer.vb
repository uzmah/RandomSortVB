<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSortIntegers
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
        Me.btnSort = New System.Windows.Forms.Button()
        Me.nudValue = New System.Windows.Forms.NumericUpDown()
        Me.lstValues = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSort
        '
        Me.btnSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.Location = New System.Drawing.Point(115, 171)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(120, 23)
        Me.btnSort.TabIndex = 5
        Me.btnSort.Text = "Sort Integers"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'nudValue
        '
        Me.nudValue.Location = New System.Drawing.Point(115, 123)
        Me.nudValue.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudValue.Name = "nudValue"
        Me.nudValue.Size = New System.Drawing.Size(120, 20)
        Me.nudValue.TabIndex = 4
        Me.nudValue.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lstValues
        '
        Me.lstValues.FormattingEnabled = True
        Me.lstValues.Location = New System.Drawing.Point(241, 98)
        Me.lstValues.Name = "lstValues"
        Me.lstValues.Size = New System.Drawing.Size(120, 212)
        Me.lstValues.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Random Sort Integer List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmSortIntegers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 322)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.nudValue)
        Me.Controls.Add(Me.lstValues)
        Me.Name = "frmSortIntegers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sort Integers"
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnSort As Button
    Private WithEvents nudValue As NumericUpDown
    Private WithEvents lstValues As ListBox
    Friend WithEvents Label1 As Label
End Class
