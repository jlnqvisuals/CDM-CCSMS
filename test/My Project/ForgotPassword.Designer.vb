<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        sendCodeBtn = New Button()
        changePassBtn = New Button()
        emailTxt = New TextBox()
        codeTxt = New TextBox()
        changePassPanel = New Panel()
        ExitBTN = New Button()
        updatePassBtn = New Button()
        isPassMatched = New Label()
        confirmNewPassTxt = New TextBox()
        newPassTxt = New TextBox()
        Button1 = New Button()
        changePassPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' sendCodeBtn
        ' 
        sendCodeBtn.BackColor = Color.Transparent
        sendCodeBtn.BackgroundImageLayout = ImageLayout.None
        sendCodeBtn.Cursor = Cursors.Hand
        sendCodeBtn.FlatAppearance.BorderSize = 0
        sendCodeBtn.FlatAppearance.CheckedBackColor = Color.Transparent
        sendCodeBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        sendCodeBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        sendCodeBtn.FlatStyle = FlatStyle.Flat
        sendCodeBtn.Location = New Point(54, 164)
        sendCodeBtn.Name = "sendCodeBtn"
        sendCodeBtn.Size = New Size(75, 23)
        sendCodeBtn.TabIndex = 0
        sendCodeBtn.UseVisualStyleBackColor = False
        ' 
        ' changePassBtn
        ' 
        changePassBtn.BackColor = Color.Transparent
        changePassBtn.BackgroundImageLayout = ImageLayout.None
        changePassBtn.Cursor = Cursors.Hand
        changePassBtn.FlatAppearance.BorderSize = 0
        changePassBtn.FlatAppearance.CheckedBackColor = Color.Transparent
        changePassBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        changePassBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        changePassBtn.FlatStyle = FlatStyle.Flat
        changePassBtn.Location = New Point(146, 164)
        changePassBtn.Name = "changePassBtn"
        changePassBtn.Size = New Size(98, 23)
        changePassBtn.TabIndex = 1
        changePassBtn.UseVisualStyleBackColor = False
        ' 
        ' emailTxt
        ' 
        emailTxt.BorderStyle = BorderStyle.None
        emailTxt.Cursor = Cursors.IBeam
        emailTxt.Location = New Point(59, 62)
        emailTxt.Name = "emailTxt"
        emailTxt.Size = New Size(179, 16)
        emailTxt.TabIndex = 2
        ' 
        ' codeTxt
        ' 
        codeTxt.BorderStyle = BorderStyle.None
        codeTxt.Cursor = Cursors.IBeam
        codeTxt.Location = New Point(58, 115)
        codeTxt.Name = "codeTxt"
        codeTxt.Size = New Size(180, 16)
        codeTxt.TabIndex = 3
        ' 
        ' changePassPanel
        ' 
        changePassPanel.BackgroundImage = CType(resources.GetObject("changePassPanel.BackgroundImage"), Image)
        changePassPanel.Controls.Add(ExitBTN)
        changePassPanel.Controls.Add(updatePassBtn)
        changePassPanel.Controls.Add(isPassMatched)
        changePassPanel.Controls.Add(confirmNewPassTxt)
        changePassPanel.Controls.Add(newPassTxt)
        changePassPanel.Location = New Point(0, 0)
        changePassPanel.Name = "changePassPanel"
        changePassPanel.Size = New Size(296, 215)
        changePassPanel.TabIndex = 6
        changePassPanel.Visible = False
        ' 
        ' ExitBTN
        ' 
        ExitBTN.BackColor = Color.Transparent
        ExitBTN.FlatAppearance.BorderSize = 0
        ExitBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        ExitBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        ExitBTN.FlatStyle = FlatStyle.Flat
        ExitBTN.Location = New Point(263, 11)
        ExitBTN.Name = "ExitBTN"
        ExitBTN.Size = New Size(22, 23)
        ExitBTN.TabIndex = 12
        ExitBTN.UseVisualStyleBackColor = False
        ' 
        ' updatePassBtn
        ' 
        updatePassBtn.BackColor = Color.Transparent
        updatePassBtn.BackgroundImageLayout = ImageLayout.None
        updatePassBtn.Cursor = Cursors.Hand
        updatePassBtn.Enabled = False
        updatePassBtn.FlatAppearance.BorderSize = 0
        updatePassBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        updatePassBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        updatePassBtn.FlatStyle = FlatStyle.Flat
        updatePassBtn.Location = New Point(81, 164)
        updatePassBtn.Name = "updatePassBtn"
        updatePassBtn.Size = New Size(134, 25)
        updatePassBtn.TabIndex = 11
        updatePassBtn.UseVisualStyleBackColor = False
        ' 
        ' isPassMatched
        ' 
        isPassMatched.AutoSize = True
        isPassMatched.BackColor = Color.Transparent
        isPassMatched.ForeColor = Color.Red
        isPassMatched.Location = New Point(43, 141)
        isPassMatched.Name = "isPassMatched"
        isPassMatched.Size = New Size(142, 15)
        isPassMatched.TabIndex = 10
        isPassMatched.Text = "PASSWORD UNMATCHED"
        ' 
        ' confirmNewPassTxt
        ' 
        confirmNewPassTxt.BorderStyle = BorderStyle.None
        confirmNewPassTxt.Location = New Point(59, 115)
        confirmNewPassTxt.Name = "confirmNewPassTxt"
        confirmNewPassTxt.Size = New Size(179, 16)
        confirmNewPassTxt.TabIndex = 7
        ' 
        ' newPassTxt
        ' 
        newPassTxt.BorderStyle = BorderStyle.None
        newPassTxt.Location = New Point(59, 62)
        newPassTxt.Name = "newPassTxt"
        newPassTxt.Size = New Size(179, 16)
        newPassTxt.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(263, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(22, 23)
        Button1.TabIndex = 13
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ForgotPassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(296, 215)
        Controls.Add(Button1)
        Controls.Add(changePassPanel)
        Controls.Add(codeTxt)
        Controls.Add(emailTxt)
        Controls.Add(changePassBtn)
        Controls.Add(sendCodeBtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "ForgotPassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ForgotPassword"
        changePassPanel.ResumeLayout(False)
        changePassPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents sendCodeBtn As Button
    Friend WithEvents changePassBtn As Button
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents codeTxt As TextBox
    Friend WithEvents changePassPanel As Panel
    Friend WithEvents updatePassBtn As Button
    Friend WithEvents isPassMatched As Label
    Friend WithEvents confirmNewPassTxt As TextBox
    Friend WithEvents newPassTxt As TextBox
    Friend WithEvents ExitBTN As Button
    Friend WithEvents Button1 As Button
End Class
