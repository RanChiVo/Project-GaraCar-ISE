Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility


Public Class ThamSoDAL

    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub


    Public Function SelectThamSo(ByRef ThamSo_DTO As ThamSoDTO) As Result

        Dim query As String = "SELECT * FROM tblTHAMSO"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand

                With comm
                    .CommandText = query
                    .CommandType = CommandType.Text
                    .Connection = conn

                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader
                    If reader.HasRows Then
                        reader.Read()

                        With ThamSo_DTO

                            .SoXeToiDa = Integer.Parse(reader("SLXeToiDaMoiNgay"))

                        End With

                    End If
                Catch ex As Exception
                    conn.Close()
                    Return New Result(False, "Lấy tham số thất bại!", ex.Message)
                Finally
                    conn.Close()
                End Try


            End Using
        End Using

        Return New Result(True)


    End Function


End Class
