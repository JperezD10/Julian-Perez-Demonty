import re, pickle

archivo= open("archivo.txt","w")
archivo.write("Se escribe un texto")
archivo.close()
del(archivo)

f= open("archivo.txt","r")
texto= f.read()
f.close()
if re.match("texto", texto):
    print("tiene la palabra texto")
else:
    print("no hay nada")

prueba=["buenos aires", "adroggue", "peru"]

try:
    binario=open("binario","wb")
    pickle.dump(prueba, binario)
    binario.close()
    del(binario)

    f= open("binario","rb")
    texto= f.read()
    f.close()
    print(texto)

except Exception as e:
    print(e)