<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _7to8amSched
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
        nameTxt = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        reasonTxt = New TextBox()
        reqRoomBtn = New Button()
        SuspendLayout()
        ' 
        ' nameTxt
        ' 
        nameTxt.Enabled = False
        nameTxt.Location = New Point(143, 31)
        nameTxt.Name = "nameTxt"
        nameTxt.Size = New Size(212, 23)
        nameTxt.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(96, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 1
        Label1.Text = "NAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(96, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 2
        Label2.Text = "REASON:"
        ' 
        ' reasonTxt
        ' 
        reasonTxt.Location = New Point(157, 73)
        reasonTxt.Multiline = True
        reasonTxt.Name = "reasonTxt"
        reasonTxt.ScrollBars = ScrollBars.Horizontal
        reasonTxt.Size = New Size(198, 125)
        reasonTxt.TabIndex = 3
        ' 
        ' reqRoomBtn
        ' 
        reqRoomBtn.Location = New Point(280, 217)
        reqRoomBtn.Name = "reqRoomBtn"
        reqRoomBtn.Size = New Size(75, 23)
        reqRoomBtn.TabIndex = 4
        reqRoomBtn.Text = "REQUEST"
        reqRoomBtn.UseVisualStyleBackColor = True
        ' 
        ' _7to8amSched
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(389, 281)
        Controls.Add(reqRoomBtn)
        Controls.Add(reasonTxt)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(nameTxt)
        Name = "_7to8amSched"
        Text = "_7to8amSched"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nameTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents reasonTxt As TextBox
    Friend WithEvents reqRoomBtn As Button
End Class
