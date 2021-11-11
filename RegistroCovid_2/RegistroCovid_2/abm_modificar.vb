Public Class abm_modificar
    Dim CRUD As New CRUD
    Dim estado As Boolean = False
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If CRUD.ValidaSiExiste(tDNI.Text) = True Then 'Verificacion si el ID a agregar ya existe
            If Len(Trim(tNombres.Text)) > 0 And Len(Trim(tApellidos.Text)) > 0 And Len(Trim(tEmail.Text)) > 0 Then

                If CRUD.legible(tNombres.Text) And CRUD.legible(tApellidos.Text) And CRUD.IsEmail(tEmail.Text) Then
                    estado = True
                Else
                    estado = False
                End If

            ElseIf Len(Trim(tNombres.Text)) > 0 And Len(Trim(tApellidos.Text)) > 0 Then

                If CRUD.legible(tNombres.Text) And CRUD.legible(tApellidos.Text) Then
                    estado = True
                Else
                    estado = False
                End If

            ElseIf Len(Trim(tNombres.Text)) > 0 And Len(Trim(tEmail.Text)) > 0 Then

                If CRUD.legible(tNombres.Text) And CRUD.IsEmail(tEmail.Text) Then
                    estado = True
                Else
                    estado = False
                End If
            ElseIf Len(Trim(tEmail.Text)) > 0 And Len(Trim(tApellidos.Text)) > 0 Then

                If CRUD.legible(tApellidos.Text) And CRUD.IsEmail(tEmail.Text) Then
                    estado = True
                Else
                    estado = False
                End If
            ElseIf Len(Trim(tNombres.Text)) > 0 Then

                If CRUD.legible(tNombres.Text) Then
                    estado = True
                Else
                    estado = False
                End If
            ElseIf Len(Trim(tApellidos.Text)) > 0 Then

                If CRUD.legible(tApellidos.Text) Then
                    estado = True
                Else
                    estado = False
                End If
            ElseIf Len(Trim(tEmail.Text)) > 0 Then

                If CRUD.IsEmail(tEmail.Text) Then
                    estado = True
                Else
                    estado = False
                End If
            Else
                estado = False
            End If

            If estado = True Then
                Try
                    Dim Sql As String = "Update Clientes Set Nombres='" & tNombres.Text & "', Apellidos='" & tApellidos.Text & "', Genero='" & cbGenero.Text & "', Email='" & tEmail.Text & "' where DNI=" & tDNI.Text & ""
                    CRUD.operaciones(Sql)
                    tNombres.Text = ""
                    tApellidos.Text = ""
                    tEmail.Text = ""
                    dtpNacimiento.Text = ""
                    cbGenero.Text = ""
                    MsgBox("Datos modificacos correctamente")
                Catch ex As Exception
                    MsgBox("No se pudo actualizar el registro debido a: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub tDNI_KeyDown(sender As Object, e As KeyEventArgs) Handles tDNI.KeyDown
        If e.KeyCode = 13 Then
            tNombres.Focus()
        End If
    End Sub

    Private Sub tNombres_KeyDown(sender As Object, e As KeyEventArgs) Handles tNombres.KeyDown
        If e.KeyCode = 13 Then
            tApellidos.Focus()
        End If
    End Sub

    Private Sub tApellidos_KeyDown(sender As Object, e As KeyEventArgs) Handles tApellidos.KeyDown
        If e.KeyCode = 13 Then
            tEmail.Focus()
        End If
    End Sub

    Private Sub tEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles tEmail.KeyDown
        If e.KeyCode = 13 Then
            cbGenero.Focus()
        End If
    End Sub

    Private Sub cbGenero_KeyDown(sender As Object, e As KeyEventArgs) Handles cbGenero.KeyDown
        If e.KeyCode = 13 Then
            dtpNacimiento.Focus()
        End If

    End Sub

    Private Sub dtpNacimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpNacimiento.KeyDown
        If e.KeyCode = 13 Then
            btnActualizar.Focus()
        End If
    End Sub
End Class