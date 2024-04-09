namespace EjerC;
// Dado un valor x, calcular el 30% de x.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("El 30% de el número ingresado es: "+ (_getInt() * 0.3));
    }

    private static Func<int> _getInt = () =>
    {
        int number;
        
        Console.Write("Ingrese un número: ");
        
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Número invalido, intente nuevamente...");
            return _getInt();
        }
        return number;
    };
}