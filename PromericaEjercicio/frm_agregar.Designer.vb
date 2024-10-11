<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_agregar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txt_codigo = New TextBox()
        txt_nombre = New TextBox()
        cb_tipo = New ComboBox()
        cb_unidadm = New ComboBox()
        ck_estado = New CheckBox()
        btn_agregar = New Button()
        btn_cancelar = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(79, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 28)
        Label1.TabIndex = 0
        Label1.Text = "Codigo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(79, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 28)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(79, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 28)
        Label3.TabIndex = 2
        Label3.Text = "Tipo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(33, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(175, 28)
        Label4.TabIndex = 3
        Label4.Text = "Unidad de Medida"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(79, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 28)
        Label5.TabIndex = 4
        Label5.Text = "Estado"
        ' 
        ' txt_codigo
        ' 
        txt_codigo.Location = New Point(227, 106)
        txt_codigo.Name = "txt_codigo"
        txt_codigo.Size = New Size(297, 27)
        txt_codigo.TabIndex = 5
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(227, 155)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(301, 27)
        txt_nombre.TabIndex = 6
        ' 
        ' cb_tipo
        ' 
        cb_tipo.FormattingEnabled = True
        cb_tipo.Location = New Point(227, 204)
        cb_tipo.Name = "cb_tipo"
        cb_tipo.Size = New Size(242, 28)
        cb_tipo.TabIndex = 7
        ' 
        ' cb_unidadm
        ' 
        cb_unidadm.FormattingEnabled = True
        cb_unidadm.Location = New Point(227, 256)
        cb_unidadm.Name = "cb_unidadm"
        cb_unidadm.Size = New Size(244, 28)
        cb_unidadm.TabIndex = 8
        ' 
        ' ck_estado
        ' 
        ck_estado.AutoSize = True
        ck_estado.Location = New Point(227, 301)
        ck_estado.Name = "ck_estado"
        ck_estado.Size = New Size(18, 17)
        ck_estado.TabIndex = 9
        ck_estado.UseVisualStyleBackColor = True
        ' 
        ' btn_agregar
        ' 
        btn_agregar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_agregar.Location = New Point(165, 347)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(127, 50)
        btn_agregar.TabIndex = 10
        btn_agregar.Text = "Agregar"
        btn_agregar.UseVisualStyleBackColor = True
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_cancelar.Location = New Point(321, 348)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(148, 49)
        btn_cancelar.TabIndex = 11
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(165, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(391, 46)
        Label6.TabIndex = 12
        Label6.Text = "AGREGAR PRODUCTOS"
        ' 
        ' frm_agregar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(690, 450)
        Controls.Add(Label6)
        Controls.Add(btn_cancelar)
        Controls.Add(btn_agregar)
        Controls.Add(ck_estado)
        Controls.Add(cb_unidadm)
        Controls.Add(cb_tipo)
        Controls.Add(txt_nombre)
        Controls.Add(txt_codigo)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frm_agregar"
        Text = "frm_agregar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents cb_tipo As ComboBox
    Friend WithEvents cb_unidadm As ComboBox
    Friend WithEvents ck_estado As CheckBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents Label6 As Label
End Class
