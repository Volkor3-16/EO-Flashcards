<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.btnWipe = New System.Windows.Forms.Button()
        Me.btnAdminPassword = New System.Windows.Forms.Button()
        Me.btnClearUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWipe
        '
        Me.btnWipe.Enabled = False
        Me.btnWipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWipe.ForeColor = System.Drawing.Color.Red
        Me.btnWipe.Location = New System.Drawing.Point(336, 12)
        Me.btnWipe.Name = "btnWipe"
        Me.btnWipe.Size = New System.Drawing.Size(75, 75)
        Me.btnWipe.TabIndex = 8
        Me.btnWipe.Text = "Clear Database (CLEARS ALL DATA)"
        Me.btnWipe.UseVisualStyleBackColor = True
        '
        'btnAdminPassword
        '
        Me.btnAdminPassword.Location = New System.Drawing.Point(12, 12)
        Me.btnAdminPassword.Name = "btnAdminPassword"
        Me.btnAdminPassword.Size = New System.Drawing.Size(75, 75)
        Me.btnAdminPassword.TabIndex = 10
        Me.btnAdminPassword.Text = "Change Admin Password"
        Me.btnAdminPassword.UseVisualStyleBackColor = True
        '
        'btnClearUser
        '
        Me.btnClearUser.Location = New System.Drawing.Point(177, 12)
        Me.btnClearUser.Name = "btnClearUser"
        Me.btnClearUser.Size = New System.Drawing.Size(75, 75)
        Me.btnClearUser.TabIndex = 11
        Me.btnClearUser.Text = "Clear User Stats"
        Me.btnClearUser.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 108)
        Me.Controls.Add(Me.btnClearUser)
        Me.Controls.Add(Me.btnAdminPassword)
        Me.Controls.Add(Me.btnWipe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAdmin"
        Me.Text = "Esperanto Flash Cards - Admin Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWipe As Button
    Friend WithEvents btnAdminPassword As Button
    Friend WithEvents btnClearUser As Button
End Class
