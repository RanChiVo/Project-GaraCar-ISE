<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLVatTuPhuTung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLVatTuPhuTung))
        Me.lNgayNhap = New System.Windows.Forms.Label()
        Me.dtpNgayNhap = New System.Windows.Forms.DateTimePicker()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtTenLoaiPhuTung = New System.Windows.Forms.TextBox()
        Me.txtMaLoaiPhuTung = New System.Windows.Forms.TextBox()
        Me.lDonGia = New System.Windows.Forms.Label()
        Me.lSoLuong = New System.Windows.Forms.Label()
        Me.lTenPhuTung = New System.Windows.Forms.Label()
        Me.dgvDanhSachPhuTung = New System.Windows.Forms.DataGridView()
        Me.lMaPhuTung = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        CType(Me.dgvDanhSachPhuTung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lNgayNhap
        '
        Me.lNgayNhap.AutoSize = True
        Me.lNgayNhap.BackColor = System.Drawing.Color.Transparent
        Me.lNgayNhap.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNgayNhap.Location = New System.Drawing.Point(576, 270)
        Me.lNgayNhap.Name = "lNgayNhap"
        Me.lNgayNhap.Size = New System.Drawing.Size(80, 16)
        Me.lNgayNhap.TabIndex = 29
        Me.lNgayNhap.Text = "Ngày nhập:"
        '
        'dtpNgayNhap
        '
        Me.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayNhap.Location = New System.Drawing.Point(721, 269)
        Me.dtpNgayNhap.Name = "dtpNgayNhap"
        Me.dtpNgayNhap.Size = New System.Drawing.Size(165, 20)
        Me.dtpNgayNhap.TabIndex = 28
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(760, 371)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(101, 43)
        Me.btnXoa.TabIndex = 27
        Me.btnXoa.Text = "XÓA"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhat.Location = New System.Drawing.Point(642, 371)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(101, 43)
        Me.btnCapNhat.TabIndex = 26
        Me.btnCapNhat.Text = "CẬP NHẬT"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(721, 189)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(166, 20)
        Me.txtDonGia.TabIndex = 25
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(721, 232)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(165, 20)
        Me.txtSoLuong.TabIndex = 24
        '
        'txtTenLoaiPhuTung
        '
        Me.txtTenLoaiPhuTung.Location = New System.Drawing.Point(721, 144)
        Me.txtTenLoaiPhuTung.Name = "txtTenLoaiPhuTung"
        Me.txtTenLoaiPhuTung.Size = New System.Drawing.Size(166, 20)
        Me.txtTenLoaiPhuTung.TabIndex = 23
        '
        'txtMaLoaiPhuTung
        '
        Me.txtMaLoaiPhuTung.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaLoaiPhuTung.Location = New System.Drawing.Point(721, 106)
        Me.txtMaLoaiPhuTung.Name = "txtMaLoaiPhuTung"
        Me.txtMaLoaiPhuTung.ReadOnly = True
        Me.txtMaLoaiPhuTung.Size = New System.Drawing.Size(166, 20)
        Me.txtMaLoaiPhuTung.TabIndex = 22
        '
        'lDonGia
        '
        Me.lDonGia.AutoSize = True
        Me.lDonGia.BackColor = System.Drawing.Color.Transparent
        Me.lDonGia.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDonGia.Location = New System.Drawing.Point(576, 188)
        Me.lDonGia.Name = "lDonGia"
        Me.lDonGia.Size = New System.Drawing.Size(61, 16)
        Me.lDonGia.TabIndex = 21
        Me.lDonGia.Text = "Đơn giá:"
        '
        'lSoLuong
        '
        Me.lSoLuong.AutoSize = True
        Me.lSoLuong.BackColor = System.Drawing.Color.Transparent
        Me.lSoLuong.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSoLuong.Location = New System.Drawing.Point(576, 229)
        Me.lSoLuong.Name = "lSoLuong"
        Me.lSoLuong.Size = New System.Drawing.Size(69, 16)
        Me.lSoLuong.TabIndex = 20
        Me.lSoLuong.Text = "Số lượng:"
        '
        'lTenPhuTung
        '
        Me.lTenPhuTung.AutoSize = True
        Me.lTenPhuTung.BackColor = System.Drawing.Color.Transparent
        Me.lTenPhuTung.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTenPhuTung.Location = New System.Drawing.Point(576, 147)
        Me.lTenPhuTung.Name = "lTenPhuTung"
        Me.lTenPhuTung.Size = New System.Drawing.Size(123, 16)
        Me.lTenPhuTung.TabIndex = 19
        Me.lTenPhuTung.Text = "Tên loại phụ tùng:"
        '
        'dgvDanhSachPhuTung
        '
        Me.dgvDanhSachPhuTung.AllowUserToAddRows = False
        Me.dgvDanhSachPhuTung.AllowUserToDeleteRows = False
        Me.dgvDanhSachPhuTung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachPhuTung.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachPhuTung.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgvDanhSachPhuTung.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDanhSachPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhuTung.Location = New System.Drawing.Point(27, 72)
        Me.dgvDanhSachPhuTung.MultiSelect = False
        Me.dgvDanhSachPhuTung.Name = "dgvDanhSachPhuTung"
        Me.dgvDanhSachPhuTung.ReadOnly = True
        Me.dgvDanhSachPhuTung.RowHeadersVisible = False
        Me.dgvDanhSachPhuTung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachPhuTung.Size = New System.Drawing.Size(449, 416)
        Me.dgvDanhSachPhuTung.TabIndex = 18
        '
        'lMaPhuTung
        '
        Me.lMaPhuTung.AutoSize = True
        Me.lMaPhuTung.BackColor = System.Drawing.Color.Transparent
        Me.lMaPhuTung.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMaPhuTung.Location = New System.Drawing.Point(576, 106)
        Me.lMaPhuTung.Name = "lMaPhuTung"
        Me.lMaPhuTung.Size = New System.Drawing.Size(118, 16)
        Me.lMaPhuTung.TabIndex = 17
        Me.lMaPhuTung.Text = "Mã loại phụ tùng:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 35)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "QUẢN LÝ VẬT TƯ PHỤ TÙNG"
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(524, 371)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(101, 43)
        Me.btnThem.TabIndex = 30
        Me.btnThem.Text = "THÊM"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Controls.Add(Me.lNgayNhap)
        Me.BunifuGradientPanel1.Controls.Add(Me.lMaPhuTung)
        Me.BunifuGradientPanel1.Controls.Add(Me.lTenPhuTung)
        Me.BunifuGradientPanel1.Controls.Add(Me.lSoLuong)
        Me.BunifuGradientPanel1.Controls.Add(Me.lDonGia)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Thistle
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(898, 555)
        Me.BunifuGradientPanel1.TabIndex = 31
        '
        'frmQLVatTuPhuTung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 555)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dtpNgayNhap)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtTenLoaiPhuTung)
        Me.Controls.Add(Me.txtMaLoaiPhuTung)
        Me.Controls.Add(Me.dgvDanhSachPhuTung)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Name = "frmQLVatTuPhuTung"
        Me.Text = "frmQLVatTuPhuTung"
        CType(Me.dgvDanhSachPhuTung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lNgayNhap As Label
    Friend WithEvents dtpNgayNhap As DateTimePicker
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtTenLoaiPhuTung As TextBox
    Friend WithEvents txtMaLoaiPhuTung As TextBox
    Friend WithEvents lDonGia As Label
    Friend WithEvents lSoLuong As Label
    Friend WithEvents lTenPhuTung As Label
    Friend WithEvents dgvDanhSachPhuTung As DataGridView
    Friend WithEvents lMaPhuTung As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
