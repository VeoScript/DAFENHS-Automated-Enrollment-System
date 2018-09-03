<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAdviser = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbTrack = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtGradeLevel = New System.Windows.Forms.TextBox()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSchoolYear = New System.Windows.Forms.TextBox()
        Me.dgClassList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbPopulationCategory = New System.Windows.Forms.ComboBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnSearchPopulation = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSchoolYearPopulation = New System.Windows.Forms.TextBox()
        Me.dgPopulation = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgClassList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.btnSearchPopulation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPopulation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1052, 663)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.cmbTrack)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.cmbCategory)
        Me.TabPage1.Controls.Add(Me.BunifuCustomLabel1)
        Me.TabPage1.Controls.Add(Me.txtSection)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtGradeLevel)
        Me.TabPage1.Controls.Add(Me.btnSearch)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtSchoolYear)
        Me.TabPage1.Controls.Add(Me.dgClassList)
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1044, 633)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Class List"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.txtAdviser)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 530)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1038, 100)
        Me.Panel1.TabIndex = 728
        '
        'txtAdviser
        '
        Me.txtAdviser.Enabled = False
        Me.txtAdviser.Font = New System.Drawing.Font("Candara", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdviser.Location = New System.Drawing.Point(308, 45)
        Me.txtAdviser.Name = "txtAdviser"
        Me.txtAdviser.Size = New System.Drawing.Size(369, 29)
        Me.txtAdviser.TabIndex = 726
        Me.txtAdviser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label14.Location = New System.Drawing.Point(423, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 17)
        Me.Label14.TabIndex = 727
        Me.Label14.Text = "C L A S S   A D V I S E R"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(520, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 13)
        Me.Label8.TabIndex = 724
        Me.Label8.Text = "T R A C K   o r   S T R A N D"
        '
        'cmbTrack
        '
        Me.cmbTrack.BackColor = System.Drawing.Color.DimGray
        Me.cmbTrack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbTrack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTrack.Enabled = False
        Me.cmbTrack.Font = New System.Drawing.Font("Microsoft Tai Le", 11.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrack.ForeColor = System.Drawing.Color.White
        Me.cmbTrack.FormattingEnabled = True
        Me.cmbTrack.Items.AddRange(New Object() {"GAS", "ICT", "AIM"})
        Me.cmbTrack.Location = New System.Drawing.Point(523, 36)
        Me.cmbTrack.Name = "cmbTrack"
        Me.cmbTrack.Size = New System.Drawing.Size(110, 29)
        Me.cmbTrack.TabIndex = 723
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(393, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 706
        Me.Label7.Text = "C A T E G O R Y"
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.DimGray
        Me.cmbCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Microsoft Tai Le", 11.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.ForeColor = System.Drawing.Color.White
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Junior Highschool", "Senior Highschool"})
        Me.cmbCategory.Location = New System.Drawing.Point(331, 36)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(189, 29)
        Me.cmbCategory.TabIndex = 705
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(-4, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(195, 74)
        Me.BunifuCustomLabel1.TabIndex = 704
        Me.BunifuCustomLabel1.Text = "C L A S S   L I S T"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Candara", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.Location = New System.Drawing.Point(851, 36)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(127, 29)
        Me.txtSection.TabIndex = 703
        Me.txtSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(886, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 702
        Me.Label10.Text = "S E C T I O N"
        '
        'txtGradeLevel
        '
        Me.txtGradeLevel.Font = New System.Drawing.Font("Candara", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGradeLevel.Location = New System.Drawing.Point(764, 36)
        Me.txtGradeLevel.Name = "txtGradeLevel"
        Me.txtGradeLevel.Size = New System.Drawing.Size(88, 29)
        Me.txtGradeLevel.TabIndex = 701
        Me.txtGradeLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageActive = CType(resources.GetObject("btnSearch.ImageActive"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(977, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(35, 29)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 700
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(654, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 699
        Me.Label9.Text = "S C H O O L   Y E A R"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(766, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 698
        Me.Label6.Text = "G R A D E   L E V E L"
        '
        'txtSchoolYear
        '
        Me.txtSchoolYear.Font = New System.Drawing.Font("Candara", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchoolYear.Location = New System.Drawing.Point(635, 36)
        Me.txtSchoolYear.Name = "txtSchoolYear"
        Me.txtSchoolYear.Size = New System.Drawing.Size(130, 29)
        Me.txtSchoolYear.TabIndex = 697
        Me.txtSchoolYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgClassList
        '
        Me.dgClassList.AllowUserToAddRows = False
        Me.dgClassList.AllowUserToDeleteRows = False
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.LightSeaGreen
        Me.dgClassList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle26
        Me.dgClassList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgClassList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgClassList.BackgroundColor = System.Drawing.Color.Teal
        Me.dgClassList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgClassList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgClassList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgClassList.DefaultCellStyle = DataGridViewCellStyle28
        Me.dgClassList.DoubleBuffered = True
        Me.dgClassList.EnableHeadersVisualStyles = False
        Me.dgClassList.GridColor = System.Drawing.Color.LightSeaGreen
        Me.dgClassList.HeaderBgColor = System.Drawing.Color.Teal
        Me.dgClassList.HeaderForeColor = System.Drawing.Color.White
        Me.dgClassList.Location = New System.Drawing.Point(3, 74)
        Me.dgClassList.Name = "dgClassList"
        Me.dgClassList.ReadOnly = True
        Me.dgClassList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgClassList.RowHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.dgClassList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Candara", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgClassList.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.dgClassList.Size = New System.Drawing.Size(1038, 450)
        Me.dgClassList.TabIndex = 276
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.cmbPopulationCategory)
        Me.TabPage2.Controls.Add(Me.lblTotal)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.lblFemale)
        Me.TabPage2.Controls.Add(Me.lblMale)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.BunifuCustomLabel2)
        Me.TabPage2.Controls.Add(Me.btnSearchPopulation)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtSchoolYearPopulation)
        Me.TabPage2.Controls.Add(Me.dgPopulation)
        Me.TabPage2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1044, 633)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Population"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label13.Location = New System.Drawing.Point(202, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 726
        Me.Label13.Text = "C A T E G O R Y"
        '
        'cmbPopulationCategory
        '
        Me.cmbPopulationCategory.BackColor = System.Drawing.Color.DimGray
        Me.cmbPopulationCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbPopulationCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPopulationCategory.Font = New System.Drawing.Font("Microsoft Tai Le", 11.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPopulationCategory.ForeColor = System.Drawing.Color.White
        Me.cmbPopulationCategory.FormattingEnabled = True
        Me.cmbPopulationCategory.Items.AddRange(New Object() {"Junior Highschool", "Senior Highschool"})
        Me.cmbPopulationCategory.Location = New System.Drawing.Point(205, 31)
        Me.cmbPopulationCategory.Name = "cmbPopulationCategory"
        Me.cmbPopulationCategory.Size = New System.Drawing.Size(148, 29)
        Me.cmbPopulationCategory.TabIndex = 725
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.MintCream
        Me.lblTotal.Location = New System.Drawing.Point(933, 33)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 27)
        Me.lblTotal.TabIndex = 718
        Me.lblTotal.Text = "00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label11.Location = New System.Drawing.Point(904, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 717
        Me.Label11.Text = "OVER ALL STUDENTS"
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.BackColor = System.Drawing.Color.Transparent
        Me.lblFemale.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.ForeColor = System.Drawing.Color.Yellow
        Me.lblFemale.Location = New System.Drawing.Point(840, 31)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(23, 27)
        Me.lblFemale.TabIndex = 716
        Me.lblFemale.Text = "0"
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.BackColor = System.Drawing.Color.Transparent
        Me.lblMale.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.ForeColor = System.Drawing.Color.Yellow
        Me.lblMale.Location = New System.Drawing.Point(668, 30)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(23, 27)
        Me.lblMale.TabIndex = 715
        Me.lblMale.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label5.Location = New System.Drawing.Point(725, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 714
        Me.Label5.Text = "S T U D E N T   F E M A L E  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label4.Location = New System.Drawing.Point(553, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 713
        Me.Label4.Text = "S T U D E N T   M A L E        :"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(0, 1)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(186, 74)
        Me.BunifuCustomLabel2.TabIndex = 712
        Me.BunifuCustomLabel2.Text = "P O P U L A T I O N"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearchPopulation
        '
        Me.btnSearchPopulation.BackColor = System.Drawing.Color.White
        Me.btnSearchPopulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnSearchPopulation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchPopulation.Image = CType(resources.GetObject("btnSearchPopulation.Image"), System.Drawing.Image)
        Me.btnSearchPopulation.ImageActive = CType(resources.GetObject("btnSearchPopulation.ImageActive"), System.Drawing.Image)
        Me.btnSearchPopulation.Location = New System.Drawing.Point(482, 31)
        Me.btnSearchPopulation.Name = "btnSearchPopulation"
        Me.btnSearchPopulation.Size = New System.Drawing.Size(35, 29)
        Me.btnSearchPopulation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearchPopulation.TabIndex = 708
        Me.btnSearchPopulation.TabStop = False
        Me.btnSearchPopulation.Zoom = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(354, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 707
        Me.Label2.Text = "S C H O O L   Y E A R"
        '
        'txtSchoolYearPopulation
        '
        Me.txtSchoolYearPopulation.Font = New System.Drawing.Font("Candara", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchoolYearPopulation.Location = New System.Drawing.Point(353, 31)
        Me.txtSchoolYearPopulation.Name = "txtSchoolYearPopulation"
        Me.txtSchoolYearPopulation.Size = New System.Drawing.Size(130, 29)
        Me.txtSchoolYearPopulation.TabIndex = 705
        Me.txtSchoolYearPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgPopulation
        '
        Me.dgPopulation.AllowUserToAddRows = False
        Me.dgPopulation.AllowUserToDeleteRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.LightSeaGreen
        Me.dgPopulation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.dgPopulation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPopulation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgPopulation.BackgroundColor = System.Drawing.Color.Teal
        Me.dgPopulation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPopulation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPopulation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgPopulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPopulation.DefaultCellStyle = DataGridViewCellStyle23
        Me.dgPopulation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgPopulation.DoubleBuffered = True
        Me.dgPopulation.EnableHeadersVisualStyles = False
        Me.dgPopulation.GridColor = System.Drawing.Color.LightSeaGreen
        Me.dgPopulation.HeaderBgColor = System.Drawing.Color.Teal
        Me.dgPopulation.HeaderForeColor = System.Drawing.Color.White
        Me.dgPopulation.Location = New System.Drawing.Point(3, 75)
        Me.dgPopulation.Name = "dgPopulation"
        Me.dgPopulation.ReadOnly = True
        Me.dgPopulation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPopulation.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Candara", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgPopulation.RowsDefaultCellStyle = DataGridViewCellStyle25
        Me.dgPopulation.Size = New System.Drawing.Size(1038, 555)
        Me.dgPopulation.TabIndex = 704
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Search"
        Me.Size = New System.Drawing.Size(1052, 700)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgClassList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.btnSearchPopulation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPopulation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgClassList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGradeLevel As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSchoolYear As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchPopulation As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSchoolYearPopulation As System.Windows.Forms.TextBox
    Friend WithEvents dgPopulation As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFemale As System.Windows.Forms.Label
    Friend WithEvents lblMale As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbTrack As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbPopulationCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtAdviser As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label

End Class
