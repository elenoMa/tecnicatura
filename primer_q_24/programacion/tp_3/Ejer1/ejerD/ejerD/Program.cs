namespace ejerD;

// Dados dos números num1 y num2, determinar si num1 es mayor o igual a num2.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(_isGreaterOrEqual(_getInt(), _getInt())
            ? "El primer número ingresado es Mayor o igual al Segundo"
            : "El segundo número ingresado es mayor o igual al primero");
    }

    private static Func<int> _getInt = () =>
    {
        int number;
        Console.Write("Ingrese un número: ");

        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("El número ingresado es invalido, intente nuevamente...");
            return _getInt();
        }

        return number;
    };

    private static Func<int, int, bool> _isGreaterOrEqual = (numberOne, numberTwo) => numberOne >= numberTwo;
}