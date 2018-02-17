<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginDlg
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginDlg))
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.TbxUsuario = New System.Windows.Forms.TextBox()
        Me.LbPassword = New System.Windows.Forms.Label()
        Me.TbxPassword = New System.Windows.Forms.TextBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.Location = New System.Drawing.Point(12, 9)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(57, 17)
        Me.LbUsuario.TabIndex = 0
        Me.LbUsuario.Text = "Usuario"
        '
        'TbxUsuario
        '
        Me.TbxUsuario.Location = New System.Drawing.Point(87, 6)
        Me.TbxUsuario.Name = "TbxUsuario"
        Me.TbxUsuario.Size = New System.Drawing.Size(206, 22)
        Me.TbxUsuario.TabIndex = 1
        '
        'LbPassword
        '
        Me.LbPassword.AutoSize = True
        Me.LbPassword.Location = New System.Drawing.Point(12, 52)
        Me.LbPassword.Name = "LbPassword"
        Me.LbPassword.Size = New System.Drawing.Size(69, 17)
        Me.LbPassword.TabIndex = 2
        Me.LbPassword.Text = "Password"
        '
        'TbxPassword
        '
        Me.TbxPassword.Location = New System.Drawing.Point(87, 49)
        Me.TbxPassword.Name = "TbxPassword"
        Me.TbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbxPassword.Size = New System.Drawing.Size(206, 22)
        Me.TbxPassword.TabIndex = 3
        '
        'BtnEntrar
        '
        Me.BtnEntrar.Location = New System.Drawing.Point(122, 88)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(75, 36)
        Me.BtnEntrar.TabIndex = 4
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.UseVisualStyleBackColor = True
        '
        'LoginDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 136)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.TbxPassword)
        Me.Controls.Add(Me.LbPassword)
        Me.Controls.Add(Me.TbxUsuario)
        Me.Controls.Add(Me.LbUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LoginDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbUsuario As Label
    Friend WithEvents TbxUsuario As TextBox
    Friend WithEvents LbPassword As Label
    Friend WithEvents TbxPassword As TextBox
    Friend WithEvents BtnEntrar As Button
End Class
