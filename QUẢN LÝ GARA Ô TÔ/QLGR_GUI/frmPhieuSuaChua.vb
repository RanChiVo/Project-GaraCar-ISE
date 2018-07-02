<<<<<<< HEAD
﻿Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility

Public Class frmPhieuSuaChua

    Private pscBus As PhieuSuaChuaBUS
    Private tienCongBus As TienCongBUS
    Private xeBus As XeBUS
    Private ListXe As List(Of XeDTO)
    Private vatTuPhuTungBus As VatTuPhuTungBUS
    Private listVatTuPhuTung As List(Of VatTuPhuTungDTO)
    Private listPhieuSuaChua As List(Of PhieuSuaChuaDTO)
    Private listCTPhieuSuaChua As List(Of ChiTietPhieuSuaChuaDTO)
    Private thanhTien As Integer
    Private thanhTien2 As Integer
    Private listTienCong As List(Of TienCongDTO)
    Private newList As List(Of VatTuPhuTungDTO)
    Private MaPhieuSC As String

    Private Sub frmThemPhieuSuaChua_v2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pscBus = New PhieuSuaChuaBUS()
        tienCongBus = New TienCongBUS()

        xeBus = New XeBUS()
        ListXe = New List(Of XeDTO)

        vatTuPhuTungBus = New VatTuPhuTungBUS()
        newList = New List(Of VatTuPhuTungDTO)

        listVatTuPhuTung = New List(Of VatTuPhuTungDTO)
        'listPhieuSuaChua = New List(Of PhieuSuaChuaDTO)
        listCTPhieuSuaChua = New List(Of ChiTietPhieuSuaChuaDTO)

        loadListVatTuPhuTung()

        buildDGVPhuTung()
        buildDGVPhuTungDuocChon()

        loadIDAuto()
        loadTienCongList()
        loadBienSoList() 'bi loi

        cbTienCong.SelectedValue = 0

        For Each dr In listVatTuPhuTung
            newList.Add(dr.Clone)
        Next
    End Sub

    Private Sub loadIDAuto()
        'set ID auto
        Dim nextIDPSC As Integer
        Dim result As Result
        result = pscBus.getNextIDPSC(nextIDPSC)

        If (result.FlagResult = True) Then
            txtMaPhieu.Text = nextIDPSC.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của mã Phiếu Sữa Chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
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

        End If
        cbTienCong.DataSource = New BindingSource(listTienCong, String.Empty)
        cbTienCong.DisplayMember = "MucTien"
        cbTienCong.ValueMember = "MaLoaiTienCong"
    End Sub

    Private Sub loadBienSoList()

        ' Load BienSo list to ComboBox
        Dim listBienSo = New List(Of XeDTO)
        Dim result As Result
        result = xeBus.selectAllPSC(listBienSo)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Biển số không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbBienSo.DataSource = Nothing
        cbBienSo.DataSource = New BindingSource(listBienSo, String.Empty)
        cbBienSo.DisplayMember = "BienSo"
        cbBienSo.ValueMember = "BienSo"

    End Sub

    Private Sub loadListVatTuPhuTung()
        listVatTuPhuTung = New List(Of VatTuPhuTungDTO)
        'listPhieuSuaChua = New List(Of PhieuSuaChuaDTO)
        listCTPhieuSuaChua = New List(Of ChiTietPhieuSuaChuaDTO)

        ' Load VatTuPhuTung list
        Dim result As Result
        result = vatTuPhuTungBus.selectAll(listVatTuPhuTung)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Vật tư phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
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

    Private Sub buildDGVPhuTungDuocChon()
        dgvPhuTungDuocChon.DataSource = Nothing
        dgvPhuTungDuocChon.Columns.Clear()

        dgvPhuTungDuocChon.AutoGenerateColumns = False
        dgvPhuTungDuocChon.AllowUserToAddRows = False
        dgvPhuTungDuocChon.DataSource = listCTPhieuSuaChua

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
    End Sub

    Private Sub btnFromTo_Click(sender As Object, e As EventArgs) Handles btnFromTo.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvPhuTung.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvPhuTung.RowCount) Then
            Try
                Dim vatTuPhuTung = CType(dgvPhuTung.Rows(currentRowIndex).DataBoundItem, VatTuPhuTungDTO)
                'Dim psc = CType(dgvPhuTungDuocChon.Rows(currentRowIndex).DataBoundItem, PhieuSuaChuaDTO)
                listCTPhieuSuaChua.Add(New ChiTietPhieuSuaChuaDTO(1, 1, vatTuPhuTung.MaLoaiPhuTung, vatTuPhuTung.TenLoaiPhuTung, vatTuPhuTung.DonGia, vatTuPhuTung.SoLuong))

                buildDGVPhuTung()
                buildDGVPhuTungDuocChon()
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnToFrom_Click(sender As Object, e As EventArgs) Handles btnToFrom.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvPhuTungDuocChon.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvPhuTungDuocChon.RowCount) Then
            Try
                Dim ctpsc = CType(dgvPhuTungDuocChon.Rows(currentRowIndex).DataBoundItem, ChiTietPhieuSuaChuaDTO)
                listCTPhieuSuaChua.Remove(ctpsc)
                For Each dt In listVatTuPhuTung
                    If ctpsc.MaLoaiPhuTung = dt.MaLoaiPhuTung Then
                        dt.SoLuong += ctpsc.SoLuong
                    End If
                Next

                buildDGVPhuTung()
                buildDGVPhuTungDuocChon()
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        MaPhieuSC = txtMaPhieu.Text

        Dim psc As PhieuSuaChuaDTO
        psc = New PhieuSuaChuaDTO()

        '1. Mapping data from GUI control
        ''psc.MaPhieuSuaChua = Convert.ToInt32(txtMaPhieu.Text)
        psc.MaPhieuSuaChua = 1
        psc.BienSoXe = cbBienSo.Text
        psc.NgaySuaChua = dtpNgaySuaChua.Value
        psc.NoiDung = txtNoiDung.Text
        ''psc.MaLoaiTienCong = cbTienCong.SelectedValue ---> lưu vào DB là MaLoaiTienCong
        psc.MaLoaiTienCong = cbTienCong.SelectedValue      '---->Lưu vào DB là MucTien
        psc.ThanhTien = txtThanhTien.Text
        psc.ListCTPSC = Me.listCTPhieuSuaChua

        '2. Insert to DB
        Dim result As Result
        result = pscBus.insertPSC(psc)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Phiếu Sữa Chữa thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNoiDung.Text = String.Empty
            txtThanhTien.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = pscBus.getNextIDPSC(nextID)
            If (result.FlagResult = True) Then
                txtMaPhieu.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Phiếu Sữa Chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If
            vatTuPhuTungBus.updateList(listVatTuPhuTung)

            loadListVatTuPhuTung()
            buildDGVPhuTung()
            listCTPhieuSuaChua = New List(Of ChiTietPhieuSuaChuaDTO)
            buildDGVPhuTungDuocChon()


        Else
            MessageBox.Show("Thêm Phiếu Sữa Chữa không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If


    End Sub

    Private Sub txtThanhTien_TextChanged(sender As Object, e As EventArgs) Handles txtThanhTien.TextChanged

    End Sub

    Private Sub cbTienCong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTienCong.SelectedIndexChanged
        If (cbTienCong.SelectedIndex > -1) Then
            thanhTien = 0
            thanhTien = CType(listTienCong(cbTienCong.SelectedIndex).MucTien, Int32) + thanhTien
            txtThanhTien.Text = thanhTien + thanhTien2
        End If

    End Sub

    Private Sub dgvPhuTungDuocChon_DataMemberChanged(sender As Object, e As EventArgs) Handles dgvPhuTungDuocChon.DataSourceChanged
        thanhTien2 = 0
        For Each chiTiet In listCTPhieuSuaChua
            thanhTien2 += chiTiet.DonGia * chiTiet.SoLuong
        Next
        txtThanhTien.Text = thanhTien + thanhTien2
    End Sub

    Private Sub dgvPhuTungDuocChon_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhuTungDuocChon.CellValueChanged

        Dim currentRowIndex As Integer = dgvPhuTungDuocChon.CurrentCellAddress.Y
        Dim phutung = listCTPhieuSuaChua(currentRowIndex)
        For Each vattu As VatTuPhuTungDTO In listVatTuPhuTung
            If vattu.MaLoaiPhuTung = phutung.MaLoaiPhuTung Then
                vattu.SoLuong = newList(listVatTuPhuTung.IndexOf(vattu)).SoLuong - phutung.SoLuong
            End If
        Next
        buildDGVPhuTung()
        buildDGVPhuTungDuocChon()

        thanhTien2 = 0
        For Each chiTiet In listCTPhieuSuaChua
            thanhTien2 += chiTiet.DonGia * chiTiet.SoLuong
        Next
        txtThanhTien.Text = thanhTien + thanhTien2

    End Sub

    Private Sub btnLapPhieuSC_Click(sender As Object, e As EventArgs)

        Dim frmLAPSC As New Lapphieusuachua

        frmLAPSC.Maphieusuachua = MaPhieuSC

        frmLAPSC.Show()

    End Sub

=======
﻿Public Class frmPhieuSuaChua
    Private Sub fmrPhieuSuaChua_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
>>>>>>> d323ab7ba7f63f60c39be1ba115b7be6ef87ea7d
End Class