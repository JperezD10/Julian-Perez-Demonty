def generarPares(limite):
    numero=1
    lista=[]
    while numero<=limite:
        lista.append(numero*2)
        numero+=1
    return lista

pares= int(input("Numero maximo de pares: "))
print(generarPares(pares))
#-------------------------- Con generadores Queda asi:
"""
def ParesGeneradores(limite):
    numero=1
    while numero<=limite:
        yield numero*2
        numero+=1

ObjetoGenerador=ParesGeneradores(int)
for i in ObjetoGenerador:
    print(i)

print(next(ObjetoGenerador))"""