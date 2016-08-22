<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArcade
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
        Me.txtEsperanto = New System.Windows.Forms.TextBox()
        Me.txtTranslated = New System.Windows.Forms.TextBox()
        Me.lblLineNumber = New System.Windows.Forms.Label()
        Me.lblTextCorrect = New System.Windows.Forms.Label()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEsperanto
        '
        Me.txtEsperanto.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtEsperanto.Font = New System.Drawing.Font("Open Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEsperanto.Location = New System.Drawing.Point(13, 13)
        Me.txtEsperanto.Multiline = True
        Me.txtEsperanto.Name = "txtEsperanto"
        Me.txtEsperanto.ReadOnly = True
        Me.txtEsperanto.Size = New System.Drawing.Size(842, 149)
        Me.txtEsperanto.TabIndex = 0
        '
        'txtTranslated
        '
        Me.txtTranslated.Font = New System.Drawing.Font("Open Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTranslated.Location = New System.Drawing.Point(12, 198)
        Me.txtTranslated.Name = "txtTranslated"
        Me.txtTranslated.Size = New System.Drawing.Size(843, 40)
        Me.txtTranslated.TabIndex = 1
        '
        'lblLineNumber
        '
        Me.lblLineNumber.AutoSize = True
        Me.lblLineNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineNumber.Location = New System.Drawing.Point(415, 169)
        Me.lblLineNumber.Name = "lblLineNumber"
        Me.lblLineNumber.Size = New System.Drawing.Size(45, 20)
        Me.lblLineNumber.TabIndex = 4
        Me.lblLineNumber.Text = "####"
        '
        'lblTextCorrect
        '
        Me.lblTextCorrect.AutoSize = True
        Me.lblTextCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextCorrect.Location = New System.Drawing.Point(617, 169)
        Me.lblTextCorrect.Name = "lblTextCorrect"
        Me.lblTextCorrect.Size = New System.Drawing.Size(130, 20)
        Me.lblTextCorrect.TabIndex = 5
        Me.lblTextCorrect.Text = "Correct Answers:"
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrect.Location = New System.Drawing.Point(753, 169)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(19, 20)
        Me.lblCorrect.TabIndex = 6
        Me.lblCorrect.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type in lowercase, otherwise it won't work"
        '
        'frmArcade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 247)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCorrect)
        Me.Controls.Add(Me.lblTextCorrect)
        Me.Controls.Add(Me.lblLineNumber)
        Me.Controls.Add(Me.txtTranslated)
        Me.Controls.Add(Me.txtEsperanto)
        Me.Name = "frmArcade"
        Me.Text = "frmArcade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEsperanto As TextBox
    Friend WithEvents txtTranslated As TextBox
    Friend WithEvents lblLineNumber As Label
    Friend WithEvents lblTextCorrect As Label
    Friend WithEvents lblCorrect As Label
    Friend WithEvents Label1 As Label
End Class
