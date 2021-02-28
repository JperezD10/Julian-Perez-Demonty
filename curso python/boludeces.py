class Auto:
    def __init__(self, marca, modelo, color, Precio):
        self.modelo= modelo
        self.marca=marca
        self.color= color
        self.__Precio=Precio
    def GetColor(self):
        return self.color
    def GetPrecio(self):
        return self.__Precio

marca= input("Ingrese marca: ")
modelo=input("Ingrese modelo: ")
color = input("Ingrese color: ")
cochovich= Auto(marca, modelo, color,150000)
print("El auto es un ",cochovich.marca, cochovich.modelo," de color ",cochovich.GetColor())
print("El valor del auto es",cochovich.GetPrecio())