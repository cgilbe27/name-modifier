Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.IAgree = True
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BringToFront()
        Dim cnt As Control
        For Each cnt In Controls
            cnt.ForeColor = My.Settings.SavedForeColor
        Next cnt

        Dim cnt2 As Control
        For Each cnt2 In Controls
            cnt2.BackColor = My.Settings.SavedBackColor
        Next cnt2
        Me.BackColor = My.Settings.SavedBackColor
        Me.ForeColor = My.Settings.SavedForeColor
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
        My.Settings.IAgree = False
    End Sub
End Class