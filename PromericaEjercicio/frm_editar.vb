Imports System.Data.SqlClient

Public Class frm_editar
    Dim conexion As New SqlConnection
    Dim comando As SqlCommand
    Private Sub frm_editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-DEJHHCU\MSSQLSERVER01; database=PromericaTest; integrated security=true")
        tipoproducto()
        tipounidad()
    End Sub
    Public Sub tipoproducto()
        Dim consulta As String = "select * from ProductoTipo"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adaptador.Fill(dt)

        cb_tipo.ValueMember = "Id"
        cb_tipo.DisplayMember = "Nombre"
        cb_tipo.DataSource = dt

    End Sub
    Public Sub tipounidad()

        Dim consulta As String = "select * from UnidadMedida"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adaptador.Fill(dt)

        cb_unidadm.ValueMember = "Id"
        cb_unidadm.DisplayMember = "Nombre"
        cb_unidadm.DataSource = dt
    End Sub
    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        conexion.Open()
        Dim valorcheck As Boolean = ck_estado.Checked
        Dim valor As Integer = If(valorcheck, 1, 0)
        Dim consulta As String = "UPDATE Producto SET Nombre=@nombre, ProductoTipoId=@productoTipoId, UnidadMedidaId=@unidadMedidaId, Estado=@estado WHERE Código=@codigo"

        comando = New SqlCommand(consulta, conexion)
        comando.Parameters.AddWithValue("@nombre", txt_nombre.Text)
        comando.Parameters.AddWithValue("@productoTipoId", CInt(cb_tipo.SelectedValue))
        comando.Parameters.AddWithValue("@unidadMedidaId", CInt(cb_unidadm.SelectedValue))
        comando.Parameters.AddWithValue("@estado", valor)
        comando.Parameters.AddWithValue("@codigo", txt_codigo.Text)

        Dim cant As Integer
        cant = comando.ExecuteNonQuery()

        If cant = 1 Then
            txt_codigo.Text = ""
            txt_nombre.Text = ""
            MessageBox.Show("Se actualizaron los datos correctamente")
        Else
            MessageBox.Show("No existe el producto ingresado")
        End If

        conexion.Close()

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        txt_codigo.Clear()
        txt_nombre.Clear()
    End Sub

    Private Sub txt_codigo_TextChanged(sender As Object, e As EventArgs) Handles txt_codigo.TextChanged
        If Not String.IsNullOrWhiteSpace(txt_codigo.Text) Then
            Try
                conexion.Open()
                Dim consulta As String = "SELECT Nombre, ProductoTipoId, UnidadMedidaId FROM Producto WHERE Código = @codigo"
                comando = New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@codigo", txt_codigo.Text)

                Dim reader As SqlDataReader = comando.ExecuteReader()

                If reader.Read() Then

                    txt_nombre.Text = reader("Nombre").ToString()
                    cb_tipo.SelectedItem = reader("ProductoTipoId").ToString()
                    cb_unidadm.SelectedItem = reader("UnidadMedidaId").ToString()
                Else

                    txt_nombre.Clear()
                    cb_tipo.SelectedIndex = -1
                    cb_unidadm.SelectedIndex = -1
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error al buscar el producto: " & ex.Message)
            Finally
                conexion.Close()
            End Try
        Else

            txt_nombre.Clear()
            cb_tipo.SelectedIndex = -1
            cb_unidadm.SelectedIndex = -1
        End If
    End Sub
End Class