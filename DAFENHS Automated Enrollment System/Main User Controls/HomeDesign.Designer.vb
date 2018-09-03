<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeDesign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeDesign))
        Me.FormRadius = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lblAddress = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblTitle = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblDivision = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblMeaning = New System.Windows.Forms.Label()
        Me.lblPledge = New System.Windows.Forms.Label()
        Me.lblCopyRight = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormRadius
        '
        Me.FormRadius.ElipseRadius = 10
        Me.FormRadius.TargetControl = Me
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft New Tai Lue", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAddress.Location = New System.Drawing.Point(407, 123)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(233, 19)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Bogo, Tomas Oppus, Southern Leyte"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft New Tai Lue", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(257, 95)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(556, 29)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "DON AGUSTIN F. ESCAÑO NATIONAL HIGH SCHOOL"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivision.Location = New System.Drawing.Point(445, 77)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(146, 17)
        Me.lblDivision.TabIndex = 7
        Me.lblDivision.Text = "Division of Southern Leyte"
        Me.lblDivision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMeaning
        '
        Me.lblMeaning.AutoSize = True
        Me.lblMeaning.Font = New System.Drawing.Font("Candara", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeaning.ForeColor = System.Drawing.Color.DimGray
        Me.lblMeaning.Location = New System.Drawing.Point(286, 607)
        Me.lblMeaning.Name = "lblMeaning"
        Me.lblMeaning.Size = New System.Drawing.Size(493, 13)
        Me.lblMeaning.TabIndex = 42
        Me.lblMeaning.Text = "I HEREBY PLEDGE TO BE LOYAL TO THE SCHOOL AND TO OBEY ITS EXISTING RULES AND REGU" & _
    "LATIONS."
        '
        'lblPledge
        '
        Me.lblPledge.AutoSize = True
        Me.lblPledge.Font = New System.Drawing.Font("Candara", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPledge.ForeColor = System.Drawing.Color.DimGray
        Me.lblPledge.Location = New System.Drawing.Point(459, 582)
        Me.lblPledge.Name = "lblPledge"
        Me.lblPledge.Size = New System.Drawing.Size(134, 17)
        Me.lblPledge.TabIndex = 41
        Me.lblPledge.Text = "PLEDGE OF LOYALTY"
        '
        'lblCopyRight
        '
        Me.lblCopyRight.AutoSize = True
        Me.lblCopyRight.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyRight.Font = New System.Drawing.Font("Candara", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyRight.ForeColor = System.Drawing.Color.Gray
        Me.lblCopyRight.Location = New System.Drawing.Point(386, 645)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(291, 26)
        Me.lblCopyRight.TabIndex = 44
        Me.lblCopyRight.Text = "Copyrights of DON AGUSTIN F. ESCAÑO NATIONAL HIGHSCHOOL. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All Rights Reserved 20" & _
    "17"
        Me.lblCopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(242, 626)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(587, 15)
        Me.BunifuSeparator1.TabIndex = 43
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(324, 491)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(411, 30)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "AUTOMATED ENROLLMENT SYSTEM"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(386, 185)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(293, 264)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(464, 462)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 21)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "P  R  E  S  E  N  T"
        '
        'HomeDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblCopyRight)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.lblMeaning)
        Me.Controls.Add(Me.lblPledge)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDivision)
        Me.Name = "HomeDesign"
        Me.Size = New System.Drawing.Size(1052, 700)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormRadius As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lblAddress As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblTitle As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblDivision As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblMeaning As System.Windows.Forms.Label
    Friend WithEvents lblPledge As System.Windows.Forms.Label
    Friend WithEvents lblCopyRight As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
