Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility

Public Class LoaiHieuXeBUS
<<<<<<< HEAD

    Private LoaiHieuXe_DAL As LoaiHieuXeDAL

    Public Sub New()
        LoaiHieuXe_DAL = New LoaiHieuXeDAL()
    End Sub

    Public Sub New(connectionString As String)
        LoaiHieuXe_DAL = New LoaiHieuXeDAL(connectionString)
    End Sub

    Public Function isValidName(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Boolean

        If (LoaiHieuXe_DTO.TenHieuXe.Length) < 1 Then
            Return False
        End If

        Return True

    End Function


    Public Function isValidID(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Boolean

        If (LoaiHieuXe_DTO.MaHieuXe.ToString().Length) < 1 Then
=======
    Private LoaiHieuXe_DAL As LoaiHieuXeDAL
    Public Sub New()
        LoaiHieuXe_DAL = New LoaiHieuXeDAL()
    End Sub
    Public Sub New(connectionString As String)
        LoaiHieuXe_DAL = New LoaiHieuXeDAL(connectionString)
    End Sub
    Public Function isValidName(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Boolean

        If (LoaiHieuXe_DTO.TenHieuXe) Then
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
            Return False
        End If

        Return True

    End Function

    Public Function insert(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return LoaiHieuXe_DAL.insert(LoaiHieuXe_DTO)

    End Function
    Public Function update(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return LoaiHieuXe_DAL.update(LoaiHieuXe_DTO)
    End Function
<<<<<<< HEAD

=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    Public Function delete(MaLoaiHieuXe As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return LoaiHieuXe_DAL.delete(MaLoaiHieuXe)
    End Function
<<<<<<< HEAD

=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    Public Function selectAll(ByRef listLoaiHieuXe As List(Of LoaiHieuXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
<<<<<<< HEAD
        Return LoaiHieuXe_DAL.selectALL(listLoaiHieuXe)
    End Function

=======
        Return LoaiHieuXe_DAL.selectAll(listLoaiHieuXe)
    End Function
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return LoaiHieuXe_DAL.getNextID(nextID)
    End Function
End Class
