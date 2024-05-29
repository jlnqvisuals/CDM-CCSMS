<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NGD_Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NGD_Dashboard))
        Label1 = New Label()
        currentUser = New Label()
        logOutBtn = New Button()
        Button3 = New Button()
        ExitBTN = New Button()
        StudentID = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Castellar", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(281, 375)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 91)
        Label1.TabIndex = 1
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' currentUser
        ' 
        currentUser.BackColor = Color.Transparent
        currentUser.Font = New Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        currentUser.ForeColor = Color.Transparent
        currentUser.Location = New Point(95, 25)
        currentUser.Name = "currentUser"
        currentUser.Size = New Size(232, 35)
        currentUser.TabIndex = 2
        currentUser.Text = "User Name"
        ' 
        ' logOutBtn
        ' 
        logOutBtn.Location = New Point(1453, 9)
        logOutBtn.Name = "logOutBtn"
        logOutBtn.Size = New Size(75, 23)
        logOutBtn.TabIndex = 3
        logOutBtn.Text = "Log Out"
        logOutBtn.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.Transparent
        Button3.Location = New Point(1540, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(20, 19)
        Button3.TabIndex = 10
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ExitBTN
        ' 
        ExitBTN.BackColor = Color.Transparent
        ExitBTN.Cursor = Cursors.Hand
        ExitBTN.FlatAppearance.BorderSize = 0
        ExitBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        ExitBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        ExitBTN.FlatStyle = FlatStyle.Flat
        ExitBTN.ForeColor = Color.Transparent
        ExitBTN.Location = New Point(1595, 11)
        ExitBTN.Name = "ExitBTN"
        ExitBTN.Size = New Size(20, 19)
        ExitBTN.TabIndex = 9
        ExitBTN.UseVisualStyleBackColor = False
        ' 
        ' StudentID
        ' 
        StudentID.BackColor = Color.Transparent
        StudentID.Font = New Font("Poppins Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentID.ForeColor = Color.Transparent
        StudentID.Location = New Point(95, 50)
        StudentID.Name = "StudentID"
        StudentID.Size = New Size(232, 22)
        StudentID.TabIndex = 11
        StudentID.Text = "StudentID"
        ' 
        ' NGD_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1626, 927)
        Controls.Add(StudentID)
        Controls.Add(Button3)
        Controls.Add(ExitBTN)
        Controls.Add(logOutBtn)
        Controls.Add(currentUser)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "NGD_Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NGD"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents currentUser As Label
    Friend WithEvents logOutBtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ExitBTN As Button
    Friend WithEvents StudentID As Label
End Class
