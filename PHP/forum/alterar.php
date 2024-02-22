<html>

<head>
    <meta charset="utf-8">
    <title>Alterar Registos</title>
    <link href="stylesheetIndex.css" rel="stylesheet" />
</head>

<body>

    <h1>Alteração de Registos</h1>
    <hr><br>

    <?php
    //obtem valor da combobox do form anterior
    $id = $_POST['id'];

    //estabelece a conexão ao servidor
    include "includes/liga_bd.php";
    include 'includes/valida.php';
    include 'includes/nav_bar.php';

    //procura na base de dados o registo que selecionei
    $sql = "SELECT * FROM t_user where id=" . $id;
    $resultado = mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
    $linha = mysqli_fetch_assoc($resultado);
    ?>

    <hr>
    <form action="alterar2.php" method="post">
        <p> Id: <input type="text" name="id" size="11" value="<?php echo $linha['id'] ?>" readonly></p>
        <p> Nick: <input type="text" name="nick" size="20" value="<?php echo $linha['nick'] ?>"></p>
        <p> Nome: <input type="text" name="nome" size="100" value="<?php echo $linha['nome'] ?>"></p>
        <p> Email: <input type="email" name="email" size="50" value="<?php echo $linha['email'] ?>"></p>
        <p> Data de Nascimento: <input type="date" name="data_nasc" size="10" value="<?php echo $linha['data_nasc'] ?>">
        </p>
        <p> Senha: <input type="password" name="pass" size="20" value="<?php echo $linha['pass'] ?>"></p>
        <p> Foto:<br />
            <textarea name="foto" cols="80" rows="4"><?php echo $linha['foto'] ?></textarea><br>
            </select>
        </p>
        <p>
            <input name=" submit" type="submit" value="Alterar" />
            <input type="reset" value="Limpar">
            <input type="button" value="Cancelar" onclick="window.history.go(-1);">
        </p>

    </form>

    <?php
    mysqli_close($ligacao);
    ?>

    <br><br>

</body>

</html>