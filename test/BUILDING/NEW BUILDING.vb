Imports System.Drawing.Drawing2D

Public Class NEW_BUILDING






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







    'FIRST FLOOR STAIRS
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        isVisible(Button14)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        isVisible(Button15)
    End Sub

    Private Sub f1Up_Click(sender As Object, e As EventArgs) Handles Button14.Click, Button15.Click
        newBldgF1Panel.Hide()
        newBldgF2Panel.Show()
    End Sub

    'SECOND FLOOR STAIRS
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        isVisible2(Button17, Button31)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        isVisible2(Button16, Button33)
    End Sub
    Private Sub f2Up_Click(sender As Object, e As EventArgs) Handles Button17.Click, Button16.Click
        newBldgF2Panel.Hide()
        newBldgF3Panel.Show()
    End Sub

    Private Sub f2Down_Click(sender As Object, e As EventArgs) Handles Button31.Click, Button33.Click
        newBldgF2Panel.Hide()
        newBldgF1Panel.Show()
    End Sub

    'THIRD FLOOR STAIRS
    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        isVisible2(Button36, Button35)
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        isVisible2(Button32, Button34)
    End Sub
    Private Sub f3Up_Click(sender As Object, e As EventArgs) Handles Button36.Click, Button32.Click
        newBldgF3Panel.Hide()
        newBldgF4Panel.Show()
    End Sub
    Private Sub f3Down_Click(sender As Object, e As EventArgs) Handles Button35.Click, Button34.Click
        newBldgF3Panel.Hide()
        newBldgF2Panel.Show()
    End Sub

    'FUNCTION AREA STAIRS
    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        isVisible(Button51)
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        isVisible(Button52)
    End Sub
    Private Sub f4Down_Click(sender As Object, e As EventArgs) Handles Button52.Click, Button51.Click
        newBldgF4Panel.Hide()
        newBldgF3Panel.Show()
    End Sub

    Sub isVisible(button As Button)
        If button.Visible = False Then
            button.Visible = True
        Else
            button.Visible = False
        End If
    End Sub

    Sub isVisible2(button1 As Button, button2 As Button)
        If button1.Visible = False Then
            button1.Visible = True
            button2.Visible = True
        Else
            button1.Visible = False
            button2.Visible = False
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Hide()
        NAVIGATE_CAMPUS.Show()
    End Sub

    Private Sub NEW_BUILDING_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class