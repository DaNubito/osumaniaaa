Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.Media
Imports NAudio.Wave
Imports System.Security.Cryptography.X509Certificates

Public Class Form3
    Public rectangles(-1) As Rectangle
    Public tick As Integer
    Public scores As Integer
    Public s300 As Integer
    Public s100 As Integer
    Public s50 As Integer
    Public misses As Integer
    Public combo As Integer = 0
    Public acc As Double

    Dim rectanglecount As Integer
    Dim inputhit As Boolean
    Dim sp = New SoundPlayer("filename")
    sp.Load(); //preload
    sp.Play();
    
    Private Function Collide(ByVal ObjA As Object, ByVal ObjB As Object) As Boolean
        If ObjA.bounds.intersectswith(ObjB.bounds) Then
            Collide = True
        Else
            Collide = False

        End If
    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles tile4.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub tile3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tile3.KeyPress

    End Sub

    Private Sub Form3_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.D, Keys.F, Keys.J, Keys.K
                inputhit = False
        End Select
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.D, Keys.F, Keys.J, Keys.K
                inputhit = True
        End Select
    End Sub


    Private Sub tile2_Click(sender As Object, e As EventArgs) Handles tile2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles accuracy.Click

    End Sub

    Private Sub percentage_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrGame_Tick.Tick
        tick += 1
        acc = Math.Ceiling((((300 * s300) + (100 * s100) + (50 * s50)) / (300 * (s300 + s100 + s50 + misses)) * 100) * 100D / 100D)
        combos.Text = combo.ToString + " x"
        score.Text = score.ToString("D8")
        accuracy.Text = acc.ToString + "%"
    End Sub


    Public Sub Clicked()
        If Collide(tile1, collide1) Then

            If e.KeyCode = Keys.D Then
                Debug.Print("hit")
                Select Case toc
                    Case Is <= 5, Is >= 65
                        Form3.misses += 1
                        Form3.combo = 0
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\combobreak.wav", AudioPlayMode.Background)
                        Return
                    Case Is <= 10, Is >= 60
                        Form3.s50 += 1
                        Form3.score += 50 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                        Return
                    Case Is <= 22, Is >= 48
                        Form3.s100 += 1
                        Form3.score += 100 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                    Case Is > 22, Is < 48
                        Form3.s300 += 1
                        Form3.score += 300 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                    Case Else
                        Form3.misses += 1
                        Form3.combo = 0
                End Select
            End If
        End If

        If Collide(tile2, collide2) Then
            If e.KeyCode = Keys.F Then
                Debug.Print("hit")
                Select Case toc
                    Case Is <= 5, Is >= 65
                        Form3.misses += 1
                        Form3.combo = 0
                        My.Computer.Audio.Play(, AudioPlayMode.Background"C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\combobreak.wav"
                        Return
                    Case Is <= 10, Is >= 60
                        Form3.s50 += 1
                        Form3.score += 50 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                        Return
                    Case Is <= 22, Is >= 48
                        Form3.s100 += 1
                        Form3.score += 100 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                    Case Is > 22, Is < 48
                        Form3.s300 += 1
                        Form3.score += 300 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                    Case Else
                        Form3.misses += 1
                        Form3.combo = 0
                End Select
            End If
        End If
        If Collide(tile3, collide3) Then

            If e.KeyCode = Keys.J Then
                Debug.Print("hit")
                Select Case toc
                    Case Is <= 5, Is >= 65
                        Form3.misses += 1
                        Form3.combo = 0
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\combobreak.wav", AudioPlayMode.Background)
                        Return
                    Case Is <= 10, Is >= 60
                        Form3.sc50 += 1
                        Form3.score += 50 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                        Return
                    Case Is <= 22, Is >= 48
                        Form3.sc100 += 1
                        Form3.score += 100 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                    Case Is > 22, Is < 48
                        Form3.sc300 += 1
                        Form3.score += 300 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                    Case Else
                        Form3.misses += 1
                        Form3.combo = 0
                End Select
            End If
        End If
        If Collide(tile4, collide4) Then
            If e.KeyCode = Keys.K Then
                Debug.Print("hit")
                Select Case toc
                    Case Is <= 5, Is >= 65
                        Form3.misses += 1
                        Form3.combo =
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\combobreak.wav", AudioPlayMode.Background)
                        Return
                    Case Is <= 10, Is >= 60
                        Form3.sc50 += 1
                        Form3.score += 50 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                        Return
                    Case Is <= 22, Is >= 48
                        Form3.sc100 += 1
                        Form3.score += 100 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                    Case Is > 22, Is < 48
                        Form3.sc300 += 1
                        Form3.score += 300 * Form1.combo + 1
                        Form3.combo += 1
                        My.Computer.Audio.Play("C:\Users\KON0026\source\repos\osu!Mania\osu!Mania\normal-hitnormal.wav", AudioPlayMode.Background)
                    Case Else
                        Form3.misses += 1
                        Form3.combo = 0
                End Select
            End If
        End If

    End Sub

    Private Sub collide1_Click(sender As Object, e As EventArgs) Handles collide1.Click

        End Sub

        Private Sub collide2_Click(sender As Object, e As EventArgs) Handles collide2.Click

        End Sub

        Private Sub collide3_Click(sender As Object, e As EventArgs) Handles collide3.Click

        End Sub

        Private Sub collide4_Click(sender As Object, e As EventArgs) Handles collide4.Click

        End Sub
    End Class