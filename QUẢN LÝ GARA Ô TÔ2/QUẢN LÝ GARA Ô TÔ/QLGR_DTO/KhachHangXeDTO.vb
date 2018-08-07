Imports QLGR_DTO

Public Class KhachHangXeDTO

    Private strBienSo1 As String
    Private iLoaiHieuXe1 As Integer
    Private dateNgayTiepNhan1 As DateTime
    Private strMaKH1 As String
    Private strHoTen1 As String
    Private strDiaChi1 As String
    Private strSoDienThoai1 As String
    Private strSoTienNo1 As Decimal



    Public Sub New()
    End Sub

    Public Sub New(strBienSo As String, iLoaiHieuXe As Integer, dateNgayTiepNhan As DateTime, strMaKH As String, strHoTen As String, strDiaChi As String, strSoDienThoai As String, strSoTienNo As Decimal)
        Me.strMaKH1 = strMaKH
        Me.strBienSo1 = strBienSo
        Me.iLoaiHieuXe1 = iLoaiHieuXe
        Me.dateNgayTiepNhan1 = dateNgayTiepNhan
        Me.strHoTen1 = strHoTen
        Me.strDiaChi1 = strDiaChi
        Me.strSoDienThoai1 = strSoDienThoai
        Me.strSoTienNo1 = strSoTienNo

    End Sub

    Public Property BienSo1 As String
        Get
            Return strBienSo1
        End Get
        Set(value As String)
            strBienSo1 = value
        End Set
    End Property

    Public Property LoaiHieuXe1 As Integer
        Get
            Return iLoaiHieuXe1
        End Get
        Set(value As Integer)
            iLoaiHieuXe1 = value
        End Set
    End Property

    Public Property NgayTiepNhan1 As Date
        Get
            Return dateNgayTiepNhan1
        End Get
        Set(value As Date)
            dateNgayTiepNhan1 = value
        End Set
    End Property

    Public Property MaKH1 As String
        Get
            Return strMaKH1
        End Get
        Set(value As String)
            strMaKH1 = value
        End Set
    End Property

    Public Property HoTen1 As String
        Get
            Return strHoTen1
        End Get
        Set(value As String)
            strHoTen1 = value
        End Set
    End Property

    Public Property DiaChi1 As String
        Get
            Return strDiaChi1
        End Get
        Set(value As String)
            strDiaChi1 = value
        End Set
    End Property

    Public Property SoDienThoai1 As String
        Get
            Return strSoDienThoai1
        End Get
        Set(value As String)
            strSoDienThoai1 = value
        End Set
    End Property

    Public Property SoTienNo1 As Decimal
        Get
            Return strSoTienNo1
        End Get
        Set(value As Decimal)
            strSoTienNo1 = value
        End Set
    End Property
End Class
