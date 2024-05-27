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
        Label1 = New Label()
        currentUser = New Label()
        logOutBtn = New Button()
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
        currentUser.Location = New Point(12, 9)
        currentUser.Name = "currentUser"
        currentUser.Size = New Size(228, 26)
        currentUser.TabIndex = 2
        currentUser.Text = "Label2"
        ' 
        ' logOutBtn
        ' 
        logOutBtn.Location = New Point(707, 12)
        logOutBtn.Name = "logOutBtn"
        logOutBtn.Size = New Size(75, 23)
        logOutBtn.TabIndex = 3
        logOutBtn.Text = "Log Out"
        logOutBtn.UseVisualStyleBackColor = True
        ' 
        ' NGD_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._123
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(794, 489)
        Controls.Add(logOutBtn)
        Controls.Add(currentUser)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "NGD_Dashboard"
        Text = "NGD"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents currentUser As Label
    Friend WithEvents logOutBtn As Button
End Class
