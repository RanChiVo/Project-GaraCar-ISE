Imports System.Data.SqlClient
Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class frmThemXe

    Private Xe_BUS As XeBUS
    Private LoaiHieuXe_BUS As LoaiHieuXeBUS  'Khai bao cac bien lop bus
<<<<<<< HEAD
=======

>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    Private KhachHang_BUS As KhachHangBUS

    Private Sub frmThemXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

<<<<<<< HEAD
        dpNgayTiepNhan.CustomFormat = "dd/MM/yyyy" 'Format Ngay tiếp nhận
        dpNgayTiepNhan.Format = DateTimePickerFormat.Custom

        ' Load kiem tra lop bus
        LoaiHieuXe_BUS = New LoaiHieuXeBUS()
        LoadListXe()
        KhachHang_BUS = New KhachHangBUS()
        Xe_BUS = New XeBUS()


        ' Load Loai hieu Xe list
=======

        dtpNgayTiepNhan.CustomFormat = "dd/MM/yyyy" 'Format Ngay tiếp nhận
        dtpNgayTiepNhan.Format = DateTimePickerFormat.Custom

        Xe_BUS = New XeBUS() ' Load kiem tra lop bus
        LoaiHieuXe_BUS = New LoaiHieuXeBUS()

        Dim dtXe As DataTable = New DataTable() 'Load Bang Xe
        dtXe = Xe_BUS.Show()
        dgvListXe.DataSource = dtXe

        ' Load LoaiHocSinh list
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Dim listLoaiHieuXe = New List(Of LoaiHieuXeDTO)
        Dim result As Result
        result = LoaiHieuXe_BUS.selectAll(listLoaiHieuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
<<<<<<< HEAD

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
=======
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
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Catch ex As Exception
            MessageBox.Show("Tiền nợ của khách hàng của khách hàng chưa đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End Try
<<<<<<< HEAD

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

=======
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
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        result = Xe_BUS.insert(Xe_DTO) 'Thực hiện Insert Thông qua kiểm tra từ lớp BUS
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Thêm Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

<<<<<<< HEAD
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

=======
        Dim dtXe As DataTable = New DataTable() 'Load Bang Xe
        dtXe = Xe_BUS.Show()
        dgvListXe.DataSource = dtXe

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    End Sub

End Class