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
        Me.dtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.Label()
        Me.txrHoTen = New System.Windows.Forms.Label()
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
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 35)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "TIẾP NHẬN XE"
        '
        'dgvListXe
        '
        Me.dgvListXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListXe.Location = New System.Drawing.Point(12, 47)
        Me.dgvListXe.Name = "dgvListXe"
        Me.dgvListXe.Size = New System.Drawing.Size(677, 436)
        Me.dgvListXe.TabIndex = 6
        '
        'frmThemXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 561)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnDong As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSoTienNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvListXe As DataGridView
End Class
