Public Class Main

    Public Function GetCommand() As String
        Dim command As String = ""
        ' get the selected language
        Dim language As String = ""
        If English.Checked Then
            language = "en"
        ElseIf Germany.Checked Then
            language = "de"
        End If
        '        install standerd type
        If Standard.Checked Then
            command = String.Format("{0} --mode unattended --xampp_control_language {1}", TextBox1.Text, language)
            ' install custom type
        ElseIf Custom.Checked Then
            Dim CommandDisable As String = "--disable-components "
            Dim ExcludedComponents As New List(Of String)
            If Not MySQL.Checked Then
                ExcludedComponents.Add("xampp_mysql")
            End If
            If Not FileZilla.Checked Then
                ExcludedComponents.Add("xampp_filezilla")
            End If
            If Not Mercury.Checked Then
                ExcludedComponents.Add("xampp_mercury")
            End If
            If Not Tomcat.Checked Then
                ExcludedComponents.Add("xampp_tomcat")
            End If
            If Not Perl.Checked Then
                ExcludedComponents.Add("xampp_perl")
            End If
            If Not PHPMyAdmin.Checked Then
                ExcludedComponents.Add("xampp_phpmyadmin")
            End If
            If Not Webalizer.Checked Then
                ExcludedComponents.Add("xampp_webalizer")
            End If
            If Not SendMail.Checked Then
                ExcludedComponents.Add("xampp_sendmail")
            End If
            For Each c As String In ExcludedComponents
                CommandDisable &= c & ","
            Next
            CommandDisable = Mid(CommandDisable, 1, CommandDisable.Length - 1)
            command = String.Format("{0} --mode unattended {1} --xampp_control_language {2}", TextBox1.Text, CommandDisable, language)
        End If

        Return command

    End Function

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Standard.Checked = True
        English.Checked = True
        If IO.File.Exists("C:\xampp\uninstall.exe") Then
            UninstallButton.Enabled = True
        Else
            UninstallButton.Enabled = False
        End If
    End Sub

    Private Sub Custom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Custom.CheckedChanged, Standard.CheckedChanged
        MySQL.Visible = Custom.Checked
        PHPMyAdmin.Visible = Custom.Checked
        FileZilla.Visible = Custom.Checked
        Mercury.Visible = Custom.Checked
        Tomcat.Visible = Custom.Checked
        Perl.Visible = Custom.Checked
        Webalizer.Visible = Custom.Checked
        SendMail.Visible = Custom.Checked

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub BrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseButton.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            TextBox1.Focus()
        End If
    End Sub

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        ' run the install command in cmd.
        Dim command As String = String.Format("{0} --mode unattended --xampp_control_language {1}", TextBox1.Text, Language)
        Dim cmd As String = GetCommand()
        Dim start As New ProcessStartInfo
        start.FileName = "cmd.exe"
        start.Arguments = "/C " + cmd
        start.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(start)

        ' show message Tells the user to start the installation
        MessageBox.Show("the installation has been started," & vbNewLine & "it may take a few minutes.", "Installing", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Close the tool    
        End
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            StartButton.Enabled = False
        Else
            StartButton.Enabled = True
        End If
    End Sub

    Private Sub UninstallButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UninstallButton.Click
        Dim command As String = "%systemdrive%\xampp\uninstall.exe --mode unattended"
        Dim cmd As String = command
        Dim start As New ProcessStartInfo
        start.FileName = "cmd.exe"
        start.Arguments = "/C " + cmd
        start.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(start)

        ' show message Tells the user to start the uninstallation
        MessageBox.Show("the uninstallation has been started," & vbNewLine & "it may take a few minutes.", "unInstalling", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Close the tool
        End
    End Sub

    Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About.Click
        Dim text As String = String.Format("This tool is developed by tecwindow.{0}Its primary function is to help blind people to install/uninstall xampp.{1}you can visit tecwindow website from:{2}tecwindow.net", vbNewLine, vbNewLine, vbNewLine)
        MessageBox.Show(text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CopyCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyCode.Click
        Clipboard.SetText(GetCommand)
        MessageBox.Show("The command has been copied.", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class