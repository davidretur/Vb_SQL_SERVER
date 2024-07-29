Imports CapaEntidades
Imports CapaNegocio

Public Class EliminarPersona
    ' Define un evento que se puede usar para notificar al formulario principal
    Public Event DataUpdated As EventHandler
    ' Puedes tener un constructor que reciba datos o simplemente dejarlo vacío
    Public Sub New()
        InitializeComponent()
    End Sub
    ' Puedes tener un constructor que reciba datos o simplemente dejarlo vacío
    Private itemId As Integer
    Dim objPersona As New CEPersona
    Dim objNegocio As New CNPersonas
    Public Sub New(id As Integer)
        ' para enviar parametros entre formularios
        InitializeComponent()
        itemId = id
        CargarDatosFormulario(itemId)
    End Sub
    Private Sub EliminarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub CargarDatosFormulario(ByVal id As Integer)
        ' Obtén la persona por ID
        Dim objCapaNegocio As New CNPersonas
        Dim persona As CEPersona = objCapaNegocio.listarUnaPersonas(id)

        ' Asigna los valores a los controles del formulario
        LblId.Text = persona.idPersona.ToString
        LblNombre.Text = persona.nombre
        LblCorreo.Text = persona.correo

        ' Asigna el valor al ComboBox (esto puede variar dependiendo de cómo estés manejando el ComboBox)
        ' Aquí asumimos que comboBoxPais tiene un método para seleccionar el ítem por texto
        LblPais.Text = persona.pais
    End Sub
    ' funcion para obtener valores de los campos
    Function getIdPersona() As String
        Return LblId.Text.Trim
    End Function
    Sub EliminarPersona()
        objPersona.idPersona = getIdPersona()
        objNegocio.EliminarPersona(objPersona)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        EliminarPersona()
        RaiseEvent DataUpdated(Me, EventArgs.Empty)
        Me.Close()
    End Sub
End Class