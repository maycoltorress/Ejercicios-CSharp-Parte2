using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizTranspuesta
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random(); 
            
            Console.Write("Ingrese numeros de filas: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese numeros de columnas: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int[,] m1 = new int[a, b];
            int[,] m2 = new int[b, a];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {

                    m1[i, j] = random.Next(0, 10); //Generar numero aleatorio entre 0-100
                    Console.Write(m1[i, j] + " ");
                }
                Console.WriteLine(" ");


            }

            Console.WriteLine("\nSu transpuesta sería: \n ");
            for (int j = 0; j < b; j++)
            {
                for (int i = 0; i < a; i++)
                {           
                    Console.Write(m1[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
