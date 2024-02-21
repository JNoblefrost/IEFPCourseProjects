<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="refresh" content="5;url=index.html" />
    <link href="stylesheetIndex.css" rel="stylesheet" />
    <title>Forum de programadores</title>
</head>
<body>
    <?php
    include 'includes/valida.php';
    //Apaga as variáveis de sessão
    $_SESSION=array();
    //Por fim destroy o array
    session_destroy();
    ?>

    <h2 align="center">Sessão terminada com sucesso!</h2>
    <input type="button" value="Voltar ao Início" onclick="window.open('index.html','_self');


</body>
</html>