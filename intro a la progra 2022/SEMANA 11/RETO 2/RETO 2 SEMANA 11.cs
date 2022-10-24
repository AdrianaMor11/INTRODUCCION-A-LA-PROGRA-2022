using System;

namespace reto02semana11_1057021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HECHO POR ADRIANA MORALES 1057021, MARCELO RAMAZZINI 1250521, MAURICIO CONEDERA 1253303");
            int[] nivelesA = new int[5];
            int[] nivelesN = new int[5];
            int suma = 0;
            int suma2 = 0;
            int suma3 = 0;
            int contador = 1;
            int contador2 = 1;
            int contador3 = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese la cantidad de adultos en el nivel " + contador);
                nivelesA[i] = int.Parse(Console.ReadLine());
                contador++;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese la cantidad de niños en el nivel " + contador2);
                nivelesN[i] = int.Parse(Console.ReadLine());
                contador2++;
            }
            for (int i = 0; i < 5; i++)
            {
                suma += nivelesA[i];
            }
            for (int i = 0; i < 5; i++)
            {
                suma2 += nivelesN[i];
            }
            for (int i = 0; i < 5; i++)
            {
                suma3 = nivelesA[i] + nivelesN[i];
                Console.WriteLine("la suma de las personas en el nivel " + contador3 + " es de:" + suma3);
                contador3++;
            }
            Console.WriteLine("la suma de los adultos en el edificio es: " + suma);
            Console.WriteLine("la suma de los niñso en el edificio es: " + suma2);








        }
    }
}
