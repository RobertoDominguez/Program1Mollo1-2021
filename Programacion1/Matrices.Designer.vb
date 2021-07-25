<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matrices
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.Practico1MatricesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(841, 410)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "respuesta"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(181, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Dimensionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(181, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(758, 281)
        Me.DataGridView1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 28)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1305, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(296, 413)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "filas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(445, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "columnas"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(445, 410)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1003, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 25)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "CargarDesdeGrilla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1003, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 25)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "CargarRandom"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Practico1MatricesToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1305, 28)
        Me.MenuStrip2.TabIndex = 11
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'Practico1MatricesToolStripMenuItem
        '
        Me.Practico1MatricesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejercicio1ToolStripMenuItem, Me.Ejercicio2ToolStripMenuItem, Me.Ejercicio3ToolStripMenuItem, Me.Ejercicio4ToolStripMenuItem, Me.Ejercicio5ToolStripMenuItem, Me.Ejercicio6ToolStripMenuItem, Me.Ejercicio7ToolStripMenuItem, Me.Ejercicio8ToolStripMenuItem, Me.Ejercicio9ToolStripMenuItem, Me.Ejercicio10ToolStripMenuItem, Me.Ejercicio11ToolStripMenuItem})
        Me.Practico1MatricesToolStripMenuItem.Name = "Practico1MatricesToolStripMenuItem"
        Me.Practico1MatricesToolStripMenuItem.Size = New System.Drawing.Size(140, 24)
        Me.Practico1MatricesToolStripMenuItem.Text = "Practico1Matrices"
        '
        'Ejercicio1ToolStripMenuItem
        '
        Me.Ejercicio1ToolStripMenuItem.Name = "Ejercicio1ToolStripMenuItem"
        Me.Ejercicio1ToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.Ejercicio1ToolStripMenuItem.Text = "Ejercicio1"
        '
        'Ejercicio2ToolStripMenuItem
        '
        Me.Ejercicio2ToolStripMenuItem.Name = "Ejercicio2ToolStripMenuItem"
        Me.Ejercicio2ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Ejercicio2ToolStripMenuItem.Text = "Ejercicio2"
        '
        'Ejercicio3ToolStripMenuItem
        '
        Me.Ejercicio3ToolStripMenuItem.Name = "Ejercicio3ToolStripMenuItem"
        Me.Ejercicio3ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Ejercicio3ToolStripMenuItem.Text = "Ejercicio3"
        '
        'Ejercicio4ToolStripMenuItem
        '
        Me.Ejercicio4ToolStripMenuItem.Name = "Ejercicio4ToolStripMenuItem"
        Me.Ejercicio4ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Ejercicio4ToolStripMenuItem.Text = "Ejercicio4"
        '
        'Ejercicio5ToolStripMenuItem
        '
        Me.Ejercicio5ToolStripMenuItem.Name = "Ejercicio5ToolStripMenuItem"
        Me.Ejercicio5ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Ejercicio5ToolStripMenuItem.Text = "Ejercicio5"
        '
        'Ejercicio6ToolStripMenuItem
        '
        Me.Ejercicio6ToolStripMenuItem.Name = "Ejercicio6ToolStripMenuItem"
        Me.Ejercicio6ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Ejercicio6ToolStripMenuItem.Text = "Ejercicio6"
        '
        'Ejercicio7ToolStripMenuItem
        '
        Me.Ejercicio7ToolStripMenuItem.Name = "Ejercicio7ToolStripMenuItem"
        Me.Ejercicio7ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Ejercicio7ToolStripMenuItem.Text = "Ejercicio7"
        '
        'Ejercicio8ToolStripMenuItem
        '
        Me.Ejercicio8ToolStripMenuItem.Name = "Ejercicio8ToolStripMenuItem"
        Me.Ejercicio8ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Ejercicio8ToolStripMenuItem.Text = "Ejercicio8"
        '
        'Ejercicio9ToolStripMenuItem
        '
        Me.Ejercicio9ToolStripMenuItem.Name = "Ejercicio9ToolStripMenuItem"
        Me.Ejercicio9ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Ejercicio9ToolStripMenuItem.Text = "Ejercicio9"
        '
        'Ejercicio10ToolStripMenuItem
        '
        Me.Ejercicio10ToolStripMenuItem.Name = "Ejercicio10ToolStripMenuItem"
        Me.Ejercicio10ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Ejercicio10ToolStripMenuItem.Text = "Ejercicio10"
        '
        'Ejercicio11ToolStripMenuItem
        '
        Me.Ejercicio11ToolStripMenuItem.Name = "Ejercicio11ToolStripMenuItem"
        Me.Ejercicio11ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Ejercicio11ToolStripMenuItem.Text = "Ejercicio11"
        '
        'Matrices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 576)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Matrices"
        Me.Text = "Matrices"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents Practico1MatricesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio7ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio9ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio11ToolStripMenuItem As ToolStripMenuItem
End Class
