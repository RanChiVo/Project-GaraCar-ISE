Imports Utility
Imports QLGR_DTO
Imports QLGR_DAL
Public Class ThamSo_BUS


    Private thamSoDAL As ThamSoDAL

    Public Sub New()
        thamSoDAL = New ThamSoDAL
    End Sub

    Public Function SelectThamSo(ByRef ThamSo_DTO As ThamSoDTO) As Result
<<<<<<< HEAD

        Return thamSoDAL.SelectThamSo(ThamSo_DTO)

    End Function

    Public Function upsdateThamSo(ByRef ThamSo_DTO As ThamSoDTO) As Result

        Return thamSoDAL.update(ThamSo_DTO)

    End Function
=======
        Return thamSoDAL.SelectThamSo(ThamSo_DTO)
    End Function

>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d


End Class
