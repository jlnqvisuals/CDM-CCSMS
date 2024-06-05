<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NAVIGATE_CAMPUS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NAVIGATE_CAMPUS))
        adminBldgBtn = New Button()
        prrcBldgBtn = New Button()
        newBldgBtn = New Button()
        adminBldgPanel = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        adminBackBtn = New Button()
        adminNavBtn = New Button()
        prrcBldgPanel = New Panel()
        prrcBackBtn = New Button()
        prrcNavBtn = New Button()
        Label7 = New Label()
        Label8 = New Label()
        newBldgPanel = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        newBackBtn = New Button()
        newNavBtn = New Button()
        Button2 = New Button()
        adminBldgPanel.SuspendLayout()
        prrcBldgPanel.SuspendLayout()
        newBldgPanel.SuspendLayout()
        SuspendLayout()
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
        adminBldgBtn.Location = New Point(152, 144)
        adminBldgBtn.Name = "adminBldgBtn"
        adminBldgBtn.Size = New Size(155, 125)
        adminBldgBtn.TabIndex = 0
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
        prrcBldgBtn.Location = New Point(241, 358)
        prrcBldgBtn.Name = "prrcBldgBtn"
        prrcBldgBtn.Size = New Size(155, 125)
        prrcBldgBtn.TabIndex = 0
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
        newBldgBtn.Location = New Point(422, 217)
        newBldgBtn.Name = "newBldgBtn"
        newBldgBtn.Size = New Size(155, 125)
        newBldgBtn.TabIndex = 0
        newBldgBtn.UseVisualStyleBackColor = False
        ' 
        ' adminBldgPanel
        ' 
        adminBldgPanel.BackColor = Color.Transparent
        adminBldgPanel.BackgroundImage = CType(resources.GetObject("adminBldgPanel.BackgroundImage"), Image)
        adminBldgPanel.BackgroundImageLayout = ImageLayout.Stretch
        adminBldgPanel.Controls.Add(Label1)
        adminBldgPanel.Controls.Add(Label2)
        adminBldgPanel.Controls.Add(adminBackBtn)
        adminBldgPanel.Controls.Add(adminNavBtn)
        adminBldgPanel.Location = New Point(654, 78)
        adminBldgPanel.Name = "adminBldgPanel"
        adminBldgPanel.Size = New Size(347, 459)
        adminBldgPanel.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 15F)
        Label1.Location = New Point(30, 307)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 23)
        Label1.TabIndex = 6
        Label1.Text = "Total Room Count: ??"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 15F)
        Label2.Location = New Point(30, 280)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 23)
        Label2.TabIndex = 7
        Label2.Text = "Floor count: 2"
        ' 
        ' adminBackBtn
        ' 
        adminBackBtn.Cursor = Cursors.Hand
        adminBackBtn.FlatAppearance.BorderSize = 0
        adminBackBtn.FlatAppearance.CheckedBackColor = Color.Transparent
        adminBackBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        adminBackBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        adminBackBtn.FlatStyle = FlatStyle.Flat
        adminBackBtn.Location = New Point(188, 410)
        adminBackBtn.Name = "adminBackBtn"
        adminBackBtn.Size = New Size(75, 23)
        adminBackBtn.TabIndex = 1
        adminBackBtn.UseVisualStyleBackColor = True
        ' 
        ' adminNavBtn
        ' 
        adminNavBtn.Cursor = Cursors.Hand
        adminNavBtn.FlatAppearance.BorderSize = 0
        adminNavBtn.FlatAppearance.CheckedBackColor = Color.Transparent
        adminNavBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        adminNavBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        adminNavBtn.FlatStyle = FlatStyle.Flat
        adminNavBtn.Location = New Point(84, 410)
        adminNavBtn.Name = "adminNavBtn"
        adminNavBtn.Size = New Size(75, 23)
        adminNavBtn.TabIndex = 1
        adminNavBtn.UseVisualStyleBackColor = True
        ' 
        ' prrcBldgPanel
        ' 
        prrcBldgPanel.BackColor = Color.Transparent
        prrcBldgPanel.BackgroundImage = CType(resources.GetObject("prrcBldgPanel.BackgroundImage"), Image)
        prrcBldgPanel.BackgroundImageLayout = ImageLayout.Stretch
        prrcBldgPanel.Controls.Add(prrcBackBtn)
        prrcBldgPanel.Controls.Add(prrcNavBtn)
        prrcBldgPanel.Controls.Add(Label7)
        prrcBldgPanel.Controls.Add(Label8)
        prrcBldgPanel.Location = New Point(654, 78)
        prrcBldgPanel.Name = "prrcBldgPanel"
        prrcBldgPanel.Size = New Size(347, 459)
        prrcBldgPanel.TabIndex = 1
        ' 
        ' prrcBackBtn
        ' 
        prrcBackBtn.Cursor = Cursors.Hand
        prrcBackBtn.FlatAppearance.BorderSize = 0
        prrcBackBtn.FlatAppearance.CheckedBackColor = Color.Transparent
        prrcBackBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        prrcBackBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        prrcBackBtn.FlatStyle = FlatStyle.Flat
        prrcBackBtn.ForeColor = Color.Transparent
        prrcBackBtn.Location = New Point(188, 410)
        prrcBackBtn.Name = "prrcBackBtn"
        prrcBackBtn.Size = New Size(75, 23)
        prrcBackBtn.TabIndex = 1
        prrcBackBtn.UseVisualStyleBackColor = True
        ' 
        ' prrcNavBtn
        ' 
        prrcNavBtn.Cursor = Cursors.Hand
        prrcNavBtn.FlatAppearance.BorderSize = 0
        prrcNavBtn.FlatAppearance.CheckedBackColor = Color.Transparent
        prrcNavBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        prrcNavBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        prrcNavBtn.FlatStyle = FlatStyle.Flat
        prrcNavBtn.ForeColor = Color.Transparent
        prrcNavBtn.Location = New Point(83, 410)
        prrcNavBtn.Name = "prrcNavBtn"
        prrcNavBtn.Size = New Size(75, 23)
        prrcNavBtn.TabIndex = 1
        prrcNavBtn.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 15F)
        Label7.Location = New Point(30, 307)
        Label7.Name = "Label7"
        Label7.Size = New Size(201, 23)
        Label7.TabIndex = 0
        Label7.Text = "Total Room Count: ??"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 15F)
        Label8.Location = New Point(30, 280)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 23)
        Label8.TabIndex = 0
        Label8.Text = "Floor count: 3"
        ' 
        ' newBldgPanel
        ' 
        newBldgPanel.BackColor = Color.Transparent
        newBldgPanel.BackgroundImage = CType(resources.GetObject("newBldgPanel.BackgroundImage"), Image)
        newBldgPanel.BackgroundImageLayout = ImageLayout.Stretch
        newBldgPanel.Controls.Add(Label4)
        newBldgPanel.Controls.Add(Label5)
        newBldgPanel.Controls.Add(newBackBtn)
        newBldgPanel.Controls.Add(newNavBtn)
        newBldgPanel.Location = New Point(654, 78)
        newBldgPanel.Name = "newBldgPanel"
        newBldgPanel.Size = New Size(347, 459)
        newBldgPanel.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 15F)
        Label4.Location = New Point(30, 307)
        Label4.Name = "Label4"
        Label4.Size = New Size(201, 23)
        Label4.TabIndex = 4
        Label4.Text = "Total Room Count: ??"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 15F)
        Label5.Location = New Point(30, 280)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 23)
        Label5.TabIndex = 5
        Label5.Text = "Floor count: 4"
        ' 
        ' newBackBtn
        ' 
        newBackBtn.BackgroundImageLayout = ImageLayout.None
        newBackBtn.Cursor = Cursors.Hand
        newBackBtn.FlatAppearance.BorderSize = 0
        newBackBtn.FlatAppearance.CheckedBackColor = Color.Transparent
        newBackBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        newBackBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        newBackBtn.FlatStyle = FlatStyle.Flat
        newBackBtn.Location = New Point(188, 410)
        newBackBtn.Name = "newBackBtn"
        newBackBtn.Size = New Size(75, 23)
        newBackBtn.TabIndex = 1
        newBackBtn.UseVisualStyleBackColor = True
        ' 
        ' newNavBtn
        ' 
        newNavBtn.BackgroundImageLayout = ImageLayout.None
        newNavBtn.Cursor = Cursors.Hand
        newNavBtn.FlatAppearance.BorderSize = 0
        newNavBtn.FlatAppearance.CheckedBackColor = Color.Transparent
        newNavBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        newNavBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        newNavBtn.FlatStyle = FlatStyle.Flat
        newNavBtn.Location = New Point(83, 410)
        newNavBtn.Name = "newNavBtn"
        newNavBtn.Size = New Size(75, 23)
        newNavBtn.TabIndex = 1
        newNavBtn.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(156), CByte(156), CByte(156))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(1020, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(17, 17)
        Button2.TabIndex = 6
        Button2.UseVisualStyleBackColor = False
        ' 
        ' NAVIGATE_CAMPUS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1050, 591)
        Controls.Add(Button2)
        Controls.Add(newBldgBtn)
        Controls.Add(prrcBldgBtn)
        Controls.Add(adminBldgBtn)
        Controls.Add(adminBldgPanel)
        Controls.Add(newBldgPanel)
        Controls.Add(prrcBldgPanel)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "NAVIGATE_CAMPUS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NAVIGATE_CAMPUS"
        adminBldgPanel.ResumeLayout(False)
        adminBldgPanel.PerformLayout()
        prrcBldgPanel.ResumeLayout(False)
        prrcBldgPanel.PerformLayout()
        newBldgPanel.ResumeLayout(False)
        newBldgPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents adminBldgBtn As Button
    Friend WithEvents prrcBldgBtn As Button
    Friend WithEvents newBldgBtn As Button
    Friend WithEvents adminBldgPanel As Panel
    Friend WithEvents adminBackBtn As Button
    Friend WithEvents adminNavBtn As Button
    Friend WithEvents newBldgPanel As Panel
    Friend WithEvents newBackBtn As Button
    Friend WithEvents newNavBtn As Button
    Friend WithEvents prrcBldgPanel As Panel
    Friend WithEvents prrcBackBtn As Button
    Friend WithEvents prrcNavBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
