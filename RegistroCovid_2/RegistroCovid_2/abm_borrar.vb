Public Class abm_borrar
    Dim CRUD As New CRUD
    Dim respuesta As String
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        respuesta = MsgBox("Los datos relacionados al DNI van a ser borrados definitivamente ¿Está seguro?", vbQuestion + vbYesNo + vbDefaultButton2, "CONFIRMAR BORRADO")

        If respuesta = vbYes Then

            If CRUD.ValidaSiExiste(tDNI.Text) Then

                Dim Sql As String = "Delete * From Clientes Where DNI=" & tDNI.Text & ""
                Try
                    CRUD.operaciones(Sql)
                Catch ex As Exception
                    MsgBox("No se pudo borrar ese registro debido a: " & ex.Message)
                End Try

                If CRUD.ValidaVacunado1(tDNI.Text) Then
                    Sql = "Delete * From Clientes_Vacuna_1 Where DNI=" & tDNI.Text & ""
                    Try
                        CRUD.operaciones(Sql)
                    Catch ex As Exception
                        MsgBox("No se pudo borrar ese registro debido a: " & ex.Message)
                    End Try

                    If CRUD.ValidaVacunado2(tDNI.Text) Then
                        Sql = "Delete * From Clientes_Vacuna_2 Where DNI=" & tDNI.Text & ""
                        Try
                            CRUD.operaciones(Sql)
                        Catch ex As Exception
                            MsgBox("No se pudo borrar ese registro debido a: " & ex.Message)
                        End Try
                        MsgBox("Se han eliminados los datos relacionados en Clientes, Clientes_Vacunacion_1 y Clientes_Vacunacion_2")
                    Else
                        MsgBox("Se han eliminados los datos relacionados en Clientes, Clientes_Vacunacion_1")
                    End If
                Else
                    MsgBox("Se han eliminados los datos relacionados en Clientes")
                End If
            Else
                MsgBox("No se ha podido eliminar ningun dato")
            End If
        Else
            MsgBox("Se ha cancelado el eliminado de datos")
        End If
        tDNI.Text = ""
    End Sub

    Private Sub tDNI_KeyDown(sender As Object, e As KeyEventArgs) Handles tDNI.KeyDown
        If e.KeyCode = 13 Then
            btnBorrar.Focus()
        End If
    End Sub
End Class