Imports System.Drawing.Drawing2D
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class _7to8amSched

    Private connectionString As String = "server=localhost;userid=root;password=;database=prac"
    Private connection As MySqlConnection






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









    Private Sub _7to8amSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getCurrentUser(LOGIN_PAGE.StudentID)
        sidTxt.Text = LOGIN_PAGE.StudentID
        dateToday_Label.Text = DateTime.Now.ToString("dddd - MMMM dd yyyy")
        ' Start the timer
        dateToday.Start()
    End Sub

    Dim FirstName As String = ""
    Dim LastName As String = ""

    Sub getCurrentUser(SID As String)
        Dim selectQuery As String = "SELECT `First Name`, `LAST NAME` FROM user_data WHERE `Student ID` = @SID"


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
                                LastName = reader("Last Name").ToString()
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

        nameTxt.Text = FirstName & " " & LastName

    End Sub

    Private Sub reqRoomBtn_Click(sender As Object, e As EventArgs) Handles reqRoomBtn.Click
        Dim Time As String = PRRC_BLDG.desiredtime
        Dim createdBy As String = nameTxt.Text
        Dim reason As String = reasonTxt.Text
        Dim SID As String = LOGIN_PAGE.StudentID
        Dim SchedDate As String = DateTimePicker1.Value.Date

        Using connection As New MySqlConnection(connectionString)

            Dim command As New MySqlCommand(PRRC_BLDG.insertQuery, connection)
            command.Parameters.AddWithValue("@Date", SchedDate)
            command.Parameters.AddWithValue("@Time", Time)
            command.Parameters.AddWithValue("@Reason", reason)
            command.Parameters.AddWithValue("@CreatedBy", createdBy)
            command.Parameters.AddWithValue("@SID", SID)
            connection.Open()

            command.ExecuteNonQuery()
        End Using
        MsgBox("Room Reservation Established, Please wait for admin approval.")
        Me.Hide()
        PRRC_BLDG.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub dateToday_Tick(sender As Object, e As EventArgs) Handles dateToday.Tick
        dateToday_Label.Text = DateTime.Now.ToString("dddd - MMMM dd yyyy")
    End Sub
End Class