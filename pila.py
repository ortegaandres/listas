#apilar -> psh
#desapilar ->pop 

#TDS -> Top of stack ->cima, tope

#crear ->constrctor -> _init_(self)
#cima -> conocer el elemento qe se encentra en TDS,concide con el ltimo elemnto agragado
#tama

class pila:
    def __init__(self):
        self.lista = []

    def apilar (self,item):
        self.lista.append(item)
        print('areglo actalizado ', self.lista)

    def desapilar (self):
        if True:
            print('dato descompliado ')
        try:
            return self.lista.pop()
        except IndexError:
            print('pila esta vacia ')

    def tamano (self):
        return len(self.lista)

    def vacia (self):
        if self.lista==[]:
            print ('la pila esta vaccia')
        else:
            print('la pila contiene no o mas elemtos ')
    def limpiar (self):
        self.lista = []
pila = pila()


#psh
pila.apilar('1')
pila.apilar('3')
pila.apilar('4')
pila.apilar('5')
pila.apilar('6')
pila.apilar('7')
 #pop
pila.desapilar()

 #psh
pila.apilar('7')
 #empy
pila.vacia()
 #size 
print('el tamaño de la pila es ',pila.tamano )
 #limpieza
pila.limpiar()
 #size
