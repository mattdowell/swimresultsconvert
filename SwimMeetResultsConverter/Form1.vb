Public Class mainForm

    Private Sub convertBtn_Click(sender As System.Object, e As System.EventArgs) Handles convertBtn.Click
        convert()
    End Sub

    Private Sub athleteDbBtn_Click(sender As System.Object, e As System.EventArgs) Handles athleteDbBtn.Click
        athleteDbDialog.InitialDirectory = "C:\Users\Matt\projects\irishswim.org\meet data"
        athleteDbDialog.Title = "Choose the DB with the reference Athlete table"
        athleteDbDialog.Filter = "MS Access|*.mdb"
        athleteDbDialog.ShowDialog()
        Me.athleteDbLocation.Text = athleteDbDialog.FileName
    End Sub

    Private Sub meetDbBtn_Click(sender As System.Object, e As System.EventArgs) Handles meetDbBtn.Click
        meetDbDialog.InitialDirectory = "C:\Users\Matt\projects\irishswim.org\meet data"
        meetDbDialog.Title = "Choose the DB with the meet data"
        meetDbDialog.Filter = "MS Access|*.mdb"
        meetDbDialog.ShowDialog()
        Me.meetDbLocation.Text = meetDbDialog.FileName
    End Sub
End Class
