Public Class formKujundid
    Private Sub tootlekujund(ByRef kujund As Kujund)

        lblTyyp.Text = kujund.annaTyyp
        txtPindala.Text = kujund.leiaPindala
        txtYmbermoot.Text = kujund.leiaYmberMoot
    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click
        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
        tootleKujund(objektKolmnurk)
    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        Dim objektRuut As New Ruut(txtKylgA.Text)
        tootlekujund(objektRuut)
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click
        Dim objektRistkylik As New Ristkylik(txtKylgA.Text, txtKylgB.Text)
        tootlekujund(objektRistkylik)
    End Sub
End Class
