<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedor))
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.txtTelfono = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtRazon = New System.Windows.Forms.TextBox()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId_proveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvProv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnListar
        '
        Me.btnListar.Image = CType(resources.GetObject("btnListar.Image"), System.Drawing.Image)
        Me.btnListar.Location = New System.Drawing.Point(256, 341)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(67, 63)
        Me.btnListar.TabIndex = 24
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.AutoSize = True
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(96, 341)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(64, 63)
        Me.btnEditar.TabIndex = 23
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 18)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Contacto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Ciudad:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(96, 290)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(227, 20)
        Me.txtEmail.TabIndex = 18
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(96, 256)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(227, 20)
        Me.txtContacto.TabIndex = 17
        '
        'txtTelfono
        '
        Me.txtTelfono.Location = New System.Drawing.Point(96, 223)
        Me.txtTelfono.Name = "txtTelfono"
        Me.txtTelfono.Size = New System.Drawing.Size(227, 20)
        Me.txtTelfono.TabIndex = 16
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(96, 192)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(227, 20)
        Me.txtCiudad.TabIndex = 15
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(96, 161)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(227, 20)
        Me.txtDireccion.TabIndex = 14
        '
        'txtRazon
        '
        Me.txtRazon.Location = New System.Drawing.Point(96, 130)
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(227, 20)
        Me.txtRazon.TabIndex = 13
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(96, 97)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(227, 20)
        Me.txtNit.TabIndex = 12
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(176, 341)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(67, 63)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackgroundImage = CType(resources.GetObject("btnRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegistrar.Location = New System.Drawing.Point(19, 341)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(64, 63)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(96, 63)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(227, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtId_proveedor
        '
        Me.txtId_proveedor.Location = New System.Drawing.Point(96, 32)
        Me.txtId_proveedor.Name = "txtId_proveedor"
        Me.txtId_proveedor.ReadOnly = True
        Me.txtId_proveedor.Size = New System.Drawing.Size(227, 20)
        Me.txtId_proveedor.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Razon Social:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NIT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(841, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(839, 548)
        Me.SplitContainer1.SplitterDistance = 107
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel2.Controls.Add(Me.dgvProv)
        Me.Panel2.Location = New System.Drawing.Point(364, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(471, 428)
        Me.Panel2.TabIndex = 5
        '
        'dgvProv
        '
        Me.dgvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProv.Location = New System.Drawing.Point(13, 15)
        Me.dgvProv.Name = "dgvProv"
        Me.dgvProv.Size = New System.Drawing.Size(442, 391)
        Me.dgvProv.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.btnListar)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtContacto)
        Me.Panel1.Controls.Add(Me.txtTelfono)
        Me.Panel1.Controls.Add(Me.txtCiudad)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.txtRazon)
        Me.Panel1.Controls.Add(Me.txtNit)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnRegistrar)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.txtId_proveedor)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 426)
        Me.Panel1.TabIndex = 4
        '
        'Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 548)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnListar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents txtTelfono As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtRazon As TextBox
    Friend WithEvents txtNit As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId_proveedor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvProv As DataGridView
    Friend WithEvents Panel1 As Panel
End Class
