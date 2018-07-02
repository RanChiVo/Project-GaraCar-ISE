Imports Utility
Imports QLGR_DTO
Imports QLGR_DAL


Public Class PhieuThuTienBUS

    Private PhieuThuTien_DAL As PhieuThuTienDAL


    Public Sub New()

        PhieuThuTien_DAL = New PhieuThuTienDAL

    End Sub

    Public Function insert(PhieuThuTien_DTO As PhieuThuTienDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return PhieuThuTien_DAL.insert(PhieuThuTien_DTO)
    End Function

    Public Function buidlMaPTT(ByRef nextMaPTT As String) As Result

        Return PhieuThuTien_DAL.BuildMaPhieuThuTien(nextMaPTT)

    End Function

    Public Function CheckMaPhieuSC(PhieuThuTien_DTO As PhieuThuTienDTO) As Boolean

        If (PhieuThuTien_DTO.MaPhieuSuaChua < 1) Then

            Return False

        End If

        Return True

    End Function

    Public Function SelectThongTinKH(MaPhieuSuaChua As String, ByRef KhachHangXe_DTO As KhachHangXeDTO) As Result

        Return PhieuThuTien_DAL.SelectThongTinKH(MaPhieuSuaChua, KhachHangXe_DTO)

    End Function

    Public Function SelectTienSuaChua(MaPhieuSuaChua As Integer, ByRef PhieuSuaChua_DTO As PhieuSuaChuaDTO) As Result

        Return PhieuThuTien_DAL.SelectTienSuaChua(MaPhieuSuaChua, PhieuSuaChua_DTO)

    End Function

    Public Function UpdateTienNoKH(SoNoMoi As String, ByRef KhachHang_DTO As KhachHangDTO) As Result

        Return PhieuThuTien_DAL.updateSoNo(SoNoMoi, KhachHang_DTO)

    End Function


End Class
