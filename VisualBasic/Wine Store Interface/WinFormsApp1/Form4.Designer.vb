<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        entrada = New Button()
        comida = New Button()
        menudia = New Button()
        sobremesa = New Button()
        bebida1 = New TextBox()
        bebida2 = New TextBox()
        bebida3 = New TextBox()
        bebida4 = New TextBox()
        bebida5 = New TextBox()
        cmd_sair = New Button()
        chkbebida1 = New CheckBox()
        chkbebida2 = New CheckBox()
        chkbebida3 = New CheckBox()
        chkbebida4 = New CheckBox()
        chkbebida5 = New CheckBox()
        preçototal = New Label()
        addchk = New Button()
        SuspendLayout()
        ' 
        ' entrada
        ' 
        entrada.Location = New Point(438, 174)
        entrada.Name = "entrada"
        entrada.Size = New Size(94, 29)
        entrada.TabIndex = 13
        entrada.Text = "Entradas"
        entrada.UseVisualStyleBackColor = True
        ' 
        ' comida
        ' 
        comida.Location = New Point(425, 223)
        comida.Name = "comida"
        comida.Size = New Size(116, 29)
        comida.TabIndex = 14
        comida.Text = "Almoço/Jantar"
        comida.UseVisualStyleBackColor = True
        ' 
        ' menudia
        ' 
        menudia.Location = New Point(413, 126)
        menudia.Name = "menudia"
        menudia.Size = New Size(128, 29)
        menudia.TabIndex = 15
        menudia.Text = "Menu do Dia"
        menudia.UseVisualStyleBackColor = True
        ' 
        ' sobremesa
        ' 
        sobremesa.Location = New Point(438, 269)
        sobremesa.Name = "sobremesa"
        sobremesa.Size = New Size(103, 29)
        sobremesa.TabIndex = 23
        sobremesa.Text = "Sobremesas" & vbCrLf
        sobremesa.UseVisualStyleBackColor = True
        ' 
        ' bebida1
        ' 
        bebida1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        bebida1.Location = New Point(12, 49)
        bebida1.Name = "bebida1"
        bebida1.Size = New Size(425, 30)
        bebida1.TabIndex = 24
        bebida1.Text = "Johnnie Walker Jubileu de Diamante - 146.604,00€" & vbCrLf
        ' 
        ' bebida2
        ' 
        bebida2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        bebida2.Location = New Point(12, 128)
        bebida2.Name = "bebida2"
        bebida2.Size = New Size(358, 30)
        bebida2.TabIndex = 25
        bebida2.Text = "Bombay Sapphire Revelation - 177.681,00€"
        ' 
        ' bebida3
        ' 
        bebida3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        bebida3.Location = New Point(12, 211)
        bebida3.Name = "bebida3"
        bebida3.Size = New Size(391, 30)
        bebida3.TabIndex = 26
        bebida3.Text = "Tribute To Honor By Royal Salute - 190.488,00€"
        ' 
        ' bebida4
        ' 
        bebida4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        bebida4.Location = New Point(12, 293)
        bebida4.Name = "bebida4"
        bebida4.Size = New Size(278, 30)
        bebida4.TabIndex = 27
        bebida4.Text = "Billionaire Vodka - 3.299.250,00€" & vbCrLf & vbCrLf
        ' 
        ' bebida5
        ' 
        bebida5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        bebida5.Location = New Point(12, 379)
        bebida5.Name = "bebida5"
        bebida5.Size = New Size(197, 30)
        bebida5.TabIndex = 28
        bebida5.Text = "Copo com água - 0,50€"
        ' 
        ' cmd_sair
        ' 
        cmd_sair.Location = New Point(447, 423)
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(94, 29)
        cmd_sair.TabIndex = 30
        cmd_sair.Text = "Sair"
        cmd_sair.UseVisualStyleBackColor = True
        ' 
        ' chkbebida1
        ' 
        chkbebida1.AutoSize = True
        chkbebida1.BackColor = Color.Transparent
        chkbebida1.Location = New Point(443, 57)
        chkbebida1.Name = "chkbebida1"
        chkbebida1.Size = New Size(18, 17)
        chkbebida1.TabIndex = 31
        chkbebida1.UseVisualStyleBackColor = False
        ' 
        ' chkbebida2
        ' 
        chkbebida2.AutoSize = True
        chkbebida2.BackColor = Color.Transparent
        chkbebida2.Location = New Point(376, 136)
        chkbebida2.Name = "chkbebida2"
        chkbebida2.Size = New Size(18, 17)
        chkbebida2.TabIndex = 32
        chkbebida2.UseVisualStyleBackColor = False
        ' 
        ' chkbebida3
        ' 
        chkbebida3.AutoSize = True
        chkbebida3.BackColor = Color.Transparent
        chkbebida3.Location = New Point(405, 219)
        chkbebida3.Name = "chkbebida3"
        chkbebida3.Size = New Size(18, 17)
        chkbebida3.TabIndex = 33
        chkbebida3.UseVisualStyleBackColor = False
        ' 
        ' chkbebida4
        ' 
        chkbebida4.AutoSize = True
        chkbebida4.BackColor = Color.Transparent
        chkbebida4.Location = New Point(296, 301)
        chkbebida4.Name = "chkbebida4"
        chkbebida4.Size = New Size(18, 17)
        chkbebida4.TabIndex = 34
        chkbebida4.UseVisualStyleBackColor = False
        ' 
        ' chkbebida5
        ' 
        chkbebida5.AutoSize = True
        chkbebida5.BackColor = Color.Transparent
        chkbebida5.Location = New Point(215, 387)
        chkbebida5.Name = "chkbebida5"
        chkbebida5.Size = New Size(18, 17)
        chkbebida5.TabIndex = 35
        chkbebida5.UseVisualStyleBackColor = False
        ' 
        ' preçototal
        ' 
        preçototal.AutoSize = True
        preçototal.Location = New Point(333, 13)
        preçototal.Name = "preçototal"
        preçototal.Size = New Size(46, 20)
        preçototal.TabIndex = 36
        preçototal.Text = "Preço"
        ' 
        ' addchk
        ' 
        addchk.Location = New Point(406, 7)
        addchk.Name = "addchk"
        addchk.Size = New Size(135, 29)
        addchk.TabIndex = 37
        addchk.Text = "Adicionar Conta"
        addchk.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(553, 464)
        Controls.Add(addchk)
        Controls.Add(preçototal)
        Controls.Add(chkbebida5)
        Controls.Add(chkbebida4)
        Controls.Add(chkbebida3)
        Controls.Add(chkbebida2)
        Controls.Add(chkbebida1)
        Controls.Add(cmd_sair)
        Controls.Add(bebida5)
        Controls.Add(bebida4)
        Controls.Add(bebida3)
        Controls.Add(bebida2)
        Controls.Add(bebida1)
        Controls.Add(sobremesa)
        Controls.Add(menudia)
        Controls.Add(comida)
        Controls.Add(entrada)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form4"
        Text = "Taverna ""O Pipo"""
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents entrada As Button
    Friend WithEvents comida As Button
    Friend WithEvents menudia As Button
    Friend WithEvents sobremesa As Button
    Friend WithEvents bebida1 As TextBox
    Friend WithEvents bebida2 As TextBox
    Friend WithEvents bebida3 As TextBox
    Friend WithEvents bebida4 As TextBox
    Friend WithEvents bebida5 As TextBox
    Friend WithEvents cmd_sair As Button
    Friend WithEvents chkbebida1 As CheckBox
    Friend WithEvents chkbebida2 As CheckBox
    Friend WithEvents chkbebida3 As CheckBox
    Friend WithEvents chkbebida4 As CheckBox
    Friend WithEvents chkbebida5 As CheckBox
    Friend WithEvents preçototal As Label
    Friend WithEvents addchk As Button
End Class
