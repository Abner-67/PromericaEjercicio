Imports System.Data.SqlClient
Public Class frm_inicio
    Dim conexion As New SqlConnection

    Private Sub frm_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("server=DESKTOP-DEJHHCU\MSSQLSERVER01; database=PromericaTest; integrated security=true")



        Agregar_grid()
    End Sub

    Public Sub Agregar_grid()
        Dim consulta As String = "select * from Producto"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        frm_agregar.Show()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        frm_editar.Show()

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        frm_eliminar.Show()
    End Sub

    Private Sub btn_renovar_Click(sender As Object, e As EventArgs) Handles btn_renovar.Click
        Dim consulta As String = "select * from Producto"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class