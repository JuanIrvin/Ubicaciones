<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTelas))
        Me.PBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextRollo = New System.Windows.Forms.TextBox()
        Me.TextUbicacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LEstanteria = New System.Windows.Forms.Label()
        Me.LBloque = New System.Windows.Forms.Label()
        Me.LEspacio = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TextBarra = New System.Windows.Forms.TextBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.TextPeso_Real = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextPeso_Teorico = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextLote = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.TextSKU = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBox
        '
        Me.PBox.Location = New System.Drawing.Point(1196, 503)
        Me.PBox.Name = "PBox"
        Me.PBox.Size = New System.Drawing.Size(100, 50)
        Me.PBox.TabIndex = 0
        Me.PBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero de Rollo:"
        '
        'TextRollo
        '
        Me.TextRollo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextRollo.Location = New System.Drawing.Point(786, 230)
        Me.TextRollo.Name = "TextRollo"
        Me.TextRollo.Size = New System.Drawing.Size(155, 29)
        Me.TextRollo.TabIndex = 2
        Me.TextRollo.TabStop = False
        '
        'TextUbicacion
        '
        Me.TextUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUbicacion.Location = New System.Drawing.Point(1145, 222)
        Me.TextUbicacion.Name = "TextUbicacion"
        Me.TextUbicacion.Size = New System.Drawing.Size(155, 29)
        Me.TextUbicacion.TabIndex = 4
        Me.TextUbicacion.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1030, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ubicacion:"
        '
        'LEstanteria
        '
        Me.LEstanteria.AutoSize = True
        Me.LEstanteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEstanteria.Location = New System.Drawing.Point(1141, 265)
        Me.LEstanteria.Name = "LEstanteria"
        Me.LEstanteria.Size = New System.Drawing.Size(108, 24)
        Me.LEstanteria.TabIndex = 5
        Me.LEstanteria.Text = "Estanteria:"
        '
        'LBloque
        '
        Me.LBloque.AutoSize = True
        Me.LBloque.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBloque.Location = New System.Drawing.Point(1141, 300)
        Me.LBloque.Name = "LBloque"
        Me.LBloque.Size = New System.Drawing.Size(82, 24)
        Me.LBloque.TabIndex = 7
        Me.LBloque.Text = "Bloque:"
        '
        'LEspacio
        '
        Me.LEspacio.AutoSize = True
        Me.LEspacio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEspacio.Location = New System.Drawing.Point(1141, 335)
        Me.LEspacio.Name = "LEspacio"
        Me.LEspacio.Size = New System.Drawing.Size(91, 24)
        Me.LEspacio.TabIndex = 9
        Me.LEspacio.Text = "Espacio:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(609, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(484, 262)
        Me.DataGridView1.TabIndex = 10
        Me.DataGridView1.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'TextBarra
        '
        Me.TextBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBarra.Location = New System.Drawing.Point(204, 94)
        Me.TextBarra.Name = "TextBarra"
        Me.TextBarra.Size = New System.Drawing.Size(273, 26)
        Me.TextBarra.TabIndex = 1
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Location = New System.Drawing.Point(89, 286)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(131, 56)
        Me.btnGrabar.TabIndex = 5
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(313, 286)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(132, 56)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'TextPeso_Real
        '
        Me.TextPeso_Real.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPeso_Real.Location = New System.Drawing.Point(204, 212)
        Me.TextPeso_Real.Name = "TextPeso_Real"
        Me.TextPeso_Real.Size = New System.Drawing.Size(103, 22)
        Me.TextPeso_Real.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Peso Real:"
        '
        'TextPeso_Teorico
        '
        Me.TextPeso_Teorico.Enabled = False
        Me.TextPeso_Teorico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPeso_Teorico.Location = New System.Drawing.Point(204, 174)
        Me.TextPeso_Teorico.Name = "TextPeso_Teorico"
        Me.TextPeso_Teorico.Size = New System.Drawing.Size(103, 22)
        Me.TextPeso_Teorico.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(93, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Peso Teorico:"
        '
        'TextLote
        '
        Me.TextLote.Enabled = False
        Me.TextLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLote.Location = New System.Drawing.Point(204, 136)
        Me.TextLote.Name = "TextLote"
        Me.TextLote.Size = New System.Drawing.Size(140, 22)
        Me.TextLote.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Lote:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(201, 61)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(19, 16)
        Me.lblDescripcion.TabIndex = 49
        Me.lblDescripcion.Text = "---"
        '
        'TextSKU
        '
        Me.TextSKU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSKU.Location = New System.Drawing.Point(204, 36)
        Me.TextSKU.Name = "TextSKU"
        Me.TextSKU.Size = New System.Drawing.Size(161, 22)
        Me.TextSKU.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(161, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 16)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "SKU"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(776, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Label6"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(776, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(770, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(702, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(702, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Label11"
        '
        'FrmTelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 365)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.TextSKU)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.TextPeso_Real)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextPeso_Teorico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextLote)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.TextBarra)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LEspacio)
        Me.Controls.Add(Me.LBloque)
        Me.Controls.Add(Me.LEstanteria)
        Me.Controls.Add(Me.TextUbicacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextRollo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBox)
        Me.KeyPreview = True
        Me.Name = "FrmTelas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Telas"
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextRollo As TextBox
    Friend WithEvents TextUbicacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LEstanteria As Label
    Friend WithEvents LBloque As Label
    Friend WithEvents LEspacio As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents TextBarra As TextBox
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents TextPeso_Real As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextPeso_Teorico As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextLote As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents TextSKU As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
