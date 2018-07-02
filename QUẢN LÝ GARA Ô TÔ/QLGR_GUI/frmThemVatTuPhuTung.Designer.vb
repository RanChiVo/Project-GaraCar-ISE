<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemVatTuPhuTung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemVatTuPhuTung))
        Me.btnThemVaDong = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtTenLoaiPhuTung = New System.Windows.Forms.TextBox()
        Me.txtMaLoaiPhuTung = New System.Windows.Forms.TextBox()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lTenLoaiPhuTung = New System.Windows.Forms.Label()
        Me.lMaLoaiPhuTung = New System.Windows.Forms.Label()
        Me.lNgayNhap = New System.Windows.Forms.Label()
        Me.lDonGia = New System.Windows.Forms.Label()
        Me.lSoLuong = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThemVaDong
        '
        Me.btnThemVaDong.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemVaDong.Location = New System.Drawing.Point(234, 290)
        Me.btnThemVaDong.Margin = New System.Windows.Forms.Padding(2)
        Me.btnThemVaDong.Name = "btnThemVaDong"
        Me.btnThemVaDong.Size = New System.Drawing.Size(122, 23)
        Me.btnThemVaDong.TabIndex = 19
        Me.btnThemVaDong.Text = "THÊM VÀ ĐÓNG"
        Me.btnThemVaDong.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(112, 290)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 18
        Me.btnThem.Text = "THÊM"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(203, 215)
        Me.txtSoLuong.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(153, 20)
        Me.txtSoLuong.TabIndex = 17
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(203, 173)
        Me.txtDonGia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(153, 20)
        Me.txtDonGia.TabIndex = 16
        '
        'txtTenLoaiPhuTung
        '
        Me.txtTenLoaiPhuTung.Location = New System.Drawing.Point(203, 93)
        Me.txtTenLoaiPhuTung.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenLoaiPhuTung.Name = "txtTenLoaiPhuTung"
        Me.txtTenLoaiPhuTung.Size = New System.Drawing.Size(153, 20)
        Me.txtTenLoaiPhuTung.TabIndex = 15
        '
        'txtMaLoaiPhuTung
        '
        Me.txtMaLoaiPhuTung.Location = New System.Drawing.Point(203, 54)
        Me.txtMaLoaiPhuTung.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaLoaiPhuTung.Name = "txtMaLoaiPhuTung"
        Me.txtMaLoaiPhuTung.ReadOnly = True
        Me.txtMaLoaiPhuTung.Size = New System.Drawing.Size(153, 20)
        Me.txtMaLoaiPhuTung.TabIndex = 14
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayNhap.Location = New System.Drawing.Point(203, 137)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(153, 20)
        Me.dtpNgayNhap.TabIndex = 21
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnClose)
        Me.BunifuGradientPanel1.Controls.Add(Me.lTenLoaiPhuTung)
        Me.BunifuGradientPanel1.Controls.Add(Me.lMaLoaiPhuTung)
        Me.BunifuGradientPanel1.Controls.Add(Me.lNgayNhap)
        Me.BunifuGradientPanel1.Controls.Add(Me.lDonGia)
        Me.BunifuGradientPanel1.Controls.Add(Me.lSoLuong)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Thistle
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(430, 358)
        Me.BunifuGradientPanel1.TabIndex = 28
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Image = Global.QLGR_GUI.My.Resources.Resources.cancel__2_
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(389, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(15, 15)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 27
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'lTenLoaiPhuTung
        '
        Me.lTenLoaiPhuTung.AutoSize = True
        Me.lTenLoaiPhuTung.BackColor = System.Drawing.Color.Transparent
        Me.lTenLoaiPhuTung.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTenLoaiPhuTung.Location = New System.Drawing.Point(65, 54)
        Me.lTenLoaiPhuTung.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lTenLoaiPhuTung.Name = "lTenLoaiPhuTung"
        Me.lTenLoaiPhuTung.Size = New System.Drawing.Size(123, 16)
        Me.lTenLoaiPhuTung.TabIndex = 11
        Me.lTenLoaiPhuTung.Text = "Mã Loại Phụ Tùng:"
        '
        'lMaLoaiPhuTung
        '
        Me.lMaLoaiPhuTung.AutoSize = True
        Me.lMaLoaiPhuTung.BackColor = System.Drawing.Color.Transparent
        Me.lMaLoaiPhuTung.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMaLoaiPhuTung.Location = New System.Drawing.Point(65, 94)
        Me.lMaLoaiPhuTung.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lMaLoaiPhuTung.Name = "lMaLoaiPhuTung"
        Me.lMaLoaiPhuTung.Size = New System.Drawing.Size(128, 16)
        Me.lMaLoaiPhuTung.TabIndex = 10
        Me.lMaLoaiPhuTung.Text = "Tên Loại Phụ Tùng:"
        '
        'lNgayNhap
        '
        Me.lNgayNhap.AutoSize = True
        Me.lNgayNhap.BackColor = System.Drawing.Color.Transparent
        Me.lNgayNhap.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNgayNhap.Location = New System.Drawing.Point(65, 134)
        Me.lNgayNhap.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lNgayNhap.Name = "lNgayNhap"
        Me.lNgayNhap.Size = New System.Drawing.Size(82, 16)
        Me.lNgayNhap.TabIndex = 20
        Me.lNgayNhap.Text = "Ngày Nhập:"
        '
        'lDonGia
        '
        Me.lDonGia.AutoSize = True
        Me.lDonGia.BackColor = System.Drawing.Color.Transparent
        Me.lDonGia.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDonGia.Location = New System.Drawing.Point(65, 174)
        Me.lDonGia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lDonGia.Name = "lDonGia"
        Me.lDonGia.Size = New System.Drawing.Size(62, 16)
        Me.lDonGia.TabIndex = 12
        Me.lDonGia.Text = "Đơn Giá:"
        '
        'lSoLuong
        '
        Me.lSoLuong.AutoSize = True
        Me.lSoLuong.BackColor = System.Drawing.Color.Transparent
        Me.lSoLuong.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSoLuong.Location = New System.Drawing.Point(65, 214)
        Me.lSoLuong.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lSoLuong.Name = "lSoLuong"
        Me.lSoLuong.Size = New System.Drawing.Size(72, 16)
        Me.lSoLuong.TabIndex = 13
        Me.lSoLuong.Text = "Số Lượng:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 23)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "THÊM PHỤ TÙNG"
        '
        'frmThemVatTuPhuTung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 358)
        Me.Controls.Add(Me.dtpNgayNhap)
        Me.Controls.Add(Me.btnThemVaDong)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtTenLoaiPhuTung)
        Me.Controls.Add(Me.txtMaLoaiPhuTung)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmThemVatTuPhuTung"
        Me.Text = "frmThemVatTuPhuTung"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnThemVaDong As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtTenLoaiPhuTung As TextBox
    Friend WithEvents txtMaLoaiPhuTung As TextBox
    Friend WithEvents lSoLuong As Label
    Friend WithEvents lDonGia As Label
    Friend WithEvents lTenLoaiPhuTung As Label
    Friend WithEvents lMaLoaiPhuTung As Label
    Friend WithEvents dtpNgayNhap As DateTimePicker
    Friend WithEvents lNgayNhap As Label
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label1 As Label
End Class
