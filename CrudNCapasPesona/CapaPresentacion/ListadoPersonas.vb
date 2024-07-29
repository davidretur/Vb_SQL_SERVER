Imports CapaNegocio
Public Class ListadoPersonas

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPersonas()
        BotonActualizar()
        BotonEliminar()
    End Sub

    Sub ListarPersonas()
        ' Aquí iría la lógica para cargar los datos en el DataGridView
        ' Por ejemplo, podrías volver a consultar la base de datos o la fuente de datos
        'DataGridView1.Rows.Clear()
        Dim objCapaNegocio As New CNPersonas
        DataGridView1.DataSource = objCapaNegocio.listarPersonas.Tables("Personas")
        lblTotal.Text = objCapaNegocio.listarPersonas.Tables("Personas").Rows.Count
    End Sub

    Sub BotonActualizar()
        ' Añadir columna de botón
        Dim buttonColumn As New DataGridViewButtonColumn()
        buttonColumn.Name = "BtnEditar"
        buttonColumn.HeaderText = "Details"
        buttonColumn.Text = "Editar"
        buttonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(buttonColumn)
    End Sub
    Sub BotonEliminar()
        ' Añadir columna de botón
        Dim buttonColumn As New DataGridViewButtonColumn()
        buttonColumn.Name = "BtnEliminar"
        buttonColumn.HeaderText = "Eliminar"
        buttonColumn.Text = "Eliminar"
        buttonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(buttonColumn)
    End Sub

    Private Sub dataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Verificar si el clic fue en la columna del botón
        If e.ColumnIndex = DataGridView1.Columns("BtnEditar").Index AndAlso e.RowIndex >= 0 Then
            ' Obtener el ID del ítem seleccionado
            Dim selectedId As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("Codigo").Value)
            ' Crear una instancia del formulario de registro
            Dim registerForm As New ActualizarPersona(selectedId)

            ' Suscribirse al evento DataUpdated del formulario de registro
            AddHandler registerForm.DataUpdated, AddressOf OnDataUpdated

            ' Mostrar el formulario de registro
            registerForm.ShowDialog()
        End If
        ' Verificar si el clic fue en la columna del botón
        If e.ColumnIndex = DataGridView1.Columns("BtnEliminar").Index AndAlso e.RowIndex >= 0 Then
            ' Obtener el ID del ítem seleccionado
            Dim selectedId As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("Codigo").Value)
            ' Crear una instancia del formulario de registro
            Dim registerForm As New EliminarPersona(selectedId)

            ' Suscribirse al evento DataUpdated del formulario de registro
            AddHandler registerForm.DataUpdated, AddressOf OnDataUpdated

            ' Mostrar el formulario de registro
            registerForm.ShowDialog()
        End If

    End Sub
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ' Crear una instancia del formulario de registro
        Dim registerForm As New RegistrarPersona()

        ' Suscribirse al evento DataUpdated del formulario de registro
        AddHandler registerForm.DataUpdated, AddressOf OnDataUpdated

        ' Mostrar el formulario de registro
        registerForm.ShowDialog()
    End Sub
    Private Sub OnDataUpdated(sender As Object, e As EventArgs)
        ' Cuando se active el evento DataUpdated, actualizar el DataGridView
        ListarPersonas()
    End Sub

End Class
