Imports System.Data.SqlClient
Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class frmThemXe

    Private Xe_BUS As XeBUS
    Private LoaiHieuXe_BUS As LoaiHieuXeBUS  'Khai bao cac bien lop bus

    Private KhachHang_BUS As KhachHangBUS

    Private Sub frmThemXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dtpNgayTiepNhan.CustomFormat = "dd/MM/yyyy" 'Format Ngay tiếp nhận
        dtpNgayTiepNhan.Format = DateTimePickerFormat.Custom

        Xe_BUS = New XeBUS() ' Load kiem tra lop bus
        LoaiHieuXe_BUS = New LoaiHieuXeBUS()

        Dim dtXe As DataTable = New DataTable() 'Load Bang Xe
        dtXe = Xe_BUS.Show()
        dgvListXe.DataSource = dtXe

        ' Load LoaiHocSinh list
        Dim listLoaiHieuXe = New List(Of LoaiHieuXeDTO)
        Dim result As Result
        result = LoaiHieuXe_BUS.selectAll(listLoaiHieuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbHieuXe.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXe.DisplayMember = "TenHieuXe"
        cbHieuXe.ValueMember = "MaHieuXe"


        'Dim nextMaKH = "GR000001"
        'result = KhachHang_BUS.buildMaKH(nextMaKH)
        'If (result.FlagResult = False) Then
        '    MessageBox.Show("Lấy danh tự động mã Khách hàng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    System.Console.WriteLine(result.SystemMessage)
        '    Me.Close()
        '    Return
        'End If

        'txtMaKH.Text = nextMaKH
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        Dim Xe_DTO As XeDTO 'Khai báo biến DTO để lấy dữ liệu từ GUI
        Xe_DTO = New XeDTO()

        Xe_DTO.BienSo = txtBienSo.Text ' Gán giá trị vào GUI
        Xe_DTO.LoaiHieuXe = Convert.ToInt32(cbHieuXe.SelectedValue)
        Xe_DTO.NgayTiepNhan = dtpNgayTiepNhan.Value
        Xe_DTO.HoTen = txtHoTen.Text
        Xe_DTO.DiaChi = txtDiaChiKH.Text
        Xe_DTO.SoDienThoai = txtSoDienThoai.Text
        Xe_DTO.SoTienNo = txtSoTienNo.Text

        Try
            Xe_DTO.SoTienNo = Convert.ToInt32(txtSoTienNo.Text)
        Catch ex As Exception
            MessageBox.Show("Tiền nợ của khách hàng của khách hàng chưa đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End Try
        If (Xe_BUS.isValidLicensePlate(Xe_DTO) = False) Then 'Kiểm tra dữ liệu nhập từ lớp GUI
            MessageBox.Show("Biển Số  không đúng")
            txtBienSo.Focus()
            Return
        End If
        If (Xe_BUS.isValidName(Xe_DTO) = False) Then
            MessageBox.Show("Họ tên  không đúng")
            txtHoTen.Focus()
            Return
        End If
        If (Xe_BUS.isValidAddress(Xe_DTO) = False) Then
            MessageBox.Show("Địa chỉ không đúng")
            txtHoTen.Focus()
            Return
        End If
        If (Xe_BUS.isValidPhone(Xe_DTO) = False) Then
            MessageBox.Show("Số Điện Thoại Không đúng")
            txtHoTen.Focus()
            Return
        End If
        If (Xe_BUS.isValidThebalance(Xe_DTO) = False) Then
            MessageBox.Show("Số Tiền Không đúng")
            txtHoTen.Focus()
            Return
        End If


        Dim result As Result
        result = Xe_BUS.insert(Xe_DTO) 'Thực hiện Insert Thông qua kiểm tra từ lớp BUS
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Thêm Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        Dim dtXe As DataTable = New DataTable() 'Load Bang Xe
        dtXe = Xe_BUS.Show()
        dgvListXe.DataSource = dtXe

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

End Class