Public Class ThamSoDTO


    Private iSoXeToiDa As Integer

    Public Sub New()
    End Sub

    Public Property SoXeToiDa As Integer
        Get
            Return iSoXeToiDa
        End Get
        Set(value As Integer)
            iSoXeToiDa = value
        End Set
    End Property


End Class
