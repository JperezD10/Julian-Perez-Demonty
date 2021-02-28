<?php
    //nombre host, usuario que por defecto es root, contraseña, base de datos
    //$conexion=mysqli_connect("localhost","root","","prueba_bbdd");
    $conexion = new mysqli("localhost","root","","prueba_bbdd");
    $busqueda=$_GET["Buscar"];
    if(mysqli_connect_errno($conexion)){
        echo "error al conectarse a la BBDD";
        exit();
    }
    mysqli_set_charset($conexion,"utf8");
    $query="select * from usuario where NombreUsuario like '%$busqueda%'";
    $resultado=mysqli_query($conexion,$query);
    If($resultado){
        //while ($fila = mysqli_fetch_row($resultado)) { //el fetch row me da las columnas como indices
          //  echo $fila[0] . " " . $fila[1] . "<br>";
          //}
        while($fila= mysqli_fetch_array($resultado, MYSQL_ASSOC)){ //este me permite llamar al array con el nombre de la columna
            echo $fila['NombreUsuario'] . " " . $fila["Contraseña"] . "<br>";
        }
      }
      mysqli_close($conexion);
      
?>