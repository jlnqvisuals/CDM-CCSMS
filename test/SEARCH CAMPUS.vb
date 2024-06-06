Imports System.Drawing.Drawing2D

Public Class SEARCH_CAMPUS






    Private Sub RoundedCorners(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create a rounded rectangle shape
        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim radius As Integer = 20 ' Adjust the radius to change the roundness of the corners
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Apply the custom region to the form
        Me.Region = New Region(path)

    End Sub






    Private isDragging As Boolean = False
    Private startPoint As Point

    ' Event handler for Mouse Down event
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            startPoint = New Point(e.X, e.Y)
        End If
    End Sub

    ' Event handler for Mouse Move event
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    ' Event handler for Mouse Up event
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            isDragging = False
        End If
    End Sub







    Private Sub SEARCH_CAMPUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainDB_User.Show()

    End Sub

    Sub locate(mainPanel As Panel, pan1 As Panel, pan2 As Panel, pan3 As Panel, pan4 As Panel, pan5 As Panel)
        mainPanel.Visible = True
        pan1.Visible = False
        pan2.Visible = False
        pan3.Visible = False
        pan4.Visible = False
        pan5.Visible = False
    End Sub

    Private Sub locate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles toCBox.SelectedIndexChanged, fromCBox.SelectedIndexChanged
        If fromCBox.SelectedItem = "ADMIN BUILDING" And toCBox.SelectedItem = "PRRC BUILDING" Then
            locate(AdminToPRRC, AdmintoNewBLDG, NewBLDGtoAdmin, NewBLDGtoPRRC, PRRCtoAdmin, PRRCtoNewBLDG)
        ElseIf fromCBox.SelectedItem = "ADMIN BUILDING" And toCBox.SelectedItem = "YNARES BUILDING" Then
            locate(AdmintoNewBLDG, AdminToPRRC, NewBLDGtoAdmin, NewBLDGtoPRRC, PRRCtoAdmin, PRRCtoNewBLDG)
        ElseIf fromCBox.SelectedItem = "YNARES BUILDING" And toCBox.SelectedItem = "ADMIN BUILDING" Then
            locate(NewBLDGtoAdmin, AdminToPRRC, AdmintoNewBLDG, NewBLDGtoPRRC, PRRCtoAdmin, PRRCtoNewBLDG)
        ElseIf fromCBox.SelectedItem = "YNARES BUILDING" And toCBox.SelectedItem = "PRRC BUILDING" Then
            locate(NewBLDGtoPRRC, AdminToPRRC, AdmintoNewBLDG, NewBLDGtoAdmin, PRRCtoAdmin, PRRCtoNewBLDG)
        ElseIf fromCBox.SelectedItem = "PRRC BUILDING" And toCBox.SelectedItem = "ADMIN BUILDING" Then
            locate(PRRCtoAdmin, AdminToPRRC, AdmintoNewBLDG, NewBLDGtoAdmin, NewBLDGtoPRRC, PRRCtoNewBLDG)
        ElseIf fromCBox.SelectedItem = "PRRC BUILDING" And toCBox.SelectedItem = "YNARES BUILDING" Then
            locate(PRRCtoNewBLDG, AdminToPRRC, AdmintoNewBLDG, NewBLDGtoAdmin, NewBLDGtoPRRC, PRRCtoAdmin)
        Else
            AdminToPRRC.Visible = False
            AdmintoNewBLDG.Visible = False
            NewBLDGtoAdmin.Visible = False
            NewBLDGtoPRRC.Visible = False
            PRRCtoAdmin.Visible = False
            PRRCtoNewBLDG.Visible = False
        End If
    End Sub
End Class