from tkinter import Frame
from tkinter import Tk
raiz=Tk()
raiz.title("Primer Ventana")
raiz.resizable(1,0)
#raiz.iconbitmap("foto.ico")
raiz.config(bg="red")
miframe=Frame()
miframe.pack()
miframe.config(bg="blue")
miframe.config(width="700",height="500")





raiz.mainloop()
