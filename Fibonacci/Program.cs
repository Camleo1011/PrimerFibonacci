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
            Console.WriteLine("presione una tecla para salir");
            Console.ReadLine();
        }

        static void Fibonacci()
        {
            long a;
            long b;
            long c;
            long con = 2;
            long lim;
            bool limValido;

            do
            {
                Console.WriteLine("ingrese un número");
                limValido = long.TryParse(Console.ReadLine(), out lim);
                continue;
                
            
            }while(limValido == false || lim < 0);

            a = 0;
            b = 1;
            
            if (lim == 0)
            {
                Console.WriteLine($"estamos en la posicion: {con-2} y el  numero es: {a}");
                return;
            }
            else if (lim == 1)
            {
                Console.WriteLine($"estamos en la posicion: {con-2} y el  numero es: {a}");
                Console.WriteLine($"estamos en la posicion: {con-1} y el  numero es: {b}");

                return;
            }
            else
            {
                Console.WriteLine($"estamos en la posicion: {con-2} y el  numero es: {a}");
                Console.WriteLine($"estamos en la posicion: {con-1} y el  numero es: {b}");
                do
                {
                    c = a + b;

                    a = b;
                    b = c;
                    Console.WriteLine($"estamos en la posicion: {con} y el  numero es: {c}");
                    con = con + 1;
                    
                } while (con <= lim);
            }
           
        }
    }
}