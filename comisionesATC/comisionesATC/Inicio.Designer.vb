<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuInicio = New System.Windows.Forms.MenuStrip()
        Me.AccesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuInicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuInicio
        '
        Me.MenuInicio.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuInicio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccesoToolStripMenuItem, Me.CargarReportesToolStripMenuItem, Me.EstadísticasToolStripMenuItem})
        Me.MenuInicio.Location = New System.Drawing.Point(0, 0)
        Me.MenuInicio.Name = "MenuInicio"
        Me.MenuInicio.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuInicio.Size = New System.Drawing.Size(1053, 28)
        Me.MenuInicio.TabIndex = 0
        Me.MenuInicio.Text = "MenuStrip1"
        '
        'AccesoToolStripMenuItem
        '
        Me.AccesoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AccesoToolStripMenuItem.Name = "AccesoToolStripMenuItem"
        Me.AccesoToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.AccesoToolStripMenuItem.Text = "Acceso"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CargarReportesToolStripMenuItem
        '
        Me.CargarReportesToolStripMenuItem.Name = "CargarReportesToolStripMenuItem"
        Me.CargarReportesToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.CargarReportesToolStripMenuItem.Text = "Cargar Reportes"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 687)
        Me.Controls.Add(Me.MenuInicio)
        Me.MainMenuStrip = Me.MenuInicio
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comisiones ATC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuInicio.ResumeLayout(False)
        Me.MenuInicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuInicio As MenuStrip
    Friend WithEvents AccesoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As ToolStripMenuItem
End Class
