<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDB_User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDB_User))
        currentUser = New Label()
        AboutBTN = New Button()
        ExitBTN = New Button()
        StudentID = New Label()
        MinBTN = New Button()
        Panel1 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        navigateBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Label3 = New Label()
        Label6 = New Label()
        Button4 = New Button()
        PictureBox1 = New PictureBox()
        DnT = New Timer(components)
        DateTime_Label = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' currentUser
        ' 
        currentUser.BackColor = Color.Transparent
        currentUser.FlatStyle = FlatStyle.Flat
        resources.ApplyResources(currentUser, "currentUser")
        currentUser.ForeColor = Color.FromArgb(CByte(224), CByte(253), CByte(43))
        currentUser.Name = "currentUser"
        ' 
        ' AboutBTN
        ' 
        AboutBTN.BackColor = Color.Transparent
        resources.ApplyResources(AboutBTN, "AboutBTN")
        AboutBTN.Cursor = Cursors.Hand
        AboutBTN.FlatAppearance.BorderColor = Color.FromArgb(CByte(40), CByte(27), CByte(2))
        AboutBTN.FlatAppearance.BorderSize = 0
        AboutBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        AboutBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        AboutBTN.ForeColor = Color.Transparent
        AboutBTN.Name = "AboutBTN"
        AboutBTN.UseVisualStyleBackColor = False
        ' 
        ' ExitBTN
        ' 
        ExitBTN.BackColor = Color.Transparent
        resources.ApplyResources(ExitBTN, "ExitBTN")
        ExitBTN.Cursor = Cursors.Hand
        ExitBTN.FlatAppearance.BorderColor = Color.FromArgb(CByte(40), CByte(27), CByte(2))
        ExitBTN.FlatAppearance.BorderSize = 0
        ExitBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        ExitBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        ExitBTN.ForeColor = Color.Transparent
        ExitBTN.Name = "ExitBTN"
        ExitBTN.UseVisualStyleBackColor = False
        ' 
        ' StudentID
        ' 
        StudentID.BackColor = Color.Transparent
        StudentID.FlatStyle = FlatStyle.Flat
        resources.ApplyResources(StudentID, "StudentID")
        StudentID.ForeColor = Color.Transparent
        StudentID.Name = "StudentID"
        ' 
        ' MinBTN
        ' 
        MinBTN.BackColor = Color.Transparent
        resources.ApplyResources(MinBTN, "MinBTN")
        MinBTN.Cursor = Cursors.Hand
        MinBTN.FlatAppearance.BorderColor = Color.FromArgb(CByte(40), CByte(27), CByte(2))
        MinBTN.FlatAppearance.BorderSize = 0
        MinBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        MinBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        MinBTN.ForeColor = Color.Transparent
        MinBTN.Name = "MinBTN"
        MinBTN.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.BackColor = Color.Transparent
        Panel1.Name = "Panel1"
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.FlatStyle = FlatStyle.Flat
        resources.ApplyResources(Label4, "Label4")
        Label4.ForeColor = Color.White
        Label4.Name = "Label4"
        ' 
        ' Label5
        ' 
        resources.ApplyResources(Label5, "Label5")
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.FromArgb(CByte(224), CByte(253), CByte(43))
        Label5.Name = "Label5"
        ' 
        ' navigateBtn
        ' 
        navigateBtn.BackColor = Color.Transparent
        resources.ApplyResources(navigateBtn, "navigateBtn")
        navigateBtn.Cursor = Cursors.Hand
        navigateBtn.FlatAppearance.BorderSize = 0
        navigateBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        navigateBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        navigateBtn.Name = "navigateBtn"
        navigateBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        resources.ApplyResources(Label1, "Label1")
        Label1.ForeColor = Color.White
        Label1.Name = "Label1"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(253), CByte(43))
        Label2.Name = "Label2"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        resources.ApplyResources(Button2, "Button2")
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.Name = "Button2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Flat
        resources.ApplyResources(Label3, "Label3")
        Label3.ForeColor = Color.White
        Label3.Name = "Label3"
        ' 
        ' Label6
        ' 
        resources.ApplyResources(Label6, "Label6")
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.FromArgb(CByte(224), CByte(253), CByte(43))
        Label6.Name = "Label6"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        resources.ApplyResources(Button4, "Button4")
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button4.Name = "Button4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' DnT
        ' 
        DnT.Enabled = True
        DnT.Interval = 1000
        ' 
        ' DateTime_Label
        ' 
        resources.ApplyResources(DateTime_Label, "DateTime_Label")
        DateTime_Label.BackColor = Color.Transparent
        DateTime_Label.FlatStyle = FlatStyle.Flat
        DateTime_Label.ForeColor = Color.White
        DateTime_Label.Name = "DateTime_Label"
        ' 
        ' MainDB_User
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        resources.ApplyResources(Me, "$this")
        Controls.Add(DateTime_Label)
        Controls.Add(PictureBox1)
        Controls.Add(StudentID)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(navigateBtn)
        Controls.Add(Panel1)
        Controls.Add(MinBTN)
        Controls.Add(currentUser)
        Controls.Add(AboutBTN)
        Controls.Add(ExitBTN)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "MainDB_User"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents currentUser As Label
    Friend WithEvents AboutBTN As Button
    Friend WithEvents ExitBTN As Button
    Friend WithEvents StudentID As Label
    Friend WithEvents MinBTN As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents navigateBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DnT As Timer
    Friend WithEvents DateTime_Label As Label
End Class
