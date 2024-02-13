Public Class Form5

    Dim total As Decimal
    Private Sub menudia_Click(sender As Object, e As EventArgs) Handles menudia.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub entrada_Click(sender As Object, e As EventArgs) Handles entrada.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub comida_Click(sender As Object, e As EventArgs) Handles comida.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub bebidas_Click(sender As Object, e As EventArgs) Handles bebidas.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub cmd_sair_Click(sender As Object, e As EventArgs) Handles cmd_sair.Click
        End
    End Sub

    Private Sub chksobremesa1_CheckedChanged(sender As Object, e As EventArgs) Handles chksobremesa1.CheckedChanged

        If chksobremesa1.Checked = True Then
            total = total + 1.2

        ElseIf chksobremesa1.Checked = False Then
            total = total - 1.2
        End If

        preçototal.Text = total
    End Sub

    Private Sub chksobremesa2_CheckedChanged(sender As Object, e As EventArgs) Handles chksobremesa2.CheckedChanged

        If chksobremesa2.Checked = True Then
            total = total + 0.8

        ElseIf chksobremesa2.Checked = False Then
            total = total - 0.8
        End If

        preçototal.Text = total
    End Sub

    Private Sub chksobremesa3_CheckedChanged(sender As Object, e As EventArgs) Handles chksobremesa3.CheckedChanged

        If chksobremesa3.Checked = True Then
            total = total + 1.45

        ElseIf chksobremesa3.Checked = False Then
            total = total - 1.45
        End If

        preçototal.Text = total
    End Sub

    Private Sub chksobremesa4_CheckedChanged(sender As Object, e As EventArgs) Handles chksobremesa4.CheckedChanged

        If chksobremesa4.Checked = True Then
            total = total + 1.2

        ElseIf chksobremesa4.Checked = False Then
            total = total - 1.2
        End If

        preçototal.Text = total
    End Sub

    Private Sub chksobremesa5_CheckedChanged(sender As Object, e As EventArgs) Handles chksobremesa5.CheckedChanged

        If chksobremesa5.Checked = True Then
            total = total + 0.65

        ElseIf chksobremesa5.Checked = False Then
            total = total - 0.65
        End If

        preçototal.Text = total
    End Sub

    Private Sub addchk_Click(sender As Object, e As EventArgs) Handles addchk.Click
        Form1.totaleverything = Form1.totaleverything + total
    End Sub
End Class