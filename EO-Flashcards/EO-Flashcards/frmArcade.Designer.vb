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
        Me.lblLineNumber.Location = New System.Drawing.Point(412, 169)
        Me.lblLineNumber.Name = "lblLineNumber"
        Me.lblLineNumber.Size = New System.Drawing.Size(35, 13)
        Me.lblLineNumber.TabIndex = 4
        Me.lblLineNumber.Text = "####"
        '
        'frmArcade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 247)
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
End Class
