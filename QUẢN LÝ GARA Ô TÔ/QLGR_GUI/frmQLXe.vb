Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class frmQLXe
    Private Xe_Bus As XeBUS
    Private LoaiHieuXe_Bus As LoaiHieuXeBUS

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
                KhachHang_DTO.HoTen = txtHoTen.Text
                KhachHang_DTO.DiaChi = txtDiaChi.Text
                KhachHang_DTO.SoDienThoai = txtSoDienThoai.Text
                KhachHang_DTO.SoTienNo = txtTienNo.Text

                '2. Business .....
                If (Xe_Bus.isValidName(Xe_DTO) = False) Then
                    MessageBox.Show("Biển số xe không đúng.")
                    txtBienSo.Focus()
                    Return
                End If
                '3. Insert to DB
                Dim result As Result
                result = Xe_Bus.update(Xe_DTO)
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

    Private Sub fmrQLXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Xe_Bus = New XeBUS()
        LoaiHieuXe_Bus = New LoaiHieuXeBUS()

        ' Load LoaiHocSinh list
        Dim listLoaiHieuXe = New List(Of LoaiHieuXeDTO)
        Dim result As Result
        result = LoaiHieuXe_Bus.selectAll(listLoaiHieuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        cbHieuXe.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXe.DisplayMember = "TenLoai"
        cbHieuXe.ValueMember = "MaLoaiHieuXe"

        cbHieuXeCapNhat.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXeCapNhat.DisplayMember = "TenLoai"
        cbHieuXeCapNhat.ValueMember = "MaLoaiHieuXe"

    End Sub

    Private Sub loadListXe()
        Dim listXe = New List(Of XeDTO)
        Dim result As Result
        result = Xe_Bus.selectAll(listXe)
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
        dgvListXe.Columns.Add(clBienSo)

        Dim clHoTenKH = New DataGridViewTextBoxColumn()
        clHoTenKH.Name = "HoTen"
        clHoTenKH.HeaderText = "Họ Tên"
        clHoTenKH.DataPropertyName = "HoTen"
        dgvListXe.Columns.Add(clHoTenKH)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListXe.Columns.Add(clDiaChi)

        Dim clSoDienThoai = New DataGridViewTextBoxColumn()
        clSoDienThoai.Name = "SoDienThoai"
        clSoDienThoai.HeaderText = "Số Điện Thoại"
        clSoDienThoai.DataPropertyName = "SoDienThoai"
        dgvListXe.Columns.Add(clSoDienThoai)
        'dgvListHS.ResumeLayout()
    End Sub

    Private Sub loadListXe(MaLoaiHieuXe As String)
        Dim listXe = New List(Of XeDTO)
        Dim result As Result
        result = Xe_Bus.selectALL_ByHieuXe(MaLoaiHieuXe, listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách học sinh theo loại không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        Dim clHoTenKH = New DataGridViewTextBoxColumn()
        clHoTenKH.Name = "HoTen"
        clHoTenKH.HeaderText = "Họ Tên"
        clHoTenKH.DataPropertyName = "HoTen"
        dgvListXe.Columns.Add(clHoTenKH)

        Dim clDiaChi = New DataGridViewTextBoxColumn()
        clDiaChi.Name = "DiaChi"
        clDiaChi.HeaderText = "Địa Chỉ"
        clDiaChi.DataPropertyName = "DiaChi"
        dgvListXe.Columns.Add(clDiaChi)

        Dim clSoDienThoai = New DataGridViewTextBoxColumn()
        clSoDienThoai.Name = "SoDienThoai"
        clSoDienThoai.HeaderText = "Số Điện Thoại"
        clSoDienThoai.DataPropertyName = "SoDienThoai"
        dgvListXe.Columns.Add(clSoDienThoai)
        'dgvListHS.ResumeLayout()
    End Sub

    Private Sub cbHieuXe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHieuXe.SelectedIndexChanged, dgvListXe.MultiSelectChanged
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
                        result = Xe_Bus.delete(txtBienSo.Text)
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
                Dim KhachHang = CType(dgvListXe.Rows(currentRowIndex).DataBoundItem, KhachHangDTO)
                txtBienSo.Text = Xe.BienSo
                dtpNgayTiepNhan.Value = Xe.NgayTiepNhan
                txtHoTen.Text = KhachHang.HoTen
                txtDiaChi.Text = KhachHang.DiaChi
                txtSoDienThoai.Text = KhachHang.SoDienThoai
                txtTienNo.Text = KhachHang.SoTienNo.ToString()
                cbHieuXeCapNhat.SelectedIndex = cbHieuXe.SelectedIndex

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub txtHoTen_TextChanged(sender As Object, e As EventArgs) Handles txtHoTen.TextChanged

    End Sub
End Class