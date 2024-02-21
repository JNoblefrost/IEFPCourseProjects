<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="stylesheetIndex.css" rel="stylesheet" />
    <title>Eliminar Resposta</title>
</head>
<body>
<?php
include 'includes/liga_bd.php';
include 'includes/valida.php';
    $sql="UPDATE t_resp SET apagado=0 WHERE id=".$_POST['id_resp'];
    if(mysqli_query($ligacao,$sql)){
        echo "<h1>Resposta recuperada com sucesso!</h1>";
    }
    mysqli_close($ligacao);
    ?>

    <input type="button" value="Continuar" onclick="window.history.go(-2)">
    
</body>
</html>