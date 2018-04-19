using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizSimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numeros de filas: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese numeros de columnas: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a ==b ){
                int[,] m1 = new int[a, b];
                int[,] m2 = new int[b, a];
                //Llenar matriz 1
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write("Ingrese numero en posicion {0},{1}: ",i,j);
                        m1[i, j] = Convert.ToInt32(Console.ReadLine());                        
                    }
                }
                //Sacar  matriz transpuesta
               
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        m2[j, i] = m1[i, j];                        
                    }
                }

              
                //Imprimir  matriz transpuesta
                Console.WriteLine("Matriz Transpuesta: ");
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        Console.Write("{0,2}", m2[i, j]);
                    }
                    Console.WriteLine("");
                }
                //Comparar valores de ambas matrices
                int comp = (a * b);
                int suma = 0;

                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        if (m1[i, j] == m2[i, j])
                            suma++;

                    }

                }
                if (suma == comp)
                    Console.WriteLine("La matriz es simétrica");
                else
                    Console.WriteLine("La matriz No es simétrica");

            }
            else
            Console.WriteLine("La matriz debe ser cuadrada");
            Console.ReadKey();

        }
    }
}
