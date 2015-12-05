Public Class frmMuestra
    Private Fun_Muestra As New Gestor_Muestra

    Private Tabla_SesionesCatacion As New BindingSource
    Private RegistroSeleccionado As New BindingSource
    Private RegistroSeleccionado_Productor As New BindingSource
    Private RegistroSeleccionado_Proveedor As New BindingSource
    Private TablaProductores As New BindingSource
    Private TablaProveedores As New BindingSource

    Private Sub frmMuestra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iniciar_Formulario()
        Cargar_Ciudades()
        CargarTabla_Productores()
        CargarTabla_Proveedor()
        Lipiar_Formulario()
    End Sub

    Sub Iniciar_Formulario() 'Carga todos los registros de sesiones de catacion en la tabla
        Dim Cod_Sesion As String
        Dim Var_Sesion As String

        Cod_Sesion = frmRealizarCataciones.varCod_Sesion 'Obtiene el Codigo de la sesion seleccionado
        Var_Sesion = frmRealizarCataciones.varSesion

        'Cargos los valor de identificador
        Tabla_SesionesCatacion.DataSource = Fun_Muestra.Lista_Valor_Identificado(Cod_Sesion)
        dgMuestras.DataSource = Tabla_SesionesCatacion
        dgMuestras.Columns("codigo").Visible = False

        'Mostramos el numero de la sesicion
        lbSesion.Text = Var_Sesion
    End Sub

    Sub Lipiar_Formulario()
        'Productor
        txtBuscarPor_Productor.Text = "Cedula"
        cbBuscar_Productor.Checked = False
        Desbilitar_Tabla_Productor()
        dgLista_Productores.ClearSelection() 'Cancelo la seleccion de la tabla

        'Proveedor
        cbBuscarPor_Proveedores.Text = "Cedula"
        cbBuscar_Proveedor.Checked = False
        Desbilitar_Tabla_Proveedor()
        dgLista_Proveedores.ClearSelection() 'Cancelo la seleccion de la tabla
    End Sub

    Sub Desbilitar_Tabla_Productor()
        gbProductor.Enabled = False
    End Sub

    Sub Habilitar_Tabla_Productor()
        gbProductor.Enabled = True
    End Sub

    Sub Desbilitar_Tabla_Proveedor()
        gbProveedor.Enabled = False
    End Sub

    Sub Habilitar_Tabla_Proveedor()
        gbProveedor.Enabled = True
    End Sub

    Private Sub cbBuscar_Productor_CheckedChanged(sender As Object, e As EventArgs) Handles cbBuscar_Productor.CheckedChanged
        If cbBuscar_Productor.Checked = True Then
            Habilitar_Tabla_Productor()
            dgLista_Productores.ClearSelection() 'Cancelo la seleccion de la tabla
            txtBuscar_Productor.Focus()
        ElseIf cbBuscar_Productor.Checked = False Then
            Desbilitar_Tabla_Productor()
            txtProductor.Clear()
            dgLista_Productores.ClearSelection() 'Cancelo la seleccion de la tabla
        End If
    End Sub

    Private Sub cbBuscar_Proveedor_CheckedChanged(sender As Object, e As EventArgs) Handles cbBuscar_Proveedor.CheckedChanged
        If cbBuscar_Proveedor.Checked = True Then
            Habilitar_Tabla_Proveedor()
            dgLista_Proveedores.ClearSelection() 'Cancelo la seleccion de la tabla
            txtBuscar_Proveedor.Focus()
        ElseIf cbBuscar_Proveedor.Checked = False Then
            Desbilitar_Tabla_Proveedor()
            txtProveedor.Clear()
            dgLista_Proveedores.ClearSelection() 'Cancelo la seleccion de la tabla
        End If
    End Sub

    'Borra el campo 'Buscar' justo antes de escoger otro atributo para filtrar la tabla
    Private Sub txtBuscarPor_Productor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBuscarPor_Productor.SelectedIndexChanged
        txtBuscar_Productor.Clear()
        txtBuscar_Productor.Focus()
    End Sub

    'Borra el campo 'Buscar' justo antes de escoger otro atributo para filtrar la tabla
    Private Sub cbBuscarPor_Proveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBuscarPor_Proveedores.SelectedIndexChanged
        txtBuscar_Proveedor.Clear()
        txtBuscar_Proveedor.Focus()
    End Sub

    Private Sub txtBuscar_Productor_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar_Productor.TextChanged
        If txtBuscar_Productor.TextLength = 0 Or txtBuscar_Productor.Text = "Buscar" Then
            TablaProductores.RemoveFilter()
            Exit Sub
        End If

        If txtBuscarPor_Productor.Text = "Cedula" Then
            TablaProductores.Filter = "cedula like '" & txtBuscar_Productor.Text & "%'"
        ElseIf txtBuscarPor_Productor.Text = "Nombre" Then
            TablaProductores.Filter = "nombre like '" & txtBuscar_Productor.Text & "%'"
        ElseIf txtBuscarPor_Productor.Text = "Apellido" Then
            TablaProductores.Filter = "apellido like '" & txtBuscar_Productor.Text & "%'"
        End If
    End Sub

    Private Sub txtBuscar_Proveedor_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar_Proveedor.TextChanged
        If txtBuscar_Proveedor.TextLength = 0 Or txtBuscar_Proveedor.Text = "Buscar" Then
            TablaProveedores.RemoveFilter()
            Exit Sub
        End If

        If cbBuscarPor_Proveedores.Text = "Cedula" Then
            TablaProveedores.Filter = "cedula like '" & txtBuscar_Proveedor.Text & "%'"
        ElseIf cbBuscarPor_Proveedores.Text = "Nombre" Then
            TablaProveedores.Filter = "nombre like '" & txtBuscar_Proveedor.Text & "%'"
        ElseIf cbBuscarPor_Proveedores.Text = "Apellido" Then
            TablaProveedores.Filter = "apellido like '" & txtBuscar_Proveedor.Text & "%'"
        End If
    End Sub

    'GRILLA: MUESTRAS - Evento de la grilla para mostrar los identificadores de las muestras selecciona de la sesion de catación
    Private Sub dgMuestras_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgMuestras.CellEnter
        Dim varCod_Muestra As String
        Dim row As DataGridViewRow = dgMuestras.CurrentRow
        varCod_Muestra = CStr(row.Cells("codigo").Value)
        Try
            RegistroSeleccionado.DataSource = Fun_Muestra.Buscar_Muestra() 'Obtiene la muestra de la sesion seleccionada
            RegistroSeleccionado.Filter = "cod_muestra = '" & varCod_Muestra & "'"

            lbMuestra.Text = RegistroSeleccionado.Item(0)("valor_identificado")
            txtNombre.Text = RegistroSeleccionado.Item(0)("nombre_muestra")
            txtDescripcion.Text = RegistroSeleccionado.Item(0)("descripcion")
            txtEspecie.Text = RegistroSeleccionado.Item(0)("especie")
            cbAnio_Cosecha.Text = RegistroSeleccionado.Item(0)("anio_cosecha")
            nuHumedad.Text = RegistroSeleccionado.Item(0)("humedad")
            cbCiudad.Text = RegistroSeleccionado.Item(0)("ciudad")
            'txtProductor.Text = RegistroSeleccionado.Item(0)("finca_productor")
            'txtProveedor.Text = RegistroSeleccionado.Item(0)("finca_proveedor")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'GRILLA: PRODUCTO - Evento de la grilla para mostrar la cedula en el campo 'Productor'
    Private Sub dgLista_Productores_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgLista_Productores.CellEnter
        If dgLista_Productores.ContainsFocus = True Then
            Dim Cedula_Productor As String
            Dim row As DataGridViewRow = dgLista_Productores.CurrentRow
            Cedula_Productor = CStr(row.Cells("Cedula").Value)
            Try
                RegistroSeleccionado_Productor.DataSource = Fun_Muestra.Tabla_Productores() 'Obtiene la muestra de la sesion seleccionada
                RegistroSeleccionado_Productor.Filter = "Cedula = '" & Cedula_Productor & "'"

                txtProductor.Text = RegistroSeleccionado_Productor.Item(0)("Cedula")
                'txtProductor.Text = RegistroSeleccionado.Item(0)("finca_productor")
                'txtProveedor.Text = RegistroSeleccionado.Item(0)("finca_proveedor")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'GRILLA: PROVEEDOR - Evento de la grilla para mostrar la cedula en el campo 'Proveedor'
    Private Sub dgLista_Proveedores_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgLista_Proveedores.CellEnter
        If dgLista_Proveedores.ContainsFocus = True Then
            Dim Cedula_Proveedor As String
            Dim row As DataGridViewRow = dgLista_Proveedores.CurrentRow
            Cedula_Proveedor = CStr(row.Cells("Cedula").Value)
            Try
                RegistroSeleccionado_Proveedor.DataSource = Fun_Muestra.Tabla_Proveedores() 'Obtiene la muestra de la sesion seleccionada
                RegistroSeleccionado_Proveedor.Filter = "Cedula = '" & Cedula_Proveedor & "'"

                txtProveedor.Text = RegistroSeleccionado_Proveedor.Item(0)("Cedula")
                'txtProductor.Text = RegistroSeleccionado.Item(0)("finca_productor")
                'txtProveedor.Text = RegistroSeleccionado.Item(0)("finca_proveedor")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Sub Cargar_Ciudades()
        Dim Lista_Ciudades As New BindingSource
        Lista_Ciudades.DataSource = Fun_Muestra.Lista_Ciudad()
        cbCiudad.Items.Clear()
        For i = 0 To Lista_Ciudades.Count - 1
            cbCiudad.Items.Add(Lista_Ciudades.Item(i)("nombre"))
        Next
    End Sub

    Sub CargarTabla_Productores() 'Carga los registros de los productores en la tabla
        TablaProductores.DataSource = Fun_Muestra.Tabla_Productores()
        dgLista_Productores.DataSource = TablaProductores
    End Sub

    Sub CargarTabla_Proveedor() 'Carga los registros de los proveedor en la tabla
        TablaProveedores.DataSource = Fun_Muestra.Tabla_Proveedores()
        dgLista_Proveedores.DataSource = TablaProveedores
    End Sub

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        frmCiudad.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class