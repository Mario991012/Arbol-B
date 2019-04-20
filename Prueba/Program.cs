using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Estructuras_de_Datos.ArbolB<int> Arbol = new Estructuras_de_Datos.ArbolB<int>();


            string[] lineas = File.ReadAllLines("C: \\Users\\paulaximena\\Desktop\\Estructuras de datos\\Estructuras de Datos\\CSVPrueba.csv");

            foreach(var linea in lineas)
            {
                int num = int.Parse(linea);
                Arbol.Insertar(Arbol.Raiz, num);
            }
            
            bool salir = false;
            while(salir == false)
            {
                Console.WriteLine("Ingrese numero a buscar");
                int buscar = int.Parse(Console.ReadLine());
                int encontrado = Arbol.Busqueda(buscar, Arbol.Raiz);
                Console.WriteLine("Se encontro: {0}", encontrado);
                break;
            }
            Console.ReadKey();
            
        }
    }
}
