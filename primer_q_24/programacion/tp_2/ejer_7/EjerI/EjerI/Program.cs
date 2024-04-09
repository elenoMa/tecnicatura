namespace EjerI;

class Program
{
    static void Main(string[] args)
    {
        int numberOfNumbers = GetInteger("Ingrese la cantidad de numeros a evaluar: ")();
        
        Console.Write("La suma de los multiplos de 5 entre 0 y " +numberOfNumbers + " es: " + AddMultiplesOfFive(numberOfNumbers)());
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
                Console.WriteLine("Entrada invalida, entente nuevamente...");
            }

        } while (!isValid);

        return () => value;
    }
    static Func<int> AddMultiplesOfFive(int limit)
    {
        if (limit == 0)
        {
            return () => 0;
        }
        
        return () => limit % 5 == 0 ? limit + AddMultiplesOfFive(limit - 1)() : limit + 0;
    }
}