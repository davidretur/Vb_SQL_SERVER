<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarPersona
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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        LblId = New Label()
        LblNombre = New Label()
        LblPais = New Label()
        LblCorreo = New Label()
        BtnEliminar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(86, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 21)
        Label1.TabIndex = 0
        Label1.Text = "Datos de persona a eliminar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(89, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 1
        Label2.Text = "Id Persona"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(89, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 17)
        Label3.TabIndex = 2
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(89, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 3
        Label4.Text = "Pais"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(87, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 20)
        Label5.TabIndex = 4
        Label5.Text = "Correo"
        ' 
        ' LblId
        ' 
        LblId.AutoSize = True
        LblId.BorderStyle = BorderStyle.FixedSingle
        LblId.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblId.Location = New Point(229, 91)
        LblId.Name = "LblId"
        LblId.Size = New Size(2, 19)
        LblId.TabIndex = 5
        ' 
        ' LblNombre
        ' 
        LblNombre.AutoSize = True
        LblNombre.BorderStyle = BorderStyle.FixedSingle
        LblNombre.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblNombre.Location = New Point(229, 125)
        LblNombre.Name = "LblNombre"
        LblNombre.Size = New Size(2, 19)
        LblNombre.TabIndex = 6
        ' 
        ' LblPais
        ' 
        LblPais.AutoSize = True
        LblPais.BorderStyle = BorderStyle.FixedSingle
        LblPais.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblPais.Location = New Point(229, 162)
        LblPais.Name = "LblPais"
        LblPais.Size = New Size(2, 19)
        LblPais.TabIndex = 7
        ' 
        ' LblCorreo
        ' 
        LblCorreo.AutoSize = True
        LblCorreo.BorderStyle = BorderStyle.FixedSingle
        LblCorreo.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblCorreo.Location = New Point(229, 202)
        LblCorreo.Name = "LblCorreo"
        LblCorreo.Size = New Size(2, 19)
        LblCorreo.TabIndex = 8
        ' 
        ' BtnEliminar
        ' 
        BtnEliminar.Location = New Point(134, 265)
        BtnEliminar.Name = "BtnEliminar"
        BtnEliminar.Size = New Size(75, 23)
        BtnEliminar.TabIndex = 9
        BtnEliminar.Text = "Eliminar"
        BtnEliminar.UseVisualStyleBackColor = True
        ' 
        ' EliminarPersona
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnEliminar)
        Controls.Add(LblCorreo)
        Controls.Add(LblPais)
        Controls.Add(LblNombre)
        Controls.Add(LblId)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "EliminarPersona"
        Text = "EliminarPersona"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblId As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblPais As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents BtnEliminar As Button
End Class
