Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared




Public Class frmBAOCAODT


    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click

        Try

            Dim cry As New CrystalRPBAOCAODT()

            BaocaodoanhthuTableAdapter1.Fill(QlgrDataSet1.BAOCAODOANHTHU, CbThang.Text, txtNam.Text)

            cry.Database.Tables(0).SetDataSource(QlgrDataSet1)

            CrystalReportViewer1.ReportSource = cry

        Catch ex As Exception

        End Try

    End Sub

End Class