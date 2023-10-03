Public Class FrmHilos
    Public cnx As New ADODB.Connection

    Private Sub FrmHilos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnx.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        cnx.Open(cadenaConexion)
    End Sub

    Private Sub TextRollo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextRollo.KeyPress
        Dim da As New System.Data.OleDb.OleDbDataAdapter()
        Dim ds As New DataSet()
        Dim rs As New ADODB.Recordset

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            rs.Open("select * from productos where sku = '" & TextRollo.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                Label7.Text = rs.Fields("descripcion").Value
                rs.Close()
                rs.Open("select descripcion, sku, rolloetiqueta, lote, existencia  from productos, detalleexistencia where productos.codigoproducto = detalleexistencia.codigoproducto and detalleexistencia.codigobodega = 1 and productos.sku = '" & TextRollo.Text & "' ", cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly)
                If Not rs.EOF Then
                    da.Fill(ds, rs, "productos")
                    DataGridView1.DataSource = (ds.Tables("productos"))
                    DataGridView1.Columns(0).Visible = False
                    DataGridView1.Columns(1).Visible = False
                End If
            End If
        End If
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim rs As New ADODB.Recordset
        Dim numero As Double

        'Pbox es un picturebox
        TextSKU.Text = DataGridView1.Item(1, e.RowIndex).Value
        TextEtiqueta.Text = DataGridView1.Item(2, e.RowIndex).Value
        TextLote.Text = DataGridView1.Item(3, e.RowIndex).Value
        TextPeso_Teorico.Text = DataGridView1.Item(4, e.RowIndex).Value
        TextPeso_Real.Text = DataGridView1.Item(4, e.RowIndex).Value
        TextPeso_Real.Focus()






    End Sub

    Private Sub TextPeso_Real_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPeso_Real.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rs As New ADODB.Recordset

        rs.Open("select * from mpinven ", cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        rs.AddNew()
        rs.Fields("sku").Value = Trim(TextSKU.Text)
        rs.Fields("rollo").Value = TextEtiqueta.Text
        rs.Fields("lote").Value = TextLote.Text
        rs.Fields("peso_teorico").Value = TextPeso_Teorico.Text
        rs.Fields("peso_real").Value = TextPeso_Real.Text
        rs.Fields("fecha").Value = Now
        rs.Update()
        rs.Close()
        If Err.Number = 0 Then
            MsgBox("Registro Grabado")
            TextSKU.Text = ""
            TextEtiqueta.Text = ""
            TextLote.Text = ""
            TextPeso_Teorico.Text = ""
            TextPeso_Real.Text = ""
            DataGridView1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextSKU.Enabled = True
        TextEtiqueta.Enabled = True
        TextLote.Enabled = True
        TextPeso_Teorico.Text = 0
        TextSKU.Focus()
    End Sub


    Private Sub TextSKU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextSKU.KeyPress
        Dim rs As New ADODB.Recordset

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            rs.Open("select * from productos where sku = '" & TextSKU.Text & "' ", cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not rs.EOF Then
                TextEtiqueta.Focus()
                Label8.Text = rs.Fields("descripcion").Value
            Else
                MsgBox("El SKU no existe")
            End If
            rs.Close()
        End If
    End Sub
    Private Sub TextEtiqueta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEtiqueta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            TextLote.Focus()
        End If
    End Sub

    Private Sub TextLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextLote.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            TextPeso_Real.Focus()
        End If
    End Sub

    Private Sub TextSKU_TextChanged(sender As Object, e As EventArgs) Handles TextSKU.TextChanged

    End Sub
End Class