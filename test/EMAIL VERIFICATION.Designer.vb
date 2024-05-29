<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMAIL_VERIFICATION
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
        verifyBtn = New Button()
        verifyTxt = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' verifyBtn
        ' 
        verifyBtn.Location = New Point(110, 93)
        verifyBtn.Name = "verifyBtn"
        verifyBtn.Size = New Size(75, 23)
        verifyBtn.TabIndex = 7
        verifyBtn.Text = "Verify"
        verifyBtn.UseVisualStyleBackColor = True
        ' 
        ' verifyTxt
        ' 
        verifyTxt.Location = New Point(90, 64)
        verifyTxt.Name = "verifyTxt"
        verifyTxt.Size = New Size(114, 23)
        verifyTxt.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Poppins", 9F)
        Label3.Location = New Point(38, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(221, 22)
        Label3.TabIndex = 5
        Label3.Text = "A code has been sent to your inbox:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Poppins", 10F, FontStyle.Bold)
        Label2.Location = New Point(73, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 25)
        Label2.TabIndex = 4
        Label2.Text = "VERIFY YOUR EMAIL"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(269, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(23, 22)
        Button1.TabIndex = 8
        Button1.Text = "x"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' EMAIL_VERIFICATION
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(296, 144)
        Controls.Add(Button1)
        Controls.Add(verifyBtn)
        Controls.Add(verifyTxt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Name = "EMAIL_VERIFICATION"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EMAIL_VERIFICATION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents verifyBtn As Button
    Friend WithEvents verifyTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
