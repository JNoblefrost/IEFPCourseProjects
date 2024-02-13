<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        menudia = New Button()
        entrada = New Button()
        bebidas = New Button()
        sobremesa = New Button()
        comida1 = New TextBox()
        comida2 = New TextBox()
        comida3 = New TextBox()
        comida4 = New TextBox()
        comida5 = New TextBox()
        cmd_sair = New Button()
        chkalmoço1 = New CheckBox()
        chkalmoço2 = New CheckBox()
        chkalmoço3 = New CheckBox()
        chkalmoço4 = New CheckBox()
        chkalmoço5 = New CheckBox()
        preçototal = New Label()
        addchk = New Button()
        SuspendLayout()
        ' 
        ' menudia
        ' 
        menudia.Location = New Point(413, 126)
        menudia.Name = "menudia"
        menudia.Size = New Size(128, 29)
        menudia.TabIndex = 14
        menudia.Text = "Menu do Dia"
        menudia.UseVisualStyleBackColor = True
        ' 
        ' entrada
        ' 
        entrada.Location = New Point(438, 174)
        entrada.Name = "entrada"
        entrada.Size = New Size(103, 29)
        entrada.TabIndex = 15
        entrada.Text = "Entradas"
        entrada.UseVisualStyleBackColor = True
        ' 
        ' bebidas
        ' 
        bebidas.Location = New Point(447, 223)
        bebidas.Name = "bebidas"
        bebidas.Size = New Size(94, 29)
        bebidas.TabIndex = 16
        bebidas.Text = "Bebidas"
        bebidas.UseVisualStyleBackColor = True
        ' 
        ' sobremesa
        ' 
        sobremesa.Location = New Point(438, 269)
        sobremesa.Name = "sobremesa"
        sobremesa.Size = New Size(103, 29)
        sobremesa.TabIndex = 22
        sobremesa.Text = "Sobremesas" & vbCrLf
        sobremesa.UseVisualStyleBackColor = True
        ' 
        ' comida1
        ' 
        comida1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        comida1.Location = New Point(12, 49)
        comida1.Name = "comida1"
        comida1.Size = New Size(275, 30)
        comida1.TabIndex = 23
        comida1.Text = "Hambúrguer de frango - 12,99€" & vbCrLf
        ' 
        ' comida2
        ' 
        comida2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        comida2.Location = New Point(12, 128)
        comida2.Name = "comida2"
        comida2.Size = New Size(262, 30)
        comida2.TabIndex = 24
        comida2.Text = "Espaguete à carbonara - 10,50€" & vbCrLf
        ' 
        ' comida3
        ' 
        comida3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        comida3.Location = New Point(12, 211)
        comida3.Name = "comida3"
        comida3.Size = New Size(288, 30)
        comida3.TabIndex = 25
        comida3.Text = "Macarrão ao molho branco - 6,75€"
        ' 
        ' comida4
        ' 
        comida4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        comida4.Location = New Point(12, 293)
        comida4.Name = "comida4"
        comida4.Size = New Size(311, 30)
        comida4.TabIndex = 26
        comida4.Text = "Strogonoff de frango simples - 9,00€" & vbCrLf
        ' 
        ' comida5
        ' 
        comida5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        comida5.Location = New Point(12, 379)
        comida5.Name = "comida5"
        comida5.Size = New Size(295, 30)
        comida5.TabIndex = 27
        comida5.Text = "Peixe assado com legumes - 20,00€"
        ' 
        ' cmd_sair
        ' 
        cmd_sair.Location = New Point(447, 423)
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(94, 29)
        cmd_sair.TabIndex = 29
        cmd_sair.Text = "Sair"
        cmd_sair.UseVisualStyleBackColor = True
        ' 
        ' chkalmoço1
        ' 
        chkalmoço1.AutoSize = True
        chkalmoço1.BackColor = Color.Transparent
        chkalmoço1.Location = New Point(293, 57)
        chkalmoço1.Name = "chkalmoço1"
        chkalmoço1.Size = New Size(18, 17)
        chkalmoço1.TabIndex = 30
        chkalmoço1.UseVisualStyleBackColor = False
        ' 
        ' chkalmoço2
        ' 
        chkalmoço2.AutoSize = True
        chkalmoço2.BackColor = Color.Transparent
        chkalmoço2.Location = New Point(280, 138)
        chkalmoço2.Name = "chkalmoço2"
        chkalmoço2.Size = New Size(18, 17)
        chkalmoço2.TabIndex = 31
        chkalmoço2.UseVisualStyleBackColor = False
        ' 
        ' chkalmoço3
        ' 
        chkalmoço3.AutoSize = True
        chkalmoço3.BackColor = Color.Transparent
        chkalmoço3.Location = New Point(306, 219)
        chkalmoço3.Name = "chkalmoço3"
        chkalmoço3.Size = New Size(18, 17)
        chkalmoço3.TabIndex = 32
        chkalmoço3.UseVisualStyleBackColor = False
        ' 
        ' chkalmoço4
        ' 
        chkalmoço4.AutoSize = True
        chkalmoço4.BackColor = Color.Transparent
        chkalmoço4.Location = New Point(329, 301)
        chkalmoço4.Name = "chkalmoço4"
        chkalmoço4.Size = New Size(18, 17)
        chkalmoço4.TabIndex = 33
        chkalmoço4.UseVisualStyleBackColor = False
        ' 
        ' chkalmoço5
        ' 
        chkalmoço5.AutoSize = True
        chkalmoço5.BackColor = Color.Transparent
        chkalmoço5.Location = New Point(316, 387)
        chkalmoço5.Name = "chkalmoço5"
        chkalmoço5.Size = New Size(18, 17)
        chkalmoço5.TabIndex = 34
        chkalmoço5.UseVisualStyleBackColor = False
        ' 
        ' preçototal
        ' 
        preçototal.AutoSize = True
        preçototal.Location = New Point(335, 16)
        preçototal.Name = "preçototal"
        preçototal.Size = New Size(46, 20)
        preçototal.TabIndex = 35
        preçototal.Text = "Preço"
        ' 
        ' addchk
        ' 
        addchk.Location = New Point(406, 12)
        addchk.Name = "addchk"
        addchk.Size = New Size(135, 29)
        addchk.TabIndex = 36
        addchk.Text = "Adicionar Conta"
        addchk.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(553, 464)
        Controls.Add(addchk)
        Controls.Add(preçototal)
        Controls.Add(chkalmoço5)
        Controls.Add(chkalmoço4)
        Controls.Add(chkalmoço3)
        Controls.Add(chkalmoço2)
        Controls.Add(chkalmoço1)
        Controls.Add(cmd_sair)
        Controls.Add(comida5)
        Controls.Add(comida4)
        Controls.Add(comida3)
        Controls.Add(comida2)
        Controls.Add(comida1)
        Controls.Add(sobremesa)
        Controls.Add(bebidas)
        Controls.Add(entrada)
        Controls.Add(menudia)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form3"
        Text = "Taverna ""O Pipo"""
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents menudia As Button
    Friend WithEvents entrada As Button
    Friend WithEvents bebidas As Button
    Friend WithEvents sobremesa As Button
    Friend WithEvents comida1 As TextBox
    Friend WithEvents comida2 As TextBox
    Friend WithEvents comida3 As TextBox
    Friend WithEvents comida4 As TextBox
    Friend WithEvents comida5 As TextBox
    Friend WithEvents cmd_sair As Button
    Friend WithEvents chkalmoço1 As CheckBox
    Friend WithEvents chkalmoço2 As CheckBox
    Friend WithEvents chkalmoço3 As CheckBox
    Friend WithEvents chkalmoço4 As CheckBox
    Friend WithEvents chkalmoço5 As CheckBox
    Friend WithEvents preçototal As Label
    Friend WithEvents addchk As Button
End Class
