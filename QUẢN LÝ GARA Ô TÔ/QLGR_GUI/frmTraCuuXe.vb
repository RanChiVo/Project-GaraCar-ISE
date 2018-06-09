Imports System.Data.SqlClient
Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility


Public Class fmrTraCuuXe

    Dim connection As New SqlConnection("Server = DESKTOP-KG90A2I; Database = QLGR4; Integrated Security = true")

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachXe.CellContentClick

    End Sub

    Private Sub fmrTraCuuXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData()
    End Sub


    Public Sub FilterData()


        Dim searchQuery As String = "SELECT tblXE.BienSoXe, tblXE.MaLoaiHieuXe, tblKHACHHANG.TenKH,tblKHACHHANG.TienNo
        From tblXE,tblKHACHHANG WHERE tblXE.MaKH = tblKHACHHANG.MaKh"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim Table As New DataTable()


        Adapter.Fill(Table)

        dgvDanhSachXe.DataSource = Table



    End Sub

    Private Sub Search()
        Dim dt As DataTable = New DataTable()

        If (txtBienSo.Text.Length > 0) Then
            Dim query1 As String = "Select * from tblXE  WHERE  tblXE.BienSoXe like '%" & txtBienSo.Text & "%'"
            Dim sda As SqlDataAdapter = New SqlDataAdapter(query1, connection)
            sda.Fill(dt)

        ElseIf (txtHoTen.Text.Length > 0) Then
            Dim query1 As String = "Select tblXE.BienSoXe, tblXE.MaLoaiHieuXe, tblKHACHHANG.TenKH,tblKHACHHANG.TienNo from tblXE, tblKHACHHANG WHERE (tblXE.MaKH = tblKHACHHANG.MaKH) and tblKHACHHANG.TenKH like '%" & txtHoTen.Text & "%'"
            Dim sda As SqlDataAdapter = New SqlDataAdapter(query1, connection)
            sda.Fill(dt)
        ElseIf (txtTienNo.Text.Length > 0) Then
            Dim query1 As String = "Select tblXE.BienSoXe, tblXE.MaLoaiHieuXe, tblKHACHHANG.TenKH,tblKHACHHANG.TienNo from tblXE, tblKHACHHANG WHERE (tblXE.MaKH = tblKHACHHANG.MaKH) and tblXE.TienNo like '%" & txtTienNo.Text & "%'"
            Dim sda As SqlDataAdapter = New SqlDataAdapter(query1, connection)




        End If
        dgvDanhSachXe.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Search()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub cbMaLoaiHieuXe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaLoaiHieuXe.SelectedIndexChanged

        txtBienSo.Text = ""
        txtHoTen.Text = ""
        txtTienNo.Text = ""
        Search()
    End Sub

    Private Sub txtBienSo_TextChanged(sender As Object, e As EventArgs) Handles txtBienSo.TextChanged
        txtTienNo.Text = " "
        txtHoTen.Text = " "
        cbMaLoaiHieuXe.SelectedText = " "
        Search()

    End Sub

    Private Sub txtTienNo_TextChanged(sender As Object, e As EventArgs) Handles txtTienNo.TextChanged
        txtBienSo.Text = " "
        txtHoTen.Text = " "
        cbMaLoaiHieuXe.SelectedText = " "
        Search()
    End Sub

    Private Sub txtHoTen_TextChanged(sender As Object, e As EventArgs) Handles txtHoTen.TextChanged
        txtTienNo.Text = " "
        txtBienSo.Text = " "
        cbMaLoaiHieuXe.SelectedText = " "
        Search()
    End Sub
End Class