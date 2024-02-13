Imports System.Linq.Expressions

Public Class Form1

    Public totaleverything As Decimal
    Sub mostrar()
        menu.Show()
        preço.Show()
    End Sub
    Sub esconder()
        tartesapo.Hide()
        carneporco.Hide()
        pizzaananas.Hide()
        saladaouriço.Hide()
        arrozcabidela.Hide()
        saladaporco.Hide()
        caracois.Hide()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Segunda-Feira")
        ComboBox1.Items.Add("Terça-Feira")
        ComboBox1.Items.Add("Quarta-Feira")
        ComboBox1.Items.Add("Quinta-Feira")
        ComboBox1.Items.Add("Sexta-Feira")
        ComboBox1.Items.Add("Sábado")
        ComboBox1.Items.Add("Domingo")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Segunda-Feira" Then
            mostrar()
            menu.Text = "Tarte de Sapo" & vbCrLf & "com Rissóis de Girassol"
            preço.Text = "7,99€"
            tartesapo.Show()
        ElseIf ComboBox1.SelectedItem = "Terça-Feira" Then
            mostrar()
            menu.Text = "Carne de Porco" & vbCrLf & "temperado com molho de alho"
            preço.Text = "12,50€"
            esconder()
            carneporco.Show()
        ElseIf ComboBox1.SelectedItem = "Quarta-Feira" Then
            mostrar()
            menu.Text = "Pizza com Ananás" & vbCrLf & "e rebordo recheado de queijo casu marzu"
            preço.Text = "10,25€"
            esconder()
            pizzaananas.Show()
        ElseIf ComboBox1.SelectedItem = "Quinta-Feira" Then
            mostrar()
            menu.Text = "Salada de Ouriço do Mar" & vbCrLf & "com Percebes"
            preço.Text = "5,99€"
            esconder()
            saladaouriço.Show()
        ElseIf ComboBox1.SelectedItem = "Sexta-Feira" Then
            mostrar()
            menu.Text = "Arroz de Cabidela" & vbCrLf & "acompanhado com Morcela"
            preço.Text = "15,00€"
            esconder()
            arrozcabidela.Show()
        ElseIf ComboBox1.SelectedItem = "Sábado" Then
            mostrar()
            menu.Text = "Salada De Orelhas" & vbCrLf & "temperado com molho de banana"
            preço.Text = "4,50€"
            esconder()
            saladaporco.Show()
        ElseIf ComboBox1.SelectedItem = "Domingo" Then
            mostrar()
            menu.Text = "Caracóis Cozidos" & vbCrLf & "com Burras Assadas"
            preço.Text = "7,25€"
            esconder()
            caracois.Show()
        End If
    End Sub
    Private Sub cmd_sair_Click(sender As Object, e As EventArgs) Handles cmd_sair.Click
        End
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

    Private Sub sobremesa_Click(sender As Object, e As EventArgs) Handles sobremesa.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub contafinal_Click(sender As Object, e As EventArgs) Handles contafinal.Click
        preçototal.Text = totaleverything
    End Sub

    Private Sub addchk_Click(sender As Object, e As EventArgs) Handles addchk.Click
        Me.totaleverything = Me.totaleverything + preço.Text
    End Sub

    Private Sub bt_verificaçao_Click(sender As Object, e As EventArgs) Handles bt_verificaçao.Click

        Dim a As Decimal

        a = valor.Text - totaleverything

        Str(a)

        If valor.Text >= totaleverything Then
            MessageBox.Show("Tem saldo suficiente para a conta!" & vbCrLf & " O seu troco é de: " & a, "Informação")
        End If

        If valor.Text < totaleverything Then
            MessageBox.Show("Não tem saldo suficiente :)", "ERRO")
        End If

    End Sub
End Class
