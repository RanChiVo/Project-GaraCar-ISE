Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility


Public Class PhieuThuTienDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaPhieuThuTien(ByRef nextPhieuThuTien As String) As Result 'ex: 18222229

        Dim query As String = String.Empty
        query &= "Select TOP 1[MaPhieuThuTien] "     'FIX THIS
        query &= "From [tblPHIEUTHUTIEN] "            'FIX THIS
        query &= "Order By [MaPhieuThuTien] DESC "    'FIX THIS

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
                            idOnDB = reader("MaPhieuThuTien")   'FIX THIS
                        End While
                    Else
                        nextPhieuThuTien = "PT000001"
                        Return New Result(True)
                    End If
                    idOnDB = (Integer.Parse(idOnDB.Remove(0, 2)) + 1).ToString()

                    While (idOnDB.Length() < 6)
                        idOnDB = "0" + idOnDB
                    End While

                    nextPhieuThuTien = "PT" + idOnDB

                Catch ex As Exception
                    conn.Close()
                    nextPhieuThuTien = "PT000001"
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(PhieuThuTien_DTO As PhieuThuTienDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblPHIEUTHUTIEN] ([MaPhieuThuTien], [MaPhieuSuaChua], [NgayThuTien], [SoTienThu])"
        query &= "VALUES (@MaPhieuThuTien,@MaPhieuSuaChua,@NgayThuTien, @SoTienThu)"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuThuTien", PhieuThuTien_DTO.MaPhieuThuTien)
                    .Parameters.AddWithValue("@MaPhieuSuaChua", PhieuThuTien_DTO.MaPhieuSuaChua)
                    .Parameters.AddWithValue("@NgayThuTien", PhieuThuTien_DTO.NgayThuTien)
                    .Parameters.AddWithValue("@SoTienThu", PhieuThuTien_DTO.SoTienThu)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm phiếu thu tiền không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function SelectThongTinKH(MaPhieuSuaChua As Integer, ByRef KhachHangXe_DTO As KhachHangXeDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT [tblXE].[BienSoXe], [tblXE].[MaKH], TenKH , DienThoai, TienNo"
        query &= " FROM [tblXE], [tblKHACHHANG], [tblPHIEUSUACHUA]"
        query &= " WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] and [tblPHIEUSUACHUA].[BienSoXe] = [tblXE].[BienSoXe]"
        query &= " and [tblPHIEUSUACHUA].[MaPhieuSuaChua] = @MaPhieuSuaChua"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand

                With comm
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Connection = conn
                    .Parameters.AddWithValue("@MaPhieuSuaChua", MaPhieuSuaChua)

                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader
                    If reader.HasRows Then
                        reader.Read()

                        With KhachHangXe_DTO

                            .BienSo1 = reader("BienSoXe")
                            .MaKH1 = reader("MaKH")
                            .HoTen1 = reader("TenKH")
                            .SoDienThoai1 = reader("DienThoai")
                            .SoTienNo1 = reader("TienNo")

                        End With

                    End If
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Lấy thông tin khách hàng thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try


            End Using
        End Using

        Return New Result(True)


    End Function

    Public Function SelectTienSuaChua(MaPhieuSuaChua As Integer, ByRef PhieuSuaChua_DTO As PhieuSuaChuaDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT ThanhTien"
        query &= " FROM  [tblPHIEUSUACHUA]"
        query &= " WHERE MaPhieuSuaChua = @MaPhieuSuaChua"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand

                With comm
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Connection = conn
                    .Parameters.AddWithValue("@MaPhieuSuaChua", MaPhieuSuaChua)

                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader
                    If reader.HasRows Then
                        reader.Read()

                        With PhieuSuaChua_DTO


                            .ThanhTien = reader("ThanhTien")

                        End With

                    End If
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Lay Thanh tien thanh cong!", ex.Message)
                Finally
                    conn.Close()
                End Try


            End Using
        End Using

        Return New Result(True)


    End Function



    Public Function updateSoNo(SoNoMoi As String, KhachHang As KhachHangDTO) As Result

        Dim query As String = String.Empty

        query &= " update [tblKHACHHANG] SET"
        query &= " [TienNo] = @TienNo"
        query &= " where [MaKH] = @MaKH"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query

                    .Parameters.AddWithValue("@TienNo", SoNoMoi)
                    .Parameters.AddWithValue("@MaKH", KhachHang.MaKH)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Số nợ mới của khách mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
