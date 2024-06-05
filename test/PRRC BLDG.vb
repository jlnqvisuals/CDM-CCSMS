Imports System.Net
Imports MySql.Data.MySqlClient

Public Class PRRC_BLDG
    Private connectionString As String = "server=localhost;userid=root;password=;database=prac"
    Private connection As MySqlConnection

    Public Shared desiredtime As String = ""

    Private Sub PRRC_BLDG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label16.Text = DateTime.Now.ToString("dddd - MMMM dd yyyy HH:mm tt")
        ' Start the timer
        updateDB.Interval = 1000
        updateDB.Start()
        Timer1.Start()
        checkAvailability("7:00-8:00", roomsched1)
    End Sub

    Private Sub r101backBtn_Click(sender As Object, e As EventArgs) Handles r101backBtn.Click
        r101Panel.Hide()
    End Sub

    Private Sub r101Btn_Click(sender As Object, e As EventArgs) Handles r101Btn.Click
        r101Panel.Show()
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

    Private Sub lab1Btn_Click(sender As Object, e As EventArgs) Handles lab1Btn.Click
        If lab1SchedPanel.Visible = False Then
            lab1SchedPanel.Visible = True
        Else
            lab1SchedPanel.Visible = False
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
    End Sub

    Sub checkAvailability(schedtime As String, Button As Button)
        Dim time As String = schedtime
        Dim query As String = "SELECT Approved FROM lab1sched WHERE Time = @Time"

        ' Create a connection
        Using connection As New MySqlConnection(connectionString)
            ' Create a command
            Using command As New MySqlCommand(query, connection)
                ' Add the parameter to the command
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

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles roomsched1.Click
        _7to8amSched.Show()
    End Sub

    Private Sub Button51_Click_1(sender As Object, e As EventArgs) Handles Button51.Click
        Me.Hide()
        NAVIGATE_CAMPUS.Show()
    End Sub

    Private Sub updateDB_Tick(sender As Object, e As EventArgs) Handles updateDB.Tick
        checkAvailability("7:00-8:00", roomsched1)
        checkAvailability("8:00-9:00", roomsched2)
        checkAvailability("9:00-10:00", roomsched3)
        checkAvailability("10:00-11:00", roomsched4)
        checkAvailability("11:00-12:00", roomsched5)
        checkAvailability("12:00-1:00", roomsched6)
        checkAvailability("1:00-2:00", roomsched7)
        checkAvailability("2:00-3:00", roomsched8)
        checkAvailability("3:00-4:00", roomsched9)
        checkAvailability("4:00-5:00", roomsched10)
    End Sub
End Class