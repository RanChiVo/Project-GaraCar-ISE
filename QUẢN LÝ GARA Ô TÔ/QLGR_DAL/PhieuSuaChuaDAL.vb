Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class PhieuSuaChuaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextIDPSC(ByRef nextIDPSC As Integer) As Result


        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaPhieuSuaChua] "
        query &= "FROM [tblPHIEUSUACHUA] "
        query &= "ORDER BY [MaPhieuSuaChua] DESC "

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
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaPhieuSuaChua")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextIDPSC = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextIDPSC = 1
                    Return New Result(False, "Lấy ID kế tiếp của Phiếu Sữa Chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function getNextIDCTPSC(ByRef nextIDCTPSC As String) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaCTPhieuSuaChua] "
        query &= "FROM [tblCTPHIEUSUACHUA] "
        query &= "ORDER BY [MaCTPhieuSuaChua] DESC "

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
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("MaCTPhieuSuaChua")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextIDCTPSC = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextIDCTPSC = 1
                    Return New Result(False, "Lấy ID kế tiếp của Chi Tiết Phiếu Sữa Chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function

    Public Function insertPSC(psc As PhieuSuaChuaDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [dbo].[tblPHIEUSUACHUA] "
        query &= "(  [MaPhieuSuaChua] "
        query &= "  ,[BienSoXe] "
        query &= "  ,[NgaySuaChua] "
        query &= "  ,[NoiDung] "
        query &= "  ,[MaLoaiTienCong] "
        query &= "  ,[ThanhTien]) "
        query &= "VALUES "
        query &= "(   @MaPhieuSuaChua"
        query &= "   ,@BienSoXe"
        query &= "   ,@NgaySuaChua"
        query &= "   ,@NoiDung"
        query &= "   ,@MaLoaiTienCong"
        query &= "   ,@ThanhTien)"


        Dim nextIDPSC = 0
        Dim result As Result
        result = getNextIDPSC(nextIDPSC)
        If (result.FlagResult = False) Then
            Return result
        End If
        psc.MaPhieuSuaChua = nextIDPSC

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuSuaChua", psc.MaPhieuSuaChua)
                    .Parameters.AddWithValue("@BienSoXe", psc.BienSoXe)
                    .Parameters.AddWithValue("@NgaySuaChua", psc.NgaySuaChua)
                    .Parameters.AddWithValue("@NoiDung", psc.NoiDung)
                    .Parameters.AddWithValue("@MaLoaiTienCong", psc.MaLoaiTienCong)
                    .Parameters.AddWithValue("@ThanhTien", psc.ThanhTien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Phiếu Sữa Chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Them Chi tiet chuong trinh
        If (psc.ListCTPSC IsNot Nothing) Then
            If (psc.ListCTPSC.Count > 0) Then
                For Each ctpsc In psc.ListCTPSC
                    ctpsc.MaPhieuSuaChua = psc.MaPhieuSuaChua
                    result = insertCTPSC(ctpsc)
                    If (result.FlagResult = False) Then
                        Return result
                    End If
                Next

            End If
        End If
        Return New Result(True) ' thanh cong
    End Function

    Public Function insertCTPSC(ctpsc As ChiTietPhieuSuaChuaDTO) As Result

        Dim query As String = String.Empty
        query &= "  INSERT INTO [dbo].[tblCTPHIEUSUACHUA] "
        query &= "             ([MaCTPhieuSuaChua] "
        query &= "             ,[MaPhieuSuaChua] "
        query &= "             ,[MaLoaiPhuTung] "
        query &= "             ,[SoLuong]) "
        query &= "       VALUES "
        query &= "             (@MaCTPhieuSuaChua "
        query &= "             ,@MaPhieuSuaChua "
        query &= "             ,@MaLoaiPhuTung "
        query &= "             ,@SoLuong) "


        Dim nextIDCTPSC = 0
        Dim result As Result
        result = getNextIDCTPSC(nextIDCTPSC)
        If (result.FlagResult = False) Then
            Return result
        End If
        ctpsc.MaCTPhieuSuaChua = nextIDCTPSC

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaCTPhieuSuaChua", ctpsc.MaCTPhieuSuaChua)
                    .Parameters.AddWithValue("@MaPhieuSuaChua", ctpsc.MaPhieuSuaChua)
                    .Parameters.AddWithValue("@MaLoaiPhuTung", ctpsc.MaLoaiPhuTung)
                    .Parameters.AddWithValue("@SoLuong", ctpsc.SoLuong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Chi Tiết Phiếu Sữa Chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function updatePSC_Cascade(psc As PhieuSuaChuaDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblPHIEUSUACHUA] SET"
        query &= " [BienSoXe] = @BienSoXe "
        query &= " ,[NgaySuaChua] = @NgaySuaChua "
        query &= " ,[NoiDung] = @NoiDung "
        query &= " ,[MaLoaiTienCong] = @MaLoaiTienCong "
        query &= " ,[ThanhTien] = @ThanhTien "
        query &= " WHERE "
        query &= " [MaPhieuSuaChua] = @MaPhieuSuaChua "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BienSoXe", psc.BienSoXe)
                    .Parameters.AddWithValue("@NgaySuaChua", psc.NgaySuaChua)
                    .Parameters.AddWithValue("@NoiDung", psc.NoiDung)
                    .Parameters.AddWithValue("@MaLoaiTienCong", psc.MaLoaiTienCong)
                    .Parameters.AddWithValue("@ThanhTien", psc.ThanhTien)
                    .Parameters.AddWithValue("@MaPhieuSuaChua", psc.MaPhieuSuaChua)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật phần Cascade của phiếu sữa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        'Update cascade for Chi Tiết Phiếu Sữa Chữa
        Dim listCTPSConDB = New List(Of ChiTietPhieuSuaChuaDTO)
        Dim result = selectALLCTPSC_ByMaPSC(psc.MaPhieuSuaChua, listCTPSConDB)
        If (result.FlagResult = False) Then
            Return result
        End If
        Dim f = False
        For Each ctpscOnDB In listCTPSConDB
            f = False
            For Each ctpsc In psc.ListCTPSC
                If (ctpscOnDB.MaCTPhieuSuaChua = ctpsc.MaCTPhieuSuaChua) Then
                    f = True
                    Exit For
                End If
            Next
            If (f = False) Then ' record on DB is NOT found on GUI  -> Delete
                result = deleteCTPSC(ctpscOnDB)
                If (result.FlagResult = False) Then
                    Return result
                End If
            End If
        Next
        f = False
        For Each ctpsc In psc.ListCTPSC
            f = False
            For Each ctpscOnDB In listCTPSConDB
                If (ctpsc.MaCTPhieuSuaChua = ctpscOnDB.MaCTPhieuSuaChua) Then
                    f = True
                    Exit For
                End If
            Next
            If (f = False) Then ' record on GUI is NOT found on DB  -> Insert new
                ctpsc.MaPhieuSuaChua = psc.MaPhieuSuaChua
                insertCTPSC(ctpsc)
                If (result.FlagResult = False) Then
                    Return result
                End If
            Else ' Updated
                updateCTPSC_Cascade(ctpsc)
                If (result.FlagResult = False) Then
                    Return result
                End If
            End If
        Next
        Return New Result(True) ' thanh cong
    End Function

    Public Function updateCTPSC_Cascade(ctpsc As ChiTietPhieuSuaChuaDTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblCTPHIEUSUACHUA] SET"
        query &= " [MaPhieuSuaChua] = @MaPhieuSuaChua "
        query &= " ,[MaLoaiPhuTung] = @MaLoaiPhuTung "
        query &= " ,[SoLuong] = @SoLuong "
        query &= " WHERE "
        query &= " [MaCTPhieuSuaChua] = @MaCTPhieuSuaChua "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuSuaChua", ctpsc.MaPhieuSuaChua)
                    .Parameters.AddWithValue("@MaLoaiPhuTung", ctpsc.MaLoaiPhuTung)
                    .Parameters.AddWithValue("@SoLuong", ctpsc.SoLuong)
                    .Parameters.AddWithValue("@MaCTPhieuSuaChua", ctpsc.MaCTPhieuSuaChua)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Chi Tiết Chương Trình không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(listPSC As List(Of PhieuSuaChuaDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaPhieuSuaChua], [BienSoXe], [NgaySuaChua], [NoiDung], [MaLoaiTienCong], [ThanhTien]"
        query &= " FROM [tblPHIEUSUACHUA]"


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
                        listPSC.Clear()
                        While reader.Read()
                            listPSC.Add(New PhieuSuaChuaDTO(reader("MaPhieuSuaChua"), reader("BienSoXe"), reader("NgaySuaChua"), reader("NoiDung"), reader("MaLoaiTienCong"), reader("ThanhTien"), New List(Of ChiTietPhieuSuaChuaDTO)))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả Phiếu sữa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        ' select Chi Tiet Phieu Sua Chua
        For Each psc In listPSC
            Dim result = selectALLCTPSC_ByMaPSC(psc.MaPhieuSuaChua, psc.ListCTPSC)
            If (result.FlagResult = False) Then
                Return result
            End If
        Next
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALLCTPSC_ByMaPSC(iMaPSC As Integer, listCTPSC As List(Of ChiTietPhieuSuaChuaDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [tblCTPHIEUSUACHUA].[MaCTPhieuSuaChua], [tblVATTUPHUTUNG].[MaLoaiPhuTung], [tblCTPHIEUSUACHUA].[MaPhieuSuaChua], [tblCTPHIEUSUACHUA].[SoLuong], [tblVATTUPHUTUNG].[TenLoaiPhuTung], [tblVATTUPHUTUNG].[DonGia] "
        query &= " FROM [tblCTPHIEUSUACHUA], [tblVATTUPHUTUNG]"
        query &= " WHERE "
        query &= " [tblCTPHIEUSUACHUA].[MaLoaiPhuTung] = [tblVATTUPHUTUNG].[MaLoaiPhuTung]"
        query &= " AND [tblCTPHIEUSUACHUA].[MaPhieuSuaChua]= @MaPhieuSuaChua"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaPhieuSuaChua", iMaPSC)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listCTPSC.Clear()
                        While reader.Read()
                            listCTPSC.Add(New ChiTietPhieuSuaChuaDTO(reader("MaCTPhieuSuaChua"), reader("MaPhieuSuaChua"), reader("MaLoaiPhuTung"), reader("TenLoaiPhuTung"), reader("DonGia"), reader("SoLuong")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()

                    Return New Result(False, "Lấy tất cả Phiếu sữa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        Return New Result(True) ' thanh cong
    End Function

    Public Function deleteCTPSC(ctpsc As ChiTietPhieuSuaChuaDTO) As Result
        Dim query As String = String.Empty
        query &= " DELETE FROM [dbo].[tblCTPHIEUSUACHUA] "
        query &= " WHERE "
        query &= " [MaCTPhieuSuaChua] = @MaCTPhieuSuaChua "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaCTPhieuSuaChua", ctpsc.MaCTPhieuSuaChua)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Chi Tiết Phiếu sữa chữa không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        Return New Result(True) ' thanh cong
    End Function

End Class
