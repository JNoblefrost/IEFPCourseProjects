<?php
    $tema="SELECT distinct(tema) FROM t_post WHERE apagado=0 ORDER BY tema";
    $tema_res = mysqli_query($ligacao,$tema) or die(mysqli_error($ligacao));
    echo "<h1>Listagem de Posts - ".$_GET['tema']."</h1>";
    echo"<form action='listar_P.php' method='get' align='left'>";
    echo"<select name='tema' align='left'>";
    echo "<option value='Todos'>Todos</option>";
    //enquanto conseguir ler dados do array resultado imprime
    while($linha_tema=mysqli_fetch_assoc($tema_res)){
        echo"<option value'=".$linha_tema['tema']."'>".$linha_tema['tema']."</option>";
    }
    echo"</select>";
    echo"<input type='submit' value='Filtrar'>";
    echo"</form><br>";
    if(strcmp($_GET['tema'],"Todos")==0){
        $sql="SELECT t_post.id,tema,titulo,texto,t_post.foto,nick FROM t_post JOIN t_user ON t_post.id_user=t_user.id WHERE t_post.apagado=0";
    }else{
        $sql="SELECT t_post.id,tema,titulo,texto,t_post.foto,nick FROM t_post JOIN t_user ON t_post.id_user=t_user.id WHERE t_post.apagado=0 AND tema='".$_GET['tema']."'";
    }
    ?>