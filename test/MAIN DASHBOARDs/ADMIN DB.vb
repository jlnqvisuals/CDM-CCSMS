Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class ADMIN_DB
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












    Private Sub ADMIN_DB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData1()
        AcceptedData1()
        DisplayData2()
        AcceptedData2()
    End Sub


    Sub DisplayData1()
        Dim query As String = "SELECT * FROM lab1sched WHERE Approved = 0"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                Dim dataTable As New DataTable()

                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                reviewGrid.DataSource = dataTable
            End Using
        End Using
    End Sub

    Sub DisplayData2()
        Dim query As String = "SELECT * FROM lab2sched WHERE Approved = 0"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                Dim dataTable As New DataTable()

                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                reviewGrid2.DataSource = dataTable
            End Using
        End Using
    End Sub

    Sub AcceptedData1()
        Dim query As String = "SELECT * FROM lab1sched WHERE Approved = 1"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                Dim dataTable As New DataTable()

                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                acceptedGrid.DataSource = dataTable
            End Using
        End Using
        For Each column As DataGridViewColumn In reviewGrid.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Sub AcceptedData2()
        Dim query As String = "SELECT * FROM lab2sched WHERE Approved = 1"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                Dim dataTable As New DataTable()

                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                acceptedGrid2.DataSource = dataTable
            End Using
        End Using
        For Each column As DataGridViewColumn In reviewGrid.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Private Sub acceptBtn_Click(sender As Object, e As EventArgs) Handles acceptBtn.Click
        Dim ID As Integer = reviewGrid.SelectedRows(0).Cells("ID").Value

        Dim updateQuery = "UPDATE lab1sched SET Approved = 1 WHERE ID = @ID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@ID", ID)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
        DisplayData1()
        AcceptedData1()
    End Sub

    Private Sub rejectBtn_Click(sender As Object, e As EventArgs) Handles rejectBtn.Click
        Dim ID As Integer = CInt(reviewGrid.SelectedRows(0).Cells("ID").Value)

        Dim deleteQuery As String = "DELETE FROM lab1sched WHERE ID = @ID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(deleteQuery, connection)
                command.Parameters.AddWithValue("@ID", ID)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
        DisplayData1()
        AcceptedData1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        acceptedLogPanel.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub schedLogBtn_Click(sender As Object, e As EventArgs) Handles schedLogBtn.Click
        acceptedLogPanel.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ADMIN_MENU_DB.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AcceptedData1()
        DisplayData1()
        DisplayData2()
        AcceptedData2()
    End Sub

    Private Sub acceptBtn2_Click(sender As Object, e As EventArgs) Handles acceptBtn2.Click
        Dim ID As Integer = reviewGrid2.SelectedRows(0).Cells("ID").Value

        Dim updateQuery = "UPDATE lab2sched SET Approved = 1 WHERE ID = @ID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@ID", ID)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
        DisplayData2()
        AcceptedData2()



    End Sub

    Private Sub rejectBtn2_Click(sender As Object, e As EventArgs) Handles rejectBtn2.Click
        Dim ID As Integer = CInt(reviewGrid2.SelectedRows(0).Cells("ID").Value)

        Dim deleteQuery As String = "DELETE FROM lab2sched WHERE ID = @ID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(deleteQuery, connection)
                command.Parameters.AddWithValue("@ID", ID)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
        DisplayData2()
        AcceptedData2()
    End Sub
End Class