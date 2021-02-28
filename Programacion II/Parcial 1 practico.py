class Personaje():
    vida=100
    Posicion=0
    Velocidad=0
    def Recibir_Ataque(self, daño, atacante):
        self.vida-=daño
        if self.vida<0:
            print("Dejenlo, ya esta muerto")


    def Mover(self, Direccion, Velocidad):
        self.Posicion=Direccion
        self.Velocidad=Velocidad
    
    def GetVida(self):
        if self.vida>=0:
            print(f"El personaje tiene {self.vida} puntos de vida")
        else:
            print("Se murio")

    


class Soldado(Personaje):
    ataque=0
    def Atacar(self, Personaje, ataque):
        self.ataque = ataque
        Personaje.Recibir_Ataque(self.ataque, "Soldado")


class Campesino(Personaje):
    cosecha=0
    def __init__(self):
        print("Se creo un campesino. Recuerde que no puede atacar")
    def Cosechar(self, cosecha):
        self.cosecha+= cosecha
        return self.cosecha


juli= Personaje()
peron = Soldado()
jose= Campesino()

jose.Cosechar(20)
print("Cosecha: ",jose.cosecha)
juli.Mover("Izquierda", 20)
print("Va para la ",juli.Posicion)
peron.Atacar(jose, 30)
print(jose.GetVida())