Imports System.Drawing.Drawing2D

Public Class FACULTY_BUILDING







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







    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button5.Visible = False Then
            Button5.Visible = True
        Else
            Button5.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button6.Visible = False Then
            Button6.Visible = True
        Else
            Button6.Visible = False
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Button11.Visible = False Then
            Button11.Visible = True
        Else
            Button11.Visible = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button12.Visible = False Then
            Button12.Visible = True
        Else
            Button12.Visible = False
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click, Button12.Click
        facultyF2Panel.Hide()
        facultyF1Panel.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click, Button5.Click
        facultyF1Panel.Hide()
        facultyF2Panel.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Hide()
        NAVIGATE_CAMPUS.Show()
    End Sub

    Private Sub FACULTY_BUILDING_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class