Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility

<<<<<<< HEAD
Public Class XeBUS

    Private Xe_DAL As XeDAL
    Private KhachHang_DAL As KhachHangDAL
    Private TraCuu_DAL As TraCuuDAL

    Public Sub New()

        Xe_DAL = New XeDAL()
        TraCuu_DAL = New TraCuuDAL()
    End Sub
    Public Sub New(connectionString As String)
        Xe_DAL = New XeDAL(connectionString)
        TraCuu_DAL = New TraCuuDAL(connectionString)
    End Sub

=======

Public Class XeBUS
    Private Xe_DAL As XeDAL
    Public Sub New()
        Xe_DAL = New XeDAL()
    End Sub
    Public Sub New(connectionString As String)
        Xe_DAL = New XeDAL(connectionString)
    End Sub
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    Public Function isValidLicensePlate(Xe As XeDTO) As Boolean

        If (Xe.BienSo.Length < 1) Then
            Return False
        End If

<<<<<<< HEAD
=======

>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Return True
    End Function


    Public Function insert(Xe_DTO As XeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return Xe_DAL.InsertXe(Xe_DTO)

<<<<<<< HEAD

    End Function

    Public Function update(Xe As KhachHangXeDTO) As Result


        Return Xe_DAL.update(Xe)
    End Function

    Public Function delete(KhachHangXe As KhachHangXeDTO) As Result

        Return Xe_DAL.delete(KhachHangXe)
    End Function

    Public Function selectAll(ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB

        Return Xe_DAL.selectALLXe(listKhachHangXe)
    End Function

    '    Public Function selectALL_ByMaKH(iMaKH As Integer, ByRef listXe As List(Of XeDTO)) As Result
    '1. verify data here!!

    '        2. insert to DB
    '        Return Xe_DAL.selectALL_ByMaKH(iMaKH, listXe)
    '    End Function
    Public Function selectALL_ByHieuXe(MaLoaiHieuXe As Integer, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return Xe_DAL.selectALL_ByHieuXe(MaLoaiHieuXe, listKhachHangXe)
    End Function

    Public Function Show() As DataTable
        Return Xe_DAL.FilterData()
    End Function

    Public Function Check(XE_DTO As XeDTO) As Boolean

        Dim ThamSo_DTO As New ThamSoDTO
        Dim thamsoBUS As New ThamSo_BUS
        thamsoBUS.SelectThamSo(ThamSo_DTO)

        If (Xe_DAL.CountXe(XE_DTO) >= ThamSo_DTO.SoXeToiDa) Then
=======
    End Function


    Public Function isValidName(Xe_DTO As XeDTO) As Boolean

        If (Xe_DTO.HoTen.Length < 1) Then
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
            Return False
        End If

        Return True
    End Function

<<<<<<< HEAD
    Public Function selectALL_ByBienSo(BienSo As String, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return Xe_DAL.selectALL_BienSoXe(BienSo, listKhachHangXe)
    End Function

    Public Function selectALL_ByHoTen(HoTen As String, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return Xe_DAL.selectALL_HoTen(HoTen, listKhachHangXe)
    End Function

    Public Function selectALL_ByTienNo(TienNo As Decimal, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return Xe_DAL.selectALL_TienNo(TienNo, listKhachHangXe)

    End Function

    Public Function selectALL_ByBienSoHoTen(BienSo As String, HoTen As String, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TraCuu_DAL.selectALL_HoTenBienSo(BienSo, HoTen, listKhachHangXe)
    End Function

    Public Function selectALL_ByBienSoMaLoaiHieuXe(BienSo As String, MaLoaiHieuXe As Integer, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TraCuu_DAL.selectALL_BienSoHieuXe(BienSo, MaLoaiHieuXe, listKhachHangXe)
    End Function

    Public Function selectALL_ByBienSoTienNo(BienSo As String, TienNo As Decimal, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TraCuu_DAL.selectALL_BienSoTienNo(BienSo, TienNo, listKhachHangXe)
    End Function

    '23
    Public Function selectALL_ByHoTenHieuXe(HoTen As String, HieuXe As Integer, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TraCuu_DAL.selectALL_HoTenHieuXe(HoTen, HieuXe, listKhachHangXe)
    End Function

    '24
    Public Function selectALL_ByHoTenTienNo(HoTen As String, TienNo As Decimal, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TraCuu_DAL.selectALL_HoTenTienNo(HoTen, TienNo, listKhachHangXe)
    End Function

    '34
    Public Function selectALL_ByHieuXeTienNo(MaLoaiHieuXe As Integer, TienNo As Decimal, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TraCuu_DAL.selectALL_HieuXeTienNo(MaLoaiHieuXe, TienNo, listKhachHangXe)
    End Function

    '123
    Public Function selectALL_ByBienSoHoTenHieuXe(BienSo As String, HoTen As String, MaLoaiHieuXe As Integer, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TraCuu_DAL.selectALL_BienSoHoTenHieuXe(BienSo, HoTen, MaLoaiHieuXe, listKhachHangXe)
    End Function


    '124
    Public Function selectALL_ByBienSoHoTenTienNo(BienSo As String, HoTen As String, TienNo As Decimal, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TraCuu_DAL.selectALL_BienSoHoTenTienNo(BienSo, HoTen, TienNo, listKhachHangXe)
    End Function


    '134
    Public Function selectALL_ByBienSoHieuXeTienNo(BienSo As String, MaLoaiHieuXe As Integer, TienNo As Decimal, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TraCuu_DAL.selectALL_BienSoHieuXeTienNo(BienSo, MaLoaiHieuXe, TienNo, listKhachHangXe)
    End Function

    '234
    Public Function selectALL_ByHoTenHieuXeTienNo(HoTen As String, MaLoaiHieuXe As Integer, TienNo As Decimal, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return TraCuu_DAL.selectALL_HoTenHieuXeTienNo(HoTen, MaLoaiHieuXe, TienNo, listKhachHangXe)
    End Function

    '1234
    Public Function selectALL_ByBienSoHoTenHieuXeTienNo(BienSo As String, HoTen As String, MaLoaiHieuXe As Integer, TienNo As Decimal, ByRef listKhachHangXe As List(Of KhachHangXeDTO)) As Result

        Return TraCuu_DAL.selectALL_BienSoHoTenHieuXeTienNo(BienSo, HoTen, MaLoaiHieuXe, TienNo, listKhachHangXe)
    End Function


    Public Function selectAllPSC(ByRef ListXe As List(Of XeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB

        Return Xe_DAL.selectAllSC(ListXe)

=======
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
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    End Function

End Class
