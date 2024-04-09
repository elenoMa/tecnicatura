using System;

namespace EjerH
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = GetInteger("Ingrese el numero de números a sumar: ")();

            Console.Write("La sumatoria de los " + numberOfNumbers + " números es: " + AddFirstNumbers(numberOfNumbers)());
        }

        static Func<int> AddFirstNumbers(int limit)
        {
            if (limit == 0)
            {
                return () => 0;
            }
            else
            {
                return () => limit + AddFirstNumbers(limit - 1)();
            }
        }

        static Func<int> GetInteger(string message)
        {
            int value;
            bool isValid;
            
            do
            {
                Console.Write(message);
                isValid = int.TryParse(Console.ReadLine(), out value);

                if (!isValid)
                {
                    Console.WriteLine("Entrada invalida, intente nuevamente... ");
                }
                
            } while (!isValid);

            return () => value;
        }
    }
}