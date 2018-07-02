Public Class ChiTietPhieuSuaChuaDTO
    Private iMaCTPhieuSuaChua As Integer
    Private iMaPhieuSuaChua As Integer
    Private iMaLoaiPhuTung As Integer
    Private strTenLoaiPhuTung As String
    Private iDonGia As Integer
    Private iSoLuong As Integer

    Public Sub New(iMaCTPhieuSuaChua As Integer, iMaPhieuSuaChua As Integer, iMaLoaiPhuTung As Integer, iDonGia As Integer, iSoLuong As Integer)
        Me.iMaCTPhieuSuaChua = iMaCTPhieuSuaChua
        Me.iMaPhieuSuaChua = iMaPhieuSuaChua
        Me.iMaLoaiPhuTung = iMaLoaiPhuTung
        Me.iDonGia = iDonGia
        Me.iSoLuong = iSoLuong
    End Sub

    Public Sub New(iMaCTPhieuSuaChua As Integer, iMaPhieuSuaChua As Integer, iMaLoaiPhuTung As Integer, strTenLoaiPhuTung As String, iDonGia As Integer, iSoLuong As Integer)
        Me.iMaCTPhieuSuaChua = iMaCTPhieuSuaChua
        Me.iMaPhieuSuaChua = iMaPhieuSuaChua
        Me.iMaLoaiPhuTung = iMaLoaiPhuTung
        Me.strTenLoaiPhuTung = strTenLoaiPhuTung
        Me.iDonGia = iDonGia
        Me.iSoLuong = iSoLuong
    End Sub

    Property MaCTPhieuSuaChua() As Integer
        Get
            Return iMaCTPhieuSuaChua
        End Get
        Set(value As Integer)
            iMaCTPhieuSuaChua = value
        End Set
    End Property

    Property MaPhieuSuaChua() As Integer
        Get
            Return iMaPhieuSuaChua
        End Get
        Set(value As Integer)
            iMaPhieuSuaChua = value
        End Set
    End Property

    Property MaLoaiPhuTung As Integer
        Get
            Return iMaLoaiPhuTung
        End Get
        Set(value As Integer)
            iMaLoaiPhuTung = value
        End Set
    End Property

    Property TenLoaiPhuTung As String
        Get
            Return strTenLoaiPhuTung
        End Get
        Set(value As String)
            strTenLoaiPhuTung = value
        End Set
    End Property

    Property DonGia As Integer
        Get
            Return iDonGia
        End Get
        Set(value As Integer)
            iDonGia = value
        End Set
    End Property

    Property SoLuong() As Integer
        Get
            Return iSoLuong
        End Get
        Set(value As Integer)
            iSoLuong = value
        End Set
    End Property

    Public Function Clone() As ChiTietPhieuSuaChuaDTO
        Return Me.MemberwiseClone()
    End Function
End Class
