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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.launchGame = New System.Windows.Forms.Button()
        Me.launcherVersionLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LauncherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoombiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DayZA3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoombiesStratisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallationCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.remoteVersionVersion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.installedVersionVersion = New System.Windows.Forms.Label()
        Me.downloadButton = New System.Windows.Forms.Button()
        Me.loadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.motdLabel = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'launchGame
        '
        Me.launchGame.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.launchGame.Location = New System.Drawing.Point(717, 414)
        Me.launchGame.Name = "launchGame"
        Me.launchGame.Size = New System.Drawing.Size(123, 37)
        Me.launchGame.TabIndex = 0
        Me.launchGame.Text = "Launch"
        Me.launchGame.UseVisualStyleBackColor = True
        '
        'launcherVersionLabel
        '
        Me.launcherVersionLabel.AutoSize = True
        Me.launcherVersionLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.launcherVersionLabel.Location = New System.Drawing.Point(12, 433)
        Me.launcherVersionLabel.Name = "launcherVersionLabel"
        Me.launcherVersionLabel.Size = New System.Drawing.Size(61, 21)
        Me.launcherVersionLabel.TabIndex = 2
        Me.launcherVersionLabel.Text = "1.2.5.4"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UpdatesToolStripMenuItem, Me.ModsToolStripMenuItem, Me.InstallationCheckToolStripMenuItem, Me.LaunchOptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(852, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'UpdatesToolStripMenuItem
        '
        Me.UpdatesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LauncherToolStripMenuItem, Me.ZoombiesToolStripMenuItem})
        Me.UpdatesToolStripMenuItem.Name = "UpdatesToolStripMenuItem"
        Me.UpdatesToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.UpdatesToolStripMenuItem.Text = "Update"
        '
        'LauncherToolStripMenuItem
        '
        Me.LauncherToolStripMenuItem.Enabled = False
        Me.LauncherToolStripMenuItem.Name = "LauncherToolStripMenuItem"
        Me.LauncherToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.LauncherToolStripMenuItem.Text = "Launcher (NYI)"
        '
        'ZoombiesToolStripMenuItem
        '
        Me.ZoombiesToolStripMenuItem.Enabled = False
        Me.ZoombiesToolStripMenuItem.Name = "ZoombiesToolStripMenuItem"
        Me.ZoombiesToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ZoombiesToolStripMenuItem.Text = "Zoombies(NYI)"
        '
        'ModsToolStripMenuItem
        '
        Me.ModsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DayZA3ToolStripMenuItem, Me.ZoombiesStratisToolStripMenuItem})
        Me.ModsToolStripMenuItem.Name = "ModsToolStripMenuItem"
        Me.ModsToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ModsToolStripMenuItem.Text = "Mods"
        '
        'DayZA3ToolStripMenuItem
        '
        Me.DayZA3ToolStripMenuItem.Checked = True
        Me.DayZA3ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DayZA3ToolStripMenuItem.Enabled = False
        Me.DayZA3ToolStripMenuItem.Name = "DayZA3ToolStripMenuItem"
        Me.DayZA3ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DayZA3ToolStripMenuItem.Text = "DayZA3"
        '
        'ZoombiesStratisToolStripMenuItem
        '
        Me.ZoombiesStratisToolStripMenuItem.Enabled = False
        Me.ZoombiesStratisToolStripMenuItem.Name = "ZoombiesStratisToolStripMenuItem"
        Me.ZoombiesStratisToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ZoombiesStratisToolStripMenuItem.Text = "Zoombies Stratis"
        '
        'InstallationCheckToolStripMenuItem
        '
        Me.InstallationCheckToolStripMenuItem.Name = "InstallationCheckToolStripMenuItem"
        Me.InstallationCheckToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.InstallationCheckToolStripMenuItem.Text = "Installation Check"
        '
        'LaunchOptionsToolStripMenuItem
        '
        Me.LaunchOptionsToolStripMenuItem.Name = "LaunchOptionsToolStripMenuItem"
        Me.LaunchOptionsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.LaunchOptionsToolStripMenuItem.Text = "Launch Options"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Remote Version:"
        '
        'remoteVersionVersion
        '
        Me.remoteVersionVersion.AutoSize = True
        Me.remoteVersionVersion.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remoteVersionVersion.ForeColor = System.Drawing.Color.LimeGreen
        Me.remoteVersionVersion.Location = New System.Drawing.Point(168, 366)
        Me.remoteVersionVersion.Name = "remoteVersionVersion"
        Me.remoteVersionVersion.Size = New System.Drawing.Size(88, 23)
        Me.remoteVersionVersion.TabIndex = 5
        Me.remoteVersionVersion.Text = "-Version-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Installed Version:"
        '
        'installedVersionVersion
        '
        Me.installedVersionVersion.AutoSize = True
        Me.installedVersionVersion.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.installedVersionVersion.Location = New System.Drawing.Point(169, 389)
        Me.installedVersionVersion.Name = "installedVersionVersion"
        Me.installedVersionVersion.Size = New System.Drawing.Size(43, 23)
        Me.installedVersionVersion.TabIndex = 7
        Me.installedVersionVersion.Text = "null"
        '
        'downloadButton
        '
        Me.downloadButton.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downloadButton.Location = New System.Drawing.Point(717, 371)
        Me.downloadButton.Name = "downloadButton"
        Me.downloadButton.Size = New System.Drawing.Size(123, 37)
        Me.downloadButton.TabIndex = 8
        Me.downloadButton.Text = "Download"
        Me.downloadButton.UseVisualStyleBackColor = True
        Me.downloadButton.Visible = False
        '
        'motdLabel
        '
        Me.motdLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motdLabel.Location = New System.Drawing.Point(16, 25)
        Me.motdLabel.Name = "motdLabel"
        Me.motdLabel.Size = New System.Drawing.Size(672, 341)
        Me.motdLabel.TabIndex = 11
        Me.motdLabel.Text = "MOTD"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(393, 439)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(173, 15)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Logo created by: blabaalzaurus"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Zoombies_Launcher.My.Resources.Resources.ZOOMBIES_LOGO1
        Me.PictureBox2.Location = New System.Drawing.Point(396, 371)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(315, 67)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(702, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 118)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 463)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.motdLabel)
        Me.Controls.Add(Me.downloadButton)
        Me.Controls.Add(Me.installedVersionVersion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.remoteVersionVersion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.launcherVersionLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.launchGame)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Zoombies Universal Launcher"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents launchGame As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents launcherVersionLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LauncherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoombiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents remoteVersionVersion As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents installedVersionVersion As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaunchOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents downloadButton As System.Windows.Forms.Button
    Friend WithEvents ModsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DayZA3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoombiesStratisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents loadTimer As System.Windows.Forms.Timer
    Friend WithEvents motdLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents InstallationCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
