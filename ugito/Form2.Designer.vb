<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        TextBox6 = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        TextBox8 = New TextBox()
        Label12 = New Label()
        TextBox9 = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button3 = New Button()
        Timer1 = New Timer(components)
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        ListBox3 = New ListBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        PrintDocument1 = New Printing.PrintDocument()
        Label15 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(478, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 12
        Label1.Text = "FACTURA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(-19, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(1504, 23)
        Label2.TabIndex = 13
        Label2.Text = "----------------------------------------------------------------------------------------------------------------------------------------------------------------------"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 21)
        Label3.TabIndex = 14
        Label3.Text = "DATOS DEL CLIENTE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(129, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 17)
        Label4.TabIndex = 15
        Label4.Text = "NOMBRE/S"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(205, 116)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(178, 23)
        TextBox1.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(407, 119)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 17)
        Label5.TabIndex = 17
        Label5.Text = "APELLIDO/S"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(800, 115)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(178, 23)
        TextBox3.TabIndex = 20
        TextBox3.Text = "DD-MM-AAAA"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(708, 117)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 17)
        Label6.TabIndex = 19
        Label6.Text = "FECHA_NAC"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(205, 171)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(178, 23)
        TextBox4.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(163, 171)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 17)
        Label7.TabIndex = 21
        Label7.Text = "CUIL"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(514, 170)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(173, 23)
        TextBox5.TabIndex = 24
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(407, 172)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 17)
        Label8.TabIndex = 23
        Label8.Text = "NRO.TELEFONO"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(21, 226)
        Label9.Name = "Label9"
        Label9.Size = New Size(184, 21)
        Label9.TabIndex = 25
        Label9.Text = "DATOS DEL PRODUCTO"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(250, 271)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.Size = New Size(178, 23)
        TextBox6.TabIndex = 27
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(165, 271)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 17)
        Label10.TabIndex = 26
        Label10.Text = "CATEGORIA"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(434, 272)
        Label11.Name = "Label11"
        Label11.Size = New Size(138, 17)
        Label11.TabIndex = 28
        Label11.Text = "NOMBRE PRODUCTO"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(250, 329)
        TextBox8.Name = "TextBox8"
        TextBox8.ReadOnly = True
        TextBox8.Size = New Size(178, 23)
        TextBox8.TabIndex = 31
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(191, 330)
        Label12.Name = "Label12"
        Label12.Size = New Size(53, 17)
        Label12.TabIndex = 30
        Label12.Text = "PRECIO"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(584, 329)
        TextBox9.Name = "TextBox9"
        TextBox9.ReadOnly = True
        TextBox9.Size = New Size(178, 23)
        TextBox9.TabIndex = 33
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(502, 330)
        Label13.Name = "Label13"
        Label13.Size = New Size(76, 17)
        Label13.TabIndex = 32
        Label13.Text = "CANTIDAD"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(21, 383)
        Label14.Name = "Label14"
        Label14.Size = New Size(184, 21)
        Label14.TabIndex = 34
        Label14.Text = "DATOS DEL PRODUCTO"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(175, 421)
        Label16.Name = "Label16"
        Label16.Size = New Size(79, 17)
        Label16.TabIndex = 37
        Label16.Text = "PRODUCTO"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(392, 421)
        Label17.Name = "Label17"
        Label17.Size = New Size(53, 17)
        Label17.TabIndex = 39
        Label17.Text = "PRECIO"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(589, 421)
        Label18.Name = "Label18"
        Label18.Size = New Size(76, 17)
        Label18.TabIndex = 41
        Label18.Text = "CANTIDAD"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(776, 485)
        Label19.Name = "Label19"
        Label19.Size = New Size(59, 17)
        Label19.TabIndex = 43
        Label19.Text = "TOTAL $"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlDarkDark
        Button1.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        Button1.FlatAppearance.BorderSize = 4
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button1.Location = New Point(800, 577)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 34)
        Button1.TabIndex = 45
        Button1.Text = "LIMPIAR"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlDarkDark
        Button2.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        Button2.FlatAppearance.BorderSize = 4
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button2.Location = New Point(950, 577)
        Button2.Name = "Button2"
        Button2.Size = New Size(124, 34)
        Button2.TabIndex = 46
        Button2.Text = "GUARDAR"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1040, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(34, 42)
        PictureBox1.TabIndex = 47
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(21, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 34)
        PictureBox2.TabIndex = 48
        PictureBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlDarkDark
        Button3.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        Button3.FlatAppearance.BorderSize = 4
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button3.Location = New Point(884, 330)
        Button3.Name = "Button3"
        Button3.Size = New Size(124, 34)
        Button3.TabIndex = 49
        Button3.Text = "AÑADIR"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(135, 446)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(167, 109)
        ListBox1.TabIndex = 50
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(337, 446)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(167, 109)
        ListBox2.TabIndex = 51
        ' 
        ' ListBox3
        ' 
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 15
        ListBox3.Location = New Point(547, 446)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(167, 109)
        ListBox3.TabIndex = 52
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(514, 115)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(173, 23)
        ComboBox1.TabIndex = 53
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(584, 266)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(178, 23)
        ComboBox2.TabIndex = 54
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(21, 577)
        Label15.Name = "Label15"
        Label15.Size = New Size(47, 15)
        Label15.TabIndex = 55
        Label15.Text = "Label15"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(1086, 623)
        Controls.Add(Label15)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(ListBox3)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(Button3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label14)
        Controls.Add(TextBox9)
        Controls.Add(Label13)
        Controls.Add(TextBox8)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(TextBox6)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(TextBox5)
        Controls.Add(Label8)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label15 As Label
End Class
