<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Forum para Programadores</title>
</head>
<body>
    <?php session_start();
    
    include 'liga_bd.php';

    if ($_POST['foto']!= null){
        $sql="INSERT INTO t_resp (id_user,id_post,texto, foto) VALUES
    ($_POST[id_user],
    $_POST[id_post],
    '$_POST[texto]',
    '$_POST[foto]')";
    }else{
    $sql="INSERT INTO t_resp (id_user,id_post,texto) VALUES
    ($_POST[id_user],
    $_POST[id_post],
    '$_POST[texto]')";
    }
    
    
    if(mysqli_query($ligacao, $sql)) {
        echo "<h1>Resposta publicada com sucesso!</h1>";
    }
    mysqli_close($ligacao);
    
    ?>
   <input type="button"  value="Continuar" onclick="window.history.go(-2)">

    </form>
</body>
</html>