

Public Class Lapphieusuachua

    Public Maphieusuachua As String

    Private Sub Lapphieusuachua_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim crystalreport As New CrystalRPLAPPHIEUSUACHUA()

            PhieusuachuaTableAdapter1.Fill(QlgrDataSet1.PHIEUSUACHUA, Maphieusuachua)

            crystalreport.Database.Tables(0).SetDataSource(QlgrDataSet1)

            CrystalReportViewer1.ReportSource = crystalreport

        Catch ex As Exception

        End Try

    End Sub

End Class