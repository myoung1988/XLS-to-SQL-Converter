Public Class About

    Private Sub lnkContact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkContact.LinkClicked
        System.Diagnostics.Process.Start("mailto:myoung@jjc.edu")
    End Sub
End Class