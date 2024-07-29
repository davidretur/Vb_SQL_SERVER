<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListadoPersonas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        lblTotal = New Label()
        DataGridView1 = New DataGridView()
        BtnAgregar = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(295, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 21)
        Label1.TabIndex = 0
        Label1.Text = "Listado de Personas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(359, 371)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 20)
        Label2.TabIndex = 1
        Label2.Text = "Cantidad de Registros"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BorderStyle = BorderStyle.FixedSingle
        lblTotal.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.Location = New Point(577, 371)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(2, 22)
        lblTotal.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(46, 114)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(708, 199)
        DataGridView1.TabIndex = 3
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.Location = New Point(153, 368)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(75, 23)
        BtnAgregar.TabIndex = 4
        BtnAgregar.Text = "Registrar"
        BtnAgregar.UseVisualStyleBackColor = True
        ' 
        ' ListadoPersonas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnAgregar)
        Controls.Add(DataGridView1)
        Controls.Add(lblTotal)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ListadoPersonas"
        Text = "Listado de Personas"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAgregar As Button

End Class
