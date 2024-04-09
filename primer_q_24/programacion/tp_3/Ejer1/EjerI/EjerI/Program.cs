namespace EjerI;
/*
 * dado un entero que representa un año,
 *indique si corresponde a un año bisiesto o no
 * (un año es bisiesto si es múltiplo de 4 y no de 100; o es múltiplo  de 400)
 */
class Program
{
    static void Main(string[] args)
    {
        PrintLeapYear();
    }

    private static Func<int> _readYear = () =>
    {
        int year;
        Console.Write("Ingrese el año: ");

        if (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Año invalido, intente nuevamente...");
            return _readYear();
        }

        return year;
    };

    private static Func<int, bool> _isALeapYear = (year) => year != 0 && ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);

    private static void PrintLeapYear()
    {
        Console.WriteLine($"El año es {(_isALeapYear(_readYear()) ? "BISIESTO" : "NO BISIESTO")}");
    }
    
}