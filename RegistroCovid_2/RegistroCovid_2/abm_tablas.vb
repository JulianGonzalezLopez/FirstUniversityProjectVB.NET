Public Class abm_tablas

    Dim CRUD As New CRUD

    Private Sub abm_tablas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGTabla.RowHeadersVisible = False
        DGTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
End Class