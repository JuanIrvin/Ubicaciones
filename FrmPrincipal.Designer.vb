<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ImgQR = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEstanteria = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtBloque = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEspacio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lestanteria = New System.Windows.Forms.Label()
        Me.Lbloque = New System.Windows.Forms.Label()
        Me.Lespacio = New System.Windows.Forms.Label()
        Me.Lcodart = New System.Windows.Forms.Label()
        Me.Ltalla = New System.Windows.Forms.Label()
        Me.Lcodcol = New System.Windows.Forms.Label()
        Me.Llinkcat = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.ImgQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "ImgQr"
        '
        'ImgQR
        '
        Me.ImgQR.Location = New System.Drawing.Point(37, 209)
        Me.ImgQR.Name = "ImgQR"
        Me.ImgQR.Size = New System.Drawing.Size(211, 198)
        Me.ImgQR.TabIndex = 0
        Me.ImgQR.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Estanteria:"
        '
        'TxtEstanteria
        '
        Me.TxtEstanteria.Location = New System.Drawing.Point(99, 15)
        Me.TxtEstanteria.Name = "TxtEstanteria"
        Me.TxtEstanteria.Size = New System.Drawing.Size(162, 20)
        Me.TxtEstanteria.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 56)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtBloque
        '
        Me.TxtBloque.Location = New System.Drawing.Point(99, 51)
        Me.TxtBloque.Name = "TxtBloque"
        Me.TxtBloque.Size = New System.Drawing.Size(162, 20)
        Me.TxtBloque.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bloques:"
        '
        'TxtEspacio
        '
        Me.TxtEspacio.Location = New System.Drawing.Point(99, 86)
        Me.TxtEspacio.Name = "TxtEspacio"
        Me.TxtEspacio.Size = New System.Drawing.Size(162, 20)
        Me.TxtEspacio.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Espacio:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(276, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 30)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(276, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 30)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(130, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Escaner QR"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TxtEspacio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtBloque)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TxtEstanteria)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ImgQR)
        Me.Panel1.Location = New System.Drawing.Point(896, 197)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(348, 420)
        Me.Panel1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(494, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(162, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(321, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Escaner Barra Articulo:"
        '
        'Lestanteria
        '
        Me.Lestanteria.AutoSize = True
        Me.Lestanteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lestanteria.Location = New System.Drawing.Point(37, 77)
        Me.Lestanteria.Name = "Lestanteria"
        Me.Lestanteria.Size = New System.Drawing.Size(0, 16)
        Me.Lestanteria.TabIndex = 15
        '
        'Lbloque
        '
        Me.Lbloque.AutoSize = True
        Me.Lbloque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbloque.Location = New System.Drawing.Point(95, 77)
        Me.Lbloque.Name = "Lbloque"
        Me.Lbloque.Size = New System.Drawing.Size(0, 16)
        Me.Lbloque.TabIndex = 16
        '
        'Lespacio
        '
        Me.Lespacio.AutoSize = True
        Me.Lespacio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lespacio.Location = New System.Drawing.Point(160, 77)
        Me.Lespacio.Name = "Lespacio"
        Me.Lespacio.Size = New System.Drawing.Size(0, 16)
        Me.Lespacio.TabIndex = 17
        '
        'Lcodart
        '
        Me.Lcodart.AutoSize = True
        Me.Lcodart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcodart.Location = New System.Drawing.Point(380, 77)
        Me.Lcodart.Name = "Lcodart"
        Me.Lcodart.Size = New System.Drawing.Size(54, 16)
        Me.Lcodart.TabIndex = 18
        Me.Lcodart.Text = "Label6"
        '
        'Ltalla
        '
        Me.Ltalla.AutoSize = True
        Me.Ltalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltalla.Location = New System.Drawing.Point(380, 105)
        Me.Ltalla.Name = "Ltalla"
        Me.Ltalla.Size = New System.Drawing.Size(54, 16)
        Me.Ltalla.TabIndex = 19
        Me.Ltalla.Text = "Label6"
        '
        'Lcodcol
        '
        Me.Lcodcol.AutoSize = True
        Me.Lcodcol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcodcol.Location = New System.Drawing.Point(380, 131)
        Me.Lcodcol.Name = "Lcodcol"
        Me.Lcodcol.Size = New System.Drawing.Size(54, 16)
        Me.Lcodcol.TabIndex = 20
        Me.Lcodcol.Text = "Label6"
        '
        'Llinkcat
        '
        Me.Llinkcat.AutoSize = True
        Me.Llinkcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llinkcat.Location = New System.Drawing.Point(380, 156)
        Me.Llinkcat.Name = "Llinkcat"
        Me.Llinkcat.Size = New System.Drawing.Size(54, 16)
        Me.Llinkcat.TabIndex = 21
        Me.Llinkcat.Text = "Label6"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(367, 236)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 77)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Telas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(525, 236)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 77)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Accesorios"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(213, 236)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(137, 77)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Hilos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(61, 236)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(137, 77)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Consultar Inventario Hilos"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 366)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Llinkcat)
        Me.Controls.Add(Me.Lcodcol)
        Me.Controls.Add(Me.Ltalla)
        Me.Controls.Add(Me.Lcodart)
        Me.Controls.Add(Me.Lespacio)
        Me.Controls.Add(Me.Lbloque)
        Me.Controls.Add(Me.Lestanteria)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menui Principal"
        CType(Me.ImgQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ImgQR As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtEstanteria As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtBloque As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEspacio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Lestanteria As Label
    Friend WithEvents Lbloque As Label
    Friend WithEvents Lespacio As Label
    Friend WithEvents Lcodart As Label
    Friend WithEvents Ltalla As Label
    Friend WithEvents Lcodcol As Label
    Friend WithEvents Llinkcat As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
