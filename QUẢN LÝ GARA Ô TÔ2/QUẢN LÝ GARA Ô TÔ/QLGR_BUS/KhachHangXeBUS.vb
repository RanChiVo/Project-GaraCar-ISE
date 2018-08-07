Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility

Public Class KhachHangXeBUS

    Public Function isValiIDKH(KhachHangXe_DTO As KhachHangXeDTO) As Boolean

        If (KhachHangXe_DTO.MaKH1.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function isValidName(KhachHangXe_DTO As KhachHangXeDTO) As Boolean

        If (KhachHangXe_DTO.HoTen1.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function isValidAddress(KhachHangXe_DTO As KhachHangXeDTO) As Boolean

        If (KhachHangXe_DTO.DiaChi1.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function isValidPhone(KhachHangXe_DTO As KhachHangXeDTO) As Boolean

        If (KhachHangXe_DTO.SoDienThoai1.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function isValidThebalance(KhachHangXe_DTO As KhachHangXeDTO) As Boolean

        If (KhachHangXe_DTO.SoTienNo1.ToString().Length < 1) Then
            Return False
        End If

        Return True

    End Function

End Class
