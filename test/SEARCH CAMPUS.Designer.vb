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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        adminBldgBtn = New Button()
        prrcBldgBtn = New Button()
        newBldgBtn = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Panel1.SuspendLayout()
        NewBLDGtoPRRC.SuspendLayout()
        PRRCtoNewBLDG.SuspendLayout()
        AdmintoNewBLDG.SuspendLayout()
        NewBLDGtoAdmin.SuspendLayout()
        AdminToPRRC.SuspendLayout()
        PRRCtoAdmin.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' fromCBox
        ' 
        fromCBox.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        fromCBox.FlatStyle = FlatStyle.Flat
        fromCBox.FormattingEnabled = True
        fromCBox.Items.AddRange(New Object() {"ADMIN BUILDING", "YNARES BUILDING", "PRRC BUILDING"})
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
        toCBox.Items.AddRange(New Object() {"ADMIN BUILDING", "YNARES BUILDING", "PRRC BUILDING"})
        toCBox.Location = New Point(59, 109)
        toCBox.Name = "toCBox"
        toCBox.Size = New Size(233, 23)
        toCBox.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
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
        NewBLDGtoPRRC.Controls.Add(prrcBldgBtn)
        NewBLDGtoPRRC.Controls.Add(PictureBox1)
        NewBLDGtoPRRC.Location = New Point(0, 0)
        NewBLDGtoPRRC.Name = "NewBLDGtoPRRC"
        NewBLDGtoPRRC.Size = New Size(543, 591)
        NewBLDGtoPRRC.TabIndex = 5
        NewBLDGtoPRRC.Visible = False
        ' 
        ' PRRCtoNewBLDG
        ' 
        PRRCtoNewBLDG.BackgroundImage = CType(resources.GetObject("PRRCtoNewBLDG.BackgroundImage"), Image)
        PRRCtoNewBLDG.BackgroundImageLayout = ImageLayout.Stretch
        PRRCtoNewBLDG.Controls.Add(newBldgBtn)
        PRRCtoNewBLDG.Controls.Add(PictureBox2)
        PRRCtoNewBLDG.Location = New Point(0, 0)
        PRRCtoNewBLDG.Name = "PRRCtoNewBLDG"
        PRRCtoNewBLDG.Size = New Size(543, 591)
        PRRCtoNewBLDG.TabIndex = 6
        PRRCtoNewBLDG.Visible = False
        ' 
        ' AdmintoNewBLDG
        ' 
        AdmintoNewBLDG.BackgroundImage = CType(resources.GetObject("AdmintoNewBLDG.BackgroundImage"), Image)
        AdmintoNewBLDG.BackgroundImageLayout = ImageLayout.Stretch
        AdmintoNewBLDG.Controls.Add(Button2)
        AdmintoNewBLDG.Controls.Add(PictureBox3)
        AdmintoNewBLDG.Location = New Point(0, 0)
        AdmintoNewBLDG.Name = "AdmintoNewBLDG"
        AdmintoNewBLDG.Size = New Size(543, 591)
        AdmintoNewBLDG.TabIndex = 7
        AdmintoNewBLDG.Visible = False
        ' 
        ' NewBLDGtoAdmin
        ' 
        NewBLDGtoAdmin.BackgroundImage = CType(resources.GetObject("NewBLDGtoAdmin.BackgroundImage"), Image)
        NewBLDGtoAdmin.BackgroundImageLayout = ImageLayout.Stretch
        NewBLDGtoAdmin.Controls.Add(Button3)
        NewBLDGtoAdmin.Controls.Add(PictureBox4)
        NewBLDGtoAdmin.Location = New Point(0, 0)
        NewBLDGtoAdmin.Name = "NewBLDGtoAdmin"
        NewBLDGtoAdmin.Size = New Size(543, 591)
        NewBLDGtoAdmin.TabIndex = 8
        NewBLDGtoAdmin.Visible = False
        ' 
        ' AdminToPRRC
        ' 
        AdminToPRRC.BackgroundImage = CType(resources.GetObject("AdminToPRRC.BackgroundImage"), Image)
        AdminToPRRC.BackgroundImageLayout = ImageLayout.Stretch
        AdminToPRRC.Controls.Add(Button4)
        AdminToPRRC.Controls.Add(PictureBox5)
        AdminToPRRC.Location = New Point(0, 0)
        AdminToPRRC.Name = "AdminToPRRC"
        AdminToPRRC.Size = New Size(543, 591)
        AdminToPRRC.TabIndex = 9
        AdminToPRRC.Visible = False
        ' 
        ' PRRCtoAdmin
        ' 
        PRRCtoAdmin.BackgroundImage = CType(resources.GetObject("PRRCtoAdmin.BackgroundImage"), Image)
        PRRCtoAdmin.BackgroundImageLayout = ImageLayout.Stretch
        PRRCtoAdmin.Controls.Add(adminBldgBtn)
        PRRCtoAdmin.Controls.Add(PictureBox6)
        PRRCtoAdmin.Location = New Point(0, 0)
        PRRCtoAdmin.Name = "PRRCtoAdmin"
        PRRCtoAdmin.Size = New Size(543, 591)
        PRRCtoAdmin.TabIndex = 10
        PRRCtoAdmin.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(329, 274)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 28)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(214, 395)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 28)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(166, 245)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(28, 28)
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(329, 273)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(28, 28)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(166, 245)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(28, 28)
        PictureBox5.TabIndex = 1
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(214, 422)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(28, 28)
        PictureBox6.TabIndex = 1
        PictureBox6.TabStop = False
        ' 
        ' adminBldgBtn
        ' 
        adminBldgBtn.BackColor = Color.Transparent
        adminBldgBtn.BackgroundImage = CType(resources.GetObject("adminBldgBtn.BackgroundImage"), Image)
        adminBldgBtn.BackgroundImageLayout = ImageLayout.None
        adminBldgBtn.Cursor = Cursors.Hand
        adminBldgBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(216), CByte(216), CByte(216))
        adminBldgBtn.FlatAppearance.BorderSize = 0
        adminBldgBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        adminBldgBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        adminBldgBtn.FlatStyle = FlatStyle.Flat
        adminBldgBtn.ForeColor = SystemColors.ControlText
        adminBldgBtn.Location = New Point(76, 89)
        adminBldgBtn.Name = "adminBldgBtn"
        adminBldgBtn.Size = New Size(155, 125)
        adminBldgBtn.TabIndex = 2
        adminBldgBtn.UseVisualStyleBackColor = False
        ' 
        ' prrcBldgBtn
        ' 
        prrcBldgBtn.BackColor = Color.Transparent
        prrcBldgBtn.BackgroundImage = CType(resources.GetObject("prrcBldgBtn.BackgroundImage"), Image)
        prrcBldgBtn.BackgroundImageLayout = ImageLayout.None
        prrcBldgBtn.Cursor = Cursors.Hand
        prrcBldgBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(216), CByte(216), CByte(216))
        prrcBldgBtn.FlatAppearance.BorderSize = 0
        prrcBldgBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        prrcBldgBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        prrcBldgBtn.FlatStyle = FlatStyle.Flat
        prrcBldgBtn.ForeColor = SystemColors.ControlText
        prrcBldgBtn.Location = New Point(53, 325)
        prrcBldgBtn.Name = "prrcBldgBtn"
        prrcBldgBtn.Size = New Size(155, 125)
        prrcBldgBtn.TabIndex = 1
        prrcBldgBtn.UseVisualStyleBackColor = False
        ' 
        ' newBldgBtn
        ' 
        newBldgBtn.BackColor = Color.Transparent
        newBldgBtn.BackgroundImage = CType(resources.GetObject("newBldgBtn.BackgroundImage"), Image)
        newBldgBtn.BackgroundImageLayout = ImageLayout.None
        newBldgBtn.Cursor = Cursors.Hand
        newBldgBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(216), CByte(216), CByte(216))
        newBldgBtn.FlatAppearance.BorderSize = 0
        newBldgBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        newBldgBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        newBldgBtn.FlatStyle = FlatStyle.Flat
        newBldgBtn.ForeColor = SystemColors.ControlText
        newBldgBtn.Location = New Point(343, 172)
        newBldgBtn.Name = "newBldgBtn"
        newBldgBtn.Size = New Size(155, 125)
        newBldgBtn.TabIndex = 2
        newBldgBtn.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(216), CByte(216), CByte(216))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(332, 194)
        Button2.Name = "Button2"
        Button2.Size = New Size(155, 125)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderColor = Color.FromArgb(CByte(216), CByte(216), CByte(216))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ControlText
        Button3.Location = New Point(67, 98)
        Button3.Name = "Button3"
        Button3.Size = New Size(155, 125)
        Button3.TabIndex = 2
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.None
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderColor = Color.FromArgb(CByte(216), CByte(216), CByte(216))
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.ControlText
        Button4.Location = New Point(259, 422)
        Button4.Name = "Button4"
        Button4.Size = New Size(155, 125)
        Button4.TabIndex = 2
        Button4.UseVisualStyleBackColor = False
        ' 
        ' SEARCH_CAMPUS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1050, 591)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(PRRCtoAdmin)
        Controls.Add(NewBLDGtoPRRC)
        Controls.Add(PRRCtoNewBLDG)
        Controls.Add(AdmintoNewBLDG)
        Controls.Add(NewBLDGtoAdmin)
        Controls.Add(AdminToPRRC)
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
        PRRCtoAdmin.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents adminBldgBtn As Button
    Friend WithEvents prrcBldgBtn As Button
    Friend WithEvents newBldgBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
