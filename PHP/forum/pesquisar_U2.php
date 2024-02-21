<html>

<head>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link href="stylesheetIndex.css" rel="stylesheet" />
    <title>Gestão de Utilizadores</title>
</head>

<body>
    <h1>Pesquisa de Utilizadores</h1>

    <?php
    // abro a instrução para escrever código php
    
    //criar a variavel ligacao (1º ip do servidor, 2º nome do utilizador)
    // (3º senha por defeito vazia, e 4º nome da base de dados)   
    include 'includes/liga_bd.php';
    include 'includes/valida.php';



    //crio a instrução sql para selecionar todos os registos
    $num_reg=0;

    if($_POST['tema']=='nick'){

        $sql="SELECT * FROM t_user WHERE nick LIKE '".$_POST['valor']."%'";
        $resultado = mysqli_query($ligacao,$sql) or die (mysqli_error($ligacao));
        while ($linha = mysqli_fetch_assoc($resultado)) {
            if ($linha['apagado'] == 1) {
                echo "<div style='background-color:red'>";
            }
            echo "Id: " . $linha['id'] . "<br/>";
            echo "Nick: " . $linha['nick'] . "<br/>";
            echo "Nome: " . $linha['nome'] . "<br/>";
            echo "Email: " . $linha['email'] . "<br/>";
            echo "Data de nascimento: " . $linha['data_nasc'] . "<br/>";
            echo "Foto: <br/> <img height='100' src='" . $linha['foto'] . "'<br/>";
    
            echo "<form action='alterar.php' method='post'>";
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
            }
    
    
    
            $num_reg = $num_reg + 1;
        }

    }else if($_POST['tema']=='nome'){

        $sql="SELECT * FROM t_user WHERE nome LIKE'".$_POST['valor']."%'";
        $resultado = mysqli_query($ligacao,$sql) or die (mysqli_error($ligacao));
        while ($linha = mysqli_fetch_assoc($resultado)) {
            if ($linha['apagado'] == 1) {
                echo "<div style='background-color:red'>";
            }
            echo "Id: " . $linha['id'] . "<br/>";
            echo "Nick: " . $linha['nick'] . "<br/>";
            echo "Nome: " . $linha['nome'] . "<br/>";
            echo "Email: " . $linha['email'] . "<br/>";
            echo "Data de nascimento: " . $linha['data_nasc'] . "<br/>";
            echo "Foto: <br/> <img height='100' src='" . $linha['foto'] . "'<br/>";
    
            echo "<form action='alterar.php' method='post'>";
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
            }
    
    
    
            $num_reg = $num_reg + 1;
        }
    }else if($_POST['tema']=='email'){

        $sql="SELECT * FROM t_user WHERE email LIKE'".$_POST['valor']."%'";
        $resultado = mysqli_query($ligacao,$sql) or die (mysqli_error($ligacao));
        while ($linha = mysqli_fetch_assoc($resultado)) {
            if ($linha['apagado'] == 1) {
                echo "<div style='background-color:red'>";
            }
            echo "Id: " . $linha['id'] . "<br/>";
            echo "Nick: " . $linha['nick'] . "<br/>";
            echo "Nome: " . $linha['nome'] . "<br/>";
            echo "Email: " . $linha['email'] . "<br/>";
            echo "Data de nascimento: " . $linha['data_nasc'] . "<br/>";
            echo "Foto: <br/> <img height='100' src='" . $linha['foto'] . "'<br/>";
    
            echo "<form action='alterar.php' method='post'>";
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
            }
    
    
    
            $num_reg = $num_reg + 1;
        }
    }else if($_POST['tema']=='data_nasc'){

        $sql="SELECT * FROM t_user WHERE data_nasc LIKE '".$_POST['valor']."%'";
        $resultado = mysqli_query($ligacao,$sql) or die (mysqli_error($ligacao));
        while ($linha = mysqli_fetch_assoc($resultado)) {
            if ($linha['apagado'] == 1) {
                echo "<div style='background-color:red'>";
            }
            echo "Id: " . $linha['id'] . "<br/>";
            echo "Nick: " . $linha['nick'] . "<br/>";
            echo "Nome: " . $linha['nome'] . "<br/>";
            echo "Email: " . $linha['email'] . "<br/>";
            echo "Data de nascimento: " . $linha['data_nasc'] . "<br/>";
            echo "Foto: <br/> <img height='100' src='" . $linha['foto'] . "'<br/>";
    
            echo "<form action='alterar.php' method='post'>";
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
            }
    
    
    
            $num_reg = $num_reg + 1;
        }
    }
    ?>

    <?php
    switch($_POST['tema']){
        case 'nick':
            echo '<h3>Número de usuários com o nick contendo"<b>'.$_POST['valor'].'</b>" :'.$num_reg.'</h3>';
            break;
        case 'nome':
            echo '<h3>Número de usuários com o nome contendo"<b>'.$_POST['valor'].'</b>" :'.$num_reg.'</h3>';
            break;
        case 'data_nasc':
            echo '<h3>Número de usuários com a data de nascimento contendo os dígitos "<b>'.$_POST['valor'].'</b>" :'.$num_reg.'</h3>';
    }
    ?>

<input type="button"  value="Voltar" onclick="window.history.go(-2)">
</body>

</html>