using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_OperacionesAritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, ciudad;
            //Mostrando el Nombre de una Persona y una Ciudad
            Console.WriteLine("*** Mostrando el Nombre de una Persona y una Ciudad ***\n");
            Console.WriteLine("Por favor ingrese el Nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Por favor ingrese la Ciudad");
            ciudad = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hola: " + nombre + ", Estas en la Ciudad: " + ciudad);
            Console.ReadKey();
        }
    }
}
