Public Class Form1

    Dim aux As New Form

    Dim CRUD As New CRUD

    Private currentForm As Form = Nothing
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelABM.Hide()
        panelTablas.Hide()
    End Sub

    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        If currentForm Is childForm Then
        Else
            currentForm = Nothing
            currentForm = childForm
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            panelChildForm.Controls.Add(childForm)
            panelChildForm.Tag = childForm
            childForm.BringToFront()
            childForm.Show()
        End If
    End Sub

    Private Sub openChildFormTablas(childForm As Form)
        If currentForm IsNot Nothing And currentForm IsNot childForm Then
            currentForm.Close()
        ElseIf currentForm IsNot Nothing And currentForm Is childForm Then
            currentForm.Update()
        End If
        If currentForm Is childForm Then
        Else
            currentForm = Nothing
            currentForm = childForm
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            panelChildForm.Controls.Add(childForm)
            panelChildForm.Tag = childForm
            childForm.BringToFront()
            childForm.Show()
        End If
    End Sub

    Private Sub btnABM_Click(sender As Object, e As EventArgs) Handles btnABM.Click
        If panelABM.Visible = True Then
            panelABM.Hide()
        Else
            panelABM.Show()
        End If
    End Sub

    Private Sub btnTablas_Click(sender As Object, e As EventArgs) Handles btnTablas.Click
        If panelTablas.Visible = True Then
            panelTablas.Hide()
        Else
            panelTablas.Show()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        openChildForm(abm_agregar)

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        openChildForm(abm_modificar)
    End Sub

    Private Sub btnPrimera_Click(sender As Object, e As EventArgs) Handles btnPrimera.Click
        openChildForm(abm_primera_dosis)
    End Sub

    Private Sub btnSegunda_Click(sender As Object, e As EventArgs) Handles btnSegunda.Click
        openChildForm(abm_segunda_dosis)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        openChildForm(abm_borrar)
    End Sub

    Private Sub btnTablaIngresados_Click(sender As Object, e As EventArgs) Handles btnTablaIngresados.Click
        global_variables.TablasSQL = "Select *from Clientes"
        abm_tablas.lbTitulo.Text = "Tabla ingresados a la base"
        openChildFormTablas(abm_tablas)
        CRUD.consulta(abm_tablas.DGTabla, global_variables.TablasSQL)
    End Sub

    Private Sub btnTablaPrimera_Click(sender As Object, e As EventArgs) Handles btnTablaPrimera.Click
        global_variables.TablasSQL = "Select *from Clientes_Vacuna_1"
        abm_tablas.lbTitulo.Text = "Tabla vacunados con 1 dosis"
        openChildFormTablas(abm_tablas)
        CRUD.consulta(abm_tablas.DGTabla, global_variables.TablasSQL)
    End Sub

    Private Sub btnTablaCompleto_Click(sender As Object, e As EventArgs) Handles btnTablaCompleto.Click
        global_variables.TablasSQL = "Select *from Clientes_Vacuna_2"
        abm_tablas.lbTitulo.Text = "Tabla vacunados con 2 dosis"
        openChildFormTablas(abm_tablas)
        CRUD.consulta(abm_tablas.DGTabla, global_variables.TablasSQL)
    End Sub
End Class
