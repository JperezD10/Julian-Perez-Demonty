<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Documento sin título</title>
<style>
	h1{
		text-align:center;
        color: white;
        background-color: red;
	}

	table{
		background-color:#FFC;
		padding:5px;
		border:#666 5px solid;
	}
	
	.no_validado{
		font-size:18px;
		color:#F00;
		font-weight:bold;
        text-align: center;
        margin-top: 25px;
	}
	
	.validado{
		font-size:18px;
		color:#0C3;
		font-weight:bold;
         text-align: center;
	}


</style>
</head>

<body>
<h1>USANDO OPERADORES COMPARACIÓN</h1>

<form method="post" name="datos_usuario" id="datos_usuario">
  <table width="15%" align="center">
    <tr>
      <td>Nombre:</td>
      <td><label for="nombre_usuario"></label>
      <input type="text" name="nombre_usuario" id="nombre_usuario"></td>
    </tr>
    <tr>
      <td>Edad:</td>
      <td><label for="edad_usuario"></label>
      <input type="text" name="edad_usuario" id="edad_usuario"></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td colspan="2" align="center"><input type="submit" name="enviando" id="enviando" value="Enviar"></td>
    </tr>
  </table>
</form>

<?PHP
    
    if(isset($_POST["enviando"])){
        $usuario=$_POST["nombre_usuario"];
        $edad=$_POST["edad_usuario"];
        
        /*if($usuario=="juli" && $edad=="19"){
        echo "<p class='validado'> podes entrar </p>";
    }
    else{
        echo "<p class='no_validado'>no podes entrar </p>";
      }*/  
      echo $edad<18?"raja de aca menor </br>":"Podes entrar </br>";
    }
    define("NOMBRE",3.14);

    echo "el valor es ". NOMBRE;
    
    
    
    
    
?>


</body>
</html>