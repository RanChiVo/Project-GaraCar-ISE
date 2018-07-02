<<<<<<< HEAD
﻿Imports System.Configuration
Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class frmQLVatTuPhuTung

    Private phuTungBus As VatTuPhuTungBUS

    Private Sub frmQLVatTuPhuTung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        phuTungBus = New VatTuPhuTungBUS
        'Load ListPhuTung
        loadListPhuTung()

    End Sub

    Private Sub loadListPhuTung()
        ' Load PhuTung list
        Dim listPhuTung = New List(Of VatTuPhuTungDTO)
        Dim result As Result
        result = phuTungBus.selectAll(listPhuTung)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachPhuTung.Columns.Clear()
        dgvDanhSachPhuTung.DataSource = Nothing

        dgvDanhSachPhuTung.AutoGenerateColumns = False
        dgvDanhSachPhuTung.AllowUserToAddRows = False
        dgvDanhSachPhuTung.DataSource = listPhuTung

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "MaLoaiPhuTung"
        clMaLoai.HeaderText = "Mã Loại"
        clMaLoai.DataPropertyName = "MaLoaiPhuTung"
        dgvDanhSachPhuTung.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TenLoaiPhuTung"
        clTenLoai.HeaderText = "Tên Loại"
        clTenLoai.DataPropertyName = "TenLoaiPhuTung"
        dgvDanhSachPhuTung.Columns.Add(clTenLoai)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "DonGia"
        clDonGia.HeaderText = "Đơn Giá"
        clDonGia.DataPropertyName = "DonGia"
        dgvDanhSachPhuTung.Columns.Add(clDonGia)

        Dim clSoLuong = New DataGridViewTextBoxColumn()
        clSoLuong.Name = "SoLuong"
        clSoLuong.HeaderText = "Số Lượng"
        clSoLuong.DataPropertyName = "SoLuong"
        dgvDanhSachPhuTung.Columns.Add(clSoLuong)

    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click

        Dim currentRowIndex As Integer = dgvDanhSachPhuTung.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachPhuTung.RowCount) Then
            Try
                Dim phuTung As VatTuPhuTungDTO
                phuTung = New VatTuPhuTungDTO()

                '1. Mapping data from GUI control
                phuTung.MaLoaiPhuTung = Convert.ToInt32(txtMaLoaiPhuTung.Text)
                phuTung.TenLoaiPhuTung = txtTenLoaiPhuTung.Text
                phuTung.DonGia = txtDonGia.Text
                phuTung.SoLuong = txtSoLuong.Text

                '2. Business .....
                If (phuTungBus.isValidName(phuTung) = False) Then
                    MessageBox.Show("Tên Loại phụ tùng không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoaiPhuTung.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = phuTungBus.update(phuTung)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListPhuTung()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachPhuTung.Rows(currentRowIndex).Selected = True
                    Try
                        phuTung = CType(dgvDanhSachPhuTung.Rows(currentRowIndex).DataBoundItem, VatTuPhuTungDTO)
                        txtMaLoaiPhuTung.Text = phuTung.MaLoaiPhuTung
                        txtTenLoaiPhuTung.Text = phuTung.TenLoaiPhuTung
                        txtDonGia.Text = phuTung.DonGia
                        txtSoLuong.Text = phuTung.SoLuong
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Loại phụ tùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Loại phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub dgvDanhSachPhuTung_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachPhuTung.SelectionChanged

        'Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachPhuTung.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachPhuTung.RowCount) Then
            Try
                Dim phuTung = CType(dgvDanhSachPhuTung.Rows(currentRowIndex).DataBoundItem, VatTuPhuTungDTO)
                txtMaLoaiPhuTung.Text = phuTung.MaLoaiPhuTung
                txtTenLoaiPhuTung.Text = phuTung.TenLoaiPhuTung
                txtDonGia.Text = phuTung.DonGia
                txtSoLuong.Text = phuTung.SoLuong
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click

        ' get the current cell location.
        Dim currentrowindex As Integer = dgvDanhSachPhuTung.CurrentCellAddress.Y 'current row selected


        'verify that indexing ok
        If (-1 < currentrowindex And currentrowindex < dgvDanhSachPhuTung.RowCount) Then
            Select Case MsgBox("bạn có thực sự muốn xóa phụ tùng có mã: " + txtMaLoaiPhuTung.Text, MsgBoxStyle.YesNo, "information")
                Case MsgBoxResult.Yes
                    Try

                        '1. delete from db
                        Dim result As Result
                        result = phuTungBus.delete(Convert.ToInt32(txtMaLoaiPhuTung.Text))
                        If (result.FlagResult = True) Then

                            ' re-load loaihocsinh list
                            loadListPhuTung()

                            ' hightlight the next row on table
                            If (currentrowindex >= dgvDanhSachPhuTung.Rows.Count) Then
                                currentrowindex = currentrowindex - 1
                            End If
                            If (currentrowindex >= 0) Then
                                dgvDanhSachPhuTung.Rows(currentrowindex).Selected = True
                                Try
                                    Dim phutung = CType(dgvDanhSachPhuTung.Rows(currentrowindex).DataBoundItem, VatTuPhuTungDTO)
                                    txtMaLoaiPhuTung.Text = phutung.MaLoaiPhuTung
                                    txtTenLoaiPhuTung.Text = phutung.TenLoaiPhuTung
                                    txtDonGia.Text = phutung.DonGia
                                    txtSoLuong.Text = phutung.SoLuong
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("xóa phụ tùng thành công.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("xóa phụ tùng không thành công.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    Private Sub btnThem_Click_1(sender As Object, e As EventArgs) Handles btnThem.Click


        Dim frmVatTu As New frmThemVatTuPhuTung()

        frmVatTu.Show()


    End Sub

=======
﻿Public Class frmQLVatTuPhuTung
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
End Class