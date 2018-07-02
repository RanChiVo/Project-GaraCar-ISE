Public Class LoaiHieuXeDTO

    Private iMaLoaiHieuXe As Integer
    Private strTenHieuXe As String

    Public Sub New()
    End Sub
<<<<<<< HEAD

=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    Public Sub New(Maloai As Integer, tenloai As String)
        iMaLoaiHieuXe = Maloai
        strTenHieuXe = tenloai
    End Sub
<<<<<<< HEAD

=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    Public Property MaHieuXe As Integer
        Get
            Return iMaLoaiHieuXe
        End Get
        Set(value As Integer)
            iMaLoaiHieuXe = value
        End Set
    End Property

    Public Property TenHieuXe As String
        Get
            Return strTenHieuXe
        End Get
        Set(value As String)
            strTenHieuXe = value
        End Set
    End Property
<<<<<<< HEAD

=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
End Class
