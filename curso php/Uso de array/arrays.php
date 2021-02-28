<?php
 //una forma de usar los arrays
    $valores[0]=1;
    $valores[1]= 2;
    $valores[2]=1;
   //otra forma es:
    //lo llamas normalmente por posicion como otro[1]
    $otro=array(54,23,45,67);
    
    //pero este usas: $epa["nombre"] te devuelve el valor "julian"
    $epa=array("nombre"=>"julian","apellido"=>"perez");

    foreach($epa as $campo=> $valor){
        //$campo=posicion del array, %valor=valor almacenado en esa posicion
        echo "el $campo = $valor <br>";
    }

    $alimentos= array("fruta"=>array("tropical"=>"kiwi",
                                        "citrico"=>"naranja",
                                        "otro"=>"manzana"),
                        "leche"=>array("animal"=>"vaca",
                                        "vegetal"=>"coco"),
                         "carne"=>array("vaca"=>"lomo",
                                        "cerdo" =>"carre") );

        foreach($alimentos as $clave_alim=>$alim){  //esto me tira la primer dimension del array
            echo "$clave_alim:<br>";
            while(list($clave,$comida)= each($alim)){ //y esto para imprimir la segunda dimension
                echo "$clave=$comida <br>";
            }
        }
        //otra forma de usar llamar el array sin funcion:
            echo var_dump($alimentos);

    $Barray[0][0]=1;
    $Barray[0][1]=22;
    $Barray[1][0]=5;
    $Barray[1][1]=34;
    

    for($i=0;$i<2;$i++){
        for($j=0;$j<2;$j++){
          
            echo "los valores del array bidimensional son:". $Barray[$i][$j]. "<br>";
            
        }
    }
?>