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
$sql="SELECT t_post.id,titulo,texto,t_post.foto,nick,t_post.apagado FROM t_post JOIN t_user ON t_post.id_user=t_user.id WHERE id_user=".$_SESSION['id'];
$resultado = mysqli_query($ligacao,$sql) or die (mysqli_error($ligacao));
$numreg=0;

//repete o ciclo enquanto houver linhas
while($linha=mysqli_fetch_assoc($resultado)){
    if($linha['apagado']==0){
        echo "<font color='black'>";
    }else{
        echo"<font color='red'>";
    }
    echo "<h3>Id:".$linha['id']."</h3>";
    echo "<b>Título:</b>".$linha['titulo']."</br>";
    echo "<b>Texto:</b>".$linha['texto']."</br>";
    echo "<b>Foto:</b></br> <img src=".$linha['foto']." height='100>'</br>";
    echo"</font>";
    if($linha['apagado']==0){
?>

<form action = "eliminarP.php" method="post">
    <input type="hidden" value="<?php echo $linha ['id']?>" name="id_post">
    <input type="submit" value="Elminar Post">
</form>
<?php
    }
    if($linha['apagado']==1){
    ?>
        <form action="recuperarP.php" method="post">
            <input type="hidden" value="<?php echo $linha['id']?>" name="id_post">
            <input type="submit" value="Recuperar Post">
        </form>
    <?php
    }
    if($linha['apagado']>1){
        echo "<marquee><h1>Post Bloqueado pelo ADMIN</h1></marquee>";
    }
        
    echo"<hr>";
    $numreg=$numreg+1;   
    }

    echo "Nº de Postagens> ". $numreg;
mysqli_close($ligacao);
?>

<br><br>
<input type="button" value="Voltar ao menu" onclick="window.history.go(-1);">

</body>
</html>