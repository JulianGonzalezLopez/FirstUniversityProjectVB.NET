<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_borrar
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
        Me.tDNI = New System.Windows.Forms.TextBox()
        Me.btnDNI = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tDNI
        '
        Me.tDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tDNI.Location = New System.Drawing.Point(357, 184)
        Me.tDNI.Name = "tDNI"
        Me.tDNI.Size = New System.Drawing.Size(100, 20)
        Me.tDNI.TabIndex = 22
        '
        'btnDNI
        '
        Me.btnDNI.FlatAppearance.BorderSize = 0
        Me.btnDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDNI.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDNI.Location = New System.Drawing.Point(194, 173)
        Me.btnDNI.Name = "btnDNI"
        Me.btnDNI.Size = New System.Drawing.Size(89, 31)
        Me.btnDNI.TabIndex = 21
        Me.btnDNI.Text = "DNI a borrar"
        Me.btnDNI.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBorrar.Location = New System.Drawing.Point(382, 234)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 23
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'abm_borrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(662, 549)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.tDNI)
        Me.Controls.Add(Me.btnDNI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "abm_borrar"
        Me.Text = "abm_borrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tDNI As TextBox
    Friend WithEvents btnDNI As Button
    Friend WithEvents btnBorrar As Button
End Class
