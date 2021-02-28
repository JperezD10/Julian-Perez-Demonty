#comprension de listas
numbers = [1, 2, 3, 4, 5]
doubled_numbers = [n * 2 for n in numbers]

#generadores
def miGenerador(n,m,s):
    while(n<=m):
        yield n
        n+=s

for n in miGenerador(0,5,1):
    print (n)

lista= list(miGenerador(0,5,1))
print(lista)


#decoradores
def Decorador(function):
    def nueva(*args):
        print("LLamada a la funcion"), function.__name__
        retorno= function(*args)
        return retorno
    return nueva

@Decorador
def imp(s):
    print(s)
imp("Hola susana")

#excepciones

edad= input("Ingrese su edad: ")

try:
    doble = edad*2
    print(edad)
except Exception as e:
    print(e)