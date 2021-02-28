materias= ["Matematica", "Fisica", "Quimica", "Ingles"]
aprobadas=[]
for i in materias: 
    notas= int(input("Que te sacaste en "+i+"? "))
    if notas>7:
        aprobadas.append(i)

print("Materias aprobadas: ", aprobadas)