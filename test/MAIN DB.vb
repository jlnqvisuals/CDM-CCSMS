


'05/29/24
'4:54 PM

Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Org.BouncyCastle.Bcpg.OpenPgp




Public Class NGD_Dashboard

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
        Close()
        LOGIN_PAGE.Show()
    End Sub



    Private Sub NGD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getCurrentUser(LOGIN_PAGE.StudentID)
    End Sub

    Private Sub currentUser_Click(sender As Object, e As EventArgs) Handles currentUser.Click

    End Sub
End Class