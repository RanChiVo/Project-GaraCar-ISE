Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility


Public Class frmThemXe

    Private Xe_Bus As XeBUS
    Private LoaiHieuXe_Bus As LoaiHieuXeBUS

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Xe_DTO As XeDTO
        Xe_DTO = New XeDTO()


        Xe_DTO.BienSo = txtBienSo.Text
        Xe_DTO.LoaiHieuXe = Convert.ToInt32(cbHieuXe.SelectedValue)
        Xe_DTO.NgayTiepNhan = dtpNgayTiepNhan.Value



        If (Xe_Bus.isValidName(Xe_DTO) = False) Then
            MessageBox.Show("Biển số xe không đúng")
            txtBienSo.Focus()
            Return
        End If

        Dim result As Result
        result = Xe_Bus.insert(Xe_DTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Xe  thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtBienSo.Text = String.Empty

        Else
            MessageBox.Show("Thêm Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub fmrThemXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Xe_Bus = New XeBUS()
        LoaiHieuXe_Bus = New LoaiHieuXeBUS()


        Dim listLoaiHieuXe = New List(Of LoaiHieuXeDTO)
        Dim result As Result
        result = LoaiHieuXe_Bus.selectAll(listLoaiHieuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbHieuXe.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXe.DisplayMember = "TenLoaiHieuXe"
        cbHieuXe.ValueMember = "MaLoaiHieuXe"


    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class
