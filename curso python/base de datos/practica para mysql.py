import pymysql
import getpass
import hashlib
from os import system

conexion = pymysql.connect(
    host='localhost',
    user='root',
    password='',
    database='pythonmysql')

cursor= conexion.cursor()
class Usuario:
    def __init__(self, NombreU, Contraseña):
        self.User= NombreU
        cifrado= hashlib.sha256()
        cifrado.update(Contraseña.encode("utf8"))
        self.contra= cifrado.hexdigest()

    def Registrar(self):
        sql=f"INSERT INTO usuario VALUES (null,'{self.User}','{self.contra}')"
        cursor.execute(sql)
        conexion.commit()
        print("operacion finalizada")

    def Loguear(self):
        sql=f"SELECT * FROM usuario WHERE NombreUsuario='{self.User}' and Contraseña='{self.contra}'"
        try:
            cursor.execute(sql)
            result= cursor.fetchone()
            if self.User== result[1]:
                print("Bienveni3")
        except TypeError :
            print("Usuario o contraseña incorrecta")
        


def opciones(opcion):
    if opcion=="login":
        nombusu=input("Seleccione nombre de usuario: ")
        contra=input("Ingrese la contraseña: ")
        system("cls")
        user= Usuario(nombusu,contra)
        user.Loguear()
           
    elif opcion=="registro":
        username= input("Ingrese nuevo nombre de usuario: ")
        contraseña= input("Ingrese la contraseña: ")
        system("cls")
        try:
            nuevoUsuario=Usuario(username,contraseña)
            nuevoUsuario.Registrar()
        except Exception:
            raise
    else:
        print("Error de seleccion")

while True:
    opcion = input("Login o Registro: ")
    opciones(opcion)