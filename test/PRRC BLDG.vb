Public Class PRRC_BLDG
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
        lab1SchedPanel.Visible = True
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
End Class