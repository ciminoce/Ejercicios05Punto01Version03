using System;

namespace Ejercicios05Punto01Version03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejemplo con ciclo repetitivo For";
            var suma = 0;
            int nro;
            bool NoValido;
            for (int contador = 0; contador < 4; contador++)
            {
                NoValido = true;
                do
                {
                    Console.Write($"Ingrese el número {contador + 1}:");
                    if (int.TryParse(Console.ReadLine(),out nro))
                    {
                        NoValido = false;
                    }
                    else
                    {
                        Console.WriteLine("Trate otra vez ingresando un nro entero");
                    }
                    
                } while (NoValido);                
                suma += nro;
            }
            Console.Write($"La suma es {suma}");
        }
    }
}
