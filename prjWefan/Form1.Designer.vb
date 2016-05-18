<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnArbed = New System.Windows.Forms.Button()
        Me.lblTeitl = New System.Windows.Forms.Label()
        Me.btnYchwaneguTeitlau = New System.Windows.Forms.Button()
        Me.cmbTeitlTudalennau = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnArbed
        '
        Me.btnArbed.Location = New System.Drawing.Point(757, 519)
        Me.btnArbed.Name = "btnArbed"
        Me.btnArbed.Size = New System.Drawing.Size(83, 45)
        Me.btnArbed.TabIndex = 0
        Me.btnArbed.Text = "Arbed"
        Me.btnArbed.UseVisualStyleBackColor = True
        '
        'lblTeitl
        '
        Me.lblTeitl.AutoSize = True
        Me.lblTeitl.Location = New System.Drawing.Point(17, 72)
        Me.lblTeitl.Name = "lblTeitl"
        Me.lblTeitl.Size = New System.Drawing.Size(85, 13)
        Me.lblTeitl.TabIndex = 1
        Me.lblTeitl.Text = "Teitlau'r dudalen"
        '
        'btnYchwaneguTeitlau
        '
        Me.btnYchwaneguTeitlau.Location = New System.Drawing.Point(20, 88)
        Me.btnYchwaneguTeitlau.Name = "btnYchwaneguTeitlau"
        Me.btnYchwaneguTeitlau.Size = New System.Drawing.Size(74, 25)
        Me.btnYchwaneguTeitlau.TabIndex = 3
        Me.btnYchwaneguTeitlau.Text = "Ychwanegu"
        Me.btnYchwaneguTeitlau.UseVisualStyleBackColor = True
        '
        'cmbTeitlTudalennau
        '
        Me.cmbTeitlTudalennau.FormattingEnabled = True
        Me.cmbTeitlTudalennau.Location = New System.Drawing.Point(18, 133)
        Me.cmbTeitlTudalennau.Name = "cmbTeitlTudalennau"
        Me.cmbTeitlTudalennau.Size = New System.Drawing.Size(146, 21)
        Me.cmbTeitlTudalennau.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 576)
        Me.Controls.Add(Me.cmbTeitlTudalennau)
        Me.Controls.Add(Me.btnYchwaneguTeitlau)
        Me.Controls.Add(Me.lblTeitl)
        Me.Controls.Add(Me.btnArbed)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnArbed As System.Windows.Forms.Button
    Friend WithEvents lblTeitl As System.Windows.Forms.Label
    Friend WithEvents btnYchwaneguTeitlau As System.Windows.Forms.Button
    Friend WithEvents cmbTeitlTudalennau As System.Windows.Forms.ComboBox

End Class
