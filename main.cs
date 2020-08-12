using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pila_Consola_Generica
{
    class Program
    {
        static Stack<int> Pila = new Stack<int>();

        static void Main(string[] args)
        {
            UInt16 opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("PILA USANDO COLECCIONES GENÉRICAS\n");
                Console.WriteLine("1.- Insertar dato (Push)");
                Console.WriteLine("2.- Eliminar dato (Pop)");
                Console.WriteLine("3.- Mostrar datos de la pila");
                Console.WriteLine("4.- Eliminar todos los datos de la pila (Vaciar)");
                Console.WriteLine("0.- Salir");
                Console.Write("\nOpción ? ");

                opcion = UInt16.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: InsertarEnPila(); break;
                    case 2: EliminarEnPila(); break;
                    case 3: MostrarDatos(); break;
                    case 4: VaciarPila(); break;
                }

            } while (opcion != 0);
        }

        public static void InsertarEnPila()
        {
            int Dato=0;

            Console.Clear();
            Console.WriteLine("INSERTAR DATO EN LA PILA GENÉRICA");
            Console.Write("\n\nNúmero entero ? ");
            Dato = int.Parse(Console.ReadLine()); // Captura el dato que se desea insertar

            // Invoca el método Push del objeto Pila de la clase genérica Stack
            Pila.Push(Dato); // Inserta el Dato en la Pila
        }

        public static void EliminarEnPila()
        {
            Console.Clear();
            Console.WriteLine("ELIMINAR EL ÚLTIMO DATO ALMACENADO EN LA PILA GENÉRICA");

            // Intenta ejecutar el método Pop
            try
            {
                // Invoca el método Pop del objeto Pila de la clase genérica Stack
                int Dato=Pila.Pop(); // Elimina el dato de la pila y lo recibe la variabla Dato
                Console.WriteLine("\n\nDato eliminado: " + Dato.ToString());
            }
            catch(InvalidOperationException e) // Si ocurre una excepción ...
            {
                // Despliega el mensaje de error
                Console.WriteLine("\n\nNo se realizó la eliminación... "+e.Message);
            }
            Console.ReadKey();
        }

        public static void MostrarDatos()
        {
            Console.Clear();
            Console.WriteLine("DATOS ALMACENADOS EN LA PILA GENÉRICA\n");

            // Intenta recorrer la Pila
            try
            {
                // Recorre cada Dato de la Pila
                foreach (int Dato in Pila)
                    Console.WriteLine(Dato);

                // Muestra la cantidad de elementos usando el método Count()
                Console.WriteLine("\nTop = " + Pila.Count());
            }
            catch (InvalidOperationException e)  // Si ocurre una excepción ...
            {
                // Despliega el mensaje correspondiente
                Console.WriteLine("\n\nPila vacía... " + e.Message);
            }
            Console.ReadKey();
        }

        public static void VaciarPila()
        {
            char sn;
            Console.Clear();
            Console.WriteLine("ELIMINAR TODOS LOS ELEMENTOS DE LA PILA (VACIAR)\n");

            // Solicita al usuario que confirme la operación
            do
            {
                Console.Write("¿Está seguro que desea vaciar la pila [S/N] ?");
                sn = char.Parse(Console.ReadLine());
                sn = Char.ToUpper(sn);  // Convierte a mayúsculas el caracter capturado
            } while (sn != 'S' && sn != 'N');

            if (sn == 'S')  // Si se confirma la operación ...
            {
                Pila.Clear();  // Invoca el método para limpiar la pila
                Console.WriteLine("\n\nSe eliminaron todos los elementos de la pila !!!");
                Console.ReadKey();
            }
        }

    }
}