<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RootDB_Pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RootDB_Pass))
        Button1 = New Button()
        Button2 = New Button()
        txtPinCode = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(263, 11)
        Button1.Name = "Button1"
        Button1.Size = New Size(22, 23)
        Button1.TabIndex = 9
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(20), CByte(62), CByte(35))
        Button2.Location = New Point(104, 104)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 20)
        Button2.TabIndex = 10
        Button2.UseVisualStyleBackColor = False
        ' 
        ' txtPinCode
        ' 
        txtPinCode.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        txtPinCode.BorderStyle = BorderStyle.None
        txtPinCode.Cursor = Cursors.IBeam
        txtPinCode.Location = New Point(83, 64)
        txtPinCode.Name = "txtPinCode"
        txtPinCode.Size = New Size(130, 16)
        txtPinCode.TabIndex = 11
        ' 
        ' RootDB_Pass
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(296, 144)
        Controls.Add(txtPinCode)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "RootDB_Pass"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RootDB_Pass"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtPinCode As TextBox
End Class
