<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassSchedule
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.ClassSchedJuniorHigh1 = New DAFENHS_Automated_Enrollment_System.ClassSchedJuniorHigh()
        Me.pnlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.Controls.Add(Me.ClassSchedJuniorHigh1)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(1052, 700)
        Me.pnlContainer.TabIndex = 660
        '
        'ClassSchedJuniorHigh1
        '
        Me.ClassSchedJuniorHigh1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClassSchedJuniorHigh1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClassSchedJuniorHigh1.Location = New System.Drawing.Point(0, 0)
        Me.ClassSchedJuniorHigh1.Name = "ClassSchedJuniorHigh1"
        Me.ClassSchedJuniorHigh1.Size = New System.Drawing.Size(1052, 700)
        Me.ClassSchedJuniorHigh1.TabIndex = 0
        '
        'ClassSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlContainer)
        Me.Name = "ClassSchedule"
        Me.Size = New System.Drawing.Size(1052, 700)
        Me.pnlContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContainer As System.Windows.Forms.Panel
    Friend WithEvents ClassSchedJuniorHigh1 As DAFENHS_Automated_Enrollment_System.ClassSchedJuniorHigh

End Class
