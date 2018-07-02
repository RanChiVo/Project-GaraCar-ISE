<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemTienCong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemTienCong))
        Me.btnThemVaDong = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtMucTien = New System.Windows.Forms.TextBox()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.lMucTien = New System.Windows.Forms.Label()
        Me.lTenLoai = New System.Windows.Forms.Label()
        Me.lMaLoai = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnThemVaDong
        '
        Me.btnThemVaDong.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemVaDong.Location = New System.Drawing.Point(241, 209)
        Me.btnThemVaDong.Margin = New System.Windows.Forms.Padding(2)
        Me.btnThemVaDong.Name = "btnThemVaDong"
        Me.btnThemVaDong.Size = New System.Drawing.Size(97, 44)
        Me.btnThemVaDong.TabIndex = 24
        Me.btnThemVaDong.Text = "Thêm Và Đóng"
        Me.btnThemVaDong.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(111, 206)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(98, 47)
        Me.btnThem.TabIndex = 23
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtMucTien
        '
        Me.txtMucTien.Location = New System.Drawing.Point(164, 157)
        Me.txtMucTien.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMucTien.Name = "txtMucTien"
        Me.txtMucTien.Size = New System.Drawing.Size(145, 20)
        Me.txtMucTien.TabIndex = 22
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(164, 113)
        Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(145, 20)
        Me.txtTenLoai.TabIndex = 21
        '
        'txtMaLoai
        '
        Me.txtMaLoai.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaLoai.Location = New System.Drawing.Point(164, 70)
        Me.txtMaLoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(145, 20)
        Me.txtMaLoai.TabIndex = 20
        Me.txtMaLoai.WordWrap = False
        '
        'lMucTien
        '
        Me.lMucTien.AutoSize = True
        Me.lMucTien.BackColor = System.Drawing.Color.Transparent
        Me.lMucTien.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMucTien.Location = New System.Drawing.Point(86, 157)
        Me.lMucTien.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lMucTien.Name = "lMucTien"
        Me.lMucTien.Size = New System.Drawing.Size(69, 16)
        Me.lMucTien.TabIndex = 19
        Me.lMucTien.Text = "Mức Tiền:"
        '
        'lTenLoai
        '
        Me.lTenLoai.AutoSize = True
        Me.lTenLoai.BackColor = System.Drawing.Color.Transparent
        Me.lTenLoai.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTenLoai.Location = New System.Drawing.Point(86, 114)
        Me.lTenLoai.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lTenLoai.Name = "lTenLoai"
        Me.lTenLoai.Size = New System.Drawing.Size(66, 16)
        Me.lTenLoai.TabIndex = 18
        Me.lTenLoai.Text = "Tên Loại:"
        '
        'lMaLoai
        '
        Me.lMaLoai.AutoSize = True
        Me.lMaLoai.BackColor = System.Drawing.Color.Transparent
        Me.lMaLoai.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMaLoai.Location = New System.Drawing.Point(86, 70)
        Me.lMaLoai.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lMaLoai.Name = "lMaLoai"
        Me.lMaLoai.Size = New System.Drawing.Size(61, 16)
        Me.lMaLoai.TabIndex = 17
        Me.lMaLoai.Text = "Mã Loại:"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.lMaLoai)
        Me.BunifuGradientPanel1.Controls.Add(Me.lTenLoai)
        Me.BunifuGradientPanel1.Controls.Add(Me.lMucTien)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(427, 302)
        Me.BunifuGradientPanel1.TabIndex = 25
        '
        'frmThemTienCong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 302)
        Me.Controls.Add(Me.btnThemVaDong)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtMucTien)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmThemTienCong"
        Me.Text = "frmThemTienCong"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnThemVaDong As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents txtMucTien As TextBox
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents lMucTien As Label
    Friend WithEvents lTenLoai As Label
    Friend WithEvents lMaLoai As Label
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
