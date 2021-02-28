class Persona: 
    def __init__(self,nombre,apellido,edad):
        self.nombre=nombre
        self.apellido=apellido
        self.__edad= edad #Encapsulado
    
    def getEdad(self):
        return self.__edad

    def Descripcion(self):
        print("Se llama ",self.nombre,self.apellido,"y tiene ",self.getEdad()," años.")

juli = Persona("julian", "perez", 20)
juli.Descripcion()