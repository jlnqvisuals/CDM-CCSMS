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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_7to8amSched))
        nameTxt = New TextBox()
        reasonTxt = New TextBox()
        reqRoomBtn = New Button()
        sidTxt = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' nameTxt
        ' 
        nameTxt.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        nameTxt.BorderStyle = BorderStyle.None
        nameTxt.Enabled = False
        nameTxt.Location = New Point(61, 108)
        nameTxt.Name = "nameTxt"
        nameTxt.Size = New Size(175, 16)
        nameTxt.TabIndex = 0
        ' 
        ' reasonTxt
        ' 
        reasonTxt.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        reasonTxt.BorderStyle = BorderStyle.None
        reasonTxt.Location = New Point(56, 230)
        reasonTxt.Multiline = True
        reasonTxt.Name = "reasonTxt"
        reasonTxt.ScrollBars = ScrollBars.Horizontal
        reasonTxt.Size = New Size(185, 92)
        reasonTxt.TabIndex = 3
        ' 
        ' reqRoomBtn
        ' 
        reqRoomBtn.BackColor = Color.Transparent
        reqRoomBtn.FlatAppearance.BorderColor = Color.FromArgb(CByte(54), CByte(36), CByte(14))
        reqRoomBtn.FlatAppearance.BorderSize = 0
        reqRoomBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        reqRoomBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        reqRoomBtn.FlatStyle = FlatStyle.Flat
        reqRoomBtn.Location = New Point(77, 349)
        reqRoomBtn.Name = "reqRoomBtn"
        reqRoomBtn.Size = New Size(141, 23)
        reqRoomBtn.TabIndex = 4
        reqRoomBtn.UseVisualStyleBackColor = False
        ' 
        ' sidTxt
        ' 
        sidTxt.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        sidTxt.BorderStyle = BorderStyle.None
        sidTxt.Enabled = False
        sidTxt.Location = New Point(61, 161)
        sidTxt.Name = "sidTxt"
        sidTxt.Size = New Size(175, 16)
        sidTxt.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(156), CByte(156), CByte(156))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(266, 13)
        Button2.Name = "Button2"
        Button2.Size = New Size(17, 17)
        Button2.TabIndex = 7
        Button2.UseVisualStyleBackColor = False
        ' 
        ' _7to8amSched
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(296, 398)
        Controls.Add(Button2)
        Controls.Add(reqRoomBtn)
        Controls.Add(reasonTxt)
        Controls.Add(sidTxt)
        Controls.Add(nameTxt)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "_7to8amSched"
        StartPosition = FormStartPosition.CenterScreen
        Text = "_7to8amSched"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nameTxt As TextBox
    Friend WithEvents reasonTxt As TextBox
    Friend WithEvents reqRoomBtn As Button
    Friend WithEvents sidTxt As TextBox
    Friend WithEvents Button2 As Button
End Class
