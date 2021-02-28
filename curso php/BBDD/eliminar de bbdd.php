<?php
    $conexion = mysqli_connect("localhost","root","","prueba_bbdd");
    $busqueda=$_GET["IDUusario"]; //se supone que aca tendria un textbox html llamado asi
    if(mysqli_connect_errno($conexion)){
        echo "error al conectarse a la BBDD";
        exit();
    }
    mysqli_set_charset($conexion,"utf8");
    $query="delete from usuario where IDUsuario= '$busqueda'";
    $resultado=mysqli_query($conexion,$query);
    If($resultado){
        if(mysqli_affected_rows($conexion)==0){
            echo "no existe para eliminar";
        }
        else{
            echo " se han eliminado" . mysqli_affected_rows($conexion) . "Registros";
        }
      }
    else{
        echo "error en la consulta"
    }
      mysqli_close($conexion);
    ?>