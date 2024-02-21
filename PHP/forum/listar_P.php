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
include 'includes/filtra_P.php';


$resultado = mysqli_query($ligacao,$sql) or die (mysqli_error($ligacao));
$numreg=0;

while($linha=mysqli_fetch_assoc($resultado)){
    //echo "<h3>Id:".$linha['id']."</h3>";
    echo "<b>Tema:</b>".$linha['tema']."</br>";
    echo "<b>Título:</b>".$linha['titulo']."</br>";
    echo "<b>Texto:</b>".$linha['texto']."</br>";
    echo "<b>Foto:</b></br> <img src=".$linha['foto']." height='400>'</br>";

    echo "<h3>Nick: ".$linha['nick']."</h3>";


?>

<form action="inserirR.php" method="post">
    <input type="hidden" value="<?php echo $linha['id'] ?>" name="id_post">
    <input type="submit" value="Ver Respostas/Responder">
</form>
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