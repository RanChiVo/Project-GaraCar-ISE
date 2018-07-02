
Imports Dapper
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class dp

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Try
            Dim CrystalDT As New CRYSTALBAOCAODOANHTHUTHANG()

            BaocaodoanhthuTableAdapter1.Fill(QlgrDataSet1.BAOCAODOANHTHU, cbThang.Text, txtNam.Text)
            CrystalDT.Database.Tables(0).SetDataSource(QlgrDataSet1)
            CrystalReportViewer1.ReportSource = CrystalDT

        Catch ex As Exception

        End Try

    End Sub

End Class