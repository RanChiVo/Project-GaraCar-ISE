Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data


Public Class frmQLXe

    Private Xe_BUS As XeBUS
    Private LoaiHieuXe_BUS As LoaiHieuXeBUS
    Private KhachHang_BUS As KhachHangBUS
    Private KhachHangXe_BUS As KhachHangXeBUS
    Dim connection As New SqlConnection("Server = DESKTOP-KG90A2I; Database= GRDB02; Integrated Security = true")

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click

        Dim currentRowIndex As Integer = dgvListXe.CurrentCellAddress.Y
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListXe.RowCount) Then
            Try
                Dim KhachHangXe As KhachHangXeDTO = New KhachHangXeDTO()

                '1. Mapping data from GUI control
                KhachHangXe.BienSo1 = txtBienSo.Text
                KhachHangXe.LoaiHieuXe1 = Convert.ToInt32(cbHieuXeCapNhat.SelectedValue)
                KhachHangXe.NgayTiepNhan1 = dtpNgayTiepNhan.Value
                KhachHangXe.MaKH1 = txtMaKH.Text

                KhachHangXe.HoTen1 = txtHoTen.Text
                KhachHangXe.DiaChi1 = txtDiaChi.Text
                KhachHangXe.SoDienThoai1 = txtSoDienThoai.Text
                KhachHangXe.SoTienNo1 = txtSoTienNo.Text


                '2. Insert to DB
                Dim result As Result
                result = Xe_BUS.update(KhachHangXe)
                If (result.FlagResult = True) Then
                    ' Re-Load Khách hàng list
                    loadListXe()
                    ' Hightlight the row has been updated on table
                    dgvListXe.Rows(currentRowIndex).Selected = True

                    MessageBox.Show("Cập nhật Xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If

    End Sub


    Private Sub fmrQLXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Format Ngay tiep nhan

        dtpNgayTiepNhan.CustomFormat = "dd/MM/yyyy"
        dtpNgayTiepNhan.Format = DateTimePickerFormat.Custom

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

        'Do du lieu vao combobox
        cbHieuXeCapNhat.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXeCapNhat.DisplayMember = "TenHieuXe"
        cbHieuXeCapNhat.ValueMember = "MaHieuXe"

        cbHieuXe.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXe.DisplayMember = "TenHieuXe"
        cbHieuXe.ValueMember = "MaHieuXe"
        Xe_BUS = New XeBUS()
        loadListXe("1")

    End Sub

    Private Sub loadListXe() 'Load tat ca xe

        Dim listKhachHangXe = New List(Of KhachHangXeDTO)

        Dim result As Result
        result = Xe_BUS.selectAll(listKhachHangXe)

        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvListXe.Columns.Clear()
        dgvListXe.DataSource = Nothing

        dgvListXe.AutoGenerateColumns = False
        dgvListXe.AllowUserToAddRows = False
        dgvListXe.DataSource = listKhachHangXe

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
        dgvListXe.ResumeLayout()

    End Sub

    Private Sub loadListXe(MaLoaiHieuXe As String) ' Load danh sach xe theo  ma hieu xe

        Dim listXe = New List(Of KhachHangXeDTO)

        Dim result As Result
        result = Xe_BUS.selectALL_ByHieuXe(MaLoaiHieuXe, listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Xe theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListXe.Columns.Clear()
        dgvListXe.DataSource = Nothing

        dgvListXe.AutoGenerateColumns = False
        dgvListXe.AllowUserToAddRows = False
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

    End Sub

    Private Sub cbHieuXe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvListXe.MultiSelectChanged

        'Load danh sách xe từ hiệu xe

        Try
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXe.SelectedValue)
            loadListXe(MaLoaiHieuXe)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListXe.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListXe.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Xe có mã số: " + txtBienSo.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
                        Dim KhachHangXe As KhachHangXeDTO = New KhachHangXeDTO()
                        KhachHangXe.BienSo1 = txtBienSo.Text
                        KhachHangXe.MaKH1 = txtMaKH.Text

                        Dim result As Result
                        result = Xe_BUS.delete(KhachHangXe)
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListXe(cbHieuXe.SelectedValue)

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListXe.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListXe.Rows(currentRowIndex).Selected = True
                            End If

                            MessageBox.Show("Xóa Xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select

        End If

    End Sub

    Private Sub dgvListXe_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvListXe.SelectionChanged
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
                txtMaKH.Text = KhachHangXe.MaKH1
                txtBienSo.Text = KhachHangXe.BienSo1
                dtpNgayTiepNhan.Value = KhachHangXe.NgayTiepNhan1
                cbHieuXeCapNhat.SelectedIndex = cbHieuXe.SelectedIndex
                cbHieuXeCapNhat.SelectedIndex = KhachHangXe.LoaiHieuXe1 - 1
                'cbHieuXe.SelectedIndex  =
                txtHoTen.Text = KhachHangXe.HoTen1
                txtDiaChi.Text = KhachHangXe.DiaChi1
                txtSoDienThoai.Text = KhachHangXe.SoDienThoai1
                txtSoTienNo.Text = KhachHangXe.SoTienNo1.ToString()

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub cbHieuXe_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbHieuXe.SelectedIndexChanged

        Try
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXe.SelectedValue)
            loadListXe(MaLoaiHieuXe)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub btnTatCa_Click(sender As Object, e As EventArgs) Handles btnTatCa.Click ' Load tất cả Xe

        loadListXe()

    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click

        Dim frmTimKiem As fmrtracuuxe = New fmrtracuuxe()
        frmTimKiem.Show()

    End Sub


End Class