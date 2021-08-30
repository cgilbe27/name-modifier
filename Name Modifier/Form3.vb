Imports System.IO

Public Class Form3

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnReX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReX.Click
        On Error GoTo That
        Dim FileWriter As StreamWriter
        Dim results As DialogResult
        results = SaveFileDialog1.ShowDialog
        If results = DialogResult.OK Then
            FileWriter = New StreamWriter(SaveFileDialog1.FileName, False)
            FileWriter.WriteLine()
            If tbCode.Text.Contains("[777eThOd*]") Then
                FileWriter.WriteLine("SC7E52")
                FileWriter.WriteLine("Call of Duty: Black Ops")
            Else
                FileWriter.WriteLine("SM8E52")
                FileWriter.WriteLine("Modern Warfare 3")
            End If
            FileWriter.WriteLine()
            FileWriter.WriteLine(tbCode.Text)
            FileWriter.WriteLine()
            FileWriter.Close()
        End If
        unload()
        MessageBox.Show("Now open the .txt file you saved", "Please Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
That:
    End Sub
    Sub unload()
        Dim assembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim root As String = assembly.GetName().Name
        Dim f As New IO.FileStream("codemgr.exe", IO.FileMode.Create, IO.FileAccess.Write)
        Dim buffer() As Byte = My.Resources.codemgr
        f.Write(buffer, 0, buffer.Length)
        f.Close()
        Process.Start("codemgr.exe")
    End Sub

    Private Sub CCPToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCPToolStripMenuItem3.Click
        tbCode.Text = "28200F0A 00000800" + vbCrLf + "06B0AAE4 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 4 Name Modifier CCP (HOME): [777eThOd*]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub CCPToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCPToolStripMenuItem2.Click
        tbCode.Text = "28200F0A 00000800" + vbCrLf + "06B0AAC4 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 3 Name Modifier CCP (HOME): [777eThOd*]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub CCPToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)Handles CCPToolStripMenuItem1.click
        tbCode.Text = "28200F0A 00000800" + vbCrLf + "06B0AAA4 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 2 Name Modifier CCP (HOME): [777eThOd*]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub CCPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCPToolStripMenuItem.Click
        tbCode.Text = "28200F0A 00000800" + vbCrLf + "06B0AA84 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 1 Name Modifier CCP (HOME): [777eThOd*]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub WiiMoteToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WiiMoteToolStripMenuItem3.Click
        tbCode.Text = "28200FA0 00008000" + vbCrLf + "06B0AAE4 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 4 Name Modifier Wiimote/Nunchuck (HOME): [777eThOd*]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub WiiMoteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WiiMoteToolStripMenuItem2.Click
        tbCode.Text = "28200FA0 00008000" + vbCrLf + "06B0AAC4 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 3 Name Modifier Wiimote/Nunchuck (HOME): [777eThOd*]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub WiiMoteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WiiMoteToolStripMenuItem1.Click
        tbCode.Text = "28200FA0 00008000" + vbCrLf + "06B0AAA4 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 2 Name Modifier Wiimote/Nunchuck (HOME): [777eThOd*]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub WiiMoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WiiMoteToolStripMenuItem.Click
        tbCode.Text = "28200FA0 00008000" + vbCrLf + "06B0AA84 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 1 Name Modifier Wiimote/Nunchuck (HOME): [777eThOd*]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        If Me.tbCode.Text.Contains("XXXXXXXX XXXXXXXX") Then
            Dim Number As String = tbCode.Text.IndexOf("XXXXXXXX XXXXXXXX")
            Dim Number2 As String = Me.tbCode.Text.Substring(Number)
            Me.tbCode.Text = Me.tbCode.Text.Replace(Number2, "#")
            If (Form1.tbCode.Text.Length < 16 And Form1.tbCode.Text.Length > 0) Then
                Me.tbCode.Text = Me.tbCode.Text.Replace("??", "08")
            End If
            If (Form1.tbCode.Text.Length < 32 And Form1.tbCode.Text.Length > 16) Then
                Me.tbCode.Text = Me.tbCode.Text.Replace("??", "10")
            End If
            If (Form1.tbCode.Text.Length < 48 And Form1.tbCode.Text.Length > 32) Then
                Me.tbCode.Text = Me.tbCode.Text.Replace("??", "18")
            End If
            If (Form1.tbCode.Text.Length < 64 And Form1.tbCode.Text.Length > 48) Then
                Me.tbCode.Text = Me.tbCode.Text.Replace("??", "20")
            End If

            Dim try1 As String
            Dim try2 As String
            Dim try3 As String
            Dim try4 As String
            Dim try5 As String
            Dim try6 As String
            Dim try7 As String
            Dim try8 As String
            Dim try9 As String
            Dim try10 As String
            Dim try11 As String
            Dim try12 As String
            Dim try13 As String
            Dim try14 As String
            Dim try15 As String
            Dim try16 As String
            Dim try17 As String
            Dim try18 As String
            Dim try19 As String
            Dim try20 As String
            Dim try21 As String
            Dim try22 As String
            Dim try23 As String
            Dim try24 As String
            try1 = (Mid$(Form1.tbCode.Text, 1, 2))
            try2 = (Mid$(Form1.tbCode.Text, 3, 2))
            try3 = (Mid$(Form1.tbCode.Text, 5, 2))
            try4 = (Mid$(Form1.tbCode.Text, 7, 2))
            try5 = (Mid$(Form1.tbCode.Text, 9, 2))
            try6 = (Mid$(Form1.tbCode.Text, 11, 2))
            try7 = (Mid$(Form1.tbCode.Text, 13, 2))
            try8 = (Mid$(Form1.tbCode.Text, 15, 2))
            try9 = (Mid$(Form1.tbCode.Text, 17, 2))
            try10 = (Mid$(Form1.tbCode.Text, 19, 2))
            try11 = (Mid$(Form1.tbCode.Text, 21, 2))
            try12 = (Mid$(Form1.tbCode.Text, 23, 2))
            try13 = (Mid$(Form1.tbCode.Text, 25, 2))
            try14 = (Mid$(Form1.tbCode.Text, 27, 2))
            try15 = (Mid$(Form1.tbCode.Text, 29, 2))
            try16 = (Mid$(Form1.tbCode.Text, 31, 2))
            try17 = (Mid$(Form1.tbCode.Text, 33, 2))
            try18 = (Mid$(Form1.tbCode.Text, 35, 2))
            try19 = (Mid$(Form1.tbCode.Text, 37, 2))
            try20 = (Mid$(Form1.tbCode.Text, 39, 2))
            try21 = (Mid$(Form1.tbCode.Text, 41, 2))
            try22 = (Mid$(Form1.tbCode.Text, 43, 2))
            try23 = (Mid$(Form1.tbCode.Text, 45, 2))
            try24 = (Mid$(Form1.tbCode.Text, 47, 2))
            Me.tbCode.Text = Me.tbCode.Text.Replace("#", try1 & try2 & try3 & try4 & " " & try5 & try6 & try7 & try8 & vbCrLf & try9 & try10 & try11 & try12 & " " & try13 & try14 & try15 & try16 & vbCrLf & try17 & try18 & try19 & try20 & " " & try21 & try22 & try23 & try24)
            Me.tbCode.Text = Me.tbCode.Text & vbCrLf & "E0000000 80008000"
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnt As Control
        For Each cnt In Controls
            cnt.ForeColor = My.Settings.SavedForeColor
        Next cnt

        Dim cnt2 As Control
        For Each cnt2 In Controls
            cnt2.BackColor = My.Settings.SavedBackColor
        Next cnt2

        Dim cnt3 As Control
        For Each cnt3 In Controls
            cnt3.BackColor = My.Settings.SavedBackColor
        Next cnt3

        Me.BackColor = My.Settings.SavedBackColor
        Me.ForeColor = My.Settings.SavedForeColor

        For Each blah As ToolStripMenuItem In MenuStrip1.Items
            blah.BackColor = My.Settings.SavedBackColor
            blah.ForeColor = My.Settings.SavedForeColor
            For Each meh As ToolStripMenuItem In blah.DropDownItems
                meh.BackColor = My.Settings.SavedBackColor
                meh.ForeColor = My.Settings.SavedForeColor
                For Each lolCat As ToolStripMenuItem In meh.DropDownItems
                    lolCat.BackColor = My.Settings.SavedBackColor
                    lolCat.ForeColor = My.Settings.SavedForeColor
                    For Each lolCat2 As ToolStripMenuItem In lolCat.DropDownItems
                        lolCat2.BackColor = My.Settings.SavedBackColor
                        lolCat2.ForeColor = My.Settings.SavedForeColor
                    Next
                Next
            Next
        Next
        BringToFront()
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileToolStripMenuItem.Click
        BringToFront()
    End Sub

    Private Sub WiiMoteToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WiiMoteToolStripMenuItem4.Click
        tbCode.Text = "2820236A 00008000" + vbCrLf + "068F7E08 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 1 Name Modifier Wiimote/Nunchuck (HOME): [MasterQ9999]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub WiiMoteToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WiiMoteToolStripMenuItem5.Click
        tbCode.Text = "2820236A 00008000" + vbCrLf + "068F7E28 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 2 Name Modifier Wiimote/Nunchuck (HOME): [MasterQ9999]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub WiiMoteToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WiiMoteToolStripMenuItem6.Click
        tbCode.Text = "2820236A 00008000" + vbCrLf + "068F7E48 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 3 Name Modifier Wiimote/Nunchuck (HOME): [MasterQ9999]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub WiiMoteToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WiiMoteToolStripMenuItem7.Click
        tbCode.Text = "2820236A 00008000" + vbCrLf + "068F7E68 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 4 Name Modifier Wiimote/Nunchuck (HOME): [MasterQ9999]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub CCPToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCPToolStripMenuItem4.Click
        tbCode.Text = "282028F0 00008000" + vbCrLf + "068F7E08 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 1 Name Modifier CCP (HOME): [MasterQ9999]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub CCPToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCPToolStripMenuItem5.Click
        tbCode.Text = "282028F0 00008000" + vbCrLf + "068F7E28 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 2 Name Modifier CCP (HOME): [MasterQ9999]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub CCPToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCPToolStripMenuItem6.Click
        tbCode.Text = "282028F0 00008000" + vbCrLf + "068F7E48 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 3 Name Modifier CCP (HOME): [MasterQ9999]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub CCPToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCPToolStripMenuItem7.Click
        tbCode.Text = "282028F0 00000800" + vbCrLf + "068F7E68 000000??" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "XXXXXXXX XXXXXXXX" + vbCrLf + "E0000000 80008000"
        tbCode.Text = "Profile 4 Name Modifier CCP (HOME): [MasterQ9999]" & vbCrLf & tbCode.Text
    End Sub

    Private Sub RefreshProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshProgramToolStripMenuItem.Click
        Form1.id = 3
        Form1.Timer1.Start()
        Me.Close()
    End Sub
End Class