class Persona:
    def __init__(self,nombre,apellido,edad):
        self.nombre=nombre
        self.apellido=apellido
        self.edad=edad
    
    def Descripcion(self):
        print("Se llama ",self.nombre,self.apellido,"y tiene ",self.edad," años.")
    
    def hablar():
        print("hola jorge")

class Empleado(Persona):
    def __init__(self,nombre,apellido,edad,puesto,sueldo):
        super().__init__(nombre,apellido,edad)
        self.puesto=puesto
        self.sueldo=sueldo

    def hablar():

    def Descripcion(self):
        super().Descripcion()
        print("Tambien es un empleado que cobra",self.sueldo,"y trabaja como",self.puesto)

class Cliente(Persona):
    def __init__(self,nombre,apellido,edad,numeroTarjeta,Importe):
        super().__init__(nombre,apellido,edad)
        self.numeroTarjeta=numeroTarjeta
        self.Importe=Importe

    def Descripcion(self):
        super().Descripcion()
        print("Tambien es un cliente que debe pagar",self.Importe,"y usara la tarjeta:",self.numeroTarjeta)

juli=Empleado("julian","Perez Demonty",20,"programador",35000)
juli.Descripcion()
juli.hablar()
martina=Cliente("Martina","Donadio",21,8983498239,1200)
martina.Descripcion()
