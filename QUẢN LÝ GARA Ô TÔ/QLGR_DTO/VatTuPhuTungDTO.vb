Public Class VatTuPhuTungDTO
    Private iMaLoaiPhuTung As Integer
    Private strTenLoaiPhuTung As String
    Private iDonGia As Integer
    Private iSoLuong As Integer
    Private dtpNgayNhap As DateTime

    Public Sub New()
    End Sub

    Public Sub New(iMaLoaiPhuTung As Integer, strTenLoaiPhuTung As String, iDonGia As Integer, iSoLuong As Integer, dtpNgayNhap As DateTime)
        Me.iMaLoaiPhuTung = iMaLoaiPhuTung
        Me.strTenLoaiPhuTung = strTenLoaiPhuTung
        Me.iDonGia = iDonGia
        Me.iSoLuong = iSoLuong
        Me.dtpNgayNhap = DateTime.Now
    End Sub

    Property MaLoaiPhuTung() As Integer
        Get
            Return iMaLoaiPhuTung
        End Get
        Set(value As Integer)
            iMaLoaiPhuTung = value
        End Set
    End Property

    Property TenLoaiPhuTung() As String
        Get
            Return strTenLoaiPhuTung
        End Get
        Set(value As String)
            strTenLoaiPhuTung = value
        End Set
    End Property

    Property DonGia() As Integer
        Get
            Return iDonGia
        End Get
        Set(value As Integer)
            iDonGia = value
        End Set
    End Property

    Property SoLuong As Integer
        Get
            Return iSoLuong
        End Get
        Set(value As Integer)
            iSoLuong = value
        End Set
    End Property

    Property NgayNhap As DateTime
        Get
            Return dtpNgayNhap
        End Get
        Set(value As DateTime)
            dtpNgayNhap = value
        End Set
    End Property

    Public Function Clone() As VatTuPhuTungDTO
        Return Me.MemberwiseClone()
    End Function

End Class