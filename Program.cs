using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenacionDeTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            do
            {
                Console.Write("Ingrese primer número (A): ");
                a = Convert.ToInt16(Console.ReadLine());
                Console.Write("Ingrese segundo número (B): ");
                b = Convert.ToInt16(Console.ReadLine());
                Console.Write("Ingrese tercer número (C): ");
                c = Convert.ToInt16(Console.ReadLine());

                if (a > b && a > c)
                {
                    Console.WriteLine("El mayor es A: {0}", a);
                    if (b > c)
                    {
                        Console.WriteLine("El del medio es B: {0}", b);
                        Console.WriteLine("El menor es C: {0}", c);
                    }
                    else
                    {
                        Console.WriteLine("El del medio es C: {0}", c);
                        Console.WriteLine("El menor es B: {0}", b);
                    }
                }
                else
                {
                    if (b > a && b > c)
                    {
                        Console.WriteLine("El mayor es B: {0}", b);
                        if (a > c)
                        {
                            Console.WriteLine("El del medio es A: {0}", a);
                            Console.WriteLine("El menor es C: {0}", c);
                        }
                        else
                        {
                            Console.WriteLine("El del medio es C: {0}", c);
                            Console.WriteLine("El menor es A: {0}", a);
                        }
                    }
                    else
                    {
                        Console.WriteLine("El mayor es C: {0}", c);
                        if (a > b)
                        {
                            Console.WriteLine("El del medio es A: {0}", a);
                            Console.WriteLine("El menor es B: {0}", b);
                        }
                        else
                        {
                            Console.WriteLine("El del medio es B: {0}", b);
                            Console.WriteLine("El menor es A: {0}", a);
                        }
                    }
                }
            } while (true);           
            Console.ReadKey();
        }
    }
}
