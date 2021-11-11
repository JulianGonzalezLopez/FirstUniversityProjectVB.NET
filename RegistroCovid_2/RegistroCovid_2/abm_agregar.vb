Public Class abm_agregar

    Dim CRUD As New CRUD
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If CRUD.legible(tNombres.Text) And CRUD.legible(tApellidos.Text) And IsNumeric(tDNI.Text) And CRUD.IsEmail(tEmail.Text) Then
            If CRUD.ValidaSiExiste(tDNI.Text) = True Then 'Verificacion si el ID a agregar ya existe
            Else
                Try
                    Dim Sql As String = "Insert Into Clientes (DNI, Nombres, Apellidos, Genero, Nacimiento, Email) Select " & tDNI.Text & ", '" & tNombres.Text & "', '" & tApellidos.Text & "','" & cbGenero.Text & "', '" & dtpNacimiento.Text & "', '" & tEmail.Text & "'"
                    CRUD.operaciones(Sql)
                Catch ex As Exception
                    MsgBox("No se pudo agregar el registro debido a: " & ex.Message)
                End Try
                tNombres.Text = ""
                tApellidos.Text = ""
                tDNI.Text = ""
                cbGenero.Text = ""
                dtpNacimiento.Text = ""
                tEmail.Text = ""
                MsgBox("Datos cargados correctamente")
            End If
        Else
            MsgBox("Para ingresar un nuevo usuario, todos los valores han de ser rellenados con los valores apropiados")
        End If
    End Sub

    Private Sub tApellidos_KeyDown(sender As Object, e As KeyEventArgs) Handles tApellidos.KeyDown
        If e.KeyCode = 13 Then
            tDNI.Focus()
            End if
    End Sub

    Private Sub tNombres_KeyDown(sender As Object, e As KeyEventArgs) Handles tNombres.KeyDown
        If e.KeyCode = 13 Then
            tApellidos.Focus()
        End If
    End Sub

    Private Sub tDNI_KeyDown(sender As Object, e As KeyEventArgs) Handles tDNI.KeyDown
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
            Button6.Focus()
        End If
    End Sub
End Class