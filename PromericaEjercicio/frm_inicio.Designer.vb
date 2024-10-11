<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inicio
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
        btn_agregar = New Button()
        btn_editar = New Button()
        btn_eliminar = New Button()
        DataGridView1 = New DataGridView()
        btn_renovar = New Button()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_agregar
        ' 
        btn_agregar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btn_agregar.Location = New Point(375, 12)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(106, 53)
        btn_agregar.TabIndex = 0
        btn_agregar.Text = "Agregar"
        btn_agregar.UseVisualStyleBackColor = True
        ' 
        ' btn_editar
        ' 
        btn_editar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btn_editar.Location = New Point(487, 13)
        btn_editar.Name = "btn_editar"
        btn_editar.Size = New Size(106, 53)
        btn_editar.TabIndex = 1
        btn_editar.Text = "Editar"
        btn_editar.UseVisualStyleBackColor = True
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btn_eliminar.Location = New Point(599, 13)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(106, 53)
        btn_eliminar.TabIndex = 2
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 88)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(963, 328)
        DataGridView1.TabIndex = 3
        ' 
        ' btn_renovar
        ' 
        btn_renovar.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        btn_renovar.Location = New Point(711, 13)
        btn_renovar.Name = "btn_renovar"
        btn_renovar.Size = New Size(106, 53)
        btn_renovar.TabIndex = 4
        btn_renovar.Text = "Renovar"
        btn_renovar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(125, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 46)
        Label1.TabIndex = 5
        Label1.Text = "PRODUCTOS"
        ' 
        ' frm_inicio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1010, 450)
        Controls.Add(Label1)
        Controls.Add(btn_renovar)
        Controls.Add(DataGridView1)
        Controls.Add(btn_eliminar)
        Controls.Add(btn_editar)
        Controls.Add(btn_agregar)
        Name = "frm_inicio"
        Text = "Inicio"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_renovar As Button
    Friend WithEvents Label1 As Label
End Class
