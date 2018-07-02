Imports System.Data.SqlClient
Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class frmThemXe

    Private Xe_BUS As XeBUS
    Private LoaiHieuXe_BUS As LoaiHieuXeBUS  'Khai bao cac bien lop bus
    Private KhachHang_BUS As KhachHangBUS

    Private Sub frmThemXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dpNgayTiepNhan.CustomFormat = "dd/MM/yyyy" 'Format Ngay tiếp nhận
        dpNgayTiepNhan.Format = DateTimePickerFormat.Custom

        ' Load kiem tra lop bus
        LoaiHieuXe_BUS = New LoaiHieuXeBUS()
        LoadListXe()
        KhachHang_BUS = New KhachHangBUS()
        Xe_BUS = New XeBUS()


        ' Load Loai hieu Xe list
        Dim listLoaiHieuXe = New List(Of LoaiHieuXeDTO)
        Dim result As Result
        result = LoaiHieuXe_BUS.selectAll(listLoaiHieuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If

        'Do du lieu vao combonox
        cbLoaiHieuXe.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbLoaiHieuXe.DisplayMember = "TenHieuXe"
        cbLoaiHieuXe.ValueMember = "MaHieuXe"

        'Phát sinh mã khách hàng
        Dim nextMaKH = "GR000001"
        result = KhachHang_BUS.buidlMaKH(nextMaKH)
        If (result.FlagResult = True) Then
            txtMaKhachHang.Text = nextMaKH
        End If

        Dim ThamSo_DTO As New ThamSoDTO()

        Dim thamsoBUS As New ThamSo_BUS

        thamsoBUS.SelectThamSo(ThamSo_DTO)
        lbSoXeToiDa.Text = ThamSo_DTO.SoXeToiDa.ToString()

    End Sub

    Private Sub LoadListXe()

        Xe_BUS = New XeBUS()
        Dim dtXe As DataTable = New DataTable() 'Load Bang Xe

        dtXe = Xe_BUS.Show()
        dgvThemXe.DataSource = dtXe

    End Sub

    Private Sub btnThemXe_Click(sender As Object, e As EventArgs) Handles btnThemXe.Click


        Dim Xe_DTO As XeDTO 'Khai báo biến DTO để lấy dữ liệu từ GUI
        Xe_DTO = New XeDTO()
        Dim KhachHang_DTO As KhachHangDTO
        KhachHang_DTO = New KhachHangDTO()

        Xe_DTO.BienSo = txtBienSoXe.Text ' Gán giá trị vào GUI
        Xe_DTO.LoaiHieuXe = Convert.ToInt32(cbLoaiHieuXe.SelectedValue)
        Xe_DTO.NgayTiepNhan = dpNgayTiepNhan.Value
        Xe_DTO.MaKH = txtMaKhachHang.Text

        KhachHang_DTO.MaKH = txtMaKhachHang.Text
        KhachHang_DTO.HoTen = txtTenKH.Text
        KhachHang_DTO.DiaChi = txtDiaChiKhachHang.Text
        KhachHang_DTO.SoDienThoai = txtSoDT.Text

        'Kiem tra các thông tin  của khách hàng khi nhập dữ liệu vào
        Try
            KhachHang_DTO.SoTienNo = Convert.ToInt32(txtTienNo.Text)
        Catch ex As Exception
            MessageBox.Show("Tiền nợ của khách hàng của khách hàng chưa đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End Try

        KhachHang_BUS = New KhachHangBUS()
        Xe_BUS = New XeBUS()

        If (Xe_BUS.isValidLicensePlate(Xe_DTO) = False) Then 'Kiểm tra dữ liệu nhập từ lớp GUI
            MessageBox.Show("Biển Số  không đúng")
            txtBienSoXe.Focus()
            Return
        End If

        If (KhachHang_BUS.isValidName(KhachHang_DTO) = False) Then
            MessageBox.Show("Họ tên  không đúng")
            txtTenKH.Focus()
            Return
        End If

        If (KhachHang_BUS.isValidAddress(KhachHang_DTO) = False) Then
            MessageBox.Show("Địa chỉ không đúng")
            txtDiaChiKH.Focus()
            Return
        End If

        If (KhachHang_BUS.isValidPhone(KhachHang_DTO) = False) Then
            MessageBox.Show("Số Điện Thoại Không đúng")
            txtSoDT.Focus()
            Return
        End If

        If (KhachHang_BUS.isValidThebalance(KhachHang_DTO) = False) Then
            MessageBox.Show("Số Tiền Không đúng")
            txtTienNo.Focus()
            Return
        End If

        If Xe_BUS.Check(Xe_DTO) = False Then
            MessageBox.Show("Vui lòng thay đổi ngày tiếp nhận ", "NGÀY TIẾP NHẬN ĐÃ ĐỦ XE", MessageBoxButtons.OKCancel)
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

        If result.FlagResult = True Then

            result = KhachHang_BUS.insert(KhachHang_DTO) 'Thực hiện Insert Thông qua kiểm tra từ lớp BUS
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Khach Hang thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            End If

        Dim nextMaKH = "GR000001"
        result = KhachHang_BUS.buidlMaKH(nextMaKH)
        If (result.FlagResult = True) Then
            txtMaKhachHang.Text = nextMaKH
        End If

            LoadListXe()

        End If


    End Sub

    Private Sub bntDong_Click(sender As Object, e As EventArgs) Handles bntDong.Click

        Me.Close()

    End Sub

End Class