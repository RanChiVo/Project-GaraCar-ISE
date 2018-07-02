Imports System.Configuration
Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class frmQLHieuXe

    Private LoaiHieuXe_Bus As LoaiHieuXeBUS

<<<<<<< HEAD
    Private Sub fmrQLHieuXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
=======

    Private Sub frmDanhSachLoaiHocSinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d

        LoaiHieuXe_Bus = New LoaiHieuXeBUS()
        ' Load LoaiHocSinh list
        loadListLoaiHieuXe()

    End Sub
<<<<<<< HEAD

    Public Sub loadListLoaiHieuXe()
        ' Load LoaiHocSinh list

=======
    Private Sub loadListLoaiHieuXe()
        ' Load LoaiHocSinh list
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
        Dim listLoaiHieuXe = New List(Of LoaiHieuXeDTO)
        Dim result As Result
        result = LoaiHieuXe_Bus.selectAll(listLoaiHieuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Hiệu Xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvHieuXe.Columns.Clear()
        dgvHieuXe.DataSource = Nothing

        dgvHieuXe.AutoGenerateColumns = False
        dgvHieuXe.AllowUserToAddRows = False
        dgvHieuXe.DataSource = listLoaiHieuXe

        Dim clMaLoaiHieuXe = New DataGridViewTextBoxColumn()
<<<<<<< HEAD
        clMaLoaiHieuXe.Name = "MaHieuXe"
        clMaLoaiHieuXe.HeaderText = "Mã Loại"
        clMaLoaiHieuXe.DataPropertyName = "MaHieuXe"
        dgvHieuXe.Columns.Add(clMaLoaiHieuXe)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TenHieuXe"
        clTenLoai.HeaderText = "Tên Loại Hiệu Xe"
        clTenLoai.DataPropertyName = "TenHieuXe"
        dgvHieuXe.Columns.Add(clTenLoai)

    End Sub

=======
        clMaLoaiHieuXe.Name = "MaLoaiHieuXe"
        clMaLoaiHieuXe.HeaderText = "Mã Loại"
        clMaLoaiHieuXe.DataPropertyName = "MaLoaiHieuXe"
        dgvHieuXe.Columns.Add(clMaLoaiHieuXe)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TenLoaiHieuXe"
        clTenLoai.HeaderText = "Tên Loại Hiệu Xe"
        clTenLoai.DataPropertyName = "TenLoaiHieuXe"
        dgvHieuXe.Columns.Add(clTenLoai)

    End Sub
    Private Sub fmrQLHieuXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvHieuXe.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvHieuXe.RowCount) Then
            Try
                Dim LoaiHieuXe_DTO As LoaiHieuXeDTO
                LoaiHieuXe_DTO = New LoaiHieuXeDTO()

                '1. Mapping data from GUI control
                LoaiHieuXe_DTO.MaHieuXe = Convert.ToInt32(txtMaLoaiHieuXe.Text)
                LoaiHieuXe_DTO.TenHieuXe = txtTenLoaiHieuXe.Text

                '2. Business .....
                If (LoaiHieuXe_Bus.isValidName(LoaiHieuXe_DTO) = False) Then
<<<<<<< HEAD
                    MessageBox.Show("Tên Loại hiệu xe không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
=======
                    MessageBox.Show("Tên Loại học sinh không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
                    txtTenLoaiHieuXe.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = LoaiHieuXe_Bus.update(LoaiHieuXe_DTO)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListLoaiHieuXe()
                    ' Hightlight the row has been updated on table
                    dgvHieuXe.Rows(currentRowIndex).Selected = True
                    Try
                        LoaiHieuXe_DTO = CType(dgvHieuXe.Rows(currentRowIndex).DataBoundItem, LoaiHieuXeDTO)
                        txtMaLoaiHieuXe.Text = LoaiHieuXe_DTO.MaHieuXe
                        txtTenLoaiHieuXe.Text = LoaiHieuXe_DTO.TenHieuXe
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
<<<<<<< HEAD
                    MessageBox.Show("Cập nhật hiệu xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
=======
                    MessageBox.Show("Cập nhật hiệu xe không thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
                Else
                    MessageBox.Show("Cập nhật hiều xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub dgvHieuXe_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHieuXe.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvHieuXe.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvHieuXe.RowCount) Then
            Try
                Dim LoaiHieuXe = CType(dgvHieuXe.Rows(currentRowIndex).DataBoundItem, LoaiHieuXeDTO)
                txtMaLoaiHieuXe.Text = LoaiHieuXe.MaHieuXe
                txtTenLoaiHieuXe.Text = LoaiHieuXe.TenHieuXe

            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvHieuXe.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvHieuXe.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa hieu Xe có mã: " + txtMaLoaiHieuXe.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = LoaiHieuXe_Bus.delete(Convert.ToInt32(txtMaLoaiHieuXe.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListLoaiHieuXe()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvHieuXe.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvHieuXe.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim LoaiHieuXe = CType(dgvHieuXe.Rows(currentRowIndex).DataBoundItem, LoaiHieuXeDTO)
                                    txtMaLoaiHieuXe.Text = LoaiHieuXe.MaHieuXe
                                    txtTenLoaiHieuXe.Text = LoaiHieuXe.TenHieuXe
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Hiệu Xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Hiệu Xe sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

<<<<<<< HEAD
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click

        Me.Close()

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        Dim frmThemHX As New frmThemHieuXe()
        frmThemHX.Show()

    End Sub

=======


    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
End Class