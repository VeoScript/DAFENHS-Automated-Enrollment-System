<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblLoginType = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnTeacher = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSubject = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblGuest = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlMyContainer = New System.Windows.Forms.Panel()
        Me.RegisterSection1 = New DAFENHS_Automated_Enrollment_System.RegisterSection()
        Me.RegisterSubject1 = New DAFENHS_Automated_Enrollment_System.RegisterSubject()
        Me.RegisterTeacher1 = New DAFENHS_Automated_Enrollment_System.RegisterTeacher()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSection = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.btnTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMyContainer.SuspendLayout()
        CType(Me.btnSection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 2
        Me.BunifuSeparator2.Location = New System.Drawing.Point(24, 138)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(725, 10)
        Me.BunifuSeparator2.TabIndex = 157
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel3.Image = CType(resources.GetObject("BunifuCustomLabel3.Image"), System.Drawing.Image)
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(26, 79)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(76, 59)
        Me.BunifuCustomLabel3.TabIndex = 156
        Me.BunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoginType
        '
        Me.lblLoginType.AutoSize = True
        Me.lblLoginType.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginType.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginType.ForeColor = System.Drawing.Color.DimGray
        Me.lblLoginType.Location = New System.Drawing.Point(108, 107)
        Me.lblLoginType.Name = "lblLoginType"
        Me.lblLoginType.Size = New System.Drawing.Size(242, 25)
        Me.lblLoginType.TabIndex = 155
        Me.lblLoginType.Text = "R E G I S T R A T I O N   O F"
        Me.lblLoginType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTeacher
        '
        Me.btnTeacher.BackColor = System.Drawing.Color.Transparent
        Me.btnTeacher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTeacher.Image = CType(resources.GetObject("btnTeacher.Image"), System.Drawing.Image)
        Me.btnTeacher.ImageActive = CType(resources.GetObject("btnTeacher.ImageActive"), System.Drawing.Image)
        Me.btnTeacher.Location = New System.Drawing.Point(371, 93)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(51, 45)
        Me.btnTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnTeacher.TabIndex = 158
        Me.btnTeacher.TabStop = False
        Me.btnTeacher.Zoom = 1
        '
        'btnSubject
        '
        Me.btnSubject.BackColor = System.Drawing.Color.Transparent
        Me.btnSubject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubject.Image = CType(resources.GetObject("btnSubject.Image"), System.Drawing.Image)
        Me.btnSubject.ImageActive = CType(resources.GetObject("btnSubject.ImageActive"), System.Drawing.Image)
        Me.btnSubject.Location = New System.Drawing.Point(506, 93)
        Me.btnSubject.Name = "btnSubject"
        Me.btnSubject.Size = New System.Drawing.Size(51, 45)
        Me.btnSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSubject.TabIndex = 160
        Me.btnSubject.TabStop = False
        Me.btnSubject.Zoom = 1
        '
        'lblGuest
        '
        Me.lblGuest.AutoSize = True
        Me.lblGuest.BackColor = System.Drawing.Color.Transparent
        Me.lblGuest.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuest.ForeColor = System.Drawing.Color.DimGray
        Me.lblGuest.Location = New System.Drawing.Point(425, 118)
        Me.lblGuest.Name = "lblGuest"
        Me.lblGuest.Size = New System.Drawing.Size(63, 17)
        Me.lblGuest.TabIndex = 161
        Me.lblGuest.Text = "Teacher's"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(559, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "Subject"
        '
        'pnlMyContainer
        '
        Me.pnlMyContainer.Controls.Add(Me.RegisterSection1)
        Me.pnlMyContainer.Controls.Add(Me.RegisterSubject1)
        Me.pnlMyContainer.Controls.Add(Me.RegisterTeacher1)
        Me.pnlMyContainer.Location = New System.Drawing.Point(0, 149)
        Me.pnlMyContainer.Name = "pnlMyContainer"
        Me.pnlMyContainer.Size = New System.Drawing.Size(1052, 551)
        Me.pnlMyContainer.TabIndex = 164
        '
        'RegisterSection1
        '
        Me.RegisterSection1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.RegisterSection1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegisterSection1.Location = New System.Drawing.Point(0, 0)
        Me.RegisterSection1.Name = "RegisterSection1"
        Me.RegisterSection1.Size = New System.Drawing.Size(1052, 551)
        Me.RegisterSection1.TabIndex = 3
        Me.RegisterSection1.Visible = False
        '
        'RegisterSubject1
        '
        Me.RegisterSubject1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.RegisterSubject1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegisterSubject1.Location = New System.Drawing.Point(0, 0)
        Me.RegisterSubject1.Name = "RegisterSubject1"
        Me.RegisterSubject1.Size = New System.Drawing.Size(1052, 551)
        Me.RegisterSubject1.TabIndex = 2
        Me.RegisterSubject1.Visible = False
        '
        'RegisterTeacher1
        '
        Me.RegisterTeacher1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.RegisterTeacher1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegisterTeacher1.Location = New System.Drawing.Point(0, 0)
        Me.RegisterTeacher1.Name = "RegisterTeacher1"
        Me.RegisterTeacher1.Size = New System.Drawing.Size(1052, 551)
        Me.RegisterTeacher1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(679, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Section"
        '
        'btnSection
        '
        Me.btnSection.BackColor = System.Drawing.Color.Transparent
        Me.btnSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSection.Image = CType(resources.GetObject("btnSection.Image"), System.Drawing.Image)
        Me.btnSection.ImageActive = CType(resources.GetObject("btnSection.ImageActive"), System.Drawing.Image)
        Me.btnSection.Location = New System.Drawing.Point(626, 93)
        Me.btnSection.Name = "btnSection"
        Me.btnSection.Size = New System.Drawing.Size(51, 45)
        Me.btnSection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSection.TabIndex = 165
        Me.btnSection.TabStop = False
        Me.btnSection.Zoom = 1
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSection)
        Me.Controls.Add(Me.pnlMyContainer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblGuest)
        Me.Controls.Add(Me.btnSubject)
        Me.Controls.Add(Me.btnTeacher)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.lblLoginType)
        Me.Name = "Registration"
        Me.Size = New System.Drawing.Size(1052, 700)
        CType(Me.btnTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSubject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMyContainer.ResumeLayout(False)
        CType(Me.btnSection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblLoginType As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnTeacher As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSubject As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblGuest As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlMyContainer As System.Windows.Forms.Panel
    Friend WithEvents RegisterTeacher1 As DAFENHS_Automated_Enrollment_System.RegisterTeacher 
    Friend WithEvents RegisterSubject1 As DAFENHS_Automated_Enrollment_System.RegisterSubject
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSection As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents RegisterSection1 As DAFENHS_Automated_Enrollment_System.RegisterSection

End Class
