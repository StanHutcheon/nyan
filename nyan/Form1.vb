Imports Microsoft.VisualBasic
Imports System
Public Class Form1
    Public newtimer As Double = 0.0
    Public timertext As String
    Public LeftPart As String = Microsoft.VisualBasic.Left(timertext, 3)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AxWindowsMediaPlayer1.settings.setMode("loop", True)
        System.IO.File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp & "\nyan-looped.mp3", My.Resources.nyan_looped)
        AxWindowsMediaPlayer1.URL = My.Computer.FileSystem.SpecialDirectories.Temp & "\nyan-looped.mp3"

        RichTextBox1.Select()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        newtimer = newtimer + 0.016
        timertext = newtimer
        If timertext <= 10.0 Then
            LeftPart = Microsoft.VisualBasic.Left(timertext, 4)
        ElseIf timertext <= 100.0 Then
            LeftPart = Microsoft.VisualBasic.Left(timertext, 5)
        ElseIf timertext <= 1000.0 Then
            LeftPart = Microsoft.VisualBasic.Left(timertext, 6)
        ElseIf timertext <= 10000.0 Then
            LeftPart = Microsoft.VisualBasic.Left(timertext, 7)
        ElseIf timertext <= 100000.0 Then
            LeftPart = Microsoft.VisualBasic.Left(timertext, 8)
        ElseIf timertext <= 1000000.0 Then
            LeftPart = Microsoft.VisualBasic.Left(timertext, 9)
        ElseIf timertext <= 10000000.0 Then
            LeftPart = Microsoft.VisualBasic.Left(timertext, 10)
        End If
        TextBox1.Text = LeftPart
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MsgBox("By StanTheRipper" & vbCrLf & "http://stantheripper.com", MsgBoxStyle.Information, "Did you have fun?")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("http://twitter.com/home?status=Just got a score of: " & TextBox1.Text & " in @StanTheRipper's nyan.exe - http://dl.stantheripper.com/nyan.exe")
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        RichTextBox1.Select()
    End Sub
End Class
