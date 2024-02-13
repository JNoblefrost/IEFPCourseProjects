Public Class Form2

    Dim total As Decimal
    Private Sub menudia_Click(sender As Object, e As EventArgs) Handles menudia.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub comida_Click(sender As Object, e As EventArgs) Handles comida.Click
        Me.Hide()
        Form3.Show()
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
    Private Sub chkentrada1_CheckedChanged(sender As Object, e As EventArgs) Handles chkentrada1.CheckedChanged

        If chkentrada1.Checked = True Then
            total = total + 8.45

        ElseIf chkentrada1.Checked = False Then
            total = total - 8.45
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkentrada2_CheckedChanged(sender As Object, e As EventArgs) Handles chkentrada2.CheckedChanged

        If chkentrada2.Checked = True Then
            total = total + 14.5

        ElseIf chkentrada2.Checked = False Then
            total = total - 14.5
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkentrada3_CheckedChanged(sender As Object, e As EventArgs) Handles chkentrada3.CheckedChanged

        If chkentrada3.Checked = True Then
            total = total + 5.99

        ElseIf chkentrada3.Checked = False Then
            total = total - 5.99
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkentrada4_CheckedChanged(sender As Object, e As EventArgs) Handles chkentrada4.CheckedChanged

        If chkentrada4.Checked = True Then
            total = total + 12.99

        ElseIf chkentrada4.Checked = False Then
            total = total - 12.99
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkentrada5_CheckedChanged(sender As Object, e As EventArgs) Handles chkentrada5.CheckedChanged

        If chkentrada5.Checked = True Then
            total = total + 7.99

        ElseIf chkentrada5.Checked = False Then
            total = total - 7.99

        End If

        preçototal.Text = total
    End Sub

    Private Sub addchk_Click(sender As Object, e As EventArgs) Handles addchk.Click
        Form1.totaleverything = Form1.totaleverything + total
    End Sub
End Class