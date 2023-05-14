<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zpix
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
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button3 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        ProgressBar1 = New ProgressBar()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(115, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 20)
        Label3.TabIndex = 8
        Label3.Text = "Flie Compressor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Product Sans", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(0, -1)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 63)
        Label2.TabIndex = 7
        Label2.Text = "Pixel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 20)
        Label1.TabIndex = 6
        Label1.Text = "Vipro Projects Corp."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(656, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 37)
        Label4.TabIndex = 9
        Label4.Text = ".zip to .pix"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 69)
        Label5.Name = "Label5"
        Label5.Size = New Size(756, 40)
        Label5.TabIndex = 10
        Label5.Text = "A .pix file is an high quality and high security compression method. This type of compression method compresses" & vbCrLf & "the data in it by changing the encoding to a different type."
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Popup
        Button3.ForeColor = Color.White
        Button3.Location = New Point(0, 403)
        Button3.Name = "Button3"
        Button3.Size = New Size(800, 29)
        Button3.TabIndex = 11
        Button3.Text = "Upload"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 368)
        Button1.Name = "Button1"
        Button1.Size = New Size(800, 29)
        Button1.TabIndex = 12
        Button1.Text = "Select Save Location"
        Button1.UseVisualStyleBackColor = False
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
        ProgressBar1.Maximum = 1000
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(797, 29)
        ProgressBar1.Step = 1
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 14
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(ProgressBar1)
        Panel1.Location = New Point(0, 112)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 326)
        Panel1.TabIndex = 15
        Panel1.Visible = False
        ' 
        ' zpix
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
        MaximizeBox = False
        MaximumSize = New Size(818, 497)
        MinimizeBox = False
        MinimumSize = New Size(818, 497)
        Name = "zpix"
        StartPosition = FormStartPosition.CenterScreen
        Text = ".zip to .pix - Vipro Pixel Compression"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel1 As Panel
End Class
