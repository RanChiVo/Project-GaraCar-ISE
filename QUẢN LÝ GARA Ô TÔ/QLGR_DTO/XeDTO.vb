Public Class XeDTO

    Private strBienSo As String
    Private iLoaiHieuXe As Integer
    Private dateNgayTiepNhan As DateTime
<<<<<<< HEAD
    Private strMaKH As String
=======
    Private strHoTen As String
    Private strDiaChi As String
    Private strSoDienThoai As String
    Private strSoTienNo As Decimal
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d


    Public Sub New()
    End Sub

<<<<<<< HEAD

    Public Sub New(strBienSo)

        Me.strBienSo = strBienSo

    End Sub

    Public Sub New(strBienSo As String, iLoaiHieuXe As Integer, dateNgayTiepNhan As DateTime, strMaKH As String)
        Me.strBienSo = strBienSo
        Me.iLoaiHieuXe = iLoaiHieuXe
        Me.dateNgayTiepNhan = dateNgayTiepNhan
        Me.strMaKH = strMaKH
=======
    Public Sub New(strBienSo As String, iLoaiHieuXe As Integer, dateNgayTiepNhan As DateTime, strHoTen As String, strDiaChi As String, strSoDienThoai As String, strSoTienNo As Decimal)
        Me.strBienSo = strBienSo
        Me.iLoaiHieuXe = iLoaiHieuXe
        Me.dateNgayTiepNhan = dateNgayTiepNhan
        Me.strHoTen = strHoTen
        Me.strDiaChi = strDiaChi
        Me.strSoDienThoai = strSoDienThoai
        Me.strSoTienNo = strSoTienNo

>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    End Sub

    Public Property BienSo As String
        Get
            Return strBienSo
        End Get
        Set(value As String)
            strBienSo = value
        End Set
    End Property

    Public Property LoaiHieuXe As Integer
        Get
            Return iLoaiHieuXe
        End Get
        Set(value As Integer)
            iLoaiHieuXe = value
        End Set
    End Property

    Public Property NgayTiepNhan As Date
        Get
            Return dateNgayTiepNhan
        End Get
        Set(value As Date)
            dateNgayTiepNhan = value
        End Set
    End Property
<<<<<<< HEAD

    Public Property MaKH As String
        Get
            Return strMaKH
        End Get
        Set(value As String)
            strMaKH = value
        End Set
    End Property


=======
    Public Property HoTen As String
        Get
            Return strHoTen
        End Get
        Set(value As String)
            strHoTen = value
        End Set
    End Property

    Public Property DiaChi As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property SoDienThoai As String
        Get
            Return strSoDienThoai
        End Get
        Set(value As String)
            strSoDienThoai = value
        End Set
    End Property

    Public Property SoTienNo As Decimal
        Get
            Return strSoTienNo
        End Get
        Set(value As Decimal)
            strSoTienNo = value
        End Set
    End Property
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
End Class
