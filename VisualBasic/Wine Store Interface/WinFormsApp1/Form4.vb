Public Class Form4

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

    Private Sub sobremesa_Click(sender As Object, e As EventArgs) Handles sobremesa.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub cmd_sair_Click(sender As Object, e As EventArgs) Handles cmd_sair.Click
        End
    End Sub

    Private Sub chkbebida1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbebida1.CheckedChanged

        If chkbebida1.Checked = True Then
            total = total + 146604.0

        ElseIf chkbebida1.Checked = False Then
            total = total - 146604.0
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkbebida2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbebida2.CheckedChanged

        If chkbebida2.Checked = True Then
            total = total + 177681.0

        ElseIf chkbebida2.Checked = False Then
            total = total - 177681.0
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkbebida3_CheckedChanged(sender As Object, e As EventArgs) Handles chkbebida3.CheckedChanged

        If chkbebida3.Checked = True Then
            total = total + 190488.0

        ElseIf chkbebida3.Checked = False Then
            total = total - 190488.0
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkbebida4_CheckedChanged(sender As Object, e As EventArgs) Handles chkbebida4.CheckedChanged

        If chkbebida4.Checked = True Then
            total = total + 3299250.0

        ElseIf chkbebida4.Checked = False Then
            total = total - 3299250.0
        End If

        preçototal.Text = total
    End Sub

    Private Sub chkbebida5_CheckedChanged(sender As Object, e As EventArgs) Handles chkbebida5.CheckedChanged

        If chkbebida5.Checked = True Then
            total = total + 0.5

        ElseIf chkbebida5.Checked = False Then
            total = total - 0.5
        End If

        preçototal.Text = total
    End Sub

    Private Sub addchk_Click(sender As Object, e As EventArgs) Handles addchk.Click
        Form1.totaleverything = Form1.totaleverything + total
    End Sub
End Class