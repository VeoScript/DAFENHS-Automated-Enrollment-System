<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecurityAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SecurityAdmin))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSeePassword = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnlTop = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnBack = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnHelp = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblLoginType = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnAccess = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.btnSeePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSeePassword
        '
        Me.btnSeePassword.BackColor = System.Drawing.Color.Transparent
        Me.btnSeePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeePassword.Image = CType(resources.GetObject("btnSeePassword.Image"), System.Drawing.Image)
        Me.btnSeePassword.ImageActive = CType(resources.GetObject("btnSeePassword.ImageActive"), System.Drawing.Image)
        Me.btnSeePassword.Location = New System.Drawing.Point(344, 162)
        Me.btnSeePassword.Name = "btnSeePassword"
        Me.btnSeePassword.Size = New System.Drawing.Size(31, 32)
        Me.btnSeePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnSeePassword.TabIndex = 138
        Me.btnSeePassword.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnSeePassword, "See Password")
        Me.btnSeePassword.Zoom = 1
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel3.Image = CType(resources.GetObject("BunifuCustomLabel3.Image"), System.Drawing.Image)
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(196, 55)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(39, 42)
        Me.BunifuCustomLabel3.TabIndex = 137
        Me.BunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnlTop
        Me.BunifuDragControl1.Vertical = True
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
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.GradientBottomLeft = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.GradientBottomRight = System.Drawing.Color.MediumTurquoise
        Me.pnlTop.GradientTopLeft = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.GradientTopRight = System.Drawing.Color.DarkSlateGray
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Quality = 10
        Me.pnlTop.Size = New System.Drawing.Size(423, 31)
        Me.pnlTop.TabIndex = 134
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(31, 9)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(55, 19)
        Me.BunifuCustomLabel2.TabIndex = 13
        Me.BunifuCustomLabel2.Text = "ADMIN"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageActive = CType(resources.GetObject("btnBack.ImageActive"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(388, 1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(34, 31)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnBack.TabIndex = 12
        Me.btnBack.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnBack, "Back?")
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
        'lblLoginType
        '
        Me.lblLoginType.AutoSize = True
        Me.lblLoginType.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginType.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginType.ForeColor = System.Drawing.Color.DimGray
        Me.lblLoginType.Location = New System.Drawing.Point(77, 108)
        Me.lblLoginType.Name = "lblLoginType"
        Me.lblLoginType.Size = New System.Drawing.Size(281, 22)
        Me.lblLoginType.TabIndex = 136
        Me.lblLoginType.Text = "S E C U R I T Y   P A S S W O R D"
        Me.lblLoginType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.HintForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.HintText = "Password"
        Me.txtPassword.isPassword = True
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtPassword.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtPassword.LineThickness = 2
        Me.txtPassword.Location = New System.Drawing.Point(77, 163)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(261, 41)
        Me.txtPassword.TabIndex = 132
        Me.txtPassword.TabStop = False
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnAccess
        '
        Me.btnAccess.Activecolor = System.Drawing.Color.DarkSlateGray
        Me.btnAccess.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAccess.BorderRadius = 7
        Me.btnAccess.ButtonText = "A C C E S S"
        Me.btnAccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccess.DisabledColor = System.Drawing.Color.Gray
        Me.btnAccess.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccess.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAccess.Iconimage = Nothing
        Me.btnAccess.Iconimage_right = Nothing
        Me.btnAccess.Iconimage_right_Selected = Nothing
        Me.btnAccess.Iconimage_Selected = Nothing
        Me.btnAccess.IconMarginLeft = 0
        Me.btnAccess.IconMarginRight = 0
        Me.btnAccess.IconRightVisible = True
        Me.btnAccess.IconRightZoom = 0.0R
        Me.btnAccess.IconVisible = True
        Me.btnAccess.IconZoom = 90.0R
        Me.btnAccess.IsTab = False
        Me.btnAccess.Location = New System.Drawing.Point(77, 216)
        Me.btnAccess.Name = "btnAccess"
        Me.btnAccess.Normalcolor = System.Drawing.Color.DarkSlateGray
        Me.btnAccess.OnHovercolor = System.Drawing.Color.Teal
        Me.btnAccess.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAccess.selected = False
        Me.btnAccess.Size = New System.Drawing.Size(261, 35)
        Me.btnAccess.TabIndex = 133
        Me.btnAccess.TabStop = False
        Me.btnAccess.Text = "A C C E S S"
        Me.btnAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAccess.Textcolor = System.Drawing.Color.White
        Me.btnAccess.TextFont = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(73, 270)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(273, 14)
        Me.BunifuCustomLabel1.TabIndex = 139
        Me.BunifuCustomLabel1.Text = "The ADMIN can only authorized to access this security login."
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SecurityAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(423, 303)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.lblLoginType)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnSeePassword)
        Me.Controls.Add(Me.btnAccess)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SecurityAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SecurityAdmin"
        CType(Me.btnSeePassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSeePassword As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents pnlTop As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnHelp As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblLoginType As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnAccess As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
