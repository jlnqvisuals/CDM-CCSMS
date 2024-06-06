Imports System.Drawing.Drawing2D

Public Class ADMIN_MENU_DB





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






    Private Sub AcceptRoomReservBTN_Click(sender As Object, e As EventArgs) Handles AcceptRoomReservBTN.Click
        Me.Close()
        ADMIN_DB.Show()


    End Sub

    Private Sub SearchCampusBTN_Click(sender As Object, e As EventArgs) Handles SearchCampusBTN.Click
        Me.Close()
        SEARCH_CAMPUS.Show()


    End Sub

    Private Sub NavigateCampusBTN_Click(sender As Object, e As EventArgs) Handles NavigateCampusBTN.Click
        Me.Close()
        NAVIGATE_CAMPUS.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EXIT_PROMPT.Show()
        'Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AboutDev.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SignAsAdminBTN_Click(sender As Object, e As EventArgs) Handles SignAsAdminBTN.Click
        Me.Close()
        LOGIN_PAGE.Show()


    End Sub
End Class