Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility


Public Class XeBUS
    Private Xe_DAL As XeDAL
    Public Sub New()
        Xe_DAL = New XeDAL()
    End Sub
    Public Sub New(connectionString As String)
        Xe_DAL = New XeDAL(connectionString)
    End Sub
    Public Function isValidLicensePlate(Xe As XeDTO) As Boolean

        If (Xe.BienSo.Length < 1) Then
            Return False
        End If


        Return True
    End Function


    Public Function insert(Xe_DTO As XeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return Xe_DAL.InsertXe(Xe_DTO)

    End Function


    Public Function isValidName(Xe_DTO As XeDTO) As Boolean

        If (Xe_DTO.HoTen.Length < 1) Then
            Return False
        End If

        Return True
    End Function

    Public Function isValidAddress(Xe_DTO As XeDTO) As Boolean

        If (Xe_DTO.DiaChi.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function isValidPhone(Xe_DTO As XeDTO) As Boolean

        If (Xe_DTO.SoDienThoai.Length < 1) Then
            Return False
        End If
        Return True

    End Function

    Public Function isValidThebalance(Xe_DTO As XeDTO) As Boolean

        If (Xe_DTO.SoTienNo.ToString().Length < 1) Then
            Return False
        End If

        Return True


    End Function
    Public Function update(Xe As XeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return Xe_DAL.update(Xe)
    End Function
    Public Function delete(HieuXe As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return Xe_DAL.delete(HieuXe)
    End Function
    Public Function selectAll(ByRef listLoaiHieuXe As List(Of XeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return Xe_DAL.selectALLXe(listLoaiHieuXe)
    End Function
    Public Function selectALL_ByMaKH(iMaKH As Integer, ByRef listXe As List(Of XeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return Xe_DAL.selectALL_ByMaKH(iMaKH, listXe)
    End Function
    Public Function selectALL_ByHieuXe(MaLoaiHieuXe As Integer, ByRef listXe As List(Of XeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return Xe_DAL.selectALL_ByHieuXe(MaLoaiHieuXe, listXe)
    End Function
    Public Function Show() As DataTable
        Return Xe_DAL.FilterData()
    End Function

End Class
