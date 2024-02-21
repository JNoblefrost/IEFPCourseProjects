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
    include 'includes/valida.php';
    include 'includes/liga_bd.php';?>
    
    <h1>Inserir Post </h1>
    <form action="inserirP2.php" method="POST" name="f1">
        <input type="hidden" name="id" size="11" readonly value="<?php echo $_SESSION['id'] ?>"><br><br>
        <?php 
            $tema="SELECT tema FROM t_tema ORDER BY tema";
            $tema_res = mysqli_query($ligacao,$tema) or die(mysqli_error($ligacao));
            echo"Tema: <select class='costum-select' name='tema' align='left'>";
            //enquanto conseguir ler dados do array resultado imprime
            while($linha_tema=mysqli_fetch_assoc($tema_res)){
                echo"<option value'=".$linha_tema['tema']."'>".$linha_tema['tema']."</option>";
            }
            echo "</select><br><br>";
        ?>
        Título: <input type="text" name="titulo" size="50" maxlength="50" required><br><br>
        Texto: <br><textarea cols="20" rows="4" name="texto" required></textarea><br><br>
        Foto(url): <br><textarea cols="20" rows="4" name="foto" required></textarea><br><br>

        <input type="submit" value="Colocar Post"/>
        <input type="reset" value="Limpar Campos"/>
        <input type="button" value="Voltar" onclick="window.history.go(-1)"/>

    </form>
</body>
</html>