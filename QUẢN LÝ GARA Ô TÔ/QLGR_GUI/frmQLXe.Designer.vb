<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLXe
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListXe = New System.Windows.Forms.DataGridView()
        Me.txtBienSo = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.Label()
        Me.cbHieuXeCapNhat = New System.Windows.Forms.ComboBox()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.dtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSoTienNo = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtTimKiem = New System.Windows.Forms.Label()
        Me.cbHieuXe = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnTatCa = New System.Windows.Forms.Button()
        CType(Me.dgvListXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(483, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ XE"
        '
        'dgvListXe
        '
        Me.dgvListXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListXe.Location = New System.Drawing.Point(13, 62)
        Me.dgvListXe.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListXe.Name = "dgvListXe"
        Me.dgvListXe.Size = New System.Drawing.Size(666, 476)
        Me.dgvListXe.TabIndex = 1
        '
        'txtBienSo
        '
        Me.txtBienSo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBienSo.Location = New System.Drawing.Point(832, 62)
        Me.txtBienSo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBienSo.Name = "txtBienSo"
        Me.txtBienSo.Size = New System.Drawing.Size(210, 27)
        Me.txtBienSo.TabIndex = 3
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(832, 248)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(210, 27)
        Me.txtHoTen.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(832, 296)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(210, 27)
        Me.TextBox4.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(475, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(685, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Biển số:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(685, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Hiệu xe:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(687, 251)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tên khách hàng:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.AutoSize = True
        Me.txtDiaChi.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(685, 298)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(54, 16)
        Me.txtDiaChi.TabIndex = 12
        Me.txtDiaChi.Text = "Địa chỉ:"
        '
        'cbHieuXeCapNhat
        '
        Me.cbHieuXeCapNhat.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHieuXeCapNhat.FormattingEnabled = True
        Me.cbHieuXeCapNhat.Location = New System.Drawing.Point(832, 110)
        Me.cbHieuXeCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.cbHieuXeCapNhat.Name = "cbHieuXeCapNhat"
        Me.cbHieuXeCapNhat.Size = New System.Drawing.Size(210, 24)
        Me.cbHieuXeCapNhat.TabIndex = 13
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(832, 344)
        Me.txtSoDienThoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.Size = New System.Drawing.Size(210, 27)
        Me.txtSoDienThoai.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(685, 350)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Số điện thoại:"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhat.Location = New System.Drawing.Point(820, 427)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(135, 53)
        Me.btnCapNhat.TabIndex = 16
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(894, 485)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(135, 53)
        Me.btnXoa.TabIndex = 17
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.Location = New System.Drawing.Point(751, 485)
        Me.btnDong.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(135, 53)
        Me.btnDong.TabIndex = 19
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'dtpNgayTiepNhan
        '
        Me.dtpNgayTiepNhan.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayTiepNhan.Location = New System.Drawing.Point(832, 155)
        Me.dtpNgayTiepNhan.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan"
        Me.dtpNgayTiepNhan.Size = New System.Drawing.Size(210, 24)
        Me.dtpNgayTiepNhan.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(685, 157)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Ngày tiếp nhận:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(685, 399)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Tiền  nợ:"
        '
        'txtSoTienNo
        '
        Me.txtSoTienNo.Location = New System.Drawing.Point(832, 392)
        Me.txtSoTienNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoTienNo.Name = "txtSoTienNo"
        Me.txtSoTienNo.Size = New System.Drawing.Size(210, 27)
        Me.txtSoTienNo.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(273, 25)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(210, 27)
        Me.TextBox1.TabIndex = 25
        '
        'txtTimKiem
        '
        Me.txtTimKiem.AutoSize = True
        Me.txtTimKiem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimKiem.Location = New System.Drawing.Point(342, 4)
        Me.txtTimKiem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(72, 16)
        Me.txtTimKiem.TabIndex = 26
        Me.txtTimKiem.Text = "Tìm  Kiếm"
        '
        'cbHieuXe
        '
        Me.cbHieuXe.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHieuXe.FormattingEnabled = True
        Me.cbHieuXe.Location = New System.Drawing.Point(13, 25)
        Me.cbHieuXe.Margin = New System.Windows.Forms.Padding(4)
        Me.cbHieuXe.Name = "cbHieuXe"
        Me.cbHieuXe.Size = New System.Drawing.Size(171, 24)
        Me.cbHieuXe.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(92, 4)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Hiệu xe:"
        '
        'txtMaKH
        '
        Me.txtMaKH.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaKH.Location = New System.Drawing.Point(832, 200)
        Me.txtMaKH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(210, 27)
        Me.txtMaKH.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(687, 203)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Mã khách hàng:"
        '
        'btnTatCa
        '
        Me.btnTatCa.Location = New System.Drawing.Point(191, 27)
        Me.btnTatCa.Name = "btnTatCa"
        Me.btnTatCa.Size = New System.Drawing.Size(75, 23)
        Me.btnTatCa.TabIndex = 31
        Me.btnTatCa.Text = "Reset"
        Me.btnTatCa.UseVisualStyleBackColor = True
        '
        'frmQLXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 561)
        Me.Controls.Add(Me.btnTatCa)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbHieuXe)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtSoTienNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpNgayTiepNhan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSoDienThoai)
        Me.Controls.Add(Me.cbHieuXeCapNhat)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtBienSo)
        Me.Controls.Add(Me.dgvListXe)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmQLXe"
        Me.Text = "fmrQLXe"
        CType(Me.dgvListXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListXe As DataGridView
    Friend WithEvents txtBienSo As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDiaChi As Label
    Friend WithEvents cbHieuXeCapNhat As ComboBox
    Friend WithEvents txtSoDienThoai As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnDong As Button
    Friend WithEvents dtpNgayTiepNhan As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSoTienNo As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtTimKiem As Label
    Friend WithEvents cbHieuXe As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnTatCa As Button
End Class
