Imports Utility
Imports QLGR_DTO
Imports QLGR_DAL
Public Class ThamSo_BUS


    Private thamSoDAL As ThamSoDAL

    Public Sub New()
        thamSoDAL = New ThamSoDAL
    End Sub

    Public Function SelectThamSo(ByRef ThamSo_DTO As ThamSoDTO) As Result
        Return thamSoDAL.SelectThamSo(ThamSo_DTO)
    End Function



End Class
