<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enrollment
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
        Me.components = New System.ComponentModel.Container()
        Me.FormRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EnrollmentSeniorHigh1 = New DAFENHS_Automated_Enrollment_System.EnrollmentSeniorHigh()
        Me.EnrollmentJuniorHigh1 = New DAFENHS_Automated_Enrollment_System.EnrollmentJuniorHigh()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.line1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnJunior = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.line2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.btnSenior = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormRadius
        '
        Me.FormRadius.ElipseRadius = 10
        Me.FormRadius.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.EnrollmentSeniorHigh1)
        Me.Panel1.Controls.Add(Me.EnrollmentJuniorHigh1)
        Me.Panel1.Location = New System.Drawing.Point(0, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 596)
        Me.Panel1.TabIndex = 0
        '
        'EnrollmentSeniorHigh1
        '
        Me.EnrollmentSeniorHigh1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnrollmentSeniorHigh1.Location = New System.Drawing.Point(0, 0)
        Me.EnrollmentSeniorHigh1.Name = "EnrollmentSeniorHigh1"
        Me.EnrollmentSeniorHigh1.Size = New System.Drawing.Size(1052, 596)
        Me.EnrollmentSeniorHigh1.TabIndex = 656
        Me.EnrollmentSeniorHigh1.Visible = False
        '
        'EnrollmentJuniorHigh1
        '
        Me.EnrollmentJuniorHigh1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnrollmentJuniorHigh1.Location = New System.Drawing.Point(0, 0)
        Me.EnrollmentJuniorHigh1.Name = "EnrollmentJuniorHigh1"
        Me.EnrollmentJuniorHigh1.Size = New System.Drawing.Size(1052, 596)
        Me.EnrollmentJuniorHigh1.TabIndex = 0
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Candara", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(140, 56)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(213, 23)
        Me.BunifuCustomLabel2.TabIndex = 651
        Me.BunifuCustomLabel2.Text = "E N R O L L M E N T   F O R"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'line1
        '
        Me.line1.BackColor = System.Drawing.Color.Transparent
        Me.line1.ForeColor = System.Drawing.Color.Gray
        Me.line1.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.line1.LineThickness = 2
        Me.line1.Location = New System.Drawing.Point(563, 74)
        Me.line1.Name = "line1"
        Me.line1.Size = New System.Drawing.Size(202, 10)
        Me.line1.TabIndex = 653
        Me.line1.Transparency = 255
        Me.line1.Vertical = False
        '
        'btnJunior
        '
        Me.btnJunior.Activecolor = System.Drawing.Color.Transparent
        Me.btnJunior.BackColor = System.Drawing.Color.Transparent
        Me.btnJunior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJunior.BorderRadius = 0
        Me.btnJunior.ButtonText = "J U N I O R   H I G H S C H O O L"
        Me.btnJunior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJunior.DisabledColor = System.Drawing.Color.Gray
        Me.btnJunior.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJunior.Iconcolor = System.Drawing.Color.Transparent
        Me.btnJunior.Iconimage = Nothing
        Me.btnJunior.Iconimage_right = Nothing
        Me.btnJunior.Iconimage_right_Selected = Nothing
        Me.btnJunior.Iconimage_Selected = Nothing
        Me.btnJunior.IconMarginLeft = 0
        Me.btnJunior.IconMarginRight = 0
        Me.btnJunior.IconRightVisible = True
        Me.btnJunior.IconRightZoom = 0.0R
        Me.btnJunior.IconVisible = True
        Me.btnJunior.IconZoom = 90.0R
        Me.btnJunior.IsTab = True
        Me.btnJunior.Location = New System.Drawing.Point(563, 53)
        Me.btnJunior.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnJunior.Name = "btnJunior"
        Me.btnJunior.Normalcolor = System.Drawing.Color.Transparent
        Me.btnJunior.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnJunior.OnHoverTextColor = System.Drawing.Color.DarkKhaki
        Me.btnJunior.selected = False
        Me.btnJunior.Size = New System.Drawing.Size(202, 23)
        Me.btnJunior.TabIndex = 652
        Me.btnJunior.Text = "J U N I O R   H I G H S C H O O L"
        Me.btnJunior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnJunior.Textcolor = System.Drawing.Color.Maroon
        Me.btnJunior.TextFont = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'line2
        '
        Me.line2.BackColor = System.Drawing.Color.Transparent
        Me.line2.ForeColor = System.Drawing.Color.Gray
        Me.line2.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.line2.LineThickness = 2
        Me.line2.Location = New System.Drawing.Point(788, 74)
        Me.line2.Name = "line2"
        Me.line2.Size = New System.Drawing.Size(202, 10)
        Me.line2.TabIndex = 655
        Me.line2.Transparency = 255
        Me.line2.Vertical = False
        Me.line2.Visible = False
        '
        'btnSenior
        '
        Me.btnSenior.Activecolor = System.Drawing.Color.Transparent
        Me.btnSenior.BackColor = System.Drawing.Color.Transparent
        Me.btnSenior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSenior.BorderRadius = 0
        Me.btnSenior.ButtonText = "S E N I O R   H I G H S C H O O L "
        Me.btnSenior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSenior.DisabledColor = System.Drawing.Color.Gray
        Me.btnSenior.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSenior.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSenior.Iconimage = Nothing
        Me.btnSenior.Iconimage_right = Nothing
        Me.btnSenior.Iconimage_right_Selected = Nothing
        Me.btnSenior.Iconimage_Selected = Nothing
        Me.btnSenior.IconMarginLeft = 0
        Me.btnSenior.IconMarginRight = 0
        Me.btnSenior.IconRightVisible = True
        Me.btnSenior.IconRightZoom = 0.0R
        Me.btnSenior.IconVisible = True
        Me.btnSenior.IconZoom = 90.0R
        Me.btnSenior.IsTab = True
        Me.btnSenior.Location = New System.Drawing.Point(788, 53)
        Me.btnSenior.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSenior.Name = "btnSenior"
        Me.btnSenior.Normalcolor = System.Drawing.Color.Transparent
        Me.btnSenior.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnSenior.OnHoverTextColor = System.Drawing.Color.DarkKhaki
        Me.btnSenior.selected = False
        Me.btnSenior.Size = New System.Drawing.Size(202, 23)
        Me.btnSenior.TabIndex = 654
        Me.btnSenior.Text = "S E N I O R   H I G H S C H O O L "
        Me.btnSenior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSenior.Textcolor = System.Drawing.Color.Maroon
        Me.btnSenior.TextFont = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 2
        Me.BunifuSeparator2.Location = New System.Drawing.Point(38, 90)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(993, 10)
        Me.BunifuSeparator2.TabIndex = 686
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Enrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.line2)
        Me.Controls.Add(Me.btnSenior)
        Me.Controls.Add(Me.line1)
        Me.Controls.Add(Me.btnJunior)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Enrollment"
        Me.Size = New System.Drawing.Size(1052, 700)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents line2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents btnSenior As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents line1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents btnJunior As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents EnrollmentJuniorHigh1 As DAFENHS_Automated_Enrollment_System.EnrollmentJuniorHigh
    Friend WithEvents EnrollmentSeniorHigh1 As DAFENHS_Automated_Enrollment_System.EnrollmentSeniorHigh
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator

End Class
