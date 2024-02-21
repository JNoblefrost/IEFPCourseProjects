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

$sql="SELECT t_resp.id,texto,t_resp.foto,nick,t_resp.apagado FROM t_resp JOIN t_user ON t_resp.id_user=t_user.id";
$resultado = mysqli_query($ligacao,$sql) or die (mysqli_error($ligacao));
$numreg=0;

while($linha=mysqli_fetch_assoc($resultado)){
    if($linha['apagado']==0){
        echo "<font color='black'>";
    }else{
        echo"<font color='red'>";
    }
    echo "<h3>Id:".$linha['id']."</h3>";
    echo "<b>Texto:</b>".$linha['texto']."</br>";
    echo "<b>Foto:</b></br> <img src=".$linha['foto']." height='100'></br>";

    echo "<h3>Nick: ".$linha['nick']."</h3>";


?>

<?php
if($linha['apagado']==0){
?>
<form action="eliminaRadm.php" method="post">
    <select name="motivo">
        <option value="2">Violência</option>
        <option value="3">Pornografia</option>
        <option value="4">Racismo</option>
        <option value="5">Publicidade</option>
        <option value="6">Outros</option>
    </select>
    <input type="hidden" value="<?php echo $linha['id']?>" name="id_resp">
    <input type="submit" value="Eliminar Resposta">
</form>
<?php
}else{
?>
<form action="recuperarR.php" method="post">
    <input type="hidden" value="<?php echo $linha['id']?>" name="id_resp">
    <input type="submit" value="Recuperar Resposta">
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