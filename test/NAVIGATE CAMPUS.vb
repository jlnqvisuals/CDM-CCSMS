Imports System.Drawing.Drawing2D

Public Class NAVIGATE_CAMPUS






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











    Private Sub NAVIGATE_CAMPUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adminBldgPanel.Hide()
        prrcBldgPanel.Hide()
        newBldgPanel.Hide()
    End Sub

    Private Sub adminBldgBtn_Click(sender As Object, e As EventArgs) Handles adminBldgBtn.Click
        prrcBldgPanel.Hide()
        newBldgPanel.Hide()
        adminBldgPanel.Show()

    End Sub

    Private Sub newBldgBtn_Click(sender As Object, e As EventArgs) Handles newBldgBtn.Click
        adminBldgPanel.Hide()
        prrcBldgPanel.Hide()
        newBldgPanel.Show()
    End Sub

    Private Sub prrcBldgBtn_Click(sender As Object, e As EventArgs) Handles prrcBldgBtn.Click
        adminBldgPanel.Hide()
        newBldgPanel.Hide()
        prrcBldgPanel.Show()
    End Sub

    Private Sub newNavBtn_Click(sender As Object, e As EventArgs) Handles newNavBtn.Click
        Me.Hide()
        NEW_BUILDING.Show()
    End Sub

    Private Sub newBackBtn_Click(sender As Object, e As EventArgs) Handles newBackBtn.Click
        newBldgPanel.Hide()
    End Sub

    Private Sub adminNavBtn_Click(sender As Object, e As EventArgs) Handles adminNavBtn.Click
        Me.Hide()
        FACULTY_BUILDING.Show()
    End Sub

    Private Sub adminBackBtn_Click(sender As Object, e As EventArgs) Handles adminBackBtn.Click
        adminBldgPanel.Hide()
    End Sub

    Private Sub prrcNavBtn_Click(sender As Object, e As EventArgs) Handles prrcNavBtn.Click
        PRRC_BLDG.Show()
    End Sub

    Private Sub prrcBackBtn_Click(sender As Object, e As EventArgs) Handles prrcBackBtn.Click
        prrcBldgPanel.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        MainDB_User.Show()


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class