Imports Microsoft.Win32

Public Class Form2
    '########################################################
    ' Credits 3DotDev from http://3dotdevcoder.blogspot.fr/
    '########################################################

    Public Shared Function GetDefaultBrowserPath() As String
        Dim defaultBrowserPath As String = String.Empty
        Dim regkey As RegistryKey = Nothing
        Try
            regkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\shell\Associations\UrlAssociations\http\UserChoice", False)
            If regkey IsNot Nothing Then
                Dim ProgId = regkey.GetValue("Progid").ToString()
                regkey = Registry.ClassesRoot.OpenSubKey(ProgId & "\Shell\open\command", False)
                defaultBrowserPath = If(Not regkey Is Nothing,
                    regkey.GetValue("").ToString(),
                    Registry.ClassesRoot.OpenSubKey("HTTP\Shell\open\command", False).GetValue("").ToString())
            Else
                defaultBrowserPath = Registry.ClassesRoot.OpenSubKey("HTTP\Shell\open\command", False).GetValue("").ToString()
            End If
        Catch ex As Exception

        Finally
            If Not regkey Is Nothing Then regkey.Close()
        End Try
        Return CleanupPath(defaultBrowserPath)
    End Function

    Private Shared Function CleanupPath(path$) As String
        path = path.ToLower().Replace("""", "")
        If Not path.EndsWith(".exe") Then
            path = path.Substring(0, path.LastIndexOf(".exe", StringComparison.Ordinal) + ".exe".Length)
        End If
        Return path
    End Function

    '############################### Vous pouvez exécuter une URL dans votre navigateur par défaut ###########################
    Public Shared Sub ExecUrl()
        Dim Navigateur As String = GetDefaultBrowserPath()   ' Juste pour voir ...
        'MessageBox.Show("Navigateur = " & Navigateur)
        Process.Start(Navigateur, "https://www.iuneiv.yxz/")

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            ExecUrl()
        Catch ex As Exception
            MessageBox.Show("Error of App", "Error 0x01", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class