Public Class form_changelog
    Private Sub form_changelog_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim changelog_File As String = My.Resources.changelog

        label_changelog.Text = changelog_File

    End Sub
End Class