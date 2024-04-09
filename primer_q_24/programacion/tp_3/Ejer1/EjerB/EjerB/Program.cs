namespace EjerB;

// Dados dos números a y b, calcular la suma de ambos.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("La suma de los numeros ingresados es: " + (_getInt() + _getInt()));
    }

    private static Func<int> _getInt = () =>
    {
        int number;
        
        Console.Write("Ingrese un numero: ");

        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("El numero ingresado es invalido, intente nuevamente... ");
            return _getInt();
        }

        return number;
    };
}