<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Button1 = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        TextBox2 = New TextBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlDarkDark
        Button1.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        Button1.FlatAppearance.BorderSize = 4
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button1.Location = New Point(572, 265)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 34)
        Button1.TabIndex = 95
        Button1.Text = "CREAR"
        Button1.UseVisualStyleBackColor = False
        Button1.Visible = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(460, 203)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(178, 23)
        TextBox4.TabIndex = 93
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(156, 205)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(178, 23)
        TextBox3.TabIndex = 92
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(378, 205)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 17)
        Label8.TabIndex = 90
        Label8.Text = "CANTIDAD"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(97, 203)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 17)
        Label7.TabIndex = 89
        Label7.Text = "PRECIO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(391, 152)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 17)
        Label5.TabIndex = 88
        Label5.Text = "NOMBRE"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(156, 149)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(178, 23)
        TextBox1.TabIndex = 87
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(80, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 17)
        Label4.TabIndex = 86
        Label4.Text = "CATEGORIA"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(6, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 34)
        PictureBox2.TabIndex = 85
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Typewriter", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(314, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 39)
        Label1.TabIndex = 84
        Label1.Text = "PRODUCTO"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(238, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(83, 77)
        PictureBox1.TabIndex = 83
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(460, 149)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(178, 23)
        ComboBox1.TabIndex = 96
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlDarkDark
        Button2.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        Button2.FlatAppearance.BorderSize = 4
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button2.Location = New Point(572, 265)
        Button2.Name = "Button2"
        Button2.Size = New Size(124, 34)
        Button2.TabIndex = 97
        Button2.Text = "ELIMINAR"
        Button2.UseVisualStyleBackColor = False
        Button2.Visible = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(460, 148)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(178, 23)
        TextBox2.TabIndex = 98
        TextBox2.Visible = False
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(708, 311)
        Controls.Add(TextBox2)
        Controls.Add(Button2)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form8"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
End Class
