Imports Utility
Imports QLGR_DTO
Imports QLGR_DAL

Public Class TaiKhoanBUS

    Private TaiKhoan_DAL As TaiKhoanDAL

    Public Sub New()

        TaiKhoan_DAL = New TaiKhoanDAL()

    End Sub

    Public Function SelectTaiKhoan(ByRef TaiKhoan_DTO As TaiKhoanDTO) As Result

        Return TaiKhoan_DAL.selectTaiKhoan(TaiKhoan_DTO)

    End Function

    Public Function Update(ByRef TaiKhoan_DTO As TaiKhoanDTO) As Result

        Return TaiKhoan_DAL.update(TaiKhoan_DTO)

    End Function


End Class
