Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility

Public Class TraCuuDAL

    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    '12
    Public Function selectALL_HoTenBienSo(BienSo As String, TenKH As String, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and [tblKHACHHANG].[TenKH] = @TenKH and [tblXE].[BienSoXe] = @BienSoXe"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BienSoXe", BienSo)
                    .Parameters.AddWithValue("@TenKH", TenKH)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New KhachHangXeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"),
                                                          reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("DienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Xe theo biển số và họ tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    '13
    Public Function selectALL_BienSoHieuXe(BienSo As String, MaLoaiHieuXe As Integer, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and [tblXE].[BienSoXe] = @BienSoXe and [tblXE].[MaLoaiHieuXe] = @MaLoaiHieuXe"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BienSoXe", BienSo)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", MaLoaiHieuXe)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New KhachHangXeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"),
                                                          reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("DienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Xe theo biển số và họ tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    '14
    Public Function selectALL_BienSoTienNo(BienSo As String, TienNo As Decimal, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and [tblXE].[BienSoXe] = @BienSoXe and [tblKHACHHANG].[TienNo] = @TienNo"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BienSoXe", BienSo)
                    .Parameters.AddWithValue("@TienNo", TienNo)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New KhachHangXeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"),
                                                          reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("DienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Xe theo biển số và tiền nợ  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    '23
    Public Function selectALL_HoTenHieuXe(HoTen As String, MaLoaiHieuXe As Integer, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and [tblKHACHHANG].[TenKH] = @TenKH and [tblXE].[MaLoaiHieuXe] = @MaLoaiHieuXe"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenKH", HoTen)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", MaLoaiHieuXe)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New KhachHangXeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"),
                                                          reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("DienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Xe theo biển số và họ tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    '24
    Public Function selectALL_HoTenTienNo(HoTen As String, TienNo As Decimal, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and [tblKHACHHANG].[TenKH] = @TenKH and [tblKHACHHANG].[TienNo] = @TienNo"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenKH", HoTen)
                    .Parameters.AddWithValue("@TienNo", TienNo)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New KhachHangXeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"),
                                                          reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("DienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Xe theo biển số và họ tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    '34
    Public Function selectALL_HieuXeTienNo(MaLoaiHieuXe As Integer, TienNo As Decimal, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and [tblXE].[MaLoaiHieuXe] = @MaLoaiHieuXe and [tblKHACHHANG].[TienNo] = @TienNo"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiHieuXe", MaLoaiHieuXe)
                    .Parameters.AddWithValue("@TienNo", TienNo)

                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New KhachHangXeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"),
                                                          reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("DienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Xe theo biển số và họ tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    '123
    Public Function selectALL_BienSoHoTenHieuXe(BienSo As String, HoTen As String, MaLoaiHieuXe As Integer, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and  [tblXE].[BienSoXe] = @BienSoXe and [tblKHACHHANG].[TenKH] = @TenKH and [tblXE].[MaLoaiHieuXe] = @MaLoaiHieuXe"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@BienSoXe", BienSo)
                    .Parameters.AddWithValue("@TenKH", HoTen)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", MaLoaiHieuXe)

                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New KhachHangXeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"),
                                                          reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("DienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Xe theo biển số và họ tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    '124
    Public Function selectALL_BienSoHoTenTienNo(BienSo As String, HoTen As String, TienNo As Decimal, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and  [tblXE].[BienSoXe] = @BienSoXe and [tblKHACHHANG].[TenKH] = @TenKH and [tblKHACHHANG].[TienNo] = @TienNo"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@BienSoXe", BienSo)
                    .Parameters.AddWithValue("@TenKH", HoTen)
                    .Parameters.AddWithValue("@TienNo", TienNo)

                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New KhachHangXeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"),
                                                          reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("DienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Xe theo biển số và họ tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    '134
    Public Function selectALL_BienSoHieuXeTienNo(BienSo As String, MaLoaiHieuXe As Integer, TienNo As Decimal, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and  [tblXE].[BienSoXe] = @BienSoXe and [tblXE].[MaLoaiHieuXe] = @MaLoaiHieuXe and [tblKHACHHANG].[TienNo] = @TienNo"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@BienSoXe", BienSo)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", MaLoaiHieuXe)
                    .Parameters.AddWithValue("@TienNo", TienNo)

                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New KhachHangXeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"),
                                                          reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("DienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Xe theo biển số và họ tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    '234
    Public Function selectALL_HoTenHieuXeTienNo(HoTen As String, MaLoaiHieuXe As Integer, TienNo As Decimal, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and  [tblKHACHHANG].[TenKH] = @TenKH and [tblXE].[MaLoaiHieuXe] = @MaLoaiHieuXe and [tblKHACHHANG].[TienNo] = @TienNo"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@TenKH", HoTen)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", MaLoaiHieuXe)
                    .Parameters.AddWithValue("@TienNo", TienNo)

                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New KhachHangXeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"),
                                                          reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("DienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Xe theo biển số và họ tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_BienSoHoTenHieuXeTienNo(BienSo As String, HoTen As String, MaLoaiHieuXe As Integer, TienNo As Decimal, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and [tblXE].[BienSoXe] = @BienSoXe and  [tblKHACHHANG].[TenKH] = @TenKH and [tblXE].[MaLoaiHieuXe] = @MaLoaiHieuXe and [tblKHACHHANG].[TienNo] = @TienNo"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@BienSoXe", BienSo)
                    .Parameters.AddWithValue("@TenKH", HoTen)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", MaLoaiHieuXe)
                    .Parameters.AddWithValue("@TienNo", TienNo)

                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New KhachHangXeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"),
                                                          reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("DienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Xe theo biển số và họ tên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
