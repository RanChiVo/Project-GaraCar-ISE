﻿
Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility


Public Class LoaiHieuXeDAL

    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaLoaiHieuXe] "
        query &= "FROM [tblLOAIHIEUXE] "
        query &= "ORDER BY [MaLoaiHieuXe] DESC "

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
                            idOnDB = reader("MaLoaiHieuXe")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
<<<<<<< HEAD
                    Return New Result(False, "Lấy ID kế tiếp của Loại hiệu Xe không thành công", ex.StackTrace)
=======
                    Return New Result(False, "Lấy ID kế tiếp của Loại Xe không thành công", ex.StackTrace)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLOAIHIEUXE] ([MaLoaiHieuXe], [TenLoaiHieuXe])"
        query &= "VALUES (@MaLoaiHieuXe,@TenLoaiHieuXe)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        LoaiHieuXe_DTO.MaHieuXe = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiHieuXe", LoaiHieuXe_DTO.MaHieuXe)
                    .Parameters.AddWithValue("@TenLoaiHieuXe", LoaiHieuXe_DTO.TenHieuXe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Hieu Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblLOAIHIEUXE] SET"
        query &= " [TenLoaiHieuXe] = @TenLoaiHieuXe"
<<<<<<< HEAD
        query &= " WHERE "
=======
        query &= "WHERE "
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        query &= " [MaLoaiHieuXe] = @MaLoaiHieuXe"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiHieuXe", LoaiHieuXe_DTO.MaHieuXe)
                    .Parameters.AddWithValue("@TenLoaiHieuXe", LoaiHieuXe_DTO.TenHieuXe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listLoaiHieuXe As List(Of LoaiHieuXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLoaiHieuXe], [TenLoaiHieuXe]"
        query &= " FROM [tblLOAIHIEUXE]"


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
                        listLoaiHieuXe.Clear()
                        While reader.Read()
                            listLoaiHieuXe.Add(New LoaiHieuXeDTO(reader("MaLoaiHieuXe"), reader("TenLoaiHieuXe")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(MaLoaiHieuXe As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblLOAIHIEUXE] "
        query &= " WHERE "
        query &= " [MaLoaiHieuXe] = @MaLoaiHieuXe"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiHieuXe", MaLoaiHieuXe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


End Class
