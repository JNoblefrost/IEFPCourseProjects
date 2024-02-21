<?php
        session_start();
        //Validação das variáveis de sessão

        if ((!isset ($_SESSION['id'])==true) and (!isset ($_SESSION['nick'])==true)){
            header('location:erro_acesso.html');
        };

?>