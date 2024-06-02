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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN_PAGE))
        regFirstName = New TextBox()
        regSID = New TextBox()
        logUser = New TextBox()
        logPass = New TextBox()
        regBtn = New Button()
        loginBtn = New Button()
        loginPanel = New Panel()
        GuestBTN = New Button()
        Button1 = New Button()
        showRegBtn = New Button()
        showLoginBtn = New Button()
        regPanel = New Panel()
        passMatchIdentifier = New Label()
        regShowPass = New Button()
        regConfirmPass = New TextBox()
        regPass = New TextBox()
        regEmail = New TextBox()
        regLastName = New TextBox()
        regHidePass = New Button()
        regHideConPass = New Button()
        regShowConPass = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        PrivacyPolicyBTN = New Button()
        TnC_BTN = New Button()
        ContactsBTN = New Button()
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        loginPanel.SuspendLayout()
        regPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' regFirstName
        ' 
        regFirstName.BorderStyle = BorderStyle.None
        regFirstName.Cursor = Cursors.IBeam
        regFirstName.Font = New Font("Microsoft Sans Serif", 9F)
        regFirstName.ForeColor = Color.Gray
        regFirstName.Location = New Point(49, 86)
        regFirstName.MaxLength = 50
        regFirstName.Name = "regFirstName"
        regFirstName.Size = New Size(89, 14)
        regFirstName.TabIndex = 0
        regFirstName.Text = "First Name"
        ' 
        ' regSID
        ' 
        regSID.BorderStyle = BorderStyle.None
        regSID.Cursor = Cursors.IBeam
        regSID.Font = New Font("Microsoft Sans Serif", 9F)
        regSID.ForeColor = Color.Gray
        regSID.Location = New Point(184, 127)
        regSID.MaxLength = 8
        regSID.Name = "regSID"
        regSID.Size = New Size(70, 14)
        regSID.TabIndex = 0
        regSID.Text = "XX-XXXXX"
        ' 
        ' logUser
        ' 
        logUser.BorderStyle = BorderStyle.None
        logUser.Cursor = Cursors.IBeam
        logUser.ForeColor = Color.Gray
        logUser.Location = New Point(53, 86)
        logUser.Name = "logUser"
        logUser.Size = New Size(192, 16)
        logUser.TabIndex = 0
        logUser.Text = "Student ID (XX-XXXXX)"
        ' 
        ' logPass
        ' 
        logPass.BorderStyle = BorderStyle.None
        logPass.Cursor = Cursors.IBeam
        logPass.ForeColor = Color.Gray
        logPass.Location = New Point(53, 126)
        logPass.Name = "logPass"
        logPass.PasswordChar = "•"c
        logPass.Size = New Size(193, 16)
        logPass.TabIndex = 0
        logPass.Text = "Password"
        ' 
        ' regBtn
        ' 
        regBtn.Cursor = Cursors.Hand
        regBtn.FlatAppearance.BorderSize = 0
        regBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        regBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        regBtn.FlatStyle = FlatStyle.Flat
        regBtn.ForeColor = Color.Transparent
        regBtn.Location = New Point(50, 265)
        regBtn.Name = "regBtn"
        regBtn.Size = New Size(87, 21)
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
        loginBtn.Location = New Point(45, 194)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(96, 20)
        loginBtn.TabIndex = 2
        loginBtn.UseVisualStyleBackColor = True
        ' 
        ' loginPanel
        ' 
        loginPanel.BackColor = Color.Transparent
        loginPanel.BackgroundImage = CType(resources.GetObject("loginPanel.BackgroundImage"), Image)
        loginPanel.BackgroundImageLayout = ImageLayout.Stretch
        loginPanel.Controls.Add(GuestBTN)
        loginPanel.Controls.Add(Button1)
        loginPanel.Controls.Add(logUser)
        loginPanel.Controls.Add(showRegBtn)
        loginPanel.Controls.Add(loginBtn)
        loginPanel.Controls.Add(logPass)
        loginPanel.Location = New Point(377, 174)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(297, 312)
        loginPanel.TabIndex = 3
        ' 
        ' GuestBTN
        ' 
        GuestBTN.BackColor = Color.Transparent
        GuestBTN.Cursor = Cursors.Hand
        GuestBTN.FlatAppearance.BorderSize = 0
        GuestBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        GuestBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        GuestBTN.FlatStyle = FlatStyle.Flat
        GuestBTN.ForeColor = Color.Transparent
        GuestBTN.Location = New Point(47, 255)
        GuestBTN.Name = "GuestBTN"
        GuestBTN.Size = New Size(201, 23)
        GuestBTN.TabIndex = 11
        GuestBTN.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(41, 163)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 10)
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
        showRegBtn.Location = New Point(159, 194)
        showRegBtn.Name = "showRegBtn"
        showRegBtn.Size = New Size(95, 20)
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
        showLoginBtn.Location = New Point(163, 265)
        showLoginBtn.Name = "showLoginBtn"
        showLoginBtn.Size = New Size(87, 21)
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
        regPanel.Controls.Add(regShowConPass)
        regPanel.Location = New Point(377, 174)
        regPanel.Name = "regPanel"
        regPanel.Size = New Size(297, 312)
        regPanel.TabIndex = 4
        ' 
        ' passMatchIdentifier
        ' 
        passMatchIdentifier.AutoSize = True
        passMatchIdentifier.Font = New Font("Segoe UI", 8F)
        passMatchIdentifier.ForeColor = Color.FromArgb(CByte(87), CByte(82), CByte(17))
        passMatchIdentifier.Location = New Point(47, 235)
        passMatchIdentifier.Name = "passMatchIdentifier"
        passMatchIdentifier.Size = New Size(85, 13)
        passMatchIdentifier.TabIndex = 6
        passMatchIdentifier.Text = "*Required field"
        ' 
        ' regShowPass
        ' 
        regShowPass.BackgroundImage = CType(resources.GetObject("regShowPass.BackgroundImage"), Image)
        regShowPass.BackgroundImageLayout = ImageLayout.Stretch
        regShowPass.FlatAppearance.BorderSize = 0
        regShowPass.FlatAppearance.MouseDownBackColor = Color.Transparent
        regShowPass.FlatAppearance.MouseOverBackColor = Color.Transparent
        regShowPass.FlatStyle = FlatStyle.Flat
        regShowPass.Location = New Point(234, 166)
        regShowPass.Name = "regShowPass"
        regShowPass.Size = New Size(16, 16)
        regShowPass.TabIndex = 5
        regShowPass.UseVisualStyleBackColor = True
        ' 
        ' regConfirmPass
        ' 
        regConfirmPass.BorderStyle = BorderStyle.None
        regConfirmPass.Cursor = Cursors.IBeam
        regConfirmPass.Font = New Font("Microsoft Sans Serif", 9F)
        regConfirmPass.ForeColor = Color.Gray
        regConfirmPass.Location = New Point(49, 207)
        regConfirmPass.MaxLength = 100
        regConfirmPass.Name = "regConfirmPass"
        regConfirmPass.Size = New Size(184, 14)
        regConfirmPass.TabIndex = 4
        regConfirmPass.Text = "Confirm Password"
        ' 
        ' regPass
        ' 
        regPass.BorderStyle = BorderStyle.None
        regPass.Cursor = Cursors.IBeam
        regPass.Font = New Font("Microsoft Sans Serif", 9F)
        regPass.ForeColor = Color.Gray
        regPass.Location = New Point(49, 167)
        regPass.MaxLength = 100
        regPass.Name = "regPass"
        regPass.Size = New Size(184, 14)
        regPass.TabIndex = 4
        regPass.Text = "Password"
        ' 
        ' regEmail
        ' 
        regEmail.BorderStyle = BorderStyle.None
        regEmail.Cursor = Cursors.IBeam
        regEmail.Font = New Font("Microsoft Sans Serif", 9F)
        regEmail.ForeColor = Color.Gray
        regEmail.Location = New Point(49, 127)
        regEmail.MaxLength = 100
        regEmail.Name = "regEmail"
        regEmail.Size = New Size(117, 14)
        regEmail.TabIndex = 3
        regEmail.Text = "Email"
        ' 
        ' regLastName
        ' 
        regLastName.BorderStyle = BorderStyle.None
        regLastName.Cursor = Cursors.IBeam
        regLastName.Font = New Font("Microsoft Sans Serif", 9F)
        regLastName.ForeColor = Color.Gray
        regLastName.Location = New Point(162, 86)
        regLastName.MaxLength = 50
        regLastName.Name = "regLastName"
        regLastName.Size = New Size(92, 14)
        regLastName.TabIndex = 0
        regLastName.Text = "Last Name"
        ' 
        ' regHidePass
        ' 
        regHidePass.BackgroundImage = CType(resources.GetObject("regHidePass.BackgroundImage"), Image)
        regHidePass.BackgroundImageLayout = ImageLayout.Stretch
        regHidePass.FlatAppearance.BorderSize = 0
        regHidePass.FlatAppearance.MouseDownBackColor = Color.Transparent
        regHidePass.FlatAppearance.MouseOverBackColor = Color.Transparent
        regHidePass.FlatStyle = FlatStyle.Flat
        regHidePass.Location = New Point(234, 166)
        regHidePass.Name = "regHidePass"
        regHidePass.Size = New Size(16, 16)
        regHidePass.TabIndex = 5
        regHidePass.UseVisualStyleBackColor = True
        ' 
        ' regHideConPass
        ' 
        regHideConPass.BackgroundImage = CType(resources.GetObject("regHideConPass.BackgroundImage"), Image)
        regHideConPass.BackgroundImageLayout = ImageLayout.Stretch
        regHideConPass.FlatAppearance.BorderSize = 0
        regHideConPass.FlatAppearance.MouseDownBackColor = Color.Transparent
        regHideConPass.FlatAppearance.MouseOverBackColor = Color.Transparent
        regHideConPass.FlatStyle = FlatStyle.Flat
        regHideConPass.Location = New Point(234, 206)
        regHideConPass.Name = "regHideConPass"
        regHideConPass.Size = New Size(16, 16)
        regHideConPass.TabIndex = 5
        regHideConPass.Text = "H"
        regHideConPass.UseVisualStyleBackColor = True
        ' 
        ' regShowConPass
        ' 
        regShowConPass.BackgroundImage = CType(resources.GetObject("regShowConPass.BackgroundImage"), Image)
        regShowConPass.BackgroundImageLayout = ImageLayout.Stretch
        regShowConPass.FlatAppearance.BorderSize = 0
        regShowConPass.FlatAppearance.MouseDownBackColor = Color.Transparent
        regShowConPass.FlatAppearance.MouseOverBackColor = Color.Transparent
        regShowConPass.FlatStyle = FlatStyle.Flat
        regShowConPass.Location = New Point(234, 206)
        regShowConPass.Name = "regShowConPass"
        regShowConPass.Size = New Size(16, 16)
        regShowConPass.TabIndex = 5
        regShowConPass.Text = "S"
        regShowConPass.UseVisualStyleBackColor = True
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
        Button2.Location = New Point(1022, 13)
        Button2.Name = "Button2"
        Button2.Size = New Size(13, 15)
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
        Button3.Location = New Point(969, 15)
        Button3.Name = "Button3"
        Button3.Size = New Size(10, 11)
        Button3.TabIndex = 6
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = Color.Transparent
        Button4.Location = New Point(995, 14)
        Button4.Name = "Button4"
        Button4.Size = New Size(12, 12)
        Button4.TabIndex = 7
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PrivacyPolicyBTN
        ' 
        PrivacyPolicyBTN.BackColor = Color.Transparent
        PrivacyPolicyBTN.Cursor = Cursors.Hand
        PrivacyPolicyBTN.FlatAppearance.BorderSize = 0
        PrivacyPolicyBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        PrivacyPolicyBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        PrivacyPolicyBTN.FlatStyle = FlatStyle.Flat
        PrivacyPolicyBTN.ForeColor = Color.Transparent
        PrivacyPolicyBTN.Location = New Point(41, 27)
        PrivacyPolicyBTN.Name = "PrivacyPolicyBTN"
        PrivacyPolicyBTN.Size = New Size(73, 10)
        PrivacyPolicyBTN.TabIndex = 8
        PrivacyPolicyBTN.UseVisualStyleBackColor = False
        ' 
        ' TnC_BTN
        ' 
        TnC_BTN.BackColor = Color.Transparent
        TnC_BTN.Cursor = Cursors.Hand
        TnC_BTN.FlatAppearance.BorderSize = 0
        TnC_BTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        TnC_BTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        TnC_BTN.FlatStyle = FlatStyle.Flat
        TnC_BTN.ForeColor = Color.Transparent
        TnC_BTN.Location = New Point(139, 27)
        TnC_BTN.Name = "TnC_BTN"
        TnC_BTN.Size = New Size(100, 10)
        TnC_BTN.TabIndex = 9
        TnC_BTN.UseVisualStyleBackColor = False
        ' 
        ' ContactsBTN
        ' 
        ContactsBTN.BackColor = Color.Transparent
        ContactsBTN.Cursor = Cursors.Hand
        ContactsBTN.FlatAppearance.BorderSize = 0
        ContactsBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        ContactsBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        ContactsBTN.FlatStyle = FlatStyle.Flat
        ContactsBTN.ForeColor = Color.Transparent
        ContactsBTN.Location = New Point(261, 27)
        ContactsBTN.Name = "ContactsBTN"
        ContactsBTN.Size = New Size(53, 10)
        ContactsBTN.TabIndex = 10
        ContactsBTN.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(326, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(399, 530)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Poppins", 10F)
        TextBox1.Location = New Point(758, 208)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(249, 187)
        TextBox1.TabIndex = 12
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' LOGIN_PAGE
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1050, 591)
        Controls.Add(TextBox1)
        Controls.Add(ContactsBTN)
        Controls.Add(TnC_BTN)
        Controls.Add(PrivacyPolicyBTN)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(loginPanel)
        Controls.Add(regPanel)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LOGIN_PAGE"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CDM CCSMS"
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        regPanel.ResumeLayout(False)
        regPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents Button4 As Button
    Friend WithEvents PrivacyPolicyBTN As Button
    Friend WithEvents TnC_BTN As Button
    Friend WithEvents ContactsBTN As Button
    Friend WithEvents GuestBTN As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox

End Class
