using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Fibo
{
    static class Program
    {
        static void Main(string[] args) 
        {
           Fibonacci(); 
        }

        static void Fibonacci()
        {
            int a;
            int b;
            int c;
            int con = 2;
            int lim = 0;
            Console.WriteLine("ingrese un número");
            try
            {
                lim = int.Parse(Console.ReadLine());
            }
            catch (Exception x)
            {
                Console.WriteLine("Hay  un erro en el ´programa");
            }
            a = 0;

            b = 0;
            b = 1;
            
            if (lim == 0)
            {
                Console.WriteLine(a);
                return;
            }
            else if (lim == 1)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                return;
            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                do
                {
                    c = a + b;

                    a = b;
                    b = c;
                    con = con + 1;
                    Console.WriteLine(c);
                } while (con <= lim);
            }
            
        }
    }
}