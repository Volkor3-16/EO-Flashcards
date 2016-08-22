<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStats
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
        Me.lblTTotalCorrect = New System.Windows.Forms.Label()
        Me.lblTTotalIncorrect = New System.Windows.Forms.Label()
        Me.lblTotalCorrect = New System.Windows.Forms.Label()
        Me.lblTotalIncorrect = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTTotalCorrect
        '
        Me.lblTTotalCorrect.AutoSize = True
        Me.lblTTotalCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTTotalCorrect.Location = New System.Drawing.Point(11, 9)
        Me.lblTTotalCorrect.Name = "lblTTotalCorrect"
        Me.lblTTotalCorrect.Size = New System.Drawing.Size(100, 20)
        Me.lblTTotalCorrect.TabIndex = 0
        Me.lblTTotalCorrect.Text = "Total Correct"
        '
        'lblTTotalIncorrect
        '
        Me.lblTTotalIncorrect.AutoSize = True
        Me.lblTTotalIncorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTTotalIncorrect.Location = New System.Drawing.Point(11, 39)
        Me.lblTTotalIncorrect.Name = "lblTTotalIncorrect"
        Me.lblTTotalIncorrect.Size = New System.Drawing.Size(111, 20)
        Me.lblTTotalIncorrect.TabIndex = 1
        Me.lblTTotalIncorrect.Text = "Total Incorrect"
        '
        'lblTotalCorrect
        '
        Me.lblTotalCorrect.AutoSize = True
        Me.lblTotalCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCorrect.Location = New System.Drawing.Point(120, 9)
        Me.lblTotalCorrect.Name = "lblTotalCorrect"
        Me.lblTotalCorrect.Size = New System.Drawing.Size(18, 20)
        Me.lblTotalCorrect.TabIndex = 2
        Me.lblTotalCorrect.Text = "0"
        '
        'lblTotalIncorrect
        '
        Me.lblTotalIncorrect.AutoSize = True
        Me.lblTotalIncorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalIncorrect.Location = New System.Drawing.Point(120, 39)
        Me.lblTotalIncorrect.Name = "lblTotalIncorrect"
        Me.lblTotalIncorrect.Size = New System.Drawing.Size(18, 20)
        Me.lblTotalIncorrect.TabIndex = 3
        Me.lblTotalIncorrect.Text = "0"
        '
        'frmStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 79)
        Me.Controls.Add(Me.lblTotalIncorrect)
        Me.Controls.Add(Me.lblTotalCorrect)
        Me.Controls.Add(Me.lblTTotalIncorrect)
        Me.Controls.Add(Me.lblTTotalCorrect)
        Me.Name = "frmStats"
        Me.Text = "frmStats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTTotalCorrect As Label
    Friend WithEvents lblTTotalIncorrect As Label
    Friend WithEvents lblTotalCorrect As Label
    Friend WithEvents lblTotalIncorrect As Label
End Class
