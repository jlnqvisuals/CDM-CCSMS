<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccessDenied_Prompt
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccessDenied_Prompt))
        TimerClose = New Timer(components)
        SuspendLayout()
        ' 
        ' TimerClose
        ' 
        TimerClose.Interval = 2000
        ' 
        ' AccessDenied_Prompt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(296, 144)
        FormBorderStyle = FormBorderStyle.None
        Name = "AccessDenied_Prompt"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AccessDenied_Prompt"
        ResumeLayout(False)
    End Sub

    Friend WithEvents TimerClose As Timer
End Class
