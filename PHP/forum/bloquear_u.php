<html>

<head>
    <meta charset="utf-8">
    <meta http-equiv="refresh" content="3;url=gerir_u.php" />
    <title>Bloquear Clientes</title>
</head>

<body>

    <?php
    //liga-se ao servidor com user e pass
    include "liga_bd.php";

    // instrução sql para adicionar
    $sql = "UPDATE t_user SET
    apagado=1
    WHERE id=$_POST[id]";
    //echo $sql;
    
    if (mysqli_query($ligacao, $sql)) {
        echo "<h1>Usuário bloqueado com sucesso!</h1>";
    }

    mysqli_close($ligacao);
    ?>
    <p>
    <h2> Aguarde, vai ser redireccionado</h2>
    </p>
</body>

</html>