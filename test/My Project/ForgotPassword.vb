Imports System.Drawing.Drawing2D
Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class ForgotPassword

    Dim resetCode As String


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

    Private Sub sendCodeBtn_Click(sender As Object, e As EventArgs) Handles sendCodeBtn.Click
        resetCode = GenerateResetCode()
        SendResetEmail(emailTxt.Text, resetCode)
    End Sub

    Public Sub SendResetEmail(toEmail As String, verificationCode As String)
        Try
            Dim smtpClient As New SmtpClient("smtp.gmail.com")
            smtpClient.Port = 587
            smtpClient.Credentials = New System.Net.NetworkCredential("cdm.ccsms@gmail.com", "rezr ewrt nbud lvar")
            smtpClient.EnableSsl = True

            Dim mailMessage As New MailMessage()
            mailMessage.From = New MailAddress("cdm.ccsms@gmail.com")
            mailMessage.To.Add(toEmail)
            mailMessage.Subject = "CDM-DMS Password Reset Code"
            mailMessage.Body = "Your password reset code is: " & verificationCode

            smtpClient.Send(mailMessage)
            MsgBox("Code Sent")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GenerateResetCode() As String
        Dim random As New Random()
        Return random.Next(100000, 999999).ToString()
    End Function

    Private Sub changePassBtn_Click(sender As Object, e As EventArgs) Handles changePassBtn.Click
        changePassPanel.Show()
    End Sub

    Private Sub passMatch(sender As Object, e As EventArgs) Handles newPassTxt.TextChanged, confirmNewPassTxt.TextChanged
        If newPassTxt.Text = confirmNewPassTxt.Text Then
            isPassMatched.ForeColor = Color.Green
            isPassMatched.Text = "PASSWORD MATCHED"
            updatePassBtn.Enabled = True
        Else
            isPassMatched.Text = "PASSWORD UNMATCHED"
            isPassMatched.ForeColor = Color.Red
            updatePassBtn.Enabled = False
        End If
    End Sub

    Private Sub UpdatePass(email As String, password As String)

        Dim connectionString As String = "server=localhost;userid=root;password=;database=prac"

        Dim query As String = "UPDATE user_data SET password = @password WHERE email = @email"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@password", password)
                    command.Parameters.AddWithValue("@email", email)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Console.WriteLine("Update successful!")
                    Else
                        Console.WriteLine("Update failed.")
                    End If
                End Using
            Catch ex As MySqlException
                Console.WriteLine("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub updatePassBtn_Click(sender As Object, e As EventArgs) Handles updatePassBtn.Click
        UpdatePass(emailTxt.Text, newPassTxt.Text)
        Me.Close()
        LOGIN_PAGE.Show()
    End Sub

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub changePassPanel_Paint(sender As Object, e As PaintEventArgs) Handles changePassPanel.Paint

    End Sub
End Class