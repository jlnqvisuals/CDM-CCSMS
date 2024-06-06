Imports System.Drawing.Drawing2D
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class PRRC_BLDG
    Private connectionString As String = "server=localhost;userid=root;password=;database=prac"
    Private connection As MySqlConnection

    Public Shared desiredtime As String = ""
    Public Shared insertQuery As String = ""





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








    Private Sub PRRC_BLDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label16.Text = DateTime.Now.ToString("dddd - MMMM dd yyyy HH:mm tt")
        datePickerLabel.Text = DateTime.Now.ToString("dddd - MMMM dd yyyy")
        ' Start the timer
        updateDB.Interval = 1000
        updateDB.Start()
        Timer1.Start()
    End Sub

    Private Sub r101backBtn_Click(sender As Object, e As EventArgs) Handles r101backBtn.Click
        r101Panel.Visible = False
    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        isVisible(Button32)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        isVisible(Button34)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        isVisible(Button33)
    End Sub

    Sub isVisible(button As Button)
        If button.Visible = False Then
            button.Visible = True
        Else
            button.Visible = False
        End If
    End Sub
    Private Sub FirstFloorStairs(sender As Object, e As EventArgs) Handles Button32.Click, Button33.Click, Button34.Click
        firstFloorPanel.Hide()
        thirdFloorPanel.Hide()
        secondFloorPanel.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        isVisible2(Button26, Button27)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click, Button28.Click, Button30.Click
        firstFloorPanel.Hide()
        secondFloorPanel.Hide()
        thirdFloorPanel.Show()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click, Button29.Click, Button31.Click
        secondFloorPanel.Hide()
        thirdFloorPanel.Hide()
        firstFloorPanel.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        isVisible2(Button28, Button29)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        isVisible2(Button30, Button31)
    End Sub

    Sub isVisible2(button1 As Button, button2 As Button)
        If button1.Visible = False Then
            button1.Visible = True
            button2.Visible = True
        Else
            button1.Visible = False
            button2.Visible = False
        End If
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        isVisible(Button35)
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        isVisible(Button36)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        isVisible(Button37)
    End Sub

    Private Sub ThirdFloorStairs(sender As Object, e As EventArgs) Handles Button35.Click, Button36.Click, Button37.Click
        firstFloorPanel.Hide()
        thirdFloorPanel.Hide()
        secondFloorPanel.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label16.Text = DateTime.Now.ToString("dddd - MMMM dd yyyy HH:mm tt")
        datePickerLabel.Text = DateTime.Now.ToString("M/d/yyyy")
        timecheckerLabel.Text = DateTime.Now.ToString("HH")
    End Sub

    Sub checkAvailabilityLab1(schedtime As String, Button As Button)
        Dim time As String = schedtime
        Dim currentDate As String = datePickerLabel.Text
        Dim query As String = "SELECT Approved FROM lab1sched WHERE Date = @Date AND Time = @Time"

        ' Create a connection
        Using connection As New MySqlConnection(connectionString)
            ' Create a command
            Using command As New MySqlCommand(query, connection)
                ' Add the parameter to the command
                command.Parameters.AddWithValue("@Date", currentDate)
                command.Parameters.AddWithValue("@Time", time)

                ' Open the connection
                connection.Open()

                ' Execute the command and read the result
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Read the value from the cell
                        Dim approved As Boolean = Convert.ToBoolean(reader("Approved"))
                        ' Check the value
                        If approved Then
                            Button.BackColor = Color.Red
                            Button.Enabled = False
                        Else
                            Button.BackColor = Color.Green
                            Button.Enabled = True
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub

    Sub checkAvailabilityLab2(schedtime As String, Button As Button)
        Dim time As String = schedtime
        Dim currentDate As String = datePickerLabel.Text
        Dim query As String = "SELECT Approved FROM lab2sched WHERE Date = @Date AND Time = @Time"

        ' Create a connection
        Using connection As New MySqlConnection(connectionString)
            ' Create a command
            Using command As New MySqlCommand(query, connection)
                ' Add the parameter to the command
                command.Parameters.AddWithValue("@Date", currentDate)
                command.Parameters.AddWithValue("@Time", time)

                ' Open the connection
                connection.Open()

                ' Execute the command and read the result
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Read the value from the cell
                        Dim approved As Boolean = Convert.ToBoolean(reader("Approved"))
                        ' Check the value
                        If approved Then
                            Button.BackColor = Color.Red
                            Button.Enabled = False
                        Else
                            Button.BackColor = Color.Green
                            Button.Enabled = True
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        lab1SchedPanel.Hide()
    End Sub

    'LAB 1 SCHEDULES
    Private Sub roomsched1_Click(sender As Object, e As EventArgs) Handles roomsched1.Click
        desiredtime = "7:00-8:00"
        insertQuery = "INSERT INTO lab1sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub roomsched2_Click(sender As Object, e As EventArgs) Handles roomsched2.Click
        desiredtime = "8:00-9:00"
        insertQuery = "INSERT INTO lab1sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub roomsched3_Click(sender As Object, e As EventArgs) Handles roomsched3.Click
        desiredtime = "9:00-10:00"
        insertQuery = "INSERT INTO lab1sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub roomsched4_Click(sender As Object, e As EventArgs) Handles roomsched4.Click
        desiredtime = "10:00-11:00"
        insertQuery = "INSERT INTO lab1sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub roomsched5_Click(sender As Object, e As EventArgs) Handles roomsched5.Click
        desiredtime = "11:00-12:00"
        insertQuery = "INSERT INTO lab1sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub roomsched6_Click(sender As Object, e As EventArgs) Handles roomsched6.Click
        desiredtime = "12:00-1:00"
        insertQuery = "INSERT INTO lab1sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub roomsched7_Click(sender As Object, e As EventArgs) Handles roomsched7.Click
        desiredtime = "1:00-2:00"
        insertQuery = "INSERT INTO lab1sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub roomsched8_Click(sender As Object, e As EventArgs) Handles roomsched8.Click
        desiredtime = "2:00-3:00"
        insertQuery = "INSERT INTO lab1sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub roomsched9_Click(sender As Object, e As EventArgs) Handles roomsched9.Click
        desiredtime = "3:00-4:00"
        insertQuery = "INSERT INTO lab1sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub roomsched10_Click(sender As Object, e As EventArgs) Handles roomsched10.Click
        desiredtime = "4:00-5:00"
        insertQuery = "INSERT INTO lab1sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub

    'LAB 2 SCHEDULES
    Private Sub lab2sched1_Click(sender As Object, e As EventArgs) Handles lab2sched1.Click
        desiredtime = "7:00-8:00"
        insertQuery = "INSERT INTO lab2sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub lab2sched2_Click(sender As Object, e As EventArgs) Handles lab2sched2.Click
        desiredtime = "8:00-9:00"
        insertQuery = "INSERT INTO lab2sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub lab2sched3_Click(sender As Object, e As EventArgs) Handles lab2sched3.Click
        desiredtime = "9:00-10:00"
        insertQuery = "INSERT INTO lab2sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub lab2sched4_Click(sender As Object, e As EventArgs) Handles lab2sched4.Click
        desiredtime = "10:00-11:00"
        insertQuery = "INSERT INTO lab2sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub lab2sched5_Click(sender As Object, e As EventArgs) Handles lab2sched5.Click
        desiredtime = "11:00-12:00"
        insertQuery = "INSERT INTO lab2sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub lab2sched6_Click(sender As Object, e As EventArgs) Handles lab2sched6.Click
        desiredtime = "12:00-1:00"
        insertQuery = "INSERT INTO lab2sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub lab2sched7_Click(sender As Object, e As EventArgs) Handles lab2sched7.Click
        desiredtime = "1:00-2:00"
        insertQuery = "INSERT INTO lab2sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub lab2sched8_Click(sender As Object, e As EventArgs) Handles lab2sched8.Click
        desiredtime = "2:00-3:00"
        insertQuery = "INSERT INTO lab2sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub lab2sched9_Click(sender As Object, e As EventArgs) Handles lab2sched9.Click
        desiredtime = "3:00-4:00"
        insertQuery = "INSERT INTO lab2sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub
    Private Sub lab2sched10_Click(sender As Object, e As EventArgs) Handles lab2sched10.Click
        desiredtime = "4:00-5:00"
        insertQuery = "INSERT INTO lab2sched (Date, Time, Reason, CreatedBy, SID) VALUES (@Date, @Time, @Reason, @CreatedBy, @SID)"
        _7to8amSched.Show()
    End Sub


    Private Sub Button51_Click_1(sender As Object, e As EventArgs) Handles Button51.Click
        Me.Hide()
        NAVIGATE_CAMPUS.Show()
    End Sub

    Private Sub updateDB_Tick(sender As Object, e As EventArgs) Handles updateDB.Tick
        checkAvailabilityLab1("7:00-8:00", roomsched1)
        checkAvailabilityLab1("8:00-9:00", roomsched2)
        checkAvailabilityLab1("9:00-10:00", roomsched3)
        checkAvailabilityLab1("10:00-11:00", roomsched4)
        checkAvailabilityLab1("11:00-12:00", roomsched5)
        checkAvailabilityLab1("12:00-1:00", roomsched6)
        checkAvailabilityLab1("1:00-2:00", roomsched7)
        checkAvailabilityLab1("2:00-3:00", roomsched8)
        checkAvailabilityLab1("3:00-4:00", roomsched9)
        checkAvailabilityLab1("4:00-5:00", roomsched10)

        checkAvailabilityLab2("7:00-8:00", lab2sched1)
        checkAvailabilityLab2("8:00-9:00", lab2sched2)
        checkAvailabilityLab2("9:00-10:00", lab2sched3)
        checkAvailabilityLab2("10:00-11:00", lab2sched4)
        checkAvailabilityLab2("11:00-12:00", lab2sched5)
        checkAvailabilityLab2("12:00-1:00", lab2sched6)
        checkAvailabilityLab2("1:00-2:00", lab2sched7)
        checkAvailabilityLab2("2:00-3:00", lab2sched8)
        checkAvailabilityLab2("3:00-4:00", lab2sched9)
        checkAvailabilityLab2("4:00-5:00", lab2sched10)
    End Sub

    Sub isPanelVisible(mainPanel As Panel, pan1 As Panel, pan2 As Panel, pan3 As Panel, pan4 As Panel, pan5 As Panel, pan6 As Panel, pan7 As Panel)
        If mainPanel.Visible = False Then
            mainPanel.Visible = True
            pan1.Visible = False
            pan2.Visible = False
            pan3.Visible = False
            pan4.Visible = False
            pan5.Visible = False
            pan6.Visible = False
            pan7.Visible = False
        Else
            mainPanel.Visible = False
            pan1.Visible = False
            pan2.Visible = False
            pan3.Visible = False
            pan4.Visible = False
            pan5.Visible = False
            pan6.Visible = False
            pan7.Visible = False
        End If
    End Sub

    Sub isPanelVisible2(mainPanel As Panel, pan1 As Panel, pan2 As Panel, pan3 As Panel, pan4 As Panel, pan5 As Panel)
        If mainPanel.Visible = False Then
            mainPanel.Visible = True
            pan1.Visible = False
            pan2.Visible = False
            pan3.Visible = False
            pan4.Visible = False
            pan5.Visible = False

        Else
            mainPanel.Visible = False
            pan1.Visible = False
            pan2.Visible = False
            pan3.Visible = False
            pan4.Visible = False
            pan5.Visible = False
        End If
    End Sub





































    'FIRST FLOOR ROOMS
    Private Sub r101Btn_Click(sender As Object, e As EventArgs) Handles r101Btn.Click
        isPanelVisible(r101Panel, r102Panel, r108Panel, r103Panel, r104Panel, r105Panel, r106Panel, r107Panel)
    End Sub
    Private Sub r102Btn_Click(sender As Object, e As EventArgs) Handles r102Btn.Click
        isPanelVisible(r102Panel, r101Panel, r108Panel, r103Panel, r104Panel, r105Panel, r106Panel, r107Panel)
    End Sub
    Private Sub r103Btn_Click(sender As Object, e As EventArgs) Handles r103Btn.Click
        isPanelVisible(r103Panel, r101Panel, r102Panel, r108Panel, r104Panel, r105Panel, r106Panel, r107Panel)
    End Sub
    Private Sub r104Btn_Click(sender As Object, e As EventArgs) Handles r104Btn.Click
        isPanelVisible(r104Panel, r101Panel, r102Panel, r103Panel, r108Panel, r105Panel, r106Panel, r107Panel)
    End Sub
    Private Sub r105Btn_Click(sender As Object, e As EventArgs) Handles r105Btn.Click
        isPanelVisible(r105Panel, r101Panel, r102Panel, r103Panel, r104Panel, r108Panel, r106Panel, r107Panel)
    End Sub
    Private Sub r106Btn_Click(sender As Object, e As EventArgs) Handles r106Btn.Click
        isPanelVisible(r106Panel, r101Panel, r102Panel, r103Panel, r104Panel, r105Panel, r108Panel, r107Panel)
    End Sub
    Private Sub r107Btn_Click(sender As Object, e As EventArgs) Handles r107Btn.Click
        isPanelVisible(r107Panel, r101Panel, r102Panel, r103Panel, r104Panel, r105Panel, r106Panel, r108Panel)
    End Sub
    Private Sub r108Btn_Click(sender As Object, e As EventArgs) Handles r108Btn.Click
        isPanelVisible(r108Panel, r101Panel, r102Panel, r103Panel, r104Panel, r105Panel, r106Panel, r107Panel)
    End Sub

    'SECOND FLOOR ROOMS
    Private Sub r201Btn_Click(sender As Object, e As EventArgs) Handles r201Btn.Click
        isPanelVisible(r201Panel, r202Panel, r208Panel, r203Panel, r204Panel, r205Panel, r206Panel, r207Panel)
    End Sub
    Private Sub r202Btn_Click(sender As Object, e As EventArgs) Handles r202Btn.Click
        isPanelVisible(r202Panel, r201Panel, r208Panel, r203Panel, r204Panel, r205Panel, r206Panel, r207Panel)
    End Sub
    Private Sub r203Btn_Click(sender As Object, e As EventArgs) Handles r203Btn.Click
        isPanelVisible(r203Panel, r201Panel, r202Panel, r208Panel, r204Panel, r205Panel, r106Panel, r107Panel)
    End Sub
    Private Sub r204Btn_Click(sender As Object, e As EventArgs) Handles r204Btn.Click
        isPanelVisible(r204Panel, r201Panel, r202Panel, r203Panel, r208Panel, r205Panel, r206Panel, r207Panel)
    End Sub
    Private Sub r205Btn_Click(sender As Object, e As EventArgs) Handles r205Btn.Click
        isPanelVisible(r205Panel, r201Panel, r202Panel, r203Panel, r204Panel, r208Panel, r106Panel, r107Panel)
    End Sub
    Private Sub r206Btn_Click(sender As Object, e As EventArgs) Handles r206Btn.Click
        isPanelVisible(r206Panel, r201Panel, r202Panel, r203Panel, r204Panel, r205Panel, r208Panel, r207Panel)
    End Sub
    Private Sub r207Btn_Click(sender As Object, e As EventArgs) Handles r207Btn.Click
        isPanelVisible(r207Panel, r201Panel, r202Panel, r203Panel, r204Panel, r205Panel, r206Panel, r208Panel)
    End Sub
    Private Sub r208Btn_Click(sender As Object, e As EventArgs) Handles r208Btn.Click
        isPanelVisible(r208Panel, r201Panel, r202Panel, r203Panel, r204Panel, r205Panel, r206Panel, r207Panel)
    End Sub

    'THIRD FLOOR ROOMS
    Private Sub r301Btn_Click(sender As Object, e As EventArgs) Handles r301Btn.Click
        isPanelVisible2(r301Panel, r302Panel, r303Panel, r304Panel, lab1SchedPanel, lab2SchedPanel)
    End Sub
    Private Sub r302Btn_Click(sender As Object, e As EventArgs) Handles r302Btn.Click
        isPanelVisible2(r302Panel, r301Panel, r303Panel, r304Panel, lab1SchedPanel, lab2SchedPanel)
    End Sub
    Private Sub r303Btn_Click(sender As Object, e As EventArgs) Handles r303Btn.Click
        isPanelVisible2(r303Panel, r302Panel, r301Panel, r304Panel, lab1SchedPanel, lab2SchedPanel)
    End Sub
    Private Sub r304Btn_Click(sender As Object, e As EventArgs) Handles r304Btn.Click
        isPanelVisible2(r304Panel, r302Panel, r303Panel, r301Panel, lab1SchedPanel, lab2SchedPanel)
    End Sub
    Private Sub lab1Btn_Click(sender As Object, e As EventArgs) Handles lab1Btn.Click
        isPanelVisible2(lab1SchedPanel, r302Panel, r303Panel, r304Panel, r301Panel, lab2SchedPanel)
    End Sub

    Private Sub lab2Btn_Click(sender As Object, e As EventArgs) Handles lab2Btn.Click
        isPanelVisible2(lab2SchedPanel, r302Panel, r303Panel, r304Panel, lab1SchedPanel, r301Panel)
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        lab2SchedPanel.Visible = False
    End Sub


End Class