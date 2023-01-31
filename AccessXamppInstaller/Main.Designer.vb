<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.BrowseButton = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.PathLabel = New System.Windows.Forms.Label
        Me.StartButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.Standard = New System.Windows.Forms.RadioButton
        Me.Custom = New System.Windows.Forms.RadioButton
        Me.MySQL = New System.Windows.Forms.CheckBox
        Me.PHPMyAdmin = New System.Windows.Forms.CheckBox
        Me.FileZilla = New System.Windows.Forms.CheckBox
        Me.Mercury = New System.Windows.Forms.CheckBox
        Me.Tomcat = New System.Windows.Forms.CheckBox
        Me.Perl = New System.Windows.Forms.CheckBox
        Me.Webalizer = New System.Windows.Forms.CheckBox
        Me.SendMail = New System.Windows.Forms.CheckBox
        Me.InstallationType = New System.Windows.Forms.GroupBox
        Me.About = New System.Windows.Forms.Button
        Me.CopyCode = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.UninstallButton = New System.Windows.Forms.Button
        Me.Language = New System.Windows.Forms.GroupBox
        Me.Germany = New System.Windows.Forms.RadioButton
        Me.English = New System.Windows.Forms.RadioButton
        Me.InstallationType.SuspendLayout()
        Me.Language.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrowseButton
        '
        Me.BrowseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BrowseButton.Location = New System.Drawing.Point(432, 40)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseButton.TabIndex = 3
        Me.BrowseButton.Text = "&Browse"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(355, 20)
        Me.TextBox1.TabIndex = 3
        '
        'PathLabel
        '
        Me.PathLabel.AutoSize = True
        Me.PathLabel.Location = New System.Drawing.Point(12, 40)
        Me.PathLabel.Name = "PathLabel"
        Me.PathLabel.Size = New System.Drawing.Size(29, 13)
        Me.PathLabel.TabIndex = 3
        Me.PathLabel.Text = "&Path"
        '
        'StartButton
        '
        Me.StartButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.StartButton.Enabled = False
        Me.StartButton.Location = New System.Drawing.Point(148, 283)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 22
        Me.StartButton.Text = "&Start installation"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(435, 283)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 25
        Me.ExitButton.Text = "&Exit tool"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Standard
        '
        Me.Standard.AutoSize = True
        Me.Standard.Location = New System.Drawing.Point(22, 19)
        Me.Standard.Name = "Standard"
        Me.Standard.Size = New System.Drawing.Size(69, 17)
        Me.Standard.TabIndex = 11
        Me.Standard.TabStop = True
        Me.Standard.Text = "Standard"
        Me.Standard.UseVisualStyleBackColor = True
        '
        'Custom
        '
        Me.Custom.AutoSize = True
        Me.Custom.Location = New System.Drawing.Point(117, 19)
        Me.Custom.Name = "Custom"
        Me.Custom.Size = New System.Drawing.Size(61, 17)
        Me.Custom.TabIndex = 12
        Me.Custom.TabStop = True
        Me.Custom.Text = "Custom"
        Me.Custom.UseVisualStyleBackColor = True
        '
        'MySQL
        '
        Me.MySQL.AutoSize = True
        Me.MySQL.Location = New System.Drawing.Point(83, 171)
        Me.MySQL.Name = "MySQL"
        Me.MySQL.Size = New System.Drawing.Size(59, 17)
        Me.MySQL.TabIndex = 13
        Me.MySQL.Text = "MySQL"
        Me.MySQL.UseVisualStyleBackColor = True
        Me.MySQL.Visible = False
        '
        'PHPMyAdmin
        '
        Me.PHPMyAdmin.AutoSize = True
        Me.PHPMyAdmin.Location = New System.Drawing.Point(155, 172)
        Me.PHPMyAdmin.Name = "PHPMyAdmin"
        Me.PHPMyAdmin.Size = New System.Drawing.Size(88, 17)
        Me.PHPMyAdmin.TabIndex = 14
        Me.PHPMyAdmin.Text = "PHPMyAdmin"
        Me.PHPMyAdmin.UseVisualStyleBackColor = True
        Me.PHPMyAdmin.Visible = False
        '
        'FileZilla
        '
        Me.FileZilla.AutoSize = True
        Me.FileZilla.Location = New System.Drawing.Point(83, 217)
        Me.FileZilla.Name = "FileZilla"
        Me.FileZilla.Size = New System.Drawing.Size(63, 17)
        Me.FileZilla.TabIndex = 15
        Me.FileZilla.Text = "FileZilla "
        Me.FileZilla.UseVisualStyleBackColor = True
        Me.FileZilla.Visible = False
        '
        'Mercury
        '
        Me.Mercury.AutoSize = True
        Me.Mercury.Location = New System.Drawing.Point(316, 174)
        Me.Mercury.Name = "Mercury"
        Me.Mercury.Size = New System.Drawing.Size(68, 17)
        Me.Mercury.TabIndex = 16
        Me.Mercury.Text = "Mercury "
        Me.Mercury.UseVisualStyleBackColor = True
        Me.Mercury.Visible = False
        '
        'Tomcat
        '
        Me.Tomcat.AutoSize = True
        Me.Tomcat.Location = New System.Drawing.Point(159, 217)
        Me.Tomcat.Name = "Tomcat"
        Me.Tomcat.Size = New System.Drawing.Size(64, 17)
        Me.Tomcat.TabIndex = 17
        Me.Tomcat.Text = "Tomcat "
        Me.Tomcat.UseVisualStyleBackColor = True
        Me.Tomcat.Visible = False
        '
        'Perl
        '
        Me.Perl.AutoSize = True
        Me.Perl.Location = New System.Drawing.Point(255, 174)
        Me.Perl.Name = "Perl"
        Me.Perl.Size = New System.Drawing.Size(47, 17)
        Me.Perl.TabIndex = 18
        Me.Perl.Text = "Perl "
        Me.Perl.UseVisualStyleBackColor = True
        Me.Perl.Visible = False
        '
        'Webalizer
        '
        Me.Webalizer.AutoSize = True
        Me.Webalizer.Location = New System.Drawing.Point(322, 217)
        Me.Webalizer.Name = "Webalizer"
        Me.Webalizer.Size = New System.Drawing.Size(76, 17)
        Me.Webalizer.TabIndex = 19
        Me.Webalizer.Text = "Webalizer "
        Me.Webalizer.UseVisualStyleBackColor = True
        Me.Webalizer.Visible = False
        '
        'SendMail
        '
        Me.SendMail.AutoSize = True
        Me.SendMail.Location = New System.Drawing.Point(238, 217)
        Me.SendMail.Name = "SendMail"
        Me.SendMail.Size = New System.Drawing.Size(68, 17)
        Me.SendMail.TabIndex = 20
        Me.SendMail.Text = "SendMail"
        Me.SendMail.UseVisualStyleBackColor = True
        Me.SendMail.Visible = False
        '
        'InstallationType
        '
        Me.InstallationType.Controls.Add(Me.Custom)
        Me.InstallationType.Controls.Add(Me.Standard)
        Me.InstallationType.Location = New System.Drawing.Point(87, 81)
        Me.InstallationType.Name = "InstallationType"
        Me.InstallationType.Size = New System.Drawing.Size(200, 56)
        Me.InstallationType.TabIndex = 13
        Me.InstallationType.TabStop = False
        Me.InstallationType.Text = "Installation Type"
        '
        'About
        '
        Me.About.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.About.Location = New System.Drawing.Point(48, 283)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(75, 23)
        Me.About.TabIndex = 23
        Me.About.Text = "&About"
        Me.About.UseVisualStyleBackColor = True
        '
        'CopyCode
        '
        Me.CopyCode.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CopyCode.Location = New System.Drawing.Point(243, 283)
        Me.CopyCode.Name = "CopyCode"
        Me.CopyCode.Size = New System.Drawing.Size(75, 23)
        Me.CopyCode.TabIndex = 23
        Me.CopyCode.Text = "&Copy Code"
        Me.CopyCode.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "exe"
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.Title = "Choose XAMPP setup"
        '
        'UninstallButton
        '
        Me.UninstallButton.Location = New System.Drawing.Point(339, 283)
        Me.UninstallButton.Name = "UninstallButton"
        Me.UninstallButton.Size = New System.Drawing.Size(75, 23)
        Me.UninstallButton.TabIndex = 23
        Me.UninstallButton.Text = "&Uninstall"
        Me.UninstallButton.UseVisualStyleBackColor = True
        '
        'Language
        '
        Me.Language.Controls.Add(Me.Germany)
        Me.Language.Controls.Add(Me.English)
        Me.Language.Location = New System.Drawing.Point(307, 84)
        Me.Language.Name = "Language"
        Me.Language.Size = New System.Drawing.Size(166, 49)
        Me.Language.TabIndex = 26
        Me.Language.TabStop = False
        Me.Language.Text = "Language"
        '
        'Germany
        '
        Me.Germany.AutoSize = True
        Me.Germany.Location = New System.Drawing.Point(81, 16)
        Me.Germany.Name = "Germany"
        Me.Germany.Size = New System.Drawing.Size(62, 17)
        Me.Germany.TabIndex = 1
        Me.Germany.TabStop = True
        Me.Germany.Text = "German"
        Me.Germany.UseVisualStyleBackColor = True
        '
        'English
        '
        Me.English.AutoSize = True
        Me.English.Location = New System.Drawing.Point(3, 16)
        Me.English.Name = "English"
        Me.English.Size = New System.Drawing.Size(58, 17)
        Me.English.TabIndex = 0
        Me.English.TabStop = True
        Me.English.Text = "English"
        Me.English.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AcceptButton = Me.StartButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(547, 365)
        Me.Controls.Add(Me.Language)
        Me.Controls.Add(Me.UninstallButton)
        Me.Controls.Add(Me.CopyCode)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.InstallationType)
        Me.Controls.Add(Me.SendMail)
        Me.Controls.Add(Me.Webalizer)
        Me.Controls.Add(Me.Perl)
        Me.Controls.Add(Me.Tomcat)
        Me.Controls.Add(Me.Mercury)
        Me.Controls.Add(Me.FileZilla)
        Me.Controls.Add(Me.PHPMyAdmin)
        Me.Controls.Add(Me.MySQL)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.PathLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BrowseButton)
        Me.Name = "Main"
        Me.Text = "AccessXamppInstaller"
        Me.InstallationType.ResumeLayout(False)
        Me.InstallationType.PerformLayout()
        Me.Language.ResumeLayout(False)
        Me.Language.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BrowseButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PathLabel As System.Windows.Forms.Label
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Standard As System.Windows.Forms.RadioButton
    Friend WithEvents Custom As System.Windows.Forms.RadioButton
    Friend WithEvents MySQL As System.Windows.Forms.CheckBox
    Friend WithEvents PHPMyAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents FileZilla As System.Windows.Forms.CheckBox
    Friend WithEvents Mercury As System.Windows.Forms.CheckBox
    Friend WithEvents Tomcat As System.Windows.Forms.CheckBox
    Friend WithEvents Perl As System.Windows.Forms.CheckBox
    Friend WithEvents Webalizer As System.Windows.Forms.CheckBox
    Friend WithEvents SendMail As System.Windows.Forms.CheckBox
    Friend WithEvents InstallationType As System.Windows.Forms.GroupBox
    Friend WithEvents About As System.Windows.Forms.Button
    Friend WithEvents CopyCode As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UninstallButton As System.Windows.Forms.Button
    Friend WithEvents Language As System.Windows.Forms.GroupBox
    Friend WithEvents Germany As System.Windows.Forms.RadioButton
    Friend WithEvents English As System.Windows.Forms.RadioButton
End Class
