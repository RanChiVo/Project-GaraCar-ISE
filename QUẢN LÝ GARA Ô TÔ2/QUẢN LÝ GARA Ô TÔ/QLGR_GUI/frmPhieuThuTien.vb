Imports System.Data.SqlClient
Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Imports Word = Microsoft.Office.Interop.Word

Public Class frmPhieuThuTien

    Private PhieuThuTien_BUS As PhieuThuTienBUS
    Private MaPhieuHienTai As String


    Public Delegate Sub mydel1(ByVal MaPhieuThuTien As String)

    Private Sub frmPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpNgayThuTien.CustomFormat = "dd/MM/yyyy" 'Format Ngay tiếp nhận
        dtpNgayThuTien.Format = DateTimePickerFormat.Custom

        PhieuThuTien_BUS = New PhieuThuTienBUS()
        Dim result As Result
        Dim nextMaPhieu = "PT000001"

        result = PhieuThuTien_BUS.buidlMaPTT(nextMaPhieu)

        If (result.FlagResult = True) Then
            txtMaPhieuThuTien.Text = nextMaPhieu
        End If

        txtMaKH.Enabled = False
        txtHoTen.Enabled = False
        txtBienSo.Enabled = False
        txtSoDienThoai.Enabled = False
        txtSoTienNoConLai.Enabled = False

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click

        Me.Close()

    End Sub

    Private Sub btnTimKiemKH_Click(sender As Object, e As EventArgs) Handles btnTimKiemKH.Click

        btnLapPhieu.BackColor = Color.Gray
        btnXong.BackColor = Color.Azure

        Dim KhachHangXe_DTO = New KhachHangXeDTO()
        Dim PhieuThuTien_DTO = New PhieuThuTienDTO()
        Dim PhieuSuaChua_DTO = New PhieuSuaChuaDTO()
        Dim result As Result

        PhieuThuTien_BUS = New PhieuThuTienBUS()

        If (txtMaPhieuSuaChua.Text.Length < 1) Then

            MessageBox.Show("Bạn chưa nhập Mã phiếu sửa chữa ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        result = PhieuThuTien_BUS.SelectThongTinKH(txtMaPhieuSuaChua.Text, KhachHangXe_DTO)

        If (result.FlagResult = False) Then

            MessageBox.Show("Lấy danh sách Khách hàng không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If

     
        txtBienSo.Text = KhachHangXe_DTO.BienSo1
        txtMaKH.Text = KhachHangXe_DTO.MaKH1
        txtHoTen.Text = KhachHangXe_DTO.HoTen1
        txtSoDienThoai.Text = KhachHangXe_DTO.SoDienThoai1
        txtSoTienNo.Text = KhachHangXe_DTO.SoTienNo1

        Dim result2 As Result
        result2 = PhieuThuTien_BUS.SelectTienSuaChua(Convert.ToInt32(txtMaPhieuSuaChua.Text), PhieuSuaChua_DTO)
        If (result2.FlagResult = False) Then

            MessageBox.Show("Lấy tiền sửa chữa của Khách hàng không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return

        End If

        txtTienSuaChua.Text = PhieuSuaChua_DTO.ThanhTien.ToString()


    End Sub

    Public Sub SetText(ByVal str As String)

        txtMaPhieuSuaChua.Text = str

    End Sub

    Private Sub btnTraCuuPSC_Click(sender As Object, e As EventArgs) Handles btnTraCuuPSC.Click

        btnXong.BackColor = Color.Azure

        Dim frm As XemPSC = New XemPSC()
        frm.ShowDialog()

    End Sub

    Private Sub btnXong_Click(sender As Object, e As EventArgs) Handles btnXong.Click

        Dim PhieuThuTien_DTO = New PhieuThuTienDTO()

        Try
            PhieuThuTien_DTO.SoTienThu = Convert.ToInt32(txtSoTienThu.Text)
        Catch ex As Exception
            MessageBox.Show("Tiền Thu của khách hàng của khách hàng chưa đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
            txtSoTienThu.Text = ""
        End Try

        Try

            Dim flag As Boolean = 1

            If (txtMaPhieuSuaChua.Text.Length < 1) Then

                MessageBox.Show("Bạn chưa nhập Mã phiếu sửa chữa ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = 0

            ElseIf (txtMaKH.Text.Length < 1 Or txtHoTen.Text.Length < 1 Or txtSoDienThoai.Text.Length < 1 Or txtBienSo.Text.Length < 1 Or txtMaPhieuThuTien.Text.Length < 1) Then

                MessageBox.Show("Bạn chưa cập nhật thông tin khách hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = 0

            ElseIf (txtSoTienThu.Text.Length < 1) Then

                MessageBox.Show("Bạn chưa nhập số tiền thu ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = 0

            ElseIf (txtTienSuaChua.Text.Length < 1) Then

                MessageBox.Show("Bạn chưa cập nhật số tiền sửa chửa ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = 0

            ElseIf (flag = True) Then

                btnXong.BackColor = Color.Red
                txtSoTienNoConLai.Text = (Convert.ToDecimal(txtSoTienNo.Text) - Convert.ToDecimal(txtSoTienThu.Text) +
                    Convert.ToDecimal(txtTienSuaChua.Text)).ToString()

                If (Convert.ToDecimal(txtSoTienNoConLai.Text) < 0) Then

                    MessageBox.Show("Số tiền thu của bạn không được vượt quá Số tiền nợ của khách hàng !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    btnXong.BackColor = Color.AliceBlue
                    flag = 0

                End If

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnLapPhieu_Click(sender As Object, e As EventArgs) Handles btnLapPhieu.Click

        If btnXong.BackColor = Color.Red Then

            btnLapPhieu.BackColor = Color.DarkViolet

            MaPhieuHienTai = txtMaPhieuThuTien.Text

            Dim PhieuThuTien_DTO As PhieuThuTienDTO
            PhieuThuTien_DTO = New PhieuThuTienDTO()
            Dim KhachHang_DTO As KhachHangDTO
            KhachHang_DTO = New KhachHangDTO()

            PhieuThuTien_DTO.MaPhieuSuaChua = txtMaPhieuSuaChua.Text
            PhieuThuTien_DTO.MaPhieuThuTien = txtMaPhieuThuTien.Text
            PhieuThuTien_DTO.SoTienThu = Convert.ToDecimal(txtSoTienThu.Text)
            PhieuThuTien_DTO.NgayThuTien = dtpNgayThuTien.Value

            KhachHang_DTO.MaKH = txtMaKH.Text

            PhieuThuTien_BUS = New PhieuThuTienBUS()
            Dim result As Result
            result = PhieuThuTien_BUS.insert(PhieuThuTien_DTO)

            If (result.FlagResult = True) Then
                MessageBox.Show("Lập phiếu thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(" Lập phiếu thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

            Dim nextMaPTT = "PT000001"
            result = PhieuThuTien_BUS.buidlMaPTT(nextMaPTT)
            If (result.FlagResult = True) Then
                txtMaPhieuThuTien.Text = nextMaPTT
            End If

            result = PhieuThuTien_BUS.UpdateTienNoKH(txtSoTienNoConLai.Text, KhachHang_DTO)

            If (result.FlagResult = True) Then
                MessageBox.Show("Cập nhật số tiền nợ của khách hàng thành công")
            Else
                MessageBox.Show("Cập nhật số tiền nợ mới của khách hàng thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else

            MessageBox.Show("Bạn chưa hoàn thành phiếu thu tiền")
            Return

        End If

    End Sub

    Private Sub btnXuatPhieu_Click(sender As Object, e As EventArgs) Handles btnXuatPhieu.Click

        If btnLapPhieu.BackColor = Color.DarkViolet Then


            Dim frm As New XUATPHIEUTHU

            frm.MaPhieuThu = MaPhieuHienTai
            frm.Show()

        Else

            MessageBox.Show("Ban chưa lập phiếu thu tiền")
            Return

        End If



    End Sub
End Class