<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewWeb
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
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'BtnAtras
        '
        Me.BtnAtras.BackgroundImage = Global.Proyecto1.My.Resources.Resources.left
        Me.BtnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAtras.Location = New System.Drawing.Point(13, 13)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(32, 32)
        Me.BtnAtras.TabIndex = 0
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(13, 52)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(559, 597)
        Me.WebBrowser1.TabIndex = 1
        '
        'ViewWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 661)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.BtnAtras)
        Me.Name = "ViewWeb"
        Me.Text = "ViewWeb"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAtras As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
