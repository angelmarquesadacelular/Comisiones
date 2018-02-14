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
            Limpiarformulario()
            Inicio.EstadísticasToolStripMenuItem.Enabled = True
            Inicio.CargarReportesToolStripMenuItem.Enabled = True
            Inicio.SalirToolStripMenuItem.Enabled = True
            Inicio.LoginToolStripMenuItem.Enabled = False
            Me.Visible = False
        Else
            MsgBox("Datos de acceso incorrectos", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
            Limpiarformulario()
        End If
    End Sub

    Private Sub Limpiarformulario()
        TbxPassword.Text = ""
        TbxUsuario.Text = ""
    End Sub

    Private Sub LoginDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        permiso_id = 0
    End Sub
End Class