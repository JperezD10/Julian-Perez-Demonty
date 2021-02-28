import sqlite3

conexion= sqlite3.connect("dbPrueba.db")

cursor= conexion.cursor()
#tengo que usar el commit para ejecutar los cambios en los datos
"""cursor.execute("INSERT INTO Persona VALUES (null,'Julian','Perez')")
conexion.commit() 
cursor.execute("INSERT INTO Persona VALUES (null,'Martina','Donadio')")
conexion.commit()"""
#para ejecutar muchos inserts seguidos:
personas=[
    ("Julian", "Perez"),
    ("Martina","Donadio"),
    ("Freya","Perez Donadio"),
]
cursor.executemany("INSERT INTO Persona VALUES(null,?,?)",personas)
conexion.commit()
cursor.execute("SELECT * FROM Persona")
persona= cursor.fetchall()
for p in persona:
    print("Se llama",p[1],p[2])
conexion.close()