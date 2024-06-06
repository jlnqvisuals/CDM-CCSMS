Imports System.Drawing.Drawing2D

Public Class FORGET_UN_PASS_PROMPT



    Private Sub timerClose_Tick(sender As Object, e As EventArgs) Handles TimerClose1.Tick
        TimerClose1.Stop() ' Stop the timer
        Me.Close() ' Close Form2 after 3 seconds
    End Sub

    Public Sub StartCloseTimer()
        TimerClose1.Start() ' Start the timer
    End Sub










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










End Class