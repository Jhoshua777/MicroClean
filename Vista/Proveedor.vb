Imports Controlador
Imports Modelo

Public Class Proveedor
    Private Sub CargarGrid()
        Try
            Dim cons As New bdProveedor
            Dim dtb As DataTable
            dtb = cons.Cargar
            If dtb.Rows.Count > 0 Then
                dgvProv.DataSource = dtb
            Else
                MessageBox.Show("Genero un problema al cargar los datos")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Limpiar()
        txtNombre.Text = String.Empty
        txtNit.Text = String.Empty
        txtRazon.Text = String.Empty
        txtDireccion.Text = String.Empty
        txtCiudad.Text = String.Empty
        txtTelfono.Text = String.Empty
        txtContacto.Text = String.Empty
        txtEmail.Text = String.Empty
        txtId_proveedor.Text = String.Empty
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            Dim add As New bdProveedor
            Dim dt As New cProveedor
            Dim sqlOk As Integer = 0

            If txtNombre.Text <> "" And txtNit.Text <> "" And txtRazon.Text <> "" Then
                dt._Nombre = Convert.ToString(txtNombre.Text)
                dt._Nit = Convert.ToInt32(txtNit.Text)
                dt._Razon = Convert.ToString(txtRazon.Text)
                dt._Direccion = Convert.ToString(txtDireccion.Text)
                dt._Ciudad = Convert.ToString(txtCiudad.Text)
                dt._Telfono = Convert.ToInt32(txtTelfono.Text)
                dt._Contacto = Convert.ToInt32(txtContacto.Text)
                dt._Email = Convert.ToString(txtEmail.Text)

                sqlOk = add.Insertar(dt)
                If sqlOk > 0 Then
                    CargarGrid()
                    Limpiar()
                Else
                    MessageBox.Show("Genero un problema al registrar los datos")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim edit As New bdProveedor
            Dim dt As New cProveedor
            Dim sqlOk As Integer = 0

            If txtNombre.Text <> "" And txtNit.Text <> "" And txtRazon.Text <> "" Then
                dt._Nombre = Convert.ToString(txtNombre.Text)
                dt._Nit = Convert.ToInt32(txtNit.Text)
                dt._Razon = Convert.ToString(txtRazon.Text)
                dt._Direccion = Convert.ToString(txtDireccion.Text)
                dt._Ciudad = Convert.ToString(txtCiudad.Text)
                dt._Telfono = Convert.ToInt32(txtTelfono.Text)
                dt._Contacto = Convert.ToInt32(txtContacto.Text)
                dt._Email = Convert.ToString(txtEmail.Text)
                dt._Id_proveedor = Convert.ToInt32(txtId_proveedor.Text)

                sqlOk = edit.Editar(dt)
                If sqlOk > 0 Then
                    CargarGrid()
                    Limpiar()
                Else
                    MessageBox.Show("Genero un problema al registrar los datos")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        CargarGrid()
    End Sub
    Private Sub MostrarRegistro()
        Try
            If dgvProv.RowCount > 0 Then
                If dgvProv.CurrentRow.Selected = True Then
                    txtId_proveedor.Text = dgvProv.CurrentRow.Cells.Item(0).Value.ToString
                    txtNombre.Text = dgvProv.CurrentRow.Cells.Item(1).Value.ToString
                    txtNit.Text = dgvProv.CurrentRow.Cells.Item(2).Value.ToString
                    txtRazon.Text = dgvProv.CurrentRow.Cells.Item(3).Value.ToString
                    txtDireccion.Text = dgvProv.CurrentRow.Cells.Item(4).Value.ToString
                    txtCiudad.Text = dgvProv.CurrentRow.Cells.Item(5).Value.ToString
                    txtTelfono.Text = dgvProv.CurrentRow.Cells.Item(6).Value.ToString
                    txtContacto.Text = dgvProv.CurrentRow.Cells.Item(7).Value.ToString
                    txtEmail.Text = dgvProv.CurrentRow.Cells.Item(8).Value.ToString
                Else
                    MessageBox.Show("Debe seleccionar una fila del Listado de Datos")
                End If
            Else
                MessageBox.Show("El Listado NO tiene datos, seleccione el BOTON [Consultar]")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If dgvProv.RowCount > 0 Then
                If dgvProv.CurrentRow.Selected = True Then
                    Dim Result As DialogResult = MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO NRO. " & dgvProv.CurrentRow.Cells.Item(0).Value.ToString, "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If Result = DialogResult.Yes Then
                        Dim dt As New cProveedor
                        Dim elim As New bdProveedor
                        Dim sqlok As Integer

                        dt._Id_proveedor = CInt(dgvProv.CurrentRow.Cells.Item(0).Value)
                        sqlok = elim.Eliminar(dt)
                        If sqlok > 0 Then
                            CargarGrid()
                            Limpiar()
                        End If
                    End If
                End If
            Else
                MessageBox.Show("El listado no tiene datos, seleccione el Boton [Consultar]")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvProv_DoubleClick(sender As Object, e As EventArgs) Handles dgvProv.DoubleClick
        MostrarRegistro()
    End Sub
End Class