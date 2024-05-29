Imports System.Drawing.Drawing2D
Imports System.Net.Mail

Public Class EMAIL_VERIFICATION


    Dim code As String



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




    Private Sub EMAIL_VERIFICATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        code = GenerateVerificationCode()
        SendVerificationEmail(LOGIN_PAGE.email, code)
    End Sub

    Private Sub verifyBtn_Click(sender As Object, e As EventArgs) Handles verifyBtn.Click, Button1.Click
        If VerifyCode(verifyTxt.Text) Then
            MsgBox("Email Verification Successful!")
            Close()
            LOGIN_PAGE.Show()
        Else
            MsgBox("Invalid Code")
        End If
    End Sub

    Function VerifyCode(userInput As String) As Boolean
        Return userInput = code
    End Function

    Public Function GenerateVerificationCode() As String
        Dim random As New Random()
        Return random.Next(100000, 999999).ToString()
    End Function

    Public Sub SendVerificationEmail(toEmail As String, verificationCode As String)
        Try
            Dim smtpClient As New SmtpClient("smtp.gmail.com")
            smtpClient.Port = 587
            smtpClient.Credentials = New System.Net.NetworkCredential("cdm.ccsms@gmail.com", "rezr ewrt nbud lvar")
            smtpClient.EnableSsl = True

            Dim mailMessage As New MailMessage()
            mailMessage.From = New MailAddress("cdm.ccsms@gmail.com")
            mailMessage.To.Add(toEmail)
            mailMessage.Subject = "CDM CCSMS Verification Code"

            ' HTML formatting for the email body
            mailMessage.IsBodyHtml = True
            mailMessage.Body = "For security purposes, we have generated a One-Time Password (OTP) <br/>" &
                           "to authenticate your recent request. Please use the following OTP to proceed:<br/><br/>" &
                           "<b>Your One-Time Password (OTP) is: " & verificationCode & "<br/>" &
                           "Do not share this OTP with anyone."

            smtpClient.Send(mailMessage)
            MsgBox("Code Sent")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class