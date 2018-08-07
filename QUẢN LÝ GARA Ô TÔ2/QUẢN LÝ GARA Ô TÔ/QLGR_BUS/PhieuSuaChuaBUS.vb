Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class PhieuSuaChuaBUS
    Private phieuSuaChuaDAL As PhieuSuaChuaDAL

    Public Sub New()
        phieuSuaChuaDAL = New PhieuSuaChuaDAL()
    End Sub

    Public Sub New(connectionString As String)
        phieuSuaChuaDAL = New PhieuSuaChuaDAL(connectionString)
    End Sub

    Public Function insertPSC(psc As PhieuSuaChuaDTO) As Result
        Return phieuSuaChuaDAL.insertPSC(psc)
    End Function

    Public Function insertCTPSC(ctpsc As ChiTietPhieuSuaChuaDTO) As Result
        Return phieuSuaChuaDAL.insertCTPSC(ctpsc)
    End Function

    Public Function deleteCTPSC(ctpsc As ChiTietPhieuSuaChuaDTO) As Result
        Return phieuSuaChuaDAL.deleteCTPSC(ctpsc)
    End Function

    Public Function updatePSC_Cascade(psc As PhieuSuaChuaDTO) As Result
        Return phieuSuaChuaDAL.updatePSC_Cascade(psc)
    End Function

    Public Function updateCTPSC_Cascade(ctpsc As ChiTietPhieuSuaChuaDTO) As Result
        Return phieuSuaChuaDAL.updateCTPSC_Cascade(ctpsc)
    End Function

    Public Function selectALL(listPSC As List(Of PhieuSuaChuaDTO)) As Result
        Return phieuSuaChuaDAL.selectALL(listPSC)
    End Function

    Public Function selectALLCTPSC_ByMaPSC(iMaPSC As Integer, listCTPSC As List(Of ChiTietPhieuSuaChuaDTO)) As Result
        Return phieuSuaChuaDAL.selectALLCTPSC_ByMaPSC(iMaPSC, listCTPSC)
    End Function

    Public Function getNextIDPSC(ByRef nextIDPSC As Integer) As Result
        Return phieuSuaChuaDAL.getNextIDPSC(nextIDPSC)
    End Function


End Class
