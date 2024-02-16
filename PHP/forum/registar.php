<html>

<head>
    <meta charset="utf-8">
    <title>Gestão de Utilizadores</title>
    <!-- ao fim de 5 segundo redireciona para o index-->
    <meta http-equiv="refresh" content="5;url=index.html">
</head>

<body>
    <h1>Registar Utilizadores</h1>
    <?php
    //criar a variavel ligacao (1º ip do servidor, 2º nome do utilizador)
    // (3º senha por defeito vazia, e 4º nome da base de dados)   
    $ligacao = mysqli_connect("127.0.0.1", "root", "", "bd_forum");
    // tento executar a ligação ao meu servidor
    if ($ligacao->connect_error)
        die(mysqli_error($ligacao));

    //crio a instrução sql para inserir um novo registo
    $sql = "INSERT INTO t_user (nick, nome, email, data_nasc, pass, foto) VALUES
            ('$_POST[nick]','$_POST[nome]', '$_POST[email]', '$_POST[data_nasc]', '$_POST[pass]', '$_POST[foto]')";
    // os campos recebidos do formulário anterior pelo metodo post, tudo tem pelicas menos o float (vol_fatur)
    // caso consiga executar a ação mostra a mensagem de sucesso
    if (mysqli_query($ligacao, $sql))
        echo "<h3>Cliente inserido com sucesso!</h3>";
    mysqli_close($ligacao);
    echo "<br/>";
    ?>
    <br />
    <h4>Aguarde que vai ser redirecionado</h4><a href="index.html" target="_self">Volta ao Menu</a>
</body>

</html>