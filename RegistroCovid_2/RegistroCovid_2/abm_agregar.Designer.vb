<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abm_agregar
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.tNombres = New System.Windows.Forms.TextBox()
        Me.tApellidos = New System.Windows.Forms.TextBox()
        Me.tDNI = New System.Windows.Forms.TextBox()
        Me.tEmail = New System.Windows.Forms.TextBox()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.cbGenero = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.Location = New System.Drawing.Point(112, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Nombre/s"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(112, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Apellido/s"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button3.Location = New System.Drawing.Point(112, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 31)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "DNI"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button4.Location = New System.Drawing.Point(112, 244)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 31)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Email"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button5.Location = New System.Drawing.Point(112, 318)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 31)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Fecha de nacimiento"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'tNombres
        '
        Me.tNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tNombres.Location = New System.Drawing.Point(281, 144)
        Me.tNombres.Name = "tNombres"
        Me.tNombres.Size = New System.Drawing.Size(100, 20)
        Me.tNombres.TabIndex = 6
        '
        'tApellidos
        '
        Me.tApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tApellidos.Location = New System.Drawing.Point(281, 181)
        Me.tApellidos.Name = "tApellidos"
        Me.tApellidos.Size = New System.Drawing.Size(100, 20)
        Me.tApellidos.TabIndex = 7
        '
        'tDNI
        '
        Me.tDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tDNI.Location = New System.Drawing.Point(281, 218)
        Me.tDNI.Name = "tDNI"
        Me.tDNI.Size = New System.Drawing.Size(100, 20)
        Me.tDNI.TabIndex = 8
        '
        'tEmail
        '
        Me.tEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tEmail.Location = New System.Drawing.Point(281, 255)
        Me.tEmail.Name = "tEmail"
        Me.tEmail.Size = New System.Drawing.Size(100, 20)
        Me.tEmail.TabIndex = 9
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(281, 327)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.dtpNacimiento.TabIndex = 10
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button6.Location = New System.Drawing.Point(441, 289)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Enviar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button7.Location = New System.Drawing.Point(112, 281)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(89, 31)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Genero"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'cbGenero
        '
        Me.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenero.FormattingEnabled = True
        Me.cbGenero.Items.AddRange(New Object() {"Masculino", "Femenino", "Neutro", "Prefiere no decirlo"})
        Me.cbGenero.Location = New System.Drawing.Point(281, 291)
        Me.cbGenero.Name = "cbGenero"
        Me.cbGenero.Size = New System.Drawing.Size(100, 21)
        Me.cbGenero.TabIndex = 13
        '
        'abm_agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(662, 549)
        Me.Controls.Add(Me.cbGenero)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.dtpNacimiento)
        Me.Controls.Add(Me.tEmail)
        Me.Controls.Add(Me.tDNI)
        Me.Controls.Add(Me.tApellidos)
        Me.Controls.Add(Me.tNombres)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "abm_agregar"
        Me.Text = "abm_agregar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents tNombres As TextBox
    Friend WithEvents tApellidos As TextBox
    Friend WithEvents tDNI As TextBox
    Friend WithEvents tEmail As TextBox
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents cbGenero As ComboBox
End Class
