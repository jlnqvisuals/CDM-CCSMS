﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Button2 = New Button()
        DnT = New Timer(components)
        DateTime_Label = New Label()
        logoutMdbBtn = New Button()
        navigateBtn = New Button()
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
        ' logoutMdbBtn
        ' 
        logoutMdbBtn.BackColor = Color.Transparent
        resources.ApplyResources(logoutMdbBtn, "logoutMdbBtn")
        logoutMdbBtn.Cursor = Cursors.Hand
        logoutMdbBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        logoutMdbBtn.FlatAppearance.BorderSize = 0
        logoutMdbBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        logoutMdbBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        logoutMdbBtn.Name = "logoutMdbBtn"
        logoutMdbBtn.UseVisualStyleBackColor = False
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
        ' MainDB_User
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        resources.ApplyResources(Me, "$this")
        Controls.Add(logoutMdbBtn)
        Controls.Add(DateTime_Label)
        Controls.Add(Button2)
        Controls.Add(navigateBtn)
        Controls.Add(Panel1)
        Controls.Add(MinBTN)
        Controls.Add(AboutBTN)
        Controls.Add(ExitBTN)
        Controls.Add(currentUser)
        Controls.Add(StudentID)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "MainDB_User"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents currentUser As Label
    Friend WithEvents AboutBTN As Button
    Friend WithEvents ExitBTN As Button
    Friend WithEvents StudentID As Label
    Friend WithEvents MinBTN As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents DnT As Timer
    Friend WithEvents DateTime_Label As Label
    Friend WithEvents logoutMdbBtn As Button
    Friend WithEvents navigateBtn As Button
End Class
