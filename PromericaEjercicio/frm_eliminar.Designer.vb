<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_eliminar
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
        btn_cancelar = New Button()
        btn_eliminar = New Button()
        ck_estado = New CheckBox()
        cb_unidadm = New ComboBox()
        cb_tipo = New ComboBox()
        txt_nombre = New TextBox()
        txt_codigo = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_cancelar.Location = New Point(333, 321)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(118, 48)
        btn_cancelar.TabIndex = 28
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btn_eliminar.Location = New Point(209, 321)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(118, 48)
        btn_eliminar.TabIndex = 27
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' ck_estado
        ' 
        ck_estado.AutoSize = True
        ck_estado.Location = New Point(236, 296)
        ck_estado.Name = "ck_estado"
        ck_estado.Size = New Size(18, 17)
        ck_estado.TabIndex = 26
        ck_estado.UseVisualStyleBackColor = True
        ' 
        ' cb_unidadm
        ' 
        cb_unidadm.FormattingEnabled = True
        cb_unidadm.Location = New Point(236, 254)
        cb_unidadm.Name = "cb_unidadm"
        cb_unidadm.Size = New Size(244, 28)
        cb_unidadm.TabIndex = 25
        ' 
        ' cb_tipo
        ' 
        cb_tipo.FormattingEnabled = True
        cb_tipo.Location = New Point(238, 203)
        cb_tipo.Name = "cb_tipo"
        cb_tipo.Size = New Size(242, 28)
        cb_tipo.TabIndex = 24
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(236, 155)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(301, 27)
        txt_nombre.TabIndex = 23
        ' 
        ' txt_codigo
        ' 
        txt_codigo.Location = New Point(236, 105)
        txt_codigo.Name = "txt_codigo"
        txt_codigo.Size = New Size(297, 27)
        txt_codigo.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(99, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 28)
        Label5.TabIndex = 21
        Label5.Text = "Estado"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(53, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(175, 28)
        Label4.TabIndex = 20
        Label4.Text = "Unidad de Medida"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(99, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 28)
        Label3.TabIndex = 19
        Label3.Text = "Tipo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(99, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 28)
        Label2.TabIndex = 18
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(99, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 28)
        Label1.TabIndex = 17
        Label1.Text = "Codigo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(172, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(396, 46)
        Label6.TabIndex = 29
        Label6.Text = "ELIMINAR PRODUCTOS"
        ' 
        ' frm_eliminar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(btn_cancelar)
        Controls.Add(btn_eliminar)
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
        Name = "frm_eliminar"
        Text = "frm_eliminar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents ck_estado As CheckBox
    Friend WithEvents cb_unidadm As ComboBox
    Friend WithEvents cb_tipo As ComboBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
End Class
