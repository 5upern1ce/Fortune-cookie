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
        Me.components = New System.ComponentModel.Container()
        Me.Fortunebtn = New System.Windows.Forms.Button()
        Me.fortunelbl = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Fortunebtn
        '
        Me.Fortunebtn.BackgroundImage = Global.Fortune_cookie.My.Resources.Resources.Check_your_fortune
        Me.Fortunebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Fortunebtn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Fortunebtn.Location = New System.Drawing.Point(755, 625)
        Me.Fortunebtn.Name = "Fortunebtn"
        Me.Fortunebtn.Size = New System.Drawing.Size(526, 321)
        Me.Fortunebtn.TabIndex = 0
        Me.Fortunebtn.UseVisualStyleBackColor = False
        '
        'fortunelbl
        '
        Me.fortunelbl.AutoSize = True
        Me.fortunelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.fortunelbl.Location = New System.Drawing.Point(278, 197)
        Me.fortunelbl.Name = "fortunelbl"
        Me.fortunelbl.Size = New System.Drawing.Size(0, 54)
        Me.fortunelbl.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Exitbtn
        '
        Me.Exitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Exitbtn.Location = New System.Drawing.Point(1588, 837)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(230, 134)
        Me.Exitbtn.TabIndex = 2
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Fortune_cookie.My.Resources.Resources.Asian_cookie_backrgound
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.fortunelbl)
        Me.Controls.Add(Me.Fortunebtn)
        Me.Name = "Form1"
        Me.Text = "s"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Fortunebtn As Button
    Friend WithEvents fortunelbl As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Exitbtn As Button
End Class
