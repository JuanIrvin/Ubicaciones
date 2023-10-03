Public Class FrmAccesorios
    Public cnx As New ADODB.Connection
    Private Sub FrmAccesorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnx.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        cnx.Open(cadenaConexion)
    End Sub
    Private Sub TextCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextCodigo.KeyPress
        Dim rs As New ADODB.Recordset

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            rs.Open("select * from acce where codacc = '" & TextCodigo.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                Ldescripcion.Text = rs.Fields("nomacc").Value

                TextExistencia.Text = rs.Fields("exiact").Value
                TextTemporales.Text = buscar(TextCodigo.Text)
                TextFisico.Focus()
            End If
        End If
    End Sub
    Private Sub TextFisico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextFisico.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Bgrabar.Focus()
        End If
    End Sub

    Private Sub Bgrabar_Click(sender As Object, e As EventArgs) Handles Bgrabar.Click
        Dim rs As New ADODB.Recordset
        Dim query As String

        query = "select * from acceinven where 1 = 0"
        rs.Open(query, cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs.AddNew()
        rs.Fields("codacc").Value = TextCodigo.Text
        rs.Fields("existencia").Value = TextExistencia.Text
        rs.Fields("temporales").Value = TextTemporales.Text
        rs.Fields("fisico").Value = TextFisico.Text
        rs.Fields("fecha").Value = Now()
        rs.Update()
        rs.Close()


        TextCodigo.Text = ""
        TextExistencia.Text = 0
        TextTemporales.Text = 0
        TextFisico.Text = 0
        TextCodigo.Focus()
    End Sub
    Public Function buscar(codigo As String) As Double
        Dim rs As New ADODB.Recordset
        Dim cantidad As Double

        rs.Open("select tipo, cant from iamovgt, iamovdt where iamovgt.link = iamovdt.link and codacc = '" & TextCodigo.Text & "' ", cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            cantidad = 0
            While Not rs.EOF
                If rs.Fields("tipo").Value < 5 Then
                    cantidad = cantidad + rs.Fields("cant").Value
                Else
                    cantidad = cantidad - rs.Fields("cant").Value
                End If
                rs.MoveNext()
            End While
        End If

        Return (cantidad)
    End Function
End Class