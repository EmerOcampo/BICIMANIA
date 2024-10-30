<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Typewriter", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(320, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 39)
        Label1.TabIndex = 3
        Label1.Text = "USUARIO"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(244, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 77)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(348, 229)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 17)
        Label8.TabIndex = 62
        Label8.Text = "NRO.TELEFONO"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(104, 228)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 17)
        Label7.TabIndex = 60
        Label7.Text = "CUIL"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(228, 291)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 17)
        Label6.TabIndex = 58
        Label6.Text = "FECHA_NAC"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(348, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 17)
        Label5.TabIndex = 57
        Label5.Text = "APELLIDO/S"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(146, 173)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(178, 23)
        TextBox1.TabIndex = 56
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(70, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 17)
        Label4.TabIndex = 55
        Label4.Text = "NOMBRE/S"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 21)
        Label3.TabIndex = 54
        Label3.Text = "DATOS DEL CLIENTE"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(450, 175)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(178, 23)
        TextBox2.TabIndex = 64
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(146, 229)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(178, 23)
        TextBox3.TabIndex = 65
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(450, 227)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(178, 23)
        TextBox4.TabIndex = 66
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(315, 290)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(178, 23)
        TextBox5.TabIndex = 67
        TextBox5.Text = "DD-MM-AAAA"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlDarkDark
        Button2.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        Button2.FlatAppearance.BorderSize = 4
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button2.Location = New Point(558, 404)
        Button2.Name = "Button2"
        Button2.Size = New Size(124, 34)
        Button2.TabIndex = 68
        Button2.Text = "GUARDAR"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 34)
        PictureBox2.TabIndex = 69
        PictureBox2.TabStop = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(708, 450)
        Controls.Add(PictureBox2)
        Controls.Add(Button2)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
