import operator
class persona():
    def __new__(self, nombre, apellido):
        print("Bienvenido, ¿que paso? ¿que le doy? ¿Que va a querer? ¿Que va a llevar? Para eso estoy, para servirle Uwu")

    def __init__(self, nombre, apellido):
        self.nombre= nombre
        self.apellido= apellido
    
    def __str__(self):
        return(f"Nombre: {self.nombre} Apellido: {self.apellido}")
    
    def __del__(self):
        print("Y se marchooo")
    
juli= persona("Julian", "Perez")
marta= persona("Martina", "donadio")
print(operator.eq(juli, marta)) #Esta es la funcion que sustituye a la cmp ya que no existe en python 3

