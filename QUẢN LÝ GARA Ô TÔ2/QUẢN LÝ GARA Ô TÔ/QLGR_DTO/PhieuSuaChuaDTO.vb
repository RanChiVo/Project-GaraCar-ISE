Imports QLGR_DTO

Public Class PhieuSuaChuaDTO
    Private iMaPhieuSuaChua As Integer
    Private strBienSoXe As String
    Private dtpNgaySuaChua As DateTime
    Private strNoiDung As String
    Private iMaLoaiTienCong As Integer
    Private iThanhTien As Integer

    Private lsCTPSC As List(Of ChiTietPhieuSuaChuaDTO)

    Public Sub New()
        Me.iMaPhieuSuaChua = 0
        Me.strBienSoXe = String.Empty
        Me.dtpNgaySuaChua = Date.Now
        Me.strNoiDung = String.Empty
        Me.iMaLoaiTienCong = 0
        Me.iThanhTien = 0
        Me.lsCTPSC = New List(Of ChiTietPhieuSuaChuaDTO)
    End Sub

    Public Sub New(iMaPhieuSuaChua As Integer, strBienSoXe As String, dtpNgaySuaChua As DateTime, strNoiDung As String, iMaLoaiTienCong As Integer, iThanhTien As Integer, lsCTPSC As List(Of ChiTietPhieuSuaChuaDTO))
        Me.iMaPhieuSuaChua = iMaPhieuSuaChua
        Me.strBienSoXe = strBienSoXe
        Me.dtpNgaySuaChua = dtpNgaySuaChua
        Me.strNoiDung = strNoiDung
        Me.iMaLoaiTienCong = iMaLoaiTienCong
        Me.iThanhTien = iThanhTien
        Me.lsCTPSC = lsCTPSC
    End Sub

    Private Sub New(iMaPhieuSuaChua As Integer, strBienSoXe As String, dtpNgaySuaChua As DateTime, iMaLoaiTienCong As Integer, iThanhTien As Integer, lsCTPSC As List(Of ChiTietPhieuSuaChuaDTO))
        Me.iMaPhieuSuaChua = iMaPhieuSuaChua
        Me.strBienSoXe = strBienSoXe
        Me.dtpNgaySuaChua = dtpNgaySuaChua
        Me.strNoiDung = String.Empty
        Me.iMaLoaiTienCong = iMaLoaiTienCong
        Me.iThanhTien = iThanhTien
        Me.lsCTPSC = lsCTPSC
    End Sub

    Public Property MaPhieuSuaChua As Integer
        Get
            Return iMaPhieuSuaChua
        End Get
        Set(value As Integer)
            iMaPhieuSuaChua = value
        End Set
    End Property

    Public Property BienSoXe As String
        Get
            Return strBienSoXe
        End Get
        Set(value As String)
            strBienSoXe = value
        End Set
    End Property

    Public Property NgaySuaChua As DateTime
        Get
            Return dtpNgaySuaChua
        End Get
        Set(value As DateTime)
            dtpNgaySuaChua = value
        End Set
    End Property

    Public Property NoiDung As String
        Get
            Return strNoiDung
        End Get
        Set(value As String)
            strNoiDung = value
        End Set
    End Property

    Public Property MaLoaiTienCong As Integer
        Get
            Return iMaLoaiTienCong
        End Get
        Set(value As Integer)
            iMaLoaiTienCong = value
        End Set
    End Property

    Public Property ThanhTien As Integer
        Get
            Return iThanhTien
        End Get
        Set(value As Integer)
            iThanhTien = value
        End Set
    End Property

    Public Property ListCTPSC As List(Of ChiTietPhieuSuaChuaDTO)
        Get
            Return lsCTPSC
        End Get
        Set(value As List(Of ChiTietPhieuSuaChuaDTO))
            lsCTPSC = value
        End Set
    End Property

End Class
