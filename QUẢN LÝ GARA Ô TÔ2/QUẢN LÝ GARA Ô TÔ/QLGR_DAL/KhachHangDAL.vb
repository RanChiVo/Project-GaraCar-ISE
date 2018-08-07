
Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility


Public Class KhachHangDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaKH(ByRef nextMaKH As String) As Result 'ex: 18222229

        Dim query As String = String.Empty
        query &= "Select TOP 1[MaKH] "     'FIX THIS
        query &= "From [tblKHACHHANG] "            'FIX THIS
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

    Public Function insert(KhachHang_DTO As KhachHangDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblKHACHHANG] ([MaKH], [TenKH],[DiaChi],[DienThoai],[TienNo])"
        query &= "VALUES (@MaKH, @TenKH, @DiaChi, @DienThoai, @TienNo)"

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

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


End Class
