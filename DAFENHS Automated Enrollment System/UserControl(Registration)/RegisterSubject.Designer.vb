<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterSubject))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblMeaning = New System.Windows.Forms.Label()
        Me.lblPledge = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtGradeLevel = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSubject = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRegister = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(177, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 21)
        Me.Label4.TabIndex = 250
        Me.Label4.Text = "SUBJECT'S REGISTRATION"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel2.Image = CType(resources.GetObject("BunifuCustomLabel2.Image"), System.Drawing.Image)
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(727, 120)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(50, 54)
        Me.BunifuCustomLabel2.TabIndex = 249
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMeaning
        '
        Me.lblMeaning.AutoSize = True
        Me.lblMeaning.Font = New System.Drawing.Font("Candara", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeaning.ForeColor = System.Drawing.Color.DarkGray
        Me.lblMeaning.Location = New System.Drawing.Point(53, 449)
        Me.lblMeaning.Name = "lblMeaning"
        Me.lblMeaning.Size = New System.Drawing.Size(448, 13)
        Me.lblMeaning.TabIndex = 248
        Me.lblMeaning.Text = "I HEREBY PLEDGE TO BE LOYAL TO THE SCHOOL AND TO OBEY ITS EXISTING RULES AND REGU" & _
    "LATIONS."
        '
        'lblPledge
        '
        Me.lblPledge.AutoSize = True
        Me.lblPledge.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPledge.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPledge.Location = New System.Drawing.Point(213, 432)
        Me.lblPledge.Name = "lblPledge"
        Me.lblPledge.Size = New System.Drawing.Size(115, 14)
        Me.lblPledge.TabIndex = 247
        Me.lblPledge.Text = "PLEDGE OF LOYALTY"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(225, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 21)
        Me.Label8.TabIndex = 246
        Me.Label8.Text = "S U B J E C T"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(130, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(280, 54)
        Me.Label7.TabIndex = 245
        Me.Label7.Text = "D A F E N H S"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(607, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 244
        Me.Label10.Text = "Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Black
        Me.cmbCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.ForeColor = System.Drawing.Color.White
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Junior Highschool", "Senior Highschool"})
        Me.cmbCategory.Location = New System.Drawing.Point(604, 342)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(303, 24)
        Me.cmbCategory.TabIndex = 243
        '
        'txtGradeLevel
        '
        Me.txtGradeLevel.BorderColorFocused = System.Drawing.Color.MediumTurquoise
        Me.txtGradeLevel.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtGradeLevel.BorderColorMouseHover = System.Drawing.Color.MediumTurquoise
        Me.txtGradeLevel.BorderThickness = 2
        Me.txtGradeLevel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGradeLevel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGradeLevel.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtGradeLevel.isPassword = False
        Me.txtGradeLevel.Location = New System.Drawing.Point(604, 233)
        Me.txtGradeLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGradeLevel.Name = "txtGradeLevel"
        Me.txtGradeLevel.Size = New System.Drawing.Size(303, 28)
        Me.txtGradeLevel.TabIndex = 238
        Me.txtGradeLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(671, 174)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(166, 21)
        Me.BunifuCustomLabel1.TabIndex = 237
        Me.BunifuCustomLabel1.Text = "I N F O R M A T I O N"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(609, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 239
        Me.Label2.Text = "Grade Level"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel4.Image = CType(resources.GetObject("BunifuCustomLabel4.Image"), System.Drawing.Image)
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(244, 245)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(50, 54)
        Me.BunifuCustomLabel4.TabIndex = 240
        Me.BunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSubject
        '
        Me.txtSubject.BorderColorFocused = System.Drawing.Color.MediumTurquoise
        Me.txtSubject.BorderColorIdle = System.Drawing.Color.DimGray
        Me.txtSubject.BorderColorMouseHover = System.Drawing.Color.MediumTurquoise
        Me.txtSubject.BorderThickness = 2
        Me.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubject.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtSubject.isPassword = False
        Me.txtSubject.Location = New System.Drawing.Point(604, 288)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(303, 28)
        Me.txtSubject.TabIndex = 251
        Me.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(609, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 252
        Me.Label1.Text = "My Subject"
        '
        'btnDelete
        '
        Me.btnDelete.Activecolor = System.Drawing.Color.DimGray
        Me.btnDelete.BackColor = System.Drawing.Color.DimGray
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.BorderRadius = 7
        Me.btnDelete.ButtonText = "Delete"
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DisabledColor = System.Drawing.Color.Gray
        Me.btnDelete.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDelete.Iconimage = CType(resources.GetObject("btnDelete.Iconimage"), System.Drawing.Image)
        Me.btnDelete.Iconimage_right = Nothing
        Me.btnDelete.Iconimage_right_Selected = Nothing
        Me.btnDelete.Iconimage_Selected = Nothing
        Me.btnDelete.IconMarginLeft = 0
        Me.btnDelete.IconMarginRight = 0
        Me.btnDelete.IconRightVisible = True
        Me.btnDelete.IconRightZoom = 0.0R
        Me.btnDelete.IconVisible = True
        Me.btnDelete.IconZoom = 90.0R
        Me.btnDelete.IsTab = False
        Me.btnDelete.Location = New System.Drawing.Point(772, 392)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Normalcolor = System.Drawing.Color.DimGray
        Me.btnDelete.OnHovercolor = System.Drawing.Color.Teal
        Me.btnDelete.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDelete.selected = False
        Me.btnDelete.Size = New System.Drawing.Size(135, 48)
        Me.btnDelete.TabIndex = 254
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDelete.Textcolor = System.Drawing.Color.White
        Me.btnDelete.TextFont = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRegister
        '
        Me.btnRegister.Activecolor = System.Drawing.Color.DimGray
        Me.btnRegister.BackColor = System.Drawing.Color.DimGray
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegister.BorderRadius = 7
        Me.btnRegister.ButtonText = "Register"
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
        Me.btnRegister.Location = New System.Drawing.Point(604, 392)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Normalcolor = System.Drawing.Color.DimGray
        Me.btnRegister.OnHovercolor = System.Drawing.Color.Teal
        Me.btnRegister.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRegister.selected = False
        Me.btnRegister.Size = New System.Drawing.Size(134, 48)
        Me.btnRegister.TabIndex = 255
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Textcolor = System.Drawing.Color.White
        Me.btnRegister.TextFont = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageActive = CType(resources.GetObject("btnSearch.ImageActive"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(383, 67)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(35, 26)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 689
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(119, 67)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(265, 26)
        Me.txtSearch.TabIndex = 688
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label15.Location = New System.Drawing.Point(122, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 14)
        Me.Label15.TabIndex = 687
        Me.Label15.Text = "Search Subject"
        '
        'RegisterSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.lblMeaning)
        Me.Controls.Add(Me.lblPledge)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtGradeLevel)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Name = "RegisterSubject"
        Me.Size = New System.Drawing.Size(1001, 522)
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblMeaning As System.Windows.Forms.Label
    Friend WithEvents lblPledge As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtGradeLevel As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSubject As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRegister As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
