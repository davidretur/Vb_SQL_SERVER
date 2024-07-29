Imports CapaEntidad
Imports CapaEntidades
Imports CapaNegocio
Public Class RegistrarPersona
    ' Define un evento que se puede usar para notificar al formulario principal
    Public Event DataUpdated As EventHandler
    ' Puedes tener un constructor que reciba datos o simplemente dejarlo vacío
    Public Sub New()
        InitializeComponent()
    End Sub
    Dim objNegocio As New CNPersonas
    Dim objPersona As New CEPersona

    Private Sub RegistrarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    ' funcion para obtener valores de los campos
    Function getNombre() As String
        Return TxtNombre.Text.Trim
    End Function
    Function getPais() As String
        Return ComboPaises.Text.Trim
    End Function

    Function getCorreo() As String
        Return TxtCorreo.Text.Trim
    End Function
    ' Limpiar formulario
    Sub LimpiarFormulario()
        TxtNombre.Text = ""
        ComboPaises.ValueMember = ""
        TxtCorreo.Text = ""
    End Sub
    'Registro de personas
    Sub registroPersona()
        objPersona.nombre = getNombre()
        objPersona.pais = getPais()
        objPersona.correo = getCorreo()
        objNegocio.registroPersonas(objPersona)
        LimpiarFormulario()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        registroPersona()
        RaiseEvent DataUpdated(Me, EventArgs.Empty)
        Me.Close()
    End Sub
End Class