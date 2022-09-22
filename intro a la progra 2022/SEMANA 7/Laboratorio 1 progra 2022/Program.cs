using System;

namespace Laboratorio_AMO_1057021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Hola mundo!");
            Console.WriteLine("Soy Adriana Morales");

            /*Al comparar console.writeline con console.write podemos notar que al ejecutarlos console.writeline coloca las oraciones de manera separada y ordenada, mientras que console.write no deja espacio y se ve de manera mas desordenada*/

            Console.Write("Hola mundo");
            Console.Write("Soy Adriana Morales");
            Console.ReadKey();
        }
    }
}
