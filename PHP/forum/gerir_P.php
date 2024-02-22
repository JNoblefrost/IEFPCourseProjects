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
include 'includes/nav_bar.php';

if($_SESSION['admin']!=1){
    header("Location:erro_notAdmin.html");
}else{
    echo "<h1>Gestão de Posts</h1>";
    echo "<br><br><br>";
    
    $sql="SELECT t_post.id,titulo,texto,t_post.foto,nick,t_post.apagado FROM t_post JOIN t_user ON t_post.id_user=t_user.id";
    $resultado = mysqli_query($ligacao,$sql) or die (mysqli_error($ligacao));
    $numreg=0;
    
    while($linha=mysqli_fetch_assoc($resultado)){
        if($linha['apagado']!=0){
            echo"<font color='red'>";
        }
        //echo "<h3>Id: ".$linha['id']."</h3>";
        echo "<h3>User: ".$linha['nick']."</h3><br>";
        echo "<b>Título: </b>".$linha['titulo']."</br>";
        echo "<b>Texto: </b>".$linha['texto']."</br>";
        echo "<b>Foto: </b></br> <img src=".$linha['foto']." height='400>'</br>";
    
    
    
        echo "</font>"
    ?>
    
    <?php
    if($linha['apagado']==0){
    ?>
    <form action="eliminaPadm.php" method="post">
        <select name="motivo">
            <option value="2">Violência</option>
            <option value="3">Pornografia</option>
            <option value="4">Racismo</option>
            <option value="5">Publicidade</option>
            <option value="6">Outros</option>
        </select>
        <input type="hidden" value="<?php echo $linha['id']?>" name="id_post">
        <input type="submit" value="Eliminar Post">
    </form>
    <?php
    }else{
    ?>
    <form action="recuperarP.php" method="post">
        <input type="hidden" value="<?php echo $linha['id']?>" name="id_post">
        <input type="submit" value="Recuperar Post">
    </form>
    <?php
    }
    ?>
    
    <?php 
    echo "<hr>";
    $numreg=$numreg+1;
    
    }
    echo "Nº de postagens > ".$numreg;
    mysqli_close($ligacao);
}


?>

<br><br>
<input type="button" value="Voltar ao menu" onclick="window.history.go(-1);">
</body>
</html>