Imports Microsoft.Win32

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim labelSecondes As Double
        Dim labelMinutes As Double
        Dim labelHeures As Double
        Dim labelJours As Long
        Dim labelSemaines As Double
        Dim labelMois As Double
        Dim labelTrimestre As Double
        Dim label180 As Double
        Dim label365 As Double

        labelSecondes = NumericUpDown1.Value * 125 * 86400 / 86400
        If labelSecondes > 10000000 Then
            Label18.Text = labelSecondes / 100000000 & " Tio"

        ElseIf labelSecondes > 100000 Then
            Label18.Text = labelSecondes / 100000 & " Gio"

        ElseIf labelSecondes > 1000 Then
            Label18.Text = labelSecondes / 1000 & " Mio"

        ElseIf labelSecondes > 100 Then
            Label18.Text = labelSecondes / 1 & " Kio"
        End If

        labelMinutes = NumericUpDown1.Value * 125 * 86400 / 1440
        If labelMinutes > 10000000 Then
            Label2.Text = labelMinutes / 100000000 & " Tio"

        ElseIf labelMinutes > 100000 Then
            Label2.Text = labelMinutes / 100000 & " Gio"

        ElseIf labelMinutes > 1000 Then
            Label2.Text = labelMinutes / 1000 & " Mio"

        ElseIf labelMinutes > 100 Then
            Label2.Text = labelMinutes / 1 & " Kio"
        End If

        labelHeures = NumericUpDown1.Value * 125 * 86400 / 24
        If labelHeures > 10000000 Then
            Label3.Text = labelHeures / 100000000 & " Tio"

        ElseIf labelHeures > 1000000 Then
            Label3.Text = labelHeures / 1000000 & " Gio"

        ElseIf labelHeures > 1000 Then
            Label3.Text = labelHeures / 1000 & " Mio"

        ElseIf labelHeures > 100 Then
            Label3.Text = labelHeures / 1 & " Kio"
        End If

        labelJours = NumericUpDown1.Value * 125 * 60 * 60 * 24
        If labelJours > 100000000 Then
            Label5.Text = labelJours / 100000000 & " Tio"

        ElseIf labelJours > 1000000 Then
            Label5.Text = labelJours / 1000000 & " Gio"

        ElseIf labelJours > 1000 Then
            Label5.Text = labelJours / 1000 & " Mio"

        ElseIf labelJours > 100 Then
            Label5.Text = labelJours / 1 & " Kio"
        End If

        labelSemaines = NumericUpDown1.Value * 125 * 86400 * 7
        If labelSemaines > 700000000 Then
            Label7.Text = labelSemaines / 100000000 & " Tio"

        ElseIf labelSemaines > 7000000 Then
            Label7.Text = labelSemaines / 1000000 & " Gio"

        ElseIf labelSemaines > 7000 Then
            Label7.Text = labelSemaines / 1000 & " Mio"

        ElseIf labelSemaines > 700 Then
            Label7.Text = labelSemaines / 1 & " Kio"
        End If

        labelMois = NumericUpDown1.Value * 125 * 86400 * 30
        If labelMois > 100000000 Then
            Label9.Text = labelMois / 1000000000 & " Tio"

        ElseIf labelMois > 1000000 Then
            Label9.Text = labelMois / 1000000 & " Gio"

        ElseIf labelMois > 1000 Then
            Label9.Text = labelMois / 1000 & " Mio"

        ElseIf labelMois > 100 Then
            Label9.Text = labelMois / 1 & " Kio"
        End If

        labelTrimestre = NumericUpDown1.Value * 125 * 86400 * 90
        If labelTrimestre > 100000000 Then
            Label11.Text = labelTrimestre / 1000000000 & " Tio"

        ElseIf labelTrimestre > 1000000 Then
            Label11.Text = labelTrimestre / 1000000 & " Gio"

        ElseIf labelTrimestre > 1000 Then
            Label11.Text = labelTrimestre / 1000 & " Mio"

        ElseIf labelTrimestre > 100 Then
            Label11.Text = labelTrimestre / 1 & " Kio"
        End If

        label180 = NumericUpDown1.Value * 125 * 86400 * 180
        If label180 > 100000000 Then
            Label13.Text = label180 / 1000000000 & " Tio"

        ElseIf label180 > 1000000 Then
            Label13.Text = label180 / 1000000 & " Gio"

        ElseIf label180 > 1000 Then
            Label13.Text = label180 / 1000 & " Mio"

        ElseIf label180 > 100 Then
            Label13.Text = label180 / 1 & " Kio"
        End If

        label365 = NumericUpDown1.Value * 125 * 86400 * 365
        If label365 > 100000000 Then
            Label15.Text = label365 / 1000000000 & " Tio"

        ElseIf label365 > 1000000 Then
            Label15.Text = label365 / 1000000 & " Gio"

        ElseIf label365 > 1000 Then
            Label15.Text = label365 / 1000 & " Mio"

        ElseIf label365 > 100 Then
            Label15.Text = label365 / 1 & " Kio"
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

        If NumericUpDown1.Value = 0 Then

        End If

        Dim labelSecondes As Double
        Dim labelMinutes As Double
        Dim labelHeures As Double
        Dim labelJours As Long
        Dim labelSemaines As Double
        Dim labelMois As Double
        Dim labelTrimestre As Double
        Dim label180 As Double
        Dim label365 As Double

        labelSecondes = NumericUpDown1.Value * 125 * 86400 / 86400
        If labelSecondes > 10000000 Then
            Label18.Text = labelSecondes / 100000000 & " Tio"

        ElseIf labelSecondes > 100000 Then
            Label18.Text = labelSecondes / 100000 & " Gio"

        ElseIf labelSecondes > 1000 Then
            Label18.Text = labelSecondes / 1000 & " Mio"

        ElseIf labelSecondes > 100 Then
            Label18.Text = labelSecondes / 1 & " Kio"
        End If

        labelMinutes = NumericUpDown1.Value * 125 * 86400 / 1440
        If labelMinutes > 10000000 Then
            Label2.Text = labelMinutes / 100000000 & " Tio"

        ElseIf labelMinutes > 100000 Then
            Label2.Text = labelMinutes / 100000 & " Gio"

        ElseIf labelMinutes > 1000 Then
            Label2.Text = labelMinutes / 1000 & " Mio"

        ElseIf labelMinutes > 100 Then
            Label2.Text = labelMinutes / 1 & " Kio"
        End If

        labelHeures = NumericUpDown1.Value * 125 * 86400 / 24
        If labelHeures > 10000000 Then
            Label3.Text = labelHeures / 100000000 & " Tio"

        ElseIf labelHeures > 1000000 Then
            Label3.Text = labelHeures / 1000000 & " Gio"

        ElseIf labelHeures > 1000 Then
            Label3.Text = labelHeures / 1000 & " Mio"

        ElseIf labelHeures > 100 Then
            Label3.Text = labelHeures / 1 & " Kio"
        End If

        labelJours = NumericUpDown1.Value * 125 * 60 * 60 * 24
        If labelJours > 100000000 Then
            Label5.Text = labelJours / 100000000 & " Tio"

        ElseIf labelJours > 1000000 Then
            Label5.Text = labelJours / 1000000 & " Gio"

        ElseIf labelJours > 1000 Then
            Label5.Text = labelJours / 1000 & " Mio"

        ElseIf labelJours > 100 Then
            Label5.Text = labelJours / 1 & " Kio"
        End If

        labelSemaines = NumericUpDown1.Value * 125 * 86400 * 7
        If labelSemaines > 700000000 Then
            Label7.Text = labelSemaines / 100000000 & " Tio"

        ElseIf labelSemaines > 7000000 Then
            Label7.Text = labelSemaines / 1000000 & " Gio"

        ElseIf labelSemaines > 7000 Then
            Label7.Text = labelSemaines / 1000 & " Mio"

        ElseIf labelSemaines > 700 Then
            Label7.Text = labelSemaines / 1 & " Kio"
        End If

        labelMois = NumericUpDown1.Value * 125 * 86400 * 30
        If labelMois > 100000000 Then
            Label9.Text = labelMois / 1000000000 & " Tio"

        ElseIf labelMois > 1000000 Then
            Label9.Text = labelMois / 1000000 & " Gio"

        ElseIf labelMois > 1000 Then
            Label9.Text = labelMois / 1000 & " Mio"

        ElseIf labelMois > 100 Then
            Label9.Text = labelMois / 1 & " Kio"
        End If

        labelTrimestre = NumericUpDown1.Value * 125 * 86400 * 90
        If labelTrimestre > 100000000 Then
            Label11.Text = labelTrimestre / 1000000000 & " Tio"

        ElseIf labelTrimestre > 1000000 Then
            Label11.Text = labelTrimestre / 1000000 & " Gio"

        ElseIf labelTrimestre > 1000 Then
            Label11.Text = labelTrimestre / 1000 & " Mio"

        ElseIf labelTrimestre > 100 Then
            Label11.Text = labelTrimestre / 1 & " Kio"
        End If

        label180 = NumericUpDown1.Value * 125 * 86400 * 180
        If label180 > 100000000 Then
            Label13.Text = label180 / 1000000000 & " Tio"

        ElseIf label180 > 1000000 Then
            Label13.Text = label180 / 1000000 & " Gio"

        ElseIf label180 > 1000 Then
            Label13.Text = label180 / 1000 & " Mio"

        ElseIf label180 > 100 Then
            Label13.Text = label180 / 1 & " Kio"
        End If

        label365 = NumericUpDown1.Value * 125 * 86400 * 365
        If label365 > 100000000 Then
            Label15.Text = label365 / 1000000000 & " Tio"

        ElseIf label365 > 1000000 Then
            Label15.Text = label365 / 1000000 & " Gio"

        ElseIf label365 > 1000 Then
            Label15.Text = label365 / 1000 & " Mio"

        ElseIf label365 > 100 Then
            Label15.Text = label365 / 1 & " Kio"
        End If
    End Sub

    Function valueprix() As Double
        Dim Cout As Double
        Cout = FormatNumber(NumericUpDown2.Value / NumericUpDown3.Value, 2) 'Calcul du cout, FormatNumber sert à mettre 2 chiffres après la virgule
        Return Cout
    End Function
    Function valueprix1() As Double
        Dim Cout As Double
        Cout = FormatNumber(NumericUpDown3.Value / NumericUpDown2.Value, 2) 'Calcul du cout, FormatNumber sert à mettre 2 chiffres après la virgule
        Return Cout
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If NumericUpDown2.Value = 0 Then
                MessageBox.Show("Il n'y a pas de valeur pour le Mbit/s", "NumericUpDowns 0X00", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf NumericUpDown3.Value = 0.0 Then
                MessageBox.Show("Il n'y a pas de valeur pour le prix", "NumericUpDowns 0X01", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.Label24.Text = "Prix par Mbit/s :" & valueprix() & " $"
                Me.Label20.Text = "Mbit/s par le prix : " & valueprix1() & " $"

                TextBox1.Text = " #######################################################" &
                    vbNewLine & "" &
                    vbNewLine & "           " & TextBox3.Text &
                    vbNewLine & "" &
                    vbNewLine & " #######################################################" &
                    vbNewLine & "" &
                    vbNewLine & "           Le forfait est " & NumericUpDown2.Value & " Mbit/s" &
                    vbNewLine & "           Le prix est " & NumericUpDown3.Value & " $" &
                    vbNewLine & "           Valeur en Prix/Mbit/s : " & valueprix() & " $" &
                    vbNewLine & "           Mbit/s par le prix : " & valueprix1() & " $" &
                    vbNewLine & "" &
                    vbNewLine & " #######################################################" &
                    vbNewLine & "" &
                    vbNewLine & "           URL : " & TextBox2.Text &
                    vbNewLine & "           Nom Produit : " & TextBox3.Text &
                    vbNewLine & "" &
                    vbNewLine & " #######################################################"
            End If
        Catch ex As Exception
            MessageBox.Show("Il n'y a pas de valeur dans les NumericUpDowns", "NumericUpDowns 0X0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            ExecUrl()
        Catch ex As Exception
            MessageBox.Show("Error of App", "Error 0x01", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True

        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        MessageBox.Show("Hi", "Hi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
    End Sub
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
