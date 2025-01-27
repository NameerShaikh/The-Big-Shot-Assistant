Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports Windows.Win32.UI.Input

Public Class Form1
    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+4)
        Select Case ProgressBar1.Value
            Case 100
                Timer1.Enabled = False
                Me.Hide()
                Form2.Show()
        End Select
    End Sub


End Class