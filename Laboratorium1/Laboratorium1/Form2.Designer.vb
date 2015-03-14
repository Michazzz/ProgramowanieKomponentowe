<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.OwnTextBox1 = New Laboratorium1.OwnTextBox()
        Me.OwnButtonInherits1 = New Laboratorium1.OwnButtonInherits()
        Me.SuspendLayout()
        '
        'OwnTextBox1
        '
        Me.OwnTextBox1.Location = New System.Drawing.Point(359, 12)
        Me.OwnTextBox1.Name = "OwnTextBox1"
        Me.OwnTextBox1.NaszInterface = Nothing
        Me.OwnTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.OwnTextBox1.TabIndex = 2
        Me.OwnTextBox1.Text = ""
        '
        'OwnButtonInherits1
        '
        Me.OwnButtonInherits1.Location = New System.Drawing.Point(13, 171)
        Me.OwnButtonInherits1.Name = "OwnButtonInherits1"
        Me.OwnButtonInherits1.NaszInterface = Nothing
        Me.OwnButtonInherits1.Size = New System.Drawing.Size(75, 23)
        Me.OwnButtonInherits1.TabIndex = 3
        Me.OwnButtonInherits1.Text = "OwnButtonInherits1"
        Me.OwnButtonInherits1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 206)
        Me.Controls.Add(Me.OwnButtonInherits1)
        Me.Controls.Add(Me.OwnTextBox1)
        Me.Name = "Form2"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OwnTextBox1 As Laboratorium1.OwnTextBox
    Friend WithEvents OwnButtonInherits1 As Laboratorium1.OwnButtonInherits

End Class
