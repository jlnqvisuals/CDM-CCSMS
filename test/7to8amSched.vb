Imports MySql.Data.MySqlClient

Public Class _7to8amSched

    Private connectionString As String = "server=localhost;userid=root;password=;database=prac"
    Private connection As MySqlConnection


    Private Sub _7to8amSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getCurrentUser(LOGIN_PAGE.StudentID)
        sidTxt.Text = LOGIN_PAGE.StudentID
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

        Using connection As New MySqlConnection(connectionString)
            Dim insertQuery As String = "INSERT INTO lab1sched (Time, Reason, CreatedBy, SID) VALUES (@Time, @Reason, @CreatedBy, @SID)"
            Dim command As New MySqlCommand(insertQuery, connection)
            command.Parameters.AddWithValue("@Time", Time)
            command.Parameters.AddWithValue("@Reason", reason)
            command.Parameters.AddWithValue("@CreatedBy", createdBy)
            command.Parameters.AddWithValue("@SID", SID)
            connection.Open()

            command.ExecuteNonQuery()
        End Using
        MsgBox("Please wait for admin approval.")
    End Sub
End Class