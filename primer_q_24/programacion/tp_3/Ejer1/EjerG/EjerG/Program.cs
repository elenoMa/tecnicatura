namespace EjerG;
/*
  dados tres números a, b, y c,
        si la diferencia entre a y b es mayor que c,  ->   calcular el producto de a y b;
        de lo contrario, -->     calcular el cociente entre a y b.
 */

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(
                $"El resultado de la operacion es: {_calculateProductOrQuotient(_getNumber(), _getNumber(), _getNumber())}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private static Func<double> _getNumber = () =>
    {
        double number;

        Console.Write("Ingrese numero: ");

        if (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Numero invalido, intente nuevamente...");
            return _getNumber();
        }

        return number;
    };

    private static Func<double, double, double, double> _calculateProductOrQuotient = (numA, numB, numC) =>
    {
        if (numA - numB > numC)
        {
            Console.WriteLine("La diferencia entre el número A y el número B es mayor que el número C");
            Console.WriteLine("OPERACION -> MULTIPLICACION DE A y B");
            return _calculateProduct(numA, numB);
        }

        Console.WriteLine("La diferencia entre el número A y el número B es menor que el número C");
        Console.WriteLine("OPERACION -> DIVISION DE A y B");
        return _calculateQuotient(numA, numB);
    };

    private static Func<double, double, double> _calculateProduct = (numA, numB) => numA * numB;

    private static Func<double, double, double> _calculateQuotient = (numA, numB) =>
    {
        if (numB == 0)
        {
            throw new ArgumentException("No se puede dividir por 0.", nameof(numB));
        }

        return numA / numB;
    };
}