<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEARCH_CAMPUS
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
        fromCBox = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        toCBox = New ComboBox()
        SuspendLayout()
        ' 
        ' fromCBox
        ' 
        fromCBox.FormattingEnabled = True
        fromCBox.Items.AddRange(New Object() {"FACULTY BUILDING", "NEW BUILDING", "OLD BUILDING"})
        fromCBox.Location = New Point(61, 6)
        fromCBox.Name = "fromCBox"
        fromCBox.Size = New Size(239, 23)
        fromCBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 1
        Label1.Text = "FROM:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(338, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 15)
        Label2.TabIndex = 2
        Label2.Text = "TO:"
        ' 
        ' toCBox
        ' 
        toCBox.FormattingEnabled = True
        toCBox.Items.AddRange(New Object() {"FACULTY BUILDING", "NEW BUILDING", "OLD BUILDING"})
        toCBox.Location = New Point(368, 6)
        toCBox.Name = "toCBox"
        toCBox.Size = New Size(239, 23)
        toCBox.TabIndex = 0
        ' 
        ' SEARCH_CAMPUS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(toCBox)
        Controls.Add(fromCBox)
        Name = "SEARCH_CAMPUS"
        Text = "SEARCH_CAMPUS"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents fromCBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents toCBox As ComboBox
End Class
