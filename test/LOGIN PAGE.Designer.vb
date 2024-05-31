<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN_PAGE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN_PAGE))
        regFirstName = New TextBox()
        regSID = New TextBox()
        logUser = New TextBox()
        logPass = New TextBox()
        regBtn = New Button()
        loginBtn = New Button()
        loginPanel = New Panel()
        Button1 = New Button()
        showRegBtn = New Button()
        showLoginBtn = New Button()
        regPanel = New Panel()
        passMatchIdentifier = New Label()
        regShowConPass = New Button()
        regShowPass = New Button()
        regConfirmPass = New TextBox()
        regPass = New TextBox()
        regEmail = New TextBox()
        regLastName = New TextBox()
        regHidePass = New Button()
        regHideConPass = New Button()
        Button2 = New Button()
        Button3 = New Button()
        loginPanel.SuspendLayout()
        regPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' regFirstName
        ' 
        regFirstName.BorderStyle = BorderStyle.None
        regFirstName.Cursor = Cursors.IBeam
        regFirstName.Font = New Font("Microsoft Sans Serif", 9F)
        regFirstName.ForeColor = Color.Black
        regFirstName.Location = New Point(70, 103)
        regFirstName.MaxLength = 50
        regFirstName.Name = "regFirstName"
        regFirstName.Size = New Size(86, 14)
        regFirstName.TabIndex = 0
        ' 
        ' regSID
        ' 
        regSID.BorderStyle = BorderStyle.None
        regSID.Cursor = Cursors.IBeam
        regSID.Font = New Font("Microsoft Sans Serif", 9F)
        regSID.ForeColor = Color.Black
        regSID.Location = New Point(198, 155)
        regSID.MaxLength = 8
        regSID.Name = "regSID"
        regSID.Size = New Size(70, 14)
        regSID.TabIndex = 0
        ' 
        ' logUser
        ' 
        logUser.BorderStyle = BorderStyle.None
        logUser.Cursor = Cursors.IBeam
        logUser.Location = New Point(45, 101)
        logUser.Name = "logUser"
        logUser.Size = New Size(192, 16)
        logUser.TabIndex = 0
        ' 
        ' logPass
        ' 
        logPass.BorderStyle = BorderStyle.None
        logPass.Cursor = Cursors.IBeam
        logPass.Location = New Point(45, 155)
        logPass.Name = "logPass"
        logPass.PasswordChar = "•"c
        logPass.Size = New Size(173, 16)
        logPass.TabIndex = 0
        ' 
        ' regBtn
        ' 
        regBtn.Cursor = Cursors.Hand
        regBtn.FlatAppearance.BorderSize = 0
        regBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        regBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        regBtn.FlatStyle = FlatStyle.Flat
        regBtn.ForeColor = Color.Transparent
        regBtn.Location = New Point(59, 318)
        regBtn.Name = "regBtn"
        regBtn.Size = New Size(107, 26)
        regBtn.TabIndex = 2
        regBtn.Text = " "
        regBtn.UseVisualStyleBackColor = True
        ' 
        ' loginBtn
        ' 
        loginBtn.Cursor = Cursors.Hand
        loginBtn.FlatAppearance.BorderSize = 0
        loginBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        loginBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        loginBtn.FlatStyle = FlatStyle.Flat
        loginBtn.ForeColor = Color.Transparent
        loginBtn.Location = New Point(36, 219)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(101, 28)
        loginBtn.TabIndex = 2
        loginBtn.UseVisualStyleBackColor = True
        ' 
        ' loginPanel
        ' 
        loginPanel.BackColor = Color.Transparent
        loginPanel.BackgroundImage = CType(resources.GetObject("loginPanel.BackgroundImage"), Image)
        loginPanel.BackgroundImageLayout = ImageLayout.Stretch
        loginPanel.Controls.Add(Button1)
        loginPanel.Controls.Add(logUser)
        loginPanel.Controls.Add(showRegBtn)
        loginPanel.Controls.Add(loginBtn)
        loginPanel.Controls.Add(logPass)
        loginPanel.Location = New Point(383, 160)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(282, 332)
        loginPanel.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(38, 186)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 15)
        Button1.TabIndex = 4
        Button1.UseVisualStyleBackColor = True
        ' 
        ' showRegBtn
        ' 
        showRegBtn.Cursor = Cursors.Hand
        showRegBtn.FlatAppearance.BorderSize = 0
        showRegBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        showRegBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        showRegBtn.FlatStyle = FlatStyle.Flat
        showRegBtn.ForeColor = Color.Transparent
        showRegBtn.Location = New Point(146, 219)
        showRegBtn.Name = "showRegBtn"
        showRegBtn.Size = New Size(100, 28)
        showRegBtn.TabIndex = 3
        showRegBtn.UseVisualStyleBackColor = True
        ' 
        ' showLoginBtn
        ' 
        showLoginBtn.Cursor = Cursors.Hand
        showLoginBtn.FlatAppearance.BorderSize = 0
        showLoginBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        showLoginBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        showLoginBtn.FlatStyle = FlatStyle.Flat
        showLoginBtn.ForeColor = Color.Transparent
        showLoginBtn.Location = New Point(172, 318)
        showLoginBtn.Name = "showLoginBtn"
        showLoginBtn.Size = New Size(107, 26)
        showLoginBtn.TabIndex = 4
        showLoginBtn.Text = " "
        showLoginBtn.UseVisualStyleBackColor = True
        ' 
        ' regPanel
        ' 
        regPanel.BackColor = Color.Transparent
        regPanel.BackgroundImage = CType(resources.GetObject("regPanel.BackgroundImage"), Image)
        regPanel.BackgroundImageLayout = ImageLayout.Stretch
        regPanel.Controls.Add(passMatchIdentifier)
        regPanel.Controls.Add(showLoginBtn)
        regPanel.Controls.Add(regShowConPass)
        regPanel.Controls.Add(regShowPass)
        regPanel.Controls.Add(regConfirmPass)
        regPanel.Controls.Add(regPass)
        regPanel.Controls.Add(regEmail)
        regPanel.Controls.Add(regSID)
        regPanel.Controls.Add(regLastName)
        regPanel.Controls.Add(regFirstName)
        regPanel.Controls.Add(regBtn)
        regPanel.Controls.Add(regHidePass)
        regPanel.Controls.Add(regHideConPass)
        regPanel.Location = New Point(354, 159)
        regPanel.Name = "regPanel"
        regPanel.Size = New Size(342, 364)
        regPanel.TabIndex = 4
        ' 
        ' passMatchIdentifier
        ' 
        passMatchIdentifier.AutoSize = True
        passMatchIdentifier.ForeColor = Color.RoyalBlue
        passMatchIdentifier.Location = New Point(64, 288)
        passMatchIdentifier.Name = "passMatchIdentifier"
        passMatchIdentifier.Size = New Size(62, 15)
        passMatchIdentifier.TabIndex = 6
        passMatchIdentifier.Text = "(Required)"
        ' 
        ' regShowConPass
        ' 
        regShowConPass.Location = New Point(273, 253)
        regShowConPass.Name = "regShowConPass"
        regShowConPass.Size = New Size(17, 25)
        regShowConPass.TabIndex = 5
        regShowConPass.Text = "S"
        regShowConPass.UseVisualStyleBackColor = True
        ' 
        ' regShowPass
        ' 
        regShowPass.Location = New Point(273, 203)
        regShowPass.Name = "regShowPass"
        regShowPass.Size = New Size(17, 23)
        regShowPass.TabIndex = 5
        regShowPass.Text = "S"
        regShowPass.UseVisualStyleBackColor = True
        ' 
        ' regConfirmPass
        ' 
        regConfirmPass.BorderStyle = BorderStyle.None
        regConfirmPass.Cursor = Cursors.IBeam
        regConfirmPass.Font = New Font("Microsoft Sans Serif", 9F)
        regConfirmPass.ForeColor = Color.Black
        regConfirmPass.Location = New Point(70, 258)
        regConfirmPass.MaxLength = 100
        regConfirmPass.Name = "regConfirmPass"
        regConfirmPass.Size = New Size(170, 14)
        regConfirmPass.TabIndex = 4
        ' 
        ' regPass
        ' 
        regPass.BorderStyle = BorderStyle.None
        regPass.Cursor = Cursors.IBeam
        regPass.Font = New Font("Microsoft Sans Serif", 9F)
        regPass.ForeColor = Color.Black
        regPass.Location = New Point(70, 206)
        regPass.MaxLength = 100
        regPass.Name = "regPass"
        regPass.Size = New Size(170, 14)
        regPass.TabIndex = 4
        ' 
        ' regEmail
        ' 
        regEmail.BorderStyle = BorderStyle.None
        regEmail.Cursor = Cursors.IBeam
        regEmail.Font = New Font("Microsoft Sans Serif", 9F)
        regEmail.ForeColor = Color.Black
        regEmail.Location = New Point(70, 155)
        regEmail.MaxLength = 100
        regEmail.Name = "regEmail"
        regEmail.Size = New Size(103, 14)
        regEmail.TabIndex = 3
        ' 
        ' regLastName
        ' 
        regLastName.BorderStyle = BorderStyle.None
        regLastName.Cursor = Cursors.IBeam
        regLastName.Font = New Font("Microsoft Sans Serif", 9F)
        regLastName.ForeColor = Color.Black
        regLastName.Location = New Point(182, 103)
        regLastName.MaxLength = 50
        regLastName.Name = "regLastName"
        regLastName.Size = New Size(86, 14)
        regLastName.TabIndex = 0
        ' 
        ' regHidePass
        ' 
        regHidePass.Location = New Point(250, 203)
        regHidePass.Name = "regHidePass"
        regHidePass.Size = New Size(17, 23)
        regHidePass.TabIndex = 5
        regHidePass.Text = "H"
        regHidePass.UseVisualStyleBackColor = True
        ' 
        ' regHideConPass
        ' 
        regHideConPass.Location = New Point(250, 253)
        regHideConPass.Name = "regHideConPass"
        regHideConPass.Size = New Size(17, 25)
        regHideConPass.TabIndex = 5
        regHideConPass.Text = "H"
        regHideConPass.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(1018, 11)
        Button2.Name = "Button2"
        Button2.Size = New Size(20, 19)
        Button2.TabIndex = 5
        Button2.UseVisualStyleBackColor = False
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
        Button3.Location = New Point(963, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(20, 19)
        Button3.TabIndex = 6
        Button3.UseVisualStyleBackColor = False
        ' 
        ' LOGIN_PAGE
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1050, 591)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(loginPanel)
        Controls.Add(regPanel)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "LOGIN_PAGE"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        regPanel.ResumeLayout(False)
        regPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents regFirstName As TextBox
    Friend WithEvents regSID As TextBox
    Friend WithEvents logUser As TextBox
    Friend WithEvents logPass As TextBox
    Friend WithEvents regBtn As Button
    Friend WithEvents loginBtn As Button
    Friend WithEvents loginPanel As Panel
    Friend WithEvents regPanel As Panel
    Friend WithEvents showLoginBtn As Button
    Friend WithEvents showRegBtn As Button
    Friend WithEvents regLastName As TextBox
    Friend WithEvents regConfirmPass As TextBox
    Friend WithEvents regPass As TextBox
    Friend WithEvents regShowConPass As Button
    Friend WithEvents regShowPass As Button
    Friend WithEvents regHidePass As Button
    Friend WithEvents regHideConPass As Button
    Friend WithEvents passMatchIdentifier As Label
    Public WithEvents regEmail As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
