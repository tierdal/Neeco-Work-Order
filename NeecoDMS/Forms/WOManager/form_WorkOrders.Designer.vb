﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_WorkOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_WorkOrders))
        Me.button_About = New System.Windows.Forms.Button()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.button_ViewWO = New System.Windows.Forms.Button()
        Me.button_AddNewWO = New System.Windows.Forms.Button()
        Me.button_EditWO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_About
        '
        Me.button_About.Location = New System.Drawing.Point(12, 259)
        Me.button_About.Name = "button_About"
        Me.button_About.Size = New System.Drawing.Size(125, 40)
        Me.button_About.TabIndex = 0
        Me.button_About.TabStop = False
        Me.button_About.Text = "OPTIONS"
        Me.button_About.UseVisualStyleBackColor = True
        '
        'button_Exit
        '
        Me.button_Exit.Location = New System.Drawing.Point(143, 259)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(229, 40)
        Me.button_Exit.TabIndex = 4
        Me.button_Exit.Text = "EXIT"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'button_ViewWO
        '
        Me.button_ViewWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_ViewWO.Location = New System.Drawing.Point(12, 12)
        Me.button_ViewWO.Name = "button_ViewWO"
        Me.button_ViewWO.Size = New System.Drawing.Size(360, 64)
        Me.button_ViewWO.TabIndex = 1
        Me.button_ViewWO.Text = "OPEN WORK ORDER LOG"
        Me.button_ViewWO.UseVisualStyleBackColor = True
        '
        'button_AddNewWO
        '
        Me.button_AddNewWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_AddNewWO.Location = New System.Drawing.Point(12, 82)
        Me.button_AddNewWO.Name = "button_AddNewWO"
        Me.button_AddNewWO.Size = New System.Drawing.Size(360, 64)
        Me.button_AddNewWO.TabIndex = 2
        Me.button_AddNewWO.Text = "ADD NEW WORK ORDER"
        Me.button_AddNewWO.UseVisualStyleBackColor = True
        '
        'button_EditWO
        '
        Me.button_EditWO.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_EditWO.Location = New System.Drawing.Point(12, 152)
        Me.button_EditWO.Name = "button_EditWO"
        Me.button_EditWO.Size = New System.Drawing.Size(360, 64)
        Me.button_EditWO.TabIndex = 3
        Me.button_EditWO.Text = "EDIT WORK ORDER"
        Me.button_EditWO.UseVisualStyleBackColor = True
        '
        'form_WorkOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.button_EditWO)
        Me.Controls.Add(Me.button_AddNewWO)
        Me.Controls.Add(Me.button_ViewWO)
        Me.Controls.Add(Me.button_Exit)
        Me.Controls.Add(Me.button_About)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form_WorkOrders"
        Me.Text = "NeecoDMS - Work Orders"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_About As Button
    Friend WithEvents button_Exit As Button
    Friend WithEvents button_ViewWO As Button
    Friend WithEvents button_AddNewWO As Button
    Friend WithEvents button_EditWO As Button
End Class
