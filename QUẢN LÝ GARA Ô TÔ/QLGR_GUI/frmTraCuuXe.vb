Imports System.Data.SqlClient
Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class fmrtracuuxe

    Private Xe_BUS As XeBUS
    Private LoaiHieuXe_BUS As LoaiHieuXeBUS
    Private KhachHang_BUS As KhachHangBUS
    Dim connection As New SqlConnection("Server = DESKTOP-0354T0B; Database= QLGR; Integrated Security = true")

    Private Sub fmrtracuuxe_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'LOAD FORM

        LoaiHieuXe_BUS = New LoaiHieuXeBUS()

        ' Load Hieu xe list
        Dim listLoaiHieuXe = New List(Of LoaiHieuXeDTO)
        Dim result As Result

        result = LoaiHieuXe_BUS.selectAll(listLoaiHieuXe)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbMaLoaiHieuXe.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbMaLoaiHieuXe.DisplayMember = "TenHieuXe"
        cbMaLoaiHieuXe.ValueMember = "MaHieuXe"

    End Sub

    Private Sub loadListXe(MaLoaiHieuXe As String) 'LOAD THEO HIỆU XE

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByHieuXe(MaLoaiHieuXe, listXe)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Xe theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        DrawGridView(listXe)

    End Sub

    Private Sub loadListXe() 'LOAD TẤT CẢ XE

        Dim listKhachHangXe = New List(Of KhachHangXeDTO)
        Dim result As Result
        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectAll(listKhachHangXe) ''Load tất cả

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If

        DrawGridView(listKhachHangXe)

    End Sub

    Private Sub DrawGridView(ByRef listXe As List(Of KhachHangXeDTO)) 'XU LY DATAGRIDVIEW

        'dgvListXe.Columns.Clear()
        'dgvListXe.DataSource = Nothing

        'dgvListXe.AutoGenerateColumns = False
        'dgvListXe.AllowUserToAddRows = False
        dgvListXe.DataSource = listXe

        Dim clBienSo = New DataGridViewTextBoxColumn()
        clBienSo.Name = "BienSo1"
        clBienSo.HeaderText = "Biển Số"
        clBienSo.DataPropertyName = "BienSo1"
        dgvListXe.Columns.Add(clBienSo)

        Dim clLoaiHieuXe = New DataGridViewTextBoxColumn()
        clLoaiHieuXe.Name = "LoaiHieuXe1"
        clLoaiHieuXe.HeaderText = "Mã Hiệu Xe"
        clLoaiHieuXe.DataPropertyName = "LoaiHieuXe1"
        dgvListXe.Columns.Add(clLoaiHieuXe)

        Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        clNgayTiepNhan.Name = "NgayTiepNhan1"
        clNgayTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgayTiepNhan.DataPropertyName = "NgayTiepNhan1"
        dgvListXe.Columns.Add(clNgayTiepNhan)

        Dim clMaKH = New DataGridViewTextBoxColumn()
        clMaKH.Name = "MaKH1"
        clMaKH.HeaderText = "Mã Khách Hàng"
        clMaKH.DataPropertyName = "MaKH1"
        dgvListXe.Columns.Add(clMaKH)

        Dim clHoTenKH = New DataGridViewTextBoxColumn()
        clHoTenKH.Name = "HoTen1"
        clHoTenKH.HeaderText = "Họ Tên"
        clHoTenKH.DataPropertyName = "HoTen1"
        dgvListXe.Columns.Add(clHoTenKH)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi1"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi1"
        dgvListXe.Columns.Add(clDiaChi)

        Dim clSoDienThoai = New DataGridViewTextBoxColumn()
        clSoDienThoai.Name = "SoDienThoai1"
        clSoDienThoai.HeaderText = "Số Điện Thoại"
        clSoDienThoai.DataPropertyName = "SoDienThoai1"
        dgvListXe.Columns.Add(clSoDienThoai)

        Dim clSoTienNo = New DataGridViewTextBoxColumn()
        clSoTienNo.Name = "SoTienNo1"
        clSoTienNo.HeaderText = "Số Tiền Nợ"
        clSoTienNo.DataPropertyName = "SoTienNo1"
        dgvListXe.Columns.Add(clSoTienNo)

        ' dgvListXe.ResumeLayout()

    End Sub

    '1
    Private Sub loadListXeTienNo(TienNo As Decimal) 'LOAD LIST XE THEO TIỀN NỢ

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByTienNo(TienNo, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo Tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)

    End Sub

    Private Sub loadListXeBienSo(BienSo As String) 'LOAD LIST XE THEO BIỂN SỐ

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByBienSo(BienSo, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo biển số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If

        DrawGridView(listXe)

    End Sub

    Private Sub loadListXeHoTen(HoTen As String) 'LOAD LIST XE THEO BIỂN SỐ

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByHoTen(HoTen, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo biển số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)

    End Sub

    '2
    Private Sub loadListXeHoTenBienSo(BienSo As String, HoTen As String) 'LOAD LIST XE THEO BIỂN SỐ + HO TEN

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByBienSoHoTen(BienSo, HoTen, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo biển số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)

    End Sub

    Private Sub loadListXeBienSoMaLoaiHieuXe(BienSo As String, MaLoaiHieuXe As Integer) 'LOAD LIST XE THEO BIỂN SỐ + HIEUXE

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByBienSoMaLoaiHieuXe(BienSo, MaLoaiHieuXe, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo biển số và mã Loại hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)

    End Sub

    Private Sub loadListXeBienSoTienNo(BienSo As String, TienNo As Decimal) 'LOAD LIST XE THEO BIỂN SỐ + TIENNO

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByBienSoTienNo(BienSo, TienNo, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo biển số và tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)

    End Sub

    '23
    Private Sub loadListXeHoTenMaLoaiHieuXe(HoTen As String, MaLoaiHieuXe As Integer) 'LOAD LIST XE THEO HOTEN + HIEUXE

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByHoTenHieuXe(HoTen, MaLoaiHieuXe, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo họ tên và mã Loại hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)

    End Sub

    '24
    Private Sub loadListXeHoTenTienNo(HoTen As String, TienNo As Decimal) 'LOAD LIST XE THEO HOTEN + HIEUXE

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByHoTenTienNo(HoTen, TienNo, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo họ tên và tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)

    End Sub

    '34
    Private Sub loadListXeHieuXeTienNo(MaLoaiHieuXe As Integer, TienNo As Decimal) 'LOAD LIST XE THEO HOTEN + HIEUXE

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByHieuXeTienNo(MaLoaiHieuXe, TienNo, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo hiệu xe và tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)

    End Sub

    '123
    Private Sub loadListXeBienSoHoTenHieuXe(BienSo As String, HoTen As String, MaLoaiHieuXe As Integer) 'LOAD LIST XE THEO HOTEN + HIEUXE

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByBienSoHoTenHieuXe(BienSo, HoTen, MaLoaiHieuXe, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo hiệu xe và tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)
    End Sub

    '124
    Private Sub loadListXeBienSoHoTenTienNo(BienSo As String, HoTen As String, TienNo As Decimal) 'LOAD LIST XE THEO HOTEN + HIEUXE

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByBienSoHoTenTienNo(BienSo, HoTen, TienNo, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo Biển số ,họ tên  và tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)
    End Sub

    '134
    Private Sub loadListXeBienSoHieuXeTienNo(BienSo As String, MaLoaiHieuXe As Integer, TienNo As Decimal) 'LOAD LIST XE THEO HOTEN + HIEUXE

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByBienSoHieuXeTienNo(BienSo, MaLoaiHieuXe, TienNo, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo Biển số ,hiệu xe  và tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)
    End Sub

    '234
    Private Sub loadListXeHoTenHieuXeTienNo(HoTen As String, MaLoaiHieuXe As Integer, TienNo As Decimal) 'LOAD LIST XE THEO HOTEN + HIEUXE

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByHoTenHieuXeTienNo(HoTen, MaLoaiHieuXe, TienNo, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo Biển số ,hiệu xe  và tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)
    End Sub

    '1234
    Private Sub loadListXeBienSoHoTenHieuXeTienNo(BienSo As String, HoTen As String, MaLoaiHieuXe As Integer, TienNo As Decimal) 'LOAD LIST XE THEO HOTEN + HIEUXE

        Dim listXe = New List(Of KhachHangXeDTO)
        Dim result As Result

        Xe_BUS = New XeBUS()
        result = Xe_BUS.selectALL_ByBienSoHoTenHieuXeTienNo(BienSo, HoTen, MaLoaiHieuXe, TienNo, listXe)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Xe theo Biển số ,hiệu xe  và tiền nợ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If
        DrawGridView(listXe)
    End Sub

    'TIM KIẾM THEO TEXTBOX - KIEM TRA THEO TUNG TRUONG HOP CUA TEXTBOX

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click

        '1
        If (txtBienSoTimKiem.Text.Length > 0 And txtHoTenTimKiem.Text.Length = 0 And txtTienNoTimKiem.Text.Length = 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) = -1) Then
            Dim BienSo As String = txtBienSoTimKiem.Text
            loadListXeBienSo(BienSo)
            '2
        ElseIf (txtHoTenTimKiem.Text.Length > 0 And txtBienSoTimKiem.Text.Length = 0 And txtTienNoTimKiem.Text.Length = 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) = -1) Then
            Dim HoTen As String = txtHoTenTimKiem.Text
            loadListXeHoTen(HoTen)
            '3
        ElseIf (txtTienNoTimKiem.Text.Length > 0 And txtBienSoTimKiem.Text.Length = 0 And txtHoTenTimKiem.Text.Length = 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) = -1) Then
            Dim TienNo As Decimal = Convert.ToDecimal(txtTienNoTimKiem.Text)
            loadListXeTienNo(TienNo)
            '4
        ElseIf (Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) <> -1 And txtTienNoTimKiem.Text.Length = 0 And txtBienSoTimKiem.Text.Length = 0 And txtHoTenTimKiem.Text.Length = 0) Then
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXeTimKiem.SelectedValue)
            loadListXe(MaLoaiHieuXe)

            '12
        ElseIf (txtBienSoTimKiem.Text.Length > 0 And txtHoTenTimKiem.Text.Length > 0 And txtTienNoTimKiem.Text.Length = 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) = -1) Then
            Dim BienSo As String = txtBienSoTimKiem.Text
            Dim HoTen As String = txtHoTenTimKiem.Text
            loadListXeHoTenBienSo(BienSo, HoTen)

            '13
        ElseIf (Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) <> -1 And txtBienSoTimKiem.Text.Length > 0 And txtHoTenTimKiem.Text.Length = 0 And txtTienNoTimKiem.Text.Length = 0) Then
            Dim BienSo As String = txtBienSoTimKiem.Text
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXeTimKiem.SelectedValue)
            loadListXeBienSoMaLoaiHieuXe(BienSo, MaLoaiHieuXe)

            '14
        ElseIf (txtBienSoTimKiem.Text.Length > 0 And txtTienNoTimKiem.Text.Length > 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) = -1 And txtHoTenTimKiem.Text.Length = 0) Then
            Dim BienSo As String = txtBienSoTimKiem.Text
            Dim TienNo As Decimal = Convert.ToDecimal(txtTienNoTimKiem.Text)
            loadListXeBienSoTienNo(BienSo, TienNo)

            '23
        ElseIf (Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) <> -1 And txtHoTenTimKiem.Text.Length > 0 And txtBienSoTimKiem.Text.Length = 0 And txtTienNoTimKiem.Text.Length = 0) Then
            Dim HoTen As String = txtHoTenTimKiem.Text
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXeTimKiem.SelectedValue)
            loadListXeHoTenMaLoaiHieuXe(HoTen, MaLoaiHieuXe)

            '24
        ElseIf (txtHoTenTimKiem.Text.Length > 0 And txtTienNoTimKiem.Text.Length > 0 And txtBienSoTimKiem.Text.Length = 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) = -1) Then
            Dim HoTen As String = txtHoTenTimKiem.Text
            Dim TienNo As Decimal = Convert.ToDecimal(txtTienNoTimKiem.Text)
            loadListXeHoTenTienNo(HoTen, TienNo)

            '34
        ElseIf (txtTienNoTimKiem.Text.Length > 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) <> -1 And txtBienSoTimKiem.Text.Length = 0 And txtHoTenTimKiem.Text.Length = 0) Then
            Dim TienNo As Decimal = Convert.ToDecimal(txtTienNoTimKiem.Text)
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXeTimKiem.SelectedValue)
            loadListXeHieuXeTienNo(MaLoaiHieuXe, TienNo)


            '123
        ElseIf (txtBienSoTimKiem.Text.Length > 0 And txtHoTenTimKiem.Text.Length > 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) <> -1 And txtTienNoTimKiem.Text.Length = 0) Then
            Dim BienSo As String = txtBienSoTimKiem.Text
            Dim HoTen As String = txtHoTenTimKiem.Text
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXeTimKiem.SelectedValue)

            loadListXeBienSoHoTenHieuXe(BienSo, HoTen, MaLoaiHieuXe)

            '124
        ElseIf (txtBienSoTimKiem.Text.Length > 0 And txtHoTenTimKiem.Text.Length > 0 And txtTienNoTimKiem.Text.Length > 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) = -1) Then
            Dim BienSo As String = txtBienSoTimKiem.Text
            Dim HoTen As String = txtHoTenTimKiem.Text
            Dim TienNo As Decimal = Convert.ToDecimal(txtTienNoTimKiem.Text)

            loadListXeBienSoHoTenTienNo(BienSo, HoTen, TienNo)

            '134
        ElseIf (txtBienSoTimKiem.Text.Length > 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) <> -1 And txtTienNoTimKiem.Text.Length > 0 And txtHoTenTimKiem.Text.Length = 0) Then
            Dim BienSo As String = txtBienSoTimKiem.Text
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXeTimKiem.SelectedValue)
            Dim TienNo As Decimal = Convert.ToDecimal(txtTienNoTimKiem.Text)

            loadListXeBienSoHieuXeTienNo(BienSo, MaLoaiHieuXe, TienNo)

            '234
        ElseIf (txtHoTenTimKiem.Text.Length > 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) <> -1 And txtTienNoTimKiem.Text.Length > 0 And txtBienSoTimKiem.Text.Length = 0) Then
            Dim HoTen As String = txtHoTenTimKiem.Text
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXeTimKiem.SelectedValue)
            Dim TienNo As Decimal = Convert.ToDecimal(txtTienNoTimKiem.Text)

            loadListXeHoTenHieuXeTienNo(HoTen, MaLoaiHieuXe, TienNo)


            '1234
        ElseIf (txtHoTenTimKiem.Text.Length > 0 And Convert.ToInt32(cbHieuXeTimKiem.SelectedIndex) <> -1 And txtTienNoTimKiem.Text.Length > 0 And txtBienSoTimKiem.Text.Length > 0) Then

            Dim BienSo As String = txtBienSoTimKiem.Text
            Dim HoTen As String = txtHoTenTimKiem.Text
            Dim MaLoaiHieuXe As Integer = Convert.ToInt32(cbHieuXeTimKiem.SelectedValue)
            Dim TienNo As Decimal = Convert.ToDecimal(txtTienNoTimKiem.Text)

            loadListXeBienSoHoTenHieuXeTienNo(BienSo, HoTen, MaLoaiHieuXe, TienNo)

        Else
            MessageBox.Show("Hãy nhập ít nhất một thông tin vào TextBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    'Thay đổi datagridview
    Private Sub dgvListXe_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListXe.SelectionChanged, cbHieuXeTimKiem.SelectedIndexChanged
        ' Get the current cell location.

        Dim currentRowIndex As Integer = dgvListXe.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListXe.RowCount) Then
            Try

                Dim KhachHangXe = CType(dgvListXe.Rows(currentRowIndex).DataBoundItem, KhachHangXeDTO)

                'hiện dữ liệu chọn  vào textbox

                txtBienSo.Text = KhachHangXe.BienSo1
                cbMaLoaiHieuXe.SelectedIndex = KhachHangXe.LoaiHieuXe1 - 1
                dtpNgayTiepNhan.Value = KhachHangXe.NgayTiepNhan1
                'cbHieuXe.SelectedIndex  =
                txtMaKH.Text = KhachHangXe.MaKH1
                txtHoTen.Text = KhachHangXe.HoTen1
                txtDiaChiKH.Text = KhachHangXe.DiaChi1
                txtSoDienThoai.Text = KhachHangXe.SoDienThoai1
                txtTienNo.Text = KhachHangXe.SoTienNo1.ToString()

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    'XEM TẤT CẢ CÁC XE
    Private Sub btnXemTatCa_Click(sender As Object, e As EventArgs) Handles btnXemTatCa.Click
        loadListXe()


    End Sub

    Public Sub FilterData(valueToSearch As String)

        'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
        Dim searchQuery As String = "Select BienSoXe, MaLoaiHieuXe, CONVERT(varchar, NgayTiepNhan, 103) As NgayTiepNhan, tblXE.MaKH, tblKHACHHANG.TenKH , DiaChi, DienThoai, TienNo FROM [tblXE], [tblKHACHHANG] 
        WHERE [tblXE].[MaKH] = [tblKHACHHANG].[MaKH] 
        And CONCAT(BienSoXe, MaLoaiHieuXe,  CONVERT(varchar, NgayTiepNhan, 103), tblXE.MaKH, tblKHACHHANG.TenKH,  DiaChi, DienThoai, TienNo) Like '%" & TextBox1.Text & "%'"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgvListXe.DataSource = table

    End Sub

    Public Sub binding()

        txtBienSo.DataBindings.Clear()
        txtBienSo.DataBindings.Add("text", dgvListXe.DataSource, "MaKH")

        cbMaLoaiHieuXe.DataBindings.Clear()
        cbMaLoaiHieuXe.DataBindings.Add("SelectedValue", dgvListXe.DataSource, "MaLoaiHieuXe")

        txtMaKH.DataBindings.Clear()
        txtMaKH.DataBindings.Add("text", dgvListXe.DataSource, "BienSoXe")

        Try

            dtpNgayTiepNhan.DataBindings.Clear()
            dtpNgayTiepNhan.DataBindings.Add("Text", dgvListXe.DataSource, "NgayTiepNhan", True, System.Windows.Forms.DataSourceUpdateMode.Never, "d")

        Catch ex As Exception

        End Try
        txtHoTen.DataBindings.Clear()
        txtHoTen.DataBindings.Add("text", dgvListXe.DataSource, "TenKH")

        txtDiaChiKH.DataBindings.Clear()
        txtDiaChiKH.DataBindings.Add("text", dgvListXe.DataSource, "DiaChi")

        txtSoDienThoai.DataBindings.Clear()
        txtSoDienThoai.DataBindings.Add("text", dgvListXe.DataSource, "DienThoai")

        txtTienNo.DataBindings.Clear()
        txtTienNo.DataBindings.Add("text", dgvListXe.DataSource, "TienNo")


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        loadListXe()
        FilterData(TextBox1.Text)
        binding()

    End Sub

    Private Sub cbHieuXeTimKiem_Click(sender As Object, e As EventArgs) Handles cbHieuXeTimKiem.Click

        LoaiHieuXe_BUS = New LoaiHieuXeBUS()

        ' Load Hieu xe list
        Dim listLoaiHieuXe = New List(Of LoaiHieuXeDTO)
        Dim result As Result

        result = LoaiHieuXe_BUS.selectAll(listLoaiHieuXe)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbHieuXeTimKiem.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXeTimKiem.DisplayMember = "TenHieuXe"
        cbHieuXeTimKiem.ValueMember = "MaHieuXe"

    End Sub

    Private Sub cbHieuXeTimKiem_EnabledChanged(sender As Object, e As EventArgs) Handles cbHieuXeTimKiem.EnabledChanged

        cbHieuXeTimKiem.Visible = False

    End Sub

    Private Sub btnĐong_Click(sender As Object, e As EventArgs) Handles btnĐong.Click 'Dong
        Me.Close()
    End Sub

    Private Sub dgvListXe_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvListXe.CellPainting

        If TextBox1.Text = String.Empty Then Return
        If (e.Value Is Nothing) Then Return
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

        e.Handled = True
        e.PaintBackground(e.CellBounds, True)

        'Get the value of the text in the cell, and the search term. Work with everything in lowercase for more accurate highlighting
        Dim str_SearchTerm As String = TextBox1.Text.Trim.ToLower
        Dim str_CellText As String = DirectCast(e.FormattedValue, String).ToLower

        'Create a list of the character ranges that need to be highlighted. We need to know the start index and the length
        Dim HLRanges As New List(Of CharacterRange)
        Dim SearchIndex As Integer = str_CellText.IndexOf(str_SearchTerm)
        Do Until SearchIndex = -1
            HLRanges.Add(New CharacterRange(SearchIndex, str_SearchTerm.Length))
            SearchIndex = str_CellText.IndexOf(str_SearchTerm, SearchIndex + str_SearchTerm.Length)
        Loop

        ' We also work with the original cell text which is has not been converted to lowercase, else the sizes are incorrect
        str_CellText = DirectCast(e.FormattedValue, String)

        ' Choose your colours. A different colour is used on the currently selected rows
        Dim HLColour As SolidBrush
        If ((e.State And DataGridViewElementStates.Selected) <> DataGridViewElementStates.None) Then
            HLColour = New SolidBrush(Color.Red)
        Else
            HLColour = New SolidBrush(Color.Violet)
        End If

        'Loop through all of the found instances and draw the highlight box
        For Each HLRange In HLRanges

            ' Create the rectangle. It should start just underneath the top of the cell, and go to just above the bottom
            Dim HLRectangle As New Rectangle()
            HLRectangle.Y = e.CellBounds.Y + 2
            HLRectangle.Height = e.CellBounds.Height - 5

            ' Determine the size of the text before the area to highlight, and the size of the text to highlight. 
            ' We need to know the size of the text before so that we know where to start the highlight rectangle
            Dim TextBeforeHL As String = str_CellText.Substring(0, HLRange.First)
            Dim TextToHL As String = str_CellText.Substring(HLRange.First, HLRange.Length)
            Dim SizeOfTextBeforeHL As Size = TextRenderer.MeasureText(e.Graphics, TextBeforeHL, e.CellStyle.Font, e.CellBounds.Size)
            Dim SizeOfTextToHL As Size = TextRenderer.MeasureText(e.Graphics, TextToHL, e.CellStyle.Font, e.CellBounds.Size)

            'Set the width of the rectangle, a little wider to make the highlight clearer
            If SizeOfTextBeforeHL.Width > 5 Then
                HLRectangle.X = e.CellBounds.X + SizeOfTextBeforeHL.Width - 6
                HLRectangle.Width = SizeOfTextToHL.Width - 6
            Else
                HLRectangle.X = e.CellBounds.X + 2
                HLRectangle.Width = SizeOfTextToHL.Width - 6
            End If

            'Paint the highlight area
            e.Graphics.FillRectangle(HLColour, HLRectangle)
        Next

        'Paint the rest of the cell as usual
        e.PaintContent(e.CellBounds)
    End Sub

End Class