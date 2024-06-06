<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEARCH_CAMPUS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SEARCH_CAMPUS))
        fromCBox = New ComboBox()
        toCBox = New ComboBox()
        Button1 = New Button()
        Panel1 = New Panel()
        NewBLDGtoPRRC = New Panel()
        PRRCtoNewBLDG = New Panel()
        AdmintoNewBLDG = New Panel()
        NewBLDGtoAdmin = New Panel()
        AdminToPRRC = New Panel()
        PRRCtoAdmin = New Panel()
        Panel1.SuspendLayout()
        NewBLDGtoPRRC.SuspendLayout()
        PRRCtoNewBLDG.SuspendLayout()
        AdmintoNewBLDG.SuspendLayout()
        NewBLDGtoAdmin.SuspendLayout()
        AdminToPRRC.SuspendLayout()
        SuspendLayout()
        ' 
        ' fromCBox
        ' 
        fromCBox.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        fromCBox.FlatStyle = FlatStyle.Flat
        fromCBox.FormattingEnabled = True
        fromCBox.Items.AddRange(New Object() {"FACULTY BUILDING", "NEW BUILDING", "OLD BUILDING"})
        fromCBox.Location = New Point(59, 163)
        fromCBox.Name = "fromCBox"
        fromCBox.Size = New Size(233, 23)
        fromCBox.TabIndex = 0
        ' 
        ' toCBox
        ' 
        toCBox.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        toCBox.FlatStyle = FlatStyle.Flat
        toCBox.FormattingEnabled = True
        toCBox.Items.AddRange(New Object() {"FACULTY BUILDING", "NEW BUILDING", "OLD BUILDING"})
        toCBox.Location = New Point(59, 109)
        toCBox.Name = "toCBox"
        toCBox.Size = New Size(233, 23)
        toCBox.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(1020, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(17, 17)
        Button1.TabIndex = 3
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(toCBox)
        Panel1.Controls.Add(fromCBox)
        Panel1.Location = New Point(654, 172)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(355, 250)
        Panel1.TabIndex = 4
        ' 
        ' NewBLDGtoPRRC
        ' 
        NewBLDGtoPRRC.BackgroundImage = CType(resources.GetObject("NewBLDGtoPRRC.BackgroundImage"), Image)
        NewBLDGtoPRRC.BackgroundImageLayout = ImageLayout.Stretch
        NewBLDGtoPRRC.Controls.Add(PRRCtoNewBLDG)
        NewBLDGtoPRRC.Location = New Point(0, 0)
        NewBLDGtoPRRC.Name = "NewBLDGtoPRRC"
        NewBLDGtoPRRC.Size = New Size(543, 591)
        NewBLDGtoPRRC.TabIndex = 5
        ' 
        ' PRRCtoNewBLDG
        ' 
        PRRCtoNewBLDG.BackgroundImage = CType(resources.GetObject("PRRCtoNewBLDG.BackgroundImage"), Image)
        PRRCtoNewBLDG.BackgroundImageLayout = ImageLayout.Stretch
        PRRCtoNewBLDG.Controls.Add(AdmintoNewBLDG)
        PRRCtoNewBLDG.Location = New Point(0, 0)
        PRRCtoNewBLDG.Name = "PRRCtoNewBLDG"
        PRRCtoNewBLDG.Size = New Size(543, 591)
        PRRCtoNewBLDG.TabIndex = 6
        ' 
        ' AdmintoNewBLDG
        ' 
        AdmintoNewBLDG.BackgroundImage = CType(resources.GetObject("AdmintoNewBLDG.BackgroundImage"), Image)
        AdmintoNewBLDG.BackgroundImageLayout = ImageLayout.Stretch
        AdmintoNewBLDG.Controls.Add(NewBLDGtoAdmin)
        AdmintoNewBLDG.Location = New Point(0, 0)
        AdmintoNewBLDG.Name = "AdmintoNewBLDG"
        AdmintoNewBLDG.Size = New Size(543, 591)
        AdmintoNewBLDG.TabIndex = 7
        ' 
        ' NewBLDGtoAdmin
        ' 
        NewBLDGtoAdmin.BackgroundImage = CType(resources.GetObject("NewBLDGtoAdmin.BackgroundImage"), Image)
        NewBLDGtoAdmin.BackgroundImageLayout = ImageLayout.Stretch
        NewBLDGtoAdmin.Controls.Add(AdminToPRRC)
        NewBLDGtoAdmin.Location = New Point(0, 0)
        NewBLDGtoAdmin.Name = "NewBLDGtoAdmin"
        NewBLDGtoAdmin.Size = New Size(543, 591)
        NewBLDGtoAdmin.TabIndex = 8
        ' 
        ' AdminToPRRC
        ' 
        AdminToPRRC.BackgroundImage = CType(resources.GetObject("AdminToPRRC.BackgroundImage"), Image)
        AdminToPRRC.BackgroundImageLayout = ImageLayout.Stretch
        AdminToPRRC.Controls.Add(PRRCtoAdmin)
        AdminToPRRC.Location = New Point(0, 0)
        AdminToPRRC.Name = "AdminToPRRC"
        AdminToPRRC.Size = New Size(543, 591)
        AdminToPRRC.TabIndex = 9
        ' 
        ' PRRCtoAdmin
        ' 
        PRRCtoAdmin.BackgroundImage = CType(resources.GetObject("PRRCtoAdmin.BackgroundImage"), Image)
        PRRCtoAdmin.BackgroundImageLayout = ImageLayout.Stretch
        PRRCtoAdmin.Location = New Point(0, 0)
        PRRCtoAdmin.Name = "PRRCtoAdmin"
        PRRCtoAdmin.Size = New Size(543, 591)
        PRRCtoAdmin.TabIndex = 10
        ' 
        ' SEARCH_CAMPUS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1050, 591)
        Controls.Add(NewBLDGtoPRRC)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "SEARCH_CAMPUS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SEARCH_CAMPUS"
        Panel1.ResumeLayout(False)
        NewBLDGtoPRRC.ResumeLayout(False)
        PRRCtoNewBLDG.ResumeLayout(False)
        AdmintoNewBLDG.ResumeLayout(False)
        NewBLDGtoAdmin.ResumeLayout(False)
        AdminToPRRC.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents fromCBox As ComboBox
    Friend WithEvents toCBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NewBLDGtoPRRC As Panel
    Friend WithEvents PRRCtoNewBLDG As Panel
    Friend WithEvents AdmintoNewBLDG As Panel
    Friend WithEvents NewBLDGtoAdmin As Panel
    Friend WithEvents AdminToPRRC As Panel
    Friend WithEvents PRRCtoAdmin As Panel
End Class
