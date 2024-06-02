
Imports System.Diagnostics
Imports System.Drawing.Drawing2D
Public Class AboutDev
    Private clickCount As Integer = 0



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


    Private Sub AboutDev_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        clickCount += 1
        If clickCount >= 5 Then
            Dim frm As New DevInf
            DevInf.Show
        End If

        Dim url = "https://www.facebook.com/Tech.DMS"

        ' Create a ProcessStartInfo object
        Dim psi As New ProcessStartInfo
        psi.FileName = url
        psi.UseShellExecute = True

        ' Start the process using the ProcessStartInfo object
        Process.Start(psi)

    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim url = "https://github.com/frenched"
        ' Create a ProcessStartInfo object
        Dim psi As New ProcessStartInfo
        psi.FileName = url
        psi.UseShellExecute = True

        ' Start the process using the ProcessStartInfo object
        Process.Start(psi)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim url = "https://github.com/jlnqvisuals"
        ' Create a ProcessStartInfo object
        Dim psi As New ProcessStartInfo
        psi.FileName = url
        psi.UseShellExecute = True

        ' Start the process using the ProcessStartInfo object
        Process.Start(psi)
    End Sub
End Class