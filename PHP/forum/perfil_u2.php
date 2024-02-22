<html>

<head>
    <meta charset="utf-8">
    <meta http-equiv="refresh" content="5;url=login2.php" />
    <link href="stylesheetIndex.css" rel="stylesheet" />
    <title>Alterar Registos</title>
</head>

<body>
    
    <?php
    //liga-se ao servidor com user e pass
    include 'includes/liga_bd.php';
    include 'includes/valida.php';
    include 'includes/nav_bar.php';
    // instrução sql para adicionar
    $tmp=password_hash($_POST['pass'], PASSWORD_DEFAULT);
    
    $sql = "UPDATE t_user SET
    nick='$_POST[nick]',
    nome='$_POST[nome]',
    email='$_POST[email]',
    data_nasc='$_POST[data_nasc]',
    pass='$tmp',
    foto='$_POST[foto]'
    WHERE id=$_SESSION[id]";
    //echo $sql;
    $_SESSION['nick'] = $_POST['nick'];
    
    if (mysqli_query($ligacao, $sql)) {
        echo "<h1>Registo alterado com sucesso!</h1>";
    }

    mysqli_close($ligacao);
    ?>
    <p>
    <h2> Aguarde, vai ser redireccionado</h2>
    </p>
</body>

</html>