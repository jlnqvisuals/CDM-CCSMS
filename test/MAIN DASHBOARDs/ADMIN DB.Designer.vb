<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN_DB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADMIN_DB))
        acceptBtn = New Button()
        rejectBtn = New Button()
        reviewGrid = New DataGridView()
        acceptedGrid = New DataGridView()
        schedLogBtn = New Button()
        acceptedLogPanel = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        acceptedGrid2 = New DataGridView()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        reviewGrid2 = New DataGridView()
        acceptBtn2 = New Button()
        rejectBtn2 = New Button()
        CType(reviewGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(acceptedGrid, ComponentModel.ISupportInitialize).BeginInit()
        acceptedLogPanel.SuspendLayout()
        CType(acceptedGrid2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(reviewGrid2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' acceptBtn
        ' 
        acceptBtn.BackColor = Color.Transparent
        acceptBtn.BackgroundImage = CType(resources.GetObject("acceptBtn.BackgroundImage"), Image)
        acceptBtn.BackgroundImageLayout = ImageLayout.Stretch
        acceptBtn.Cursor = Cursors.Hand
        acceptBtn.FlatStyle = FlatStyle.Flat
        acceptBtn.ForeColor = Color.White
        acceptBtn.Location = New Point(811, 35)
        acceptBtn.Name = "acceptBtn"
        acceptBtn.Size = New Size(83, 30)
        acceptBtn.TabIndex = 1
        acceptBtn.Text = "Accept"
        acceptBtn.UseVisualStyleBackColor = False
        ' 
        ' rejectBtn
        ' 
        rejectBtn.BackColor = Color.Transparent
        rejectBtn.BackgroundImage = CType(resources.GetObject("rejectBtn.BackgroundImage"), Image)
        rejectBtn.BackgroundImageLayout = ImageLayout.Stretch
        rejectBtn.Cursor = Cursors.Hand
        rejectBtn.FlatStyle = FlatStyle.Flat
        rejectBtn.ForeColor = Color.White
        rejectBtn.Location = New Point(811, 64)
        rejectBtn.Name = "rejectBtn"
        rejectBtn.Size = New Size(83, 30)
        rejectBtn.TabIndex = 2
        rejectBtn.Text = "Reject"
        rejectBtn.UseVisualStyleBackColor = False
        ' 
        ' reviewGrid
        ' 
        reviewGrid.BackgroundColor = Color.White
        reviewGrid.BorderStyle = BorderStyle.None
        reviewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        reviewGrid.Location = New Point(16, 35)
        reviewGrid.Name = "reviewGrid"
        reviewGrid.ReadOnly = True
        reviewGrid.Size = New Size(784, 146)
        reviewGrid.TabIndex = 3
        ' 
        ' acceptedGrid
        ' 
        acceptedGrid.BackgroundColor = Color.White
        acceptedGrid.BorderStyle = BorderStyle.None
        acceptedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        acceptedGrid.Location = New Point(22, 52)
        acceptedGrid.Name = "acceptedGrid"
        acceptedGrid.ReadOnly = True
        acceptedGrid.Size = New Size(860, 116)
        acceptedGrid.TabIndex = 4
        ' 
        ' schedLogBtn
        ' 
        schedLogBtn.BackColor = Color.Transparent
        schedLogBtn.BackgroundImage = CType(resources.GetObject("schedLogBtn.BackgroundImage"), Image)
        schedLogBtn.BackgroundImageLayout = ImageLayout.Stretch
        schedLogBtn.Cursor = Cursors.Hand
        schedLogBtn.FlatStyle = FlatStyle.Flat
        schedLogBtn.ForeColor = Color.White
        schedLogBtn.Location = New Point(811, 336)
        schedLogBtn.Name = "schedLogBtn"
        schedLogBtn.Size = New Size(83, 30)
        schedLogBtn.TabIndex = 5
        schedLogBtn.Text = "View Log"
        schedLogBtn.UseVisualStyleBackColor = False
        ' 
        ' acceptedLogPanel
        ' 
        acceptedLogPanel.BackColor = Color.Transparent
        acceptedLogPanel.BackgroundImage = CType(resources.GetObject("acceptedLogPanel.BackgroundImage"), Image)
        acceptedLogPanel.Controls.Add(Label2)
        acceptedLogPanel.Controls.Add(Label3)
        acceptedLogPanel.Controls.Add(Button1)
        acceptedLogPanel.Controls.Add(acceptedGrid2)
        acceptedLogPanel.Controls.Add(acceptedGrid)
        acceptedLogPanel.Controls.Add(Label1)
        acceptedLogPanel.Location = New Point(70, 162)
        acceptedLogPanel.Name = "acceptedLogPanel"
        acceptedLogPanel.Size = New Size(911, 373)
        acceptedLogPanel.TabIndex = 6
        acceptedLogPanel.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(56), CByte(15), CByte(12))
        Label2.Location = New Point(22, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(215, 21)
        Label2.TabIndex = 7
        Label2.Text = "COMPUTER LABORATORY 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(56), CByte(15), CByte(12))
        Label3.Location = New Point(22, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(215, 21)
        Label3.TabIndex = 8
        Label3.Text = "COMPUTER LABORATORY 1"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(410, 329)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 30)
        Button1.TabIndex = 6
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' acceptedGrid2
        ' 
        acceptedGrid2.BackgroundColor = Color.White
        acceptedGrid2.BorderStyle = BorderStyle.None
        acceptedGrid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        acceptedGrid2.Location = New Point(22, 200)
        acceptedGrid2.Name = "acceptedGrid2"
        acceptedGrid2.ReadOnly = True
        acceptedGrid2.Size = New Size(860, 116)
        acceptedGrid2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label1.Location = New Point(300, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(312, 32)
        Label1.TabIndex = 5
        Label1.Text = "ACCEPTED SCHEDULE LOG"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(1019, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(17, 19)
        Button2.TabIndex = 7
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.White
        Button3.Location = New Point(811, 307)
        Button3.Name = "Button3"
        Button3.Size = New Size(83, 30)
        Button3.TabIndex = 8
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(reviewGrid2)
        Panel1.Controls.Add(reviewGrid)
        Panel1.Controls.Add(acceptBtn2)
        Panel1.Controls.Add(acceptBtn)
        Panel1.Controls.Add(schedLogBtn)
        Panel1.Controls.Add(rejectBtn2)
        Panel1.Controls.Add(rejectBtn)
        Panel1.Location = New Point(70, 162)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(911, 373)
        Panel1.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(56), CByte(15), CByte(12))
        Label5.Location = New Point(16, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(215, 21)
        Label5.TabIndex = 6
        Label5.Text = "COMPUTER LABORATORY 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(56), CByte(15), CByte(12))
        Label4.Location = New Point(16, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(215, 21)
        Label4.TabIndex = 6
        Label4.Text = "COMPUTER LABORATORY 1"
        ' 
        ' reviewGrid2
        ' 
        reviewGrid2.BackgroundColor = Color.White
        reviewGrid2.BorderStyle = BorderStyle.None
        reviewGrid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        reviewGrid2.Location = New Point(16, 213)
        reviewGrid2.Name = "reviewGrid2"
        reviewGrid2.ReadOnly = True
        reviewGrid2.Size = New Size(784, 146)
        reviewGrid2.TabIndex = 3
        ' 
        ' acceptBtn2
        ' 
        acceptBtn2.BackColor = Color.Transparent
        acceptBtn2.BackgroundImage = CType(resources.GetObject("acceptBtn2.BackgroundImage"), Image)
        acceptBtn2.BackgroundImageLayout = ImageLayout.Stretch
        acceptBtn2.Cursor = Cursors.Hand
        acceptBtn2.FlatStyle = FlatStyle.Flat
        acceptBtn2.ForeColor = Color.White
        acceptBtn2.Location = New Point(811, 213)
        acceptBtn2.Name = "acceptBtn2"
        acceptBtn2.Size = New Size(83, 30)
        acceptBtn2.TabIndex = 1
        acceptBtn2.Text = "Accept"
        acceptBtn2.UseVisualStyleBackColor = False
        ' 
        ' rejectBtn2
        ' 
        rejectBtn2.BackColor = Color.Transparent
        rejectBtn2.BackgroundImage = CType(resources.GetObject("rejectBtn2.BackgroundImage"), Image)
        rejectBtn2.BackgroundImageLayout = ImageLayout.Stretch
        rejectBtn2.Cursor = Cursors.Hand
        rejectBtn2.FlatStyle = FlatStyle.Flat
        rejectBtn2.ForeColor = Color.White
        rejectBtn2.Location = New Point(811, 242)
        rejectBtn2.Name = "rejectBtn2"
        rejectBtn2.Size = New Size(83, 30)
        rejectBtn2.TabIndex = 2
        rejectBtn2.Text = "Reject"
        rejectBtn2.UseVisualStyleBackColor = False
        ' 
        ' ADMIN_DB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1050, 591)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Controls.Add(acceptedLogPanel)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ADMIN_DB"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMIN_DB"
        CType(reviewGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(acceptedGrid, ComponentModel.ISupportInitialize).EndInit()
        acceptedLogPanel.ResumeLayout(False)
        acceptedLogPanel.PerformLayout()
        CType(acceptedGrid2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(reviewGrid2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents acceptBtn As Button
    Friend WithEvents rejectBtn As Button
    Friend WithEvents approvedList As ListView
    Friend WithEvents reviewList As ListView
    Friend WithEvents review As ListBox
    Friend WithEvents approved As ListBox
    Friend WithEvents reviewGrid As DataGridView
    Friend WithEvents acceptedGrid As DataGridView
    Friend WithEvents schedLogBtn As Button
    Friend WithEvents acceptedLogPanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents acceptedGrid2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents reviewGrid2 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents acceptBtn2 As Button
    Friend WithEvents rejectBtn2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
