<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zpi
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
        Panel1 = New Panel()
        Button2 = New Button()
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        Button3 = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(ProgressBar1)
        Panel1.Location = New Point(0, 119)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 326)
        Panel1.TabIndex = 23
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
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 375)
        Button1.Name = "Button1"
        Button1.Size = New Size(800, 29)
        Button1.TabIndex = 22
        Button1.Text = "Select Save Location"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Popup
        Button3.ForeColor = Color.White
        Button3.Location = New Point(0, 410)
        Button3.Name = "Button3"
        Button3.Size = New Size(800, 29)
        Button3.TabIndex = 21
        Button3.Text = "Upload"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(653, 40)
        Label5.TabIndex = 20
        Label5.Text = "A .pi file is an low quality and low security file compression method. It doesnt't use any encodings" & vbCrLf & "and takes less time to do."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(656, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 37)
        Label4.TabIndex = 19
        Label4.Text = ".zip to .pi"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(115, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 20)
        Label3.TabIndex = 18
        Label3.Text = "Flie Compressor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Product Sans", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(0, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 63)
        Label2.TabIndex = 17
        Label2.Text = "Pixel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 20)
        Label1.TabIndex = 16
        Label1.Text = "Vipro Projects Corp."
        ' 
        ' zpi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.White
        Name = "zpi"
        Text = ".zip to .pi"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
