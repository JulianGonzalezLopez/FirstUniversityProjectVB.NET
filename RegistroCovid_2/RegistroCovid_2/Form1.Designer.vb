<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.panelPaneles = New System.Windows.Forms.Panel()
        Me.panelTablas = New System.Windows.Forms.Panel()
        Me.btnTablaCompleto = New System.Windows.Forms.Button()
        Me.btnTablaPrimera = New System.Windows.Forms.Button()
        Me.btnTablaIngresados = New System.Windows.Forms.Button()
        Me.btnTablas = New System.Windows.Forms.Button()
        Me.panelABM = New System.Windows.Forms.Panel()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSegunda = New System.Windows.Forms.Button()
        Me.btnPrimera = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnABM = New System.Windows.Forms.Button()
        Me.panelChildForm = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelPaneles.SuspendLayout()
        Me.panelTablas.SuspendLayout()
        Me.panelABM.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelPaneles
        '
        Me.panelPaneles.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panelPaneles.Controls.Add(Me.Label1)
        Me.panelPaneles.Controls.Add(Me.panelTablas)
        Me.panelPaneles.Controls.Add(Me.btnTablas)
        Me.panelPaneles.Controls.Add(Me.panelABM)
        Me.panelPaneles.Controls.Add(Me.btnABM)
        Me.panelPaneles.Location = New System.Drawing.Point(12, 12)
        Me.panelPaneles.Name = "panelPaneles"
        Me.panelPaneles.Size = New System.Drawing.Size(200, 549)
        Me.panelPaneles.TabIndex = 0
        '
        'panelTablas
        '
        Me.panelTablas.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panelTablas.Controls.Add(Me.btnTablaCompleto)
        Me.panelTablas.Controls.Add(Me.btnTablaPrimera)
        Me.panelTablas.Controls.Add(Me.btnTablaIngresados)
        Me.panelTablas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTablas.Location = New System.Drawing.Point(0, 255)
        Me.panelTablas.Name = "panelTablas"
        Me.panelTablas.Size = New System.Drawing.Size(200, 157)
        Me.panelTablas.TabIndex = 4
        '
        'btnTablaCompleto
        '
        Me.btnTablaCompleto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTablaCompleto.FlatAppearance.BorderSize = 0
        Me.btnTablaCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTablaCompleto.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTablaCompleto.Location = New System.Drawing.Point(0, 70)
        Me.btnTablaCompleto.Name = "btnTablaCompleto"
        Me.btnTablaCompleto.Size = New System.Drawing.Size(200, 35)
        Me.btnTablaCompleto.TabIndex = 2
        Me.btnTablaCompleto.Text = "Plan completo"
        Me.btnTablaCompleto.UseVisualStyleBackColor = True
        '
        'btnTablaPrimera
        '
        Me.btnTablaPrimera.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTablaPrimera.FlatAppearance.BorderSize = 0
        Me.btnTablaPrimera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTablaPrimera.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTablaPrimera.Location = New System.Drawing.Point(0, 35)
        Me.btnTablaPrimera.Name = "btnTablaPrimera"
        Me.btnTablaPrimera.Size = New System.Drawing.Size(200, 35)
        Me.btnTablaPrimera.TabIndex = 1
        Me.btnTablaPrimera.Text = "Primera dosis"
        Me.btnTablaPrimera.UseVisualStyleBackColor = True
        '
        'btnTablaIngresados
        '
        Me.btnTablaIngresados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTablaIngresados.FlatAppearance.BorderSize = 0
        Me.btnTablaIngresados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTablaIngresados.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTablaIngresados.Location = New System.Drawing.Point(0, 0)
        Me.btnTablaIngresados.Name = "btnTablaIngresados"
        Me.btnTablaIngresados.Size = New System.Drawing.Size(200, 35)
        Me.btnTablaIngresados.TabIndex = 0
        Me.btnTablaIngresados.Text = "Ingresados"
        Me.btnTablaIngresados.UseVisualStyleBackColor = True
        '
        'btnTablas
        '
        Me.btnTablas.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTablas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTablas.FlatAppearance.BorderSize = 0
        Me.btnTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTablas.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTablas.Location = New System.Drawing.Point(0, 220)
        Me.btnTablas.Name = "btnTablas"
        Me.btnTablas.Size = New System.Drawing.Size(200, 35)
        Me.btnTablas.TabIndex = 3
        Me.btnTablas.Text = "Tablas"
        Me.btnTablas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTablas.UseVisualStyleBackColor = False
        '
        'panelABM
        '
        Me.panelABM.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panelABM.Controls.Add(Me.btnBorrar)
        Me.panelABM.Controls.Add(Me.btnModificar)
        Me.panelABM.Controls.Add(Me.btnSegunda)
        Me.panelABM.Controls.Add(Me.btnPrimera)
        Me.panelABM.Controls.Add(Me.btnAgregar)
        Me.panelABM.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelABM.Location = New System.Drawing.Point(0, 35)
        Me.panelABM.Name = "panelABM"
        Me.panelABM.Size = New System.Drawing.Size(200, 185)
        Me.panelABM.TabIndex = 2
        '
        'btnBorrar
        '
        Me.btnBorrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBorrar.Location = New System.Drawing.Point(0, 140)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(200, 35)
        Me.btnBorrar.TabIndex = 4
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnModificar.Location = New System.Drawing.Point(0, 105)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(200, 35)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnSegunda
        '
        Me.btnSegunda.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSegunda.FlatAppearance.BorderSize = 0
        Me.btnSegunda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSegunda.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSegunda.Location = New System.Drawing.Point(0, 70)
        Me.btnSegunda.Name = "btnSegunda"
        Me.btnSegunda.Size = New System.Drawing.Size(200, 35)
        Me.btnSegunda.TabIndex = 2
        Me.btnSegunda.Text = "Segunda dosis"
        Me.btnSegunda.UseVisualStyleBackColor = True
        '
        'btnPrimera
        '
        Me.btnPrimera.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPrimera.FlatAppearance.BorderSize = 0
        Me.btnPrimera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimera.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPrimera.Location = New System.Drawing.Point(0, 35)
        Me.btnPrimera.Name = "btnPrimera"
        Me.btnPrimera.Size = New System.Drawing.Size(200, 35)
        Me.btnPrimera.TabIndex = 1
        Me.btnPrimera.Text = "Primera dosis"
        Me.btnPrimera.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAgregar.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(200, 35)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar a la base"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnABM
        '
        Me.btnABM.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnABM.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnABM.FlatAppearance.BorderSize = 0
        Me.btnABM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnABM.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnABM.Location = New System.Drawing.Point(0, 0)
        Me.btnABM.Name = "btnABM"
        Me.btnABM.Size = New System.Drawing.Size(200, 35)
        Me.btnABM.TabIndex = 1
        Me.btnABM.Text = "ABM"
        Me.btnABM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnABM.UseVisualStyleBackColor = False
        '
        'panelChildForm
        '
        Me.panelChildForm.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelChildForm.ForeColor = System.Drawing.SystemColors.Control
        Me.panelChildForm.Location = New System.Drawing.Point(218, 12)
        Me.panelChildForm.Name = "panelChildForm"
        Me.panelChildForm.Size = New System.Drawing.Size(662, 549)
        Me.panelChildForm.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(22, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "González López Julián" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Programación I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(892, 573)
        Me.Controls.Add(Me.panelChildForm)
        Me.Controls.Add(Me.panelPaneles)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelPaneles.ResumeLayout(False)
        Me.panelPaneles.PerformLayout()
        Me.panelTablas.ResumeLayout(False)
        Me.panelABM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelPaneles As Panel
    Friend WithEvents panelTablas As Panel
    Friend WithEvents btnTablaCompleto As Button
    Friend WithEvents btnTablaPrimera As Button
    Friend WithEvents btnTablaIngresados As Button
    Friend WithEvents btnTablas As Button
    Friend WithEvents panelABM As Panel
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnSegunda As Button
    Friend WithEvents btnPrimera As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnABM As Button
    Friend WithEvents panelChildForm As Panel
    Friend WithEvents Label1 As Label
End Class
