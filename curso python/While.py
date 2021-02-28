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

