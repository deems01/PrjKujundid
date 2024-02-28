Public Class formKujundid
    Private Sub tootlekujund(ByRef kujund As Kujund, ByVal tapsus As Integer)

        lblTyyp.Text = kujund.annaTyyp
        txtPindala.Text = kujund.leiaPindala.ToString("N" & tapsus)
        txtYmbermoot.Text = kujund.leiaYmberMoot.ToString("N" & tapsus)
    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click
        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
        Dim tapsus As Integer = cbTapsus.SelectedIndex + 1
        tootlekujund(objektKolmnurk, tapsus)
    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        Dim objektRuut As New Ruut(txtKylgA.Text)
        Dim tapsus As Integer = cbTapsus.SelectedIndex + 1
        tootlekujund(objektRuut, tapsus)
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click
        Dim objektRistkylik As New Ristkylik(txtKylgA.Text, txtKylgB.Text)
        Dim tapsus As Integer = cbTapsus.SelectedIndex + 1
        tootlekujund(objektRistkylik, tapsus)
    End Sub
End Class
