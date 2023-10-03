<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LblBienvenida = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnSalir.Location = New System.Drawing.Point(60, 160)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(160, 70)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'LblBienvenida
        '
        Me.LblBienvenida.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBienvenida.ForeColor = System.Drawing.Color.White
        Me.LblBienvenida.Location = New System.Drawing.Point(12, 35)
        Me.LblBienvenida.Name = "LblBienvenida"
        Me.LblBienvenida.Size = New System.Drawing.Size(258, 60)
        Me.LblBienvenida.TabIndex = 1
        Me.LblBienvenida.Text = "Label1"
        Me.LblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFecha
        '
        Me.LblFecha.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.White
        Me.LblFecha.Location = New System.Drawing.Point(12, 95)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(258, 33)
        Me.LblFecha.TabIndex = 2
        Me.LblFecha.Text = "Label1"
        Me.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblBienvenida)
        Me.Controls.Add(Me.BtnSalir)
        Me.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents LblBienvenida As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
End Class
