

Public Class frmBaoCaoTon

    Private Sub frmBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim crystalTon As New CrystalRPBAOCAOTON()

        BaocaotonTableAdapter1.Fill(QlgrDataSet1.BAOCAOTON, cbThang.Text, txtNam.Text)

        crystalTon.Database.Tables(0).SetDataSource(QlgrDataSet1)

        CrystalReportViewer1.ReportSource = crystalTon

    End Sub

End Class