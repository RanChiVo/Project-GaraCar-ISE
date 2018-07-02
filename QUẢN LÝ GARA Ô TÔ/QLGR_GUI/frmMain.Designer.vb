<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.logoanimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.TiếpNhậnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiếpNhậnXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLíÔTôToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýPhụTùngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýHiệuXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýTiềnCôngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýPhiếuSữaChữaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SữaChữaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SữaChữaÔTôToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraCứuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraCứuXeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpPhiếuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpPhiếuThuTiềnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpPhiếuSửaChữaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoDanhThuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoPhụTùngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelAccount = New Bunifu.Framework.UI.BunifuCards()
        Me.Panelchangepass = New System.Windows.Forms.Panel()
        Me.txtNewPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnChangePW = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtpassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtuser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.user = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnThayDoiSL = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbXeMoi = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSoXeTNM = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbXetoida = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.sidemenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnHome = New Bunifu.Framework.UI.BunifuImageButton()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel4 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnTaiKhoan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnCaiDat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.buttonMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.head = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Title = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.panelanimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Menu.SuspendLayout()
        Me.PanelAccount.SuspendLayout()
        Me.Panelchangepass.SuspendLayout()
        CType(Me.user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnThayDoiSL.SuspendLayout()
        Me.lbXeMoi.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidemenu.SuspendLayout()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.head.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "list.png")
        '
        'logoanimator
        '
        Me.logoanimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.logoanimator.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(30)
        Animation1.RotateCoeff = 0.5!
        Animation1.RotateLimit = 0.2!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.logoanimator.DefaultAnimation = Animation1
        '
        'Menu
        '
        Me.panelanimator.SetDecoration(Me.Menu, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.Menu, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.Menu, "Menu")
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiếpNhậnToolStripMenuItem, Me.QuảnLíToolStripMenuItem, Me.SữaChữaToolStripMenuItem, Me.TraCứuToolStripMenuItem, Me.LậpPhiếuToolStripMenuItem, Me.BáoCáoToolStripMenuItem})
        Me.Menu.Name = "Menu"
        '
        'TiếpNhậnToolStripMenuItem
        '
        Me.TiếpNhậnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiếpNhậnXeToolStripMenuItem})
        resources.ApplyResources(Me.TiếpNhậnToolStripMenuItem, "TiếpNhậnToolStripMenuItem")
        Me.TiếpNhậnToolStripMenuItem.Name = "TiếpNhậnToolStripMenuItem"
        '
        'TiếpNhậnXeToolStripMenuItem
        '
        Me.TiếpNhậnXeToolStripMenuItem.Name = "TiếpNhậnXeToolStripMenuItem"
        resources.ApplyResources(Me.TiếpNhậnXeToolStripMenuItem, "TiếpNhậnXeToolStripMenuItem")
        '
        'QuảnLíToolStripMenuItem
        '
        Me.QuảnLíToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLíÔTôToolStripMenuItem, Me.QuảnLýPhụTùngToolStripMenuItem, Me.QuảnLýHiệuXeToolStripMenuItem, Me.QuảnLýTiềnCôngToolStripMenuItem, Me.QuảnLýPhiếuSữaChữaToolStripMenuItem})
        resources.ApplyResources(Me.QuảnLíToolStripMenuItem, "QuảnLíToolStripMenuItem")
        Me.QuảnLíToolStripMenuItem.Name = "QuảnLíToolStripMenuItem"
        '
        'QuảnLíÔTôToolStripMenuItem
        '
        resources.ApplyResources(Me.QuảnLíÔTôToolStripMenuItem, "QuảnLíÔTôToolStripMenuItem")
        Me.QuảnLíÔTôToolStripMenuItem.Name = "QuảnLíÔTôToolStripMenuItem"
        '
        'QuảnLýPhụTùngToolStripMenuItem
        '
        resources.ApplyResources(Me.QuảnLýPhụTùngToolStripMenuItem, "QuảnLýPhụTùngToolStripMenuItem")
        Me.QuảnLýPhụTùngToolStripMenuItem.Name = "QuảnLýPhụTùngToolStripMenuItem"
        '
        'QuảnLýHiệuXeToolStripMenuItem
        '
        resources.ApplyResources(Me.QuảnLýHiệuXeToolStripMenuItem, "QuảnLýHiệuXeToolStripMenuItem")
        Me.QuảnLýHiệuXeToolStripMenuItem.Name = "QuảnLýHiệuXeToolStripMenuItem"
        '
        'QuảnLýTiềnCôngToolStripMenuItem
        '
        Me.QuảnLýTiềnCôngToolStripMenuItem.Name = "QuảnLýTiềnCôngToolStripMenuItem"
        resources.ApplyResources(Me.QuảnLýTiềnCôngToolStripMenuItem, "QuảnLýTiềnCôngToolStripMenuItem")
        '
        'QuảnLýPhiếuSữaChữaToolStripMenuItem
        '
        Me.QuảnLýPhiếuSữaChữaToolStripMenuItem.Name = "QuảnLýPhiếuSữaChữaToolStripMenuItem"
        resources.ApplyResources(Me.QuảnLýPhiếuSữaChữaToolStripMenuItem, "QuảnLýPhiếuSữaChữaToolStripMenuItem")
        '
        'SữaChữaToolStripMenuItem
        '
        Me.SữaChữaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SữaChữaÔTôToolStripMenuItem})
        resources.ApplyResources(Me.SữaChữaToolStripMenuItem, "SữaChữaToolStripMenuItem")
        Me.SữaChữaToolStripMenuItem.Name = "SữaChữaToolStripMenuItem"
        '
        'SữaChữaÔTôToolStripMenuItem
        '
        resources.ApplyResources(Me.SữaChữaÔTôToolStripMenuItem, "SữaChữaÔTôToolStripMenuItem")
        Me.SữaChữaÔTôToolStripMenuItem.Name = "SữaChữaÔTôToolStripMenuItem"
        '
        'TraCứuToolStripMenuItem
        '
        Me.TraCứuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TraCứuXeToolStripMenuItem})
        resources.ApplyResources(Me.TraCứuToolStripMenuItem, "TraCứuToolStripMenuItem")
        Me.TraCứuToolStripMenuItem.Name = "TraCứuToolStripMenuItem"
        '
        'TraCứuXeToolStripMenuItem
        '
        Me.TraCứuXeToolStripMenuItem.Name = "TraCứuXeToolStripMenuItem"
        resources.ApplyResources(Me.TraCứuXeToolStripMenuItem, "TraCứuXeToolStripMenuItem")
        '
        'LậpPhiếuToolStripMenuItem
        '
        Me.LậpPhiếuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LậpPhiếuThuTiềnToolStripMenuItem, Me.LậpPhiếuSửaChữaToolStripMenuItem})
        resources.ApplyResources(Me.LậpPhiếuToolStripMenuItem, "LậpPhiếuToolStripMenuItem")
        Me.LậpPhiếuToolStripMenuItem.Name = "LậpPhiếuToolStripMenuItem"
        '
        'LậpPhiếuThuTiềnToolStripMenuItem
        '
        Me.LậpPhiếuThuTiềnToolStripMenuItem.Name = "LậpPhiếuThuTiềnToolStripMenuItem"
        resources.ApplyResources(Me.LậpPhiếuThuTiềnToolStripMenuItem, "LậpPhiếuThuTiềnToolStripMenuItem")
        '
        'LậpPhiếuSửaChữaToolStripMenuItem
        '
        Me.LậpPhiếuSửaChữaToolStripMenuItem.Name = "LậpPhiếuSửaChữaToolStripMenuItem"
        resources.ApplyResources(Me.LậpPhiếuSửaChữaToolStripMenuItem, "LậpPhiếuSửaChữaToolStripMenuItem")
        '
        'BáoCáoToolStripMenuItem
        '
        Me.BáoCáoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BáoCáoDanhThuToolStripMenuItem, Me.BáoCáoPhụTùngToolStripMenuItem})
        resources.ApplyResources(Me.BáoCáoToolStripMenuItem, "BáoCáoToolStripMenuItem")
        Me.BáoCáoToolStripMenuItem.Name = "BáoCáoToolStripMenuItem"
        '
        'BáoCáoDanhThuToolStripMenuItem
        '
        Me.BáoCáoDanhThuToolStripMenuItem.Name = "BáoCáoDanhThuToolStripMenuItem"
        resources.ApplyResources(Me.BáoCáoDanhThuToolStripMenuItem, "BáoCáoDanhThuToolStripMenuItem")
        '
        'BáoCáoPhụTùngToolStripMenuItem
        '
        Me.BáoCáoPhụTùngToolStripMenuItem.Name = "BáoCáoPhụTùngToolStripMenuItem"
        resources.ApplyResources(Me.BáoCáoPhụTùngToolStripMenuItem, "BáoCáoPhụTùngToolStripMenuItem")
        '
        'PanelAccount
        '
        Me.PanelAccount.BackColor = System.Drawing.Color.White
        Me.PanelAccount.BorderRadius = 5
        Me.PanelAccount.BottomSahddow = True
        Me.PanelAccount.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PanelAccount.Controls.Add(Me.Panelchangepass)
        Me.PanelAccount.Controls.Add(Me.btnChangePW)
        Me.PanelAccount.Controls.Add(Me.txtpassword)
        Me.PanelAccount.Controls.Add(Me.txtuser)
        Me.PanelAccount.Controls.Add(Me.Label2)
        Me.PanelAccount.Controls.Add(Me.Label1)
        Me.PanelAccount.Controls.Add(Me.btnLogout)
        Me.PanelAccount.Controls.Add(Me.user)
        Me.panelanimator.SetDecoration(Me.PanelAccount, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.PanelAccount, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.PanelAccount, "PanelAccount")
        Me.PanelAccount.LeftSahddow = False
        Me.PanelAccount.Name = "PanelAccount"
        Me.PanelAccount.RightSahddow = True
        Me.PanelAccount.ShadowDepth = 20
        '
        'Panelchangepass
        '
        Me.Panelchangepass.Controls.Add(Me.txtNewPass)
        Me.Panelchangepass.Controls.Add(Me.BunifuThinButton22)
        Me.Panelchangepass.Controls.Add(Me.Label3)
        Me.Panelchangepass.Controls.Add(Me.BunifuThinButton21)
        Me.panelanimator.SetDecoration(Me.Panelchangepass, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.Panelchangepass, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.Panelchangepass, "Panelchangepass")
        Me.Panelchangepass.Name = "Panelchangepass"
        '
        'txtNewPass
        '
        Me.txtNewPass.BackColor = System.Drawing.SystemColors.Control
        Me.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.panelanimator.SetDecoration(Me.txtNewPass, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.txtNewPass, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.txtNewPass, "txtNewPass")
        Me.txtNewPass.ForeColor = System.Drawing.Color.Transparent
        Me.txtNewPass.HintForeColor = System.Drawing.Color.Transparent
        Me.txtNewPass.HintText = ""
        Me.txtNewPass.isPassword = False
        Me.txtNewPass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtNewPass.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtNewPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtNewPass.LineThickness = 2
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.BunifuThinButton22, "BunifuThinButton22")
        Me.BunifuThinButton22.ButtonText = "Cancel"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.logoanimator.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Name = "Label3"
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.BunifuThinButton21, "BunifuThinButton21")
        Me.BunifuThinButton21.ButtonText = "OK"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChangePW
        '
        Me.btnChangePW.ActiveBorderThickness = 1
        Me.btnChangePW.ActiveCornerRadius = 20
        Me.btnChangePW.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnChangePW.ActiveForecolor = System.Drawing.SystemColors.Control
        Me.btnChangePW.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnChangePW.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnChangePW, "btnChangePW")
        Me.btnChangePW.ButtonText = "Change password"
        Me.btnChangePW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator.SetDecoration(Me.btnChangePW, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.btnChangePW, BunifuAnimatorNS.DecorationType.None)
        Me.btnChangePW.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnChangePW.IdleBorderThickness = 1
        Me.btnChangePW.IdleCornerRadius = 20
        Me.btnChangePW.IdleFillColor = System.Drawing.SystemColors.Control
        Me.btnChangePW.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnChangePW.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnChangePW.Name = "btnChangePW"
        Me.btnChangePW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.SystemColors.Control
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.panelanimator.SetDecoration(Me.txtpassword, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.txtpassword, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.txtpassword, "txtpassword")
        Me.txtpassword.ForeColor = System.Drawing.Color.Transparent
        Me.txtpassword.HintForeColor = System.Drawing.Color.Transparent
        Me.txtpassword.HintText = ""
        Me.txtpassword.isPassword = False
        Me.txtpassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtpassword.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtpassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtpassword.LineThickness = 2
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.SystemColors.Control
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.panelanimator.SetDecoration(Me.txtuser, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.txtuser, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.txtuser, "txtuser")
        Me.txtuser.ForeColor = System.Drawing.Color.Transparent
        Me.txtuser.HintForeColor = System.Drawing.Color.Transparent
        Me.txtuser.HintText = ""
        Me.txtuser.isPassword = False
        Me.txtuser.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtuser.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtuser.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtuser.LineThickness = 2
        Me.txtuser.Name = "txtuser"
        Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.logoanimator.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.logoanimator.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Name = "Label1"
        '
        'btnLogout
        '
        Me.btnLogout.ActiveBorderThickness = 1
        Me.btnLogout.ActiveCornerRadius = 20
        Me.btnLogout.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLogout.ActiveForecolor = System.Drawing.SystemColors.Control
        Me.btnLogout.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLogout.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnLogout, "btnLogout")
        Me.btnLogout.ButtonText = "Logout"
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator.SetDecoration(Me.btnLogout, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.btnLogout, BunifuAnimatorNS.DecorationType.None)
        Me.btnLogout.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnLogout.IdleBorderThickness = 1
        Me.btnLogout.IdleCornerRadius = 20
        Me.btnLogout.IdleFillColor = System.Drawing.SystemColors.Control
        Me.btnLogout.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLogout.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.panelanimator.SetDecoration(Me.user, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.user, BunifuAnimatorNS.DecorationType.None)
        Me.user.Image = Global.QLGR_GUI.My.Resources.Resources.user
        Me.user.ImageActive = Nothing
        resources.ApplyResources(Me.user, "user")
        Me.user.Name = "user"
        Me.user.TabStop = False
        Me.user.Zoom = 10
        '
        'pnThayDoiSL
        '
        Me.pnThayDoiSL.Controls.Add(Me.Label7)
        Me.pnThayDoiSL.Controls.Add(Me.lbXeMoi)
        Me.pnThayDoiSL.Controls.Add(Me.Panel2)
        Me.panelanimator.SetDecoration(Me.pnThayDoiSL, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.pnThayDoiSL, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.pnThayDoiSL, "pnThayDoiSL")
        Me.pnThayDoiSL.Name = "pnThayDoiSL"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.logoanimator.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Name = "Label7"
        '
        'lbXeMoi
        '
        Me.lbXeMoi.Controls.Add(Me.Label5)
        Me.lbXeMoi.Controls.Add(Me.txtSoXeTNM)
        Me.lbXeMoi.Controls.Add(Me.btnOK)
        Me.panelanimator.SetDecoration(Me.lbXeMoi, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.lbXeMoi, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.lbXeMoi, "lbXeMoi")
        Me.lbXeMoi.Name = "lbXeMoi"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.logoanimator.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Name = "Label5"
        '
        'txtSoXeTNM
        '
        Me.logoanimator.SetDecoration(Me.txtSoXeTNM, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.txtSoXeTNM, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.txtSoXeTNM, "txtSoXeTNM")
        Me.txtSoXeTNM.Name = "txtSoXeTNM"
        '
        'btnOK
        '
        Me.logoanimator.SetDecoration(Me.btnOK, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.btnOK, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.btnOK.Name = "btnOK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lbXetoida)
        Me.panelanimator.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.logoanimator.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Name = "Label4"
        '
        'lbXetoida
        '
        resources.ApplyResources(Me.lbXetoida, "lbXetoida")
        Me.lbXetoida.BackColor = System.Drawing.Color.White
        Me.logoanimator.SetDecoration(Me.lbXetoida, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.lbXetoida, BunifuAnimatorNS.DecorationType.None)
        Me.lbXetoida.Name = "lbXetoida"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnThayDoiSL)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.panelanimator.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'PictureBox1
        '
        Me.logoanimator.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.logoanimator.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Image = Global.QLGR_GUI.My.Resources.Resources.background
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'sidemenu
        '
        Me.sidemenu.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.sidemenu, "sidemenu")
        Me.sidemenu.Controls.Add(Me.BunifuImageButton5)
        Me.sidemenu.Controls.Add(Me.BunifuImageButton4)
        Me.sidemenu.Controls.Add(Me.btnHome)
        Me.sidemenu.Controls.Add(Me.logo)
        Me.sidemenu.Controls.Add(Me.BunifuGradientPanel4)
        Me.sidemenu.Controls.Add(Me.btnTaiKhoan)
        Me.sidemenu.Controls.Add(Me.BunifuGradientPanel3)
        Me.sidemenu.Controls.Add(Me.btnCaiDat)
        Me.sidemenu.Controls.Add(Me.PictureBox2)
        Me.sidemenu.Controls.Add(Me.buttonMenu)
        Me.panelanimator.SetDecoration(Me.sidemenu, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.sidemenu, BunifuAnimatorNS.DecorationType.None)
        Me.sidemenu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.sidemenu.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.sidemenu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sidemenu.GradientTopRight = System.Drawing.Color.Thistle
        Me.sidemenu.Name = "sidemenu"
        Me.sidemenu.Quality = 10
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.panelanimator.SetDecoration(Me.BunifuImageButton5, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.BunifuImageButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton5.Image = Global.QLGR_GUI.My.Resources.Resources.boy
        Me.BunifuImageButton5.ImageActive = Nothing
        resources.ApplyResources(Me.BunifuImageButton5, "BunifuImageButton5")
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 10
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.panelanimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton4.Image = Global.QLGR_GUI.My.Resources.Resources.settings_gears
        Me.BunifuImageButton4.ImageActive = Nothing
        resources.ApplyResources(Me.BunifuImageButton4, "BunifuImageButton4")
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.panelanimator.SetDecoration(Me.btnHome, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.btnHome, BunifuAnimatorNS.DecorationType.None)
        Me.btnHome.Image = Global.QLGR_GUI.My.Resources.Resources.home
        Me.btnHome.ImageActive = Nothing
        resources.ApplyResources(Me.btnHome, "btnHome")
        Me.btnHome.Name = "btnHome"
        Me.btnHome.TabStop = False
        Me.btnHome.Zoom = 10
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logoanimator.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.logo.Image = Global.QLGR_GUI.My.Resources.Resources.logo1
        resources.ApplyResources(Me.logo, "logo")
        Me.logo.Name = "logo"
        Me.logo.TabStop = False
        '
        'BunifuGradientPanel4
        '
        Me.BunifuGradientPanel4.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BunifuGradientPanel4, "BunifuGradientPanel4")
        Me.panelanimator.SetDecoration(Me.BunifuGradientPanel4, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.BunifuGradientPanel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel4.GradientBottomLeft = System.Drawing.SystemColors.Control
        Me.BunifuGradientPanel4.GradientBottomRight = System.Drawing.SystemColors.Control
        Me.BunifuGradientPanel4.GradientTopLeft = System.Drawing.SystemColors.Control
        Me.BunifuGradientPanel4.GradientTopRight = System.Drawing.SystemColors.Control
        Me.BunifuGradientPanel4.Name = "BunifuGradientPanel4"
        Me.BunifuGradientPanel4.Quality = 10
        '
        'btnTaiKhoan
        '
        Me.btnTaiKhoan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnTaiKhoan.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnTaiKhoan, "btnTaiKhoan")
        Me.btnTaiKhoan.BorderRadius = 0
        Me.btnTaiKhoan.ButtonText = "TÀI KHOẢN"
        Me.btnTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.btnTaiKhoan.DisabledColor = System.Drawing.Color.Gray
        Me.btnTaiKhoan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTaiKhoan.Iconimage = Nothing
        Me.btnTaiKhoan.Iconimage_right = Nothing
        Me.btnTaiKhoan.Iconimage_right_Selected = Nothing
        Me.btnTaiKhoan.Iconimage_Selected = Nothing
        Me.btnTaiKhoan.IconMarginLeft = 0
        Me.btnTaiKhoan.IconMarginRight = 0
        Me.btnTaiKhoan.IconRightVisible = True
        Me.btnTaiKhoan.IconRightZoom = 0R
        Me.btnTaiKhoan.IconVisible = True
        Me.btnTaiKhoan.IconZoom = 90.0R
        Me.btnTaiKhoan.IsTab = True
        Me.btnTaiKhoan.Name = "btnTaiKhoan"
        Me.btnTaiKhoan.Normalcolor = System.Drawing.Color.Transparent
        Me.btnTaiKhoan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnTaiKhoan.OnHoverTextColor = System.Drawing.Color.LavenderBlush
        Me.btnTaiKhoan.selected = False
        Me.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTaiKhoan.Textcolor = System.Drawing.SystemColors.Window
        Me.btnTaiKhoan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BunifuGradientPanel3, "BunifuGradientPanel3")
        Me.panelanimator.SetDecoration(Me.BunifuGradientPanel3, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.BunifuGradientPanel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.SystemColors.Control
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.SystemColors.Control
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.SystemColors.Control
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.SystemColors.Control
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        '
        'btnCaiDat
        '
        Me.btnCaiDat.Activecolor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCaiDat.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnCaiDat, "btnCaiDat")
        Me.btnCaiDat.BorderRadius = 0
        Me.btnCaiDat.ButtonText = "CÀI ĐẶT"
        Me.btnCaiDat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelanimator.SetDecoration(Me.btnCaiDat, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.btnCaiDat, BunifuAnimatorNS.DecorationType.None)
        Me.btnCaiDat.DisabledColor = System.Drawing.Color.Gray
        Me.btnCaiDat.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCaiDat.Iconimage = Nothing
        Me.btnCaiDat.Iconimage_right = Nothing
        Me.btnCaiDat.Iconimage_right_Selected = Nothing
        Me.btnCaiDat.Iconimage_Selected = Nothing
        Me.btnCaiDat.IconMarginLeft = 0
        Me.btnCaiDat.IconMarginRight = 0
        Me.btnCaiDat.IconRightVisible = True
        Me.btnCaiDat.IconRightZoom = 0R
        Me.btnCaiDat.IconVisible = True
        Me.btnCaiDat.IconZoom = 90.0R
        Me.btnCaiDat.IsTab = True
        Me.btnCaiDat.Name = "btnCaiDat"
        Me.btnCaiDat.Normalcolor = System.Drawing.Color.Transparent
        Me.btnCaiDat.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCaiDat.OnHoverTextColor = System.Drawing.Color.LavenderBlush
        Me.btnCaiDat.selected = False
        Me.btnCaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCaiDat.Textcolor = System.Drawing.SystemColors.Window
        Me.btnCaiDat.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.logoanimator.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.QLGR_GUI.My.Resources.Resources.logo1
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'buttonMenu
        '
        Me.buttonMenu.BackColor = System.Drawing.Color.Transparent
        Me.panelanimator.SetDecoration(Me.buttonMenu, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.buttonMenu, BunifuAnimatorNS.DecorationType.None)
        Me.buttonMenu.Image = Global.QLGR_GUI.My.Resources.Resources.list
        Me.buttonMenu.ImageActive = Nothing
        resources.ApplyResources(Me.buttonMenu, "buttonMenu")
        Me.buttonMenu.Name = "buttonMenu"
        Me.buttonMenu.TabStop = False
        Me.buttonMenu.Zoom = 10
        '
        'head
        '
        Me.head.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.head, "head")
        Me.head.Controls.Add(Me.BunifuImageButton2)
        Me.head.Controls.Add(Me.BunifuImageButton1)
        Me.head.Controls.Add(Me.BunifuImageButton3)
        Me.head.Controls.Add(Me.Title)
        Me.panelanimator.SetDecoration(Me.head, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.head, BunifuAnimatorNS.DecorationType.None)
        Me.head.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.head.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.head.GradientTopLeft = System.Drawing.Color.Gray
        Me.head.GradientTopRight = System.Drawing.Color.Thistle
        Me.head.Name = "head"
        Me.head.Quality = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.panelanimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = Global.QLGR_GUI.My.Resources.Resources.minus
        Me.BunifuImageButton2.ImageActive = Nothing
        resources.ApplyResources(Me.BunifuImageButton2, "BunifuImageButton2")
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.panelanimator.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = Global.QLGR_GUI.My.Resources.Resources.cancel__2_
        Me.BunifuImageButton1.ImageActive = Nothing
        resources.ApplyResources(Me.BunifuImageButton1, "BunifuImageButton1")
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.panelanimator.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.logoanimator.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton3.Image = Global.QLGR_GUI.My.Resources.Resources.car__2_
        Me.BunifuImageButton3.ImageActive = Nothing
        resources.ApplyResources(Me.BunifuImageButton3, "BunifuImageButton3")
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'Title
        '
        resources.ApplyResources(Me.Title, "Title")
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.logoanimator.SetDecoration(Me.Title, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me.Title, BunifuAnimatorNS.DecorationType.None)
        Me.Title.Name = "Title"
        '
        'panelanimator
        '
        Me.panelanimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.panelanimator.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.panelanimator.DefaultAnimation = Animation2
        '
        'frmMain
        '
        Me.AllowDrop = True
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CausesValidation = False
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelAccount)
        Me.Controls.Add(Me.sidemenu)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.Panel1)
        Me.logoanimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.panelanimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Menu
        Me.Name = "frmMain"
        Me.ShowInTaskbar = False
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.PanelAccount.ResumeLayout(False)
        Me.PanelAccount.PerformLayout()
        Me.Panelchangepass.ResumeLayout(False)
        Me.Panelchangepass.PerformLayout()
        CType(Me.user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnThayDoiSL.ResumeLayout(False)
        Me.pnThayDoiSL.PerformLayout()
        Me.lbXeMoi.ResumeLayout(False)
        Me.lbXeMoi.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidemenu.ResumeLayout(False)
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.head.ResumeLayout(False)
        Me.head.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents Title As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents head As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents panelanimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents logoanimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents sidemenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents buttonMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents logo As PictureBox
    Friend WithEvents BunifuGradientPanel4 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnTaiKhoan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnCaiDat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents TiếpNhậnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiếpNhậnXeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLíToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLíÔTôToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýPhụTùngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýHiệuXeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TraCứuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TraCứuXeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpPhiếuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpPhiếuThuTiềnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BáoCáoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BáoCáoDanhThuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BáoCáoPhụTùngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PanelAccount As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnChangePW As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtpassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtuser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents user As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtNewPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panelchangepass As Panel
    Friend WithEvents pnThayDoiSL As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lbXetoida As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents txtSoXeTNM As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbXeMoi As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents QuảnLýTiềnCôngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SữaChữaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SữaChữaÔTôToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýPhiếuSữaChữaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpPhiếuSửaChữaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnHome As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
End Class
