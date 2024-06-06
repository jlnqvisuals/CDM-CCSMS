Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class ADMIN_DB
    Private connectionString As String = "server=localhost;userid=root;password=;database=prac"
    Private connection As MySqlConnection

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