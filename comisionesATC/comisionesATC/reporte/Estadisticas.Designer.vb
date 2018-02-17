<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Estadisticas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estadisticas))
        Me.CREstadisticas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CREstadisticas
        '
        Me.CREstadisticas.ActiveViewIndex = -1
        Me.CREstadisticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CREstadisticas.Cursor = System.Windows.Forms.Cursors.Default
        Me.CREstadisticas.Location = New System.Drawing.Point(12, 12)
        Me.CREstadisticas.Name = "CREstadisticas"
        Me.CREstadisticas.ShowLogo = False
        Me.CREstadisticas.Size = New System.Drawing.Size(1435, 865)
        Me.CREstadisticas.TabIndex = 16
        Me.CREstadisticas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1459, 1045)
        Me.Controls.Add(Me.CREstadisticas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Estadisticas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estadisticas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CREstadisticas As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
