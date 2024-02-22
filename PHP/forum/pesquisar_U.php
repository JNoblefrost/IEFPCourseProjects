<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="stylesheetIndex.css" rel="stylesheet" />
    <title>Forum Programadores</title>
</head>
<body>

<?php
//valida o acesso aravés das variaveis de sessão
include 'includes/valida.php';
include 'includes/nav_bar.php';
?>

<h1>Pesquisa de utilizadores</h1>
<form action="pesquisar_U2.php" method="post">
    Qual o campo a pesquisar:
    <select name="tema">
        <option value="nick">Nick</option>
        <option value="nome">Nome</option>
        <option value="email">E-mail</option>
        <option value="data_nasc">Data de nacimento</option>
    </select><br><br>
    Valor:<input type="text" size="50" name="valor" required><br><br>
    <input type="submit" value ="Pesquisar">
    <input type="reset" value="Limpar">
    <input type="button" value="Voltar" onclick="window.open('login2.php','_self')">
</form>
<br>
    
</body>
</html>