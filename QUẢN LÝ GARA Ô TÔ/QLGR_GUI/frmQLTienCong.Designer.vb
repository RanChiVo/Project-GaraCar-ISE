﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLTienCong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQLTienCong))
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.txtMucTien = New System.Windows.Forms.TextBox()
        Me.lMucTien = New System.Windows.Forms.Label()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.lTenLoai = New System.Windows.Forms.Label()
        Me.lMaLoai = New System.Windows.Forms.Label()
        Me.dgvListTienCong = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        CType(Me.dgvListTienCong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(597, 109)
        Me.txtMaLoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(157, 20)
        Me.txtMaLoai.TabIndex = 24
        '
        'txtMucTien
        '
        Me.txtMucTien.Location = New System.Drawing.Point(597, 227)
        Me.txtMucTien.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMucTien.Name = "txtMucTien"
        Me.txtMucTien.Size = New System.Drawing.Size(157, 20)
        Me.txtMucTien.TabIndex = 23
        '
        'lMucTien
        '
        Me.lMucTien.AutoSize = True
        Me.lMucTien.BackColor = System.Drawing.Color.Transparent
        Me.lMucTien.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMucTien.Location = New System.Drawing.Point(507, 227)
        Me.lMucTien.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lMucTien.Name = "lMucTien"
        Me.lMucTien.Size = New System.Drawing.Size(69, 17)
        Me.lMucTien.TabIndex = 22
        Me.lMucTien.Text = "Mức tiền:"
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(574, 360)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(101, 43)
        Me.btnXoa.TabIndex = 21
        Me.btnXoa.Text = "XÓA"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhat.Location = New System.Drawing.Point(634, 295)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(101, 43)
        Me.btnCapNhat.TabIndex = 20
        Me.btnCapNhat.Text = "CẬP NHẬT"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(597, 167)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(157, 20)
        Me.txtTenLoai.TabIndex = 19
        '
        'lTenLoai
        '
        Me.lTenLoai.AutoSize = True
        Me.lTenLoai.BackColor = System.Drawing.Color.Transparent
        Me.lTenLoai.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTenLoai.Location = New System.Drawing.Point(505, 168)
        Me.lTenLoai.Name = "lTenLoai"
        Me.lTenLoai.Size = New System.Drawing.Size(71, 17)
        Me.lTenLoai.TabIndex = 18
        Me.lTenLoai.Text = "Tên loại: "
        '
        'lMaLoai
        '
        Me.lMaLoai.AutoSize = True
        Me.lMaLoai.BackColor = System.Drawing.Color.Transparent
        Me.lMaLoai.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMaLoai.Location = New System.Drawing.Point(505, 109)
        Me.lMaLoai.Name = "lMaLoai"
        Me.lMaLoai.Size = New System.Drawing.Size(61, 17)
        Me.lMaLoai.TabIndex = 17
        Me.lMaLoai.Text = "Mã loại:"
        '
        'dgvListTienCong
        '
        Me.dgvListTienCong.AllowUserToAddRows = False
        Me.dgvListTienCong.AllowUserToDeleteRows = False
        Me.dgvListTienCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListTienCong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListTienCong.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.dgvListTienCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListTienCong.Location = New System.Drawing.Point(12, 66)
        Me.dgvListTienCong.MultiSelect = False
        Me.dgvListTienCong.Name = "dgvListTienCong"
        Me.dgvListTienCong.ReadOnly = True
        Me.dgvListTienCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListTienCong.Size = New System.Drawing.Size(444, 455)
        Me.dgvListTienCong.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 35)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "QUẢN LÝ TIỀN CÔNG"
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(508, 295)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(101, 43)
        Me.btnThem.TabIndex = 25
        Me.btnThem.Text = "THÊM"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Controls.Add(Me.lMaLoai)
        Me.BunifuGradientPanel1.Controls.Add(Me.lTenLoai)
        Me.BunifuGradientPanel1.Controls.Add(Me.lMucTien)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Thistle
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(800, 567)
        Me.BunifuGradientPanel1.TabIndex = 26
        '
        'frmQLTienCong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 567)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.txtMucTien)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.dgvListTienCong)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Name = "frmQLTienCong"
        Me.Text = "frmQLTienCong"
        CType(Me.dgvListTienCong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
=======
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ TIỀN CÔNG"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(424, 455)
        Me.DataGridView1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(503, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã loại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(503, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên loại: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(595, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(595, 147)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(157, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(460, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "THÊM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(567, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 43)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "CẬP NHẬT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(674, 277)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 43)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "XÓA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(567, 356)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 43)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "ĐÓNG"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'fmrQLTienCong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(900, 597)
        Me.Name = "fmrQLTienCong"
        Me.Text = "fmrQLTienCong"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

<<<<<<< HEAD
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents txtMucTien As TextBox
    Friend WithEvents lMucTien As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents lTenLoai As Label
    Friend WithEvents lMaLoai As Label
    Friend WithEvents dgvListTienCong As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
=======
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
End Class
