Imports MySql.Data.MySqlClient

Public Class Form5
    Dim connectionString As String = "server=localhost;userid=root;password=;database=bicimania"

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Text = "BICIMANIA                                                                     " & Date.Now.ToString("dd-MM-yyyy  HH:mm")
    End Sub
    Private Sub RefreshForm()
        Me.Hide()
        Dim newForm As New Form1()
        newForm.Show()
        Me.Close()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        RefreshForm()
    End Sub

    Private Sub GuardarDatosCliente()
        Dim queryCheck As String = "SELECT COUNT(*) FROM cliente WHERE cuil = @cuil"
        Dim queryInsert As String = "INSERT INTO cliente (nombre, apellido, fecha_nac, cuil, num_telefono) VALUES (@nombre, @apellido, @fecha_nac, @cuil, @num_telefono)"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("Conexión abierta.") ' Mensaje para depuración

                ' Verificar si el CUIL ya existe
                Dim count As Integer
                Using cmdCheck As New MySqlCommand(queryCheck, connection)
                    cmdCheck.Parameters.AddWithValue("@cuil", TextBox3.Text)
                    count = Convert.ToInt32(cmdCheck.ExecuteScalar())
                End Using

                If count > 0 Then
                    MessageBox.Show("El CUIL ya existe. Por favor, ingrese un CUIL único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Insertar nuevo cliente si el CUIL no existe
                Using cmdInsert As New MySqlCommand(queryInsert, connection)
                    cmdInsert.Parameters.AddWithValue("@nombre", TextBox1.Text)
                    cmdInsert.Parameters.AddWithValue("@apellido", TextBox2.Text)

                    Dim fechaNac As DateTime
                    If Not DateTime.TryParse(TextBox5.Text, fechaNac) Then
                        MessageBox.Show("La fecha de nacimiento no es válida. Use el formato dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                    cmdInsert.Parameters.AddWithValue("@fecha_nac", fechaNac.ToString("yyyy-MM-dd"))
                    cmdInsert.Parameters.AddWithValue("@cuil", TextBox3.Text)
                    cmdInsert.Parameters.AddWithValue("@num_telefono", TextBox4.Text)
                    cmdInsert.ExecuteNonQuery()
                End Using

                MessageBox.Show("Datos del cliente guardados exitosamente.")
                LimpiarCampos()
            Catch ex As MySqlException
                MessageBox.Show("Error al guardar los datos del cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error inesperado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                    MessageBox.Show("Conexión cerrada.") ' Mensaje para depuración
                End If
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("El CUIL es obligatorio.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        GuardarDatosCliente()
    End Sub

    Private Sub LimpiarCampos()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = UCase(TextBox1.Text)
        TextBox1.SelectionStart = TextBox1.Text.Length
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = UCase(TextBox2.Text)
        TextBox2.SelectionStart = TextBox2.Text.Length
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class

