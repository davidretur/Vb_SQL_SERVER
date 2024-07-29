<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TxtNombre = New TextBox()
        TxtCorreo = New TextBox()
        ComboPaises = New ComboBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(277, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 21)
        Label1.TabIndex = 0
        Label1.Text = "Registro de Personas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(104, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 17)
        Label2.TabIndex = 1
        Label2.Text = "Ingresa Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(104, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 17)
        Label4.TabIndex = 3
        Label4.Text = "Ingresa Correo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(104, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 17)
        Label3.TabIndex = 2
        Label3.Text = "Selecciona Pais"
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(253, 109)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(169, 23)
        TxtNombre.TabIndex = 4
        ' 
        ' TxtCorreo
        ' 
        TxtCorreo.Location = New Point(253, 180)
        TxtCorreo.Name = "TxtCorreo"
        TxtCorreo.Size = New Size(171, 23)
        TxtCorreo.TabIndex = 5
        ' 
        ' ComboPaises
        ' 
        ComboPaises.FormattingEnabled = True
        ComboPaises.Location = New Point(253, 144)
        ComboPaises.Name = "ComboPaises"
        ComboPaises.Size = New Size(171, 23)
        ComboPaises.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(253, 251)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "Registrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RegistrarPersona
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(ComboPaises)
        Controls.Add(TxtCorreo)
        Controls.Add(TxtNombre)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "RegistrarPersona"
        Text = "RegistrarPersona"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents ComboPaises As ComboBox
    Friend WithEvents Button1 As Button
End Class
