﻿


'TEST COMMIT/PUSH
'TEST COMMIT/PUSH 2




Imports System.Drawing.Drawing2D
Imports System.Net.Mail
Imports System.Web
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient



Public Class LOGIN_PAGE











    Private Sub RoundedCorners(sender As Object, e As EventArgs) Handles MyBase.Load

        'Default Hide button (Reg Pass Conf)
        regHideConPass.Visible = False
        regHidePass.Visible = False

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





    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        regPanel.Hide() ' Hide regPanel by default
    End Sub

    Private Sub LOGIN_PAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Other code...
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
    Public Shared email As String
    Public Shared StudentID As String = ""




    Private Sub DBtest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection = New MySqlConnection(connectionString)

            connection.Open()
            'MessageBox.Show("Connection successful!")

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub





    Private Sub ExecuteQuery(query As String)
        Try
            connection.Open()

            Dim cmd As MySqlCommand = New MySqlCommand(query, connection)

            cmd.ExecuteNonQuery()

            connection.Close()

            MessageBox.Show("Query executed successfully!")
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub RegisterData(SID As String, FName As String, LName As String, Email As String, Password As String)
        Try
            connection.Open()

            Dim insertQuery As String = "INSERT INTO user_data (`Student ID`, `First Name`, `Last Name`, Email, Password) VALUES (@SID, @FName, @LName, @Email, @Password)"

            Dim cmd As MySqlCommand = New MySqlCommand(insertQuery, connection)

            cmd.Parameters.AddWithValue("@SID", SID)
            cmd.Parameters.AddWithValue("@FName", FName)
            cmd.Parameters.AddWithValue("@LName", LName)
            cmd.Parameters.AddWithValue("@Email", Email)
            cmd.Parameters.AddWithValue("@Password", Password)

            cmd.ExecuteNonQuery()


            MessageBox.Show("Register Successful!")


            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function ValidateLogin(SID As String, Password As String) As Boolean
        Try

            connection.Open()


            Dim selectQuery As String = "SELECT COUNT(*) FROM user_data WHERE `Student ID` = @SID AND Password = @Password"


            Dim cmd As MySqlCommand = New MySqlCommand(selectQuery, connection)


            cmd.Parameters.AddWithValue("@SID", SID)
            cmd.Parameters.AddWithValue("@Password", Password)


            Dim userCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())


            connection.Close()


            Return userCount > 0
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub regBtn_Click(sender As Object, e As EventArgs) Handles regBtn.Click
        If isSIDTaken(regSID.Text) And isEmailTaken(regEmail.Text) Then
            MsgBox("Email and Student ID is already taken.")
        ElseIf (isEmailTaken(regEmail.Text)) Then
            MsgBox("Email is already taken.")
        ElseIf isSIDTaken(regSID.Text) Then
            MsgBox("An account with the same Student ID is already existing.")
        Else
            RegisterData(regSID.Text, regFirstName.Text, regLastName.Text, regEmail.Text, regPass.Text)
            email = regEmail.Text
            regEmail.Text = "Email"
            regSID.Text = "XX-XXXXX"
            regFirstName.Text = "First Name"
            regLastName.Text = "Last Name"
            regPass.Text = "Password"
            regConfirmPass.Text = "Confirm Password"
            EMAIL_VERIFICATION.Show()
        End If
    End Sub

    Function isSIDTaken(SID As String) As Boolean

        ' SQL query to check if the username exists
        Dim query As String = "SELECT COUNT(*) FROM user_data WHERE `Student ID` = @SID"

        ' Create and open a connection to the database
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Create a command to execute the SQL query
            Using command As New MySqlCommand(query, connection)
                ' Add the username parameter to the query
                command.Parameters.AddWithValue("@SID", SID)

                ' Execute the query and get the result
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' If count is greater than 0, the username is taken
                Return count > 0
            End Using
        End Using
    End Function

    Function isEmailTaken(Email As String) As Boolean

        ' SQL query to check if the username exists
        Dim query As String = "SELECT COUNT(*) FROM user_data WHERE Email = @Email"

        ' Create and open a connection to the database
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Create a command to execute the SQL query
            Using command As New MySqlCommand(query, connection)
                ' Add the username parameter to the query
                command.Parameters.AddWithValue("@Email", Email)

                ' Execute the query and get the result
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' If count is greater than 0, the username is taken
                Return count > 0
            End Using
        End Using
    End Function






    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If ValidateLogin(logUser.Text, logPass.Text) Then

            LOGIN_SUCCESS_PROMPT.Show()
            LOGIN_SUCCESS_PROMPT.StartCloseTimer()

            StudentID = logUser.Text
            logUser.Text = ""
            logPass.Text = ""
            MainDB_User.Show()
            Me.Hide()
        Else
            FORGET_UN_PASS_PROMPT.Show()
            FORGET_UN_PASS_PROMPT.StartCloseTimer()
            'MsgBox("Invalid Username/Password.")
        End If
    End Sub

    Private Sub showRegBtn_Click(sender As Object, e As EventArgs) Handles showRegBtn.Click
        regPanel.Show()
        loginPanel.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles showLoginBtn.Click
        loginPanel.Show()
        regPanel.Hide()
    End Sub



    Private Sub regFirstName_Click(sender As Object, e As EventArgs) Handles regFirstName.Click
        If regFirstName.Text = "First Name" Then
            regFirstName.Text = ""
        End If
    End Sub

    Private Sub regFirstName_LostFocus(sender As Object, e As EventArgs) Handles regFirstName.LostFocus
        If regFirstName.Text = "" Then
            regFirstName.Text = "First Name"
        End If
    End Sub

    Private Sub regLastName_Click(sender As Object, e As EventArgs) Handles regLastName.Click
        If regLastName.Text = "Last Name" Then
            regLastName.Text = ""
        End If
    End Sub

    Private Sub regLastName_LostFocus(sender As Object, e As EventArgs) Handles regLastName.LostFocus
        If regLastName.Text = "" Then
            regLastName.Text = "Last Name"
        End If
    End Sub

    Private Sub regSID_Click(sender As Object, e As EventArgs) Handles regSID.Click
        If regSID.Text = "XX-XXXXX" Then
            regSID.Text = ""
        End If
    End Sub

    Private Sub regSID_LostFocus(sender As Object, e As EventArgs) Handles regSID.LostFocus
        If regSID.Text = "" Then
            regSID.Text = "XX-XXXXX"
        End If
    End Sub
    Private Sub regEmail_Click(sender As Object, e As EventArgs) Handles regEmail.Click
        If regEmail.Text = "Email" Then
            regEmail.Text = ""
        End If
    End Sub
    Private Sub regEmail_LostFocus(sender As Object, e As EventArgs) Handles regEmail.LostFocus
        If regEmail.Text = "" Then
            regEmail.Text = "Email"
        End If
    End Sub





    Private Sub regPass_Click(sender As Object, e As EventArgs) Handles regPass.Click
        If regPass.Text = "Password" Then
            regPass.Text = ""
        End If
    End Sub







    Private Sub regPass_LostFocus(sender As Object, e As EventArgs) Handles regPass.LostFocus
        If regPass.Text = "" Then
            regPass.Text = "Password"
        End If
    End Sub

    Private Sub regPass_TextChanged(sender As Object, e As EventArgs) Handles regPass.TextChanged
        If regPass.Text <> "Password" Then
            regPass.PasswordChar = "•"
        Else
            regPass.PasswordChar = ""
        End If
    End Sub





    Private Sub regShowPass_Click(sender As Object, e As EventArgs) Handles regShowPass.Click
        regPass.PasswordChar = ""
        If regPass.Text <> "Password" Then
            regHidePass.Show()
            regShowPass.Hide()
        End If
    End Sub

    Private Sub regHidePass_Click(sender As Object, e As EventArgs) Handles regHidePass.Click
        If regPass.Text <> "Password" Then
            regPass.PasswordChar = "•"
        End If
        regShowPass.Show()
        regHidePass.Hide()
    End Sub






    Private Sub regConfirmPass_Click(sender As Object, e As EventArgs) Handles regConfirmPass.Click
        If regConfirmPass.Text = "Confirm Password" Then
            regConfirmPass.Text = ""
        End If
    End Sub




    Private Sub regConfirmPass_LostFocus(sender As Object, e As EventArgs) Handles regConfirmPass.LostFocus
        If regConfirmPass.Text = "" Then
            regConfirmPass.Text = "Confirm Password"
        End If
    End Sub







    Private Sub regConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles regConfirmPass.TextChanged
        If regConfirmPass.Text <> "Confirm Password" Then
            regConfirmPass.PasswordChar = "•"
        Else
            regConfirmPass.PasswordChar = ""
        End If
    End Sub





    Private Sub regShowConPass_Click(sender As Object, e As EventArgs) Handles regShowConPass.Click
        regConfirmPass.PasswordChar = ""
        If regConfirmPass.Text <> "Confirm Password" Then
            regHideConPass.Show()
            regShowConPass.Hide()
        End If
    End Sub

    Private Sub regHideConPass_Click(sender As Object, e As EventArgs) Handles regHideConPass.Click
        If regConfirmPass.Text <> "Confirm Password" Then
            regConfirmPass.PasswordChar = "•"
        End If
        regShowConPass.Show()
        regHideConPass.Hide()
    End Sub








    Private Sub passMatch(sender As Object, e As EventArgs) Handles regPass.TextChanged, regConfirmPass.TextChanged
        If regPass.Text = regConfirmPass.Text Then
            passMatchIdentifier.ForeColor = Color.Blue
            passMatchIdentifier.Text = "Password Matches"
            regBtn.Enabled = True
        Else
            passMatchIdentifier.Text = "Password doesn't match"
            passMatchIdentifier.ForeColor = Color.Red
            regBtn.Enabled = False
        End If
    End Sub

    Private Sub canRegister(sender As Object, e As EventArgs) Handles regPass.TextChanged, regConfirmPass.TextChanged, regFirstName.TextChanged, regLastName.TextChanged, regEmail.TextChanged, regSID.TextChanged

        If regPass.Text = "Password" Or regPass.Text = "" Or regConfirmPass.Text = "Confirm Password" Or regConfirmPass.Text = "" Or regFirstName.Text = "First Name" Or regFirstName.Text = "" Or regLastName.Text = "Last Name" Or regLastName.Text = "" Or regEmail.Text = "Email" Or regEmail.Text = "" Or regSID.Text = "XX-XXXXX" Or regSID.Text = "" Or passMatchIdentifier.Text = "PASSWORD UNMATCHED" Then
            regBtn.Enabled = False
        Else
            regBtn.Enabled = True
        End If
    End Sub

    Private Sub forgotBtn_Click(sender As Object, e As EventArgs)
        ForgotPassword.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ForgotPassword.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        EXIT_PROMPT.Show()
        'Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AboutDev.Show()
    End Sub







    Private Sub logUser_Click(sender As Object, e As EventArgs) Handles logUser.Click
        If logUser.Text = "Student ID (XX-XXXXX)" Then
            logUser.Text = ""
        End If
    End Sub

    Private Sub logUser_LostFocus(sender As Object, e As EventArgs) Handles logUser.LostFocus
        If logUser.Text = "" Then
            logUser.Text = "Student ID (XX-XXXXX)"
        End If
    End Sub

    '    logPass

    Private Sub logPass_Click(sender As Object, e As EventArgs) Handles logPass.Click
        If logPass.Text = "Password" Then
            logPass.Text = ""
        End If
    End Sub

    Private Sub logPass_LostFocus(sender As Object, e As EventArgs) Handles logPass.LostFocus
        If logPass.Text = "" Then
            logPass.Text = "Password"
        End If
    End Sub





    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub





    'ENTER TO LOGIN
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the KeyPreview property to True so the form can receive key events
        Me.KeyPreview = True
    End Sub


    Private Sub LOGINPAGE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Call the Button1_Click event handler
            loginBtn_Click(loginBtn, EventArgs.Empty)
        End If
    End Sub

    Private Sub logPass_TextChanged(sender As Object, e As EventArgs) Handles logPass.TextChanged

    End Sub

    Private Sub regPanel_Paint(sender As Object, e As PaintEventArgs) Handles regPanel.Paint

    End Sub

    Private Sub logUser_TextChanged(sender As Object, e As EventArgs) Handles logUser.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub loginPanel_Paint(sender As Object, e As PaintEventArgs) Handles loginPanel.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles PrivacyPolicy_Panel.Paint

    End Sub

    Private Sub PrivacyPolicyBTN_Click(sender As Object, e As EventArgs) Handles PrivacyPolicyBTN.Click
        PrivacyPolicy_Panel.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PrivacyPolicy_Panel.Visible = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TnC_BTN_Click(sender As Object, e As EventArgs) Handles TnC_BTN.Click
        TnC_Panel.Visible = True
    End Sub

    Private Sub TnC_Panel_Paint(sender As Object, e As PaintEventArgs) Handles TnC_Panel.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TnC_Panel.Visible = False
    End Sub

    Private Sub ContactsBTN_Click(sender As Object, e As EventArgs) Handles ContactsBTN.Click
        ContactUs_Panel.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ContactUs_Panel.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles SignAsAdminBTN.Click
        If logUser.Text = "admin" And logPass.Text = "admin" Then

            Me.Hide()
            ADMIN_MENU_DB.Show()
            'ADMIN_DB.Show()
        Else
            AccessDenied_Prompt.Show()
            AccessDenied_Prompt.StartCloseTimer()
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles GuestBTN.Click
        LOGIN_PAGE.StudentID = "GUEST"

        MainDB_User.Show()
        Me.Hide()

    End Sub


End Class


