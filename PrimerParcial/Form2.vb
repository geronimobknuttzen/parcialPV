Public Class Form2
    Dim fecha As Date = Date.Now()

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        'Cerrar el programa al hacer click en Salir
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LblBienvenida.Text = "Bienvenido " & Form1.user
        LblFecha.Text = fecha.ToString("dd/MM/yyyy")
    End Sub

End Class