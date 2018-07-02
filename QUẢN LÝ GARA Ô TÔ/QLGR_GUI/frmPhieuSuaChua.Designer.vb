<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
Partial Class frmPhieuSuaChua
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
<<<<<<< HEAD
    <System.Diagnostics.DebuggerNonUserCode()>
=======
    <System.Diagnostics.DebuggerNonUserCode()> _
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
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
<<<<<<< HEAD
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPhieuSuaChua))
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.lThanhTien = New System.Windows.Forms.Label()
        Me.cbTienCong = New System.Windows.Forms.ComboBox()
        Me.lTienCong = New System.Windows.Forms.Label()
        Me.dgvPhuTungDuocChon = New System.Windows.Forms.DataGridView()
        Me.btnToFrom = New System.Windows.Forms.Button()
        Me.btnFromTo = New System.Windows.Forms.Button()
        Me.dgvPhuTung = New System.Windows.Forms.DataGridView()
        Me.lPhuTung = New System.Windows.Forms.Label()
        Me.txtNoiDung = New System.Windows.Forms.TextBox()
        Me.lNoiDung = New System.Windows.Forms.Label()
        Me.dtpNgaySuaChua = New System.Windows.Forms.DateTimePicker()
        Me.lNgaySuaChua = New System.Windows.Forms.Label()
        Me.cbBienSo = New System.Windows.Forms.ComboBox()
        Me.lBienSo = New System.Windows.Forms.Label()
        Me.txtMaPhieu = New System.Windows.Forms.TextBox()
        Me.lMaPhieu = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        CType(Me.dgvPhuTungDuocChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPhuTung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(568, 520)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(101, 43)
        Me.btnThem.TabIndex = 52
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(277, 548)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(191, 27)
        Me.txtThanhTien.TabIndex = 51
        '
        'lThanhTien
        '
        Me.lThanhTien.AutoSize = True
        Me.lThanhTien.BackColor = System.Drawing.Color.Transparent
        Me.lThanhTien.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lThanhTien.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lThanhTien.Location = New System.Drawing.Point(167, 551)
        Me.lThanhTien.Name = "lThanhTien"
        Me.lThanhTien.Size = New System.Drawing.Size(80, 16)
        Me.lThanhTien.TabIndex = 50
        Me.lThanhTien.Text = "Thành tiền:"
        '
        'cbTienCong
        '
        Me.cbTienCong.FormattingEnabled = True
        Me.cbTienCong.Location = New System.Drawing.Point(277, 508)
        Me.cbTienCong.Name = "cbTienCong"
        Me.cbTienCong.Size = New System.Drawing.Size(191, 24)
        Me.cbTienCong.TabIndex = 49
        '
        'lTienCong
        '
        Me.lTienCong.AutoSize = True
        Me.lTienCong.BackColor = System.Drawing.Color.Transparent
        Me.lTienCong.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTienCong.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lTienCong.Location = New System.Drawing.Point(167, 508)
        Me.lTienCong.Name = "lTienCong"
        Me.lTienCong.Size = New System.Drawing.Size(75, 16)
        Me.lTienCong.TabIndex = 48
        Me.lTienCong.Text = "Tiền công:"
        '
        'dgvPhuTungDuocChon
        '
        Me.dgvPhuTungDuocChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPhuTungDuocChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhuTungDuocChon.Location = New System.Drawing.Point(561, 171)
        Me.dgvPhuTungDuocChon.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPhuTungDuocChon.MultiSelect = False
        Me.dgvPhuTungDuocChon.Name = "dgvPhuTungDuocChon"
        Me.dgvPhuTungDuocChon.RowHeadersVisible = False
        Me.dgvPhuTungDuocChon.RowTemplate.Height = 24
        Me.dgvPhuTungDuocChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPhuTungDuocChon.Size = New System.Drawing.Size(352, 277)
        Me.dgvPhuTungDuocChon.TabIndex = 47
        '
        'btnToFrom
        '
        Me.btnToFrom.Location = New System.Drawing.Point(486, 280)
        Me.btnToFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.btnToFrom.Name = "btnToFrom"
        Me.btnToFrom.Size = New System.Drawing.Size(56, 28)
        Me.btnToFrom.TabIndex = 46
        Me.btnToFrom.Text = "<"
        Me.btnToFrom.UseVisualStyleBackColor = True
        '
        'btnFromTo
        '
        Me.btnFromTo.Location = New System.Drawing.Point(486, 230)
        Me.btnFromTo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFromTo.Name = "btnFromTo"
        Me.btnFromTo.Size = New System.Drawing.Size(56, 29)
        Me.btnFromTo.TabIndex = 45
        Me.btnFromTo.Text = ">"
        Me.btnFromTo.UseVisualStyleBackColor = True
        '
        'dgvPhuTung
        '
        Me.dgvPhuTung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhuTung.Location = New System.Drawing.Point(87, 171)
        Me.dgvPhuTung.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPhuTung.MultiSelect = False
        Me.dgvPhuTung.Name = "dgvPhuTung"
        Me.dgvPhuTung.ReadOnly = True
        Me.dgvPhuTung.RowHeadersVisible = False
        Me.dgvPhuTung.RowTemplate.Height = 24
        Me.dgvPhuTung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPhuTung.Size = New System.Drawing.Size(381, 277)
        Me.dgvPhuTung.TabIndex = 44
        '
        'lPhuTung
        '
        Me.lPhuTung.AutoSize = True
        Me.lPhuTung.BackColor = System.Drawing.Color.Transparent
        Me.lPhuTung.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPhuTung.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lPhuTung.Location = New System.Drawing.Point(84, 141)
        Me.lPhuTung.Name = "lPhuTung"
        Me.lPhuTung.Size = New System.Drawing.Size(71, 16)
        Me.lPhuTung.TabIndex = 43
        Me.lPhuTung.Text = "Phụ tùng: "
        '
        'txtNoiDung
        '
        Me.txtNoiDung.Location = New System.Drawing.Point(199, 98)
        Me.txtNoiDung.Multiline = True
        Me.txtNoiDung.Name = "txtNoiDung"
        Me.txtNoiDung.Size = New System.Drawing.Size(687, 44)
        Me.txtNoiDung.TabIndex = 42
        '
        'lNoiDung
        '
        Me.lNoiDung.AutoSize = True
        Me.lNoiDung.BackColor = System.Drawing.Color.Transparent
        Me.lNoiDung.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNoiDung.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lNoiDung.Location = New System.Drawing.Point(84, 102)
        Me.lNoiDung.Name = "lNoiDung"
        Me.lNoiDung.Size = New System.Drawing.Size(70, 16)
        Me.lNoiDung.TabIndex = 41
        Me.lNoiDung.Text = "Nội dung:"
        '
        'dtpNgaySuaChua
        '
        Me.dtpNgaySuaChua.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaySuaChua.Location = New System.Drawing.Point(199, 61)
        Me.dtpNgaySuaChua.Name = "dtpNgaySuaChua"
        Me.dtpNgaySuaChua.Size = New System.Drawing.Size(112, 27)
        Me.dtpNgaySuaChua.TabIndex = 40
        '
        'lNgaySuaChua
        '
        Me.lNgaySuaChua.AutoSize = True
        Me.lNgaySuaChua.BackColor = System.Drawing.Color.Transparent
        Me.lNgaySuaChua.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNgaySuaChua.Location = New System.Drawing.Point(84, 62)
        Me.lNgaySuaChua.Name = "lNgaySuaChua"
        Me.lNgaySuaChua.Size = New System.Drawing.Size(102, 16)
        Me.lNgaySuaChua.TabIndex = 39
        Me.lNgaySuaChua.Text = "Ngày sửa chữa:"
        '
        'cbBienSo
        '
        Me.cbBienSo.FormattingEnabled = True
        Me.cbBienSo.Location = New System.Drawing.Point(457, 19)
        Me.cbBienSo.Name = "cbBienSo"
        Me.cbBienSo.Size = New System.Drawing.Size(126, 24)
        Me.cbBienSo.TabIndex = 38
        '
        'lBienSo
        '
        Me.lBienSo.AutoSize = True
        Me.lBienSo.BackColor = System.Drawing.Color.Transparent
        Me.lBienSo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBienSo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lBienSo.Location = New System.Drawing.Point(379, 22)
        Me.lBienSo.Name = "lBienSo"
        Me.lBienSo.Size = New System.Drawing.Size(62, 16)
        Me.lBienSo.TabIndex = 37
        Me.lBienSo.Text = "Biển số: "
        '
        'txtMaPhieu
        '
        Me.txtMaPhieu.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaPhieu.Location = New System.Drawing.Point(204, 19)
        Me.txtMaPhieu.Name = "txtMaPhieu"
        Me.txtMaPhieu.ReadOnly = True
        Me.txtMaPhieu.Size = New System.Drawing.Size(112, 27)
        Me.txtMaPhieu.TabIndex = 36
        '
        'lMaPhieu
        '
        Me.lMaPhieu.AutoSize = True
        Me.lMaPhieu.BackColor = System.Drawing.Color.Transparent
        Me.lMaPhieu.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMaPhieu.Location = New System.Drawing.Point(84, 18)
        Me.lMaPhieu.Name = "lMaPhieu"
        Me.lMaPhieu.Size = New System.Drawing.Size(70, 16)
        Me.lMaPhieu.TabIndex = 35
        Me.lMaPhieu.Text = "Mã phiếu:"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.lMaPhieu)
        Me.BunifuGradientPanel1.Controls.Add(Me.lNgaySuaChua)
        Me.BunifuGradientPanel1.Controls.Add(Me.lThanhTien)
        Me.BunifuGradientPanel1.Controls.Add(Me.lNoiDung)
        Me.BunifuGradientPanel1.Controls.Add(Me.lPhuTung)
        Me.BunifuGradientPanel1.Controls.Add(Me.lTienCong)
        Me.BunifuGradientPanel1.Controls.Add(Me.lBienSo)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Thistle
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1049, 645)
        Me.BunifuGradientPanel1.TabIndex = 53
        '
        'frmPhieuSuaChua
=======
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PHIẾU SỬA CHỮA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã phiếu:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(501, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Biển số: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(187, 84)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 27)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(588, 85)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 27)
        Me.TextBox2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(163, 170)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(727, 309)
        Me.Panel1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(27, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nội dung:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(27, 134)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Phụ tùng: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(27, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Số lượng: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(384, 177)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Đơn giá:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(143, 17)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(579, 94)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(143, 176)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(145, 27)
        Me.TextBox4.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(293, 138)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Ngày sửa chữa:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(447, 138)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 27)
        Me.DateTimePicker1.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(143, 134)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(579, 24)
        Me.ComboBox1.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(468, 176)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(253, 27)
        Me.TextBox5.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(29, 234)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Tiền công:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(143, 228)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(253, 24)
        Me.ComboBox2.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(27, 281)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Thành tiền:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(143, 281)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(347, 27)
        Me.TextBox6.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(344, 545)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 53)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Thêm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(518, 545)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 53)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Đóng"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'fmrPhieuSuaChua
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 645)
<<<<<<< HEAD
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtThanhTien)
        Me.Controls.Add(Me.cbTienCong)
        Me.Controls.Add(Me.dgvPhuTungDuocChon)
        Me.Controls.Add(Me.btnToFrom)
        Me.Controls.Add(Me.btnFromTo)
        Me.Controls.Add(Me.dgvPhuTung)
        Me.Controls.Add(Me.txtNoiDung)
        Me.Controls.Add(Me.dtpNgaySuaChua)
        Me.Controls.Add(Me.cbBienSo)
        Me.Controls.Add(Me.txtMaPhieu)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPhieuSuaChua"
        Me.Text = "fmrPhieuSuaChua"
        CType(Me.dgvPhuTungDuocChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPhuTung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
=======
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "fmrPhieuSuaChua"
        Me.Text = "fmrPhieuSuaChua"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

<<<<<<< HEAD
    Friend WithEvents btnThem As Button
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents lThanhTien As Label
    Friend WithEvents cbTienCong As ComboBox
    Friend WithEvents lTienCong As Label
    Friend WithEvents dgvPhuTungDuocChon As DataGridView
    Friend WithEvents btnToFrom As Button
    Friend WithEvents btnFromTo As Button
    Friend WithEvents dgvPhuTung As DataGridView
    Friend WithEvents lPhuTung As Label
    Friend WithEvents txtNoiDung As TextBox
    Friend WithEvents lNoiDung As Label
    Friend WithEvents dtpNgaySuaChua As DateTimePicker
    Friend WithEvents lNgaySuaChua As Label
    Friend WithEvents cbBienSo As ComboBox
    Friend WithEvents lBienSo As Label
    Friend WithEvents txtMaPhieu As TextBox
    Friend WithEvents lMaPhieu As Label
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
=======
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
End Class
