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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.TextBoxTITLE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxAUTHOR = New System.Windows.Forms.TextBox()
        Me.TextBoxCODE = New System.Windows.Forms.TextBox()
        Me.TextBoxAMOUNT = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(252, 190)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(447, 223)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(292, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Library"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Location = New System.Drawing.Point(475, 82)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNGUARDAR.TabIndex = 2
        Me.BTNGUARDAR.Text = "SAVE"
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'TextBoxTITLE
        '
        Me.TextBoxTITLE.Location = New System.Drawing.Point(114, 47)
        Me.TextBoxTITLE.Name = "TextBoxTITLE"
        Me.TextBoxTITLE.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTITLE.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(47, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "TITLE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(39, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "AUTHOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(39, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "GENDER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(36, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "AMOUNT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(273, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "CODE"
        '
        'TextBoxAUTHOR
        '
        Me.TextBoxAUTHOR.Location = New System.Drawing.Point(114, 92)
        Me.TextBoxAUTHOR.Name = "TextBoxAUTHOR"
        Me.TextBoxAUTHOR.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAUTHOR.TabIndex = 9
        '
        'TextBoxCODE
        '
        Me.TextBoxCODE.Location = New System.Drawing.Point(329, 76)
        Me.TextBoxCODE.Name = "TextBoxCODE"
        Me.TextBoxCODE.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCODE.TabIndex = 10
        '
        'TextBoxAMOUNT
        '
        Me.TextBoxAMOUNT.Location = New System.Drawing.Point(114, 182)
        Me.TextBoxAMOUNT.Name = "TextBoxAMOUNT"
        Me.TextBoxAMOUNT.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAMOUNT.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(114, 133)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(119, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBoxAMOUNT)
        Me.Controls.Add(Me.TextBoxCODE)
        Me.Controls.Add(Me.TextBoxAUTHOR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxTITLE)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents TextBoxTITLE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxAUTHOR As TextBox
    Friend WithEvents TextBoxCODE As TextBox
    Friend WithEvents TextBoxAMOUNT As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
