<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_AddNewCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_AddNewCustomer))
        Me.button_Submit = New System.Windows.Forms.Button()
        Me.button_Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text_CustomerName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'button_Submit
        '
        Me.button_Submit.Location = New System.Drawing.Point(447, 43)
        Me.button_Submit.Name = "button_Submit"
        Me.button_Submit.Size = New System.Drawing.Size(75, 23)
        Me.button_Submit.TabIndex = 0
        Me.button_Submit.Text = "SUBMIT"
        Me.button_Submit.UseVisualStyleBackColor = True
        '
        'button_Cancel
        '
        Me.button_Cancel.Location = New System.Drawing.Point(528, 43)
        Me.button_Cancel.Name = "button_Cancel"
        Me.button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.button_Cancel.TabIndex = 1
        Me.button_Cancel.Text = "CANCEL"
        Me.button_Cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CUSTOMER NAME:"
        '
        'text_CustomerName
        '
        Me.text_CustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_CustomerName.Location = New System.Drawing.Point(223, 6)
        Me.text_CustomerName.Name = "text_CustomerName"
        Me.text_CustomerName.Size = New System.Drawing.Size(380, 31)
        Me.text_CustomerName.TabIndex = 3
        '
        'form_AddNewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 74)
        Me.Controls.Add(Me.text_CustomerName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.button_Cancel)
        Me.Controls.Add(Me.button_Submit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(631, 113)
        Me.MinimumSize = New System.Drawing.Size(631, 113)
        Me.Name = "form_AddNewCustomer"
        Me.Text = "Neeco DMS - Customer Center - Add New"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button_Submit As Button
    Friend WithEvents button_Cancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents text_CustomerName As TextBox
End Class