Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Org.BouncyCastle.Bcpg.OpenPgp

Public Class NGD_Dashboard
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

        currentUser.Text = "Hi, " & FirstName
    End Sub

    Private Sub logOutBtn_Click(sender As Object, e As EventArgs) Handles logOutBtn.Click
        Me.Close()
        LOGIN_PAGE.Show()
    End Sub

    Private Sub NGD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getCurrentUser(LOGIN_PAGE.StudentID)
    End Sub
End Class