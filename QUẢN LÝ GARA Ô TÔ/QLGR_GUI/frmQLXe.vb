Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Data


Public Class frmQLXe
    Private Xe_BUS As XeBUS
    Private LoaiHieuXe_BUS As LoaiHieuXeBUS
    Private KhachHang_BUS As KhachHangBUS

    Dim connection As New SqlConnection("Server = DESKTOP-KG90A2I; Database= GRDB02; Integrated Security = true")

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        Dim currentRowIndex As Integer = dgvListXe.CurrentCellAddress.Y
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListXe.RowCount) Then
            Try
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
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        cbHieuXeCapNhat.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXeCapNhat.DisplayMember = "TenHieuXe"
        cbHieuXeCapNhat.ValueMember = "MaHieuXe"

        cbHieuXe.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXe.DisplayMember = "TenHieuXe"
        cbHieuXe.ValueMember = "MaHieuXe"
        loadListXe()
    End Sub


    Private Sub loadListXe()
        Dim listXe = New List(Of XeDTO)
        Dim result As Result
        result = Xe_BUS.selectAll(listXe)
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
        Dim result As Result
        result = Xe_BUS.selectALL_ByHieuXe(MaLoaiHieuXe, listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Xe theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        'dgvListHS.SuspendLayout()
        dgvListXe.Columns.Clear()
        dgvListXe.DataSource = Nothing

        dgvListXe.AutoGenerateColumns = False
        dgvListXe.AllowUserToAddRows = False
        dgvListXe.DataSource = listXe

        Dim clBienSo = New DataGridViewTextBoxColumn()
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
                        '1. Delete from DB
                        Dim result As Result
                        result = Xe_BUS.delete(txtBienSo.Text)
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

                Dim Xe = CType(dgvListXe.Rows(currentRowIndex).DataBoundItem, XeDTO)
                '    Dim KhachHang = CType(dgvListXe.Rows(currentRowIndex).DataBoundItem, KhachHangDTO)
                txtBienSo.Text = Xe.BienSo
                dtpNgayTiepNhan.Value = Xe.NgayTiepNhan

                cbHieuXeCapNhat.SelectedIndex = cbHieuXe.SelectedIndex
                'txtHoTen.Text = KhachHang.HoTen
                'txtDiaChi.Text = KhachHang.DiaChi
                'txtSoDienThoai.Text = KhachHang.SoDienThoai
                'txtSoTienNo.Text = KhachHang.SoTienNo.ToString()


            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub txtHoTen_TextChanged(sender As Object, e As EventArgs) Handles txtHoTen.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub cbHieuXe_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbHieuXe.SelectedIndexChanged
        Try
            Dim MaLoaiHieuXe = Convert.ToInt32(cbHieuXe.SelectedValue)
            loadListXe(MaLoaiHieuXe)

        Catch ex As Exception

        End Try
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
End Class