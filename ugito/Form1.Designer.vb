<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlDarkDark
        Button1.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        Button1.FlatAppearance.BorderSize = 4
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(90, 91)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 50)
        Button1.TabIndex = 0
        Button1.Text = "USUARIO"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ButtonShadow
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(240, 234)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(705, 34)
        TextBox1.TabIndex = 3
        TextBox1.Text = "PEDALEA HACIA TUS SUEÑOS"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlDarkDark
        Button2.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        Button2.FlatAppearance.BorderSize = 4
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(363, 91)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 50)
        Button2.TabIndex = 4
        Button2.Text = "FACTURA"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlDarkDark
        Button3.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        Button3.FlatAppearance.BorderSize = 4
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(649, 91)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 50)
        Button3.TabIndex = 5
        Button3.Text = "PRODUCTO"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ButtonShadow
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(352, 274)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(251, 34)
        TextBox2.TabIndex = 6
        TextBox2.Text = "CON BICIMANIA"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ButtonShadow
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(385, 25)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(168, 34)
        TextBox3.TabIndex = 7
        TextBox3.Text = "BICIMANIA"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.ButtonShadow
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(3, 52)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(874, 34)
        TextBox4.TabIndex = 8
        TextBox4.Text = "-----------------------------------------------------------------------------------------------------"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(313, 1)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 67)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(878, 450)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(300, 300)
        MaximizeBox = False
        Name = "Form1"
        RightToLeft = RightToLeft.No
        RightToLeftLayout = True
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer

End Class
