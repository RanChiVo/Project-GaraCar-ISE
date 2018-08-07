<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhieuSuaChua
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
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 645)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
End Class
