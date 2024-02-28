Public Class formKujundid
    Private Sub tootlekujund(ByRef kujund As Kujund, ByVal tapsus As Integer)

        lblTyyp.Text = kujund.annaTyyp
        txtPindala.Text = kujund.leiaPindala.ToString("N" & tapsus)
        txtYmbermoot.Text = kujund.leiaYmberMoot.ToString("N" & tapsus)
    End Sub
    Private Function kasPositiivnArv(input As String) As Boolean
        Dim value As Double
        If Double.TryParse(input, value) AndAlso value > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click
        If String.IsNullOrWhiteSpace(txtKylgA.Text) OrElse String.IsNullOrWhiteSpace(txtKylgB.Text) Then
            MessageBox.Show("Palun sisesta arv mõlemassekasti.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the sub if input is invalid
        End If
        If Not kasPositiivnArv(txtKylgA.Text) OrElse Not kasPositiivnArv(txtKylgB.Text) Then
            MessageBox.Show("Palun sisesta positiivne number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the sub if input is invalid
        End If
        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
        Dim tapsus As Integer = cbTapsus.SelectedIndex + 1
        tootlekujund(objektKolmnurk, tapsus)
    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        If String.IsNullOrWhiteSpace(txtKylgA.Text) OrElse String.IsNullOrWhiteSpace(txtKylgB.Text) Then
            MessageBox.Show("Palun sisesta arv mõlemassekasti.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the sub if input is invalid
        End If
        If Not kasPositiivnArv(txtKylgA.Text) OrElse Not kasPositiivnArv(txtKylgB.Text) Then
            MessageBox.Show("Palun sisesta positiivne number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the sub if input is invalid
        End If
        Dim objektRuut As New Ruut(txtKylgA.Text)
        Dim tapsus As Integer = cbTapsus.SelectedIndex + 1
        tootlekujund(objektRuut, tapsus)
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click
        If String.IsNullOrWhiteSpace(txtKylgA.Text) OrElse String.IsNullOrWhiteSpace(txtKylgB.Text) Then
            MessageBox.Show("Palun sisesta arv mõlemassekasti.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the sub if input is invalid
        End If
        If Not kasPositiivnArv(txtKylgA.Text) OrElse Not kasPositiivnArv(txtKylgB.Text) Then
            MessageBox.Show("Palun sisesta positiivne number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the sub if input is invalid
        End If
        Dim objektRistkylik As New Ristkylik(txtKylgA.Text, txtKylgB.Text)
        Dim tapsus As Integer = cbTapsus.SelectedIndex + 1
        tootlekujund(objektRistkylik, tapsus)
    End Sub

    Private Sub btnRomb_Click(sender As Object, e As EventArgs) Handles btnRomb.Click
        If String.IsNullOrWhiteSpace(txtKylgA.Text) OrElse String.IsNullOrWhiteSpace(txtKylgB.Text) Then
            MessageBox.Show("Palun sisesta arv kõikidesse kastidesse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the sub if input is invalid
        End If
        If Not kasPositiivnArv(txtKylgA.Text) OrElse Not kasPositiivnArv(txtKylgB.Text) OrElse Not kasPositiivnArv(txtKorgus.Text) Then
            MessageBox.Show("Palun sisesta positiivne number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the sub if input is invalid
        End If
        Dim objektRomb As New Romb(txtKylgA.Text, txtKorgus.Text)
        Dim tapsus As Integer = cbTapsus.SelectedIndex + 1
        tootlekujund(objektRomb, tapsus)
    End Sub

    Private Sub btnRoopkylik_Click(sender As Object, e As EventArgs) Handles btnRoopkylik.Click
        If String.IsNullOrWhiteSpace(txtKylgA.Text) OrElse String.IsNullOrWhiteSpace(txtKylgB.Text) Then
            MessageBox.Show("Palun sisesta arv kõikidesse kastidesse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the sub if input is invalid
        End If
        If Not kasPositiivnArv(txtKylgA.Text) OrElse Not kasPositiivnArv(txtKylgB.Text) OrElse Not kasPositiivnArv(txtKorgus.Text) Then
            MessageBox.Show("Palun sisesta positiivne number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the sub if input is invalid
        End If
        Dim objektRoopkylik As New Roopkylik(txtKylgA.Text, txtKylgB.Text, txtKorgus.Text)
        Dim tapsus As Integer = cbTapsus.SelectedIndex + 1
        tootlekujund(objektRoopkylik, tapsus)
    End Sub

End Class
