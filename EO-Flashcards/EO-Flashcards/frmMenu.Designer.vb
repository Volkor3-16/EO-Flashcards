<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnAdvancement = New System.Windows.Forms.Button()
        Me.btnTimeTrial = New System.Windows.Forms.Button()
        Me.btnArcade = New System.Windows.Forms.Button()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdvancement
        '
        Me.btnAdvancement.Enabled = False
        Me.btnAdvancement.Location = New System.Drawing.Point(12, 12)
        Me.btnAdvancement.Name = "btnAdvancement"
        Me.btnAdvancement.Size = New System.Drawing.Size(112, 75)
        Me.btnAdvancement.TabIndex = 0
        Me.btnAdvancement.Text = "Advancement Gamemode"
        Me.btnAdvancement.UseVisualStyleBackColor = True
        '
        'btnTimeTrial
        '
        Me.btnTimeTrial.Enabled = False
        Me.btnTimeTrial.Location = New System.Drawing.Point(130, 12)
        Me.btnTimeTrial.Name = "btnTimeTrial"
        Me.btnTimeTrial.Size = New System.Drawing.Size(75, 75)
        Me.btnTimeTrial.TabIndex = 1
        Me.btnTimeTrial.Text = "Time Trial Gamemode"
        Me.btnTimeTrial.UseVisualStyleBackColor = True
        '
        'btnArcade
        '
        Me.btnArcade.Location = New System.Drawing.Point(211, 12)
        Me.btnArcade.Name = "btnArcade"
        Me.btnArcade.Size = New System.Drawing.Size(119, 75)
        Me.btnArcade.TabIndex = 2
        Me.btnArcade.Text = "Arcade (Random) Gamemode"
        Me.btnArcade.UseVisualStyleBackColor = True
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.Location = New System.Drawing.Point(130, 93)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(75, 75)
        Me.btnAdminLogin.TabIndex = 15
        Me.btnAdminLogin.Text = "Admin Login (Requires Admin Pass)"
        Me.btnAdminLogin.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 176)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.Controls.Add(Me.btnArcade)
        Me.Controls.Add(Me.btnTimeTrial)
        Me.Controls.Add(Me.btnAdvancement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMenu"
        Me.Text = " Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdvancement As Button
    Friend WithEvents btnTimeTrial As Button
    Friend WithEvents btnArcade As Button
    Friend WithEvents btnAdminLogin As Button
End Class
