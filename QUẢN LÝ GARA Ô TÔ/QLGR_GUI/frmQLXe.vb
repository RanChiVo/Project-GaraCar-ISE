Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data


Public Class frmQLXe
<<<<<<< HEAD

    Private Xe_BUS As XeBUS
    Private LoaiHieuXe_BUS As LoaiHieuXeBUS
    Private KhachHang_BUS As KhachHangBUS
    Private KhachHangXe_BUS As KhachHangXeBUS
    Dim connection As New SqlConnection("Server = DESKTOP-KG90A2I; Database= GRDB02; Integrated Security = true")

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click

=======
    Private Xe_BUS As XeBUS
    Private LoaiHieuXe_BUS As LoaiHieuXeBUS
    Private KhachHang_BUS As KhachHangBUS

    Dim connection As New SqlConnection("Server = DESKTOP-KG90A2I; Database= GRDB02; Integrated Security = true")

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Dim currentRowIndex As Integer = dgvListXe.CurrentCellAddress.Y
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListXe.RowCount) Then
            Try
<<<<<<< HEAD
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
=======
                Dim Xe_DTO As XeDTO
                Xe_DTO = New XeDTO()

                Dim KhachHang_DTO As KhachHangDTO
                KhachHang_DTO = New KhachHangDTO()

                '1. Mapping data from GUI control
                Xe_DTO.BienSo = txtBienSo.Text
                Xe_DTO.LoaiHieuXe = Convert.ToInt32(cbHieuXeCapNhat.SelectedValue)
                Xe_DTO.NgayTiepNhan = dtpNgayTiepNhan.Value

                'KhachHang_DTO.HoTen = txtHoTen.Text
                'KhachHang_DTO.DiaChi = txtDiaChi.Text
                'KhachHang_DTO.SoDienThoai = txtSoDienThoai.Text
                'Try
                '    KhachHang_DTO.SoTienNo = Convert.ToInt32(txtSoTienNo.Text)
                'Catch ex As Exception
                '    MessageBox.Show("Tiền nợ của khách hàng của khách hàng chưa đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Return
                'End Try
                '2. Business .....
                'If (Xe_BUS.isValidName(Xe_DTO) = False) Then
                '    MessageBox.Show("Biển số xe không đúng.")
                '    txtBienSo.Focus()
                '    Return
                'End If

                'If (KhachHang_BUS.isValidName(KhachHang_DTO) = False) Then
                '    MessageBox.Show("Họ tên khách hàng không đúng")
                '    txtBienSo.Focus()
                '    Return
                'End If
                '3. Insert to DB
                Dim result As Result
                result = Xe_BUS.update(Xe_DTO)
                If (result.FlagResult = True) Then
                    ' Re-Load HocSinh list
                    loadListXe(cbHieuXe.SelectedValue)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
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
<<<<<<< HEAD

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

=======
    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim Query As String = "Select * from tblXE WHERE CONCAT(BienSoXe, MaKH, MaLoaiHieuXe, NgayTiepNhan) like '%" & valueToSearch & "%'"


        Dim command As New SqlCommand(Query, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)

        dgvListXe.DataSource = table
    End Sub


    Private Sub fmrQLXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpNgayTiepNhan.CustomFormat = "dd/MM/yyyy"
        dtpNgayTiepNhan.Format = DateTimePickerFormat.Custom
        '  FilterData("")

        Xe_BUS = New XeBUS()
        LoaiHieuXe_BUS = New LoaiHieuXeBUS()

        ' Load LoaiHocSinh list
        Dim listLoaiHieuXe = New List(Of LoaiHieuXeDTO)
        Dim result As Result
        result = LoaiHieuXe_BUS.selectAll(listLoaiHieuXe)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

<<<<<<< HEAD
        'Do du lieu vao combobox
=======
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        cbHieuXeCapNhat.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXeCapNhat.DisplayMember = "TenHieuXe"
        cbHieuXeCapNhat.ValueMember = "MaHieuXe"

        cbHieuXe.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXe.DisplayMember = "TenHieuXe"
        cbHieuXe.ValueMember = "MaHieuXe"
<<<<<<< HEAD
        Xe_BUS = New XeBUS()
        loadListXe("1")

    End Sub

    Private Sub loadListXe() 'Load tat ca xe

        Dim listKhachHangXe = New List(Of KhachHangXeDTO)

        Dim result As Result
        result = Xe_BUS.selectAll(listKhachHangXe)

=======
        loadListXe()
    End Sub


    Private Sub loadListXe()
        Dim listXe = New List(Of XeDTO)
        Dim result As Result
        result = Xe_BUS.selectAll(listXe)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
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
<<<<<<< HEAD
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

=======
        dgvListXe.DataSource = listXe

        Dim clBienSo = New DataGridViewTextBoxColumn()
        clBienSo.Name = "BienSo"
        clBienSo.HeaderText = "Biển Số"
        clBienSo.DataPropertyName = "BienSo"
        dgvListXe.Columns.Add(clBienSo)

        Dim clLoaiHieuXe = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        clNgayTiepNhan.Name = "NgayTiepNhan"
        clNgayTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgayTiepNhan.DataPropertyName = "NgayTiepNhan"
        dgvListXe.Columns.Add(clNgayTiepNhan)

        Dim clMaKH = New DataGridViewTextBoxColumn()
        clMaKH.Name = "MaKH"
        clMaKH.HeaderText = "Mã Khách Hàng"
        clMaKH.DataPropertyName = "MaKH"
        dgvListXe.Columns.Add(clMaKH)

        'dim listkhachhang = new list(of khachhangdto)
        'dim result1 as result
        'result1 = khachhang_bus.selectall(listkhachhang)
        'if (result1.flagresult = false) then
        '    messagebox.show("lấy danh sách khách hàng không thành công.", "error", messageboxbuttons.ok, messageboxicon.error)
        '    system.console.writeline(result.systemmessage)
        '    return
        'end if

        'dgvListHS.SuspendLayout()
        'dgvListXe.Columns.Clear()
        'dgvListXe.DataSource = Nothing

        'dgvListXe.AutoGenerateColumns = False
        'dgvListXe.AllowUserToAddRows = False
        'dgvListXe.DataSource = listXe

        'Dim cl = New DataGridViewTextBoxColumn()
        'clBienSo.Name = "BienSo"
        'clBienSo.HeaderText = "Biển Số"
        'clBienSo.DataPropertyName = "BienSo"
        'dgvListXe.Columns.Add(clBienSo)

        'Dim clLoai = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        'Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        'clNgayTiepNhan.Name = "NgayTiepNhan"
        'clNgayTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        'clNgayTiepNhan.DataPropertyName = "NgayTiepNhan"
        'dgvListXe.Columns.Add(clNgayTiepNhan)

        'Dim clMaKH = New DataGridViewTextBoxColumn()
        'clMaKH.Name = "MaKH"
        'clMaKH.HeaderText = "Mã Khách Hàng"
        'clMaKH.DataPropertyName = "MaKH"
        'dgvListXe.Columns.Add(clMaKH)
        'Dim clHoTenKH = New DataGridViewTextBoxColumn()
        'clHoTenKH.Name = "HoTen"
        'clHoTenKH.HeaderText = "Họ Tên"
        'clHoTenKH.DataPropertyName = "HoTen"
        'dgvListXe.Columns.Add(clHoTenKH)

        'Dim clDiaChi = New DataGridViewTextBoxColumn()
        'clDiaChi.Name = "DiaChi"
        'clDiaChi.HeaderText = "Địa Chỉ"
        'clDiaChi.DataPropertyName = "DiaChi"
        'dgvListXe.Columns.Add(clDiaChi)

        'Dim clSoDienThoai = New DataGridViewTextBoxColumn()
        'clSoDienThoai.Name = "SoDienThoai"
        'clSoDienThoai.HeaderText = "Số Điện Thoại"
        'clSoDienThoai.DataPropertyName = "SoDienThoai"
        'dgvListXe.Columns.Add(clSoDienThoai)

        'Dim clSoTienNo = New DataGridViewTextBoxColumn()
        'clSoTienNo.Name = "SoDienThoai"
        'clSoTienNo.HeaderText = "Số Điện Thoại"
        'clSoTienNo.DataPropertyName = "SoDienThoai"
        'dgvListXe.Columns.Add(clSoDienThoai)
        'dgvListXe.ResumeLayout()
    End Sub

    Private Sub loadListXe(MaLoaiHieuXe As String)
        Dim listXe = New List(Of XeDTO)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Dim result As Result
        result = Xe_BUS.selectALL_ByHieuXe(MaLoaiHieuXe, listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Xe theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

<<<<<<< HEAD
=======
        'dgvListHS.SuspendLayout()
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        dgvListXe.Columns.Clear()
        dgvListXe.DataSource = Nothing

        dgvListXe.AutoGenerateColumns = False
        dgvListXe.AllowUserToAddRows = False
        dgvListXe.DataSource = listXe

        Dim clBienSo = New DataGridViewTextBoxColumn()
<<<<<<< HEAD
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

=======
        clBienSo.Name = "BienSo"
        clBienSo.HeaderText = "Biển Số"
        clBienSo.DataPropertyName = "BienSo"
        dgvListXe.Columns.Add(clBienSo)

        Dim clLoaiXe = New DataGridView()
        'clLoaiHS.Name = "LoaiHS"
        'clLoaiHS.HeaderText = "Tên Loại"
        'clLoaiHS.DataPropertyName = "LoaiHS"
        'dgvListHS.Columns.Add(clLoaiHS)

        Dim clNgayTiepNhan = New DataGridViewTextBoxColumn()
        clNgayTiepNhan.Name = "NgayTiepNhan"
        clNgayTiepNhan.HeaderText = "Ngày Tiếp Nhận"
        clNgayTiepNhan.DataPropertyName = "NgayTiepNhan"
        dgvListXe.Columns.Add(clNgayTiepNhan)

        Dim clMaKH = New DataGridViewTextBoxColumn()
        clMaKH.Name = "MaKH"
        clMaKH.HeaderText = "Mã Khách Hàng"
        clMaKH.DataPropertyName = "MaKH"
        dgvListXe.Columns.Add(clMaKH)

        'Dim clHoTenKH = New DataGridViewTextBoxColumn()
        'clHoTenKH.Name = "HoTen"
        'clHoTenKH.HeaderText = "Họ Tên"
        'clHoTenKH.DataPropertyName = "HoTen"
        'dgvListXe.Columns.Add(clHoTenKH)

        'Dim clDiaChi = New DataGridViewTextBoxColumn()
        'clDiaChi.Name = "DiaChi"
        'clDiaChi.HeaderText = "Địa Chỉ"
        'clDiaChi.DataPropertyName = "DiaChi"
        'dgvListXe.Columns.Add(clDiaChi)

        'Dim clSoDienThoai = New DataGridViewTextBoxColumn()
        'clSoDienThoai.Name = "SoDienThoai"
        'clSoDienThoai.HeaderText = "Số Điện Thoại"
        'clSoDienThoai.DataPropertyName = "SoDienThoai"
        'dgvListXe.Columns.Add(clSoDienThoai)
        'dgvListXe.ResumeLayout()
    End Sub

    Private Sub cbHieuXe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvListXe.MultiSelectChanged
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Try
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXe.SelectedValue)
            loadListXe(MaLoaiHieuXe)

        Catch ex As Exception

        End Try

<<<<<<< HEAD
=======

>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListXe.CurrentCellAddress.Y 'current row selected

<<<<<<< HEAD
=======

>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListXe.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa Xe có mã số: " + txtBienSo.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try
<<<<<<< HEAD
                        Dim KhachHangXe As KhachHangXeDTO = New KhachHangXeDTO()
                        KhachHangXe.BienSo1 = txtBienSo.Text
                        KhachHangXe.MaKH1 = txtMaKH.Text

                        Dim result As Result
                        result = Xe_BUS.delete(KhachHangXe)
=======
                        '1. Delete from DB
                        Dim result As Result
                        result = Xe_BUS.delete(txtBienSo.Text)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
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

<<<<<<< HEAD
        End If

=======

        End If
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
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

<<<<<<< HEAD
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
=======
                Dim Xe = CType(dgvListXe.Rows(currentRowIndex).DataBoundItem, XeDTO)
                '    Dim KhachHang = CType(dgvListXe.Rows(currentRowIndex).DataBoundItem, KhachHangDTO)
                txtBienSo.Text = Xe.BienSo
                dtpNgayTiepNhan.Value = Xe.NgayTiepNhan

                cbHieuXeCapNhat.SelectedIndex = cbHieuXe.SelectedIndex
                'txtHoTen.Text = KhachHang.HoTen
                'txtDiaChi.Text = KhachHang.DiaChi
                'txtSoDienThoai.Text = KhachHang.SoDienThoai
                'txtSoTienNo.Text = KhachHang.SoTienNo.ToString()

>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
<<<<<<< HEAD

    End Sub

    Private Sub cbHieuXe_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbHieuXe.SelectedIndexChanged

=======
    End Sub

    Private Sub txtHoTen_TextChanged(sender As Object, e As EventArgs) Handles txtHoTen.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub cbHieuXe_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbHieuXe.SelectedIndexChanged
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Try
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXe.SelectedValue)
            loadListXe(MaLoaiHieuXe)

        Catch ex As Exception

        End Try
<<<<<<< HEAD

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


=======
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnTatCa_Click(sender As Object, e As EventArgs) Handles btnTatCa.Click
        loadListXe()
    End Sub

    Private Sub dgvListXe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListXe.CellContentClick

    End Sub

    Private Sub dgvListXe_RowDefaultCellStyleChanged(sender As Object, e As DataGridViewRowEventArgs) Handles dgvListXe.RowDefaultCellStyleChanged

    End Sub
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
End Class