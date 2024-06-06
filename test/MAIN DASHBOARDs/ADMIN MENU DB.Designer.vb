<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN_MENU_DB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADMIN_MENU_DB))
        SearchCampusBTN = New Button()
        AcceptRoomReservBTN = New Button()
        NavigateCampusBTN = New Button()
        SuspendLayout()
        ' 
        ' SearchCampusBTN
        ' 
        SearchCampusBTN.BackColor = Color.Transparent
        SearchCampusBTN.BackgroundImageLayout = ImageLayout.None
        SearchCampusBTN.Cursor = Cursors.Hand
        SearchCampusBTN.FlatAppearance.BorderSize = 0
        SearchCampusBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        SearchCampusBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        SearchCampusBTN.FlatStyle = FlatStyle.Flat
        SearchCampusBTN.ImeMode = ImeMode.NoControl
        SearchCampusBTN.Location = New Point(409, 240)
        SearchCampusBTN.Name = "SearchCampusBTN"
        SearchCampusBTN.Size = New Size(232, 148)
        SearchCampusBTN.TabIndex = 39
        SearchCampusBTN.UseVisualStyleBackColor = False
        ' 
        ' AcceptRoomReservBTN
        ' 
        AcceptRoomReservBTN.BackColor = Color.Transparent
        AcceptRoomReservBTN.BackgroundImageLayout = ImageLayout.None
        AcceptRoomReservBTN.Cursor = Cursors.Hand
        AcceptRoomReservBTN.FlatAppearance.BorderSize = 0
        AcceptRoomReservBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        AcceptRoomReservBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        AcceptRoomReservBTN.FlatStyle = FlatStyle.Flat
        AcceptRoomReservBTN.ImeMode = ImeMode.NoControl
        AcceptRoomReservBTN.Location = New Point(660, 240)
        AcceptRoomReservBTN.Name = "AcceptRoomReservBTN"
        AcceptRoomReservBTN.Size = New Size(232, 148)
        AcceptRoomReservBTN.TabIndex = 40
        AcceptRoomReservBTN.UseVisualStyleBackColor = False
        ' 
        ' NavigateCampusBTN
        ' 
        NavigateCampusBTN.BackColor = Color.Transparent
        NavigateCampusBTN.BackgroundImageLayout = ImageLayout.None
        NavigateCampusBTN.Cursor = Cursors.Hand
        NavigateCampusBTN.FlatAppearance.BorderSize = 0
        NavigateCampusBTN.FlatAppearance.MouseDownBackColor = Color.Transparent
        NavigateCampusBTN.FlatAppearance.MouseOverBackColor = Color.Transparent
        NavigateCampusBTN.FlatStyle = FlatStyle.Flat
        NavigateCampusBTN.ImeMode = ImeMode.NoControl
        NavigateCampusBTN.Location = New Point(159, 240)
        NavigateCampusBTN.Name = "NavigateCampusBTN"
        NavigateCampusBTN.Size = New Size(232, 148)
        NavigateCampusBTN.TabIndex = 41
        NavigateCampusBTN.UseVisualStyleBackColor = False
        ' 
        ' ADMIN_MENU_DB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1050, 591)
        Controls.Add(NavigateCampusBTN)
        Controls.Add(AcceptRoomReservBTN)
        Controls.Add(SearchCampusBTN)
        FormBorderStyle = FormBorderStyle.None
        Name = "ADMIN_MENU_DB"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMIN_MENU_DB"
        ResumeLayout(False)
    End Sub

    Friend WithEvents SearchCampusBTN As Button
    Friend WithEvents AcceptRoomReservBTN As Button
    Friend WithEvents NavigateCampusBTN As Button
End Class
