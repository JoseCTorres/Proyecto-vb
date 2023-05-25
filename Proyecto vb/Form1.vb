Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        Dim a As Librofisico() = New Librofisico(43) {}
        Dim i As Integer = 0
        If i < a.Length Then
            Dim x As Librofisico = New Librofisico()
            Dim sw As StreamWriter = New StreamWriter("..prograproyec.txt", True, Encoding.ASCII)
            x._Titulo = TextBoxTITLE.Text
            x._Autor = TextBoxAUTHOR.Text
            x._Cantidad = TextBoxAMOUNT.Text
            x._Genero = ComboBox1.Text
            x._Codigo = TextBoxCODE.Text
            sw.WriteLine(x.ToString())
            sw.Close()
            Dim sr As StreamReader = New StreamReader("..prograproyec.txt")
            RichTextBox1.Text = sr.ReadToEnd()
            sr.Close()
        End If
    End Sub
End Class
