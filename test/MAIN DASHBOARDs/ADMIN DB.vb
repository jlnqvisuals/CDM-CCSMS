Imports MySql.Data.MySqlClient

Public Class ADMIN_DB
    Private connectionString As String = "server=localhost;userid=root;password=;database=prac"
    Private connection As MySqlConnection

    Private Sub ADMIN_DB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData()
        AcceptedData()
    End Sub


    Sub DisplayData()
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

    Sub AcceptedData()
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

    Private Sub acceptBtn_Click(sender As Object, e As EventArgs) Handles acceptBtn.Click
        Dim ID As Integer = CInt(reviewGrid.SelectedRows(0).Cells("ID").Value)

        Dim updateQuery As String = "UPDATE lab1sched SET Approved = 1 WHERE ID = @ID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@ID", ID)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
        DisplayData()
        AcceptedData()
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles rejectBtn.Click
        Dim ID As Integer = CInt(reviewGrid.SelectedRows(0).Cells("ID").Value)

        Dim deleteQuery As String = "DELETE FROM lab1sched WHERE ID = @ID"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(deleteQuery, connection)
                command.Parameters.AddWithValue("@ID", ID)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
        DisplayData()
        AcceptedData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        acceptedLogPanel.Hide()
    End Sub

    Private Sub schedLogBtn_Click(sender As Object, e As EventArgs) Handles schedLogBtn.Click
        acceptedLogPanel.Visible = True
        acceptedLogPanel.Show()
        acceptedLogPanel.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        LOGIN_PAGE.Show()
    End Sub
End Class