import re

Lista_Nombres=["juan","mario","Martina", "julian","valeria"]
# ^algo encuentra lo que empieza asi.
# algo$ encuentra lo que termina asi.
# [a-g] encuentra lo que tenga en su interior valores entre a y g.
# si dentro de un rango pongo exponente, niego el rango= [^1-4]
for elemento in Lista_Nombres:
    if re.findall("^[Mm,v]",elemento):  
        print(elemento)
