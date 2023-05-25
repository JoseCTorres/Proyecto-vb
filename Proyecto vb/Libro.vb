Public Class Libro
    Public titulo As String
    Public autor As String
    Public genero As String
    Public codigo As String

    Public Property _Titulo As String
        Get
            Return titulo
        End Get
        Set(ByVal value As String)
            titulo = value
        End Set
    End Property

    Public Property _Autor As String
        Get
            Return autor
        End Get
        Set(ByVal value As String)
            autor = value
        End Set
    End Property

    Public Property _Genero As String
        Get
            Return genero
        End Get
        Set(ByVal value As String)
            genero = value
        End Set
    End Property

    Public Property _Codigo As String
        Get
            Return codigo
        End Get
        Set(ByVal value As String)
            codigo = value
        End Set
    End Property

    Public Sub New()
        titulo = String.Empty
        autor = String.Empty
        genero = String.Empty
        codigo = String.Empty
    End Sub

    Public Sub New(ByVal titulo As String, ByVal genero As String, ByVal autor As String, ByVal codigo As String)
        Me.titulo = titulo
        Me.autor = autor
        Me.genero = genero
        Me.codigo = codigo
    End Sub

    Public Overrides Function ToString() As String
        Return "TITLE=" & titulo.ToUpper() & "  /  " & "AUTHOR=" & autor.ToUpper() & "  /  " & " GENDER= " & genero.ToUpper() & "  /  " & "CODE=" & codigo.ToUpper()
    End Function

End Class
