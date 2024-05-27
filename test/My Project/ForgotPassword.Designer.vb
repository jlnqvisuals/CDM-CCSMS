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
        sendCodeBtn = New Button()
        changePassBtn = New Button()
        emailTxt = New TextBox()
        codeTxt = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        changePassPanel = New Panel()
        updatePassBtn = New Button()
        isPassMatched = New Label()
        Label3 = New Label()
        Label4 = New Label()
        confirmNewPassTxt = New TextBox()
        newPassTxt = New TextBox()
        changePassPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' sendCodeBtn
        ' 
        sendCodeBtn.Location = New Point(315, 50)
        sendCodeBtn.Name = "sendCodeBtn"
        sendCodeBtn.Size = New Size(75, 23)
        sendCodeBtn.TabIndex = 0
        sendCodeBtn.Text = "Send Code"
        sendCodeBtn.UseVisualStyleBackColor = True
        ' 
        ' changePassBtn
        ' 
        changePassBtn.Location = New Point(166, 124)
        changePassBtn.Name = "changePassBtn"
        changePassBtn.Size = New Size(98, 23)
        changePassBtn.TabIndex = 1
        changePassBtn.Text = "Reset Password"
        changePassBtn.UseVisualStyleBackColor = True
        ' 
        ' emailTxt
        ' 
        emailTxt.Location = New Point(129, 51)
        emailTxt.Name = "emailTxt"
        emailTxt.Size = New Size(181, 23)
        emailTxt.TabIndex = 2
        ' 
        ' codeTxt
        ' 
        codeTxt.Location = New Point(129, 95)
        codeTxt.Name = "codeTxt"
        codeTxt.Size = New Size(181, 23)
        codeTxt.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(82, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 4
        Label1.Text = " Email:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(86, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 5
        Label2.Text = "Code:"
        ' 
        ' changePassPanel
        ' 
        changePassPanel.Controls.Add(updatePassBtn)
        changePassPanel.Controls.Add(isPassMatched)
        changePassPanel.Controls.Add(Label3)
        changePassPanel.Controls.Add(Label4)
        changePassPanel.Controls.Add(confirmNewPassTxt)
        changePassPanel.Controls.Add(newPassTxt)
        changePassPanel.Location = New Point(12, 26)
        changePassPanel.Name = "changePassPanel"
        changePassPanel.Size = New Size(503, 157)
        changePassPanel.TabIndex = 6
        changePassPanel.Visible = False
        ' 
        ' updatePassBtn
        ' 
        updatePassBtn.Enabled = False
        updatePassBtn.Location = New Point(223, 98)
        updatePassBtn.Name = "updatePassBtn"
        updatePassBtn.Size = New Size(117, 23)
        updatePassBtn.TabIndex = 11
        updatePassBtn.Text = "Update Password"
        updatePassBtn.UseVisualStyleBackColor = True
        ' 
        ' isPassMatched
        ' 
        isPassMatched.AutoSize = True
        isPassMatched.ForeColor = Color.Red
        isPassMatched.Location = New Point(346, 69)
        isPassMatched.Name = "isPassMatched"
        isPassMatched.Size = New Size(142, 15)
        isPassMatched.TabIndex = 10
        isPassMatched.Text = "PASSWORD UNMATCHED"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 15)
        Label3.TabIndex = 9
        Label3.Text = "Confirm New Pasword"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(67, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 15)
        Label4.TabIndex = 8
        Label4.Text = "New Password:"
        ' 
        ' confirmNewPassTxt
        ' 
        confirmNewPassTxt.Location = New Point(159, 64)
        confirmNewPassTxt.Name = "confirmNewPassTxt"
        confirmNewPassTxt.Size = New Size(181, 23)
        confirmNewPassTxt.TabIndex = 7
        ' 
        ' newPassTxt
        ' 
        newPassTxt.Location = New Point(159, 20)
        newPassTxt.Name = "newPassTxt"
        newPassTxt.Size = New Size(181, 23)
        newPassTxt.TabIndex = 6
        ' 
        ' ForgotPassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(543, 309)
        Controls.Add(changePassPanel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(codeTxt)
        Controls.Add(emailTxt)
        Controls.Add(changePassBtn)
        Controls.Add(sendCodeBtn)
        Name = "ForgotPassword"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents changePassPanel As Panel
    Friend WithEvents updatePassBtn As Button
    Friend WithEvents isPassMatched As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents confirmNewPassTxt As TextBox
    Friend WithEvents newPassTxt As TextBox
End Class
