Imports System.Data.SqlClient
Imports Controlador

Public Class bdProveedor
    Inherits Conexion
    Private comand As SqlCommand
    Private ok As Integer = 0

    Public Function Insertar(ByVal dts As cProveedor) As Integer
        Try
            Conectado()
            comand = New SqlCommand("Insert_Prov")
            comand.CommandType = CommandType.StoredProcedure
            comand.Connection = conex

            comand.Parameters.AddWithValue("@Nombre", dts._Nombre)
            comand.Parameters.AddWithValue("@Nit", dts._Nit)
            comand.Parameters.AddWithValue("@Razon", dts._Razon)
            comand.Parameters.AddWithValue("@Direccion", dts._Direccion)
            comand.Parameters.AddWithValue("@Ciudad", dts._Ciudad)
            comand.Parameters.AddWithValue("@Telefono", dts._Telfono)
            comand.Parameters.AddWithValue("@Contacto", dts._Contacto)
            comand.Parameters.AddWithValue("@Email", dts._Email)

            ok = comand.ExecuteNonQuery()
            If ok = 1 Then
                Return 1
            Else
                Return 0
            End If

        Catch [me] As SqlException
            System.Console.Write([me].Message)
            Return 0
        Finally
            Desconectado()
        End Try
    End Function

    Public Function Editar(ByVal dts As cProveedor) As Integer
        Try
            Conectado()
            comand = New SqlCommand("Edit_Prov")
            comand.CommandType = CommandType.StoredProcedure
            comand.Connection = conex

            comand.Parameters.AddWithValue("@Nombre", dts._Nombre)
            comand.Parameters.AddWithValue("@Nit", dts._Nit)
            comand.Parameters.AddWithValue("@Razon", dts._Razon)
            comand.Parameters.AddWithValue("@Direccion", dts._Direccion)
            comand.Parameters.AddWithValue("@Ciudad", dts._Ciudad)
            comand.Parameters.AddWithValue("@Telefono", dts._Telfono)
            comand.Parameters.AddWithValue("@Contacto", dts._Contacto)
            comand.Parameters.AddWithValue("@Email", dts._Email)
            comand.Parameters.AddWithValue("@Id_proveedor", dts._Id_proveedor)

            ok = comand.ExecuteNonQuery()
            If ok = 1 Then
                Return 1
            Else
                Return 0
            End If

        Catch [me] As SqlException
            System.Console.Write([me].Message)
            Return 0
        Finally
            Desconectado()
        End Try
    End Function

    Public Function Eliminar(ByVal dts As cProveedor) As Integer
        Try
            Conectado()
            comand = New SqlCommand("Elim_Prov")
            comand.CommandType = CommandType.StoredProcedure
            comand.Connection = conex
            comand.Parameters.AddWithValue("@Id_proveedor", dts._Id_proveedor)
            If comand.ExecuteNonQuery Then
                Return 1
            Else
                Return 0
            End If
        Catch [me] As SqlException
            System.Console.Write([me].Message)
            Return 0
        Finally
            Desconectado()
        End Try
    End Function

    Public Function Cargar() As DataTable
        Try
            Conectado()
            comand = New SqlCommand("Listado_Prov")
            comand.CommandType = CommandType.StoredProcedure
            comand.Connection = conex
            If comand.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comand)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch [me] As SqlException
            System.Console.Write([me].Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function

End Class