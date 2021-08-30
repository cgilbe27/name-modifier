Public Class Spash
    Private x2 As Integer = 1


    Private Sub Timer13_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer13.Tick
        Label1.Text = Label1.Text & "."
        x2 = x2 + 1
        If x2 = 10 Then
            If My.Settings.IAgree = True Then
                Form1.Show()
                Me.Close()
            Else
                Form2.Show()
                Me.Close()
            End If


        End If
    End Sub
End Class