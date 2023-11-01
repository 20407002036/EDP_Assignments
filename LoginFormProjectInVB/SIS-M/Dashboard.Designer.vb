<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lbfUsername = New System.Windows.Forms.Label()
        Me.lbfFullName = New System.Windows.Forms.Label()
        Me.lbfPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogout.Location = New System.Drawing.Point(293, 442)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(81, 42)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lbfUsername
        '
        Me.lbfUsername.AutoSize = True
        Me.lbfUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfUsername.Location = New System.Drawing.Point(62, 169)
        Me.lbfUsername.Name = "lbfUsername"
        Me.lbfUsername.Size = New System.Drawing.Size(0, 55)
        Me.lbfUsername.TabIndex = 2
        '
        'lbfFullName
        '
        Me.lbfFullName.AutoSize = True
        Me.lbfFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfFullName.Location = New System.Drawing.Point(62, 104)
        Me.lbfFullName.Name = "lbfFullName"
        Me.lbfFullName.Size = New System.Drawing.Size(0, 55)
        Me.lbfFullName.TabIndex = 4
        '
        'lbfPassword
        '
        Me.lbfPassword.AutoSize = True
        Me.lbfPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfPassword.Location = New System.Drawing.Point(62, 241)
        Me.lbfPassword.Name = "lbfPassword"
        Me.lbfPassword.Size = New System.Drawing.Size(0, 55)
        Me.lbfPassword.TabIndex = 6
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.SIS_M.My.Resources.Resources.wallhaven_5d9mx1_683x628
        Me.ClientSize = New System.Drawing.Size(667, 589)
        Me.Controls.Add(Me.lbfPassword)
        Me.Controls.Add(Me.lbfFullName)
        Me.Controls.Add(Me.lbfUsername)
        Me.Controls.Add(Me.btnLogout)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents lbfUsername As Label
    Friend WithEvents lbfFullName As Label
    Friend WithEvents lbfPassword As Label
End Class
