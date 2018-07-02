

Public Class TaiKhoanDTO

    Private UserName As String
    Private PassWord As String

    Public Sub New()
    End Sub

    Public Sub New(UserName As String, PassWord As String)

        Me.UserName1 = UserName
        Me.PassWord1 = PassWord

    End Sub

    Public Property UserName1 As String
        Get
            Return UserName
        End Get
        Set(value As String)
            UserName = value
        End Set
    End Property

    Public Property PassWord1 As String
        Get
            Return PassWord
        End Get
        Set(value As String)
            PassWord = value
        End Set
    End Property

End Class
