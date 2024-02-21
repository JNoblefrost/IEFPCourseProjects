<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="stylesheet.css" type="text/css"/>
    <!-- <link href="https://fonts.cdnfonts.com/css/walk-the-moon" rel="stylesheet"> -->
    <title>Forum para Programadores</title>
</head>
<body>
    <h1>Forum para programadores</h1>
    <?php
        include 'includes/valida.php';

        echo "<h2 id='welcomeGreeting'>Bem vindo ".$_SESSION['nick']."!</h2>";        
    ?>
    <div id="butoes">
    <input type="button" value="Editar Perfil" onclick="window.open('perfil_u.php','_self')">
    <input type="button" value="Colocar posts" onclick="window.open('inserirP.php','_self')">
    <input type="button" value="Listar posts" onclick="window.open('listar_P.php?tema=Todos','_self')">
    <input type="button" value="Meus posts" onclick="window.open('meusP.php','_self')">
    <input type="button" value="Minhas Respostas" onclick="window.open('minhasR.php','_self')">
    <input type="button" value="Logout" onclick="window.open('logout.php','_self')">
    </div>

    <?php

    if (strcmp($_SESSION['nick'],"admin")==0)
    {
    ?>
        <div id="adminZone">
            <br><br><h2>Área de Administração</h2>
            <input type="button" value="Gerir Utilizadores" onclick="window.open('gerir_U.php','_self')">
            <input type="button" value="Pesquisar Utilizadores" onclick="window.open('pesquisar_U.php','_self')">
            <input type="button" value="Gerir Posts" onclick="window.open('gerir_P.php','_self')">
            <input type="button" value="Gerir Respostas" onclick="window.open('gerir_R.php','_self')">
        </div>
    <?php
    }
    ?>

</body>
</html>