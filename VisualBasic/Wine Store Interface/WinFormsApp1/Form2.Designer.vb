<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        menudia = New Button()
        comida = New Button()
        bebidas = New Button()
        entrada1 = New TextBox()
        entrada2 = New TextBox()
        entrada3 = New TextBox()
        entrada4 = New TextBox()
        entrada5 = New TextBox()
        sobremesa = New Button()
        cmd_sair = New Button()
        chkentrada1 = New CheckBox()
        chkentrada2 = New CheckBox()
        chkentrada3 = New CheckBox()
        chkentrada4 = New CheckBox()
        chkentrada5 = New CheckBox()
        preçototal = New Label()
        addchk = New Button()
        SuspendLayout()
        ' 
        ' menudia
        ' 
        menudia.Location = New Point(413, 126)
        menudia.Name = "menudia"
        menudia.Size = New Size(128, 29)
        menudia.TabIndex = 13
        menudia.Text = "Menu do Dia"
        menudia.UseVisualStyleBackColor = True
        ' 
        ' comida
        ' 
        comida.Location = New Point(413, 174)
        comida.Name = "comida"
        comida.Size = New Size(128, 29)
        comida.TabIndex = 14
        comida.Text = "Almoço/Jantar"
        comida.UseVisualStyleBackColor = True
        ' 
        ' bebidas
        ' 
        bebidas.Location = New Point(447, 223)
        bebidas.Name = "bebidas"
        bebidas.Size = New Size(94, 29)
        bebidas.TabIndex = 15
        bebidas.Text = "Bebidas"
        bebidas.UseVisualStyleBackColor = True
        ' 
        ' entrada1
        ' 
        entrada1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        entrada1.Location = New Point(12, 49)
        entrada1.Name = "entrada1"
        entrada1.Size = New Size(275, 30)
        entrada1.TabIndex = 16
        entrada1.Text = "Pão com recheio de pizza - 8,25€" & vbCrLf
        ' 
        ' entrada2
        ' 
        entrada2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        entrada2.Location = New Point(12, 128)
        entrada2.Name = "entrada2"
        entrada2.Size = New Size(235, 30)
        entrada2.TabIndex = 17
        entrada2.Text = "Focaccia de tomate - 14,50€" & vbCrLf
        ' 
        ' entrada3
        ' 
        entrada3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        entrada3.Location = New Point(12, 211)
        entrada3.Name = "entrada3"
        entrada3.Size = New Size(357, 30)
        entrada3.TabIndex = 18
        entrada3.Text = "Folhado de Queijo com mel e nozes - 5,99€" & vbCrLf
        ' 
        ' entrada4
        ' 
        entrada4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        entrada4.Location = New Point(12, 293)
        entrada4.Name = "entrada4"
        entrada4.Size = New Size(309, 30)
        entrada4.TabIndex = 19
        entrada4.Text = "Tártaro de Sapateira Yämmi - 12,99€" & vbCrLf & vbCrLf
        ' 
        ' entrada5
        ' 
        entrada5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        entrada5.Location = New Point(12, 379)
        entrada5.Name = "entrada5"
        entrada5.Size = New Size(212, 30)
        entrada5.TabIndex = 20
        entrada5.Text = "Tábua de Queijos - 7,99€"
        ' 
        ' sobremesa
        ' 
        sobremesa.Location = New Point(438, 269)
        sobremesa.Name = "sobremesa"
        sobremesa.Size = New Size(103, 29)
        sobremesa.TabIndex = 21
        sobremesa.Text = "Sobremesas" & vbCrLf
        sobremesa.UseVisualStyleBackColor = True
        ' 
        ' cmd_sair
        ' 
        cmd_sair.Location = New Point(447, 423)
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(94, 29)
        cmd_sair.TabIndex = 23
        cmd_sair.Text = "Sair"
        cmd_sair.UseVisualStyleBackColor = True
        ' 
        ' chkentrada1
        ' 
        chkentrada1.AutoSize = True
        chkentrada1.BackColor = Color.Transparent
        chkentrada1.Location = New Point(293, 57)
        chkentrada1.Name = "chkentrada1"
        chkentrada1.Size = New Size(18, 17)
        chkentrada1.TabIndex = 24
        chkentrada1.UseVisualStyleBackColor = False
        ' 
        ' chkentrada2
        ' 
        chkentrada2.AutoSize = True
        chkentrada2.BackColor = Color.Transparent
        chkentrada2.Location = New Point(253, 136)
        chkentrada2.Name = "chkentrada2"
        chkentrada2.Size = New Size(18, 17)
        chkentrada2.TabIndex = 25
        chkentrada2.UseVisualStyleBackColor = False
        ' 
        ' chkentrada3
        ' 
        chkentrada3.AutoSize = True
        chkentrada3.BackColor = Color.Transparent
        chkentrada3.Location = New Point(375, 219)
        chkentrada3.Name = "chkentrada3"
        chkentrada3.Size = New Size(18, 17)
        chkentrada3.TabIndex = 26
        chkentrada3.UseVisualStyleBackColor = False
        ' 
        ' chkentrada4
        ' 
        chkentrada4.AutoSize = True
        chkentrada4.BackColor = Color.Transparent
        chkentrada4.Location = New Point(327, 301)
        chkentrada4.Name = "chkentrada4"
        chkentrada4.Size = New Size(18, 17)
        chkentrada4.TabIndex = 27
        chkentrada4.UseVisualStyleBackColor = False
        ' 
        ' chkentrada5
        ' 
        chkentrada5.AutoSize = True
        chkentrada5.BackColor = Color.Transparent
        chkentrada5.Location = New Point(230, 387)
        chkentrada5.Name = "chkentrada5"
        chkentrada5.Size = New Size(18, 17)
        chkentrada5.TabIndex = 28
        chkentrada5.UseVisualStyleBackColor = False
        ' 
        ' preçototal
        ' 
        preçototal.AutoSize = True
        preçototal.Location = New Point(342, 16)
        preçototal.Name = "preçototal"
        preçototal.Size = New Size(46, 20)
        preçototal.TabIndex = 29
        preçototal.Text = "Preço"
        ' 
        ' addchk
        ' 
        addchk.Location = New Point(406, 12)
        addchk.Name = "addchk"
        addchk.Size = New Size(135, 29)
        addchk.TabIndex = 30
        addchk.Text = "Adicionar Conta"
        addchk.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(553, 464)
        Controls.Add(addchk)
        Controls.Add(preçototal)
        Controls.Add(chkentrada5)
        Controls.Add(chkentrada4)
        Controls.Add(chkentrada3)
        Controls.Add(chkentrada2)
        Controls.Add(chkentrada1)
        Controls.Add(cmd_sair)
        Controls.Add(sobremesa)
        Controls.Add(entrada5)
        Controls.Add(entrada4)
        Controls.Add(entrada3)
        Controls.Add(entrada2)
        Controls.Add(entrada1)
        Controls.Add(bebidas)
        Controls.Add(comida)
        Controls.Add(menudia)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Taverna ""O Pipo"""
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents menudia As Button
    Friend WithEvents comida As Button
    Friend WithEvents bebidas As Button
    Friend WithEvents entrada1 As TextBox
    Friend WithEvents entrada2 As TextBox
    Friend WithEvents entrada3 As TextBox
    Friend WithEvents entrada4 As TextBox
    Friend WithEvents entrada5 As TextBox
    Friend WithEvents sobremesa As Button
    Friend WithEvents cmd_sair As Button
    Friend WithEvents chkentrada1 As CheckBox
    Friend WithEvents chkentrada2 As CheckBox
    Friend WithEvents chkentrada3 As CheckBox
    Friend WithEvents chkentrada4 As CheckBox
    Friend WithEvents chkentrada5 As CheckBox
    Friend WithEvents preçototal As Label
    Friend WithEvents addchk As Button
End Class
