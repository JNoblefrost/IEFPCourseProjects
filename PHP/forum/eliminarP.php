<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="stylesheetIndex.css" rel="stylesheet" />
    <title>Eliminar Post</title>
</head>
<body>
<?php
    include 'includes/liga_bd.php';
    include 'includes/valida.php';
    include 'includes/nav_bar.php';
    $sql="UPDATE t_post SET apagado=1 WHERE id=".$_POST['id_post'];
    if(mysqli_query($ligacao,$sql)){
        echo "<h1>Post removido com sucesso!</h1>";
    }
    mysqli_close($ligacao);
    ?>

    <input type="button" value="Continuar" onclick="window.history.go(-2)">
    
</body>
</html>