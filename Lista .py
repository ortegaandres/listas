class node:
    def __init__(self, data = None, next = None):
        self.data = data
        self.next = next

class linked_list: 
    def __init__(self):
        self.cabeza = None
    
    # agregar elementos en el frente de la lista
    def add_frente(self, data):
        self.cabeza = node(data=data, next=self.cabeza)  

    # agregar elementos al final de la lista
    def add_final(self, data):
        if not self.cabeza:
            self.cabeza = node(data=data)
            return
        curr = self.cabeza
        while curr.next:
            curr = curr.next
        curr.next = node(data=data)
    
    # eleminar nodos
    def eliminar(self, key):
        curr = self.cabeza
        prev = None
        while curr and curr.data != key:
            prev = curr
            curr = curr.next
        if prev is None:
            self.cabeza = curr.next
        elif curr:
            prev.next = curr.next
            curr.next = None

    #obtener el ultimo nodo
    def get_ultimo_nodo(self):
        temp = self.cabeza
        while(temp.next is not None):
            temp = temp.next
        return temp.data

    #imprimir la lista de nodos
    def print_list( self ):
        nodo = self.cabeza
        while nodo != None:
            print(nodo.data, end =" => ")
            nodo = nodo.next

s = linked_list() 
s.add_frente(5) 
s.add_final(8) 
s.add_frente(9) 

s.print_list() 