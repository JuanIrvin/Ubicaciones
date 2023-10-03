Imports ZXing
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmTelas
    Public cnx As New ADODB.Connection
    Dim codigoProducto As Integer
    Dim programName As String = "El Zeppelin S.A."
    Dim nuevo As Boolean
    Private Sub FrmTelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnx.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        cnx.Open(cadenaConexion)
    End Sub
    Private Sub FrmTelas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextSKU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextSKU.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) And Not nuevo Then
            buscarReferencia()
        End If
    End Sub

    Private Sub TextSKU_TextChanged(sender As Object, e As EventArgs) Handles TextSKU.TextChanged
        lblDescripcion.Text = "---"
    End Sub
    Private Sub TextBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBarra.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) And Not nuevo Then
            buscarRollo()
        End If
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        grabar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If nuevo Then
            limpiar()
        Else
            limpiar()
            btnNuevo.Text = "Cancelar"
            Me.BackColor = Color.DarkGray
            nuevo = True
            TextSKU.Focus()
        End If

    End Sub

    Sub buscarReferencia()
        Dim rs As New ADODB.Recordset
        Dim query As String

        query = ""
        query = "select first 100 * from productos where sku = '" & TextSKU.Text & "'"
        rs.Open(query, cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            TextSKU.Text = rs.Fields("sku").Value
            lblDescripcion.Text = rs.Fields("descripcion").Value
            codigoProducto = rs.Fields("codigoproducto").Value
        Else
            MessageBox.Show("No se encuentra el SKU indicado, por favor vuelva a intentarlo", programName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextSKU.Focus()
        End If
        If rs.State = 1 Then rs.Close()
    End Sub
    Sub buscarRollo()
        Dim rs As New ADODB.Recordset

        rs.Open("SELECT * 
                        FROM detalleexistencia 
                        WHERE codigoproducto = '" & codigoProducto & "'
                        AND rolloetiqueta = '" & TextBarra.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            TextLote.Text = rs.Fields("lote").Value
            TextPeso_Teorico.Text = rs.Fields("existencia").Value
            TextPeso_Real.Text = rs.Fields("existencia").Value
            TextLote.Enabled = False
            TextPeso_Teorico.Enabled = False
        Else
            MessageBox.Show("No se encuentra el Rollo indicado, por favor vuelva a intentarlo", programName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextSKU.Focus()
        End If
    End Sub
    Sub grabar()
        'sku
        'rollo
        'lote
        'peso_teorico
        'peso_real
        'fecha

        Dim rs As New ADODB.Recordset
        Dim query As String

        query = ""
        query = "select * from mpinven where sku = '" & Trim(TextSKU.Text) & "' and rollo = " & TextBarra.Text
        rs.Open(query, cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.EOF Then
            rs.AddNew()
            rs.Fields("sku").Value = Trim(TextSKU.Text)
            rs.Fields("rollo").Value = TextBarra.Text
            rs.Fields("lote").Value = TextLote.Text
            rs.Fields("peso_teorico").Value = TextPeso_Teorico.Text
            rs.Fields("peso_real").Value = TextPeso_Real.Text
            rs.Fields("fecha").Value = Now
            rs.Update()
            rs.Close()
            limpiar()
        Else
            MessageBox.Show("El registro ya existe!", programName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Sub limpiar()
        btnNuevo.Text = "Nuevo"
        Me.BackColor = SystemColors.Control
        'TextSKU.Clear()
        lblDescripcion.Text = "---"
        TextBarra.Clear()
        TextLote.Clear()
        TextPeso_Teorico.Clear()
        TextPeso_Real.Clear()
        codigoProducto = 0
        nuevo = False
        TextLote.Enabled = True
        TextPeso_Teorico.Enabled = True
        TextPeso_Real.Enabled = True
        If TextSKU.Text.Trim.Length > 0 Then
            TextSKU_KeyPress(TextSKU, New KeyPressEventArgs(Convert.ToChar(Keys.Enter)))
            TextBarra.Focus()
        Else
            TextSKU.Focus()
        End If

    End Sub






























    Private Sub TextRollo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextRollo.KeyPress
        Dim da As New System.Data.OleDb.OleDbDataAdapter()
        Dim ds As New DataSet()
        Dim rs As New ADODB.Recordset

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            rs.Open("select sku, rolloetiqueta, existencia, fecha, detalleexistencia.codigobodega, detalleexistencia.codigoproducto from productos, detalleexistencia where productos.codigoproducto = detalleexistencia.codigoproducto and rolloetiqueta = " & TextRollo.Text, cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                da.Fill(ds, rs, "productos")
                DataGridView1.DataSource = (ds.Tables("productos"))
            End If
        End If
    End Sub

    Private Sub TextUbicacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextUbicacion.KeyPress
        Dim codigo As String
        Dim posicion As Integer

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            codigo = TextUbicacion.Text.ToString
            posicion = InStr(1, codigo, "-")
            LEstanteria.Text = Mid(codigo, 1, (posicion - 1))
            codigo = Mid(codigo, (posicion + 1), (codigo.Length - posicion))
            posicion = InStr(1, codigo, "-")
            LBloque.Text = Mid(codigo, 1, (posicion - 1))
            codigo = Mid(codigo, (posicion + 1), (codigo.Length - posicion))
            posicion = InStr(1, codigo, "-")
            If posicion = 0 Then
                LEspacio.Text = Trim(codigo)
            Else
                LEspacio.Text = Mid(codigo, 1, (posicion - 1))
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim rs As New ADODB.Recordset
        Dim numero As Double

        'Pbox es un picturebox
        numero = Year(DataGridView1.Item(3, e.RowIndex).Value)
        numero = numero & Month(DataGridView1.Item(3, e.RowIndex).Value)
        numero = numero & DataGridView1.Item(1, e.RowIndex).Value
        PBox.Image = Nothing
        'Dim Writer As New BarcodeWriter
        'Writer.Format = BarcodeFormat.CODE_128
        'PBox.Image = Writer.Write(numero)
        PrintPreviewDialog1.ShowDialog()
        'cnx.Execute("INSERT into ubicaciones values(" & numero & "," & DataGridView1.Item(4, e.RowIndex).Value & "," & DataGridView1.Item(5, e.RowIndex).Value & "," & DataGridView1.Item(1, e.RowIndex).Value & "," & LEstanteria.Text & "," & LBloque.Text & "," & LEspacio.Text & ")")
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(PBox.Image, 10, 0, 110, 60)
    End Sub


    Private Sub TextSKU_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        Dim rs As New ADODB.Recordset

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            rs.Open("select * from productos where sku = '" & TextSKU.Text & "' ", cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not rs.EOF Then
                'TextEtiqueta.Focus()
                lblDescripcion.Text = rs.Fields("descripcion").Value
            Else
                MsgBox("El SKU no existe")
            End If
            rs.Close()
        End If
    End Sub
    Private Sub TextEtiqueta_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            TextLote.Focus()
        End If
    End Sub


End Class