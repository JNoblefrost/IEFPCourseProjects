Public Class Form3

    Dim total As Decimal
    Private Sub menudia_Click(sender As Object, e As EventArgs) Handles menudia.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub entrada_Click(sender As Object, e As EventArgs) Handles entrada.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub bebidas_Click(sender As Object, e As EventArgs) Handles bebidas.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub sobremesa_Click(sender As Object, e As EventArgs) Handles sobremesa.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub cmd_sair_Click(sender As Object, e As EventArgs) Handles cmd_sair.Click
        End
    End Sub

    Private Sub chkalmoço1_CheckedChanged(sender As Object, e As EventArgs) Handles chkalmoço1.CheckedChanged

        If chkalmoço1.Checked = True Then
            total = total + 12.99

        ElseIf chkalmoço1.Checked = False Then
            total = total - 12.99
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkalmoço2_CheckedChanged(sender As Object, e As EventArgs) Handles chkalmoço2.CheckedChanged

        If chkalmoço2.Checked = True Then
            total = total + 10.5

        ElseIf chkalmoço2.Checked = False Then
            total = total - 10.5
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkalmoço3_CheckedChanged(sender As Object, e As EventArgs) Handles chkalmoço3.CheckedChanged

        If chkalmoço3.Checked = True Then
            total = total + 6.75

        ElseIf chkalmoço3.Checked = False Then
            total = total - 6.75
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkalmoço4_CheckedChanged(sender As Object, e As EventArgs) Handles chkalmoço4.CheckedChanged

        If chkalmoço4.Checked = True Then
            total = total + 9

        ElseIf chkalmoço4.Checked = False Then
            total = total - 9
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkalmoço5_CheckedChanged(sender As Object, e As EventArgs) Handles chkalmoço5.CheckedChanged

        If chkalmoço5.Checked = True Then
            total = total + 20

        ElseIf chkalmoço5.Checked = False Then
            total = total - 20
        End If

        preçototal.Text = total
    End Sub

    Private Sub addchk_Click(sender As Object, e As EventArgs) Handles addchk.Click
        Form1.totaleverything = Form1.totaleverything + total
    End Sub
End Class