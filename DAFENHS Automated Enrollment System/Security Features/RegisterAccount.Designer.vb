<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterAccount))
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cmbAccountType = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnBack = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnHelp = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtIdNumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtFullname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.separator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblLoginType = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.btnSeePassword = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSeePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.btnLogin.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.BorderRadius = 7
        Me.btnLogin.ButtonText = "R E G I S T E R"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnLogin.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogin.Iconimage = Nothing
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
        Me.btnLogin.Location = New System.Drawing.Point(451, 340)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.btnLogin.OnHovercolor = System.Drawing.Color.Teal
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(228, 32)
        Me.btnLogin.TabIndex = 31
        Me.btnLogin.Text = "R E G I S T E R"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogin.Textcolor = System.Drawing.Color.White
        Me.btnLogin.TextFont = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cmbAccountType
        '
        Me.cmbAccountType.BackColor = System.Drawing.Color.DimGray
        Me.cmbAccountType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccountType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbAccountType.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccountType.ForeColor = System.Drawing.Color.White
        Me.cmbAccountType.FormattingEnabled = True
        Me.cmbAccountType.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.cmbAccountType.Location = New System.Drawing.Point(433, 177)
        Me.cmbAccountType.Name = "cmbAccountType"
        Me.cmbAccountType.Size = New System.Drawing.Size(262, 31)
        Me.cmbAccountType.TabIndex = 30
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(434, 155)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(92, 19)
        Me.BunifuCustomLabel1.TabIndex = 29
        Me.BunifuCustomLabel1.Text = "Account Type"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.BackgroundImage = CType(resources.GetObject("pnlTop.BackgroundImage"), System.Drawing.Image)
        Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlTop.Controls.Add(Me.BunifuCustomLabel2)
        Me.pnlTop.Controls.Add(Me.btnBack)
        Me.pnlTop.Controls.Add(Me.btnHelp)
        Me.pnlTop.Controls.Add(Me.BunifuImageButton1)
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.GradientBottomLeft = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.GradientBottomRight = System.Drawing.Color.MediumTurquoise
        Me.pnlTop.GradientTopLeft = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.GradientTopRight = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.Location = New System.Drawing.Point(-1, -1)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Quality = 10
        Me.pnlTop.Size = New System.Drawing.Size(760, 31)
        Me.pnlTop.TabIndex = 28
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(31, 9)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(112, 19)
        Me.BunifuCustomLabel2.TabIndex = 13
        Me.BunifuCustomLabel2.Text = "Register Account"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageActive = CType(resources.GetObject("btnBack.ImageActive"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(726, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(34, 32)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnBack.TabIndex = 12
        Me.btnBack.TabStop = False
        Me.btnBack.Zoom = 10
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageActive = CType(resources.GetObject("btnHelp.ImageActive"), System.Drawing.Image)
        Me.btnHelp.Location = New System.Drawing.Point(1198, 1)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(32, 21)
        Me.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnHelp.TabIndex = 11
        Me.btnHelp.TabStop = False
        Me.btnHelp.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = CType(resources.GetObject("BunifuImageButton1.ImageActive"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1232, 1)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(32, 21)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BunifuImageButton1.TabIndex = 10
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = CType(resources.GetObject("btnClose.ImageActive"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(1265, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 21)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnClose.TabIndex = 9
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.HintForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.HintText = "Password"
        Me.txtPassword.isPassword = True
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtPassword.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtPassword.LineThickness = 2
        Me.txtPassword.Location = New System.Drawing.Point(433, 285)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(262, 29)
        Me.txtPassword.TabIndex = 33
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Gainsboro
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.HintForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.HintText = "Username"
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtUsername.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtUsername.LineThickness = 2
        Me.txtUsername.Location = New System.Drawing.Point(433, 225)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(262, 29)
        Me.txtUsername.TabIndex = 32
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtIdNumber
        '
        Me.txtIdNumber.BackColor = System.Drawing.Color.Gainsboro
        Me.txtIdNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdNumber.ForeColor = System.Drawing.Color.DimGray
        Me.txtIdNumber.HintForeColor = System.Drawing.Color.DimGray
        Me.txtIdNumber.HintText = "Id Number"
        Me.txtIdNumber.isPassword = False
        Me.txtIdNumber.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtIdNumber.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtIdNumber.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtIdNumber.LineThickness = 2
        Me.txtIdNumber.Location = New System.Drawing.Point(54, 151)
        Me.txtIdNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(262, 31)
        Me.txtIdNumber.TabIndex = 34
        Me.txtIdNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtFullname
        '
        Me.txtFullname.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.ForeColor = System.Drawing.Color.DimGray
        Me.txtFullname.HintForeColor = System.Drawing.Color.DimGray
        Me.txtFullname.HintText = "Fullname"
        Me.txtFullname.isPassword = False
        Me.txtFullname.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtFullname.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtFullname.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtFullname.LineThickness = 2
        Me.txtFullname.Location = New System.Drawing.Point(54, 210)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(262, 31)
        Me.txtFullname.TabIndex = 35
        Me.txtFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cmbPosition
        '
        Me.cmbPosition.BackColor = System.Drawing.Color.DimGray
        Me.cmbPosition.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPosition.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbPosition.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPosition.ForeColor = System.Drawing.Color.White
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Items.AddRange(New Object() {"Teacher in Junior High", "Teacher in Senior High", "Administrator", "Secretary"})
        Me.cmbPosition.Location = New System.Drawing.Point(54, 288)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(262, 27)
        Me.cmbPosition.TabIndex = 36
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(56, 265)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(61, 20)
        Me.BunifuCustomLabel3.TabIndex = 37
        Me.BunifuCustomLabel3.Text = "Position"
        Me.BunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'separator1
        '
        Me.separator1.BackColor = System.Drawing.Color.Transparent
        Me.separator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.separator1.LineThickness = 4
        Me.separator1.Location = New System.Drawing.Point(375, 87)
        Me.separator1.Name = "separator1"
        Me.separator1.Size = New System.Drawing.Size(13, 285)
        Me.separator1.TabIndex = 118
        Me.separator1.Transparency = 255
        Me.separator1.Vertical = True
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(459, 101)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(212, 21)
        Me.BunifuCustomLabel8.TabIndex = 126
        Me.BunifuCustomLabel8.Text = "C R E A T E   A C C O U N T"
        Me.BunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLoginType
        '
        Me.lblLoginType.AutoSize = True
        Me.lblLoginType.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginType.ForeColor = System.Drawing.Color.DimGray
        Me.lblLoginType.Location = New System.Drawing.Point(44, 101)
        Me.lblLoginType.Name = "lblLoginType"
        Me.lblLoginType.Size = New System.Drawing.Size(292, 21)
        Me.lblLoginType.TabIndex = 125
        Me.lblLoginType.Text = "P E R S O N A L   I N F O R M A T I O N "
        Me.lblLoginType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft YaHei", 6.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(64, 344)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(245, 14)
        Me.BunifuCustomLabel4.TabIndex = 127
        Me.BunifuCustomLabel4.Text = "This account is intended only for the Security Account"
        Me.BunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnlTop
        Me.BunifuDragControl1.Vertical = True
        '
        'btnSeePassword
        '
        Me.btnSeePassword.BackColor = System.Drawing.Color.Transparent
        Me.btnSeePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeePassword.Image = CType(resources.GetObject("btnSeePassword.Image"), System.Drawing.Image)
        Me.btnSeePassword.ImageActive = CType(resources.GetObject("btnSeePassword.ImageActive"), System.Drawing.Image)
        Me.btnSeePassword.Location = New System.Drawing.Point(698, 281)
        Me.btnSeePassword.Name = "btnSeePassword"
        Me.btnSeePassword.Size = New System.Drawing.Size(32, 32)
        Me.btnSeePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSeePassword.TabIndex = 128
        Me.btnSeePassword.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnSeePassword, "See Password")
        Me.btnSeePassword.Zoom = 1
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel5.Image = CType(resources.GetObject("BunifuCustomLabel5.Image"), System.Drawing.Image)
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(542, 44)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(40, 42)
        Me.BunifuCustomLabel5.TabIndex = 129
        Me.BunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel6.Image = CType(resources.GetObject("BunifuCustomLabel6.Image"), System.Drawing.Image)
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(162, 38)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(40, 52)
        Me.BunifuCustomLabel6.TabIndex = 130
        Me.BunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegisterAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(759, 410)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.btnSeePassword)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.lblLoginType)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.cmbPosition)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.txtIdNumber)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.cmbAccountType)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.separator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegisterAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterAccount"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSeePassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cmbAccountType As System.Windows.Forms.ComboBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlTop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnHelp As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Friend WithEvents txtFullname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtIdNumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblLoginType As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents separator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnSeePassword As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
