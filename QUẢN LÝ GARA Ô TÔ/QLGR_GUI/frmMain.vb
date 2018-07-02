
Imports System.Data.SqlClient
Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Imports System.Configuration

Public Class frmMain

    Private ConnectionString As String
    Private LoginResult As DialogResult
    Dim frm As New frmDangNhap()
    Private TaiKhoan_Bus As TaiKhoanBUS

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        frm.ShowDialog()


    End Sub

    Private Sub buttonMenu_Click(sender As Object, e As EventArgs) Handles buttonMenu.Click

        panelanimator.ShowSync(Title)

        If (sidemenu.Width = 45) Then

            sidemenu.Visible = False
            sidemenu.Width = 210
            panelanimator.ShowSync(sidemenu)
            logoanimator.ShowSync(logo)
            buttonMenu.Location = New Point(170, 85)
            Menu.Location = New Point(209, 31)

            logo.Visible = False

        Else

            logoanimator.Hide(logo)
            sidemenu.Visible = False
            sidemenu.Width = 45
            panelanimator.ShowSync(sidemenu)
            buttonMenu.Location = New Point(3, 88)

            Menu.Location = New Point(97, 31)
            logo.Visible = True

        End If

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        Me.Close()

    End Sub

    Private Sub TiếpNhậnXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiếpNhậnXeToolStripMenuItem.Click

        Dim fthemxe As frmThemXe = New frmThemXe()
        frmThemXe.Show()

    End Sub


    Private Sub TraCứuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraCứuXeToolStripMenuItem.Click

        Dim ftracuuxe As fmrtracuuxe = New fmrtracuuxe()
        ftracuuxe.Show()

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

        Me.WindowState = WindowState.Minimized

    End Sub

    Private Function IsEmpty() As Boolean

        Return String.IsNullOrEmpty(Me.txtNewPass.Text)

    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")

        logo.Visible = False
        Panelchangepass.Visible = False
        pnThayDoiSL.Visible = False


        If frm.DialogResult = Windows.Forms.DialogResult.Cancel Then
            Me.Close()
        End If

        PanelAccount.Visible = False

        TaiKhoan_Bus = New TaiKhoanBUS()
        Dim TaiKhoan_DTO As New TaiKhoanDTO()
        Dim result As Result

        Try

            result = TaiKhoan_Bus.SelectTaiKhoan(TaiKhoan_DTO)

            If (result.FlagResult = True) Then

                MessageBox.Show("Thành Công")

            Else

                MessageBox.Show("Thất bại")

            End If

            txtuser.Text = TaiKhoan_DTO.UserName1
            txtpassword.Text = TaiKhoan_DTO.PassWord1

        Catch ex As Exception

        End Try

        Dim ThamSo_DTO As New ThamSoDTO()
        Dim thamsoBUS As New ThamSo_BUS

        thamsoBUS.SelectThamSo(ThamSo_DTO)
        lbXetoida.Text = ThamSo_DTO.SoXeToiDa.ToString()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim frm As frmDangNhap = New frmDangNhap()

        frm.ShowDialog()

    End Sub

    Private Sub btnTaiKhoan_Click(sender As Object, e As EventArgs) Handles btnTaiKhoan.Click

        PanelAccount.Visible = True
        pnThayDoiSL.Visible = False

    End Sub

    Private Sub QuảnLíÔTôToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíÔTôToolStripMenuItem.Click

        Dim frmquanlioto As frmQLXe = New frmQLXe()
        frmquanlioto.Show()

    End Sub

    Private Sub LậpPhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpPhiếuThuTiềnToolStripMenuItem.Click

        Dim frm As frmPhieuThuTien = New frmPhieuThuTien()
        frm.Show()

    End Sub

    Private Sub btnCaiDat_Click(sender As Object, e As EventArgs) Handles btnCaiDat.Click

        PanelAccount.Visible = False
        pnThayDoiSL.Visible = True

    End Sub

    Private Sub btnChangePW_Click(sender As Object, e As EventArgs) Handles btnChangePW.Click

        Panelchangepass.Visible = True

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click


        TaiKhoan_Bus = New TaiKhoanBUS()
        Dim TaiKhoan_DTO As New TaiKhoanDTO()
        Dim result As Result

        If IsEmpty() Then

            MessageBox.Show("Không được để trống!")
            txtNewPass.Focus()
            Return

        End If

        TaiKhoan_DTO.PassWord1 = txtNewPass.Text

        Try

            result = TaiKhoan_Bus.Update(TaiKhoan_DTO)

            If (result.FlagResult = True) Then

                MessageBox.Show("Thay đổi password Thành Công")

            Else

                MessageBox.Show("Thất bại")

            End If

        Catch ex As Exception

        End Try

        Try

            result = TaiKhoan_Bus.SelectTaiKhoan(TaiKhoan_DTO)

            If (result.FlagResult = True) Then

                MessageBox.Show("Thành Công")

            Else

                MessageBox.Show("Thất bại")

            End If

            txtuser.Text = TaiKhoan_DTO.UserName1
            txtpassword.Text = TaiKhoan_DTO.PassWord1

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

        Panelchangepass.Visible = False 'An panel change password

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim ThamSo_DTO As New ThamSoDTO()
        Dim thamsoBUS As New ThamSo_BUS

        ThamSo_DTO.SoXeToiDa = Convert.ToInt32(txtSoXeTNM.Text)
        thamsoBUS.upsdateThamSo(ThamSo_DTO)

        Dim result As Result

        result = thamsoBUS.upsdateThamSo(ThamSo_DTO)

        If (result.FlagResult = True) Then

            MessageBox.Show("Cập nhật số lượng xe tiếp nhận trong ngày thành công!")

        Else

            MessageBox.Show("Cập nhật thất bại!")
            Return

        End If

        thamsoBUS.SelectThamSo(ThamSo_DTO)
        lbXetoida.Text = ThamSo_DTO.SoXeToiDa.ToString()

    End Sub

    Private Sub QuảnLýPhụTùngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhụTùngToolStripMenuItem.Click

        Dim frmQLPT As New frmQLVatTuPhuTung()
        frmQLPT.Show()

    End Sub

    Private Sub BáoCáoDanhThuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoDanhThuToolStripMenuItem.Click

        Dim frmBaoCaoDT As New dp()
        frmBaoCaoDT.Show()

    End Sub

    Private Sub BáoCáoPhụTùngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoPhụTùngToolStripMenuItem.Click

        Dim frmBaoCaoPhuTung As New frmBaoCaoTon()
        frmBaoCaoPhuTung.Show()

    End Sub

    Private Sub SữaChữaÔTôToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SữaChữaÔTôToolStripMenuItem.Click

        Dim frmSuaChuaOto As New frmPhieuSuaChua()
        frmSuaChuaOto.Show()

    End Sub

    Private Sub QuảnLýTiềnCôngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýTiềnCôngToolStripMenuItem.Click

        Dim QLTienCong As New frmQLTienCong()
        QLTienCong.Show()

    End Sub

    Private Sub QuảnLýPhiếuSữaChữaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýPhiếuSữaChữaToolStripMenuItem.Click

        Dim QLSC As New frmQuanLiSuaChua()
        QLSC.Show()

    End Sub

    Private Sub QuảnLýHiệuXeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýHiệuXeToolStripMenuItem.Click

        Dim QlHieuXe As New frmQLHieuXe()
        QlHieuXe.Show()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        pnThayDoiSL.Visible = False
        PanelAccount.Visible = False

    End Sub

    Private Sub LậpPhiếuSửaChữaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpPhiếuSửaChữaToolStripMenuItem.Click

        Dim frmQLSC As New frmQuanLiSuaChua()
        frmQLSC.Show()

    End Sub

End Class