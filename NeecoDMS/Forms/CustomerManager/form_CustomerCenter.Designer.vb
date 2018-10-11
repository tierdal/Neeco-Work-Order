<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_CustomerCenter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_CustomerCenter))
        Me.button_NewCPO = New System.Windows.Forms.Button()
        Me.button_NewQuote = New System.Windows.Forms.Button()
        Me.button_NewCustomer = New System.Windows.Forms.Button()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_NewCPO
        '
        Me.button_NewCPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_NewCPO.Location = New System.Drawing.Point(12, 152)
        Me.button_NewCPO.Name = "button_NewCPO"
        Me.button_NewCPO.Size = New System.Drawing.Size(360, 64)
        Me.button_NewCPO.TabIndex = 2
        Me.button_NewCPO.Text = "NEW PO FOLDER"
        Me.button_NewCPO.UseVisualStyleBackColor = True
        '
        'button_NewQuote
        '
        Me.button_NewQuote.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_NewQuote.Location = New System.Drawing.Point(12, 82)
        Me.button_NewQuote.Name = "button_NewQuote"
        Me.button_NewQuote.Size = New System.Drawing.Size(360, 64)
        Me.button_NewQuote.TabIndex = 1
        Me.button_NewQuote.Text = "NEW QUOTE FOLDER"
        Me.button_NewQuote.UseVisualStyleBackColor = True
        '
        'button_NewCustomer
        '
        Me.button_NewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_NewCustomer.Location = New System.Drawing.Point(12, 12)
        Me.button_NewCustomer.Name = "button_NewCustomer"
        Me.button_NewCustomer.Size = New System.Drawing.Size(360, 64)
        Me.button_NewCustomer.TabIndex = 0
        Me.button_NewCustomer.Text = "NEW CUSTOMER FOLDER"
        Me.button_NewCustomer.UseVisualStyleBackColor = True
        '
        'button_Exit
        '
        Me.button_Exit.Location = New System.Drawing.Point(12, 259)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(360, 40)
        Me.button_Exit.TabIndex = 3
        Me.button_Exit.Text = "EXIT"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'form_CustomerCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.button_Exit)
        Me.Controls.Add(Me.button_NewCPO)
        Me.Controls.Add(Me.button_NewQuote)
        Me.Controls.Add(Me.button_NewCustomer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_CustomerCenter"
        Me.Text = "NeecoDMS - Customer Center"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_NewCPO As Button
    Friend WithEvents button_NewQuote As Button
    Friend WithEvents button_NewCustomer As Button
    Friend WithEvents button_Exit As Button
End Class
