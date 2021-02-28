import re
import pickle

class Chofer():
    def __init__(self,nombre,apellido,edad):
        self.nombre=nombre
        self.apellido=apellido
        self.edad=edad

class Camion():
    kilometrosTotales=None
    def __init__(self,patente, litros, ciudadActual, kmlitro, velMax, recorridos, nombreChofer,apellidoChofer,edadChofer):
        self.Patente=patente
        self.Litros_Disponibles=litros
        self.Ciudad_Actual=ciudadActual
        self.km_Litro= kmlitro
        self.Vel_maxima=velMax
        self.Recorridos= recorridos
        self.chofer= Chofer(nombreChofer,apellidoChofer,edadChofer)
    
    def EstimarKM(self):
        kmTotales=0
        self.Recorridos.append([self.Ciudad_Actual,0])
        for km in self.Recorridos:
            for x in km:
                if type(x)==int:
                    kmTotales+=x
        self.kilometrosTotales= kmTotales
    def EstimarTiempo(self):
        tiempoParada=len(self.Recorridos)
        return (self.kilometrosTotales/self.Vel_maxima)+tiempoParada
    
    def VerificarCombustiblle(self):
        kmPosibles = self.km_Litro*self.Litros_Disponibles
        if float(self.kilometrosTotales)> kmPosibles:
            return "No te da la nafta"
        else:
            return "Viaja tranquilo, te alcanza para el viaje"

    def Estimar(self, camiones):
        oEstimacion= Estimacion(self.Patente,self.kilometrosTotales,self.EstimarTiempo(),self.VerificarCombustiblle())
        lstEstimacion= list()
        lstEstimacion.append(oEstimacion)
        fichero= open("Estimaciones","wb")
        pickle.dump(camiones,fichero)
        fichero.close()
        del (fichero)
    
    def estado(self):
        self.EstimarKM()
        if self.kilometrosTotales>1000:
            print(f"Patente: {self.Patente} con viaje mayor a 1000 km, {self.kilometrosTotales}")

class Estimacion():
    def __init__(self, Patente, KM, tiempo, combustible):
        self.Patente= Patente
        self.Kilometros=KM
        self.Tiempo=tiempo
        self.Combustible=combustible


def SetRecorrido(viajes):
    print("RECORRIDO")
    cantidad=1
    Kilometros=[]
    km=[]
    recorridos=[]
    viaje=[]
    
    if viajes is not None:
        print("Soy un viaje ya creado")
        for i in viajes:
            viaje.append(i)
    opcion = int(input("\n Seleccione la opcion (1_Agregar uno u otro recorrido, 2_Ver recorridos actuales, 0_ Terminar Recorridos): "))

    while opcion!=0:
        if opcion==1:
            ciudadTexto=input("Indique las ciudades del recorrido separadas por comas (,): ")
            if re.search(",", ciudadTexto) is None:
                print("Te dije que separes por comas...")
            else:
                ciudades= ciudadTexto.split(",")
                recorridos=ciudades
                kilometrosTexto= input("Indique las distancias de las ciudades del recorrido separadas por comas (,) respectivamente: ")
                if re.search(",", kilometrosTexto) is None:
                    print("Te dije que separes por comas...")
                else:
                    distancias= kilometrosTexto.split(",")
                    km= [int(x) for x in distancias]
                    Kilometros=km
                    print(f"Bien! Se creo el recorrido Nº {cantidad}") 
                    for i in range (len(recorridos)):
                        viaje.append([recorridos[i],Kilometros[i]])
                    cantidad+=1
            opcion = int(input("\n Seleccione la opcion (1_Agregar uno u otro recorrido, 2_Ver recorridos actuales, 0_ Terminar Recorridos): "))
            
        elif opcion==2:
            print(f"Hay {len(viaje)} viajes")
            if len(viaje):
                rec= int(input("Indique cual recorrido quiere ver (debe ser un numero): "))
                for i in viaje[rec-1]:
                    print(i)
            else:
                print("No tiene recorridos. Ingrese uno si desea")
            opcion = int(input("\n Seleccione la opcion (1_Agregar uno u otro recorrido, 2_Ver recorridos actuales, 0_ Terminar Recorridos): "))
        
        else:
            print("Opcion incorrecta")
            opcion = int(input("\n Seleccione la opcion (1_Agregar uno u otro recorrido, 2_Ver recorridos actuales, 0_ Terminar Recorridos): "))
    print("Terminamos los recorridos")
    return viaje

Camiones={}

def Menu():
    print("Bienvenido: \n Seleccione una de las 5 opciones: \n 1_Crear Camiones \n 2_Elegir Camion \n 3_Ver estimaciones segun camion \n 4_Estiamciones por patente\n 0_Salir")
    
    opcion = int(input("\n Seleccione la opcion: "))
    while opcion!=0:
        if opcion==1:
            try:
                patente= input("Ingrese patente: ")
                litros= float(input("Ingrese los litros del vehiculo: "))
                ciuddadActual= input("Ingrese Ciudad Actual: ")
                kmlitro= int(input("Ingrese km por Litro: "))
                velMax= int(input("Ingrese Velocidad Maxima del Camion: "))
                recorridos= SetRecorrido(None)
                nombreChofer=input("Nommbre del chofer: ")
                apellidoChofer=input("Apellido: ")
                edadChofer=int(input("Edad: "))
                camion=Camion(patente,litros,ciuddadActual,kmlitro,velMax,recorridos, nombreChofer,apellidoChofer,edadChofer)
                Camiones[camion.Patente]=camion
                
                print("Camion creado correctamente")
                print("\n Seleccione una de las 5 opciones: \n 1_Crear Camiones \n 2_Elegir Camion \n 3_Ver estimaciones segun camion \n 4_Estiamciones por patente\n 0_Salir")

                opcion = int(input("\n Seleccione la opcion: "))
            
            except:
                print("Algo salio mal. Intente nuevamente con los datos correctos")

        elif opcion==2:
            if len(Camiones)==0:
                print("No hay camiones. Agregue algunos si desea")
            else:
                patente= input("Escriba la patente del camion que desea: ")
                try:
                    unCamion=Camiones[patente]
                    print("Se Encontro el camion")
                    SetRecorrido(unCamion.Recorridos)
                except Exception as e:
                    print(e)
            print("\n Seleccione una de las 5 opciones: \n 1_Crear Camiones \n 2_Elegir Camion \n 3_Ver estimaciones segun camion \n 4_Estiamciones por patente\n 0_Salir")
            opcion = int(input("\n Seleccione la opcion: "))
        
        elif opcion==3:
            if len(Camiones)==0:
                print("No hay camiones. Agregue algunos si desea")
            else:
                patente= input("Escriba la patente del camion que desea: ")
                try:
                    unCamion=Camiones[patente]
                    print("Se Encontro el camion")
                    unCamion.EstimarKM()
                    print(f"Kilometros estimados: {unCamion.kilometrosTotales}")
                    print(f"Tiempo estimado: {unCamion.EstimarTiempo()} horas")
                    print(f"Combustible: {unCamion.VerificarCombustiblle()} ")
                    unCamion.Estimar(unCamion)
                except Exception as e:
                    print(e)
            print("\n Seleccione una de las 5 opciones: \n 1_Crear Camiones \n 2_Elegir Camion \n 3_Ver estimaciones segun camion \n 4_Estiamciones por patente\n 0_Salir")
            opcion = int(input("\n Seleccione la opcion: "))

        elif opcion==4:
            patente= input("Escriba la patente del camion que desea: ")
            ficheroApertura = open("Estimaciones", "rb")
            misCamiones= pickle.load(ficheroApertura)
            ficheroApertura.close() # El archivo se debe cerrar siempre al final.
            for c in misCamiones:
                c.estados()
            print("\n Seleccione una de las 5 opciones: \n 1_Crear Camiones \n 2_Elegir Camion \n 3_Ver estimaciones segun camion \n 4_Estiamciones por patente\n 0_Salir")
            opcion = int(input("\n Seleccione la opcion: "))
        else:
            print("Opcion incorrecta")
            print("\n Seleccione una de las 5 opciones: \n 1_Crear Camiones \n 2_Elegir Camion \n 3_Ver estimaciones segun camion \n 4_Estiamciones por patente\n 0_Salir")
            opcion = int(input("\n Seleccione la opcion: "))


    print("Terminamos")
        


Menu()