<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_VendorCenter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_VendorCenter))
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.button_NewVPO = New System.Windows.Forms.Button()
        Me.button_NewVendor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_Exit
        '
        Me.button_Exit.Location = New System.Drawing.Point(12, 259)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(360, 40)
        Me.button_Exit.TabIndex = 11
        Me.button_Exit.Text = "EXIT"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'button_NewVPO
        '
        Me.button_NewVPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_NewVPO.Location = New System.Drawing.Point(12, 82)
        Me.button_NewVPO.Name = "button_NewVPO"
        Me.button_NewVPO.Size = New System.Drawing.Size(360, 64)
        Me.button_NewVPO.TabIndex = 10
        Me.button_NewVPO.Text = "NEW PO FOLDER"
        Me.button_NewVPO.UseVisualStyleBackColor = True
        '
        'button_NewVendor
        '
        Me.button_NewVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_NewVendor.Location = New System.Drawing.Point(12, 12)
        Me.button_NewVendor.Name = "button_NewVendor"
        Me.button_NewVendor.Size = New System.Drawing.Size(360, 64)
        Me.button_NewVendor.TabIndex = 8
        Me.button_NewVendor.Text = "NEW VENDOR FOLDER"
        Me.button_NewVendor.UseVisualStyleBackColor = True
        '
        'form_VendorCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.button_Exit)
        Me.Controls.Add(Me.button_NewVPO)
        Me.Controls.Add(Me.button_NewVendor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_VendorCenter"
        Me.Text = "NeecoDMS - Vendor Center"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_Exit As Button
    Friend WithEvents button_NewVPO As Button
    Friend WithEvents button_NewVendor As Button
End Class
