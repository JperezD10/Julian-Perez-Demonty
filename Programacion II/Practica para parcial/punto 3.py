nota = int(input("ingrese la nota: "))

if nota<4:
    print("Aplazado")
elif nota <7 and nota >=3:
    print("Desaprobado")
elif nota >= 7 and nota <=10:
    print("Aprobado")
else:
    print("Nota invalida")



# bucles

maximo= int(input("Ingrese maximo de lineas: "))
puntos="*"
for i in range(0, maximo):
    print(puntos)
    puntos+="*"

# while

num=0
gusto=False
while gusto!=True:
    respuesta=input(f"Te gusta el numero {num}? ")
    if respuesta.lower()=="si":
        print(f"Genial te quedaste con el numero {num}")
        gusto=True
    elif respuesta.lower()=="no":
        print("Ok, Vamos de vuelta")
        num=num+1
    else:
        print("respuesta invalida")

print("Terminamoh")