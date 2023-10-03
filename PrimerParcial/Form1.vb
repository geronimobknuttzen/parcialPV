Public Class Form1
    Dim password As String
    Public user As String  ' Obtener el contenido de la caja de texto



    Private Sub BtnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIniciar.Click
        'Regla para evitar que se ingrese un Usuario vacio al pasar los parametros al Form2
        user = TxtUsuario.Text
        password = TxtPassword.Text
        If String.IsNullOrEmpty(user) Then
            MessageBox.Show("Debe ingresar un Usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If password <> "abc123" Then
            MessageBox.Show("Contraseña Vacía o Incorrecta. Ingrese de nuevo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If user <> "" And password = "abc123" Then
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub TxtUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUsuario.KeyPress
        'Regla para evitar que los nombres de Usuario tengan espacio
        If e.KeyChar = Chr(32) Then
            ' Mostrar mensaje de advertencia
            MessageBox.Show("No se permiten espacios en los nombres de Usuario")
            ' Cancelar la tecla presionada (no se agrega el espacio)
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassword.KeyPress
        'Regla para evitar que la tengan espacio
        If e.KeyChar = Chr(32) Then
            ' Mostrar mensaje de advertencia
            MessageBox.Show("No se permiten espacios en la Contraseña")
            ' Cancelar la tecla presionada (no se agrega el espacio)
            e.Handled = True
        End If
    End Sub
End Class
