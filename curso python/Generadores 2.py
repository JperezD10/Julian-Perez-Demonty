#que me tire las letras de las ciudades 
def MostrarCiudades(*ciudades): #el * indica que es una tupla indeterminda
    for elemento in ciudades:
        yield from elemento #suplanta los for anidados

ciudadesDevueltas=MostrarCiudades("bahia","adrogue","neuquen")

print(next(ciudadesDevueltas))
