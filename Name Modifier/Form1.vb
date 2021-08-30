Option Explicit On

Imports System.IO



Public Class Form1
    Public id As Integer
    Private Sub btnImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImage.Click
        If tbCode.Text.Length > 48 Then
            MessageBox.Show("You have entered to many characters into your code", "Error: Application click has stopped", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("Please rethink your name so that it will fit into the code correctly", "Error: Application click has stopped", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo That
        End If
        If radA.Checked Then
            tbCode.Text = tbCode.Text + "01"
        ElseIf radWiiA.Checked Then
            tbCode.Text = tbCode.Text + "01"
        ElseIf radB.Checked Then
            tbCode.Text = tbCode.Text + "02"
        ElseIf radMinus.Checked Then
            tbCode.Text = tbCode.Text + "02"
        ElseIf radX.Checked Then
            tbCode.Text = tbCode.Text + "03"
        ElseIf rad2.Checked Then
            tbCode.Text = tbCode.Text + "03"
        ElseIf radY.Checked Then
            tbCode.Text = tbCode.Text + "04"
        ElseIf rad1.Checked Then
            tbCode.Text = tbCode.Text + "04"
        ElseIf radL.Checked Then
            tbCode.Text = tbCode.Text + "05"
        ElseIf radNun.Checked Then
            tbCode.Text = tbCode.Text + "05"
        ElseIf RadR.Checked Then
            tbCode.Text = tbCode.Text + "06"
        ElseIf radWii.Checked Then
            tbCode.Text = tbCode.Text + "06"
        ElseIf radPA.Checked Then
            tbCode.Text = tbCode.Text + "07"
        ElseIf radPB.Checked Then
            tbCode.Text = tbCode.Text + "08"
        ElseIf radPX.Checked Then
            tbCode.Text = tbCode.Text + "09"
        ElseIf radC.Checked Then
            tbCode.Text = tbCode.Text + "10"
        ElseIf radWiiC.Checked Then
            tbCode.Text = tbCode.Text + "10"
        ElseIf radZL.Checked Then
            tbCode.Text = tbCode.Text + "12"
        ElseIf radZ.Checked Then
            tbCode.Text = tbCode.Text + "12"
        ElseIf radZR.Checked Then
            tbCode.Text = tbCode.Text + "13"
        ElseIf radWiiB.Checked Then
            tbCode.Text = tbCode.Text + "13"
        ElseIf radUp.Checked Then
            tbCode.Text = tbCode.Text + "14"
        ElseIf radDown.Checked Then
            tbCode.Text = tbCode.Text + "15"
        ElseIf radLeft.Checked Then
            tbCode.Text = tbCode.Text + "16"
        ElseIf radRight.Checked Then
            tbCode.Text = tbCode.Text + "17"
        ElseIf radRed.Checked Then
            tbCode.Text = tbCode.Text + "18"
        ElseIf radBlue.Checked Then
            tbCode.Text = tbCode.Text + "19"
        ElseIf radWiiUp.Checked Then
            tbCode.Text = tbCode.Text + "14"
        ElseIf radWiiDown.Checked Then
            tbCode.Text = tbCode.Text + "15"
        ElseIf radWiiLeft.Checked Then
            tbCode.Text = tbCode.Text + "16"
        End If
        If radWiiRight.Checked Then
            tbCode.Text = tbCode.Text + "17"
        End If
That:

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tbCode.Text.Length > 48 Then
            MessageBox.Show("You have entered to many characters into your code", "Error: Application click has stopped", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("Please rethink your name so that it will fit into the code correctly", "Error: Application click has stopped", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo That
        End If
        If tbLetters.Text.Length > 24 Then
            MessageBox.Show("You have entered to many characters, you need 24 or less", "Error: Application click has stopped", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo That
        End If
        Dim str As String = tbLetters.Text
        Dim byteArray() As Byte
        Dim hexNumbers As System.Text.StringBuilder = New System.Text.StringBuilder

        byteArray = System.Text.ASCIIEncoding.ASCII.GetBytes(str)

        For i As Integer = 0 To byteArray.Length - 1
            hexNumbers.Append(byteArray(i).ToString("x"))
        Next
        tbCode.Text = tbCode.Text & hexNumbers.ToString()
        tbCode.Text = tbCode.Text.Replace("f", "F")
        tbCode.Text = tbCode.Text.Replace("e", "E")
        tbCode.Text = tbCode.Text.Replace("d", "D")
        tbCode.Text = tbCode.Text.Replace("c", "C")
        tbCode.Text = tbCode.Text.Replace("b", "B")
        tbCode.Text = tbCode.Text.Replace("a", "A")
This:

That:

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        tbCode.Text = ""
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        Application.Exit()
    End Sub

    Private Sub CCPToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCPToolStripMenuItem2.Click
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

    Private Sub WiiMoteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WiiMoteToolStripMenuItem1.Click
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

    Private Sub CodesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodesToolStripMenuItem2.Click
        Form3.Show()
    End Sub

    Private Sub AboutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem2.Click
        Form2.Show()
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
    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Dim FileWriter As StreamWriter
        Dim results As DialogResult
        results = SaveFileDialog1.ShowDialog
        If results = DialogResult.OK Then
            FileWriter = New StreamWriter(SaveFileDialog1.FileName, False)
            FileWriter.WriteLine(tbCode.Text)
            FileWriter.Close()
        End If
    End Sub
    Private Sub DonateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonateToolStripMenuItem.Click
        Dim objBrowser As Object

        objBrowser = CreateObject("InternetExplorer.Application")
        objBrowser.Visible = True
        objBrowser.Left = 0
        objBrowser.Top = 0
        objBrowser.Width = 1200
        objBrowser.Height = 1000
        objBrowser.navigate("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=MDPAQ7YMY4JHA")
        objBrowser = Nothing
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        tbPreview.Text = Nothing
        Dim str, idx, c

        str = vbNullString
        For idx = 1 To Len(tbCode.Text) Step 2

            c = "&H" & Mid(tbCode.Text, idx, 2)
            If Mid(tbCode.Text, idx, 2) = "01" Then
                str = str & "(A Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "02" And grpCImages.Text = "WiiMote and Nunchuck Images" Then
                str = str & "(Minus Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "02" And grpCImages.Text = "CCP Images" Then
                str = str & "(B Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "03" And grpCImages.Text = "WiiMote and Nunchuck Images" Then
            str = str & "(2 Button)"
            GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "03" And grpCImages.Text = "CCP Images" Then
                str = str & "(X Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "04" And grpCImages.Text = "WiiMote and Nunchuck Images" Then
                str = str & "(1 Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "04" And grpCImages.Text = "CCP Images" Then
                str = str & "(Y Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "05" And grpCImages.Text = "WiiMote and Nunchuck Images" Then
                str = str & "(Nunchuck)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "05" And grpCImages.Text = "CCP Images" Then
                str = str & "(L Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "06" And grpCImages.Text = "CCP Images" Then
                str = str & "(R Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "06" And grpCImages.Text = "WiiMote and Nunchuck Images" Then
                str = str & "(WiiMote)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "07" Then
                str = str & "(Pressed A)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "08" Then
                str = str & "(Pressed B)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "09" Then
                str = str & "(Pressed X)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "10" Then
                str = str & "(C Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "12" And grpCImages.Text = "CCP Images" Then
                str = str & "(ZL Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "12" And grpCImages.Text = "WiiMote and Nunchuck Images" Then
                str = str & "(Z Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "13" And grpCImages.Text = "CCP Images" Then
                str = str & "(ZR Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "13" And grpCImages.Text = "WiiMote and Nunchuck Images" Then
                str = str & "(B Button)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "14" Then
                str = str & "(Up Dpad)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "15" Then
                str = str & "(Down Dpad)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "16" Then
                str = str & "(Left Dpad)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "17" Then
                str = str & "(Right Dpad)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "18" Then
                str = str & "(Red Arrow)"
                GoTo That
            ElseIf Mid(tbCode.Text, idx, 2) = "19" Then
                str = str & "(Blue Arrow)"
                GoTo That
            End If
            str = str & Chr(c)
That:

        Next
        tbPreview.Text = str
        tbPreview.Text = tbPreview.Text.Replace("^1", "(Color: Red)")
        tbPreview.Text = tbPreview.Text.Replace("^2", "(Color: Green)")
        tbPreview.Text = tbPreview.Text.Replace("^3", "(Color: Yellow)")
        tbPreview.Text = tbPreview.Text.Replace("^4", "(Color: Dark Blue)")
        tbPreview.Text = tbPreview.Text.Replace("^5", "(Color: Cyan)")
        tbPreview.Text = tbPreview.Text.Replace("^6", "(Color: Orange)")
        tbPreview.Text = tbPreview.Text.Replace("^7", "(Color: Default(White))")
        tbPreview.Text = tbPreview.Text.Replace("^8", "(Color: Gray)")
        tbPreview.Text = tbPreview.Text.Replace("^9", "(Color: Brown)")
        tbPreview.Text = tbPreview.Text.Replace("^0", "(Color: Black)")

    End Sub

    Private Sub tbLetters_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLetters.Click
        tbLetters.Text = Nothing
        Cursor.Current = Cursors.IBeam
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.Click
        MessageBox.Show("This program was made by BLiTz*", "Made by:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ForeColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForeColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Dim Universal_Color As Color = ColorDialog1.Color
        Me.ForeColor = Universal_Color
        My.Settings.SavedForeColor = ForeColor
        My.Settings.Save()

        Dim cnt As Control
        For Each cnt In Controls
            cnt.ForeColor = My.Settings.SavedForeColor
        Next cnt



        For Each blah As ToolStripMenuItem In MenuStrip1.Items
            blah.ForeColor = My.Settings.SavedForeColor
            For Each meh As ToolStripMenuItem In blah.DropDownItems
                meh.ForeColor = My.Settings.SavedForeColor
                For Each lolCat As ToolStripMenuItem In meh.DropDownItems
                    lolCat.ForeColor = My.Settings.SavedForeColor
                Next
            Next
        Next
        MessageBox.Show("Please close all forms except this one for the change to take place")

    End Sub

    Private Sub BackColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Dim Universal_Color As Color = ColorDialog1.Color
        Me.BackColor = Universal_Color
        My.Settings.SavedBackColor = BackColor
        My.Settings.Save()

        Dim cnt As Control
        For Each cnt In Controls
            cnt.BackColor = My.Settings.SavedBackColor
        Next cnt

        pbBlank.BackColor = My.Settings.SavedBackColor
        tbCode.BackColor = My.Settings.SavedBackColor

        For Each blah As ToolStripMenuItem In MenuStrip1.Items
            blah.BackColor = My.Settings.SavedBackColor
            For Each meh As ToolStripMenuItem In blah.DropDownItems
                meh.BackColor = My.Settings.SavedBackColor
                For Each lolCat As ToolStripMenuItem In meh.DropDownItems
                    lolCat.BackColor = My.Settings.SavedBackColor
                Next
            Next
        Next
        MessageBox.Show("Please close all forms except this one for the change to take place")
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Dim cnt As Control
        For Each cnt In Controls
            cnt.ForeColor = Color.FromArgb(224, 224, 224)
        Next cnt

        Dim cnt2 As Control
        For Each cnt2 In Controls
            cnt2.BackColor = Color.DimGray
        Next cnt2
        pbBlank.BackColor = Color.DimGray
        Me.BackColor = Color.DimGray
        tbCode.BackColor = Color.DimGray
        My.Settings.SavedBackColor = Color.DimGray
        My.Settings.Save()
        My.Settings.SavedForeColor = Color.FromArgb(224, 224, 224)
        My.Settings.Save()

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

    Private Sub cmbColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbColor.SelectedIndexChanged
        If tbCode.Text.Length > 48 Then
            MessageBox.Show("You have entered to many characters into your code", "Error: Application click has stopped", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("Please rethink your name so that it will fit into the code correctly", "Error: Application click has stopped", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GoTo That
        End If
        If cmbColor.Text = "Red" Then
            tbCode.Text = tbCode.Text & "5E31"
        ElseIf cmbColor.Text = "Green" Then
            tbCode.Text = tbCode.Text & "5E32"
        ElseIf cmbColor.Text = "Yellow" Then
            tbCode.Text = tbCode.Text & "5E33"
        ElseIf cmbColor.Text = "Dark Blue" Then
            tbCode.Text = tbCode.Text & "5E34"
        ElseIf cmbColor.Text = "Cyan(Light Blue)" Then
            tbCode.Text = tbCode.Text & "5E35"
        ElseIf cmbColor.Text = "Orange" Then
            tbCode.Text = tbCode.Text & "5E36"
        ElseIf cmbColor.Text = "Default(white)" Then
            tbCode.Text = tbCode.Text & "5E37"
        ElseIf cmbColor.Text = "Gray" Then
            tbCode.Text = tbCode.Text & "5E38"
        ElseIf cmbColor.Text = "Brown" Then
            tbCode.Text = tbCode.Text & "5E39"
        ElseIf cmbColor.Text = "Black" Then
            tbCode.Text = tbCode.Text & "5E30"
        End If
That:
    End Sub

    Private Sub MW3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MW3ToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tbCode.Text = tbCode.Text & "0A"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If id = 3 Then
            Form3.Show()
        End If
        If id = 4 Then
            Form4.Show()
        End If
        Timer1.Stop()
    End Sub
End Class
