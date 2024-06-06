Public Class SEARCH_CAMPUS
    Private Sub SEARCH_CAMPUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainDB_User.Show()

    End Sub

    Sub locate(mainPanel As Panel, pan1 As Panel, pan2 As Panel, pan3 As Panel, pan4 As Panel, pan5 As Panel)
        mainPanel.Visible = True
        pan1.Visible = False
        pan2.Visible = False
        pan3.Visible = False
        pan4.Visible = False
        pan5.Visible = False
    End Sub

    Private Sub locate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles toCBox.SelectedIndexChanged, fromCBox.SelectedIndexChanged
        If fromCBox.SelectedItem = "ADMIN BUILDING" And toCBox.SelectedItem = "PRRC BUILDING" Then
            locate(AdminToPRRC, AdmintoNewBLDG, NewBLDGtoAdmin, NewBLDGtoPRRC, PRRCtoAdmin, PRRCtoNewBLDG)
        ElseIf fromCBox.SelectedItem = "ADMIN BUILDING" And toCBox.SelectedItem = "YNARES BUILDING" Then
            locate(AdmintoNewBLDG, AdminToPRRC, NewBLDGtoAdmin, NewBLDGtoPRRC, PRRCtoAdmin, PRRCtoNewBLDG)
        ElseIf fromCBox.SelectedItem = "YNARES BUILDING" And toCBox.SelectedItem = "ADMIN BUILDING" Then
            locate(NewBLDGtoAdmin, AdminToPRRC, AdmintoNewBLDG, NewBLDGtoPRRC, PRRCtoAdmin, PRRCtoNewBLDG)
        ElseIf fromCBox.SelectedItem = "YNARES BUILDING" And toCBox.SelectedItem = "PRRC BUILDING" Then
            locate(NewBLDGtoPRRC, AdminToPRRC, AdmintoNewBLDG, NewBLDGtoAdmin, PRRCtoAdmin, PRRCtoNewBLDG)
        ElseIf fromCBox.SelectedItem = "PRRC BUILDING" And toCBox.SelectedItem = "ADMIN BUILDING" Then
            locate(PRRCtoAdmin, AdminToPRRC, AdmintoNewBLDG, NewBLDGtoAdmin, NewBLDGtoPRRC, PRRCtoNewBLDG)
        ElseIf fromCBox.SelectedItem = "PRRC BUILDING" And toCBox.SelectedItem = "YNARES BUILDING" Then
            locate(PRRCtoNewBLDG, AdminToPRRC, AdmintoNewBLDG, NewBLDGtoAdmin, NewBLDGtoPRRC, PRRCtoAdmin)
        Else
            AdminToPRRC.Visible = False
            AdmintoNewBLDG.Visible = False
            NewBLDGtoAdmin.Visible = False
            NewBLDGtoPRRC.Visible = False
            PRRCtoAdmin.Visible = False
            PRRCtoNewBLDG.Visible = False
        End If
    End Sub
End Class