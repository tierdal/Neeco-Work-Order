<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_MainMenu))
        Me.button_WorkOrders = New System.Windows.Forms.Button()
        Me.button_VendorCenter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.button_CustomerCenter = New System.Windows.Forms.Button()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.button_help = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button_WorkOrders
        '
        Me.button_WorkOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_WorkOrders.Location = New System.Drawing.Point(12, 308)
        Me.button_WorkOrders.Name = "button_WorkOrders"
        Me.button_WorkOrders.Size = New System.Drawing.Size(360, 64)
        Me.button_WorkOrders.TabIndex = 3
        Me.button_WorkOrders.Text = "WORK ORDERS"
        Me.button_WorkOrders.UseVisualStyleBackColor = True
        '
        'button_VendorCenter
        '
        Me.button_VendorCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_VendorCenter.Location = New System.Drawing.Point(12, 238)
        Me.button_VendorCenter.Name = "button_VendorCenter"
        Me.button_VendorCenter.Size = New System.Drawing.Size(360, 64)
        Me.button_VendorCenter.TabIndex = 2
        Me.button_VendorCenter.Text = "VENDOR CENTER"
        Me.button_VendorCenter.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(125, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'button_CustomerCenter
        '
        Me.button_CustomerCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_CustomerCenter.Location = New System.Drawing.Point(12, 168)
        Me.button_CustomerCenter.Name = "button_CustomerCenter"
        Me.button_CustomerCenter.Size = New System.Drawing.Size(360, 64)
        Me.button_CustomerCenter.TabIndex = 1
        Me.button_CustomerCenter.Text = "CUSTOMER CENTER"
        Me.button_CustomerCenter.UseVisualStyleBackColor = True
        '
        'button_Exit
        '
        Me.button_Exit.Location = New System.Drawing.Point(143, 409)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(229, 40)
        Me.button_Exit.TabIndex = 5
        Me.button_Exit.Text = "EXIT"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'button_help
        '
        Me.button_help.Location = New System.Drawing.Point(12, 409)
        Me.button_help.Name = "button_help"
        Me.button_help.Size = New System.Drawing.Size(125, 40)
        Me.button_help.TabIndex = 4
        Me.button_help.Text = "HELP"
        Me.button_help.UseVisualStyleBackColor = True
        '
        'form_MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.button_WorkOrders)
        Me.Controls.Add(Me.button_VendorCenter)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.button_CustomerCenter)
        Me.Controls.Add(Me.button_Exit)
        Me.Controls.Add(Me.button_help)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form_MainMenu"
        Me.Text = "Neeco DMS - Document Management"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_WorkOrders As Button
    Friend WithEvents button_VendorCenter As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents button_CustomerCenter As Button
    Friend WithEvents button_Exit As Button
    Friend WithEvents button_help As Button
End Class
