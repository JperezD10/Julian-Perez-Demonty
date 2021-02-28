import pymysql
#para hacer un insert es con cursos.execute pero el commit va la propiedad "conexion".commit()
class DATABASE:
    def __init__(self):
        self.conexion=pymysql.Connection(
            host='localhost',
            user='root',
            password='',
            db='PruebaPython'
        )
        self.cursor=self.conexion.cursor()
        print("Conexion Establecida")
    
    def Selec_User(self,id):
        sql="SELECT * FROM Usuarios WHERE Id="+str(id)
        try:
            self.cursor.execute(sql)
            user=self.cursor.fetchone()
            print("ID:", user[0])
            print("Nombre Usuario:", user[1])
        
        except Exception as e:
            raise e
    
    def Selec_ALL_Users(self):
        sql="SELECT * FROM Usuarios"
        try:
            self.cursor.execute(sql)
            users=self.cursor.fetchall()
            for user in users:
                print("ID:",user[0])
                print("Nombre de Usuario:",user[1].upper())
                print("Contraseña:",user[2])
                print("-------\n")
        except Exception as e:
            raise
    
    def update_Usuarios(self,id,Nombre):
        sql="UPDATE Usuarios SET NombreUsuario='"+Nombre +"' WHERE Id="+str(id)
        try:
            self.cursor.execute(sql)
            self.conexion.commit()
            print("Se actualizaron los campos\n")
        except Exception as e:
            raise
    
    def Close(self):
        self.conexion.close()


database= DATABASE()
#database.Selec_User(1)
database.Selec_ALL_Users()
database.update_Usuarios(2,"Matu")
database.Selec_ALL_Users()
database.Close()

