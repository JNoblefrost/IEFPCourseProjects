<?php
?>

<div id="butoes">
  <input
    type="button"
    value="Editar Perfil"
    onclick="window.open('perfil_u.php','_self')"
  />
  <input
    type="button"
    value="Colocar posts"
    onclick="window.open('inserirP.php','_self')"
  />
  <input
    type="button"
    value="Listar posts"
    onclick="window.open('listar_P.php?tema=Todos','_self')"
  />
  <input
    type="button"
    value="Meus posts"
    onclick="window.open('meusP.php','_self')"
  />
  <input
    type="button"
    value="Minhas Respostas"
    onclick="window.open('minhasR.php','_self')"
  />
  <input
    type="button"
    value="Logout"
    onclick="window.open('logout.php','_self')"
  />
</div>

<?php

    if ($_SESSION['admin']==1)
    {
    ?>
        <div id="butoes">
            <input type="button" value="Gerir Utilizadores" onclick="window.open('gerir_U.php','_self')">
            <input type="button" value="Pesquisar Utilizadores" onclick="window.open('pesquisar_U.php','_self')">
            <input type="button" value="Gerir Posts" onclick="window.open('gerir_P.php','_self')">
            <input type="button" value="Gerir Respostas" onclick="window.open('gerir_R.php','_self')">
        </div>
    <?php
    }
    ?>