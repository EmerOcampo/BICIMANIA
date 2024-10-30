Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Drawing
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form2

    Dim connectionString As String = "server=localhost;userid=root;password=;database=bicimania"
    Private WithEvents printDocument As New PrintDocument()
    Private bicimania As Image
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        bicimania = Image.FromFile("C:\Users\Ezequiel Merlo\Desktop\ugo\ugito\ugito\bicimania.jpg")
        LlenarComboBox1()
        LlenarComboBox2()
    End Sub

    Private Sub LlenarComboBox1()
        Dim query As String = "SELECT cuil, apellido FROM cliente"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim cuil As String = reader("cuil").ToString()
                            Dim apellido As String = reader("apellido").ToString()
                            ComboBox1.Items.Add(New With {.Text = apellido, .Value = cuil})
                        End While
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al conectar: " & ex.Message)
            End Try
        End Using

        ComboBox1.DisplayMember = "Text"
        ComboBox1.ValueMember = "Value"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedCuil As String = CType(ComboBox1.SelectedItem, Object).Value
        LlenarTextBox(selectedCuil)
    End Sub

    Private Sub LlenarTextBox(cuil As String)
        Dim query As String = "SELECT * FROM cliente WHERE cuil = @cuil"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@cuil", cuil)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TextBox1.Text = reader("nombre").ToString()
                            TextBox3.Text = reader("fecha_nac").ToString()
                            TextBox4.Text = reader("cuil").ToString()
                            TextBox5.Text = reader("num_telefono").ToString()
                        End If
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al conectar: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LlenarComboBox2()
        Dim query As String = "SELECT id_producto, nombre FROM producto"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim id_producto As Integer = reader("id_producto")
                            Dim nombre As String = reader("nombre").ToString()
                            ComboBox2.Items.Add(New With {.Text = nombre, .Value = id_producto})
                        End While
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al conectar: " & ex.Message)
            End Try
        End Using

        ComboBox2.DisplayMember = "Text"
        ComboBox2.ValueMember = "Value"
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim selectedIdProducto As Integer = CType(ComboBox2.SelectedItem, Object).Value
        LlenarTextBoxProducto(selectedIdProducto)
    End Sub

    Private Sub LlenarTextBoxProducto(id_producto As Integer)
        Dim query As String = "SELECT * FROM producto WHERE id_producto = @id_producto"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@id_producto", id_producto)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TextBox6.Text = reader("categoria").ToString()
                            TextBox8.Text = reader("precio").ToString()
                            TextBox9.Text = reader("cantidad").ToString()
                        End If
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al conectar: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox2.SelectedItem IsNot Nothing Then
            Dim selectedText As String = ComboBox2.Text
            ListBox1.Items.Add(selectedText)
        Else
            MessageBox.Show("Por favor, seleccione una opción del ComboBox.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim precio As Double
        Dim cantidad As Integer

        If Double.TryParse(TextBox8.Text, precio) AndAlso Integer.TryParse(TextBox9.Text, cantidad) Then
            ListBox2.Items.Add(precio.ToString())
            ListBox3.Items.Add(cantidad.ToString())

            ActualizarCantidadProducto(CType(ComboBox2.SelectedItem, Object).Value, cantidad)

            TextBox8.Clear()
            TextBox9.Clear()
            TextBox6.Clear()
        Else
            MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos de precio y cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim suma As Double = 0
        For i As Integer = 0 To ListBox2.Items.Count - 1
            Dim valor1 As Double = Convert.ToDouble(ListBox2.Items(i))
            Dim valor2 As Double = Convert.ToDouble(ListBox3.Items(i))
            suma += valor1 * valor2
        Next
        Label19.Text = "TOTAL $" & suma.ToString()
    End Sub

    Private Sub ActualizarCantidadProducto(id_producto As Integer, cantidadVendida As Integer)
        Dim query As String = "UPDATE producto SET cantidad = cantidad - @cantidadVendida WHERE id_producto = @id_producto"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@id_producto", id_producto)
                    cmd.Parameters.AddWithValue("@cantidadVendida", cantidadVendida)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al actualizar la cantidad del producto: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        SyncSelection(ListBox1.SelectedIndex)
    End Sub

    Private Sub SyncSelection(selectedIndex As Integer)
        ListBox2.SelectedIndex = selectedIndex
        ListBox3.SelectedIndex = selectedIndex
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        SyncSelection2(ListBox2.SelectedIndex)
    End Sub

    Private Sub SyncSelection2(selectedIndex As Integer)
        ListBox1.SelectedIndex = selectedIndex
        ListBox3.SelectedIndex = selectedIndex
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        SyncSelection3(ListBox3.SelectedIndex)
    End Sub

    Private Sub SyncSelection3(selectedIndex As Integer)
        ListBox1.SelectedIndex = selectedIndex
        ListBox2.SelectedIndex = selectedIndex
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        Label19.Text = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ListBox3.Items.Clear()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Text = "BICIMANIA                                                                                                                              " & Date.Now.ToString("dd-MM-yyyy  hh:mm")
        Label15.Hide()
        Label15.Text = Date.Now.ToString("dd-MM-yyyy")

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)
        Dim numeroFactura As Integer = ObtenerSiguienteNumeroFactura()
        Dim x As Single = 100
        Dim y As Single = 100
        Dim titlex As Single = 300

        e.Graphics.DrawString("BICIMANIA", New Font("Arial", 25, FontStyle.Bold), brush, titlex, y)
        y += 70
        e.Graphics.DrawString("Boleta de Pago", New Font("Arial", 20, FontStyle.Bold), brush, titlex, y)
        y += 70
        e.Graphics.DrawString("Fecha:" & Label15.Text & "           Nro Factura:" & numeroFactura, font, brush, x, y)
        y += 30
        e.Graphics.DrawString("Datos Cliente", New Font("Arial", 16, FontStyle.Bold), brush, x, y)
        y += 40
        e.Graphics.DrawString("Nombre: " & TextBox1.Text, font, brush, x, y)
        y += 20
        e.Graphics.DrawString("Apellido: " & ComboBox1.Text, font, brush, x, y)
        y += 20
        e.Graphics.DrawString("CUIL: " & TextBox4.Text, font, brush, x, y)
        y += 20
        e.Graphics.DrawString("Fecha Nacimineto: " & TextBox3.Text, font, brush, x, y)
        y += 20
        e.Graphics.DrawString("Num.Tel: " & TextBox5.Text, font, brush, x, y)
        y += 70
        e.Graphics.DrawString("Productos", New Font("Arial", 16, FontStyle.Bold), brush, x, y)
        y += 40
        e.Graphics.DrawString("Producto", font, brush, x, y)
        x += 250
        e.Graphics.DrawString("Precio", font, brush, x, y)
        x += 200
        e.Graphics.DrawString("Cantidad", font, brush, x, y)
        y += 30
        x = 100
        Dim itemsText As String = String.Join(Environment.NewLine, ListBox1.Items.Cast(Of String)())
        e.Graphics.DrawString(itemsText, font, brush, x, y)
        x += 250
        Dim itemsText1 As String = String.Join(Environment.NewLine, ListBox2.Items.Cast(Of String)())
        e.Graphics.DrawString(itemsText1, font, brush, x, y)
        x += 200
        Dim itemsText2 As String = String.Join(Environment.NewLine, ListBox3.Items.Cast(Of String)())
        e.Graphics.DrawString(itemsText2, font, brush, x, y)
        y += 100
        x = 650
        e.Graphics.DrawString(Label19.Text, font, brush, x, y)
        y = 1000
        x = 100
        e.Graphics.DrawString("9 de Julio 412, Villa Carlos Paz, Córdoba", font, brush, x, y)
        x = 420
        e.Graphics.DrawString("Tel: 3541-433189", font, brush, x, y)
        x += 150
        e.Graphics.DrawString("bicimania@gmail.com", font, brush, x, y)
        y = 200
        x = 600
        e.Graphics.DrawImage(bicimania, x, y)
    End Sub

    Private Function ValidarCampos() As Boolean

        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Por favor, complete el campo de Nombre


.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Por favor, complete el campo de CUIL.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox4.Focus()
            Return False
        End If

        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBox1.Focus()
            Return False
        End If

        If ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione un Producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBox2.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ValidarCampos() Then
            Return
        End If
        Dim fecha As Date = DateTime.Parse(Label15.Text)

        Dim query As String = "INSERT INTO FACTURA (FECHA) VALUES (@fecha)"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@fecha", fecha)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Factura insertada con éxito.")
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al insertar factura: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Function ObtenerSiguienteNumeroFactura() As Integer
        Dim siguienteNumero As Integer

        Dim query As String = "SELECT COALESCE(MAX(NRO_FACTURA), 0) + 1 FROM FACTURA"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    siguienteNumero = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error al obtener el siguiente número de factura: " & ex.Message)
                siguienteNumero = -1
            End Try
        End Using

        Return siguienteNumero
    End Function

End Class
