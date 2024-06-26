﻿


'05/29/24
'4:54 PM

Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Org.BouncyCastle.Bcpg.OpenPgp




Public Class MainDB_User

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






    Private connectionString As String = "server=localhost;userid=root;password=;database=prac"
    Private connection As MySqlConnection
    Dim FirstName As String

    Sub getCurrentUser(SID As String)
        Dim selectQuery As String = "SELECT `First Name` FROM user_data WHERE `Student ID` = @SID"


        Dim cmd As MySqlCommand = New MySqlCommand(selectQuery, connection)

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New MySqlCommand(selectQuery, connection)
                    command.Parameters.AddWithValue("@SID", SID)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                FirstName = reader("First Name").ToString()
                            End While
                        Else
                            MsgBox("No records found for ID " & SID)
                        End If
                    End Using
                End Using
            Catch ex As MySqlException
                Console.WriteLine("Error: " & ex.Message)
            End Try
        End Using

        currentUser.Text = "Hi, " & FirstName & "!"
        StudentID.Text = SID

    End Sub


    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        EXIT_PROMPT.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles MinBTN.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTN01_Click(sender As Object, e As EventArgs) Handles navigateBtn.Click
        Me.Hide()
        NAVIGATE_CAMPUS.Show()
    End Sub

    Private Sub AboutBTN_Click(sender As Object, e As EventArgs) Handles AboutBTN.Click
        AboutDev.Show()

    End Sub





    Private Sub MainDB_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LOGIN_PAGE.StudentID = "GUEST" Then
            currentUser.Text = "GUEST ACCOUNT"
            StudentID.Text = "CDM-CCSMS"
        ElseIf LOGIN_PAGE.StudentID = "ADMIN" Then
            currentUser.Text = "ADMIN ACCOUNT"
            StudentID.Text = "CDM-CCSMS"
        Else
            getCurrentUser(LOGIN_PAGE.StudentID)
        End If
        ' Initialize the label text with the current date and time in the desired format
        DateTime_Label.Text = DateTime.Now.ToString("dddd - MMMM dd yyyy HH:mm tt")
        ' Start the timer
        DnT.Start()
    End Sub

    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DnT.Tick
        ' Update the label with the current date and time in the desired format
        DateTime_Label.Text = DateTime.Now.ToString("dddd - MMMM dd yyyy HH:mm tt")
    End Sub

    Private Sub DateTime_Label_Click(sender As Object, e As EventArgs) Handles DateTime_Label.Click
        ' You can leave this event handler empty or add any additional actions you want to perform when the label is clicked.
    End Sub

    Private Sub logoutMdbBtn_Click(sender As Object, e As EventArgs) Handles logoutMdbBtn.Click

        LOGIN_PAGE.Show()
        Me.Close()

    End Sub

    Private Sub SEARCHCAMPUS_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        SEARCH_CAMPUS.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub currentUser_Click(sender As Object, e As EventArgs) Handles currentUser.Click

    End Sub
End Class







