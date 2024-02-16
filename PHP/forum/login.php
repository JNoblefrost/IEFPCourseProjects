<html>

<head>
    <meta charset="utf-8">
    <link rel="stylesheet" href="stylesheet.css" type="text/css"/>
</head>

<body>
<h1>Validação de utilizadores</h1>
    <?php
    //liga-se ao servidor com user e pass
    include "liga_bd.php";

    //Verificar se existe uma variavel de sessão
    if(session_status()!==PHP_SESSION_ACTIVE){
        $sql="SELECT * FROM t_user WHERE nick='$_POST[nick]'";
        //pesquisar apenas o nick do registo enviado
        $resultado=mysqli_query($ligacao,$sql);
        //vou ao array resultadoe  obtenho a primeira linha
        $linha=mysqli_fetch_assoc($resultado);
        //caso não exista variavel
        if($linha==NULL){
            header('Location:erro.html');
        }
        //caso o nickname exista
        if(strcmp($linha['pass'],$_POST['pass']==0)){
            session_start();
            $_SESSION['id'] = $linha['id'];
            $_SESSION['nick'] = $linha['nick'];
            header('Location:login2.php');
        }
        //em caso de senha incorreta
        else{
            header('Location:erro.html');
        }
    }
    mysqli_close($ligacao); echo "<br/>";
    ?>
</body>
</html>