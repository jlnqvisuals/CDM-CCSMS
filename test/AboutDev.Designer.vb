<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutDev
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutDev))
        Button1 = New Button()
        ExitBTN = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(200, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(74, 74)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ExitBTN
        ' 
        ExitBTN.BackColor = Color.Transparent
        ExitBTN.Cursor = Cursors.Hand
        ExitBTN.FlatAppearance.BorderSize = 0
        ExitBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        ExitBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        ExitBTN.FlatStyle = FlatStyle.Flat
        ExitBTN.ForeColor = Color.Transparent
        ExitBTN.Location = New Point(443, 12)
        ExitBTN.Name = "ExitBTN"
        ExitBTN.Size = New Size(20, 19)
        ExitBTN.TabIndex = 10
        ExitBTN.UseVisualStyleBackColor = False
        ' 
        ' AboutDev
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(475, 565)
        Controls.Add(ExitBTN)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AboutDev"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AboutDev"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ExitBTN As Button
End Class
