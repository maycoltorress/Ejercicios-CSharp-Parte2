using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0, puntos = 0;
            String n;
            do
            {
                Console.WriteLine("1- Jugar");
                Console.WriteLine("2- Salir");
                Console.Write("Opcion >> ");
                opcion = Convert.ToInt32(Console.ReadLine());
                puntos = 0;
                switch (opcion)
                {
                    case 1:
                        //Pregunta 1
                        Console.Clear();
                        Console.WriteLine("Pregunta 1");
                        Console.WriteLine("Puntos: {0,2}",puntos);
                        Console.WriteLine("a) 1\nb) 2\nc) 3\nd) 4\ne) SALIR");
                        Console.Write("\n¿Cuanto es 1 +1? Escriba Alternativa -> ");
                        n = Convert.ToString(Console.ReadLine());

                        if (n.Equals("b") || n.Equals("B"))
                        {
                            Console.WriteLine("CORRECTO!! (^0^)/");
                            puntos += 100;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            if(n.Equals("e"))
                            {
                                Console.Clear();
                                Console.WriteLine("Su puntuacion Final es: {0,2}",puntos);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            Console.WriteLine("INCORRECTO :(");
                            puntos -= 50;
                            if (puntos < 0)
                                puntos = 0;
                            Console.ReadKey();
                            Console.Clear();
                        }

                        //Pregunta 2

                        Console.Clear();
                        Console.WriteLine("Pregunta 2");
                        Console.WriteLine("Puntos: {0,2}", puntos);
                        Console.WriteLine("a) 1\nb) 2\nc) 3\nd) 4\ne) SALIR");
                        Console.Write("¿Cuanto es 2 +1? Escriba Alternativa -> ");
                        n = Convert.ToString(Console.ReadLine());
 
                        if (n.Equals("c") || n.Equals("C"))
                        {
                            Console.WriteLine("CORRECTO!! (^0^)/");
                            puntos += 100;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            if (n.Equals("e"))
                            {
                                Console.Clear();
                                Console.WriteLine("Su puntuacion Final es: {0,2}", puntos);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            Console.WriteLine("Incorrecto");
                            puntos -= 50;
                            if (puntos < 0)
                                puntos = 0;
                            Console.ReadKey();
                            Console.Clear();
                        }

                        //Pregunta 3

                        Console.Clear();
                        Console.WriteLine("Pregunta 3");
                        Console.WriteLine("Puntos: {0,2}", puntos);
                        Console.WriteLine("a) 1\nb) 2\nc) 3\nd) 4\ne) SALIR");
                        Console.Write("¿Cuanto es 2 x 2 ? Escriba Alternativa -> ");
                        n = Convert.ToString(Console.ReadLine());

                        if (n.Equals("d") || n.Equals("D"))
                        {
                            Console.WriteLine("CORRECTO!! (^0^)/");
                            puntos += 100;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            if (n.Equals("e"))
                            {
                                Console.Clear();
                                Console.WriteLine("Su puntuacion Final es: {0,2}", puntos);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            
                            Console.WriteLine("Incorrecto");
                            puntos -= 50;
                            if (puntos < 0)
                                puntos = 0;
                            Console.ReadKey();
                            Console.Clear();
                        }

                        //Pregunta 4

                        Console.Clear();
                        Console.WriteLine("Pregunta 4");
                        Console.WriteLine("Puntos: {0,2}", puntos);
                        Console.WriteLine("a) 1\nb) 2\nc) 3\nd) 4\ne) SALIR");
                        Console.Write("¿Cuanto es 2 x 1? Escriba Alternativa -> ");
                        n = Convert.ToString(Console.ReadLine());

                        if (n.Equals("b") || n.Equals("B"))
                        {
                            Console.WriteLine("CORRECTO!! (^0^)/");
                            puntos += 100;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            if (n.Equals("e"))
                            {
                                Console.Clear();
                                Console.WriteLine("Su puntuacion Final es: {0,2}", puntos);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                            Console.WriteLine("Incorrecto");
                            puntos -= 50;
                            if (puntos < 0)
                                puntos = 0;
                            Console.ReadKey();
                            Console.Clear();
                        }

                        //Pregunta 5

                        Console.Clear();
                        Console.WriteLine("Pregunta 5");
                        Console.WriteLine("Puntos: {0,2}", puntos);
                        Console.WriteLine("a) 1\nb) 2\nc) 3\nd) 4\ne) SALIR");
                        Console.Write("¿Cuanto es 3 x 1 ? Escriba Alternativa -> ");
                        n = Convert.ToString(Console.ReadLine());

                        if (n.Equals("c") || n.Equals("C"))
                        {
                            Console.WriteLine("CORRECTO!! (^0^)/");
                            puntos += 100;
                            Console.WriteLine("Su puntuacion Final es: {0,2}", puntos);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            if (n.Equals("e"))
                            {
                                Console.Clear();
                                Console.WriteLine("Su puntuacion Final es: {0,2}", puntos);
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }

                            Console.WriteLine("Incorrecto");
                            puntos -= 50;
                            if (puntos < 0)
                                puntos = 0;
                            Console.WriteLine("Su puntuacion Final es: {0,2}", puntos);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        
                        
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Adios...");
                        Console.ReadKey();
                        break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese Opción Válida!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != 2);
        }
    }
}
