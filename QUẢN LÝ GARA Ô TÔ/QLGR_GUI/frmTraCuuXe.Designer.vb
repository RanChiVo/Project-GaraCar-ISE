<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrTraCuuXe
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDanhSachXe = New System.Windows.Forms.DataGridView()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtTienNo = New System.Windows.Forms.TextBox()
        Me.txtBienSo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbMaLoaiHieuXe = New System.Windows.Forms.ComboBox()
        CType(Me.dgvDanhSachXe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRA CỨU XE"
        '
        'dgvDanhSachXe
        '
        Me.dgvDanhSachXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachXe.Location = New System.Drawing.Point(12, 68)
        Me.dgvDanhSachXe.Name = "dgvDanhSachXe"
        Me.dgvDanhSachXe.Size = New System.Drawing.Size(720, 481)
        Me.dgvDanhSachXe.TabIndex = 1
        '
        'txtHoTen
        '
        Me.txtHoTen.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoTen.Location = New System.Drawing.Point(822, 266)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(210, 24)
        Me.txtHoTen.TabIndex = 2
        '
        'txtTienNo
        '
        Me.txtTienNo.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTienNo.Location = New System.Drawing.Point(822, 325)
        Me.txtTienNo.Name = "txtTienNo"
        Me.txtTienNo.Size = New System.Drawing.Size(210, 24)
        Me.txtTienNo.TabIndex = 4
        '
        'txtBienSo
        '
        Me.txtBienSo.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBienSo.Location = New System.Drawing.Point(822, 148)
        Me.txtBienSo.Name = "txtBienSo"
        Me.txtBienSo.Size = New System.Drawing.Size(210, 24)
        Me.txtBienSo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(757, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Họ Tên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(757, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tiền nợ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(754, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Biển Số:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(757, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Hiệu Xe:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(789, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 43)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Tìm Kiếm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(907, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 43)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Đóng"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbMaLoaiHieuXe
        '
        Me.cbMaLoaiHieuXe.FormattingEnabled = True
        Me.cbMaLoaiHieuXe.Location = New System.Drawing.Point(824, 204)
        Me.cbMaLoaiHieuXe.Name = "cbMaLoaiHieuXe"
        Me.cbMaLoaiHieuXe.Size = New System.Drawing.Size(208, 21)
        Me.cbMaLoaiHieuXe.TabIndex = 12
        '
        'fmrTraCuuXe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 561)
        Me.Controls.Add(Me.cbMaLoaiHieuXe)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBienSo)
        Me.Controls.Add(Me.txtTienNo)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.dgvDanhSachXe)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fmrTraCuuXe"
        Me.Text = "fmrTraCuuHocSinh"
        CType(Me.dgvDanhSachXe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDanhSachXe As DataGridView
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtTienNo As TextBox
    Friend WithEvents txtBienSo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cbMaLoaiHieuXe As ComboBox
End Class
