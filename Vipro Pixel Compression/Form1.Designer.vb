<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(-1, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 19)
        Label1.TabIndex = 0
        Label1.Text = "Vipro Projects Corp."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Product Sans", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(69, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 63)
        Label2.TabIndex = 1
        Label2.Text = "Pixel"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(80, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 19)
        Label3.TabIndex = 2
        Label3.Text = "Flie Compressor"
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.White
        Button1.Location = New Point(-1, 397)
        Button1.Name = "Button1"
        Button1.Size = New Size(800, 29)
        Button1.TabIndex = 3
        Button1.Text = "Convert ZIP to PI (less protection)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = Color.White
        Button2.Location = New Point(0, 362)
        Button2.Name = "Button2"
        Button2.Size = New Size(800, 29)
        Button2.TabIndex = 4
        Button2.Text = "Convert ZIP to PIX (lots of protection)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Popup
        Button3.ForeColor = Color.White
        Button3.Location = New Point(0, 324)
        Button3.Name = "Button3"
        Button3.Size = New Size(800, 29)
        Button3.TabIndex = 5
        Button3.Text = "Convert PIX/PX to ZIP"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(800, 428)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Product Sans", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = Color.White
        MaximizeBox = False
        MaximumSize = New Size(818, 475)
        MinimizeBox = False
        MinimumSize = New Size(818, 475)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Vipro Pixel Compressor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
