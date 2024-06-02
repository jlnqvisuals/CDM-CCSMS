Public Class NAVIGATE_CAMPUS

    Private Sub NAVIGATE_CAMPUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adminBldgPanel.Hide()
        prrcBldgPanel.Hide()
        newBldgPanel.Hide()
    End Sub

    Private Sub adminBldgBtn_Click(sender As Object, e As EventArgs) Handles adminBldgBtn.Click
        prrcBldgPanel.Hide()
        newBldgPanel.Hide()
        adminBldgPanel.Show()

    End Sub

    Private Sub newBldgBtn_Click(sender As Object, e As EventArgs) Handles newBldgBtn.Click
        adminBldgPanel.Hide()
        prrcBldgPanel.Hide()
        newBldgPanel.Show()
    End Sub

    Private Sub prrcBldgBtn_Click(sender As Object, e As EventArgs) Handles prrcBldgBtn.Click
        adminBldgPanel.Hide()
        newBldgPanel.Hide()
        prrcBldgPanel.Show()
    End Sub

    Private Sub newNavBtn_Click(sender As Object, e As EventArgs) Handles newNavBtn.Click

    End Sub

    Private Sub newBackBtn_Click(sender As Object, e As EventArgs) Handles newBackBtn.Click
        newBldgPanel.Hide()
    End Sub

    Private Sub adminNavBtn_Click(sender As Object, e As EventArgs) Handles adminNavBtn.Click

    End Sub

    Private Sub adminBackBtn_Click(sender As Object, e As EventArgs) Handles adminBackBtn.Click
        adminBldgPanel.Hide()
    End Sub

    Private Sub prrcNavBtn_Click(sender As Object, e As EventArgs) Handles prrcNavBtn.Click
        PRRC_BLDG.Show()
    End Sub

    Private Sub prrcBackBtn_Click(sender As Object, e As EventArgs) Handles prrcBackBtn.Click
        prrcBldgPanel.Hide()
    End Sub


End Class