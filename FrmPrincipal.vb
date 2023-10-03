
Public Class FrmPrincipal
    Public cnx As New ADODB.Connection


    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cnx.Open(cadenaConexion)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        PrintDocument1.Print()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtBloque.Text = TxtBloque.Text + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TxtEspacio.Text = TxtEspacio.Text + 1
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(ImgQR.Image, 50, 20, 90, 90)
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim posicion As Integer
        Dim codigo As String

        If e.KeyChar = Convert.ToChar(Keys.Enter) And TextBox1.Text.Trim().Length > 0 Then
            codigo = TextBox1.Text.ToString
            posicion = InStr(1, codigo, "-")
            Lestanteria.Text = Mid(codigo, 1, (posicion - 1))
            codigo = Mid(codigo, (posicion + 1), (codigo.Length - posicion))
            posicion = InStr(1, codigo, "-")
            Lbloque.Text = Mid(codigo, 1, (posicion - 1))
            codigo = Mid(codigo, (posicion + 1), (codigo.Length - posicion))
            posicion = InStr(1, codigo, "-")
            If posicion = 0 Then
                Lespacio.Text = Trim(codigo)
            Else
                Lespacio.Text = Mid(codigo, 1, (posicion - 1))
            End If
            TextBox2.Focus()
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim rs As New ADODB.Recordset

        If e.KeyChar = Convert.ToChar(Keys.Enter) And TextBox2.Text.Trim().Length > 0 Then
            rs.Open("select * from etiquetas where barra = " & TextBox2.Text, cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)
            If Not rs.EOF Then
                Lcodart.Text = rs.Fields("articulo").Value
                Ltalla.Text = rs.Fields("talla").Value
                Lcodcol.Text = rs.Fields("color").Value
                rs.Close()
                rs.Open("select linkcat from catal, catalg where catal.link = catalg.link and coddep = 101 and codart = '" & Lcodart.Text & "' and talla = '" & Ltalla.Text & "' and codcol = " & Lcodcol.Text, cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)
                Llinkcat.Text = rs.Fields("linkcat").Value
                rs.Close()
                rs.Open("select * from ubicacion where linkcat = " & Llinkcat.Text, cnx, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)
                If Not rs.EOF Then
                    rs.Fields("estanteria").Value = Lestanteria.Text
                    rs.Fields("bloque").Value = Lbloque.Text
                    rs.Fields("espacio").Value = Lespacio.Text
                    rs.Update()
                    MsgBox("Ubicacion Actualizada")
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox1.Focus()
                Else
                    rs.AddNew()
                    rs.Fields("linkcat").Value = Llinkcat.Text
                    rs.Fields("estanteria").Value = Lestanteria.Text
                    rs.Fields("bloque").Value = Lbloque.Text
                    rs.Fields("espacio").Value = Lespacio.Text
                    rs.Update()
                    MsgBox("Ubicacion Agragada")
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox1.Focus()
                End If
            Else
                MsgBox("NO ES POSIBLE UBICAR LA REFERENCIA TALLA Y COLOR")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmTelas.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmAccesorios.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FrmHilos.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FrmConsulta.Show()
    End Sub
End Class
