using System;

namespace T1_AMO_1057021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa!");
            Console.WriteLine("Ingrese su nombre: ");
                string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: "); 
                string edad = Console.ReadLine();
            Console.WriteLine("Ingrese su carrera: ");
                string carrera = Console.ReadLine();
            Console.WriteLine("Ingrese su carne: ");
            string carne = Console.ReadLine();

            Console.Write(" Soy " + nombre);
            Console.Write(" tengo " + edad);
            Console.Write(" años y estudio la carrera de " + carrera);
            Console.Write(". Mi número de carné es " + carne);
            Console.ReadKey();
        }
    }
}
