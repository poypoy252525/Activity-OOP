﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activity2_9
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
        Me.output = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'output
        '
        Me.output.Location = New System.Drawing.Point(56, 143)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(100, 20)
        Me.output.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(67, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Compute"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "/"
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(117, 65)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(53, 20)
        Me.num2.TabIndex = 14
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(42, 65)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(53, 20)
        Me.num1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Activity2_9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 196)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Activity2_9"
        Me.Text = "Activity 2.9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents output As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents num2 As TextBox
    Friend WithEvents num1 As TextBox
    Friend WithEvents Button1 As Button
End Class
