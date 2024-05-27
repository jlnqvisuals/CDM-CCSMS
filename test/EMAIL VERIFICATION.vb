Imports System.Net.Mail

Public Class EMAIL_VERIFICATION
    Dim code As String

    Private Sub EMAIL_VERIFICATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        code = GenerateVerificationCode()
        SendVerificationEmail(LOGIN_PAGE.email, code)
    End Sub

    Private Sub verifyBtn_Click(sender As Object, e As EventArgs) Handles verifyBtn.Click
        If VerifyCode(verifyTxt.Text) Then
            MsgBox("Email Verification Successful!")
            Me.Close()
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
            mailMessage.Subject = "CDM-DMS Verification Code"
            mailMessage.Body = "Your verification code is: " & verificationCode

            smtpClient.Send(mailMessage)
            MsgBox("Code Sent")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class