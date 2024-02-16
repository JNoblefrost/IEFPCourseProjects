<?php
$servidor = "localhost";
$utilizador = "root";
$senha = "";
$bd = "bd_forum";
//criar a variavel ligacao (1º ip do servidor, 2º nome do utilizador, 
//3º senha por defetio vazia, e 4º nome da base de dados))
$ligacao = mysqli_connect($servidor, $utilizador, $senha, $bd);
// tento executar a ligação ao meu servidor
if ($ligacao->connect_error)
    die(mysqli_error($ligacao));
?>