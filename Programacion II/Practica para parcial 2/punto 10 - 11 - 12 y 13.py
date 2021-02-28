lista= [5,1,456]

cadena={7,3242,8678,2}

diccionario={"Juli":"Marti","Ruso":"Ceci","Vale":"Rudy"}


# punto 11

#Función de orden superior
def saludar(idioma):
    def saludar_es():
        print("Hola")

    def saludar_en():
        print("Hello")

    def saludar_fr():
        print("Salut")

    lang_func = {"es": saludar_es,  # Diccionario que contiene cada idioma y con su función referenciada
                 "en": saludar_en,
                 "fr": saludar_fr}
    return lang_func[idioma]

#f es una variable que contiene una función retornada por saludar.
f = saludar("es")
f()

#punto 12
#Map
def cuadrado(n):
    return n ** 2

l = [1, 2, 3]
cuadrados = map(cuadrado, l)

for numero in cuadrados:
    print(numero)

#filter

def es_par(n):
    return (n % 2.0 == 0)

l = [1, 2, 3]
l2 = filter(es_par, l)

for numero in l2:
    print("Es par: ", numero)


#reduce
from functools import reduce

def sumar(x, y):
    return x + y

l = [1, 2, 3]
suma = reduce(sumar, l)   

print("Suma: ", suma)

#funcion lambda 
l = [1, 2, 3, 4]
pares = filter(lambda n: n % 2.0 == 0, l)

for numero in pares:
    print("Es par: ", numero)