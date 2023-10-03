Imports System.Reflection.Emit

Public Class FrmConsulta
    Public cnx As New ADODB.Connection
    Public Sub TextRollo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextSKU.KeyPress


        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cargar_Detalle()
        End If
    End Sub

    Private Sub FrmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnx.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        cnx.Open(cadenaConexion)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextSKU.Text = DataGridView1.Item(0, e.RowIndex).Value
        TextEtiqueta.Text = DataGridView1.Item(1, e.RowIndex).Value
        TextLote.Text = DataGridView1.Item(2, e.RowIndex).Value
        TextPeso_Teorico.Text = DataGridView1.Item(3, e.RowIndex).Value
        TextPeso_Real.Text = DataGridView1.Item(4, e.RowIndex).Value
        TextPeso_Real.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rs As New ADODB.Recordset

        rs.Open("select * from mpinven where sku = '" & TextSKU.Text & "' and rollo =" & TextEtiqueta.Text, cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs.Fields("peso_real").Value = TextPeso_Real.Text
        rs.Fields("fecha").Value = Now
        rs.Update()
        rs.Close()
        If Err.Number = 0 Then
            MsgBox("Registro Grabado")
            'TextSKU.Text = ""
            TextEtiqueta.Text = ""
            TextLote.Text = ""
            TextPeso_Teorico.Text = ""
            TextPeso_Real.Text = ""
            Call cargar_detalle()
        End If
    End Sub
    Public Function cargar_detalle()
        Dim rs As New ADODB.Recordset
        Dim da As New System.Data.OleDb.OleDbDataAdapter()
        Dim ds As New DataSet()

        rs.Open("select * from productos where sku = '" & TextSKU.Text & "' ", cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            Label7.Text = rs.Fields("descripcion").Value
            rs.Close()
            rs.Open("select * from mpinven where sku = '" & TextSKU.Text & "' ", cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                da.Fill(ds, rs, "mpinven")
                DataGridView1.DataSource = (ds.Tables("mpinven"))
                DataGridView1.Columns(0).Visible = False
                DataGridView1.Columns(5).Visible = False
            End If
        Else
            MsgBox("El SKU no existe")
        End If
    End Function

End Class