Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class RootDB

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




    Sub DisplayData()
        Dim query As String = "SELECT * FROM user_data"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                Dim dataTable As New DataTable()

                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                accountGrid.DataSource = dataTable
            End Using
        End Using
    End Sub

    Private Sub DeleteSelectedRow()
        If accountGrid.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = accountGrid.SelectedRows(0).Index
            Dim row As DataGridViewRow = accountGrid.Rows(rowIndex)
            Dim SID As String = row.Cells("Student ID").Value.ToString()

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Delete Row", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Using connection As New MySqlConnection(connectionString)
                    Dim query As String = "DELETE FROM user_data WHERE `Student ID` = @SID"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@SID", SID)
                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Refresh the DataGridView
                DisplayData()
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub RootDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayData()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeleteSelectedRow()
    End Sub









    Private Sub RootDB_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the label text with the current date and time in the desired format
        DateTime_Label.Text = DateTime.Now.ToString("dddd - MMMM dd yyyy HH:mm tt")
        ' Start the timer
        DnT.Start()
    End Sub

    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DnT.Tick
        ' Update the label with the current date and time in the desired format
        DateTime_Label.Text = DateTime.Now.ToString("dddd - MMMM dd yyyy HH:mm tt")
    End Sub

    Private Sub DateTime_Label_Click(sender As Object, e As EventArgs) Handles DateTime_Label.Click
        ' You can leave this event handler empty or add any additional actions you want to perform when the label is clicked.
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        EXIT_PROMPT.Show()
        'Me.Close()
    End Sub

    Private Sub MinBTN_Click(sender As Object, e As EventArgs) Handles MinBTN.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        LOGIN_PAGE.Show()


    End Sub
End Class