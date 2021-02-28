#Escribir un programa que pida al usuario un número entero positivo y muestre por pantalla todos los números impares desde 1 hasta ese número separados por comas.
def generarPares(limite):
    numero=1
    lista=[]
    for i in range (0, limite):
        lista.append(numero)
        numero+=2
    return lista

impares= int(input("Numero maximo de impares: "))
print(generarPares(impares))