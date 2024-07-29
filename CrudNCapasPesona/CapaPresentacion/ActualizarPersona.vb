Imports CapaEntidades
Imports CapaNegocio

Public Class ActualizarPersona
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
    ' crear el constructor para resibir los datos requerido en este deben de ubicar las variables necesarias
    Public Sub New(id As Integer)
        ' para enviar parametros entre formularios
        InitializeComponent()
        itemId = id
        CargarDatosFormulario(itemId)
    End Sub
    Private Sub ActualizarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBoxPaises()
    End Sub

    ' Método para llenar el ComboBox con una lista de países
    Private Sub LlenarComboBoxPaises()
        ' Crear una lista de 10 países
        Dim listaPaises As New List(Of String) From {
            "Argentina",
            "Brasil",
            "Canadá",
            "Chile",
            "Colombia",
            "España",
            "Estados Unidos",
            "Francia",
            "México",
            "Perú"
        }

        ' Limpiar el ComboBox antes de llenarlo
        ComboPaises.Items.Clear()

        ' Agregar los países a la lista del ComboBox
        For Each pais As String In listaPaises
            ComboPaises.Items.Add(pais)
        Next
    End Sub
    Public Sub CargarDatosFormulario(ByVal id As Integer)
        ' Obtén la persona por ID
        Dim objCapaNegocio As New CNPersonas
        Dim persona As CEPersona = objCapaNegocio.listarUnaPersonas(id)

        ' Asigna los valores a los controles del formulario
        TxtIdActualizar.Text = persona.idPersona.ToString
        TxtNombre.Text = persona.nombre
        TxtCorreo.Text = persona.correo

        ' Asigna el valor al ComboBox (esto puede variar dependiendo de cómo estés manejando el ComboBox)
        ' Aquí asumimos que comboBoxPais tiene un método para seleccionar el ítem por texto
        ComboPaises.Text = persona.pais
    End Sub
    ' funcion para obtener valores de los campos
    Function getIdPersona() As String
        Return TxtIdActualizar.Text.Trim
    End Function
    Function getNombre() As String
        Return TxtNombre.Text.Trim
    End Function
    Function getPais() As String
        Return ComboPaises.Text.Trim
    End Function

    Function getCorreo() As String
        Return TxtCorreo.Text.Trim
    End Function
    'Registro de personas
    Sub ActualizarPersona()
        objPersona.idPersona = getIdPersona()
        objPersona.nombre = getNombre()
        objPersona.pais = getPais()
        objPersona.correo = getCorreo()
        objNegocio.ActualizarPersona(objPersona)
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ActualizarPersona()
        RaiseEvent DataUpdated(Me, EventArgs.Empty)
        Me.Close()
    End Sub
End Class