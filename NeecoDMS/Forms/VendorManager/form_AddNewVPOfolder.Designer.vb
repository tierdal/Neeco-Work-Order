<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_AddNewVPOfolder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_AddNewVPOfolder))
        Me.button_Cancel = New System.Windows.Forms.Button()
        Me.button_Submit = New System.Windows.Forms.Button()
        Me.text_POnumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_VendorName = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'button_Cancel
        '
        Me.button_Cancel.Location = New System.Drawing.Point(528, 89)
        Me.button_Cancel.Name = "button_Cancel"
        Me.button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.button_Cancel.TabIndex = 3
        Me.button_Cancel.Text = "CANCEL"
        Me.button_Cancel.UseVisualStyleBackColor = True
        '
        'button_Submit
        '
        Me.button_Submit.Location = New System.Drawing.Point(447, 89)
        Me.button_Submit.Name = "button_Submit"
        Me.button_Submit.Size = New System.Drawing.Size(75, 23)
        Me.button_Submit.TabIndex = 2
        Me.button_Submit.Text = "SUBMIT"
        Me.button_Submit.UseVisualStyleBackColor = True
        '
        'text_POnumber
        '
        Me.text_POnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_POnumber.Location = New System.Drawing.Point(192, 52)
        Me.text_POnumber.Name = "text_POnumber"
        Me.text_POnumber.Size = New System.Drawing.Size(411, 31)
        Me.text_POnumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "NEECO PO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "VENDOR NAME:"
        '
        'combo_VendorName
        '
        Me.combo_VendorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.combo_VendorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combo_VendorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_VendorName.FormattingEnabled = True
        Me.combo_VendorName.Location = New System.Drawing.Point(192, 6)
        Me.combo_VendorName.Name = "combo_VendorName"
        Me.combo_VendorName.Size = New System.Drawing.Size(411, 33)
        Me.combo_VendorName.TabIndex = 0
        '
        'form_AddNewVPOfolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 117)
        Me.Controls.Add(Me.button_Cancel)
        Me.Controls.Add(Me.button_Submit)
        Me.Controls.Add(Me.text_POnumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.combo_VendorName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(631, 156)
        Me.MinimumSize = New System.Drawing.Size(631, 156)
        Me.Name = "form_AddNewVPOfolder"
        Me.Text = "NeecoDMS - Add New Vendor PO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button_Cancel As Button
    Friend WithEvents button_Submit As Button
    Friend WithEvents text_POnumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_VendorName As ComboBox
End Class
