<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevInf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevInf))
        ExitBTN = New Button()
        SuspendLayout()
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
        ExitBTN.Location = New Point(448, 15)
        ExitBTN.Name = "ExitBTN"
        ExitBTN.Size = New Size(10, 10)
        ExitBTN.TabIndex = 11
        ExitBTN.UseVisualStyleBackColor = False
        ' 
        ' DevInf
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(475, 565)
        Controls.Add(ExitBTN)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "DevInf"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DevInf"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ExitBTN As Button
End Class
