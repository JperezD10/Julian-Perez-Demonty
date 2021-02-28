<style>
    .resultado{
        color:red;
    }
</style>

<?php

if(isset($_POST["button"])){
    $num1=$_POST["num1"];
    $num2=$_POST["num2"];
   Calcular($num1,$num2);
   //echo "el valor de la raiz es: " . sqrt(25);
   for($i=0;$i<10;$i++){
       echo "impresion numero: " . ($i+1) . "<br>";
   }
}

 function Calcular(){
    if(!strcmp("Suma",$_POST["operacion"])){
        global $num1,$num2;
        $resultado=$num1+$num2;
        echo "<p class='resultado'>el resultado de la suma es: $resultado </p>";
    }
    elseif(!strcmp("Resta",$_POST["operacion"])){
        global $num1,$num2;
        $resultado=$num1-$num2;
        echo "<p class='resultado'>el resultado de la resta es: $resultado </p>";
    }
    elseif(!strcmp("Multiplicación",$_POST["operacion"])){
        global $num1,$num2;
        $resultado=$num1*$num2;
        echo "<p class='resultado'>el resultado de la multiplicacion es: $resultado </p>";
    }
    elseif(!strcmp("División",$_POST["operacion"])){
        global $num1,$num2;
        $resultado=$num1/$num2;
        echo "<p class='resultado'>el resultado de la division es: $resultado </p>";
    }
    elseif(!strcmp("Incremento",$_POST["operacion"])){
        global $num1;
        $resultado=++$num1;
        echo "<p class='resultado'>el resultado del incremento es: $resultado </p>";
    }
    elseif(!strcmp("Decremento",$_POST["operacion"])){
        global $num1;
        $resultado=--$num1;
        echo "<p class='resultado'>el resultado del decremento es: $resultado </p>";
    }
    else{
        global $num1,$num2;
        $resultado=$num1%$num2;
            echo "<p class='resultado'>el resultado del modulo es: $resultado </p>";
    }
 }
?>