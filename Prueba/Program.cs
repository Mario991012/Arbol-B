using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Estructuras_de_Datos.ArbolB<int> Arbol = new Estructuras_de_Datos.ArbolB<int>();
            
            bool salir = false;
            while(salir == false)
            {
                Console.WriteLine("Ingrese un numero");
                int num = int.Parse(Console.ReadLine());
                Arbol.Insertar(Arbol.Raiz, num);
            }
            Console.ReadKey();
            
        }
    }
}
