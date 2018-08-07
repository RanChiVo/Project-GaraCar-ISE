Imports System.Data.SqlClient
Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility


Public Class frmThemHieuXe

    Private LoaiHieuXe_BUS As LoaiHieuXeBUS

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        Dim HieuXe_DTO As LoaiHieuXeDTO
        HieuXe_DTO = New LoaiHieuXeDTO()

        '1. Mapping data from GUI control
        HieuXe_DTO.MaHieuXe = Convert.ToInt32(txtMaHieuXe.Text)
        HieuXe_DTO.TenHieuXe = txtTenHieuXe.Text


        '2. Business .....
        If (LoaiHieuXe_BUS.isValidName(HieuXe_DTO) = False) Then
            MessageBox.Show("Tên Loại hiệu xe không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenHieuXe.Focus()
            Return
        End If


        '3. Insert to DB
        Dim result As Result
        result = LoaiHieuXe_BUS.insert(HieuXe_DTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại hiệu xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenHieuXe.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = LoaiHieuXe_BUS.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaHieuXe.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Loại tiền công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm loại tiền công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        Dim frmQL_HieuXe As New fmrQLHieuXe()
        frmQLHieuXe.loadListLoaiHieuXe()

    End Sub

    Private Sub frmThemHieuXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoaiHieuXe_BUS = New LoaiHieuXeBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = LoaiHieuXe_BUS.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaHieuXe.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loai hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click

        Me.Close()

    End Sub


End Class