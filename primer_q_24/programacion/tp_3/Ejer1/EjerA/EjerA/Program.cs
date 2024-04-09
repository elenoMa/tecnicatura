namespace EjerA;

// validar si un número ingresado es par o impar

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(_isEven(_getInteger())
            ? "El número es PAR"
            : "El número es IMPAR");
    }

    private static Func<int> _getInteger = () =>
    {
        int number;

        Console.Write("Ingrese un número a validar: ");

        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Entrada invalida, intente nuevamente...");
            return _getInteger();
        }

        return number;
    };
    
    static Func<int, bool> _isEven = number => number % 2 == 0;
}
