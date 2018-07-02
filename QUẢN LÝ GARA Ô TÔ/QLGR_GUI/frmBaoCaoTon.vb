

Public Class frmBaoCaoTon

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim crystalTon As New CrystalRPBAOCAOTON()

            BaocaotonTableAdapter1.Fill(QlgrDataSet1.BAOCAOTON, cbThang.Text, txtNam.Text)

            crystalTon.Database.Tables(0).SetDataSource(QlgrDataSet1)

            CrystalReportViewer1.ReportSource = crystalTon

        Catch ex As Exception

        End Try

    End Sub

End Class