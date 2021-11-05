<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(299, 28)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(475, 394)
        Me.ListBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(281, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Pedir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Pizza de Mussarela", "Pizza de Pepperone", "Pizza de Calabresa", "Pizza de Portuguesa", "Pizza de Alho"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 28)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(281, 79)
        Me.CheckedListBox1.TabIndex = 4
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.CheckOnClick = True
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"Dolly 1 Litro", "Guarana 1 Litro", "Suco de laranja 1 Litro", "Pepsi 1 Litro", "Itubaina 1 Litro"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(12, 136)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(281, 79)
        Me.CheckedListBox2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sabores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Bebidas"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(281, 26)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Listar pedidos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Pizzaria "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class