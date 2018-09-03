<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.formRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnEnrollmentSection = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnClassList = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnHome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSeniorHighschool = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRegistration = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnJuniorHighschool = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAbout = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSettings = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Enrollment = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.dragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.timerNow = New System.Windows.Forms.Timer(Me.components)
        Me.pnlGuestContainer = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.lblGreet = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblGuest = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlUserControlHolder = New System.Windows.Forms.Panel()
        Me.Search1 = New DAFENHS_Automated_Enrollment_System.Search()
        Me.ClassSchedule1 = New DAFENHS_Automated_Enrollment_System.ClassSchedule()
        Me.Enrollment1 = New DAFENHS_Automated_Enrollment_System.Enrollment()
        Me.lblMessageUser = New System.Windows.Forms.Label()
        Me.Registration1 = New DAFENHS_Automated_Enrollment_System.Registration()
        Me.SeniorHighRegistration1 = New DAFENHS_Automated_Enrollment_System.SeniorHighRegistration()
        Me.JuniorHighRegistration1 = New DAFENHS_Automated_Enrollment_System.JuniorHighRegistration()
        Me.HomeDesign1 = New DAFENHS_Automated_Enrollment_System.HomeDesign()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGuestContainer.SuspendLayout()
        Me.pnlUserControlHolder.SuspendLayout()
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
        Me.pnlTop.Controls.Add(Me.btnEnrollmentSection)
        Me.pnlTop.Controls.Add(Me.btnSearch)
        Me.pnlTop.Controls.Add(Me.btnClassList)
        Me.pnlTop.Controls.Add(Me.btnHome)
        Me.pnlTop.Controls.Add(Me.btnSeniorHighschool)
        Me.pnlTop.Controls.Add(Me.btnRegistration)
        Me.pnlTop.Controls.Add(Me.btnJuniorHighschool)
        Me.pnlTop.Controls.Add(Me.btnMinimize)
        Me.pnlTop.Controls.Add(Me.btnAbout)
        Me.pnlTop.Controls.Add(Me.btnSettings)
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.GradientBottomLeft = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.GradientBottomRight = System.Drawing.Color.Black
        Me.pnlTop.GradientTopLeft = System.Drawing.Color.CadetBlue
        Me.pnlTop.GradientTopRight = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.Location = New System.Drawing.Point(-1, -1)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Quality = 10
        Me.pnlTop.Size = New System.Drawing.Size(1317, 33)
        Me.pnlTop.TabIndex = 1
        '
        'btnEnrollmentSection
        '
        Me.btnEnrollmentSection.Activecolor = System.Drawing.SystemColors.Control
        Me.btnEnrollmentSection.BackColor = System.Drawing.Color.Transparent
        Me.btnEnrollmentSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnrollmentSection.BorderRadius = 0
        Me.btnEnrollmentSection.ButtonText = "ENROLLMENT SECTION"
        Me.btnEnrollmentSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnrollmentSection.DisabledColor = System.Drawing.Color.Gray
        Me.btnEnrollmentSection.ForeColor = System.Drawing.Color.Gray
        Me.btnEnrollmentSection.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEnrollmentSection.Iconimage = Nothing
        Me.btnEnrollmentSection.Iconimage_right = Nothing
        Me.btnEnrollmentSection.Iconimage_right_Selected = Nothing
        Me.btnEnrollmentSection.Iconimage_Selected = Nothing
        Me.btnEnrollmentSection.IconMarginLeft = 0
        Me.btnEnrollmentSection.IconMarginRight = 0
        Me.btnEnrollmentSection.IconRightVisible = True
        Me.btnEnrollmentSection.IconRightZoom = 0.0R
        Me.btnEnrollmentSection.IconVisible = True
        Me.btnEnrollmentSection.IconZoom = 90.0R
        Me.btnEnrollmentSection.IsTab = True
        Me.btnEnrollmentSection.Location = New System.Drawing.Point(739, 0)
        Me.btnEnrollmentSection.Name = "btnEnrollmentSection"
        Me.btnEnrollmentSection.Normalcolor = System.Drawing.Color.Transparent
        Me.btnEnrollmentSection.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.btnEnrollmentSection.OnHoverTextColor = System.Drawing.Color.DarkSlateGray
        Me.btnEnrollmentSection.selected = False
        Me.btnEnrollmentSection.Size = New System.Drawing.Size(153, 34)
        Me.btnEnrollmentSection.TabIndex = 57
        Me.btnEnrollmentSection.Text = "ENROLLMENT SECTION"
        Me.btnEnrollmentSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEnrollmentSection.Textcolor = System.Drawing.Color.DarkKhaki
        Me.btnEnrollmentSection.TextFont = New System.Drawing.Font("Candara", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSearch
        '
        Me.btnSearch.Activecolor = System.Drawing.SystemColors.Control
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.BorderRadius = 0
        Me.btnSearch.ButtonText = "SEARCH"
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.DisabledColor = System.Drawing.Color.Gray
        Me.btnSearch.ForeColor = System.Drawing.Color.Gray
        Me.btnSearch.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSearch.Iconimage = Nothing
        Me.btnSearch.Iconimage_right = Nothing
        Me.btnSearch.Iconimage_right_Selected = Nothing
        Me.btnSearch.Iconimage_Selected = Nothing
        Me.btnSearch.IconMarginLeft = 0
        Me.btnSearch.IconMarginRight = 0
        Me.btnSearch.IconRightVisible = True
        Me.btnSearch.IconRightZoom = 0.0R
        Me.btnSearch.IconVisible = True
        Me.btnSearch.IconZoom = 90.0R
        Me.btnSearch.IsTab = True
        Me.btnSearch.Location = New System.Drawing.Point(1091, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Normalcolor = System.Drawing.Color.Transparent
        Me.btnSearch.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.btnSearch.OnHoverTextColor = System.Drawing.Color.DarkSlateGray
        Me.btnSearch.selected = False
        Me.btnSearch.Size = New System.Drawing.Size(88, 34)
        Me.btnSearch.TabIndex = 56
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSearch.Textcolor = System.Drawing.Color.DarkKhaki
        Me.btnSearch.TextFont = New System.Drawing.Font("Candara", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnClassList
        '
        Me.btnClassList.Activecolor = System.Drawing.SystemColors.Control
        Me.btnClassList.BackColor = System.Drawing.Color.Transparent
        Me.btnClassList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClassList.BorderRadius = 0
        Me.btnClassList.ButtonText = "CLASS SCHEDULE"
        Me.btnClassList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClassList.DisabledColor = System.Drawing.Color.Gray
        Me.btnClassList.ForeColor = System.Drawing.Color.Gray
        Me.btnClassList.Iconcolor = System.Drawing.Color.Transparent
        Me.btnClassList.Iconimage = Nothing
        Me.btnClassList.Iconimage_right = Nothing
        Me.btnClassList.Iconimage_right_Selected = Nothing
        Me.btnClassList.Iconimage_Selected = Nothing
        Me.btnClassList.IconMarginLeft = 0
        Me.btnClassList.IconMarginRight = 0
        Me.btnClassList.IconRightVisible = True
        Me.btnClassList.IconRightZoom = 0.0R
        Me.btnClassList.IconVisible = True
        Me.btnClassList.IconZoom = 90.0R
        Me.btnClassList.IsTab = True
        Me.btnClassList.Location = New System.Drawing.Point(990, 0)
        Me.btnClassList.Name = "btnClassList"
        Me.btnClassList.Normalcolor = System.Drawing.Color.Transparent
        Me.btnClassList.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.btnClassList.OnHoverTextColor = System.Drawing.Color.DarkSlateGray
        Me.btnClassList.selected = False
        Me.btnClassList.Size = New System.Drawing.Size(96, 34)
        Me.btnClassList.TabIndex = 55
        Me.btnClassList.Text = "CLASS SCHEDULE"
        Me.btnClassList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnClassList.Textcolor = System.Drawing.Color.DarkKhaki
        Me.btnClassList.TextFont = New System.Drawing.Font("Candara", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnHome
        '
        Me.btnHome.Activecolor = System.Drawing.SystemColors.Control
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.BorderRadius = 0
        Me.btnHome.ButtonText = "HOME"
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.DisabledColor = System.Drawing.Color.Gray
        Me.btnHome.ForeColor = System.Drawing.Color.Gray
        Me.btnHome.Iconcolor = System.Drawing.Color.Transparent
        Me.btnHome.Iconimage = Nothing
        Me.btnHome.Iconimage_right = Nothing
        Me.btnHome.Iconimage_right_Selected = Nothing
        Me.btnHome.Iconimage_Selected = Nothing
        Me.btnHome.IconMarginLeft = 0
        Me.btnHome.IconMarginRight = 0
        Me.btnHome.IconRightVisible = True
        Me.btnHome.IconRightZoom = 0.0R
        Me.btnHome.IconVisible = True
        Me.btnHome.IconZoom = 90.0R
        Me.btnHome.IsTab = True
        Me.btnHome.Location = New System.Drawing.Point(352, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Normalcolor = System.Drawing.Color.Transparent
        Me.btnHome.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.btnHome.OnHoverTextColor = System.Drawing.Color.DarkSlateGray
        Me.btnHome.selected = False
        Me.btnHome.Size = New System.Drawing.Size(66, 34)
        Me.btnHome.TabIndex = 54
        Me.btnHome.TabStop = False
        Me.btnHome.Text = "HOME"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnHome.Textcolor = System.Drawing.Color.DarkKhaki
        Me.btnHome.TextFont = New System.Drawing.Font("Candara", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSeniorHighschool
        '
        Me.btnSeniorHighschool.Activecolor = System.Drawing.SystemColors.Control
        Me.btnSeniorHighschool.BackColor = System.Drawing.Color.Transparent
        Me.btnSeniorHighschool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeniorHighschool.BorderRadius = 0
        Me.btnSeniorHighschool.ButtonText = "SENIOR HIGH REGISTRATION"
        Me.btnSeniorHighschool.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeniorHighschool.DisabledColor = System.Drawing.Color.Gray
        Me.btnSeniorHighschool.ForeColor = System.Drawing.Color.Gray
        Me.btnSeniorHighschool.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSeniorHighschool.Iconimage = Nothing
        Me.btnSeniorHighschool.Iconimage_right = Nothing
        Me.btnSeniorHighschool.Iconimage_right_Selected = Nothing
        Me.btnSeniorHighschool.Iconimage_Selected = Nothing
        Me.btnSeniorHighschool.IconMarginLeft = 0
        Me.btnSeniorHighschool.IconMarginRight = 0
        Me.btnSeniorHighschool.IconRightVisible = True
        Me.btnSeniorHighschool.IconRightZoom = 0.0R
        Me.btnSeniorHighschool.IconVisible = True
        Me.btnSeniorHighschool.IconZoom = 90.0R
        Me.btnSeniorHighschool.IsTab = True
        Me.btnSeniorHighschool.Location = New System.Drawing.Point(582, 0)
        Me.btnSeniorHighschool.Name = "btnSeniorHighschool"
        Me.btnSeniorHighschool.Normalcolor = System.Drawing.Color.Transparent
        Me.btnSeniorHighschool.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.btnSeniorHighschool.OnHoverTextColor = System.Drawing.Color.DarkSlateGray
        Me.btnSeniorHighschool.selected = False
        Me.btnSeniorHighschool.Size = New System.Drawing.Size(153, 34)
        Me.btnSeniorHighschool.TabIndex = 53
        Me.btnSeniorHighschool.Text = "SENIOR HIGH REGISTRATION"
        Me.btnSeniorHighschool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSeniorHighschool.Textcolor = System.Drawing.Color.DarkKhaki
        Me.btnSeniorHighschool.TextFont = New System.Drawing.Font("Candara", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRegistration
        '
        Me.btnRegistration.Activecolor = System.Drawing.SystemColors.Control
        Me.btnRegistration.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistration.BorderRadius = 0
        Me.btnRegistration.ButtonText = "REGISTRATION"
        Me.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistration.DisabledColor = System.Drawing.Color.DarkSlateGray
        Me.btnRegistration.ForeColor = System.Drawing.Color.Gray
        Me.btnRegistration.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRegistration.Iconimage = Nothing
        Me.btnRegistration.Iconimage_right = Nothing
        Me.btnRegistration.Iconimage_right_Selected = Nothing
        Me.btnRegistration.Iconimage_Selected = Nothing
        Me.btnRegistration.IconMarginLeft = 0
        Me.btnRegistration.IconMarginRight = 0
        Me.btnRegistration.IconRightVisible = True
        Me.btnRegistration.IconRightZoom = 0.0R
        Me.btnRegistration.IconVisible = True
        Me.btnRegistration.IconZoom = 90.0R
        Me.btnRegistration.IsTab = True
        Me.btnRegistration.Location = New System.Drawing.Point(897, 0)
        Me.btnRegistration.Name = "btnRegistration"
        Me.btnRegistration.Normalcolor = System.Drawing.Color.Transparent
        Me.btnRegistration.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.btnRegistration.OnHoverTextColor = System.Drawing.Color.DarkSlateGray
        Me.btnRegistration.selected = False
        Me.btnRegistration.Size = New System.Drawing.Size(88, 34)
        Me.btnRegistration.TabIndex = 52
        Me.btnRegistration.Text = "REGISTRATION"
        Me.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegistration.Textcolor = System.Drawing.Color.DarkKhaki
        Me.btnRegistration.TextFont = New System.Drawing.Font("Candara", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnJuniorHighschool
        '
        Me.btnJuniorHighschool.Activecolor = System.Drawing.SystemColors.Control
        Me.btnJuniorHighschool.BackColor = System.Drawing.Color.Transparent
        Me.btnJuniorHighschool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJuniorHighschool.BorderRadius = 0
        Me.btnJuniorHighschool.ButtonText = "JUNIOR HIGH REGISTRATION"
        Me.btnJuniorHighschool.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJuniorHighschool.DisabledColor = System.Drawing.Color.Gray
        Me.btnJuniorHighschool.ForeColor = System.Drawing.Color.Gray
        Me.btnJuniorHighschool.Iconcolor = System.Drawing.Color.Transparent
        Me.btnJuniorHighschool.Iconimage = Nothing
        Me.btnJuniorHighschool.Iconimage_right = Nothing
        Me.btnJuniorHighschool.Iconimage_right_Selected = Nothing
        Me.btnJuniorHighschool.Iconimage_Selected = Nothing
        Me.btnJuniorHighschool.IconMarginLeft = 0
        Me.btnJuniorHighschool.IconMarginRight = 0
        Me.btnJuniorHighschool.IconRightVisible = True
        Me.btnJuniorHighschool.IconRightZoom = 0.0R
        Me.btnJuniorHighschool.IconVisible = True
        Me.btnJuniorHighschool.IconZoom = 90.0R
        Me.btnJuniorHighschool.IsTab = True
        Me.btnJuniorHighschool.Location = New System.Drawing.Point(422, 0)
        Me.btnJuniorHighschool.Name = "btnJuniorHighschool"
        Me.btnJuniorHighschool.Normalcolor = System.Drawing.Color.Transparent
        Me.btnJuniorHighschool.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.btnJuniorHighschool.OnHoverTextColor = System.Drawing.Color.DarkSlateGray
        Me.btnJuniorHighschool.selected = False
        Me.btnJuniorHighschool.Size = New System.Drawing.Size(153, 34)
        Me.btnJuniorHighschool.TabIndex = 3
        Me.btnJuniorHighschool.TabStop = False
        Me.btnJuniorHighschool.Text = "JUNIOR HIGH REGISTRATION"
        Me.btnJuniorHighschool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnJuniorHighschool.Textcolor = System.Drawing.Color.DarkKhaki
        Me.btnJuniorHighschool.TextFont = New System.Drawing.Font("Candara", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageActive = CType(resources.GetObject("btnMinimize.ImageActive"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1249, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(32, 32)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnMinimize.TabIndex = 50
        Me.btnMinimize.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnMinimize, "Minimize")
        Me.btnMinimize.Zoom = 1
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.ImageActive = CType(resources.GetObject("btnAbout.ImageActive"), System.Drawing.Image)
        Me.btnAbout.Location = New System.Drawing.Point(1181, 2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(32, 32)
        Me.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnAbout.TabIndex = 49
        Me.btnAbout.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnAbout, "About")
        Me.btnAbout.Zoom = 1
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageActive = CType(resources.GetObject("btnSettings.ImageActive"), System.Drawing.Image)
        Me.btnSettings.Location = New System.Drawing.Point(1215, 2)
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
        Me.btnClose.Location = New System.Drawing.Point(1282, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 32)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnClose.TabIndex = 47
        Me.btnClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnClose, "Logout?")
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
        'Enrollment
        '
        Me.Enrollment.Activecolor = System.Drawing.SystemColors.Control
        Me.Enrollment.BackColor = System.Drawing.Color.Transparent
        Me.Enrollment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enrollment.BorderRadius = 0
        Me.Enrollment.ButtonText = "ENROLLMENT SECTION"
        Me.Enrollment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enrollment.DisabledColor = System.Drawing.Color.Gray
        Me.Enrollment.ForeColor = System.Drawing.Color.Gray
        Me.Enrollment.Iconcolor = System.Drawing.Color.Transparent
        Me.Enrollment.Iconimage = Nothing
        Me.Enrollment.Iconimage_right = Nothing
        Me.Enrollment.Iconimage_right_Selected = Nothing
        Me.Enrollment.Iconimage_Selected = Nothing
        Me.Enrollment.IconMarginLeft = 0
        Me.Enrollment.IconMarginRight = 0
        Me.Enrollment.IconRightVisible = True
        Me.Enrollment.IconRightZoom = 0.0R
        Me.Enrollment.IconVisible = True
        Me.Enrollment.IconZoom = 90.0R
        Me.Enrollment.IsTab = True
        Me.Enrollment.Location = New System.Drawing.Point(739, 0)
        Me.Enrollment.Name = "Enrollment"
        Me.Enrollment.Normalcolor = System.Drawing.Color.Transparent
        Me.Enrollment.OnHovercolor = System.Drawing.Color.LightSeaGreen
        Me.Enrollment.OnHoverTextColor = System.Drawing.Color.DarkSlateGray
        Me.Enrollment.selected = False
        Me.Enrollment.Size = New System.Drawing.Size(153, 34)
        Me.Enrollment.TabIndex = 57
        Me.Enrollment.Text = "ENROLLMENT SECTION"
        Me.Enrollment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Enrollment.Textcolor = System.Drawing.Color.DarkKhaki
        Me.Enrollment.TextFont = New System.Drawing.Font("Candara", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(100, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "C L O C K"
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.DarkKhaki
        Me.lblTime.Location = New System.Drawing.Point(37, 281)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(190, 34)
        Me.lblTime.TabIndex = 49
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dragControl
        '
        Me.dragControl.Fixed = True
        Me.dragControl.Horizontal = True
        Me.dragControl.TargetControl = Me.pnlTop
        Me.dragControl.Vertical = True
        '
        'timerNow
        '
        '
        'pnlGuestContainer
        '
        Me.pnlGuestContainer.BackgroundImage = CType(resources.GetObject("pnlGuestContainer.BackgroundImage"), System.Drawing.Image)
        Me.pnlGuestContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlGuestContainer.Controls.Add(Me.Label4)
        Me.pnlGuestContainer.Controls.Add(Me.Label15)
        Me.pnlGuestContainer.Controls.Add(Me.lblPosition)
        Me.pnlGuestContainer.Controls.Add(Me.Label12)
        Me.pnlGuestContainer.Controls.Add(Me.lblFullname)
        Me.pnlGuestContainer.Controls.Add(Me.lblGreet)
        Me.pnlGuestContainer.Controls.Add(Me.Label11)
        Me.pnlGuestContainer.Controls.Add(Me.Label2)
        Me.pnlGuestContainer.Controls.Add(Me.Label10)
        Me.pnlGuestContainer.Controls.Add(Me.Label9)
        Me.pnlGuestContainer.Controls.Add(Me.lblTime)
        Me.pnlGuestContainer.Controls.Add(Me.Label8)
        Me.pnlGuestContainer.Controls.Add(Me.Label7)
        Me.pnlGuestContainer.Controls.Add(Me.Label6)
        Me.pnlGuestContainer.Controls.Add(Me.Label5)
        Me.pnlGuestContainer.Controls.Add(Me.lblGuest)
        Me.pnlGuestContainer.Controls.Add(Me.Label3)
        Me.pnlGuestContainer.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlGuestContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlGuestContainer.Name = "pnlGuestContainer"
        Me.pnlGuestContainer.Size = New System.Drawing.Size(268, 700)
        Me.pnlGuestContainer.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(8, 426)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 21)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Personal Information"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Silver
        Me.Label15.Location = New System.Drawing.Point(13, 510)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 17)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Position :"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.NavajoWhite
        Me.lblPosition.Location = New System.Drawing.Point(19, 530)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(41, 19)
        Me.lblPosition.TabIndex = 63
        Me.lblPosition.Text = "none"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(13, 462)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Name :"
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.BackColor = System.Drawing.Color.Transparent
        Me.lblFullname.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.NavajoWhite
        Me.lblFullname.Location = New System.Drawing.Point(19, 480)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(41, 19)
        Me.lblFullname.TabIndex = 61
        Me.lblFullname.Text = "none"
        '
        'lblGreet
        '
        Me.lblGreet.AutoSize = True
        Me.lblGreet.BackColor = System.Drawing.Color.Transparent
        Me.lblGreet.Font = New System.Drawing.Font("Corbel", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreet.ForeColor = System.Drawing.Color.White
        Me.lblGreet.Location = New System.Drawing.Point(32, 337)
        Me.lblGreet.Name = "lblGreet"
        Me.lblGreet.Size = New System.Drawing.Size(0, 27)
        Me.lblGreet.TabIndex = 60
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semilight", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(96, 627)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 12)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Web Developer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Historic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label10.Location = New System.Drawing.Point(82, 609)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 19)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "V E O S C R I P T"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(26, 587)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 12)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Developed By :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(37, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 19)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Automated Enrollment System"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Khaki
        Me.Label7.Location = New System.Drawing.Point(16, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(237, 46)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "D A F E N H S"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Candara", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(124, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 18)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Candara", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(98, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "WELCOME"
        '
        'lblGuest
        '
        Me.lblGuest.AutoSize = True
        Me.lblGuest.BackColor = System.Drawing.Color.Transparent
        Me.lblGuest.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuest.ForeColor = System.Drawing.Color.DarkKhaki
        Me.lblGuest.Location = New System.Drawing.Point(92, 53)
        Me.lblGuest.Name = "lblGuest"
        Me.lblGuest.Size = New System.Drawing.Size(94, 33)
        Me.lblGuest.TabIndex = 52
        Me.lblGuest.Text = "GUEST"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(59, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Hey!"
        '
        'pnlUserControlHolder
        '
        Me.pnlUserControlHolder.BackColor = System.Drawing.Color.White
        Me.pnlUserControlHolder.Controls.Add(Me.Search1)
        Me.pnlUserControlHolder.Controls.Add(Me.ClassSchedule1)
        Me.pnlUserControlHolder.Controls.Add(Me.Enrollment1)
        Me.pnlUserControlHolder.Controls.Add(Me.lblMessageUser)
        Me.pnlUserControlHolder.Controls.Add(Me.Registration1)
        Me.pnlUserControlHolder.Controls.Add(Me.SeniorHighRegistration1)
        Me.pnlUserControlHolder.Controls.Add(Me.JuniorHighRegistration1)
        Me.pnlUserControlHolder.Controls.Add(Me.HomeDesign1)
        Me.pnlUserControlHolder.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlUserControlHolder.Location = New System.Drawing.Point(263, 0)
        Me.pnlUserControlHolder.Name = "pnlUserControlHolder"
        Me.pnlUserControlHolder.Size = New System.Drawing.Size(1052, 700)
        Me.pnlUserControlHolder.TabIndex = 3
        '
        'Search1
        '
        Me.Search1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Search1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Search1.Location = New System.Drawing.Point(0, 0)
        Me.Search1.Name = "Search1"
        Me.Search1.Size = New System.Drawing.Size(0, 700)
        Me.Search1.TabIndex = 54
        '
        'ClassSchedule1
        '
        Me.ClassSchedule1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClassSchedule1.Location = New System.Drawing.Point(0, 0)
        Me.ClassSchedule1.Name = "ClassSchedule1"
        Me.ClassSchedule1.Size = New System.Drawing.Size(0, 700)
        Me.ClassSchedule1.TabIndex = 53
        Me.ClassSchedule1.Visible = False
        '
        'Enrollment1
        '
        Me.Enrollment1.BackColor = System.Drawing.SystemColors.Control
        Me.Enrollment1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Enrollment1.Location = New System.Drawing.Point(0, 0)
        Me.Enrollment1.Name = "Enrollment1"
        Me.Enrollment1.Size = New System.Drawing.Size(0, 700)
        Me.Enrollment1.TabIndex = 52
        '
        'lblMessageUser
        '
        Me.lblMessageUser.AutoSize = True
        Me.lblMessageUser.BackColor = System.Drawing.SystemColors.Control
        Me.lblMessageUser.Font = New System.Drawing.Font("Calibri", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageUser.ForeColor = System.Drawing.Color.Red
        Me.lblMessageUser.Location = New System.Drawing.Point(585, 36)
        Me.lblMessageUser.Name = "lblMessageUser"
        Me.lblMessageUser.Size = New System.Drawing.Size(194, 13)
        Me.lblMessageUser.TabIndex = 51
        Me.lblMessageUser.Text = "This Register Link are intended only for ADMIN."
        Me.lblMessageUser.Visible = False
        '
        'Registration1
        '
        Me.Registration1.AutoScroll = True
        Me.Registration1.BackColor = System.Drawing.SystemColors.Control
        Me.Registration1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Registration1.Location = New System.Drawing.Point(-3156, 0)
        Me.Registration1.Name = "Registration1"
        Me.Registration1.Size = New System.Drawing.Size(1052, 700)
        Me.Registration1.TabIndex = 3
        '
        'SeniorHighRegistration1
        '
        Me.SeniorHighRegistration1.BackColor = System.Drawing.SystemColors.Control
        Me.SeniorHighRegistration1.Dock = System.Windows.Forms.DockStyle.Right
        Me.SeniorHighRegistration1.Location = New System.Drawing.Point(-2104, 0)
        Me.SeniorHighRegistration1.Name = "SeniorHighRegistration1"
        Me.SeniorHighRegistration1.Size = New System.Drawing.Size(1052, 700)
        Me.SeniorHighRegistration1.TabIndex = 2
        '
        'JuniorHighRegistration1
        '
        Me.JuniorHighRegistration1.BackColor = System.Drawing.SystemColors.Control
        Me.JuniorHighRegistration1.Dock = System.Windows.Forms.DockStyle.Right
        Me.JuniorHighRegistration1.Location = New System.Drawing.Point(-1052, 0)
        Me.JuniorHighRegistration1.Name = "JuniorHighRegistration1"
        Me.JuniorHighRegistration1.Size = New System.Drawing.Size(1052, 700)
        Me.JuniorHighRegistration1.TabIndex = 1
        '
        'HomeDesign1
        '
        Me.HomeDesign1.BackColor = System.Drawing.SystemColors.Control
        Me.HomeDesign1.Dock = System.Windows.Forms.DockStyle.Right
        Me.HomeDesign1.Location = New System.Drawing.Point(0, 0)
        Me.HomeDesign1.Name = "HomeDesign1"
        Me.HomeDesign1.Size = New System.Drawing.Size(1052, 700)
        Me.HomeDesign1.TabIndex = 0
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 700)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlGuestContainer)
        Me.Controls.Add(Me.pnlUserControlHolder)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DAFENHS Automated Enrollment System"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGuestContainer.ResumeLayout(False)
        Me.pnlGuestContainer.PerformLayout()
        Me.pnlUserControlHolder.ResumeLayout(False)
        Me.pnlUserControlHolder.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents dragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents timerNow As System.Windows.Forms.Timer
    Friend WithEvents pnlGuestContainer As System.Windows.Forms.Panel
    Friend WithEvents lblGuest As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblGreet As System.Windows.Forms.Label
    Friend WithEvents btnJuniorHighschool As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSeniorHighschool As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRegistration As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnHome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents pnlUserControlHolder As System.Windows.Forms.Panel
    Friend WithEvents HomeDesign1 As DAFENHS_Automated_Enrollment_System.HomeDesign
    Friend WithEvents JuniorHighRegistration1 As DAFENHS_Automated_Enrollment_System.JuniorHighRegistration
    Friend WithEvents SeniorHighRegistration1 As DAFENHS_Automated_Enrollment_System.SeniorHighRegistration
    Friend WithEvents btnClassList As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Registration1 As DAFENHS_Automated_Enrollment_System.Registration
    Friend WithEvents lblMessageUser As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Enrollment As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnEnrollmentSection As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Enrollment1 As DAFENHS_Automated_Enrollment_System.Enrollment
    Friend WithEvents ClassSchedule1 As DAFENHS_Automated_Enrollment_System.ClassSchedule
    Friend WithEvents Search1 As DAFENHS_Automated_Enrollment_System.Search

End Class
