Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility

Public Class XeDAL

    Private connectionString As String
    Dim connection As New SqlConnection("Server = DESKTOP-KG90A2I; Database= QLGR4; Integrated Security = true")
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub




    Public Function FilterData() As DataTable ' Đỗ dữ liệu

        Dim query As String = "Select* FROM tblXE"
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

    'Public Function BuildMaKH(ByRef nextMaKH As String) As Result 'ex: 18222229

    '    Dim query As String = String.Empty
    '    query &= "Select TOP 1 [MaKH] "     'FIX THIS
    '    query &= "From [tblXE] "            'FIX THIS
    '    query &= "Order By [MaKH] DESC "    'FIX THIS

    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '            End With
    '            Try
    '                conn.Open()
    '                Dim reader As SqlDataReader
    '                reader = comm.ExecuteReader()
    '                Dim idOnDB As String
    '                idOnDB = Nothing
    '                If reader.HasRows = True Then
    '                    While reader.Read()
    '                        idOnDB = reader("MaKH")   'FIX THIS
    '                    End While
    '                Else
    '                    nextMaKH = "GR000001"
    '                    Return New Result(True)
    '                End If
    '                idOnDB = (Integer.Parse(idOnDB.Remove(0, 2)) + 1).ToString()

    '                While (idOnDB.Length() < 6)
    '                    idOnDB = "0" + idOnDB
    '                End While

    '                nextMaKH = "GR" + idOnDB

    '            Catch ex As Exception
    '                conn.Close()
    '                nextMaKH = "GR000001"
    '                Return New Result(False)
    '            End Try
    '        End Using
    '    End Using
    '    Return New Result(True) ' thanh cong
    'End Function

    Public Function InsertXe(xe As XeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblXE] ([BienSoXe],[MaLoaiHieuXe], [NgayTiepNhan], [TenKH], [DiaChi], [DienThoai], [TienNo])"
        query &= "VALUES (@BienSoXe,@MaKH,@MaLoaiHieuXe,@NgayTiepNhan)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BienSoXe", xe.BienSo)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", xe.LoaiHieuXe)
                    .Parameters.AddWithValue("@NgayTiepNhan", xe.NgayTiepNhan)
                    .Parameters.AddWithValue("@TenKH", xe.HoTen)
                    .Parameters.AddWithValue("@DiaChi", xe.DiaChi)
                    .Parameters.AddWithValue("@DienThoai", xe.SoDienThoai)
                    .Parameters.AddWithValue("@TienNo", xe.SoTienNo)

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

    Public Function selectALLXe(listXe As List(Of XeDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [BienSoXe], [MaKH], [MaLoaiHieuXe], [NgayTiepNhan],[TenKH], [DiaChi], [SoDienThoai],[TienNo]"
        query &= "FROM [tblXE]"

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
                            listXe.Add(New XeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"), reader("TenKH"), reader("DiaChi"), reader("SoDienThoai"), reader("TienNo")))
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

    Public Function selectALL_ByMaKH(iMaKH As Integer, ByRef listXe As List(Of XeDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [BienSoXe], [MaLoaiHieuXe], [NgayTiepNhan]"
        query &= " FROM [tblXE] "
        query &= "     ,[tblKHACHHANG] "
        query &= "     [tblXE].[MaKH] = [tblKHACHHANG].[MaKH]"
        query &= " WHERE "
        query &= "[tblXe].[MaKH] = @MaKH"


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
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New XeDTO(reader("BienSoXe"), reader("LoaiHieuXe"), reader("NgayTiepNhan"), reader("TenKH"), reader("DiaChi"), reader("SoDienThoai"), reader("TienNo")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Xe theo mã khách hàng  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByHieuXe(ByVal maloai As Integer, ByRef listXe As List(Of XeDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [BienSoXe],[MaKH], [MaLoaiHieuXe], [NgayTiepNhan]"
        query &= "FROM [tblXE] "
        query &= "WHERE [MaLoaiHieuXe] = @MaLoaiHieuXe"

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
                            listXe.Add(New XeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan"), reader("TenKH"), reader("DiaChi"), reader("SoDienThoai"), reader("TienNo")))
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

    Public Function update(Xe As XeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblXE] SET"
        query &= " [MaLoaiHieuXe] = @MaLoaiHieuXe "
        query &= " [NgayTiepNhan] = @NgayTiepNhan"
        query &= " WHERE "
        query &= " [BienSoXe] = @BienSoXe"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@MaLoaiHieuXe", Xe.LoaiHieuXe)
                    .Parameters.AddWithValue("@NgayTiepNhan", Xe.NgayTiepNhan)

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

    Public Function delete(BienSo As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblXE] "
        query &= " WHERE "
        query &= " [BienSoXe] = @BienSoXe "

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
