# Escribir un programa que pida al usuario un número entero positivo y muestre por pantalla la cuenta atrás desde ese número hasta cero separados por comas.
arranque = int(input("Numero de arranque: "))
for i in range(0, arranque):
    print(arranque, end=", ")
    arranque-=1