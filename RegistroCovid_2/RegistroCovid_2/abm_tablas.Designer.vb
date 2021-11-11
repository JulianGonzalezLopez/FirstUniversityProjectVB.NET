<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_tablas
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
        Me.lbTitulo = New System.Windows.Forms.Button()
        Me.DGTabla = New System.Windows.Forms.DataGridView()
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbTitulo
        '
        Me.lbTitulo.FlatAppearance.BorderSize = 0
        Me.lbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbTitulo.Location = New System.Drawing.Point(187, 67)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(290, 54)
        Me.lbTitulo.TabIndex = 2
        Me.lbTitulo.Text = "xxxxxxxxxxxxxxxxxxxxx"
        Me.lbTitulo.UseVisualStyleBackColor = True
        '
        'DGTabla
        '
        Me.DGTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTabla.Location = New System.Drawing.Point(12, 143)
        Me.DGTabla.Name = "DGTabla"
        Me.DGTabla.Size = New System.Drawing.Size(638, 394)
        Me.DGTabla.TabIndex = 3
        '
        'abm_tablas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(662, 549)
        Me.Controls.Add(Me.DGTabla)
        Me.Controls.Add(Me.lbTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "abm_tablas"
        Me.Text = "abm_tablas"
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbTitulo As Button
    Friend WithEvents DGTabla As DataGridView
End Class
