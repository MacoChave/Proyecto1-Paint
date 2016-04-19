<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaPestañaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarPestañaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Pestaña0 = New System.Windows.Forms.TabPage()
        Me.RchTxtCaja0 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGenerarArchivos = New System.Windows.Forms.Button()
        Me.btnAnalizar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxDebugger = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ListadoDeTokenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.Pestaña0.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaPestañaToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.ToolStripSeparator1, Me.GuardarToolStripMenuItem, Me.ToolStripSeparator2, Me.CerrarPestañaToolStripMenuItem, Me.CerrarTodoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.InicioToolStripMenuItem.Text = "Archivo"
        '
        'NuevaPestañaToolStripMenuItem
        '
        Me.NuevaPestañaToolStripMenuItem.Name = "NuevaPestañaToolStripMenuItem"
        Me.NuevaPestañaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevaPestañaToolStripMenuItem.Text = "Nueva Pestaña"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'CerrarPestañaToolStripMenuItem
        '
        Me.CerrarPestañaToolStripMenuItem.Name = "CerrarPestañaToolStripMenuItem"
        Me.CerrarPestañaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarPestañaToolStripMenuItem.Text = "Cerrar Pestaña"
        '
        'CerrarTodoToolStripMenuItem
        '
        Me.CerrarTodoToolStripMenuItem.Name = "CerrarTodoToolStripMenuItem"
        Me.CerrarTodoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CerrarTodoToolStripMenuItem.Text = "Cerrar Todo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsuarioToolStripMenuItem, Me.ListadoDeTokenToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca De"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Pestaña0)
        Me.TabControl.Location = New System.Drawing.Point(20, 40)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Padding = New System.Drawing.Point(10, 5)
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(400, 400)
        Me.TabControl.TabIndex = 1
        '
        'Pestaña0
        '
        Me.Pestaña0.Controls.Add(Me.RchTxtCaja0)
        Me.Pestaña0.Location = New System.Drawing.Point(4, 26)
        Me.Pestaña0.Name = "Pestaña0"
        Me.Pestaña0.Size = New System.Drawing.Size(392, 370)
        Me.Pestaña0.TabIndex = 0
        Me.Pestaña0.Text = "Pestaña 0"
        Me.Pestaña0.UseVisualStyleBackColor = True
        '
        'RchTxtCaja0
        '
        Me.RchTxtCaja0.ForeColor = System.Drawing.Color.Teal
        Me.RchTxtCaja0.Location = New System.Drawing.Point(4, 4)
        Me.RchTxtCaja0.Name = "RchTxtCaja0"
        Me.RchTxtCaja0.Size = New System.Drawing.Size(386, 364)
        Me.RchTxtCaja0.TabIndex = 0
        Me.RchTxtCaja0.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGenerarArchivos)
        Me.GroupBox1.Controls.Add(Me.btnAnalizar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnAbrir)
        Me.GroupBox1.Location = New System.Drawing.Point(454, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Funciones"
        '
        'btnGenerarArchivos
        '
        Me.btnGenerarArchivos.Location = New System.Drawing.Point(119, 69)
        Me.btnGenerarArchivos.Name = "btnGenerarArchivos"
        Me.btnGenerarArchivos.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerarArchivos.TabIndex = 3
        Me.btnGenerarArchivos.Text = "Generar"
        Me.btnGenerarArchivos.UseVisualStyleBackColor = True
        '
        'btnAnalizar
        '
        Me.btnAnalizar.Location = New System.Drawing.Point(7, 69)
        Me.btnAnalizar.Name = "btnAnalizar"
        Me.btnAnalizar.Size = New System.Drawing.Size(75, 23)
        Me.btnAnalizar.TabIndex = 2
        Me.btnAnalizar.Text = "Analizar"
        Me.btnAnalizar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(119, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        Me.btnAbrir.Location = New System.Drawing.Point(7, 20)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrir.TabIndex = 0
        Me.btnAbrir.Text = "Abrir"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtBoxDebugger)
        Me.GroupBox2.Location = New System.Drawing.Point(461, 298)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 142)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Debbuger"
        '
        'TxtBoxDebugger
        '
        Me.TxtBoxDebugger.Location = New System.Drawing.Point(7, 20)
        Me.TxtBoxDebugger.Multiline = True
        Me.TxtBoxDebugger.Name = "TxtBoxDebugger"
        Me.TxtBoxDebugger.Size = New System.Drawing.Size(198, 116)
        Me.TxtBoxDebugger.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox)
        Me.GroupBox3.Location = New System.Drawing.Point(461, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 146)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vista Previa"
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(7, 20)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(198, 120)
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ListadoDeTokenToolStripMenuItem
        '
        Me.ListadoDeTokenToolStripMenuItem.Name = "ListadoDeTokenToolStripMenuItem"
        Me.ListadoDeTokenToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ListadoDeTokenToolStripMenuItem.Text = "Listado de Token"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paint"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.Pestaña0.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaPestañaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CerrarPestañaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarTodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerarArchivos As System.Windows.Forms.Button
    Friend WithEvents btnAnalizar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnAbrir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Pestaña0 As System.Windows.Forms.TabPage
    Friend WithEvents RchTxtCaja0 As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtBoxDebugger As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ListadoDeTokenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
