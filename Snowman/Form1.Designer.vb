<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pboxPlatno = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbarSnow = New System.Windows.Forms.TrackBar()
        Me.tbarSize = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pboxSnowColor = New System.Windows.Forms.PictureBox()
        Me.pboxSkyColor = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbarWind = New System.Windows.Forms.TrackBar()
        Me.tbarPosition = New System.Windows.Forms.TrackBar()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pboxPlatno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.tbarSnow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbarSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pboxSnowColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxSkyColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tbarWind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbarPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pboxPlatno
        '
        Me.pboxPlatno.BackColor = System.Drawing.Color.White
        Me.pboxPlatno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboxPlatno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pboxPlatno.Location = New System.Drawing.Point(107, 0)
        Me.pboxPlatno.Name = "pboxPlatno"
        Me.pboxPlatno.Size = New System.Drawing.Size(673, 368)
        Me.pboxPlatno.TabIndex = 0
        Me.pboxPlatno.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.tbarSnow)
        Me.Panel1.Controls.Add(Me.tbarSize)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(107, 368)
        Me.Panel1.TabIndex = 1
        '
        'tbarSnow
        '
        Me.tbarSnow.Location = New System.Drawing.Point(56, 140)
        Me.tbarSnow.Maximum = 100
        Me.tbarSnow.Name = "tbarSnow"
        Me.tbarSnow.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbarSnow.Size = New System.Drawing.Size(45, 222)
        Me.tbarSnow.TabIndex = 2
        '
        'tbarSize
        '
        Me.tbarSize.Location = New System.Drawing.Point(12, 140)
        Me.tbarSize.Maximum = 100
        Me.tbarSize.Name = "tbarSize"
        Me.tbarSize.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbarSize.Size = New System.Drawing.Size(45, 222)
        Me.tbarSize.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pboxSnowColor)
        Me.GroupBox1.Controls.Add(Me.pboxSkyColor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(95, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colors"
        '
        'pboxSnowColor
        '
        Me.pboxSnowColor.BackColor = System.Drawing.Color.White
        Me.pboxSnowColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboxSnowColor.Location = New System.Drawing.Point(25, 86)
        Me.pboxSnowColor.Name = "pboxSnowColor"
        Me.pboxSnowColor.Size = New System.Drawing.Size(51, 31)
        Me.pboxSnowColor.TabIndex = 3
        Me.pboxSnowColor.TabStop = False
        '
        'pboxSkyColor
        '
        Me.pboxSkyColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pboxSkyColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pboxSkyColor.Location = New System.Drawing.Point(25, 36)
        Me.pboxSkyColor.Name = "pboxSkyColor"
        Me.pboxSkyColor.Size = New System.Drawing.Size(51, 31)
        Me.pboxSkyColor.TabIndex = 2
        Me.pboxSkyColor.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "snow:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "sky:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.tbarWind)
        Me.Panel2.Controls.Add(Me.tbarPosition)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 368)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 64)
        Me.Panel2.TabIndex = 2
        '
        'tbarWind
        '
        Me.tbarWind.Location = New System.Drawing.Point(7, 7)
        Me.tbarWind.Maximum = 100
        Me.tbarWind.Minimum = -100
        Me.tbarWind.Name = "tbarWind"
        Me.tbarWind.Size = New System.Drawing.Size(100, 45)
        Me.tbarWind.TabIndex = 1
        '
        'tbarPosition
        '
        Me.tbarPosition.Location = New System.Drawing.Point(107, 7)
        Me.tbarPosition.Maximum = 100
        Me.tbarPosition.Name = "tbarPosition"
        Me.tbarPosition.Size = New System.Drawing.Size(670, 45)
        Me.tbarPosition.TabIndex = 0
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 432)
        Me.Controls.Add(Me.pboxPlatno)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Sněhulák"
        CType(Me.pboxPlatno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tbarSnow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbarSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pboxSnowColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxSkyColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tbarWind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbarPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pboxPlatno As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pboxSnowColor As PictureBox
    Friend WithEvents pboxSkyColor As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents tmrTime As Timer
    Friend WithEvents tbarSize As TrackBar
    Friend WithEvents tbarPosition As TrackBar
    Friend WithEvents tbarWind As TrackBar
    Friend WithEvents tbarSnow As TrackBar
End Class
