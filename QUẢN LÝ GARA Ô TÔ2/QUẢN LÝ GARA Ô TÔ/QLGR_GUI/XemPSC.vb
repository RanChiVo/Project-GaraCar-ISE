Imports System.Data.SqlClient
Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class XemPSC

    Dim connection As New SqlConnection("Server = DESKTOP-0354T0B; Database= QLGR; Integrated Security = true")

    Private MaSuaChua As String

    Public Property MaSuaChua1 As String
        Get
            Return MaSuaChua
        End Get
        Set(value As String)
            MaSuaChua = value
        End Set
    End Property

    Public Sub FilterData()

        'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
        Dim searchQuery As String = " SELECT MaPhieuSuaChua, NgaySuaChua, [tblXE].[BienSoXe], [tblXE].[MaKH], TenKH , DienThoai, TienNo FROM [tblXE], [tblKHACHHANG], [tblPHIEUSUACHUA]
            WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and [tblPHIEUSUACHUA].[BienSoXe] = [tblXE].[BienSoXe]"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgvPhieuSuaChua.DataSource = table

    End Sub

    Private Sub XemPSC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData()
        binding()
    End Sub

    Public Sub binding()

        txtMaPhieuSuaChua.DataBindings.Clear()
        txtMaPhieuSuaChua.DataBindings.Add("text", dgvPhieuSuaChua.DataSource, "MaPhieuSuaChua")

    End Sub



    Private Sub btnChonMaPhieu_Click(sender As Object, e As EventArgs) Handles btnChonMaPhieu.Click

        Dim frm As frmPhieuThuTien = New frmPhieuThuTien()
        Dim dlg1 As frmPhieuThuTien.mydel1

        dlg1 = New frmPhieuThuTien.mydel1(AddressOf frmPhieuThuTien.SetText)
        dlg1.Invoke(txtMaPhieuSuaChua.Text)

        MessageBox.Show("Bạn vừa tìm Mã phiếu sửa chữa mới. Vui lòng nhấp chuột vào ô Cập nhật TTKH ở PHIẾU THU TIỀN để cập nhập TTKH")

        frm.txtMaPhieuSuaChua.Text = txtMaPhieuSuaChua.Text


        Me.Close()


    End Sub
End Class