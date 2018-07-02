<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLHieuXe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
<<<<<<< HEAD
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLHieuXe))
=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvHieuXe = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaLoaiHieuXe = New System.Windows.Forms.TextBox()
        Me.txtTenLoaiHieuXe = New System.Windows.Forms.TextBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
<<<<<<< HEAD
        Me.btnThem = New System.Windows.Forms.Button()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        CType(Me.dgvHieuXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
=======
        CType(Me.dgvHieuXe, System.ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
<<<<<<< HEAD
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 9)
=======
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 9)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ HIỆU XE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
<<<<<<< HEAD
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 59)
=======
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 59)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Danh sách hiệu xe:"
        '
        'dgvHieuXe
        '
<<<<<<< HEAD
        Me.dgvHieuXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHieuXe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvHieuXe.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgvHieuXe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHieuXe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHieuXe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHieuXe.ColumnHeadersHeight = 50
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumOrchid
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHieuXe.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHieuXe.Location = New System.Drawing.Point(28, 80)
        Me.dgvHieuXe.Name = "dgvHieuXe"
        Me.dgvHieuXe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Violet
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHieuXe.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHieuXe.RowHeadersWidth = 50
        Me.dgvHieuXe.Size = New System.Drawing.Size(364, 418)
        Me.dgvHieuXe.TabIndex = 16
=======
        Me.dgvHieuXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHieuXe.Location = New System.Drawing.Point(28, 80)
        Me.dgvHieuXe.Name = "dgvHieuXe"
        Me.dgvHieuXe.Size = New System.Drawing.Size(456, 417)
        Me.dgvHieuXe.TabIndex = 2
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        '
        'Label3
        '
        Me.Label3.AutoSize = True
<<<<<<< HEAD
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(524, 99)
=======
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(508, 104)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mã loại: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
<<<<<<< HEAD
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(524, 157)
=======
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(508, 154)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tên loại: "
        '
        'txtMaLoaiHieuXe
        '
        Me.txtMaLoaiHieuXe.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaLoaiHieuXe.Location = New System.Drawing.Point(597, 104)
        Me.txtMaLoaiHieuXe.Name = "txtMaLoaiHieuXe"
        Me.txtMaLoaiHieuXe.Size = New System.Drawing.Size(210, 27)
        Me.txtMaLoaiHieuXe.TabIndex = 5
        '
        'txtTenLoaiHieuXe
        '
        Me.txtTenLoaiHieuXe.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenLoaiHieuXe.Location = New System.Drawing.Point(597, 154)
        Me.txtTenLoaiHieuXe.Name = "txtTenLoaiHieuXe"
        Me.txtTenLoaiHieuXe.Size = New System.Drawing.Size(210, 27)
        Me.txtTenLoaiHieuXe.TabIndex = 6
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.btnXoa.Location = New System.Drawing.Point(610, 289)
=======
        Me.btnXoa.Location = New System.Drawing.Point(629, 289)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(101, 43)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.btnCapNhat.Location = New System.Drawing.Point(465, 289)
=======
        Me.btnCapNhat.Location = New System.Drawing.Point(511, 289)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(101, 43)
        Me.btnCapNhat.TabIndex = 9
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.btnDong.Location = New System.Drawing.Point(610, 362)
=======
        Me.btnDong.Location = New System.Drawing.Point(747, 289)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(101, 43)
        Me.btnDong.TabIndex = 10
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
<<<<<<< HEAD
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(749, 289)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(101, 43)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label2)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label3)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label4)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Thistle
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(884, 561)
        Me.BunifuGradientPanel1.TabIndex = 18
        '
=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        'frmQLHieuXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
<<<<<<< HEAD
        Me.Controls.Add(Me.btnThem)
=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.txtTenLoaiHieuXe)
        Me.Controls.Add(Me.txtMaLoaiHieuXe)
<<<<<<< HEAD
        Me.Controls.Add(Me.dgvHieuXe)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Name = "frmQLHieuXe"
        Me.Text = "fmrQLHieuXe"
        CType(Me.dgvHieuXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
=======
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvHieuXe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLHieuXe"
        Me.Text = "fmrQLHieuXe"
        CType(Me.dgvHieuXe, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvHieuXe As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaLoaiHieuXe As TextBox
    Friend WithEvents txtTenLoaiHieuXe As TextBox
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnDong As Button
<<<<<<< HEAD
    Friend WithEvents btnThem As Button
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
End Class
