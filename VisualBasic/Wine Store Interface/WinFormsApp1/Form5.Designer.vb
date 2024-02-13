<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        menudia = New Button()
        entrada = New Button()
        comida = New Button()
        bebidas = New Button()
        sobremesa1 = New TextBox()
        sobremesa2 = New TextBox()
        sobremesa3 = New TextBox()
        sobremesa4 = New TextBox()
        sobremesa5 = New TextBox()
        cmd_sair = New Button()
        chksobremesa1 = New CheckBox()
        chksobremesa2 = New CheckBox()
        chksobremesa3 = New CheckBox()
        chksobremesa4 = New CheckBox()
        chksobremesa5 = New CheckBox()
        preçototal = New Label()
        addchk = New Button()
        SuspendLayout()
        ' 
        ' menudia
        ' 
        menudia.Location = New Point(413, 126)
        menudia.Name = "menudia"
        menudia.Size = New Size(128, 29)
        menudia.TabIndex = 16
        menudia.Text = "Menu do Dia"
        menudia.UseVisualStyleBackColor = True
        ' 
        ' entrada
        ' 
        entrada.Location = New Point(438, 174)
        entrada.Name = "entrada"
        entrada.Size = New Size(94, 29)
        entrada.TabIndex = 17
        entrada.Text = "Entradas"
        entrada.UseVisualStyleBackColor = True
        ' 
        ' comida
        ' 
        comida.Location = New Point(418, 223)
        comida.Name = "comida"
        comida.Size = New Size(123, 29)
        comida.TabIndex = 18
        comida.Text = "Almoço/Jantar"
        comida.UseVisualStyleBackColor = True
        ' 
        ' bebidas
        ' 
        bebidas.Location = New Point(438, 269)
        bebidas.Name = "bebidas"
        bebidas.Size = New Size(94, 29)
        bebidas.TabIndex = 19
        bebidas.Text = "Bebidas"
        bebidas.UseVisualStyleBackColor = True
        ' 
        ' sobremesa1
        ' 
        sobremesa1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        sobremesa1.Location = New Point(12, 49)
        sobremesa1.Name = "sobremesa1"
        sobremesa1.Size = New Size(201, 30)
        sobremesa1.TabIndex = 25
        sobremesa1.Text = "Bolas de Berlim - 1,20€"
        ' 
        ' sobremesa2
        ' 
        sobremesa2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        sobremesa2.Location = New Point(12, 128)
        sobremesa2.Name = "sobremesa2"
        sobremesa2.Size = New Size(182, 30)
        sobremesa2.TabIndex = 26
        sobremesa2.Text = "Natas do Céu - 0,80€"
        ' 
        ' sobremesa3
        ' 
        sobremesa3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        sobremesa3.Location = New Point(12, 211)
        sobremesa3.Name = "sobremesa3"
        sobremesa3.Size = New Size(238, 30)
        sobremesa3.TabIndex = 27
        sobremesa3.Text = "Taça de Banana Split - 1,45€"
        ' 
        ' sobremesa4
        ' 
        sobremesa4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        sobremesa4.Location = New Point(12, 293)
        sobremesa4.Name = "sobremesa4"
        sobremesa4.Size = New Size(238, 30)
        sobremesa4.TabIndex = 28
        sobremesa4.Text = "Mousse de Caramelo - 1,20€"
        ' 
        ' sobremesa5
        ' 
        sobremesa5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        sobremesa5.Location = New Point(12, 379)
        sobremesa5.Name = "sobremesa5"
        sobremesa5.Size = New Size(251, 30)
        sobremesa5.TabIndex = 29
        sobremesa5.Text = "Queijada de requeijão - 0,65€"
        ' 
        ' cmd_sair
        ' 
        cmd_sair.Location = New Point(447, 423)
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(94, 29)
        cmd_sair.TabIndex = 31
        cmd_sair.Text = "Sair"
        cmd_sair.UseVisualStyleBackColor = True
        ' 
        ' chksobremesa1
        ' 
        chksobremesa1.AutoSize = True
        chksobremesa1.BackColor = Color.Transparent
        chksobremesa1.Location = New Point(219, 57)
        chksobremesa1.Name = "chksobremesa1"
        chksobremesa1.Size = New Size(18, 17)
        chksobremesa1.TabIndex = 32
        chksobremesa1.UseVisualStyleBackColor = False
        ' 
        ' chksobremesa2
        ' 
        chksobremesa2.AutoSize = True
        chksobremesa2.BackColor = Color.Transparent
        chksobremesa2.Location = New Point(200, 136)
        chksobremesa2.Name = "chksobremesa2"
        chksobremesa2.Size = New Size(18, 17)
        chksobremesa2.TabIndex = 33
        chksobremesa2.UseVisualStyleBackColor = False
        ' 
        ' chksobremesa3
        ' 
        chksobremesa3.AutoSize = True
        chksobremesa3.BackColor = Color.Transparent
        chksobremesa3.Location = New Point(256, 219)
        chksobremesa3.Name = "chksobremesa3"
        chksobremesa3.Size = New Size(18, 17)
        chksobremesa3.TabIndex = 34
        chksobremesa3.UseVisualStyleBackColor = False
        ' 
        ' chksobremesa4
        ' 
        chksobremesa4.AutoSize = True
        chksobremesa4.BackColor = Color.Transparent
        chksobremesa4.Location = New Point(256, 301)
        chksobremesa4.Name = "chksobremesa4"
        chksobremesa4.Size = New Size(18, 17)
        chksobremesa4.TabIndex = 35
        chksobremesa4.UseVisualStyleBackColor = False
        ' 
        ' chksobremesa5
        ' 
        chksobremesa5.AutoSize = True
        chksobremesa5.BackColor = Color.Transparent
        chksobremesa5.Location = New Point(269, 387)
        chksobremesa5.Name = "chksobremesa5"
        chksobremesa5.Size = New Size(18, 17)
        chksobremesa5.TabIndex = 36
        chksobremesa5.UseVisualStyleBackColor = False
        ' 
        ' preçototal
        ' 
        preçototal.AutoSize = True
        preçototal.Location = New Point(334, 11)
        preçototal.Name = "preçototal"
        preçototal.Size = New Size(46, 20)
        preçototal.TabIndex = 37
        preçototal.Text = "Preço"
        ' 
        ' addchk
        ' 
        addchk.Location = New Point(406, 7)
        addchk.Name = "addchk"
        addchk.Size = New Size(135, 29)
        addchk.TabIndex = 38
        addchk.Text = "Adicionar Conta"
        addchk.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(553, 464)
        Controls.Add(addchk)
        Controls.Add(preçototal)
        Controls.Add(chksobremesa5)
        Controls.Add(chksobremesa4)
        Controls.Add(chksobremesa3)
        Controls.Add(chksobremesa2)
        Controls.Add(chksobremesa1)
        Controls.Add(cmd_sair)
        Controls.Add(sobremesa5)
        Controls.Add(sobremesa4)
        Controls.Add(sobremesa3)
        Controls.Add(sobremesa2)
        Controls.Add(sobremesa1)
        Controls.Add(bebidas)
        Controls.Add(comida)
        Controls.Add(entrada)
        Controls.Add(menudia)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form5"
        Text = "Taverna ""O Pipo"""
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents menudia As Button
    Friend WithEvents entrada As Button
    Friend WithEvents comida As Button
    Friend WithEvents bebidas As Button
    Friend WithEvents sobremesa1 As TextBox
    Friend WithEvents sobremesa2 As TextBox
    Friend WithEvents sobremesa3 As TextBox
    Friend WithEvents sobremesa4 As TextBox
    Friend WithEvents sobremesa5 As TextBox
    Friend WithEvents cmd_sair As Button
    Friend WithEvents chksobremesa1 As CheckBox
    Friend WithEvents chksobremesa2 As CheckBox
    Friend WithEvents chksobremesa3 As CheckBox
    Friend WithEvents chksobremesa4 As CheckBox
    Friend WithEvents chksobremesa5 As CheckBox
    Friend WithEvents preçototal As Label
    Friend WithEvents addchk As Button
End Class