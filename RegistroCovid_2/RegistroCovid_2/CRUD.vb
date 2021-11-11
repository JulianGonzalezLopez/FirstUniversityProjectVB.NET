Imports System.Data.OleDb
Imports System.Text.RegularExpressions 'Importo las regex para poder llevar a cabo la validacion

Public Class CRUD

    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=C:\Tutorial_CRUD\Datos.mdb") 'Se establece un objeto de la clase OleDbConnection que posee la ruta de conexion

    Sub consulta(ByVal Tabla As DataGridView, ByVal Sql As String) 'Se encarga de el codigo relacionado con la consulta y grabado de datos en la DataGridView
        Try
            Dim DA As New OleDbDataAdapter(Sql, con)
            Dim DT As New DataTable
            DA.Fill(DT)
            Tabla.DataSource = DT
        Catch ex As Exception
            MsgBox("No se logró la consulta debido a: " & ex.Message, MsgBoxStyle.Critical, "COVID_PROGRAMA")
        End Try
    End Sub

    Sub operaciones(ByVal Sql As String) 'Se encarga de todas las operaciones de escritura, grabado, borrado. Teniendo en el parametro SQL la instruccion correspondiente
        con.Open()
        Try
            Dim cmd As New OleDbCommand(Sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se logro realizar la operación por: " & ex.Message, MsgBoxStyle.Critical, "COVID_PROGRAMA")
        End Try
        con.Close()
    End Sub
    Function ValidaSiExiste(ByVal DNI As Integer) As Boolean 'Se encarga de validar la existencia de un ID, lo utilizo para evitar duplicados, ya que aunque el programa tira el error de por si, eso tambien hacia que finalice su ejecucion
        Try
            Dim buscar As String = String.Format("Select *from clientes where DNI = @tDNI.Text")
            Dim cmd As New OleDbCommand(buscar, con)
            con.Open()
            cmd.Parameters.AddWithValue("@tDNI.Text", DNI)
            Dim Count As Integer = cmd.ExecuteScalar()
            con.Close()
            If Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Function ValidaVacunado1(ByVal DNI As Integer) As Boolean 'Se encarga de validar la existencia de un ID, lo utilizo para evitar duplicados, ya que aunque el programa tira el error de por si, eso tambien hacia que finalice su ejecucion
        Try
            Dim buscar As String = String.Format("Select *from clientes_vacuna_1 where DNI = @tDNI.Text")
            Dim cmd As New OleDbCommand(buscar, con)
            con.Open()
            cmd.Parameters.AddWithValue("@tDNI.Text", DNI) 'Esto lo robé
            Dim Count As Integer = cmd.ExecuteScalar() 'Esto tambien
            con.Close()
            If Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    Function ValidaVacunado2(ByVal DNI As Integer) As Boolean 'Se encarga de validar la existencia de un ID, lo utilizo para evitar duplicados, ya que aunque el programa tira el error de por si, eso tambien hacia que finalice su ejecucion
        Try
            Dim buscar As String = String.Format("Select *from clientes_vacuna_2 where DNI = @tDNI.Text")
            Dim cmd As New OleDbCommand(buscar, con)
            con.Open()
            cmd.Parameters.AddWithValue("@tDNI.Text", DNI)
            Dim Count As Integer = cmd.ExecuteScalar()
            con.Close()
            If Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Function legible(texto As String) 'Funcion para confirmar que lo escrito en el lugar de texto coincide con el patron (letras de a-z y capaz otra vez otro conjunto de letras a-z 
        If Regex.IsMatch(texto, "^[a-zA-Z]+(?: [a-zA-Z]+)*$") = True Then
            Return True
        End If
        Return False 'Si se da, devuelve verdadero. Caso contrario, false
    End Function

    Function IsEmail(texto As String) As Boolean
        If Regex.IsMatch(texto, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$") Then 'Esta expresion la robé
            Return True
        End If
        Return False
    End Function

    Function longitud(texto As String) 'Funcion para comprobar de lo escrito en lugar de texto tiene longitud mayor a 0
        If Len(Trim(texto)) > 0 Then
            Return True
        End If
        Return False 'Si se da, devuelve verdadero. Caso contrario, false
    End Function


End Class