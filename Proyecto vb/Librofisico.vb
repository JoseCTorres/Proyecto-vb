Friend Class Librofisico
    Inherits Libro

    Private cantidad As String

    Public Property _Cantidad As String
        Get
            Return cantidad
        End Get
        Set(ByVal value As String)
            cantidad = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        cantidad = String.Empty
    End Sub

    Public Sub New(ByVal titulo As String, ByVal genero As String, ByVal autor As String, ByVal codigo As String, ByVal cantidad As String)
        MyBase.New(titulo, genero, autor, codigo)
        Me.cantidad = cantidad
    End Sub


    Public Overrides Function ToString() As String
        Return MyBase.ToString() & " / " & "AMOUNT=" & cantidad & "   /   " & "DATE=" & DateTime.Now
    End Function
End Class

