

Public Class BaoCaoDoanhThuDTO

    Private strTenHieuXe As String
    Private iSoLuocSua As Integer
    Private decThanhTien As Decimal
    Private flTyLe As Double

    Public Sub New()

    End Sub

    Public Sub New(strTenHieuXe As String, iSoLuocSua As Integer, decThanhTien As Decimal, flTyLe As Double)

        Me.strTenHieuXe = strTenHieuXe
        Me.iSoLuocSua = iSoLuocSua
        Me.decThanhTien = decThanhTien
        Me.flTyLe = flTyLe

    End Sub

    Public Property TenHieuXe As String
        Get
            Return strTenHieuXe
        End Get
        Set(value As String)
            strTenHieuXe = value
        End Set
    End Property

    Public Property SoLuocSua As Integer
        Get
            Return iSoLuocSua
        End Get
        Set(value As Integer)
            iSoLuocSua = value
        End Set
    End Property

    Public Property ThanhTien As Decimal
        Get
            Return decThanhTien
        End Get
        Set(value As Decimal)
            decThanhTien = value
        End Set
    End Property

    Public Property TyLe As Double
        Get
            Return flTyLe
        End Get
        Set(value As Double)
            flTyLe = value
        End Set
    End Property

End Class
