Public Class abm_segunda_dosis
    Dim CRUD As New CRUD
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If CRUD.ValidaSiExiste(tDNI.Text) Then
            If Len(Trim(cbVacuna.Text)) > 0 Then
                If CRUD.ValidaVacunado2(tDNI.Text) = False Then
                    Try
                        Dim Sql As String = "Insert Into Clientes_Vacuna_2 (DNI, Valoraciones, Vacuna, Fecha) Select " & tDNI.Text & ", '" & tValoraciones.Text & "', '" & cbVacuna.Text & "','" & dtpFecha.Text & "'"
                        CRUD.operaciones(Sql)
                        tDNI.Text = ""
                        tValoraciones.Text = ""
                        cbVacuna.Text = ""
                        dtpFecha.Text = ""
                        MsgBox("Datos cargados correctamente")
                    Catch ex As Exception
                        MsgBox("No se pudo agregar el registro debido a: " & ex.Message)
                    End Try
                Else
                    MsgBox("Esa persona ya ha recibido la segunda dosis")
                End If
            Else

                MsgBox("Tiene que completar el campo de vacuna")
            End If
            Else
                MsgBox("Esta persona no existe en la base de datos o se han ingresado el DNI erroneamente")
        End If
    End Sub

    Private Sub tDNI_KeyDown(sender As Object, e As KeyEventArgs) Handles tDNI.KeyDown
        If e.KeyCode = 13 Then
            tValoraciones.Focus()
        End If
    End Sub

    Private Sub tValoraciones_KeyDown(sender As Object, e As KeyEventArgs) Handles tValoraciones.KeyDown
        If e.KeyCode = 13 Then
            cbVacuna.Focus()
        End If
    End Sub

    Private Sub cbVacuna_KeyDown(sender As Object, e As KeyEventArgs) Handles cbVacuna.KeyDown
        If e.KeyCode = 13 Then
            dtpFecha.Focus()
        End If
    End Sub

    Private Sub dtpFecha_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyCode = 13 Then
            btnEnviar.Focus()
        End If
    End Sub
End Class