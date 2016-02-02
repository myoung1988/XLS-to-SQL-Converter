Public Class Processing

    Private Sub Processing_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Processing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'ProgressBar1.PerformStep()
    End Sub
End Class