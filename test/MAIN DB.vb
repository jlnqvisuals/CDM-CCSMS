


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

    Private Sub logOutBtn_Click(sender As Object, e As EventArgs) Handles logOutBtn.Click
        Me.Close()
        LOGIN_PAGE.Show()
    End Sub


    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        EXIT_PROMPT.Show()
    End Sub



    Private Sub NGD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getCurrentUser(LOGIN_PAGE.StudentID)
    End Sub





    Private Sub currentUser_Click(sender As Object, e As EventArgs) Handles currentUser.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub Label03_Click_1(sender As Object, e As EventArgs) Handles Label03.Click


    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class







