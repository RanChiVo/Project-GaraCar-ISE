Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility

Public Class XeDAL

    Private connectionString As String
    Dim connection As New SqlConnection("Server = DESKTOP-0354T0B; Database= QLGR; Integrated Security = true")

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function FilterData() As DataTable ' Đỗ dữ liệu

        Dim query As String = "Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, TenKH, tblXE.MaKH, DiaChi, DienThoai, TienNo FROM tblXE, tblKHACHHANG WHERE tblXE.MaKH = tblKHACHHANG.MaKH"

        Dim command As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable

        adapter.Fill(table)
        Return table

    End Function


    Public Sub ExcuteNonQuery(sql As String) ' Thuc thi cau lệnh sql
        connection.Open()
        Dim Command As New SqlCommand(sql, connection)
        Command.ExecuteNonQuery()
        Command.Dispose()
        connection.Close()
    End Sub

    Public Function InsertXe(xe As XeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblXE] ([BienSoXe], [MaKH],[MaLoaiHieuXe], [NgayTiepNhan])"
        query &= "VALUES (@BienSoXe,@MaKH,@MaLoaiHieuXe,@NgayTiepNhan)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BienSoXe", xe.BienSo)
                    .Parameters.AddWithValue("@MaKH", xe.MaKH)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", xe.LoaiHieuXe)
                    .Parameters.AddWithValue("@NgayTiepNhan", xe.NgayTiepNhan)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function CountXe(xe As XeDTO) As Integer

        Dim NgayTiepNhan As DateTime = xe.NgayTiepNhan
        Dim query As String = String.Empty
        Dim sum As Integer

        query &= " select Count(*)  As SLX"
        query &= " from [tblXE], [tblKHACHHANG]"
        query &= " where tblXE.MaKH = tblKHACHHANG.MaKH and [NgayTiepNhan] = @NgayTiepNhan"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand

                With comm
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Connection = conn

                    .Parameters.AddWithValue("@NgayTiepNhan", NgayTiepNhan)
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    While reader.Read()
                        sum = reader("SLX")
                    End While
                Catch ex As Exception
                    conn.Close()
                    Return 0
                Finally
                    conn.Close()
                End Try

            End Using
        End Using
        Return sum

    End Function

    Public Function selectALLXe(listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= "Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH]"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
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
                    Return New Result(False, "Lấy tất cả Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function selectAllSC(ByRef listXe As List(Of XeDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [BienSoXe] FROM [tblXE]"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New XeDTO(reader("BienSoXe")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function selectALL_BienSoXe(BienSo As String, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and tblXE.[BienSoXe] like '%' + @BienSoXe + '%'"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BienSoXe", BienSo)
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
                    Return New Result(False, "Lấy tất cả Xe theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByHieuXe(ByVal maloai As Integer, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= "Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and [tblXE].[MaLoaiHieuXe] = @MaLoaiHieuXe"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiHieuXe", maloai)
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
                    Return New Result(False, "Lấy tất cả Xe theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_HoTen(TenKH As String, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and [tblKHACHHANG].[TenKH] like '%' + @TenKH + '%'"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
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
                    Return New Result(False, "Lấy tất cả Xe theo tên khách hàng  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_TienNo(TienNo As Decimal, ByRef listXe As List(Of KhachHangXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " Select BienSoXe, MaLoaiHieuXe, NgayTiepNhan, tblXE.MaKH,TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] And [tblKHACHHANG].[TienNo] = @TienNo"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
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
                    Return New Result(False, "Lấy tất cả Xe theo tiền nợ không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(KhachHangXe As KhachHangXeDTO) As Result

        Dim query As String = String.Empty

        query &= " update [tblXE] SET"
        query &= " [MaLoaiHieuXe] = @MaLoaiHieuXe "
        query &= " ,[NgayTiepNhan] = @NgayTiepNhan"
        query &= " where [BienSoXe] = @BienSoXe"

        query &= " update [tblKHACHHANG] SET"
        query &= " [TenKH] =  @TenKH"
        query &= " ,[DiaChi] = @DiaChi"
        query &= " ,[DienThoai] = @DienThoai"
        query &= " ,[TienNo] = @TienNo"
        query &= " where [MaKH] = @MaKH"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@BienSoXe", KhachHangXe.BienSo1)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", KhachHangXe.LoaiHieuXe1)
                    .Parameters.AddWithValue("@NgayTiepNhan", KhachHangXe.NgayTiepNhan1)
                    .Parameters.AddWithValue("@TenKH", KhachHangXe.HoTen1)
                    .Parameters.AddWithValue("@DiaChi", KhachHangXe.DiaChi1)
                    .Parameters.AddWithValue("@DienThoai", KhachHangXe.SoDienThoai1)
                    .Parameters.AddWithValue("@TienNo", KhachHangXe.SoTienNo1)
                    .Parameters.AddWithValue("@MaKH", KhachHangXe.MaKH1)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(KhachHangXe As KhachHangXeDTO) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblXE] WHERE [BienSoXe] = @BienSoXe and [MaKH] = @MaKH"
        query &= " DELETE FROM [tblKHACHHANG] WHERE [MaKH] = @MaKH "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BienSoXe", KhachHangXe.BienSo1)
                    .Parameters.AddWithValue("@MaKH", KhachHangXe.MaKH1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function

End Class
