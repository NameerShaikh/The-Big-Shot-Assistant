Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports Windows.Win32.UI.Input

Public Class Form1
    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+10)
        Select Case ProgressBar1.Value
            Case 100
                Timer1.Enabled = False
                Me.Hide()
                Form2.Show()
        End Select
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class