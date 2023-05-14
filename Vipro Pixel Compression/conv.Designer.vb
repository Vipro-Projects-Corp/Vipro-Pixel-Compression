<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conv
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
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        Button2 = New Button()
        ProgressBar1 = New ProgressBar()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(582, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(206, 37)
        Label4.TabIndex = 22
        Label4.Text = ".pi or .pix to .zip"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(124, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 20)
        Label3.TabIndex = 21
        Label3.Text = "Flie Compressor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Product Sans", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(9, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 63)
        Label2.TabIndex = 20
        Label2.Text = "Pixel"
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 275)
        Button1.Name = "Button1"
        Button1.Size = New Size(800, 29)
        Button1.TabIndex = 24
        Button1.Text = "Select Save Location"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Popup
        Button3.ForeColor = Color.White
        Button3.Location = New Point(0, 310)
        Button3.Name = "Button3"
        Button3.Size = New Size(800, 29)
        Button3.TabIndex = 23
        Button3.Text = "Upload"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(ProgressBar1)
        Panel1.Location = New Point(0, 62)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 326)
        Panel1.TabIndex = 25
        Panel1.Visible = False
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(0, 16)
        Button2.Name = "Button2"
        Button2.Size = New Size(800, 29)
        Button2.TabIndex = 13
        Button2.Text = "Begin Compressing!"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = Color.Black
        ProgressBar1.ForeColor = Color.White
        ProgressBar1.Location = New Point(0, 288)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(797, 29)
        ProgressBar1.Step = 1
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 14
        ' 
        ' conv
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(Button3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        ForeColor = Color.White
        MaximizeBox = False
        MaximumSize = New Size(818, 497)
        MinimizeBox = False
        MinimumSize = New Size(818, 497)
        Name = "conv"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Conversions"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
