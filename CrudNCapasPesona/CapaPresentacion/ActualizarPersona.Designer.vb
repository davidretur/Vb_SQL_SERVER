<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarPersona
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
        TxtIdActualizar = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ComboPaises = New ComboBox()
        TxtNombre = New TextBox()
        TxtCorreo = New TextBox()
        BtnActualizar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(77, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 17)
        Label1.TabIndex = 0
        Label1.Text = "Id Actualizar"
        ' 
        ' TxtIdActualizar
        ' 
        TxtIdActualizar.Location = New Point(199, 53)
        TxtIdActualizar.Name = "TxtIdActualizar"
        TxtIdActualizar.Size = New Size(167, 23)
        TxtIdActualizar.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(77, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 17)
        Label2.TabIndex = 2
        Label2.Text = "Nuevo Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(77, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 17)
        Label3.TabIndex = 3
        Label3.Text = "Nuevo Pais"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(77, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 17)
        Label4.TabIndex = 4
        Label4.Text = "Nuevo Correo"
        ' 
        ' ComboPaises
        ' 
        ComboPaises.FormattingEnabled = True
        ComboPaises.Location = New Point(199, 156)
        ComboPaises.Name = "ComboPaises"
        ComboPaises.Size = New Size(167, 23)
        ComboPaises.TabIndex = 5
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(199, 106)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(167, 23)
        TxtNombre.TabIndex = 6
        ' 
        ' TxtCorreo
        ' 
        TxtCorreo.Location = New Point(199, 204)
        TxtCorreo.Name = "TxtCorreo"
        TxtCorreo.Size = New Size(266, 23)
        TxtCorreo.TabIndex = 7
        ' 
        ' BtnActualizar
        ' 
        BtnActualizar.Location = New Point(199, 273)
        BtnActualizar.Name = "BtnActualizar"
        BtnActualizar.Size = New Size(75, 23)
        BtnActualizar.TabIndex = 8
        BtnActualizar.Text = "Actualizar"
        BtnActualizar.UseVisualStyleBackColor = True
        ' 
        ' ActualizarPersona
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnActualizar)
        Controls.Add(TxtCorreo)
        Controls.Add(TxtNombre)
        Controls.Add(ComboPaises)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtIdActualizar)
        Controls.Add(Label1)
        Name = "ActualizarPersona"
        Text = "ActualizarPersona"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdActualizar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboPaises As ComboBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents BtnActualizar As Button
End Class
