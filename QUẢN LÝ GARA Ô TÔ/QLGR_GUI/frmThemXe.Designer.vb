<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThemXe
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
<<<<<<< HEAD
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemXe))
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbSoXeToiDa = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.bntDong = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTienNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSoDT = New System.Windows.Forms.TextBox()
        Me.txtDiaChiKhachHang = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvThemXe = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbLoaiHieuXe = New System.Windows.Forms.ComboBox()
        Me.dpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBienSoXe = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnThemXe = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtSoTienNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
=======
        Me.dtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.Label()
        Me.txrHoTen = New System.Windows.Forms.Label()
<<<<<<< HEAD
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.txtDiaChiKH = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvListXe = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbHieuXe = New System.Windows.Forms.ComboBox()
        Me.dtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBienSo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvThemXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvListXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuGradientPanel1)
        Me.BunifuGradientPanel2.Controls.Add(Me.btnDong)
        Me.BunifuGradientPanel2.Controls.Add(Me.Panel3)
        Me.BunifuGradientPanel2.Controls.Add(Me.dgvListXe)
        Me.BunifuGradientPanel2.Controls.Add(Me.Panel2)
        Me.BunifuGradientPanel2.Controls.Add(Me.btnThem)
        Me.BunifuGradientPanel2.Controls.Add(Me.Label8)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Thistle
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(1094, 561)
        Me.BunifuGradientPanel2.TabIndex = 7
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.lbSoXeToiDa)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label21)
        Me.BunifuGradientPanel1.Controls.Add(Me.bntDong)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.dgvThemXe)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnThemXe)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label20)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Thistle
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1094, 561)
        Me.BunifuGradientPanel1.TabIndex = 8
        '
        'lbSoXeToiDa
        '
        Me.lbSoXeToiDa.AutoSize = True
        Me.lbSoXeToiDa.BackColor = System.Drawing.Color.White
        Me.lbSoXeToiDa.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSoXeToiDa.Location = New System.Drawing.Point(439, 25)
        Me.lbSoXeToiDa.Name = "lbSoXeToiDa"
        Me.lbSoXeToiDa.Size = New System.Drawing.Size(0, 16)
        Me.lbSoXeToiDa.TabIndex = 18
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(278, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(141, 16)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Số xe  tiếp nhận tối đa:"
        '
        'bntDong
        '
        Me.bntDong.BackColor = System.Drawing.Color.Transparent
        Me.bntDong.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntDong.Location = New System.Drawing.Point(922, 472)
        Me.bntDong.Name = "bntDong"
        Me.bntDong.Size = New System.Drawing.Size(130, 48)
        Me.bntDong.TabIndex = 4
        Me.bntDong.Text = "Đóng"
        Me.bntDong.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txtTienNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtMaKhachHang)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtSoDT)
        Me.Panel1.Controls.Add(Me.txtDiaChiKhachHang)
        Me.Panel1.Controls.Add(Me.txtTenKH)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(695, 206)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 243)
        Me.Panel1.TabIndex = 2
        '
        'txtTienNo
        '
        Me.txtTienNo.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTienNo.Location = New System.Drawing.Point(161, 178)
        Me.txtTienNo.Name = "txtTienNo"
        Me.txtTienNo.Size = New System.Drawing.Size(210, 24)
        Me.txtTienNo.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Tiền nợ:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Mã khách hàng:"
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaKhachHang.Location = New System.Drawing.Point(161, 30)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.Size = New System.Drawing.Size(210, 24)
        Me.txtMaKhachHang.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(32, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Số điện thoại:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Địa chỉ:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 16)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Họ tên:"
        '
        'txtSoDT
        '
        Me.txtSoDT.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoDT.Location = New System.Drawing.Point(161, 141)
        Me.txtSoDT.Name = "txtSoDT"
        Me.txtSoDT.Size = New System.Drawing.Size(210, 24)
        Me.txtSoDT.TabIndex = 12
        '
        'txtDiaChiKhachHang
        '
        Me.txtDiaChiKhachHang.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChiKhachHang.Location = New System.Drawing.Point(161, 104)
        Me.txtDiaChiKhachHang.Name = "txtDiaChiKhachHang"
        Me.txtDiaChiKhachHang.Size = New System.Drawing.Size(210, 24)
        Me.txtDiaChiKhachHang.TabIndex = 11
        '
        'txtTenKH
        '
        Me.txtTenKH.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenKH.Location = New System.Drawing.Point(161, 67)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(210, 24)
        Me.txtTenKH.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.AliceBlue
        Me.Label15.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(119, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(146, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Thông tin khách hàng"
        '
        'dgvThemXe
        '
        Me.dgvThemXe.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvThemXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThemXe.Location = New System.Drawing.Point(12, 47)
        Me.dgvThemXe.Name = "dgvThemXe"
        Me.dgvThemXe.Size = New System.Drawing.Size(677, 436)
        Me.dgvThemXe.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.cbLoaiHieuXe)
        Me.Panel4.Controls.Add(Me.dpNgayTiepNhan)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.txtBienSoXe)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Location = New System.Drawing.Point(695, 47)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(376, 153)
        Me.Panel4.TabIndex = 1
        '
        'cbLoaiHieuXe
        '
        Me.cbLoaiHieuXe.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoaiHieuXe.FormattingEnabled = True
        Me.cbLoaiHieuXe.Location = New System.Drawing.Point(157, 69)
        Me.cbLoaiHieuXe.Name = "cbLoaiHieuXe"
        Me.cbLoaiHieuXe.Size = New System.Drawing.Size(210, 23)
        Me.cbLoaiHieuXe.TabIndex = 10
        '
        'dpNgayTiepNhan
        '
        Me.dpNgayTiepNhan.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpNgayTiepNhan.Location = New System.Drawing.Point(157, 111)
        Me.dpNgayTiepNhan.Name = "dpNgayTiepNhan"
        Me.dpNgayTiepNhan.Size = New System.Drawing.Size(210, 24)
        Me.dpNgayTiepNhan.TabIndex = 9
        Me.dpNgayTiepNhan.Value = New Date(2018, 6, 7, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(40, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 16)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Ngày tiếp nhận:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(40, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 16)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Hiệu xe:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(40, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 16)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Biển số:"
        '
        'txtBienSoXe
        '
        Me.txtBienSoXe.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBienSoXe.Location = New System.Drawing.Point(157, 31)
        Me.txtBienSoXe.Name = "txtBienSoXe"
        Me.txtBienSoXe.Size = New System.Drawing.Size(210, 24)
        Me.txtBienSoXe.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.AliceBlue
        Me.Label19.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(154, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Thông tin xe"
        '
        'btnThemXe
        '
        Me.btnThemXe.BackColor = System.Drawing.Color.Transparent
        Me.btnThemXe.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemXe.Location = New System.Drawing.Point(764, 472)
        Me.btnThemXe.Name = "btnThemXe"
        Me.btnThemXe.Size = New System.Drawing.Size(130, 48)
        Me.btnThemXe.TabIndex = 5
        Me.btnThemXe.Text = "Thêm"
        Me.btnThemXe.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(41, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(213, 35)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "TIẾP NHẬN XE"
        '
        'btnDong
        '
        Me.btnDong.BackColor = System.Drawing.Color.Transparent
        Me.btnDong.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.Location = New System.Drawing.Point(922, 472)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(130, 48)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtSoTienNo)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtMaKH)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtDiaChi)
        Me.Panel3.Controls.Add(Me.txrHoTen)
        Me.Panel3.Controls.Add(Me.txtSoDienThoai)
        Me.Panel3.Controls.Add(Me.txtDiaChiKH)
        Me.Panel3.Controls.Add(Me.txtHoTen)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(695, 206)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(376, 243)
        Me.Panel3.TabIndex = 2
        '
        'txtSoTienNo
        '
        Me.txtSoTienNo.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoTienNo.Location = New System.Drawing.Point(161, 178)
        Me.txtSoTienNo.Name = "txtSoTienNo"
        Me.txtSoTienNo.Size = New System.Drawing.Size(210, 24)
        Me.txtSoTienNo.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Tiền nợ:"
=======
        Me.cbHieuXe = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBienSo = New System.Windows.Forms.TextBox()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.txtDiaChiKH = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtSoTienNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvListXe = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvListXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpNgayTiepNhan
        '
        Me.dtpNgayTiepNhan.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayTiepNhan.Location = New System.Drawing.Point(157, 111)
        Me.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan"
        Me.dtpNgayTiepNhan.Size = New System.Drawing.Size(210, 24)
        Me.dtpNgayTiepNhan.TabIndex = 9
        Me.dtpNgayTiepNhan.Value = New Date(2018, 6, 7, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Ngày tiếp nhận:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hiệu xe:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Biển số:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.AliceBlue
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Thông tin xe"
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Mã khách hàng:"
        '
        'txtMaKH
        '
        Me.txtMaKH.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaKH.Location = New System.Drawing.Point(161, 30)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(210, 24)
        Me.txtMaKH.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Số điện thoại:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.AutoSize = True
        Me.txtDiaChi.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(32, 108)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(54, 16)
        Me.txtDiaChi.TabIndex = 13
        Me.txtDiaChi.Text = "Địa chỉ:"
        '
        'txrHoTen
        '
        Me.txrHoTen.AutoSize = True
        Me.txrHoTen.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txrHoTen.Location = New System.Drawing.Point(32, 69)
        Me.txrHoTen.Name = "txrHoTen"
        Me.txrHoTen.Size = New System.Drawing.Size(54, 16)
        Me.txrHoTen.TabIndex = 11
        Me.txrHoTen.Text = "Họ tên:"
        '
<<<<<<< HEAD
=======
        'cbHieuXe
        '
        Me.cbHieuXe.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHieuXe.FormattingEnabled = True
        Me.cbHieuXe.Location = New System.Drawing.Point(157, 69)
        Me.cbHieuXe.Name = "cbHieuXe"
        Me.cbHieuXe.Size = New System.Drawing.Size(210, 23)
        Me.cbHieuXe.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbHieuXe)
        Me.Panel2.Controls.Add(Me.dtpNgayTiepNhan)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtBienSo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(695, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 153)
        Me.Panel2.TabIndex = 1
        '
        'txtBienSo
        '
        Me.txtBienSo.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBienSo.Location = New System.Drawing.Point(157, 31)
        Me.txtBienSo.Name = "txtBienSo"
        Me.txtBienSo.Size = New System.Drawing.Size(210, 24)
        Me.txtBienSo.TabIndex = 3
        '
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoDienThoai.Location = New System.Drawing.Point(161, 141)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(210, 24)
        Me.txtSoDienThoai.TabIndex = 12
        '
        'txtDiaChiKH
        '
        Me.txtDiaChiKH.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChiKH.Location = New System.Drawing.Point(161, 104)
        Me.txtDiaChiKH.Name = "txtDiaChiKH"
        Me.txtDiaChiKH.Size = New System.Drawing.Size(210, 24)
        Me.txtDiaChiKH.TabIndex = 11
        '
<<<<<<< HEAD
        'txtHoTen
        '
        Me.txtHoTen.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoTen.Location = New System.Drawing.Point(161, 67)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(210, 24)
        Me.txtHoTen.TabIndex = 10
        '
=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.AliceBlue
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Thông tin khách hàng"
        '
<<<<<<< HEAD
        'dgvListXe
        '
        Me.dgvListXe.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvListXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListXe.Location = New System.Drawing.Point(12, 47)
        Me.dgvListXe.Name = "dgvListXe"
        Me.dgvListXe.Size = New System.Drawing.Size(677, 436)
        Me.dgvListXe.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.cbHieuXe)
        Me.Panel2.Controls.Add(Me.dtpNgayTiepNhan)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtBienSo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(695, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 153)
        Me.Panel2.TabIndex = 1
        '
        'cbHieuXe
        '
        Me.cbHieuXe.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHieuXe.FormattingEnabled = True
        Me.cbHieuXe.Location = New System.Drawing.Point(157, 69)
        Me.cbHieuXe.Name = "cbHieuXe"
        Me.cbHieuXe.Size = New System.Drawing.Size(210, 23)
        Me.cbHieuXe.TabIndex = 10
        '
        'dtpNgayTiepNhan
        '
        Me.dtpNgayTiepNhan.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayTiepNhan.Location = New System.Drawing.Point(157, 111)
        Me.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan"
        Me.dtpNgayTiepNhan.Size = New System.Drawing.Size(210, 24)
        Me.dtpNgayTiepNhan.TabIndex = 9
        Me.dtpNgayTiepNhan.Value = New Date(2018, 6, 7, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Ngày tiếp nhận:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hiệu xe:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Biển số:"
        '
        'txtBienSo
        '
        Me.txtBienSo.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBienSo.Location = New System.Drawing.Point(157, 31)
        Me.txtBienSo.Name = "txtBienSo"
        Me.txtBienSo.Size = New System.Drawing.Size(210, 24)
        Me.txtBienSo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.AliceBlue
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Thông tin xe"
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.Transparent
        Me.btnThem.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(764, 472)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(130, 48)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
=======
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, -31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TIẾP NHẬN XE"
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(774, 472)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(130, 48)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.Location = New System.Drawing.Point(941, 472)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(130, 48)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtSoTienNo)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtMaKH)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtDiaChi)
        Me.Panel3.Controls.Add(Me.txrHoTen)
        Me.Panel3.Controls.Add(Me.txtSoDienThoai)
        Me.Panel3.Controls.Add(Me.txtDiaChiKH)
        Me.Panel3.Controls.Add(Me.txtHoTen)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(695, 206)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(376, 243)
        Me.Panel3.TabIndex = 2
        '
        'txtSoTienNo
        '
        Me.txtSoTienNo.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoTienNo.Location = New System.Drawing.Point(161, 178)
        Me.txtSoTienNo.Name = "txtSoTienNo"
        Me.txtSoTienNo.Size = New System.Drawing.Size(210, 24)
        Me.txtSoTienNo.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Tiền nợ:"
        '
        'txtHoTen
        '
        Me.txtHoTen.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoTen.Location = New System.Drawing.Point(161, 67)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(210, 24)
        Me.txtHoTen.TabIndex = 10
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        '
        'Label8
        '
        Me.Label8.AutoSize = True
<<<<<<< HEAD
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 9)
=======
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 9)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 35)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "TIẾP NHẬN XE"
        '
<<<<<<< HEAD
=======
        'dgvListXe
        '
        Me.dgvListXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListXe.Location = New System.Drawing.Point(12, 47)
        Me.dgvListXe.Name = "dgvListXe"
        Me.dgvListXe.Size = New System.Drawing.Size(677, 436)
        Me.dgvListXe.TabIndex = 6
        '
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        'frmThemXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 561)
<<<<<<< HEAD
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmThemXe"
        Me.Text = "frmThemXe"
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvThemXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvListXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
=======
        Me.Controls.Add(Me.dgvListXe)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmThemXe"
        Me.Text = "frmThemXe"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvListXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d

    End Sub

    Friend WithEvents dtpNgayTiepNhan As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDiaChi As Label
    Friend WithEvents txrHoTen As Label
    Friend WithEvents cbHieuXe As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBienSo As TextBox
    Friend WithEvents txtSoDienThoai As TextBox
    Friend WithEvents txtDiaChiKH As TextBox
    Friend WithEvents Label3 As Label
<<<<<<< HEAD
=======
    Friend WithEvents Label1 As Label
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    Friend WithEvents btnThem As Button
    Friend WithEvents btnDong As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSoTienNo As TextBox
    Friend WithEvents Label10 As Label
<<<<<<< HEAD
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents dgvListXe As DataGridView
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbSoXeToiDa As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents bntDong As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtTienNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtMaKhachHang As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSoDT As TextBox
    Friend WithEvents txtDiaChiKhachHang As TextBox
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents dgvThemXe As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbLoaiHieuXe As ComboBox
    Friend WithEvents dpNgayTiepNhan As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBienSoXe As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnThemXe As Button
    Friend WithEvents Label20 As Label
=======
    Friend WithEvents dgvListXe As DataGridView
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
End Class
