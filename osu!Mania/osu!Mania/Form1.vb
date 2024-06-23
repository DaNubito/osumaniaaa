Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.Media
Imports System.Media.SoundPlayer
Imports System.Security.Cryptography.X509Certificates
Imports System.Numerics
Public Class Form1

    Public rectangles As Rectangle
    Public tick As Integer
    Public score As Integer
    Public s300 As Integer
    Public s100 As Integer
    Public s50 As Integer
    Public misses As Integer
    Public combo As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim audioFilePath As String = "C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\nekodex - circles!.wav"
        PlayAudioFile(audioFilePath)
        If Not System.IO.File.Exists(audioFilePath) Then
            MessageBox.Show("File not found: " & audioFilePath)
            Return
        End If
        PlayAudioFile(audioFilePath)
    End Sub

    Private Sub PlayAudioFile(filePath As String)
        Try
            Dim player As New SoundPlayer(filePath)
            player.Load()
            player.Play()
        Catch ex As Exception
            MessageBox.Show("Error playing sound: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        btnPlay.Visible = True
        btnQuit.Visible = True
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form2.Show()
        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class

