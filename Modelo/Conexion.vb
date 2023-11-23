Imports System.Data.SqlClient
Public Class Conexion
    Public conex As New SqlConnection

    Public Function Conectado()
        Try
            'Crear la variable conex
            conex = New SqlConnection(My.Settings.dbmicroclean)
            'Abrir conexion
            conex.Open()
            'Retorno conexion ocn exito con el true
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desconectado()
        Try
            If conex.State = ConnectionState.Open Then      'Verifico si esta abierta
                'Cerrar la conexion
                conex.Close()
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
