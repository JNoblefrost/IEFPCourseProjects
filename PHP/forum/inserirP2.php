<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="stylesheetIndex.css" rel="stylesheet" />
    <title>Forum para Programadores</title>
</head>
<body>
    <?php 
    
    include 'includes/liga_bd.php';
    include 'includes/valida.php';

    //inserir na base de dados
    $sql="INSERT INTO t_post (tema,titulo,texto, foto, id_user) VALUES
    ('$_POST[tema]',
    '$_POST[titulo]',
    '$_POST[texto]',
    '$_POST[foto]',
    $_POST[id])";
 
    
    if(mysqli_query($ligacao, $sql)) {
        echo "<h1>Post publicado com sucesso!</h1>";
    }
    mysqli_close($ligacao);
    
    ?>
   <input type="button"  value="Continuar" onclick="window.history.go(-2)">

    </form>
</body>
</html>