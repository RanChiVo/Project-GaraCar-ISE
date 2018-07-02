
Public Class PhieuThuTienDTO

    Private strMaPhieuThuTien As String
    Private strMaPhieuSuaChua As String
    Private DecSoTienThu As Decimal
    Private dateNgayThuTien As DateTime

    Public Sub New()
    End Sub

    Public Sub New(strMaPhieuThuTien As String, strMaPhieuSuaChua As String, DecSoTienThu As Decimal, dateNgayThuTien As DateTime)

        Me.strMaPhieuThuTien = strMaPhieuThuTien
        Me.strMaPhieuSuaChua = strMaPhieuSuaChua
        Me.DecSoTienThu = DecSoTienThu
        Me.dateNgayThuTien = dateNgayThuTien

    End Sub

    Public Property MaPhieuSuaChua As String
        Get
            Return strMaPhieuSuaChua
        End Get
        Set(value As String)
            strMaPhieuSuaChua = value
        End Set
    End Property

    Public Property MaPhieuThuTien As String
        Get
            Return strMaPhieuThuTien
        End Get
        Set(value As String)
            strMaPhieuThuTien = value
        End Set
    End Property

    Public Property SoTienThu As Decimal
        Get
            Return DecSoTienThu
        End Get
        Set(value As Decimal)
            DecSoTienThu = value
        End Set
    End Property

    Public Property NgayThuTien As Date
        Get
            Return dateNgayThuTien
        End Get
        Set(value As Date)
            dateNgayThuTien = value
        End Set
    End Property


End Class
