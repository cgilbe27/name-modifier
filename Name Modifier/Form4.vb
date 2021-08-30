Public Class Form4

    Private Sub CCPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCPToolStripMenuItem.Click
        grpCImages.Text = "WiiMote and Nunchuck Images"
        radA.Text = "A"
        radB.Hide()
        radMinus.Show()
        radX.Hide()
        rad2.Show()
        radY.Hide()
        rad1.Show()
        radL.Hide()
        radNun.Show()
        RadR.Hide()
        radWii.Show()
        radPA.Text = "Pressed A"
        radPB.Text = "Pressed B"
        radPX.Text = "Pressed X"
        radC.Text = "C"
        radZL.Hide()
        radZ.Show()
        radZR.Hide()
        radWiiB.Show()
        radUp.Text = "Up Dpad"
        radDown.Text = "Down Dpad"
        radLeft.Text = "Left Dpad"
        radRight.Text = "Right Dpad"
        radRed.Text = "Red Arrow"
        radBlue.Text = "Blue Arrow"
        radWiiA.Show()
        radWiiC.Show()
        radWiiUp.Show()
        radWiiDown.Show()
        radWiiRight.Show()
        radWiiLeft.Show()
    End Sub

    Private Sub WiiMoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WiiMoteToolStripMenuItem.Click
        grpCImages.Text = "CCP Images"
        radA.Text = "A"
        radB.Show()
        radMinus.Hide()
        radX.Show()
        rad2.Hide()
        radY.Show()
        rad1.Hide()
        radL.Show()
        radNun.Hide()
        RadR.Show()
        radWii.Hide()
        radPA.Text = "Pressed A"
        radPB.Text = "Pressed B"
        radPX.Text = "Pressed X"
        radC.Text = "C"
        radZL.Show()
        radZ.Hide()
        radZR.Show()
        radWiiB.Hide()
        radUp.Text = "Up Dpad"
        radDown.Text = "Down Dpad"
        radLeft.Text = "Left Dpad"
        radRight.Text = "Right Dpad"
        radRed.Text = "Red Arrow"
        radBlue.Text = "Blue Arrow"
        radWiiA.Hide()
        radWiiC.Hide()
        radWiiUp.Hide()
        radWiiDown.Hide()
        radWiiRight.Hide()
        radWiiLeft.Hide()
    End Sub

    Private Sub btnImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImage.Click
        If Form1.tbCode.Text.Length > 48 Then
            MessageBox.Show("You have entered to many characters into your code", "Error: Application click has stopped", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("Please rethink your name so that it will fit into the code correctly", "Error: Application click has stopped", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo That
        End If
        If radA.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "01"
        ElseIf radWiiA.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "01"
        ElseIf radB.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "02"
        ElseIf radMinus.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "02"
        ElseIf radX.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "03"
        ElseIf rad2.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "03"
        ElseIf radY.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "04"
        ElseIf rad1.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "04"
        ElseIf radL.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "05"
        ElseIf radNun.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "05"
        ElseIf RadR.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "06"
        ElseIf radWii.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "06"
        ElseIf radPA.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "07"
        ElseIf radPB.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "08"
        ElseIf radPX.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "09"
        ElseIf radC.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "10"
        ElseIf radWiiC.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "10"
        ElseIf radZL.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "12"
        ElseIf radZ.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "12"
        ElseIf radZR.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "13"
        ElseIf radWiiB.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "13"
        ElseIf radUp.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "14"
        ElseIf radDown.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "15"
        ElseIf radLeft.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "16"
        ElseIf radRight.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "17"
        ElseIf radRed.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "18"
        ElseIf radBlue.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "19"
        ElseIf radWiiUp.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "14"
        ElseIf radWiiDown.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "15"
        ElseIf radWiiLeft.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "16"
        ElseIf radWiiRight.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "17"
        ElseIf RadioButton2.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "0B"
        ElseIf RadioButton1.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "0C"
        ElseIf RadioButton3.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "1B"
        ElseIf RadioButton4.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "0E"
        ElseIf RadioButton5.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "1D"
        ElseIf RadioButton6.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "1C"
        ElseIf RadioButton7.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "1F"
        ElseIf RadioButton8.Checked Then
            Form1.tbCode.Text = Form1.tbCode.Text + "1E"
            End If
That:
    End Sub

    Private Sub radA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radA.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPA.BringToFront()
    End Sub

    Private Sub radWiiA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radWiiA.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiA.BringToFront()
    End Sub

    Private Sub radB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radB.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPB.BringToFront()

    End Sub

    Private Sub radMinus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMinus.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiMinus.BringToFront()
    End Sub

    Private Sub radX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radX.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPX.BringToFront()
    End Sub

    Private Sub rad2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad2.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWii2.BringToFront()
    End Sub

    Private Sub radY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radY.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPY.BringToFront()
    End Sub

    Private Sub rad1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad1.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWii1.BringToFront()
    End Sub

    Private Sub radL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radL.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPL.BringToFront()
    End Sub

    Private Sub radNun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNun.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiNun.BringToFront()
    End Sub

    Private Sub radPA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPA.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiPA.BringToFront()
    End Sub

    Private Sub radPB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPB.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiPB.BringToFront()
    End Sub

    Private Sub radPX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPX.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiPX.BringToFront()
    End Sub

    Private Sub RadR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadR.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPR.BringToFront()
    End Sub

    Private Sub radWii_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radWii.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiMote.BringToFront()
    End Sub

    Private Sub radC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radC.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPC.BringToFront()
    End Sub

    Private Sub radWiiC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radWiiC.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiC.BringToFront()
    End Sub

    Private Sub radZL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radZL.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPZL.BringToFront()
    End Sub

    Private Sub radZ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radZ.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiZ.BringToFront()
    End Sub

    Private Sub radZR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radZR.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPZR.BringToFront()
    End Sub

    Private Sub radWiiB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radWiiB.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiB.BringToFront()
    End Sub

    Private Sub radUp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radUp.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPUp.BringToFront()
    End Sub

    Private Sub radWiiUp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radWiiUp.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiUp.BringToFront()
    End Sub

    Private Sub radDown_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDown.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPDown.BringToFront()
    End Sub

    Private Sub radWiiDown_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radWiiDown.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiDown.BringToFront()
    End Sub

    Private Sub radLeft_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLeft.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPLeft.BringToFront()
    End Sub

    Private Sub radWiiLeft_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radWiiLeft.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiLeft.BringToFront()
    End Sub

    Private Sub radRight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRight.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPRight.BringToFront()
    End Sub

    Private Sub radWiiRight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radWiiRight.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiRight.BringToFront()
    End Sub

    Private Sub radRed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRed.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbRed.BringToFront()
    End Sub

    Private Sub radBlue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBlue.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbBlue.BringToFront()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        radA.Text = "A"
        radB.Show()
        radMinus.Hide()
        radX.Show()
        rad2.Hide()
        radY.Show()
        rad1.Hide()
        radL.Show()
        radNun.Hide()
        RadR.Show()
        radWii.Hide()
        radPA.Text = "Pressed A"
        radPB.Text = "Pressed B"
        radPX.Text = "Pressed X"
        radC.Text = "C"
        radZL.Show()
        radZ.Hide()
        radZR.Show()
        radWiiB.Hide()
        radUp.Text = "Up Dpad"
        radDown.Text = "Down Dpad"
        radLeft.Text = "Left Dpad"
        radRight.Text = "Right Dpad"
        radRed.Text = "Red Arrow"
        radBlue.Text = "Blue Arrow"
        radWiiA.Hide()
        radWiiC.Hide()
        radWiiUp.Hide()
        radWiiDown.Hide()
        radWiiRight.Hide()
        radWiiLeft.Hide()
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
        pbBlank.BackColor = My.Settings.SavedBackColor



        For Each blah As ToolStripMenuItem In MenuStrip1.Items
            blah.BackColor = My.Settings.SavedBackColor
            blah.ForeColor = My.Settings.SavedForeColor
            For Each meh As ToolStripMenuItem In blah.DropDownItems
                meh.BackColor = My.Settings.SavedBackColor
                meh.ForeColor = My.Settings.SavedForeColor
                For Each lolCat As ToolStripMenuItem In meh.DropDownItems
                    lolCat.BackColor = My.Settings.SavedBackColor
                    lolCat.ForeColor = My.Settings.SavedForeColor
                Next
            Next
        Next
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPZL.BringToFront()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbCCPZR.BringToFront()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.PictureBox1.BringToFront()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiMinus.BringToFront()
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiUp.BringToFront()
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiDown.BringToFront()
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiLeft.BringToFront()
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        Me.pbBlank.BringToFront()
        Me.pbWiiRight.BringToFront()
    End Sub

    Private Sub RefreshFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshFormToolStripMenuItem.Click
        Form1.id = 4
        Form1.Timer1.Start()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.tbCode.Text = Form1.tbCode.Text + "5E36"
    End Sub
End Class