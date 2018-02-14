Public Class LoginDlg
    Public permiso_id As Integer
    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        AccesarSistema()
    End Sub
    'Método que permite acceder al funcionamiento del sistema
    Private Sub AccesarSistema()
        If TbxUsuario.Text.Length() > 0 Then
            If TbxPassword.Text.Length() > 0 Then
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
            Else
                MsgBox("Favor de teclear el password de acceso", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
                TbxPassword.Select()
            End If
        Else
            MsgBox("Favor de teclear el usuario de acceso", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
            TbxUsuario.Select()
        End If
    End Sub

    Private Sub Limpiarformulario()
        TbxPassword.Text = ""
        TbxUsuario.Text = ""
    End Sub

    Private Sub LoginDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        permiso_id = 0
    End Sub

    Private Sub TbxUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxUsuario.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                AccesarSistema()
        End Select
    End Sub

    Private Sub TbxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TbxPassword.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                AccesarSistema()
        End Select
    End Sub

    Private Sub LoginDlg_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                AccesarSistema()
        End Select
    End Sub
End Class