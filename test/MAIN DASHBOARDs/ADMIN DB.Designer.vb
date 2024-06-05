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
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        acceptedGrid2 = New DataGridView()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        reviewGrid2 = New DataGridView()
        acceptBtn2 = New Button()
        rejectBtn2 = New Button()
        CType(reviewGrid, ComponentModel.ISupportInitialize).BeginInit()
        CType(acceptedGrid, ComponentModel.ISupportInitialize).BeginInit()
        acceptedLogPanel.SuspendLayout()
        CType(acceptedGrid2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(reviewGrid2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' acceptBtn
        ' 
        acceptBtn.Location = New Point(519, 177)
        acceptBtn.Name = "acceptBtn"
        acceptBtn.Size = New Size(75, 23)
        acceptBtn.TabIndex = 1
        acceptBtn.Text = "Accept"
        acceptBtn.UseVisualStyleBackColor = True
        ' 
        ' rejectBtn
        ' 
        rejectBtn.Location = New Point(600, 177)
        rejectBtn.Name = "rejectBtn"
        rejectBtn.Size = New Size(75, 23)
        rejectBtn.TabIndex = 2
        rejectBtn.Text = "Reject"
        rejectBtn.UseVisualStyleBackColor = True
        ' 
        ' reviewGrid
        ' 
        reviewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        reviewGrid.Location = New Point(146, 25)
        reviewGrid.Name = "reviewGrid"
        reviewGrid.ReadOnly = True
        reviewGrid.Size = New Size(529, 146)
        reviewGrid.TabIndex = 3
        ' 
        ' acceptedGrid
        ' 
        acceptedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        acceptedGrid.Location = New Point(0, 84)
        acceptedGrid.Name = "acceptedGrid"
        acceptedGrid.ReadOnly = True
        acceptedGrid.Size = New Size(778, 116)
        acceptedGrid.TabIndex = 4
        ' 
        ' schedLogBtn
        ' 
        schedLogBtn.Location = New Point(689, 451)
        schedLogBtn.Name = "schedLogBtn"
        schedLogBtn.Size = New Size(75, 23)
        schedLogBtn.TabIndex = 5
        schedLogBtn.Text = "View Log"
        schedLogBtn.UseVisualStyleBackColor = True
        ' 
        ' acceptedLogPanel
        ' 
        acceptedLogPanel.Controls.Add(Label3)
        acceptedLogPanel.Controls.Add(Label2)
        acceptedLogPanel.Controls.Add(Button1)
        acceptedLogPanel.Controls.Add(acceptedGrid2)
        acceptedLogPanel.Controls.Add(acceptedGrid)
        acceptedLogPanel.Controls.Add(Label1)
        acceptedLogPanel.Location = New Point(12, 12)
        acceptedLogPanel.Name = "acceptedLogPanel"
        acceptedLogPanel.Size = New Size(778, 434)
        acceptedLogPanel.TabIndex = 6
        acceptedLogPanel.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(347, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 7
        Label3.Text = "LAB 2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(347, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 15)
        Label2.TabIndex = 7
        Label2.Text = "LAB 1"
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
        ' acceptedGrid2
        ' 
        acceptedGrid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        acceptedGrid2.Location = New Point(0, 236)
        acceptedGrid2.Name = "acceptedGrid2"
        acceptedGrid2.ReadOnly = True
        acceptedGrid2.Size = New Size(778, 116)
        acceptedGrid2.TabIndex = 4
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
        Button2.Location = New Point(715, 505)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "LOG OUT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(15, 505)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 8
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(reviewGrid2)
        Panel1.Controls.Add(reviewGrid)
        Panel1.Controls.Add(acceptBtn2)
        Panel1.Controls.Add(acceptBtn)
        Panel1.Controls.Add(schedLogBtn)
        Panel1.Controls.Add(rejectBtn2)
        Panel1.Controls.Add(rejectBtn)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(778, 487)
        Panel1.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(387, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 15)
        Label5.TabIndex = 6
        Label5.Text = "LAB 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(387, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 15)
        Label4.TabIndex = 6
        Label4.Text = "LAB 1"
        ' 
        ' reviewGrid2
        ' 
        reviewGrid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        reviewGrid2.Location = New Point(146, 236)
        reviewGrid2.Name = "reviewGrid2"
        reviewGrid2.ReadOnly = True
        reviewGrid2.Size = New Size(529, 146)
        reviewGrid2.TabIndex = 3
        ' 
        ' acceptBtn2
        ' 
        acceptBtn2.Location = New Point(519, 388)
        acceptBtn2.Name = "acceptBtn2"
        acceptBtn2.Size = New Size(75, 23)
        acceptBtn2.TabIndex = 1
        acceptBtn2.Text = "Accept"
        acceptBtn2.UseVisualStyleBackColor = True
        ' 
        ' rejectBtn2
        ' 
        rejectBtn2.Location = New Point(600, 388)
        rejectBtn2.Name = "rejectBtn2"
        rejectBtn2.Size = New Size(75, 23)
        rejectBtn2.TabIndex = 2
        rejectBtn2.Text = "Reject"
        rejectBtn2.UseVisualStyleBackColor = True
        ' 
        ' ADMIN_DB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(802, 540)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(acceptedLogPanel)
        Controls.Add(Panel1)
        Name = "ADMIN_DB"
        Text = "ADMIN_DB"
        CType(reviewGrid, ComponentModel.ISupportInitialize).EndInit()
        CType(acceptedGrid, ComponentModel.ISupportInitialize).EndInit()
        acceptedLogPanel.ResumeLayout(False)
        acceptedLogPanel.PerformLayout()
        CType(acceptedGrid2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(reviewGrid2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents acceptedGrid2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents reviewGrid2 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents acceptBtn2 As Button
    Friend WithEvents rejectBtn2 As Button
End Class
