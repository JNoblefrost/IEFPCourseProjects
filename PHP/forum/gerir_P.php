<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Forum para Programadores</title>
</head>
<body>

<?php 
include 'liga_bd.php';

$sql="SELECT t_post.id,titulo,texto,t_post.foto,nick,t_post.apagado FROM t_post JOIN t_user ON t_post.id_user=t_user.id";
$resultado = mysqli_query($ligacao,$sql) or die (mysqli_error($ligacao));
$numreg=0;

while($linha=mysqli_fetch_assoc($resultado)){
    if($linha['apagado']==0){
        echo "<font color='black'>";
    }else{
        echo"<font color='red'>";
    }
    echo "<h3>Id:".$linha['id']."</h3>";
    echo "<b>Título:</b>".$linha['titulo']."</br>";
    echo "<b>Texto:</b>".$linha['texto']."</br>";
    echo "<b>Foto:</b></br> <img src=".$linha['foto']." height='400>'</br>";

    echo "<h3>Nick: ".$linha['nick']."</h3>";


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
?>

<br><br>
<input type="button" value="Voltar ao menu" onclick="window.history.go(-1);">
</body>
</html>