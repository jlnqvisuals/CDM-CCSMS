<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORGET_UN_PASS_PROMPT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORGET_UN_PASS_PROMPT))
        TimerClose1 = New Timer(components)
        SuspendLayout()
        ' 
        ' TimerClose1
        ' 
        TimerClose1.Interval = 2000
        ' 
        ' FORGET_UN_PASS_PROMPT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(296, 144)
        FormBorderStyle = FormBorderStyle.None
        Name = "FORGET_UN_PASS_PROMPT"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "FORGET_UN_PASS_PROMPT"
        ResumeLayout(False)
    End Sub

    Friend WithEvents TimerClose1 As Timer
End Class
