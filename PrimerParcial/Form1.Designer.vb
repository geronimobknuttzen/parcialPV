<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnIniciar
        '
        Me.BtnIniciar.BackColor = System.Drawing.Color.Indigo
        Me.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIniciar.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnIniciar.Location = New System.Drawing.Point(65, 160)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(160, 70)
        Me.BtnIniciar.TabIndex = 0
        Me.BtnIniciar.Text = "Iniciar Sesión"
        Me.BtnIniciar.UseVisualStyleBackColor = False
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BackColor = System.Drawing.Color.GhostWhite
        Me.TxtUsuario.ForeColor = System.Drawing.Color.Black
        Me.TxtUsuario.Location = New System.Drawing.Point(40, 52)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(206, 27)
        Me.TxtUsuario.TabIndex = 1
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.GhostWhite
        Me.TxtPassword.ForeColor = System.Drawing.Color.Black
        Me.TxtPassword.Location = New System.Drawing.Point(40, 111)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(206, 27)
        Me.TxtPassword.TabIndex = 2
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LblUsuario.Location = New System.Drawing.Point(40, 29)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(81, 20)
        Me.LblUsuario.TabIndex = 3
        Me.LblUsuario.Text = "Usuario:"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LblPassword.Location = New System.Drawing.Point(40, 88)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(108, 20)
        Me.LblPassword.TabIndex = 4
        Me.LblPassword.Text = "Contraseña:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "¡Bienvenido!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnIniciar As System.Windows.Forms.Button
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label

End Class
