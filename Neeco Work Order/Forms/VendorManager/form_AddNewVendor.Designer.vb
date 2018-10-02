<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_AddNewVendor
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_AddNewVendor))
        Me.text_VendorName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.button_Cancel = New System.Windows.Forms.Button()
        Me.button_Submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'text_VendorName
        '
        Me.text_VendorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_VendorName.Location = New System.Drawing.Point(192, 6)
        Me.text_VendorName.Name = "text_VendorName"
        Me.text_VendorName.Size = New System.Drawing.Size(411, 31)
        Me.text_VendorName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "VENDOR NAME:"
        '
        'button_Cancel
        '
        Me.button_Cancel.Location = New System.Drawing.Point(528, 43)
        Me.button_Cancel.Name = "button_Cancel"
        Me.button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.button_Cancel.TabIndex = 5
        Me.button_Cancel.Text = "CANCEL"
        Me.button_Cancel.UseVisualStyleBackColor = True
        '
        'button_Submit
        '
        Me.button_Submit.Location = New System.Drawing.Point(447, 43)
        Me.button_Submit.Name = "button_Submit"
        Me.button_Submit.Size = New System.Drawing.Size(75, 23)
        Me.button_Submit.TabIndex = 4
        Me.button_Submit.Text = "SUBMIT"
        Me.button_Submit.UseVisualStyleBackColor = True
        '
        'form_AddNewVendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 74)
        Me.Controls.Add(Me.text_VendorName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.button_Cancel)
        Me.Controls.Add(Me.button_Submit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(631, 113)
        Me.MinimumSize = New System.Drawing.Size(631, 113)
        Me.Name = "form_AddNewVendor"
        Me.Text = "NeecoDMS - Add New Vendor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents text_VendorName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents button_Cancel As Button
    Friend WithEvents button_Submit As Button
End Class
