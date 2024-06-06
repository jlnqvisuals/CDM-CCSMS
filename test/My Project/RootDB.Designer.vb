<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RootDB
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RootDB))
        accountGrid = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        DateTime_Label = New Label()
        DnT = New Timer(components)
        MinBTN = New Button()
        ExitBTN = New Button()
        Button3 = New Button()
        CType(accountGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' accountGrid
        ' 
        accountGrid.BackgroundColor = Color.White
        accountGrid.BorderStyle = BorderStyle.None
        accountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        accountGrid.GridColor = Color.White
        accountGrid.Location = New Point(67, 121)
        accountGrid.Name = "accountGrid"
        accountGrid.Size = New Size(742, 412)
        accountGrid.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.CheckedBackColor = Color.Transparent
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(878, 358)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 21)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.CheckedBackColor = Color.Transparent
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(878, 469)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 21)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DateTime_Label
        ' 
        DateTime_Label.AutoSize = True
        DateTime_Label.BackColor = Color.Transparent
        DateTime_Label.FlatStyle = FlatStyle.Flat
        DateTime_Label.Font = New Font("Arial", 15F, FontStyle.Bold)
        DateTime_Label.ForeColor = Color.White
        DateTime_Label.ImeMode = ImeMode.NoControl
        DateTime_Label.Location = New Point(46, 64)
        DateTime_Label.Name = "DateTime_Label"
        DateTime_Label.Size = New Size(323, 24)
        DateTime_Label.TabIndex = 46
        DateTime_Label.Text = "Tuesday - June 04 2024 11:28 am"
        ' 
        ' DnT
        ' 
        DnT.Enabled = True
        DnT.Interval = 1000
        ' 
        ' MinBTN
        ' 
        MinBTN.BackColor = Color.Transparent
        MinBTN.BackgroundImage = CType(resources.GetObject("MinBTN.BackgroundImage"), Image)
        MinBTN.Cursor = Cursors.Hand
        MinBTN.FlatAppearance.BorderColor = Color.FromArgb(CByte(40), CByte(27), CByte(2))
        MinBTN.FlatAppearance.BorderSize = 0
        MinBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        MinBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        MinBTN.FlatStyle = FlatStyle.Flat
        MinBTN.ForeColor = Color.Transparent
        MinBTN.ImeMode = ImeMode.NoControl
        MinBTN.Location = New Point(992, 11)
        MinBTN.Name = "MinBTN"
        MinBTN.Size = New Size(20, 20)
        MinBTN.TabIndex = 48
        MinBTN.UseVisualStyleBackColor = False
        ' 
        ' ExitBTN
        ' 
        ExitBTN.BackColor = Color.Transparent
        ExitBTN.BackgroundImage = CType(resources.GetObject("ExitBTN.BackgroundImage"), Image)
        ExitBTN.BackgroundImageLayout = ImageLayout.None
        ExitBTN.Cursor = Cursors.Hand
        ExitBTN.FlatAppearance.BorderColor = Color.FromArgb(CByte(40), CByte(27), CByte(2))
        ExitBTN.FlatAppearance.BorderSize = 0
        ExitBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        ExitBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        ExitBTN.FlatStyle = FlatStyle.Flat
        ExitBTN.ForeColor = Color.Transparent
        ExitBTN.ImeMode = ImeMode.NoControl
        ExitBTN.Location = New Point(1018, 11)
        ExitBTN.Name = "ExitBTN"
        ExitBTN.Size = New Size(20, 20)
        ExitBTN.TabIndex = 47
        ExitBTN.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.CheckedBackColor = Color.Transparent
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(878, 507)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 21)
        Button3.TabIndex = 49
        Button3.UseVisualStyleBackColor = False
        ' 
        ' RootDB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1050, 591)
        Controls.Add(Button3)
        Controls.Add(MinBTN)
        Controls.Add(ExitBTN)
        Controls.Add(DateTime_Label)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(accountGrid)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "RootDB"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RootDB"
        CType(accountGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents accountGrid As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DateTime_Label As Label
    Friend WithEvents DnT As Timer
    Friend WithEvents MinBTN As Button
    Friend WithEvents ExitBTN As Button
    Friend WithEvents Button3 As Button
End Class
