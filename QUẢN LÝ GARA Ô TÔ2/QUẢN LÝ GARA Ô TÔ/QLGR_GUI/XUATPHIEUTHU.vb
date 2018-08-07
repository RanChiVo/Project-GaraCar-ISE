Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class XUATPHIEUTHU

    Public MaPhieuThu As String


    Private Sub XUATPHIEUTHU_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim crytalPT As New CRYRPLAPPHIEUTHUTIEN()

        PhieuthutienTableAdapter1.Fill(QlgrDataSet1.PHIEUTHUTIEN, MaPhieuThu)

        crytalPT.Database.Tables(0).SetDataSource(QlgrDataSet1)

        CrystalReportViewer1.ReportSource = crytalPT

    End Sub

End Class