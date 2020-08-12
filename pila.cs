namespace pila

{
    class principal
    {
        public void _init_ ()
        {
        self.lista = [];
        }

        public void apilar (self,item):
        {
        self.lista.append(item);
        console.Writeline('areglo actalizado ', self.lista);
        }

        public void desapilar (self):
        {
        if True:
            console.Writeline('dato descompliado ');
        try:
            return self.lista.pop();
        except IndexError:
            console.Writeline('pila esta vacia ')
        }
        public void tamano (self):
        {
        return len(self.lista);
        }
        public void vacia (self):
        {
        if self.lista==[]:
            console.Writeline('la pila esta vaccia');
        else:
            console.Writeline('la pila contiene no o mas elemtos ');
        }
        public limpiar (self):
        {
        self.lista = [];
        }
    }
}