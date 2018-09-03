<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollmentSeniorHigh
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnrollmentSeniorHigh))
        Me.dgSubjectTeacher = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel24 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.btnEnroll = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel37 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cmbGradeLevel = New System.Windows.Forms.ComboBox()
        Me.txtSchoolYear = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtBirthDate = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtGender = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lblIdentifier = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLRN = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBirthPlace = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.picboxProfile = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAge = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cmbTrack = New System.Windows.Forms.ComboBox()
        Me.txtClassAdvisory = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.dgSubjectTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgSubjectTeacher
        '
        Me.dgSubjectTeacher.AllowUserToAddRows = False
        Me.dgSubjectTeacher.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgSubjectTeacher.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSubjectTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSubjectTeacher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgSubjectTeacher.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.dgSubjectTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSubjectTeacher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.dgSubjectTeacher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSubjectTeacher.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgSubjectTeacher.ColumnHeadersHeight = 50
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSubjectTeacher.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgSubjectTeacher.DoubleBuffered = True
        Me.dgSubjectTeacher.EnableHeadersVisualStyles = False
        Me.dgSubjectTeacher.GridColor = System.Drawing.Color.LightGray
        Me.dgSubjectTeacher.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.dgSubjectTeacher.HeaderForeColor = System.Drawing.Color.Silver
        Me.dgSubjectTeacher.Location = New System.Drawing.Point(485, 191)
        Me.dgSubjectTeacher.Name = "dgSubjectTeacher"
        Me.dgSubjectTeacher.ReadOnly = True
        Me.dgSubjectTeacher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgSubjectTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgSubjectTeacher.Size = New System.Drawing.Size(544, 331)
        Me.dgSubjectTeacher.TabIndex = 718
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageActive = CType(resources.GetObject("btnSearch.ImageActive"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(370, 90)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(35, 26)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 717
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(106, 90)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(265, 26)
        Me.txtSearch.TabIndex = 716
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel24
        '
        Me.BunifuCustomLabel24.AutoSize = True
        Me.BunifuCustomLabel24.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel24.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel24.Location = New System.Drawing.Point(757, 70)
        Me.BunifuCustomLabel24.Name = "BunifuCustomLabel24"
        Me.BunifuCustomLabel24.Size = New System.Drawing.Size(86, 17)
        Me.BunifuCustomLabel24.TabIndex = 715
        Me.BunifuCustomLabel24.Text = "School Section"
        Me.BunifuCustomLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSection
        '
        Me.cmbSection.BackColor = System.Drawing.Color.DimGray
        Me.cmbSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.ForeColor = System.Drawing.Color.White
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(754, 89)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(89, 29)
        Me.cmbSection.TabIndex = 714
        '
        'btnEnroll
        '
        Me.btnEnroll.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.btnEnroll.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnEnroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnroll.BorderRadius = 7
        Me.btnEnroll.ButtonText = "            E  N  R  O  L  L"
        Me.btnEnroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnroll.DisabledColor = System.Drawing.Color.Gray
        Me.btnEnroll.Enabled = False
        Me.btnEnroll.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnroll.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEnroll.Iconimage = CType(resources.GetObject("btnEnroll.Iconimage"), System.Drawing.Image)
        Me.btnEnroll.Iconimage_right = Nothing
        Me.btnEnroll.Iconimage_right_Selected = Nothing
        Me.btnEnroll.Iconimage_Selected = Nothing
        Me.btnEnroll.IconMarginLeft = 0
        Me.btnEnroll.IconMarginRight = 0
        Me.btnEnroll.IconRightVisible = True
        Me.btnEnroll.IconRightZoom = 0.0R
        Me.btnEnroll.IconVisible = True
        Me.btnEnroll.IconZoom = 90.0R
        Me.btnEnroll.IsTab = False
        Me.btnEnroll.Location = New System.Drawing.Point(666, 535)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.btnEnroll.OnHovercolor = System.Drawing.Color.Teal
        Me.btnEnroll.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEnroll.selected = False
        Me.btnEnroll.Size = New System.Drawing.Size(238, 51)
        Me.btnEnroll.TabIndex = 713
        Me.btnEnroll.Text = "            E  N  R  O  L  L"
        Me.btnEnroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnroll.Textcolor = System.Drawing.Color.White
        Me.btnEnroll.TextFont = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel37
        '
        Me.BunifuCustomLabel37.AutoSize = True
        Me.BunifuCustomLabel37.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel37.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel37.Location = New System.Drawing.Point(669, 70)
        Me.BunifuCustomLabel37.Name = "BunifuCustomLabel37"
        Me.BunifuCustomLabel37.Size = New System.Drawing.Size(69, 17)
        Me.BunifuCustomLabel37.TabIndex = 712
        Me.BunifuCustomLabel37.Text = "Grade Level"
        Me.BunifuCustomLabel37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbGradeLevel
        '
        Me.cmbGradeLevel.BackColor = System.Drawing.Color.DimGray
        Me.cmbGradeLevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGradeLevel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGradeLevel.ForeColor = System.Drawing.Color.White
        Me.cmbGradeLevel.FormattingEnabled = True
        Me.cmbGradeLevel.Items.AddRange(New Object() {"11", "12"})
        Me.cmbGradeLevel.Location = New System.Drawing.Point(666, 89)
        Me.cmbGradeLevel.Name = "cmbGradeLevel"
        Me.cmbGradeLevel.Size = New System.Drawing.Size(82, 29)
        Me.cmbGradeLevel.TabIndex = 711
        '
        'txtSchoolYear
        '
        Me.txtSchoolYear.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchoolYear.Location = New System.Drawing.Point(530, 90)
        Me.txtSchoolYear.Name = "txtSchoolYear"
        Me.txtSchoolYear.Size = New System.Drawing.Size(130, 26)
        Me.txtSchoolYear.TabIndex = 709
        Me.txtSchoolYear.Text = "2016-2017"
        Me.txtSchoolYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(533, 70)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(70, 17)
        Me.BunifuCustomLabel6.TabIndex = 710
        Me.BunifuCustomLabel6.Text = "School Year"
        Me.BunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBirthDate
        '
        Me.txtBirthDate.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBirthDate.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtBirthDate.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.txtBirthDate.BorderThickness = 1
        Me.txtBirthDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBirthDate.Enabled = False
        Me.txtBirthDate.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBirthDate.isPassword = False
        Me.txtBirthDate.Location = New System.Drawing.Point(210, 478)
        Me.txtBirthDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(156, 28)
        Me.txtBirthDate.TabIndex = 708
        Me.txtBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGender
        '
        Me.txtGender.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGender.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtGender.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.txtGender.BorderThickness = 1
        Me.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGender.Enabled = False
        Me.txtGender.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGender.isPassword = False
        Me.txtGender.Location = New System.Drawing.Point(210, 418)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(128, 28)
        Me.txtGender.TabIndex = 707
        Me.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIdentifier
        '
        Me.lblIdentifier.BackColor = System.Drawing.Color.Black
        Me.lblIdentifier.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentifier.ForeColor = System.Drawing.Color.White
        Me.lblIdentifier.Location = New System.Drawing.Point(22, 375)
        Me.lblIdentifier.Name = "lblIdentifier"
        Me.lblIdentifier.Size = New System.Drawing.Size(158, 31)
        Me.lblIdentifier.TabIndex = 706
        Me.lblIdentifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Candara", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(21, 416)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 13)
        Me.Label13.TabIndex = 705
        Me.Label13.Text = "LRN (Learner Reference Number)"
        '
        'txtLRN
        '
        Me.txtLRN.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLRN.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtLRN.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.txtLRN.BorderThickness = 1
        Me.txtLRN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLRN.Enabled = False
        Me.txtLRN.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLRN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLRN.isPassword = False
        Me.txtLRN.Location = New System.Drawing.Point(22, 434)
        Me.txtLRN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.Size = New System.Drawing.Size(158, 28)
        Me.txtLRN.TabIndex = 704
        Me.txtLRN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(216, 514)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 703
        Me.Label8.Text = "Place of Birth"
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBirthPlace.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtBirthPlace.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.txtBirthPlace.BorderThickness = 1
        Me.txtBirthPlace.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBirthPlace.Enabled = False
        Me.txtBirthPlace.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthPlace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBirthPlace.isPassword = False
        Me.txtBirthPlace.Location = New System.Drawing.Point(210, 535)
        Me.txtBirthPlace.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.Size = New System.Drawing.Size(238, 28)
        Me.txtBirthPlace.TabIndex = 702
        Me.txtBirthPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(69, 166)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 17)
        Me.Label21.TabIndex = 701
        Me.Label21.Text = "PROFILE"
        '
        'picboxProfile
        '
        Me.picboxProfile.BackColor = System.Drawing.Color.Black
        Me.picboxProfile.Location = New System.Drawing.Point(22, 186)
        Me.picboxProfile.Name = "picboxProfile"
        Me.picboxProfile.Size = New System.Drawing.Size(158, 189)
        Me.picboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxProfile.TabIndex = 700
        Me.picboxProfile.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(216, 457)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 17)
        Me.Label7.TabIndex = 699
        Me.Label7.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(350, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 698
        Me.Label6.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAge.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtAge.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.txtAge.BorderThickness = 1
        Me.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAge.Enabled = False
        Me.txtAge.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAge.isPassword = False
        Me.txtAge.Location = New System.Drawing.Point(346, 418)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(102, 28)
        Me.txtAge.TabIndex = 697
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(215, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 696
        Me.Label5.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtAddress.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.txtAddress.BorderThickness = 1
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress.isPassword = False
        Me.txtAddress.Location = New System.Drawing.Point(210, 360)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(238, 28)
        Me.txtAddress.TabIndex = 695
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(216, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 694
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(216, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 693
        Me.Label3.Text = "First Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMiddleName.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtMiddleName.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.txtMiddleName.BorderThickness = 1
        Me.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddleName.Enabled = False
        Me.txtMiddleName.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMiddleName.isPassword = False
        Me.txtMiddleName.Location = New System.Drawing.Point(210, 308)
        Me.txtMiddleName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(238, 28)
        Me.txtMiddleName.TabIndex = 692
        Me.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(216, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 691
        Me.Label1.Text = "Middle Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFirstName.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtFirstName.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.txtFirstName.BorderThickness = 1
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFirstName.isPassword = False
        Me.txtFirstName.Location = New System.Drawing.Point(210, 257)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(238, 28)
        Me.txtFirstName.TabIndex = 690
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(216, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 689
        Me.Label2.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLastName.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtLastName.BorderColorMouseHover = System.Drawing.Color.DimGray
        Me.txtLastName.BorderThickness = 1
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.Enabled = False
        Me.txtLastName.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLastName.isPassword = False
        Me.txtLastName.Location = New System.Drawing.Point(210, 204)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(238, 28)
        Me.txtLastName.TabIndex = 688
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(102, 27)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(304, 21)
        Me.BunifuCustomLabel1.TabIndex = 687
        Me.BunifuCustomLabel1.Text = "S E N I O R   H I G H   E N R O L L M E N T"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(109, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 14)
        Me.Label15.TabIndex = 686
        Me.Label15.Text = "Search Learner Reference Number"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(527, 143)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(84, 17)
        Me.BunifuCustomLabel2.TabIndex = 720
        Me.BunifuCustomLabel2.Text = "Class Advisory"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(852, 70)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(88, 17)
        Me.BunifuCustomLabel3.TabIndex = 722
        Me.BunifuCustomLabel3.Text = "Track or Strand"
        Me.BunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTrack
        '
        Me.cmbTrack.BackColor = System.Drawing.Color.DimGray
        Me.cmbTrack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrack.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrack.ForeColor = System.Drawing.Color.White
        Me.cmbTrack.FormattingEnabled = True
        Me.cmbTrack.Items.AddRange(New Object() {"GAS", "ICT", "AIM"})
        Me.cmbTrack.Location = New System.Drawing.Point(849, 89)
        Me.cmbTrack.Name = "cmbTrack"
        Me.cmbTrack.Size = New System.Drawing.Size(133, 29)
        Me.cmbTrack.TabIndex = 721
        '
        'txtClassAdvisory
        '
        Me.txtClassAdvisory.Enabled = False
        Me.txtClassAdvisory.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassAdvisory.Location = New System.Drawing.Point(524, 162)
        Me.txtClassAdvisory.Name = "txtClassAdvisory"
        Me.txtClassAdvisory.Size = New System.Drawing.Size(248, 26)
        Me.txtClassAdvisory.TabIndex = 723
        Me.txtClassAdvisory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRefresh
        '
        Me.btnRefresh.Activecolor = System.Drawing.Color.Transparent
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.BorderRadius = 7
        Me.btnRefresh.ButtonText = "   Refresh Table"
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.DisabledColor = System.Drawing.Color.Gray
        Me.btnRefresh.ForeColor = System.Drawing.Color.DimGray
        Me.btnRefresh.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRefresh.Iconimage = CType(resources.GetObject("btnRefresh.Iconimage"), System.Drawing.Image)
        Me.btnRefresh.Iconimage_right = Nothing
        Me.btnRefresh.Iconimage_right_Selected = Nothing
        Me.btnRefresh.Iconimage_Selected = Nothing
        Me.btnRefresh.IconMarginLeft = 0
        Me.btnRefresh.IconMarginRight = 0
        Me.btnRefresh.IconRightVisible = True
        Me.btnRefresh.IconRightZoom = 0.0R
        Me.btnRefresh.IconVisible = True
        Me.btnRefresh.IconZoom = 60.0R
        Me.btnRefresh.IsTab = False
        Me.btnRefresh.Location = New System.Drawing.Point(824, 154)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Normalcolor = System.Drawing.Color.Transparent
        Me.btnRefresh.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnRefresh.OnHoverTextColor = System.Drawing.Color.DodgerBlue
        Me.btnRefresh.selected = False
        Me.btnRefresh.Size = New System.Drawing.Size(130, 30)
        Me.btnRefresh.TabIndex = 724
        Me.btnRefresh.Text = "   Refresh Table"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Textcolor = System.Drawing.Color.DimGray
        Me.btnRefresh.TextFont = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'EnrollmentSeniorHigh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtClassAdvisory)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.cmbTrack)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.dgSubjectTeacher)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BunifuCustomLabel24)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.btnEnroll)
        Me.Controls.Add(Me.BunifuCustomLabel37)
        Me.Controls.Add(Me.cmbGradeLevel)
        Me.Controls.Add(Me.txtSchoolYear)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.txtBirthDate)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lblIdentifier)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtLRN)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBirthPlace)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.picboxProfile)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.Label15)
        Me.Name = "EnrollmentSeniorHigh"
        Me.Size = New System.Drawing.Size(1052, 596)
        CType(Me.dgSubjectTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgSubjectTeacher As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BunifuCustomLabel24 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents btnEnroll As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel37 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cmbGradeLevel As System.Windows.Forms.ComboBox
    Friend WithEvents txtSchoolYear As System.Windows.Forms.TextBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtBirthDate As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtGender As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lblIdentifier As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtLRN As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBirthPlace As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents picboxProfile As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAge As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cmbTrack As System.Windows.Forms.ComboBox
    Friend WithEvents txtClassAdvisory As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As Bunifu.Framework.UI.BunifuFlatButton

End Class
