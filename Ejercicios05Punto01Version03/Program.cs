using System;

namespace Ejercicios05Punto01Version03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejemplo con ciclo repetitivo For";
            var suma = 0;
            for (int contador = 0; contador < 4; contador++)
            {
                Console.Write($"Ingrese el número {contador+1}:");
                var nro = int.Parse(Console.ReadLine());
                suma += nro;
            }
            Console.Write($"La suma es {suma}");
        }
    }
}
