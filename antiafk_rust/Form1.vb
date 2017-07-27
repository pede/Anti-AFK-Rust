Imports System
Imports System.Net
Imports System.IO
Public Class Form1
    Dim run_ctrl As Boolean = False
    Dim on_var As Boolean = False
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If on_var = False Then
            Timer1.Enabled = True
            on_var = True
            Button1.Text = "Stop"
        Else
            Timer1.Enabled = False
            on_var = False
            Button1.Text = "Start"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim index As Integer = 0
        Do While index <= 100
            SendKeys.Send("{D}")
            index += 1
        Loop
        If run_ctrl = False Then
            run_ctrl = True
        Else
            run_ctrl = False
        End If
    End Sub
End Class
