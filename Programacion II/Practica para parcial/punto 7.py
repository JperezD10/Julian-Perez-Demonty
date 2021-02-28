class Terrestre():
    def Caminar(self):
        print("Estoy caminando")
    

class Acuatico():
    def Nadar(self):
        print("Estoy nadando")
    

class Aereo():
    def Volar(self):
        print("Estoy Volando")

class Tortuga(Terrestre,Acuatico):
    def moverse(self):
        self.Nadar()
        self.Caminar()