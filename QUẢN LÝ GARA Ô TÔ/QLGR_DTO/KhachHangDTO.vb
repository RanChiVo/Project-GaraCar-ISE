﻿Public Class KhachHangDTO

    Private strMaKH As String
    Private strHoTen As String
    Private strDiaChi As String
    Private strSoDienThoai As String
    Public Sub New()
    End Sub

    Public Property MaKH As String
        Get
            Return strMaKH
        End Get
        Set(value As String)
            strMaKH = value
        End Set
    End Property

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
End Class
