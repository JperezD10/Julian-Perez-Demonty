<?php
    class Vehiculo{
        var $ruedas;
        var $motor;
        function descripcion(){
            echo "el vehiculo tiene " . $this->ruedas . " ruedas <br>";
        }
    }

    class Coche extends Vehiculo{
        var $marca;
        var $color;

        /*function Coche($marca,$color){
            $this->$marca=$marca;
            $this->$color=$color;
            echo "el color es: " . $this->$color . " y la marca es: " . $this->$marca;
        }*/
        function descripcion(){
            parent::descripcion();
            echo "pero es un auto " . $this->marca . " color " . $this->color . " <br>";
        }
    }

    $Auto1= new Coche();
    $Auto1->marca= "ford";
    $Auto1->color="gris";
    $Auto1->ruedas=4;
    echo $Auto1-> descripcion();

?>