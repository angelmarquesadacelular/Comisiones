Public Class LoginDlg
    Public permiso_id As Integer
    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        AccesarSistema()
    End Sub
    'Método que permite acceder al funcionamiento del sistema
    Private Sub AccesarSistema()
        'Encriptación del password del usuario
        Dim passwordEncriptado = EncriptarPassword(TbxPassword.Text)
        'Se obtiene el acceso del usuario
        permiso_id = AccesoUsuario(TbxUsuario.Text, passwordEncriptado)
        'Se verifica que el usuario tenga permiso de accesar al sistema
        If permiso_id > 0 Then

        End If
    End Sub

    Private Sub Limpiarformulario()
        TbxPassword.Text = ""
        TbxUsuario.Text = ""
    End Sub
End Class