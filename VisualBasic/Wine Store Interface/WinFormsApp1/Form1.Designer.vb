<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        ComboBox1 = New ComboBox()
        menu_dia = New Label()
        menu = New Label()
        cmd_sair = New Button()
        tartesapo = New PictureBox()
        carneporco = New PictureBox()
        pizzaananas = New PictureBox()
        saladaouriço = New PictureBox()
        arrozcabidela = New PictureBox()
        saladaporco = New PictureBox()
        caracois = New PictureBox()
        preço = New Label()
        entrada = New Button()
        comida = New Button()
        bebidas = New Button()
        sobremesa = New Button()
        preçototal = New Label()
        contafinal = New Button()
        addchk = New Button()
        valor = New TextBox()
        bt_verificaçao = New Button()
        CType(tartesapo, ComponentModel.ISupportInitialize).BeginInit()
        CType(carneporco, ComponentModel.ISupportInitialize).BeginInit()
        CType(pizzaananas, ComponentModel.ISupportInitialize).BeginInit()
        CType(saladaouriço, ComponentModel.ISupportInitialize).BeginInit()
        CType(arrozcabidela, ComponentModel.ISupportInitialize).BeginInit()
        CType(saladaporco, ComponentModel.ISupportInitialize).BeginInit()
        CType(caracois, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 144)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 31)
        ComboBox1.TabIndex = 0
        ' 
        ' menu_dia
        ' 
        menu_dia.AutoSize = True
        menu_dia.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        menu_dia.Location = New Point(12, 102)
        menu_dia.Name = "menu_dia"
        menu_dia.Size = New Size(112, 24)
        menu_dia.TabIndex = 1
        menu_dia.Text = "Menu do Dia"
        ' 
        ' menu
        ' 
        menu.AutoSize = True
        menu.Font = New Font("Harlow Solid Italic", 15F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        menu.Location = New Point(12, 193)
        menu.Name = "menu"
        menu.Size = New Size(80, 32)
        menu.TabIndex = 2
        menu.Text = "Menu"
        menu.Visible = False
        ' 
        ' cmd_sair
        ' 
        cmd_sair.Location = New Point(447, 423)
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(94, 29)
        cmd_sair.TabIndex = 3
        cmd_sair.Text = "Sair"
        cmd_sair.UseVisualStyleBackColor = True
        ' 
        ' tartesapo
        ' 
        tartesapo.Image = CType(resources.GetObject("tartesapo.Image"), Image)
        tartesapo.Location = New Point(12, 266)
        tartesapo.Name = "tartesapo"
        tartesapo.Size = New Size(219, 186)
        tartesapo.SizeMode = PictureBoxSizeMode.StretchImage
        tartesapo.TabIndex = 4
        tartesapo.TabStop = False
        tartesapo.Visible = False
        ' 
        ' carneporco
        ' 
        carneporco.Image = CType(resources.GetObject("carneporco.Image"), Image)
        carneporco.Location = New Point(12, 266)
        carneporco.Name = "carneporco"
        carneporco.Size = New Size(219, 186)
        carneporco.SizeMode = PictureBoxSizeMode.StretchImage
        carneporco.TabIndex = 5
        carneporco.TabStop = False
        carneporco.Visible = False
        ' 
        ' pizzaananas
        ' 
        pizzaananas.Image = CType(resources.GetObject("pizzaananas.Image"), Image)
        pizzaananas.Location = New Point(12, 266)
        pizzaananas.Name = "pizzaananas"
        pizzaananas.Size = New Size(219, 186)
        pizzaananas.SizeMode = PictureBoxSizeMode.StretchImage
        pizzaananas.TabIndex = 6
        pizzaananas.TabStop = False
        pizzaananas.Visible = False
        ' 
        ' saladaouriço
        ' 
        saladaouriço.Image = CType(resources.GetObject("saladaouriço.Image"), Image)
        saladaouriço.Location = New Point(12, 266)
        saladaouriço.Name = "saladaouriço"
        saladaouriço.Size = New Size(219, 186)
        saladaouriço.SizeMode = PictureBoxSizeMode.StretchImage
        saladaouriço.TabIndex = 7
        saladaouriço.TabStop = False
        saladaouriço.Visible = False
        ' 
        ' arrozcabidela
        ' 
        arrozcabidela.Image = CType(resources.GetObject("arrozcabidela.Image"), Image)
        arrozcabidela.Location = New Point(12, 266)
        arrozcabidela.Name = "arrozcabidela"
        arrozcabidela.Size = New Size(219, 186)
        arrozcabidela.SizeMode = PictureBoxSizeMode.StretchImage
        arrozcabidela.TabIndex = 8
        arrozcabidela.TabStop = False
        arrozcabidela.Visible = False
        ' 
        ' saladaporco
        ' 
        saladaporco.Image = CType(resources.GetObject("saladaporco.Image"), Image)
        saladaporco.Location = New Point(12, 266)
        saladaporco.Name = "saladaporco"
        saladaporco.Size = New Size(219, 186)
        saladaporco.SizeMode = PictureBoxSizeMode.StretchImage
        saladaporco.TabIndex = 9
        saladaporco.TabStop = False
        saladaporco.Visible = False
        ' 
        ' caracois
        ' 
        caracois.Image = CType(resources.GetObject("caracois.Image"), Image)
        caracois.Location = New Point(12, 266)
        caracois.Name = "caracois"
        caracois.Size = New Size(219, 186)
        caracois.SizeMode = PictureBoxSizeMode.StretchImage
        caracois.TabIndex = 10
        caracois.TabStop = False
        caracois.Visible = False
        ' 
        ' preço
        ' 
        preço.AutoSize = True
        preço.Font = New Font("Harlow Solid Italic", 15F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        preço.Location = New Point(265, 266)
        preço.Name = "preço"
        preço.Size = New Size(79, 32)
        preço.TabIndex = 11
        preço.Text = "Preço"
        preço.Visible = False
        ' 
        ' entrada
        ' 
        entrada.Location = New Point(447, 126)
        entrada.Name = "entrada"
        entrada.Size = New Size(94, 29)
        entrada.TabIndex = 12
        entrada.Text = "Entradas"
        entrada.UseVisualStyleBackColor = True
        ' 
        ' comida
        ' 
        comida.Location = New Point(413, 174)
        comida.Name = "comida"
        comida.Size = New Size(128, 29)
        comida.TabIndex = 13
        comida.Text = "Almoço/Jantar"
        comida.UseVisualStyleBackColor = True
        ' 
        ' bebidas
        ' 
        bebidas.Location = New Point(447, 223)
        bebidas.Name = "bebidas"
        bebidas.Size = New Size(94, 29)
        bebidas.TabIndex = 14
        bebidas.Text = "Bebidas"
        bebidas.UseVisualStyleBackColor = True
        ' 
        ' sobremesa
        ' 
        sobremesa.Location = New Point(438, 269)
        sobremesa.Name = "sobremesa"
        sobremesa.Size = New Size(103, 29)
        sobremesa.TabIndex = 15
        sobremesa.Text = "Sobremesas" & vbCrLf
        sobremesa.UseVisualStyleBackColor = True
        ' 
        ' preçototal
        ' 
        preçototal.AutoSize = True
        preçototal.Location = New Point(363, 18)
        preçototal.Name = "preçototal"
        preçototal.Size = New Size(46, 20)
        preçototal.TabIndex = 30
        preçototal.Text = "Preço"
        ' 
        ' contafinal
        ' 
        contafinal.Location = New Point(447, 12)
        contafinal.Name = "contafinal"
        contafinal.Size = New Size(94, 29)
        contafinal.TabIndex = 31
        contafinal.Text = "Conta Final"
        contafinal.UseVisualStyleBackColor = True
        ' 
        ' addchk
        ' 
        addchk.Location = New Point(237, 312)
        addchk.Name = "addchk"
        addchk.Size = New Size(135, 29)
        addchk.TabIndex = 32
        addchk.Text = "Adicionar Conta"
        addchk.UseVisualStyleBackColor = True
        ' 
        ' valor
        ' 
        valor.Location = New Point(130, 13)
        valor.Name = "valor"
        valor.Size = New Size(125, 27)
        valor.TabIndex = 33
        ' 
        ' bt_verificaçao
        ' 
        bt_verificaçao.Location = New Point(12, 12)
        bt_verificaçao.Name = "bt_verificaçao"
        bt_verificaçao.Size = New Size(94, 29)
        bt_verificaçao.TabIndex = 34
        bt_verificaçao.Text = "Verificação"
        bt_verificaçao.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(553, 464)
        Controls.Add(bt_verificaçao)
        Controls.Add(valor)
        Controls.Add(addchk)
        Controls.Add(contafinal)
        Controls.Add(preçototal)
        Controls.Add(sobremesa)
        Controls.Add(bebidas)
        Controls.Add(comida)
        Controls.Add(entrada)
        Controls.Add(preço)
        Controls.Add(caracois)
        Controls.Add(saladaporco)
        Controls.Add(arrozcabidela)
        Controls.Add(saladaouriço)
        Controls.Add(pizzaananas)
        Controls.Add(carneporco)
        Controls.Add(tartesapo)
        Controls.Add(cmd_sair)
        Controls.Add(menu)
        Controls.Add(menu_dia)
        Controls.Add(ComboBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Taverna ""O Pipo"""
        CType(tartesapo, ComponentModel.ISupportInitialize).EndInit()
        CType(carneporco, ComponentModel.ISupportInitialize).EndInit()
        CType(pizzaananas, ComponentModel.ISupportInitialize).EndInit()
        CType(saladaouriço, ComponentModel.ISupportInitialize).EndInit()
        CType(arrozcabidela, ComponentModel.ISupportInitialize).EndInit()
        CType(saladaporco, ComponentModel.ISupportInitialize).EndInit()
        CType(caracois, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents menu_dia As Label
    Friend WithEvents menu As Label
    Friend WithEvents cmd_sair As Button
    Friend WithEvents tartesapo As PictureBox
    Friend WithEvents carneporco As PictureBox
    Friend WithEvents pizzaananas As PictureBox
    Friend WithEvents saladaouriço As PictureBox
    Friend WithEvents arrozcabidela As PictureBox
    Friend WithEvents saladaporco As PictureBox
    Friend WithEvents caracois As PictureBox
    Friend WithEvents preço As Label
    Friend WithEvents entrada As Button
    Friend WithEvents comida As Button
    Friend WithEvents bebidas As Button
    Friend WithEvents sobremesa As Button
    Friend WithEvents preçototal As Label
    Friend WithEvents contafinal As Button
    Friend WithEvents addchk As Button
    Friend WithEvents valor As TextBox
    Friend WithEvents bt_verificaçao As Button
End Class
