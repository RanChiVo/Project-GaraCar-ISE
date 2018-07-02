<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dp))
        Me.txtNam = New System.Windows.Forms.TextBox()
        Me.txtThang = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbThang = New System.Windows.Forms.ComboBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CRYSTALBAOCAODOANHTHUTHANG2 = New QLGR_GUI.CRYSTALBAOCAODOANHTHUTHANG()
        Me.btnLoad = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.crystalbaocaodoanhthuthang1 = New QLGR_GUI.CRYSTALBAOCAODOANHTHUTHANG()
        Me.QlgrDataSet1 = New QLGR_GUI.QLGRDataSet()
        Me.BaocaodoanhthuTableAdapter1 = New QLGR_GUI.QLGRDataSetTableAdapters.BAOCAODOANHTHUTableAdapter()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        CType(Me.QlgrDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNam
        '
        Me.txtNam.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNam.Location = New System.Drawing.Point(526, 2)
        Me.txtNam.Multiline = True
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(49, 23)
        Me.txtNam.TabIndex = 8
        '
        'txtThang
        '
        Me.txtThang.AutoSize = True
        Me.txtThang.BackColor = System.Drawing.Color.Transparent
        Me.txtThang.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThang.Location = New System.Drawing.Point(331, 10)
        Me.txtThang.Name = "txtThang"
        Me.txtThang.Size = New System.Drawing.Size(47, 16)
        Me.txtThang.TabIndex = 9
        Me.txtThang.Text = "Tháng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(483, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Năm"
        '
        'cbThang
        '
        Me.cbThang.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbThang.FormattingEnabled = True
        Me.cbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbThang.Location = New System.Drawing.Point(396, 2)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(45, 24)
        Me.cbThang.TabIndex = 11
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(-2, 86)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CRYSTALBAOCAODOANHTHUTHANG2
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(894, 392)
        Me.CrystalReportViewer1.TabIndex = 5
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnLoad
        '
        Me.btnLoad.ActiveBorderThickness = 1
        Me.btnLoad.ActiveCornerRadius = 20
        Me.btnLoad.ActiveFillColor = System.Drawing.Color.SeaShell
        Me.btnLoad.ActiveForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnLoad.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLoad.BackColor = System.Drawing.Color.Transparent
        Me.btnLoad.BackgroundImage = CType(resources.GetObject("btnLoad.BackgroundImage"), System.Drawing.Image)
        Me.btnLoad.ButtonText = "Thống Kê"
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnLoad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLoad.IdleBorderThickness = 1
        Me.btnLoad.IdleCornerRadius = 20
        Me.btnLoad.IdleFillColor = System.Drawing.Color.White
        Me.btnLoad.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLoad.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnLoad.Location = New System.Drawing.Point(632, 0)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(103, 41)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QlgrDataSet1
        '
        Me.QlgrDataSet1.DataSetName = "QLGRDataSet"
        Me.QlgrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BaocaodoanhthuTableAdapter1
        '
        Me.BaocaodoanhthuTableAdapter1.ClearBeforeFill = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.txtThang)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label2)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnLoad)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Thistle
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(884, 561)
        Me.BunifuGradientPanel1.TabIndex = 12
        '
        'dp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.cbThang)
        Me.Controls.Add(Me.txtNam)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "dp"
        Me.Text = "z"
        CType(Me.QlgrDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoad As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtNam As TextBox
    Friend WithEvents txtThang As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbThang As ComboBox
    Friend WithEvents QlgrDataSet1 As QLGRDataSet
    Friend WithEvents BaocaodoanhthuTableAdapter1 As QLGRDataSetTableAdapters.BAOCAODOANHTHUTableAdapter
    Friend WithEvents crystalbaocaodoanhthuthang1 As CRYSTALBAOCAODOANHTHUTHANG
    Friend WithEvents CRYSTALBAOCAODOANHTHUTHANG2 As CRYSTALBAOCAODOANHTHUTHANG
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
