<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class abm_primera_dosis
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
        Me.tDNI = New System.Windows.Forms.TextBox()
        Me.btnDNI = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.tValoraciones = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbVacuna = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tDNI
        '
        Me.tDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tDNI.Location = New System.Drawing.Point(339, 151)
        Me.tDNI.Name = "tDNI"
        Me.tDNI.Size = New System.Drawing.Size(100, 20)
        Me.tDNI.TabIndex = 10
        '
        'btnDNI
        '
        Me.btnDNI.FlatAppearance.BorderSize = 0
        Me.btnDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDNI.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDNI.Location = New System.Drawing.Point(170, 140)
        Me.btnDNI.Name = "btnDNI"
        Me.btnDNI.Size = New System.Drawing.Size(89, 31)
        Me.btnDNI.TabIndex = 9
        Me.btnDNI.Text = "DNI"
        Me.btnDNI.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEnviar.Location = New System.Drawing.Point(364, 319)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 12
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'tValoraciones
        '
        Me.tValoraciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tValoraciones.Location = New System.Drawing.Point(339, 192)
        Me.tValoraciones.Name = "tValoraciones"
        Me.tValoraciones.Size = New System.Drawing.Size(100, 20)
        Me.tValoraciones.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(170, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 31)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Valoraciones"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbVacuna
        '
        Me.cbVacuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVacuna.FormattingEnabled = True
        Me.cbVacuna.Items.AddRange(New Object() {"Sputnik V", "Covidshield", "Sinopharm", "AstraZeneca"})
        Me.cbVacuna.Location = New System.Drawing.Point(339, 236)
        Me.cbVacuna.Name = "cbVacuna"
        Me.cbVacuna.Size = New System.Drawing.Size(100, 21)
        Me.cbVacuna.TabIndex = 18
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button7.Location = New System.Drawing.Point(170, 226)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(89, 31)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "Vacuna"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(339, 272)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 16
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button5.Location = New System.Drawing.Point(170, 263)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 31)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Fecha de vacunado"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'abm_primera_dosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(662, 549)
        Me.Controls.Add(Me.cbVacuna)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.tValoraciones)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.tDNI)
        Me.Controls.Add(Me.btnDNI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "abm_primera_dosis"
        Me.Text = "h"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tDNI As TextBox
    Friend WithEvents btnDNI As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents tValoraciones As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cbVacuna As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Button5 As Button
End Class
