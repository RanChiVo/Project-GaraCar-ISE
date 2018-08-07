Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility



Public Class frmQuanLiSuaChua

    Private pscBus As PhieuSuaChuaBUS
    Private vatTuPhuTungBus As VatTuPhuTungBUS
    Private tienCongBus As TienCongBUS

    Private listTienCong As List(Of TienCongDTO)
    Private listVatTuPhuTung As List(Of VatTuPhuTungDTO)
    Private listVatTuPhuTungOnDB As List(Of VatTuPhuTungDTO)
    Private listPhieuSuaChua As List(Of PhieuSuaChuaDTO)
    Private listCTPhieuSuaChua As List(Of ChiTietPhieuSuaChuaDTO)
    Private thanhTien As Integer
    Private thanhTien2 As Integer
    Private newList As List(Of VatTuPhuTungDTO)

    Private Sub frmQuanLiSuaChua_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pscBus = New PhieuSuaChuaBUS()
        tienCongBus = New TienCongBUS()
        vatTuPhuTungBus = New VatTuPhuTungBUS()
        listVatTuPhuTung = New List(Of VatTuPhuTungDTO)
        listVatTuPhuTungOnDB = New List(Of VatTuPhuTungDTO)
        listCTPhieuSuaChua = New List(Of ChiTietPhieuSuaChuaDTO)
        newList = New List(Of VatTuPhuTungDTO)


        loadListVatTuPhuTung()
        loadTienCongList()
        'buildDGVPhuTung()
        loadMaPhieuSuaChua()
        For Each dr In listVatTuPhuTung
            newList.Add(dr.Clone)
        Next

    End Sub

    Private Sub loadMaPhieuSuaChua()

        'Load MaPhieuSuaChua to combobox
        listPhieuSuaChua = New List(Of PhieuSuaChuaDTO)
        Dim result As Result
        result = pscBus.selectALL(Me.listPhieuSuaChua)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Phiếu sữa chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbMaPhieu.DataSource = New BindingSource(listPhieuSuaChua, String.Empty)
        cbMaPhieu.DisplayMember = "MaPhieuSuaChua"
        cbMaPhieu.ValueMember = "MaPhieuSuaChua"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(cbMaPhieu.DataSource)
        myCurrencyManager.Refresh()
        If (listPhieuSuaChua.Count > 0) Then
            cbMaPhieu.SelectedIndex = 0
        End If

    End Sub

    Private Sub loadListVatTuPhuTung()
        'listVatTuPhuTung = New List(Of VatTuPhuTungDTO)
        'listCTPhieuSuaChua = New List(Of VatTuPhuTungDTO)

        ' Load VatTuPhuTung list
        Dim result As Result
        result = vatTuPhuTungBus.selectAll(Me.listVatTuPhuTungOnDB)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Vật tư phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
    End Sub

    Private Sub loadTienCongList()
        ' Load TienCong list to ComboBox
        listTienCong = New List(Of TienCongDTO)
        Dim result As Result
        result = tienCongBus.selectAll(listTienCong)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại Tiền công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbTienCong.DataSource = New BindingSource(listTienCong, String.Empty)
        cbTienCong.DisplayMember = "MucTien"
        cbTienCong.ValueMember = "MaLoaiTienCong"

    End Sub

    Private Sub buildDGVPhuTung()
        dgvPhuTung.DataSource = Nothing
        dgvPhuTung.Columns.Clear()

        dgvPhuTung.AutoGenerateColumns = False
        dgvPhuTung.AllowUserToAddRows = False
        dgvPhuTung.DataSource = listVatTuPhuTung

        Dim clMaLoaiPhuTung = New DataGridViewTextBoxColumn()
        clMaLoaiPhuTung.Name = "MaLoaiPhuTung"
        clMaLoaiPhuTung.HeaderText = "Mã Phụ Tùng"
        clMaLoaiPhuTung.DataPropertyName = "MaLoaiPhuTung"
        dgvPhuTung.Columns.Add(clMaLoaiPhuTung)

        Dim clTenLoaiPhuTung = New DataGridViewTextBoxColumn()
        clTenLoaiPhuTung.Name = "TenLoaiPhuTung"
        clTenLoaiPhuTung.HeaderText = "Tên Phụ Tùng"
        clTenLoaiPhuTung.DataPropertyName = "TenLoaiPhuTung"
        dgvPhuTung.Columns.Add(clTenLoaiPhuTung)

        Dim clDonGia = New DataGridViewTextBoxColumn()
        clDonGia.Name = "DonGia"
        clDonGia.HeaderText = "Đơn Giá"
        clDonGia.DataPropertyName = "DonGia"
        dgvPhuTung.Columns.Add(clDonGia)

        Dim clSoLuong = New DataGridViewTextBoxColumn()
        clSoLuong.Name = "SoLuong"
        clSoLuong.HeaderText = "Số Lượng"
        clSoLuong.DataPropertyName = "SoLuong"
        dgvPhuTung.Columns.Add(clSoLuong)

        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvPhuTung.DataSource)
        myCurrencyManager.Refresh()
    End Sub

    Private Sub cbMaPhieu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaPhieu.SelectedIndexChanged

        Try
            Dim psc = CType(cbMaPhieu.SelectedItem, PhieuSuaChuaDTO)
            txtBienSo.Text = psc.BienSoXe
            dtpNgaySuaChua.Value = psc.NgaySuaChua
            txtNoiDung.Text = psc.NoiDung
            cbTienCong.Text = psc.MaLoaiTienCong
            txtThanhTien.Text = psc.ThanhTien
            dgvPhuTungDuocChon.DataSource = Nothing
            dgvPhuTungDuocChon.Columns.Clear()

            dgvPhuTungDuocChon.AutoGenerateColumns = False
            dgvPhuTungDuocChon.AllowUserToAddRows = False
            dgvPhuTungDuocChon.DataSource = psc.ListCTPSC

            Dim clMaLoaiPhuTung = New DataGridViewTextBoxColumn()
            clMaLoaiPhuTung.Name = "MaLoaiPhuTung"
            clMaLoaiPhuTung.HeaderText = "Mã Phụ Tùng"
            clMaLoaiPhuTung.DataPropertyName = "MaLoaiPhuTung"
            dgvPhuTungDuocChon.Columns.Add(clMaLoaiPhuTung)
            clMaLoaiPhuTung.ReadOnly = True

            Dim clTenLoaiPhuTung = New DataGridViewTextBoxColumn()
            clTenLoaiPhuTung.Name = "TenLoaiPhuTung"
            clTenLoaiPhuTung.HeaderText = "Tên Phụ Tùng"
            clTenLoaiPhuTung.DataPropertyName = "TenLoaiPhuTung"
            dgvPhuTungDuocChon.Columns.Add(clTenLoaiPhuTung)
            clTenLoaiPhuTung.ReadOnly = True

            Dim clDonGia = New DataGridViewTextBoxColumn()
            clDonGia.Name = "DonGia"
            clDonGia.HeaderText = "Đơn Giá"
            clDonGia.DataPropertyName = "DonGia"
            dgvPhuTungDuocChon.Columns.Add(clDonGia)
            clDonGia.ReadOnly = True

            Dim clSoLuong = New DataGridViewTextBoxColumn()
            clSoLuong.Name = "SoLuong"
            clSoLuong.HeaderText = "Số Lượng"
            clSoLuong.DataPropertyName = "SoLuong"
            dgvPhuTungDuocChon.Columns.Add(clSoLuong)
            clSoLuong.ReadOnly = False

            Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvPhuTungDuocChon.DataSource)
            myCurrencyManager.Refresh()

            Me.listVatTuPhuTung.Clear()
            For Each vtpt In listVatTuPhuTungOnDB
                Me.listVatTuPhuTung.Add(vtpt)
            Next
            buildDGVPhuTung()

        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try

    End Sub

    Private Sub btnFromTo_Click(sender As Object, e As EventArgs) Handles btnFromTo.Click

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvPhuTung.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvPhuTung.RowCount) Then
            Try
                Dim vatTuPhuTung = CType(dgvPhuTung.Rows(currentRowIndex).DataBoundItem, VatTuPhuTungDTO)
                Dim phieuSuaChua = CType(cbMaPhieu.SelectedItem, PhieuSuaChuaDTO)
                'listVatTuPhuTung.Remove(vatTuPhuTung)
                'buildDGVPhuTung()

                phieuSuaChua.ListCTPSC.Add(New ChiTietPhieuSuaChuaDTO(1, 1, vatTuPhuTung.MaLoaiPhuTung, vatTuPhuTung.TenLoaiPhuTung, vatTuPhuTung.DonGia, vatTuPhuTung.SoLuong))



                dgvPhuTungDuocChon.DataSource = Nothing
                dgvPhuTungDuocChon.DataSource = phieuSuaChua.ListCTPSC
                Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvPhuTungDuocChon.DataSource)
                myCurrencyManager.Refresh()
                dgvPhuTungDuocChon.Rows(phieuSuaChua.ListCTPSC.Count - 1).Selected = False

                buildDGVPhuTung()
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If

    End Sub

    Private Sub btnToFrom_Click(sender As Object, e As EventArgs) Handles btnToFrom.Click

        Try
            Dim phieuSuaChua = CType(cbMaPhieu.SelectedItem, PhieuSuaChuaDTO)
            Dim vatTuPhuTung = CType(dgvPhuTungDuocChon.SelectedRows(0).DataBoundItem, ChiTietPhieuSuaChuaDTO)
            Dim currentRowIndex = dgvPhuTungDuocChon.SelectedRows(0).Index
            phieuSuaChua.ListCTPSC.Remove(vatTuPhuTung)
            'dgvHTDG.DataSource = Nothing
            'listMonHoc.Add(New MonHocDTO(ctct.MaMonHoc, ctct.TenMonHoc))
            For Each dt In listVatTuPhuTung
                If vatTuPhuTung.MaLoaiPhuTung = dt.MaLoaiPhuTung Then
                    dt.SoLuong += vatTuPhuTung.SoLuong
                End If
            Next
            buildDGVPhuTung()

            dgvPhuTungDuocChon.DataSource = Nothing
            dgvPhuTungDuocChon.DataSource = phieuSuaChua.ListCTPSC
            Dim myCurrencyManager As CurrencyManager = Me.BindingContext(dgvPhuTungDuocChon.DataSource)
            myCurrencyManager.Refresh()
            If (phieuSuaChua.ListCTPSC.Count > 0) Then
                If (currentRowIndex > 0) Then
                    currentRowIndex = currentRowIndex - 1
                End If
                dgvPhuTungDuocChon.Rows(currentRowIndex).Selected = True
                'ctct = CType(dgvMonHocChuongTrinh.Rows(currentRowIndex).DataBoundItem, ChiTietChuongTrinhDTO)
                'dgvHTDG.DataSource = Nothing
                'dgvHTDG.DataSource = ctct.ListHTDG
                'Dim myCurrencyManager11 As CurrencyManager = Me.BindingContext(dgvHTDG.DataSource)
                'myCurrencyManager11.Refresh()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try

    End Sub

    Private Sub cbTienCong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTienCong.SelectedIndexChanged

        If (cbTienCong.SelectedIndex > -1) Then
            thanhTien = 0
            thanhTien = CType(listTienCong(cbTienCong.SelectedIndex).MucTien, Int32) + thanhTien
            txtThanhTien.Text = thanhTien + thanhTien2
        End If

    End Sub



    Private Sub dgvPhuTungDuocChon_DataMemberChanged(sender As Object, e As EventArgs) Handles dgvPhuTungDuocChon.DataMemberChanged

        thanhTien2 = 0
        Dim phieuSuaChua = CType(cbMaPhieu.SelectedItem, PhieuSuaChuaDTO)
        For Each chiTiet In phieuSuaChua.ListCTPSC
            thanhTien2 += chiTiet.DonGia * chiTiet.SoLuong
        Next
        txtThanhTien.Text = thanhTien + thanhTien2

    End Sub

    Private Sub dgvPhuTungDuocChon_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhuTungDuocChon.CellValueChanged

        Dim currentRowIndex As Integer = dgvPhuTungDuocChon.CurrentCellAddress.Y
        Dim phieuSuaChua = CType(cbMaPhieu.SelectedItem, PhieuSuaChuaDTO)
        Dim phutung = phieuSuaChua.ListCTPSC(currentRowIndex)
        For Each vattu As VatTuPhuTungDTO In listVatTuPhuTung
            If vattu.MaLoaiPhuTung = phutung.MaLoaiPhuTung Then
                vattu.SoLuong = newList(listVatTuPhuTung.IndexOf(vattu)).SoLuong - phutung.SoLuong
            End If
        Next
        buildDGVPhuTung()

        thanhTien2 = 0
        For Each chiTiet In phieuSuaChua.ListCTPSC
            thanhTien2 += chiTiet.DonGia * chiTiet.SoLuong
        Next
        txtThanhTien.Text = thanhTien + thanhTien2

    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click

        Dim pscUpdated = New PhieuSuaChuaDTO()
        Dim psc = CType(cbMaPhieu.SelectedItem, PhieuSuaChuaDTO)
        '1. Mapping data from GUI control
        pscUpdated.MaPhieuSuaChua = psc.MaPhieuSuaChua
        pscUpdated.BienSoXe = txtBienSo.Text
        pscUpdated.NgaySuaChua = dtpNgaySuaChua.Value
        pscUpdated.NoiDung = txtNoiDung.Text
        pscUpdated.MaLoaiTienCong = cbTienCong.SelectedValue
        pscUpdated.ThanhTien = txtThanhTien.Text
        pscUpdated.ListCTPSC = psc.ListCTPSC
        ''2. Business .....
        'If (ctBus.isValidName(ctUpdated) = False) Then
        '    MessageBox.Show("Tên Chương Trình không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtTenCT.Focus()
        '    Return
        'End If
        '3. Insert to DB
        Dim result As Result
        result = pscBus.updatePSC_Cascade(pscUpdated)
        If (result.FlagResult = True) Then
            MessageBox.Show("Cập Nhật Phiếu Sữa Chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadMaPhieuSuaChua()
        Else
            MessageBox.Show("Cập Nhật Phiếu Sữa Chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub dgvPhuTung_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhuTung.CellContentClick

    End Sub

    Private Sub btnLapPhieuSC_Click_1(sender As Object, e As EventArgs) Handles btnLapPhieuSC.Click
        Dim LapPhieuSC As New Lapphieusuachua()
        LapPhieuSC.Maphieusuachua = cbMaPhieu.Text

        LapPhieuSC.Show()

    End Sub
End Class