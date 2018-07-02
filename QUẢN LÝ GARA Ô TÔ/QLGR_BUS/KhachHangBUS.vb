Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility

Public Class KhachHangBUS
<<<<<<< HEAD

    Private KhachHang_DAL As KhachHangDAL

    Public Sub New()
        KhachHang_DAL = New KhachHangDAL()
    End Sub

=======
    Private KhachHang_DAL As KhachHangDAL
    Public Sub New()
        KhachHang_DAL = New KhachHangDAL()
    End Sub
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    Public Sub New(connectionString As String)
        KhachHang_DAL = New KhachHangDAL(connectionString)
    End Sub

<<<<<<< HEAD
=======

>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    Public Function isValidName(KhachHang_DTO As KhachHangDTO) As Boolean

        If (KhachHang_DTO.HoTen.Length < 1) Then
            Return False
        End If

        Return True
<<<<<<< HEAD

=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    End Function

    Public Function isValidAddress(KhachHang_DTO As KhachHangDTO) As Boolean

        If (KhachHang_DTO.DiaChi.Length < 1) Then
            Return False
        End If

        Return True
    End Function
<<<<<<< HEAD

=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    Public Function isValidPhone(KhachHang_DTO As KhachHangDTO) As Boolean

        If (KhachHang_DTO.SoDienThoai.Length < 1) Then
            Return False
        End If
        Return True

    End Function

    Public Function isValidThebalance(KhachHang_DTO As KhachHangDTO) As Boolean

        If (KhachHang_DTO.SoTienNo.ToString().Length < 1) Then
            Return False
        End If

        Return True
<<<<<<< HEAD
=======

>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    End Function

    Public Function insert(KhachHang_DTO As KhachHangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return KhachHang_DAL.insert(KhachHang_DTO)
    End Function
<<<<<<< HEAD

    Public Function buidlMaKH(ByRef nextMaKH As String) As Result
        Return KhachHang_DAL.BuildMaKH(nextMaKH)
    End Function


End Class

=======
    Public Function update(lop As KhachHangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return KhachHang_DAL.update(lop)
    End Function
    Public Function delete(MaKH As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return KhachHang_DAL.delete(MaKH)
    End Function
    Public Function selectAll(ByRef listKhachHang As List(Of KhachHangDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return KhachHang_DAL.selectALL(listKhachHang)
    End Function
    Public Function Show() As DataTable
        Return KhachHang_DAL.FilterData()
    End Function
    Public Function buildMaKH(nextMaKH As String) As Result
        Return KhachHang_DAL.BuildMaKH(nextMaKH)
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function
End Class
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
