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
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.MuteButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewGameButton
        '
        Me.NewGameButton.Location = New System.Drawing.Point(197, 226)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(75, 23)
        Me.NewGameButton.TabIndex = 0
        Me.NewGameButton.Text = "Nytt spill"
        Me.NewGameButton.UseVisualStyleBackColor = True
        '
        'MuteButton
        '
        Me.MuteButton.Location = New System.Drawing.Point(197, 197)
        Me.MuteButton.Name = "MuteButton"
        Me.MuteButton.Size = New System.Drawing.Size(75, 23)
        Me.MuteButton.TabIndex = 1
        Me.MuteButton.Text = "Mute"
        Me.MuteButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MuteButton)
        Me.Controls.Add(Me.NewGameButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewGameButton As Button
    Friend WithEvents MuteButton As Button
End Class
