Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form8
    Private llenadoPorComboBox As Boolean = False
    Dim connectionString As String = "server=localhost;userid=root;password=;database=bicimania"
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        LoadProducts()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Text = "BICIMANIA                                                                     " & Date.Now.ToString("dd-MM-yyyy  hh:mm")
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query = "INSERT INTO producto (Precio, Cantidad, Categoria, Nombre) VALUES (@Precio, @Cantidad, @Categoria, @Nombre)"
        Using connection As New MySqlConnection(connectionString)

            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(TextBox3.Text))
                command.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(TextBox4.Text))
                command.Parameters.AddWithValue("@Categoria", TextBox1.Text)
                command.Parameters.AddWithValue("@Nombre", TextBox2.Text)

                connection.Open()


                Dim rowsAffected = command.ExecuteNonQuery

                If rowsAffected > 0 Then
                    MessageBox.Show("Datos insertados correctamente.")
                Else
                    MessageBox.Show("No se pudo insertar los datos.")
                End If
            End Using
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedProductName = ComboBox1.SelectedItem.ToString()
        Dim querySelect = "SELECT Precio, Cantidad, Categoria FROM producto WHERE Nombre = @Nombre"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(querySelect, connection)
                command.Parameters.AddWithValue("@Nombre", selectedProductName)

                connection.Open()

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        TextBox3.Text = reader("Precio").ToString()
                        TextBox4.Text = reader("Cantidad").ToString()
                        TextBox1.Text = reader("Categoria").ToString()
                    End If
                End Using
            End Using
        End Using
        TextBox2.Text = ComboBox1.SelectedItem.ToString()
        llenadoPorComboBox = True ' Marcar que fue llenado por el ComboBox
        MostrarBoton()
    End Sub

    ' Método para cargar productos en el ComboBox
    Private Sub LoadProducts()
        ComboBox1.Items.Clear()
        Dim queryLoad = "SELECT Nombre FROM producto"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryLoad, connection)
                connection.Open()

                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ComboBox1.Items.Add(reader("Nombre").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' Método para limpiar los TextBox
    Private Sub ClearTextBoxes()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Clear()
        ComboBox1.Items.Clear()
    End Sub

    ' Llama a LoadProducts() cuando se carga el formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim queryDelete = "DELETE FROM producto WHERE Nombre = @Nombre"
        Using connection As New MySqlConnection(connectionString)

            Using command As New MySqlCommand(queryDelete, connection)
                command.Parameters.AddWithValue("@Nombre", ComboBox1.SelectedItem.ToString)

                connection.Open()

                Dim rowsAffected = command.ExecuteNonQuery

                If rowsAffected > 0 Then
                    MessageBox.Show("Producto eliminado correctamente.")
                    LoadProducts()
                    ClearTextBoxes()
                Else
                    MessageBox.Show("No se pudo eliminar el producto.")
                End If
            End Using
        End Using
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If llenadoPorComboBox Then
            llenadoPorComboBox = False
        End If
        MostrarBoton()
        If TextBox1.Text.Length > 0 Then
            ComboBox1.Visible = False
            TextBox2.Visible = True
        Else
            ComboBox1.Visible = True
            TextBox2.Visible = False
        End If
        TextBox1.Text = UCase(TextBox1.Text)
        TextBox1.SelectionStart = TextBox1.Text.Length
    End Sub

    Private Sub MostrarBoton()
        If llenadoPorComboBox Then
            Button2.Visible = True
            Button1.Visible = False
        ElseIf Not String.IsNullOrWhiteSpace(TextBox1.Text) Then
            Button1.Visible = True
            Button2.Visible = False
        Else
            Button2.Visible = False
            Button1.Visible = False
        End If
    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso
           Not String.IsNullOrWhiteSpace(TextBox2.Text) AndAlso
           Not String.IsNullOrWhiteSpace(TextBox3.Text) AndAlso
           Not String.IsNullOrWhiteSpace(TextBox4.Text) Then
            Button1.Visible = True
        Else
            Button1.Visible = False
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = UCase(TextBox2.Text)
        TextBox2.SelectionStart = TextBox2.Text.Length
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Solo se permiten letras y espacios.")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Solo se permiten letras y espacios.")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Solo se permiten números.")
        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Solo se permiten números.")
        End If
    End Sub
End Class