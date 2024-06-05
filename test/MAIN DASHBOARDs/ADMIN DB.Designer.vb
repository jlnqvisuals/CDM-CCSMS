<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN_DB
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
        acceptBtn = New Button()
        rejectBtn = New Button()
        reviewGrid = New DataGridView()
        acceptedGrid = New DataGridView()
        schedLogBtn = New Button()
        acceptedLogPanel = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        CType(reviewGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(acceptedGrid, ComponentModel.ISupportInitialize).BeginInit()
        acceptedLogPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' acceptBtn
        ' 
        acceptBtn.Location = New Point(12, 281)
        acceptBtn.Name = "acceptBtn"
        acceptBtn.Size = New Size(172, 57)
        acceptBtn.TabIndex = 1
        acceptBtn.Text = "Accept"
        acceptBtn.UseVisualStyleBackColor = True
        ' 
        ' rejectBtn
        ' 
        rejectBtn.Location = New Point(305, 281)
        rejectBtn.Name = "rejectBtn"
        rejectBtn.Size = New Size(75, 23)
        rejectBtn.TabIndex = 2
        rejectBtn.Text = "Reject"
        rejectBtn.UseVisualStyleBackColor = True
        ' 
        ' reviewGrid
        ' 
        reviewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        reviewGrid.Enabled = False
        reviewGrid.Location = New Point(12, 12)
        reviewGrid.Name = "reviewGrid"
        reviewGrid.Size = New Size(778, 263)
        reviewGrid.TabIndex = 3
        ' 
        ' acceptedGrid
        ' 
        acceptedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        acceptedGrid.Enabled = False
        acceptedGrid.Location = New Point(0, 70)
        acceptedGrid.Name = "acceptedGrid"
        acceptedGrid.Size = New Size(778, 312)
        acceptedGrid.TabIndex = 4
        ' 
        ' schedLogBtn
        ' 
        schedLogBtn.Location = New Point(680, 408)
        schedLogBtn.Name = "schedLogBtn"
        schedLogBtn.Size = New Size(75, 23)
        schedLogBtn.TabIndex = 5
        schedLogBtn.Text = "View Log"
        schedLogBtn.UseVisualStyleBackColor = True
        ' 
        ' acceptedLogPanel
        ' 
        acceptedLogPanel.Controls.Add(Button1)
        acceptedLogPanel.Controls.Add(acceptedGrid)
        acceptedLogPanel.Controls.Add(Label1)
        acceptedLogPanel.Location = New Point(12, 12)
        acceptedLogPanel.Name = "acceptedLogPanel"
        acceptedLogPanel.Size = New Size(778, 434)
        acceptedLogPanel.TabIndex = 6
        acceptedLogPanel.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(689, 396)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(236, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 32)
        Label1.TabIndex = 5
        Label1.Text = "ACCEPTED SCHEDULE LOG"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(680, 493)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "LOG OUT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ADMIN_DB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(802, 540)
        Controls.Add(Button2)
        Controls.Add(schedLogBtn)
        Controls.Add(reviewGrid)
        Controls.Add(rejectBtn)
        Controls.Add(acceptBtn)
        Controls.Add(acceptedLogPanel)
        Name = "ADMIN_DB"
        Text = "ADMIN_DB"
        CType(reviewGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(acceptedGrid, ComponentModel.ISupportInitialize).EndInit()
        acceptedLogPanel.ResumeLayout(False)
        acceptedLogPanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents acceptBtn As Button
    Friend WithEvents rejectBtn As Button
    Friend WithEvents approvedList As ListView
    Friend WithEvents reviewList As ListView
    Friend WithEvents review As ListBox
    Friend WithEvents approved As ListBox
    Friend WithEvents reviewGrid As DataGridView
    Friend WithEvents acceptedGrid As DataGridView
    Friend WithEvents schedLogBtn As Button
    Friend WithEvents acceptedLogPanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
