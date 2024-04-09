namespace EjerE;

// Dada una distancia Dm expresada en metros, convertir en su equivalente en pies.
// Se conoce que 1 metro equivale a 39.37 pulgadas y que 12 pulgadas equivalen a 1 pie.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la distancia expresada en metros: ");
        double distanceInMeters = _getFloat();
        Console.WriteLine("La distancia " + distanceInMeters + "m. expresada en pies es :" + _metersToFeet(distanceInMeters) + " pies.");
    }

    private static Func<double> _getFloat = () =>
    {
        double number;

        if (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Entrada invalida, intente nuevamente: ");
            return _getFloat();
        }

        return number;
    };

    private static Func<double, double> _metersToFeet = (meters) => (meters * 39.37) / 12;
}