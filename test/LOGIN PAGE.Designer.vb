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
        regFirstName = New TextBox()
        regSID = New TextBox()
        Label1 = New Label()
        logUser = New TextBox()
        logPass = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        regBtn = New Button()
        loginBtn = New Button()
        loginPanel = New Panel()
        forgotBtn = New Button()
        showLoginBtn = New Button()
        showRegBtn = New Button()
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
        loginPanel.SuspendLayout()
        regPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' regFirstName
        ' 
        regFirstName.Location = New Point(166, 35)
        regFirstName.MaxLength = 50
        regFirstName.Name = "regFirstName"
        regFirstName.Size = New Size(135, 23)
        regFirstName.TabIndex = 0
        regFirstName.Text = "First Name"
        ' 
        ' regSID
        ' 
        regSID.Location = New Point(342, 64)
        regSID.MaxLength = 8
        regSID.Name = "regSID"
        regSID.Size = New Size(100, 23)
        regSID.TabIndex = 0
        regSID.Text = "SID (EX. 24-12345)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(268, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 15)
        Label1.TabIndex = 1
        Label1.Text = "REGISTER"
        ' 
        ' logUser
        ' 
        logUser.Location = New Point(262, 83)
        logUser.Name = "logUser"
        logUser.Size = New Size(100, 23)
        logUser.TabIndex = 0
        ' 
        ' logPass
        ' 
        logPass.Location = New Point(262, 131)
        logPass.Name = "logPass"
        logPass.PasswordChar = "•"c
        logPass.Size = New Size(100, 23)
        logPass.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(278, 54)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 1
        Label4.Text = "LOGIN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(193, 86)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 1
        Label5.Text = "Student ID:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(196, 134)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 15)
        Label6.TabIndex = 1
        Label6.Text = "Password:"
        ' 
        ' regBtn
        ' 
        regBtn.Location = New Point(261, 166)
        regBtn.Name = "regBtn"
        regBtn.Size = New Size(75, 23)
        regBtn.TabIndex = 2
        regBtn.Text = "Register"
        regBtn.UseVisualStyleBackColor = True
        ' 
        ' loginBtn
        ' 
        loginBtn.Location = New Point(287, 169)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(75, 23)
        loginBtn.TabIndex = 2
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = True
        ' 
        ' loginPanel
        ' 
        loginPanel.Controls.Add(forgotBtn)
        loginPanel.Controls.Add(showLoginBtn)
        loginPanel.Controls.Add(showRegBtn)
        loginPanel.Controls.Add(logUser)
        loginPanel.Controls.Add(loginBtn)
        loginPanel.Controls.Add(logPass)
        loginPanel.Controls.Add(Label4)
        loginPanel.Controls.Add(Label6)
        loginPanel.Controls.Add(Label5)
        loginPanel.Location = New Point(58, 34)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(599, 389)
        loginPanel.TabIndex = 3
        ' 
        ' forgotBtn
        ' 
        forgotBtn.Location = New Point(247, 198)
        forgotBtn.Name = "forgotBtn"
        forgotBtn.Size = New Size(115, 23)
        forgotBtn.TabIndex = 5
        forgotBtn.Text = "Forgot Password"
        forgotBtn.UseVisualStyleBackColor = True
        ' 
        ' showLoginBtn
        ' 
        showLoginBtn.Location = New Point(299, 0)
        showLoginBtn.Name = "showLoginBtn"
        showLoginBtn.Size = New Size(300, 30)
        showLoginBtn.TabIndex = 4
        showLoginBtn.Text = "Log In"
        showLoginBtn.UseVisualStyleBackColor = True
        ' 
        ' showRegBtn
        ' 
        showRegBtn.Location = New Point(0, 0)
        showRegBtn.Name = "showRegBtn"
        showRegBtn.Size = New Size(301, 30)
        showRegBtn.TabIndex = 3
        showRegBtn.Text = "Register"
        showRegBtn.UseVisualStyleBackColor = True
        ' 
        ' regPanel
        ' 
        regPanel.Controls.Add(passMatchIdentifier)
        regPanel.Controls.Add(regShowConPass)
        regPanel.Controls.Add(regShowPass)
        regPanel.Controls.Add(regConfirmPass)
        regPanel.Controls.Add(regPass)
        regPanel.Controls.Add(regEmail)
        regPanel.Controls.Add(regSID)
        regPanel.Controls.Add(regLastName)
        regPanel.Controls.Add(regFirstName)
        regPanel.Controls.Add(regBtn)
        regPanel.Controls.Add(Label1)
        regPanel.Controls.Add(regHidePass)
        regPanel.Controls.Add(regHideConPass)
        regPanel.Location = New Point(58, 66)
        regPanel.Name = "regPanel"
        regPanel.Size = New Size(599, 360)
        regPanel.TabIndex = 4
        ' 
        ' passMatchIdentifier
        ' 
        passMatchIdentifier.AutoSize = True
        passMatchIdentifier.ForeColor = Color.RoyalBlue
        passMatchIdentifier.Location = New Point(448, 127)
        passMatchIdentifier.Name = "passMatchIdentifier"
        passMatchIdentifier.Size = New Size(34, 15)
        passMatchIdentifier.TabIndex = 6
        passMatchIdentifier.Text = "OOO"
        ' 
        ' regShowConPass
        ' 
        regShowConPass.Location = New Point(425, 122)
        regShowConPass.Name = "regShowConPass"
        regShowConPass.Size = New Size(17, 25)
        regShowConPass.TabIndex = 5
        regShowConPass.Text = "S"
        regShowConPass.UseVisualStyleBackColor = True
        ' 
        ' regShowPass
        ' 
        regShowPass.Location = New Point(425, 93)
        regShowPass.Name = "regShowPass"
        regShowPass.Size = New Size(17, 23)
        regShowPass.TabIndex = 5
        regShowPass.Text = "S"
        regShowPass.UseVisualStyleBackColor = True
        ' 
        ' regConfirmPass
        ' 
        regConfirmPass.Location = New Point(166, 122)
        regConfirmPass.MaxLength = 100
        regConfirmPass.Name = "regConfirmPass"
        regConfirmPass.Size = New Size(257, 23)
        regConfirmPass.TabIndex = 4
        regConfirmPass.Text = "Confirm Password"
        ' 
        ' regPass
        ' 
        regPass.Location = New Point(166, 93)
        regPass.MaxLength = 100
        regPass.Name = "regPass"
        regPass.Size = New Size(257, 23)
        regPass.TabIndex = 4
        regPass.Text = "Password"
        ' 
        ' regEmail
        ' 
        regEmail.Location = New Point(166, 64)
        regEmail.MaxLength = 100
        regEmail.Name = "regEmail"
        regEmail.Size = New Size(170, 23)
        regEmail.TabIndex = 3
        regEmail.Text = "Email"
        ' 
        ' regLastName
        ' 
        regLastName.Location = New Point(307, 35)
        regLastName.MaxLength = 50
        regLastName.Name = "regLastName"
        regLastName.Size = New Size(135, 23)
        regLastName.TabIndex = 0
        regLastName.Text = "Last Name"
        ' 
        ' regHidePass
        ' 
        regHidePass.Location = New Point(425, 93)
        regHidePass.Name = "regHidePass"
        regHidePass.Size = New Size(17, 23)
        regHidePass.TabIndex = 5
        regHidePass.Text = "H"
        regHidePass.UseVisualStyleBackColor = True
        ' 
        ' regHideConPass
        ' 
        regHideConPass.Location = New Point(425, 122)
        regHideConPass.Name = "regHideConPass"
        regHideConPass.Size = New Size(17, 25)
        regHideConPass.TabIndex = 5
        regHideConPass.Text = "H"
        regHideConPass.UseVisualStyleBackColor = True
        ' 
        ' LOGIN_PAGE
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(702, 489)
        Controls.Add(regPanel)
        Controls.Add(loginPanel)
        Name = "LOGIN_PAGE"
        Text = "Form1"
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        regPanel.ResumeLayout(False)
        regPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents regFirstName As TextBox
    Friend WithEvents regSID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents logUser As TextBox
    Friend WithEvents logPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
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
    Friend WithEvents forgotBtn As Button

End Class
