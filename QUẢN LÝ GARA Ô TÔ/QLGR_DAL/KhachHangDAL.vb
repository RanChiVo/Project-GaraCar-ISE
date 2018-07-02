
Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility


Public Class KhachHangDAL
    Private connectionString As String
<<<<<<< HEAD

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
=======
    Dim connection As New SqlConnection("Server = DESKTOP-KG90A2I; Database= QLGR4; Integrated Security = true")
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaKH(ByRef nextMaKH As String) As Result 'ex: 18222229

        Dim query As String = String.Empty
<<<<<<< HEAD
        query &= "Select TOP 1[MaKH] "     'FIX THIS
        query &= "From [tblKHACHHANG] "            'FIX THIS
=======
        query &= "Select TOP 1 [MaKH] "     'FIX THIS
        query &= "From [tblXE] "            'FIX THIS
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        query &= "Order By [MaKH] DESC "    'FIX THIS

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
                    Dim idOnDB As String
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaKH")   'FIX THIS
                        End While
                    Else
                        nextMaKH = "GR000001"
                        Return New Result(True)
                    End If
                    idOnDB = (Integer.Parse(idOnDB.Remove(0, 2)) + 1).ToString()

                    While (idOnDB.Length() < 6)
                        idOnDB = "0" + idOnDB
                    End While

                    nextMaKH = "GR" + idOnDB

                Catch ex As Exception
                    conn.Close()
                    nextMaKH = "GR000001"
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

<<<<<<< HEAD
    Public Function insert(KhachHang_DTO As KhachHangDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblKHACHHANG] ([MaKH], [TenKH],[DiaChi],[DienThoai],[TienNo])"
        query &= "VALUES (@MaKH, @TenKH, @DiaChi, @DienThoai, @TienNo)"
=======
    Public Function FilterData() As DataTable ' Đỗ dữ liệu
        'Dim Query As String = "Select * from tblXE WHERE CONCAT(BienSoXe, MaKH, MaLoaiHieuXe, NgayTiepNhan) like '%" & valueToSearch & "%'"

        Dim query As String = "Select BienSoXe, tblKHACHHANG.MaKH, MaLoaiHieuXe, NgayTiepNhan, TenKH, DiaChi, TienNo from tblKHACHHANG, tblXE"
        query &= " WHERE tblKHACHHANG.MaKH = tblXE.MaKH"
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

    Public Function insert(KhachHang_DTO As KhachHangDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblKHACHHANG] ([MaKH], [TenKH], [DiaChi], [DienThoai], [TienNo])"
        query &= "VALUES (@MaKH,@TenKH,@DiaChi,@DienThoai,@TienNo)"

        'get MSHS
        Dim nextMaKH = "1"
        BuildMaKH(nextMaKH)
        KhachHang_DTO.MaKH = nextMaKH
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", KhachHang_DTO.MaKH)
                    .Parameters.AddWithValue("@TenKH", KhachHang_DTO.HoTen)
                    .Parameters.AddWithValue("@DiaChi", KhachHang_DTO.DiaChi)
                    .Parameters.AddWithValue("@DienThoai", KhachHang_DTO.SoDienThoai)
                    .Parameters.AddWithValue("@TienNo", KhachHang_DTO.SoTienNo)
<<<<<<< HEAD

=======
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


    Public Function update(KhachHang_DTO As KhachHangDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblKHACHHANG] SET"
        query &= " [TenKH] = @TenKH "
        query &= " [DiaChi] = @Diachi "
        query &= " [SoDienThoai] = @SoDienThoai"
        query &= "[TienNo] = @TienNo"
        query &= "WHERE "
        query &= " [MaKH] = @MaKH "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", KhachHang_DTO.MaKH)
                    .Parameters.AddWithValue("@TenKH", KhachHang_DTO.HoTen)
                    .Parameters.AddWithValue("@DiaChi", KhachHang_DTO.DiaChi)
                    .Parameters.AddWithValue("@SoDienThoai", KhachHang_DTO.SoDienThoai)
                    .Parameters.AddWithValue("@TienNo", KhachHang_DTO.SoTienNo)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
<<<<<<< HEAD
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm khách hàng không thành công", ex.StackTrace)
=======
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listKhachHang As List(Of KhachHangDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaKH], [TenKH], [DiaChi], [SoDienThoai],[TienNo]"
        query &= " FROM [tblKHACHHANG]"


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
                        listKhachHang.Clear()
                        While reader.Read()
                            listKhachHang.Add(New KhachHangDTO(reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("SoDienThoai"), reader("TienNo")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả Khach hang không thành công", ex.StackTrace)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

<<<<<<< HEAD
=======
    Public Function selectALL_ByMaKH(iMaKH As Integer, ByRef listKhachHang As List(Of KhachHangDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaKH], [TenKH], [DiaChi], [SoDienThoai],[TienNo]"
        query &= " FROM [tblKHACHHANG]"
        query &= " WHERE "
        query &= " [MaKH] = @MaKH "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", iMaKH)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listKhachHang.Clear()
                        While reader.Read()
                            listKhachHang.Add(New KhachHangDTO(reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("SoDienThoai"), reader("TienNo")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function delete(MaKH As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblKHACHHANG] "
        query &= " WHERE "
        query &= " [MaKH] = @MaKH "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", MaKH)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d

End Class
