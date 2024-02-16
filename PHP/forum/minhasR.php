<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="stylesheet.css" rel="stylesheet">
    <title>Minhas respostas</title>
</head>
<body>

<?php 
session_start();
include 'liga_bd.php';
//$sql="SELECT t_post.id,titulo,texto,t_post.foto,nick FROM t_post JOIN t_user ON t_post.user_id=t_user.id WHERE t_post.id=".$_POST['id_post'];
$sql="SELECT * FROM t_resp WHERE id_user=".$_SESSION['id'];
$resultado = mysqli_query($ligacao,$sql) or die (mysqli_error($ligacao));
$numresp=0;


while($linha=mysqli_fetch_assoc($resultado))
{
    if($linha['apagado']==0){
        echo "<font color='black'>";
    }else{
        echo"<font color='red'>";
    }
    echo "</br><h1>ID:".$linha['id']."</h1>";
    echo "<b>Texto:</b>".$linha['texto']."</br>";
    echo "<b>Foto</b>:</br><img src=".$linha['foto']." height='100'></br>";

    echo "</font>";
    
    $sqlPostSel= "SELECT t_post.tema,t_post.titulo,t_post.texto,t_post.foto FROM t_post JOIN t_resp ON t_post.id=t_resp.id_post";
    $resultadoPostSel = mysqli_query($ligacao,$sqlPostSel) or die (mysqli_error($ligacao));
    $linhaPostSel = mysqli_fetch_assoc($resultadoPostSel);
    echo "<table id='tabelaResp' width='100%' align='left' border='1'>";
    echo "<tr><th id='respHeader' colspan='3'><h1>Resposta a</h1></th></tr>";
    echo "<td><b>Tema:</b>".$linhaPostSel['tema']."</br>";
    echo "<b>Título:</b>".$linhaPostSel['titulo']."</br>";
    echo "<b>Texto:</b>".$linhaPostSel['texto']."</br></td>";
    echo "<td><img src=".$linhaPostSel['foto']." height='100'></td>";
    echo "</table></br></br>";
    $numresp++;
    

    if($linha['apagado']==0){
        ?>
        
        <form action = "eliminarR.php" method="post">
            <input type="hidden" value="<?php echo $linha ['id']?>" name="id_resp">
            <input type="submit" value="Elminar Resposta">
        </form>
        <?php
            }
            if($linha['apagado']==1){
            ?>
                <form action="recuperarR.php" method="post">
                    <input type="hidden" value="<?php echo $linha['id']?>" name="id_resp">
                    <input type="submit" value="Recuperar Resposta">
                </form>
            <?php
            }
            if($linha['apagado']>1){
                echo "<marquee><h1>Resposta Bloqueada pelo ADMIN</h1></marquee>";
            }
            }
        
            
        mysqli_close($ligacao);
        ?>


</body>
</html>