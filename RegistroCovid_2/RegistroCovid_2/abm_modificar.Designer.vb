<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_modificar
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
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.tEmail = New System.Windows.Forms.TextBox()
        Me.tApellidos = New System.Windows.Forms.TextBox()
        Me.tNombres = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tDNI
        '
        Me.tDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tDNI.Location = New System.Drawing.Point(290, 95)
        Me.tDNI.Name = "tDNI"
        Me.tDNI.Size = New System.Drawing.Size(100, 20)
        Me.tDNI.TabIndex = 22
        '
        'btnDNI
        '
        Me.btnDNI.FlatAppearance.BorderSize = 0
        Me.btnDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDNI.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDNI.Location = New System.Drawing.Point(48, 88)
        Me.btnDNI.Name = "btnDNI"
        Me.btnDNI.Size = New System.Drawing.Size(212, 31)
        Me.btnDNI.TabIndex = 21
        Me.btnDNI.Text = "DNI de los datos a modificar"
        Me.btnDNI.UseVisualStyleBackColor = True
        '
        'cbGenero
        '
        Me.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"Masculino", "Femenino", "Neutro", "Prefiere no decirlo"})
        Me.cbGenero.Location = New System.Drawing.Point(290, 280)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(100, 21)
        Me.cbGenero.TabIndex = 35
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button7.Location = New System.Drawing.Point(121, 270)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(89, 31)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "Genero"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnActualizar.Location = New System.Drawing.Point(453, 313)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 33
        Me.btnActualizar.Text = "Modificar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(290, 316)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.dtpNacimiento.TabIndex = 32
        '
        'tEmail
        '
        Me.tEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tEmail.Location = New System.Drawing.Point(290, 244)
        Me.tEmail.Name = "tEmail"
        Me.tEmail.Size = New System.Drawing.Size(100, 20)
        Me.tEmail.TabIndex = 31
        '
        'tApellidos
        '
        Me.tApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tApellidos.Location = New System.Drawing.Point(291, 206)
        Me.tApellidos.Name = "tApellidos"
        Me.tApellidos.Size = New System.Drawing.Size(100, 20)
        Me.tApellidos.TabIndex = 29
        '
        'tNombres
        '
        Me.tNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tNombres.Location = New System.Drawing.Point(291, 169)
        Me.tNombres.Name = "tNombres"
        Me.tNombres.Size = New System.Drawing.Size(100, 20)
        Me.tNombres.TabIndex = 28
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button5.Location = New System.Drawing.Point(121, 307)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 31)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Fecha de nacimiento"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button4.Location = New System.Drawing.Point(121, 233)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 31)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Email"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(122, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 31)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Apellido/s"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.Location = New System.Drawing.Point(122, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 31)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Nombre/s"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'abm_modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(662, 549)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.dtpNacimiento)
        Me.Controls.Add(Me.tEmail)
        Me.Controls.Add(Me.tApellidos)
        Me.Controls.Add(Me.tNombres)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tDNI)
        Me.Controls.Add(Me.btnDNI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "abm_modificar"
        Me.Text = "abm_modificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tDNI As TextBox
    Friend WithEvents btnDNI As Button
    Friend WithEvents cbGenero As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents tEmail As TextBox
    Friend WithEvents tApellidos As TextBox
    Friend WithEvents tNombres As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
