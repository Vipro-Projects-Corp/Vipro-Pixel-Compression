Imports System.IO
Imports System.Threading

Public Class zpix
    Dim filePath
    Dim filesave
    Dim done
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set the initial directory and filter for the file dialog
        openFileDialog.InitialDirectory = "C:\"
        openFileDialog.Filter = "Compression Archives (*.zip)|*.zip|All Types (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        ' Show the file dialog and check if the user clicked the OK button
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            filePath = openFileDialog.FileName
            ' Do something with the file path

            Button3.Text = "Uploaded " & filePath
            done = done + 1
            If done = 2 Then
                Panel1.Show()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "EMPTY Folder, Do Not make a file, ()|"
        saveFileDialog.Title = "Save File"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            filesave = saveFileDialog.FileName

            ' Check if the file already exists
            If File.Exists(filesave) Then
                MessageBox.Show("File already exists. Please choose a different location or filename.")
                Return
            End If
            Button1.Text = "Save Location - " & filesave
        End If
        done = done + 1
        If done = 2 Then
            Panel1.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i
        Dim sourceFile As String = filePath
        Dim targetDirectory As String = "C:\path\to\target"
        Dim targetFileName As String = "newfile.txt"

        ' Combine the target directory and file name
        Dim targetPath As String = filesave & ".pix"

        ' Copy the file to the target location and rename it
        File.Copy(sourceFile, targetPath)
        Do
            ProgressBar1.Value = i
            Threading.Thread.Sleep(1)
            i = i + 1
        Loop Until i = 1000
        MsgBox("Compression Complete!", , "Operation")
    End Sub
End Class