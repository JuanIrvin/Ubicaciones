<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccesorios
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
        Me.TextCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ldescripcion = New System.Windows.Forms.Label()
        Me.TextExistencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextTemporales = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextFisico = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bgrabar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextCodigo
        '
        Me.TextCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCodigo.Location = New System.Drawing.Point(211, 29)
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.Size = New System.Drawing.Size(155, 29)
        Me.TextCodigo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo Accesorio:"
        '
        'Ldescripcion
        '
        Me.Ldescripcion.AutoSize = True
        Me.Ldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ldescripcion.Location = New System.Drawing.Point(207, 72)
        Me.Ldescripcion.Name = "Ldescripcion"
        Me.Ldescripcion.Size = New System.Drawing.Size(183, 24)
        Me.Ldescripcion.TabIndex = 5
        Me.Ldescripcion.Text = "Codigo Accesorio:"
        '
        'TextExistencia
        '
        Me.TextExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextExistencia.Location = New System.Drawing.Point(211, 150)
        Me.TextExistencia.Name = "TextExistencia"
        Me.TextExistencia.Size = New System.Drawing.Size(155, 29)
        Me.TextExistencia.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Existencia Act.:"
        '
        'TextTemporales
        '
        Me.TextTemporales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTemporales.Location = New System.Drawing.Point(211, 195)
        Me.TextTemporales.Name = "TextTemporales"
        Me.TextTemporales.Size = New System.Drawing.Size(155, 29)
        Me.TextTemporales.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Temporales"
        '
        'TextFisico
        '
        Me.TextFisico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFisico.Location = New System.Drawing.Point(211, 242)
        Me.TextFisico.Name = "TextFisico"
        Me.TextFisico.Size = New System.Drawing.Size(155, 29)
        Me.TextFisico.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fisico:"
        '
        'Bgrabar
        '
        Me.Bgrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bgrabar.Location = New System.Drawing.Point(191, 320)
        Me.Bgrabar.Name = "Bgrabar"
        Me.Bgrabar.Size = New System.Drawing.Size(223, 79)
        Me.Bgrabar.TabIndex = 12
        Me.Bgrabar.Text = "Grabar Datos"
        Me.Bgrabar.UseVisualStyleBackColor = True
        '
        'FrmAccesorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 450)
        Me.Controls.Add(Me.Bgrabar)
        Me.Controls.Add(Me.TextFisico)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextTemporales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextExistencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Ldescripcion)
        Me.Controls.Add(Me.TextCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAccesorios"
        Me.Text = "FrmAccesorios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Ldescripcion As Label
    Friend WithEvents TextExistencia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextTemporales As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextFisico As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Bgrabar As Button
End Class
