<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NeuenServerErstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.HinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerStartenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BenutzerHinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BenutzerAuswählenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.AnmeldenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminzugangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ProgrammInfosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1572, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuenServerErstellenToolStripMenuItem, Me.ServerStartenToolStripMenuItem, Me.AdminzugangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(-3, 203)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(416, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NeuenServerErstellenToolStripMenuItem
        '
        Me.NeuenServerErstellenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripMenuItem})
        Me.NeuenServerErstellenToolStripMenuItem.Name = "NeuenServerErstellenToolStripMenuItem"
        Me.NeuenServerErstellenToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.NeuenServerErstellenToolStripMenuItem.Text = "Rechner Hinzufügen/Erstellen"
        '
        'NameToolStripMenuItem
        '
        Me.NameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.HinzufügenToolStripMenuItem})
        Me.NameToolStripMenuItem.Name = "NameToolStripMenuItem"
        Me.NameToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.NameToolStripMenuItem.Text = "Name:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'HinzufügenToolStripMenuItem
        '
        Me.HinzufügenToolStripMenuItem.Name = "HinzufügenToolStripMenuItem"
        Me.HinzufügenToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.HinzufügenToolStripMenuItem.Text = "Hinzufügen"
        '
        'ServerStartenToolStripMenuItem
        '
        Me.ServerStartenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BenutzerHinzufügenToolStripMenuItem, Me.BenutzerAuswählenToolStripMenuItem})
        Me.ServerStartenToolStripMenuItem.Name = "ServerStartenToolStripMenuItem"
        Me.ServerStartenToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.ServerStartenToolStripMenuItem.Text = "Benutzer"
        '
        'BenutzerHinzufügenToolStripMenuItem
        '
        Me.BenutzerHinzufügenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BenutzerHinzufügenToolStripMenuItem.Name = "BenutzerHinzufügenToolStripMenuItem"
        Me.BenutzerHinzufügenToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.BenutzerHinzufügenToolStripMenuItem.Text = "Benutzer Hinzufügen"
        '
        'BenutzerAuswählenToolStripMenuItem
        '
        Me.BenutzerAuswählenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1, Me.AnmeldenToolStripMenuItem})
        Me.BenutzerAuswählenToolStripMenuItem.Name = "BenutzerAuswählenToolStripMenuItem"
        Me.BenutzerAuswählenToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.BenutzerAuswählenToolStripMenuItem.Text = "Benutzer Auswählen"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        '
        'AnmeldenToolStripMenuItem
        '
        Me.AnmeldenToolStripMenuItem.Name = "AnmeldenToolStripMenuItem"
        Me.AnmeldenToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.AnmeldenToolStripMenuItem.Text = "Anmelden"
        '
        'AdminzugangToolStripMenuItem
        '
        Me.AdminzugangToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminzugangToolStripMenuItem.Name = "AdminzugangToolStripMenuItem"
        Me.AdminzugangToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.AdminzugangToolStripMenuItem.Text = "Adminzugang"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgrammInfosToolStripMenuItem, Me.NewsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 755)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1569, 28)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ProgrammInfosToolStripMenuItem
        '
        Me.ProgrammInfosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammInfosToolStripMenuItem.Name = "ProgrammInfosToolStripMenuItem"
        Me.ProgrammInfosToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.ProgrammInfosToolStripMenuItem.Text = "Programm-Infos"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.NewsToolStripMenuItem.Text = "News:"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(39, 24)
        Me.ToolStripMenuItem1.Text = "----"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Deine Noten-Rechner:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(272, 314)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(544, 364)
        Me.ListBox1.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(272, 684)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(188, 24)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Automatisch Öffnen"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(694, 682)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Öffnen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1521, 769)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Version"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1569, 783)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Noten-Rechner Programm "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NeuenServerErstellenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerStartenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BenutzerHinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgrammInfosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents NameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents HinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BenutzerAuswählenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents AnmeldenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AdminzugangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
