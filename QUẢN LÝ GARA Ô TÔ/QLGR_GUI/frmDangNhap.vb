Imports System.Configuration
Imports System.Data.SqlClient


Public Class frmDangNhap

    Private connectionstring = ConfigurationManager.AppSettings("ConnectionString")
    Private conn As SqlConnection
    Private adapter As SqlDataAdapter
    Private LoginResult As DialogResult

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub


    Private Function getDataTable(sqlQuery As String) As DataTable

        'Thu hien get data khi thuc thi cau lenh sql lay du lieu tu tai khoan thong tin user- passwword
        Dim DataTable As New DataTable
        conn = New SqlConnection(connectionstring)

        adapter = New SqlDataAdapter(sqlQuery, conn)

        Try
            conn.Open()

            adapter.Fill(DataTable)

        Catch ex As Exception
            MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

        Return DataTable

    End Function

    Private Function CheckLogin(user As String, pass As String)

        Dim sqlQuery As String = String.Format("Select* from tblTAIKHOAN where username = '{0}' and pass ='{1}' ", user, pass)
        Dim dTable As DataTable = getDataTable(sqlQuery)

        Return dTable.Rows.Count > 0

    End Function

    Private Function IsEmpty() As Boolean

        Return String.IsNullOrEmpty(Me.txtuser.Text) OrElse String.IsNullOrEmpty(Me.txtpassword.Text)

    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        imageAnimation.ShowSync(btnLogin)
        imageAnimation.ShowSync(logo)
        user.Location = New Point(95, 36)

        lineAimation.ShowSync(txtpassword)
        lineAimation.ShowSync(txtuser)
        user.Location = New Point(95, 52)

        loginAnimation.ShowSync(btnLogin)
        user.Location = New Point(95, 36)
        user.Location = New Point(95, 60)

        If IsEmpty() Then

            MessageBox.Show("Your Username, password cannot be empty!")
        Else

            If CheckLogin(Me.txtuser.Text, Me.txtpassword.Text) Then

                Me.DialogResult = Windows.Forms.DialogResult.OK
                MessageBox.Show("Login Successful!")
                Me.Close()

            Else

                MessageBox.Show("Your Username or your password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub txtpassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtpassword.OnValueChanged

        txtpassword.isPassword = 1

    End Sub


End Class