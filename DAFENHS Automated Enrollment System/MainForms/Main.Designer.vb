<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.formRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAbout = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnSettings = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timerNow = New System.Windows.Forms.Timer(Me.components)
        Me.lblAddress = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblDivision = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblSystemName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnRegister = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblMeaning = New System.Windows.Forms.Label()
        Me.lblPledge = New System.Windows.Forms.Label()
        Me.lblCopyRight = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator4 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator6 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator7 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator8 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator9 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.dragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'formRadius
        '
        Me.formRadius.ElipseRadius = 10
        Me.formRadius.TargetControl = Me
        '
        'pnlTop
        '
        Me.pnlTop.BackgroundImage = CType(resources.GetObject("pnlTop.BackgroundImage"), System.Drawing.Image)
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTop.Controls.Add(Me.btnMinimize)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.btnAbout)
        Me.pnlTop.Controls.Add(Me.lblTime)
        Me.pnlTop.Controls.Add(Me.btnSettings)
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.GradientBottomLeft = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.GradientBottomRight = System.Drawing.Color.Black
        Me.pnlTop.GradientTopLeft = System.Drawing.Color.CadetBlue
        Me.pnlTop.GradientTopRight = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Quality = 10
        Me.pnlTop.Size = New System.Drawing.Size(899, 33)
        Me.pnlTop.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageActive = CType(resources.GetObject("btnMinimize.ImageActive"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(834, 1)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(32, 32)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnMinimize.TabIndex = 50
        Me.btnMinimize.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnMinimize, "Minimize")
        Me.btnMinimize.Zoom = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(524, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Clock :"
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.ImageActive = CType(resources.GetObject("btnAbout.ImageActive"), System.Drawing.Image)
        Me.btnAbout.Location = New System.Drawing.Point(766, 1)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(32, 32)
        Me.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnAbout.TabIndex = 49
        Me.btnAbout.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnAbout, "About")
        Me.btnAbout.Zoom = 1
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lblTime.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Turquoise
        Me.lblTime.Location = New System.Drawing.Point(574, -1)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(190, 34)
        Me.lblTime.TabIndex = 49
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageActive = CType(resources.GetObject("btnSettings.ImageActive"), System.Drawing.Image)
        Me.btnSettings.Location = New System.Drawing.Point(800, 1)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(32, 32)
        Me.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSettings.TabIndex = 48
        Me.btnSettings.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnSettings, "Settings")
        Me.btnSettings.Zoom = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = CType(resources.GetObject("btnClose.ImageActive"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(867, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 32)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnClose.TabIndex = 47
        Me.btnClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnClose, "Shutdown?")
        Me.btnClose.Zoom = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Automated Enrollment System"
        '
        'timerNow
        '
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAddress.Location = New System.Drawing.Point(326, 101)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(233, 19)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "Bogo, Tomas Oppus, Southern Leyte"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft New Tai Lue", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(175, 73)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(556, 29)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "DON AGUSTIN F. ESCAÑO NATIONAL HIGH SCHOOL"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.Location = New System.Drawing.Point(370, 55)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(146, 17)
        Me.lblDivision.TabIndex = 4
        Me.lblDivision.Text = "Division of Southern Leyte"
        Me.lblDivision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(436, 228)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(11, 74)
        Me.BunifuSeparator2.TabIndex = 38
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = True
        '
        'lblSystemName
        '
        Me.lblSystemName.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSystemName.Font = New System.Drawing.Font("Candara", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSystemName.Location = New System.Drawing.Point(276, 181)
        Me.lblSystemName.Name = "lblSystemName"
        Me.lblSystemName.Size = New System.Drawing.Size(340, 47)
        Me.lblSystemName.TabIndex = 37
        Me.lblSystemName.Text = "AUTOMATED ENROLLMENT SYSTEM"
        Me.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegister
        '
        Me.btnRegister.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.btnRegister.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegister.BorderRadius = 7
        Me.btnRegister.ButtonText = "R E G I S T E R  A C C O U N T"
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.DisabledColor = System.Drawing.Color.Gray
        Me.btnRegister.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRegister.Iconimage = CType(resources.GetObject("btnRegister.Iconimage"), System.Drawing.Image)
        Me.btnRegister.Iconimage_right = Nothing
        Me.btnRegister.Iconimage_right_Selected = Nothing
        Me.btnRegister.Iconimage_Selected = Nothing
        Me.btnRegister.IconMarginLeft = 0
        Me.btnRegister.IconMarginRight = 0
        Me.btnRegister.IconRightVisible = True
        Me.btnRegister.IconRightZoom = 0.0R
        Me.btnRegister.IconVisible = True
        Me.btnRegister.IconZoom = 90.0R
        Me.btnRegister.IsTab = False
        Me.btnRegister.Location = New System.Drawing.Point(457, 246)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.btnRegister.OnHovercolor = System.Drawing.Color.Teal
        Me.btnRegister.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRegister.selected = False
        Me.btnRegister.Size = New System.Drawing.Size(178, 77)
        Me.btnRegister.TabIndex = 36
        Me.btnRegister.Text = "R E G I S T E R  A C C O U N T"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegister.Textcolor = System.Drawing.Color.White
        Me.btnRegister.TextFont = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnLogin
        '
        Me.btnLogin.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.btnLogin.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.BorderRadius = 7
        Me.btnLogin.ButtonText = " L O G I N"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnLogin.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogin.Iconimage = CType(resources.GetObject("btnLogin.Iconimage"), System.Drawing.Image)
        Me.btnLogin.Iconimage_right = Nothing
        Me.btnLogin.Iconimage_right_Selected = Nothing
        Me.btnLogin.Iconimage_Selected = Nothing
        Me.btnLogin.IconMarginLeft = 0
        Me.btnLogin.IconMarginRight = 0
        Me.btnLogin.IconRightVisible = True
        Me.btnLogin.IconRightZoom = 0.0R
        Me.btnLogin.IconVisible = True
        Me.btnLogin.IconZoom = 90.0R
        Me.btnLogin.IsTab = False
        Me.btnLogin.Location = New System.Drawing.Point(249, 245)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.btnLogin.OnHovercolor = System.Drawing.Color.Teal
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(179, 77)
        Me.btnLogin.TabIndex = 35
        Me.btnLogin.Text = " L O G I N"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogin.Textcolor = System.Drawing.Color.White
        Me.btnLogin.TextFont = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(152, 465)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(587, 15)
        Me.BunifuSeparator1.TabIndex = 41
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'lblMeaning
        '
        Me.lblMeaning.AutoSize = True
        Me.lblMeaning.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeaning.ForeColor = System.Drawing.Color.DimGray
        Me.lblMeaning.Location = New System.Drawing.Point(135, 425)
        Me.lblMeaning.Name = "lblMeaning"
        Me.lblMeaning.Size = New System.Drawing.Size(625, 17)
        Me.lblMeaning.TabIndex = 40
        Me.lblMeaning.Text = "I HEREBY PLEDGE TO BE LOYAL TO THE SCHOOL AND TO OBEY ITS EXISTING RULES AND REGU" & _
    "LATIONS."
        '
        'lblPledge
        '
        Me.lblPledge.AutoSize = True
        Me.lblPledge.Font = New System.Drawing.Font("Candara", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPledge.ForeColor = System.Drawing.Color.DimGray
        Me.lblPledge.Location = New System.Drawing.Point(357, 397)
        Me.lblPledge.Name = "lblPledge"
        Me.lblPledge.Size = New System.Drawing.Size(172, 22)
        Me.lblPledge.TabIndex = 39
        Me.lblPledge.Text = "PLEDGE OF LOYALTY"
        '
        'lblCopyRight
        '
        Me.lblCopyRight.AutoSize = True
        Me.lblCopyRight.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyRight.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyRight.ForeColor = System.Drawing.Color.DarkGray
        Me.lblCopyRight.Location = New System.Drawing.Point(264, 488)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(343, 28)
        Me.lblCopyRight.TabIndex = 42
        Me.lblCopyRight.Text = "Copyrights of DON AGUSTIN F. ESCAÑO NATIONAL HIGHSCHOOL. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All Rights Reserved 20" & _
    "17"
        Me.lblCopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(221, 202)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(11, 95)
        Me.BunifuSeparator3.TabIndex = 43
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = True
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(659, 202)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(11, 95)
        Me.BunifuSeparator4.TabIndex = 44
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = True
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 1
        Me.BunifuSeparator5.Location = New System.Drawing.Point(227, 197)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(49, 10)
        Me.BunifuSeparator5.TabIndex = 45
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'BunifuSeparator6
        '
        Me.BunifuSeparator6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator6.LineThickness = 1
        Me.BunifuSeparator6.Location = New System.Drawing.Point(616, 196)
        Me.BunifuSeparator6.Name = "BunifuSeparator6"
        Me.BunifuSeparator6.Size = New System.Drawing.Size(49, 10)
        Me.BunifuSeparator6.TabIndex = 46
        Me.BunifuSeparator6.Transparency = 255
        Me.BunifuSeparator6.Vertical = False
        '
        'BunifuSeparator7
        '
        Me.BunifuSeparator7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator7.LineThickness = 1
        Me.BunifuSeparator7.Location = New System.Drawing.Point(626, 292)
        Me.BunifuSeparator7.Name = "BunifuSeparator7"
        Me.BunifuSeparator7.Size = New System.Drawing.Size(39, 10)
        Me.BunifuSeparator7.TabIndex = 47
        Me.BunifuSeparator7.Transparency = 255
        Me.BunifuSeparator7.Vertical = False
        '
        'BunifuSeparator8
        '
        Me.BunifuSeparator8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator8.LineThickness = 1
        Me.BunifuSeparator8.Location = New System.Drawing.Point(226, 292)
        Me.BunifuSeparator8.Name = "BunifuSeparator8"
        Me.BunifuSeparator8.Size = New System.Drawing.Size(39, 10)
        Me.BunifuSeparator8.TabIndex = 48
        Me.BunifuSeparator8.Transparency = 255
        Me.BunifuSeparator8.Vertical = False
        '
        'BunifuSeparator9
        '
        Me.BunifuSeparator9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator9.LineColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuSeparator9.LineThickness = 1
        Me.BunifuSeparator9.Location = New System.Drawing.Point(427, 297)
        Me.BunifuSeparator9.Name = "BunifuSeparator9"
        Me.BunifuSeparator9.Size = New System.Drawing.Size(39, 10)
        Me.BunifuSeparator9.TabIndex = 49
        Me.BunifuSeparator9.Transparency = 255
        Me.BunifuSeparator9.Vertical = False
        '
        'dragControl
        '
        Me.dragControl.Fixed = True
        Me.dragControl.Horizontal = True
        Me.dragControl.TargetControl = Me.pnlTop
        Me.dragControl.Vertical = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(99, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(899, 529)
        Me.Controls.Add(Me.BunifuSeparator4)
        Me.Controls.Add(Me.BunifuSeparator6)
        Me.Controls.Add(Me.BunifuSeparator5)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.lblCopyRight)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.lblMeaning)
        Me.Controls.Add(Me.lblPledge)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.lblSystemName)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDivision)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.BunifuSeparator7)
        Me.Controls.Add(Me.BunifuSeparator8)
        Me.Controls.Add(Me.BunifuSeparator9)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DAFENHS Automated Enrollment System"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents formRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlTop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAbout As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnSettings As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timerNow As System.Windows.Forms.Timer
    Friend WithEvents lblAddress As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblTitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblDivision As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblSystemName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnRegister As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblCopyRight As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblMeaning As System.Windows.Forms.Label
    Friend WithEvents lblPledge As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BunifuSeparator4 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator6 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator7 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator8 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator9 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents dragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
