﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMAIL_VERIFICATION))
        verifyBtn = New Button()
        verifyTxt = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' verifyBtn
        ' 
        verifyBtn.BackColor = Color.Transparent
        verifyBtn.BackgroundImageLayout = ImageLayout.None
        verifyBtn.FlatAppearance.BorderSize = 0
        verifyBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        verifyBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        verifyBtn.FlatStyle = FlatStyle.Flat
        verifyBtn.Location = New Point(92, 98)
        verifyBtn.Name = "verifyBtn"
        verifyBtn.Size = New Size(112, 31)
        verifyBtn.TabIndex = 7
        verifyBtn.UseVisualStyleBackColor = False
        ' 
        ' verifyTxt
        ' 
        verifyTxt.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        verifyTxt.BorderStyle = BorderStyle.None
        verifyTxt.Location = New Point(83, 64)
        verifyTxt.Name = "verifyTxt"
        verifyTxt.Size = New Size(130, 16)
        verifyTxt.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(263, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(22, 23)
        Button1.TabIndex = 8
        Button1.UseVisualStyleBackColor = False
        ' 
        ' EMAIL_VERIFICATION
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(296, 144)
        Controls.Add(Button1)
        Controls.Add(verifyBtn)
        Controls.Add(verifyTxt)
        FormBorderStyle = FormBorderStyle.None
        Name = "EMAIL_VERIFICATION"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EMAIL_VERIFICATION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents verifyBtn As Button
    Friend WithEvents verifyTxt As TextBox
    Friend WithEvents Button1 As Button
End Class
