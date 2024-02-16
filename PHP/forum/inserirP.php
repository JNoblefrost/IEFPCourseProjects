<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Forum para Programadores</title>
</head>
<body>
    <?php session_start(); ?>
    <h1>Inserir Post </h1>
    <form action="inserirP2.php" method="POST" name="f1">
        Id user: <input type="text" name="id" size="11" readonly value="<?php echo $_SESSION['id'] ?>"><br><br>
        Tema: <input type="text" name="tema" size="20" maxlength="20" required><br><br>
        Título: <input type="text" name="titulo" size="50" maxlength="50" required><br><br>
        Texto: <br><textarea cols="20" rows="4" name="texto" required></textarea><br><br>
        Foto(url): <br><textarea cols="20" rows="4" name="foto" required></textarea><br><br>

        <input type="submit" value="Colocar Post"/>
        <input type="reset" value="Limpar Campos"/>
        <input type="button" value="Voltar" onclick="window.history.go(-1)"/>

    </form>
</body>
</html>