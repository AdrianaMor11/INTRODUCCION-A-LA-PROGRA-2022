using System;

namespace reto03semana11_1057021
{
    class Program
    {

        public string[] niveles; //Declaramos un vector de tipo string para los niveles
         public float[] personas; //Declaramos un vector de tipo float para las personas

        public void Cargar()
        {
            niveles = new string[5];
            personas = new float[5];
            for (int f = 0; f < niveles.Length; f++)
            {
                Console.Write("Ingrese el nivel: " + (f + 1) + ": ");
                niveles[f] = Console.ReadLine();
                Console.Write("Ingrese el número de personas " + (f + 1) + ": ");
                string linea;
                linea = Console.ReadLine();
                personas[f] = float.Parse(linea);
            }
        }

        public void Mayorpersonas()
        {
            float mayor;
            int pos;
            mayor = personas[0];
            pos = 0;
            for (int f = 1; f < niveles.Length; f++)
            {
                if (personas[f] > mayor)
                {
                    mayor = personas[f];
                    pos = f;
                }
            }
            Console.WriteLine("El empleado con sueldo mayor es :" + niveles[pos]);
            Console.WriteLine("Tiene un sueldo de: " + mayor);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("HECHO POR ADRIANA MORALES 1057021, MARCELO RAMAZZINI 1250521, MAURICIO CONEDERA 1253303");
        }
    }
}








