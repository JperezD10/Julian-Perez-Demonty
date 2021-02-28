class Auto():
    def __init__(self,cantRuedas,eMotor,Est):
        self.Ruedas= cantRuedas
        self.motor=eMotor
        self.estado=Est

auto1=Auto(4,"buenardo","Nuevo")
auto2=Auto(6,"meh","usado")
print("el auto 1 tiene: ",auto1.Ruedas," ruedas, el motor esta: ", auto1.motor," y el estado del auto es: ",auto1.estado)
print("el auto 2 tiene: ",auto2.Ruedas," ruedas, el motor esta: ", auto2.motor," y el estado del auto es: ",auto2.estado)