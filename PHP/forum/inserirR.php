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
//$sql="SELECT t_post.id,titulo,texto,t_post.foto,nick FROM t_post JOIN t_user ON t_post.user_id=t_user.id WHERE t_post.id=".$_POST['id_post'];
$sql="SELECT * FROM t_post WHERE id=".$_POST['id_post'];
$resultado = mysqli_query($ligacao,$sql) or die (mysqli_error($ligacao));
$numreg=0;

//exposição do post
$linha=mysqli_fetch_assoc($resultado);
echo "<h3>Id:".$linha['id']."</h3>";
echo "<b>Título:</b>".$linha['titulo']."</br>";
echo "<b>Texto:</b>".$linha['texto']."</br>";
echo "<b>Foto:</b></br> <img src=".$linha['foto']." height='100'></br>";
$sql2="SELECT * FROM t_user WHERE id=".$linha['id_user'];
$resultado2= mysqli_query($ligacao,$sql2) or die (mysqli_error($ligacao));
$linha2 = mysqli_fetch_assoc($resultado2);
echo "<h3>Nick: ".$linha2['nick']."</h3>";
//respostas ao post principal de utilizadores
$numresp=0;
$sql3 = "SELECT * FROM t_resp WHERE id_post=".$linha['id']." AND apagado=0";
// executo o sql no meu serivdor
$resultado3=mysqli_query($ligacao,$sql3) or die (mysqli_error($ligacao));

echo "<table width='80%' align='center' border='1'>";
//repete o ciclo enquanto houver linhas

while($linha3=mysqli_fetch_assoc($resultado3))
{
    echo "<tr><td>".$linha3['texto']."</td>";
    echo "<td><img src=".$linha3['foto']." height='100'></td>";
    $sql4="SELECT * FROM t_user WHERE id=".$linha3['id_user'];
    //executo o sql no meu servidor
    $resultado4=mysqli_query($ligacao,$sql4) or die (mysqli_error($ligacao));
    $linha4 = mysqli_fetch_assoc($resultado4);
    echo"<td>".$linha4['nick']."</td></tr>";
    $numresp++;
}

echo "<tr><td colspan='3' align='center'> Total de respostas: ".$numresp."</td></tr>";
echo "</table>";
//fim respostas

?>

<!-- responder -->

<h1>Responder ao Post</h1>

<form action="inserirR2.php" method="post" name="f1">
    <input type="hidden" size="20" maxlength="20" value="<?php echo $_SESSION['id'] ?>" name="id_user"></br>
    <input type="hidden" name="id_post" readonly value= "<?php echo $linha['id']?>"></br>
    Texto: <br><textarea cols="80" row="4" name="texto"></textarea></br>
    Foto(url): <br><textarea cols="80" row="4" name="foto"></textarea></br></br>
    <input type="submit" value="Responder"/></br></br>
    <input type="reset" value="Limpar Campos"/></br></br>
    <input type="button" value="Voltar" onclick="window.history.go(-1)"/></br></br>
</form>


<?php 
mysqli_close($ligacao);
?>

</body>
</html>