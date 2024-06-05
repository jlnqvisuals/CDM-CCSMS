<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EXIT_PROMPT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EXIT_PROMPT))
        showRegBtn = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' showRegBtn
        ' 
        showRegBtn.BackColor = Color.Transparent
        showRegBtn.Cursor = Cursors.Hand
        showRegBtn.FlatAppearance.BorderSize = 0
        showRegBtn.FlatAppearance.MouseDownBackColor = Color.Transparent
        showRegBtn.FlatAppearance.MouseOverBackColor = Color.Transparent
        showRegBtn.FlatStyle = FlatStyle.Flat
        showRegBtn.ForeColor = Color.Transparent
        showRegBtn.Location = New Point(160, 87)
        showRegBtn.Name = "showRegBtn"
        showRegBtn.Size = New Size(65, 21)
        showRegBtn.TabIndex = 4
        showRegBtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(72, 87)
        Button1.Name = "Button1"
        Button1.Size = New Size(65, 21)
        Button1.TabIndex = 5
        Button1.UseVisualStyleBackColor = False
        ' 
        ' EXIT_PROMPT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(296, 144)
        Controls.Add(Button1)
        Controls.Add(showRegBtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "EXIT_PROMPT"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "EXIT_PROMPT"
        ResumeLayout(False)
    End Sub

    Friend WithEvents showRegBtn As Button
    Friend WithEvents Button1 As Button
End Class
