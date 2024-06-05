Imports System.Drawing.Drawing2D

Public Class RootDB_Pass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtPinCode.Text = "1234" Then
            Dim form2 As New RootDB()
            Me.Hide()
            AboutDev.Hide()
            DevInf.Hide()
            RootDB.Show()
            LOGIN_PAGE.Hide()

        Else
            MessageBox.Show("Incorrect PIN, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Hide()
            AboutDev.Hide()
            DevInf.Hide()
        End If
    End Sub

    Private Sub txtPinCode_TextChanged(sender As Object, e As EventArgs) Handles txtPinCode.TextChanged

    End Sub

    Private Sub RootDB_Pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class