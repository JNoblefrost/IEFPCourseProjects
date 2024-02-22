<html>

<head>
    <meta charset="utf-8">
    <link href="stylesheetIndex.css" rel="stylesheet" />
    <title>Gestão de Utilizadores</title>
</head>

<body>
    <h1>Listagem de Utilizadores</h1>

    <?php
    // abro a instrução para escrever código php
    
    //criar a variavel ligacao (1º ip do servidor, 2º nome do utilizador)
    // (3º senha por defeito vazia, e 4º nome da base de dados)   
    include 'includes/liga_bd.php';
    include 'includes/valida.php';
    include 'includes/nav_bar.php';

    if($_SESSION['admin']!=1){
        header("Location:erro_notAdmin.html");
    }else{
        //crio a instrução sql para selecionar todos os registos
        $sql = "SELECT * FROM t_user";

        // a variavel resultado vai guardar todos os dados de todos os clientes
        // o primeiro parametro é a base dados e o segundo a instrução sql
        $resultado = mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
        //variavel para contar os registos
        $num_reg = 0;
        $num_block = 0;
        //enquanto conseguir ler dados do array resultado imprime
        while ($linha = mysqli_fetch_assoc($resultado)) {
            if ($linha['apagado'] == 1) {
                echo "<div style='background-color:red'>";
            }
            echo "Id: " . $linha['id'] . "<br/>";
            echo "Nick: " . $linha['nick'] . "<br/>";
            echo "Nome: " . $linha['nome'] . "<br/>";
            echo "Email: " . $linha['email'] . "<br/>";
            echo "Data de nascimento: " . $linha['data_nasc'] . "<br/>";
            echo "Foto: <br/> <img height='100' src='" . $linha['foto'] . "'><br/><br/>";
            
            echo "<form style='margin-bottom: 0px' action='alterar.php' method='post'>";
            echo "<input type='hidden' name='id' value='" . $linha['id'] . "'>";
            echo "<input type='submit' value='Alterar'></form>";


            if ($linha['apagado'] == 0) {
                // o utilizado encontra-se ativo
                echo "<form action='bloquear_u.php' method='post'>";
                echo "<input type='hidden' name='id' value='" . $linha['id'] . "'><br>";
                echo "<input type='submit' value='Bloquear'></form><br>";
            } else {
                // o utilizador está bloquado
                echo "<form action='desbloquear_u.php' method='post'>";
                echo "<input type='hidden' name='id' value='" . $linha['id'] . "'><br>";
                echo "<input type='submit' value='Desbloquear'></form><br>";
                echo "</div>";
                $num_block++;
            }



            $num_reg = $num_reg + 1;
        }
        mysqli_close($ligacao);
        echo "<br/>";
        echo "<b>Numero de usuários registados -> " . $num_reg . "</br>";
        echo "<b>Numero de usuários Bloqueados -> " . $num_block . "</br>";
    } 
    //fecho a instrução de escrita em php
    ?>
    <br />
    <a href="index.html" target="_self">Volta ao Menu</a>
</body>

</html>