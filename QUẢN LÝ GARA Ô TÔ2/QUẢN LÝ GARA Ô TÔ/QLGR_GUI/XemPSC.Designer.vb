<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XemPSC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XemPSC))
        Me.dgvPhieuSuaChua = New System.Windows.Forms.DataGridView()
        Me.txtMaPhieuSuaChua = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnChonMaPhieu = New System.Windows.Forms.Button()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        CType(Me.dgvPhieuSuaChua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPhieuSuaChua
        '
        Me.dgvPhieuSuaChua.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvPhieuSuaChua.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPhieuSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhieuSuaChua.Location = New System.Drawing.Point(89, 85)
        Me.dgvPhieuSuaChua.Name = "dgvPhieuSuaChua"
        Me.dgvPhieuSuaChua.Size = New System.Drawing.Size(596, 353)
        Me.dgvPhieuSuaChua.TabIndex = 0
        '
        'txtMaPhieuSuaChua
        '
        Me.txtMaPhieuSuaChua.Location = New System.Drawing.Point(221, 48)
        Me.txtMaPhieuSuaChua.Name = "txtMaPhieuSuaChua"
        Me.txtMaPhieuSuaChua.Size = New System.Drawing.Size(150, 20)
        Me.txtMaPhieuSuaChua.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã Phiếu Sửa Chữa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Phiếu Sửa Chữa:"
        '
        'btnChonMaPhieu
        '
        Me.btnChonMaPhieu.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChonMaPhieu.Location = New System.Drawing.Point(393, 42)
        Me.btnChonMaPhieu.Name = "btnChonMaPhieu"
        Me.btnChonMaPhieu.Size = New System.Drawing.Size(73, 30)
        Me.btnChonMaPhieu.TabIndex = 4
        Me.btnChonMaPhieu.Text = "OK"
        Me.btnChonMaPhieu.UseVisualStyleBackColor = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.txtMaPhieuSuaChua)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnChonMaPhieu)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label2)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.WindowText
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Thistle
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(800, 454)
        Me.BunifuGradientPanel1.TabIndex = 5
        '
        'XemPSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 454)
        Me.Controls.Add(Me.dgvPhieuSuaChua)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Name = "XemPSC"
        Me.Text = "XemPSC"
        CType(Me.dgvPhieuSuaChua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPhieuSuaChua As DataGridView
    Friend WithEvents txtMaPhieuSuaChua As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnChonMaPhieu As Button
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
End Class
