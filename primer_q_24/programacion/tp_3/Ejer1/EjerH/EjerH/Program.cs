namespace EjerH;
/*
 una obra social tiene tres clases de socios.
  Los socios tipo ‘A’ abonan una cuota mayor pero tiene un 50% de descuento en todos los tipos de tratamientos odontológicos. 
  
  Los socios tipo ‘B’ abonan una cuota moderada y tienen un 35% de descuento para los mismos tratamientos que los socios del tipo A.
  
   Los socios que menos aportan, los de tipo ‘C’, no reciben descuentos sobre dichos tratamientos. 
   
   Solicite una letra (carácter) que representa la clase de un socio, y luego un valor real que represente el costo del tratamiento (previo al descuento) 
   y determine el importe en efectivo a pagar por dicho socio.
 */
class Program
{
    static void Main(string[] args)
    {
        PrintCost();
    }

    private static Func<char> _readPartnerType = () =>
    {
        char c;
        
        Console.Write("Ingrese el tipo de socio ('A', 'B', o 'C'): ");

        if (char.TryParse(Console.ReadLine(), out c))
        {
            return c;
        }

        Console.WriteLine("Caracter invalido, intente nuevamente...");
        return _readPartnerType();
    };

    private static Func<double> _readTreatmentCost = () =>
    {
        double cost;

        Console.Write("Ingrese el consto del tratamiento: ");

        if (!double.TryParse(Console.ReadLine(), out cost) && cost > 0)
        {
            Console.Write("El monto seleccionado es invalido, entente nuevamente: ");
            return _readTreatmentCost();
        }

        return cost;
    };

    private static Func<char, double, double> _calculateFinalTreatmentCost = (type, cost) =>
    {
        double total;

        switch (char.ToLower(type))
        {
            case 'a':
                total = _calculateDiscountedCost(0.5, cost);
                break;
            case 'b':
                total = _calculateDiscountedCost(0.35, cost);
                break;
            case 'c':
                total = cost;
                break;
            default:
                throw new ArgumentException("El tipo de cliente es desconocido", nameof(type));
        }
        
        return total;
    };

    private static Func<double, double, double>
        _calculateDiscountedCost = (percent, total) => total - (total * percent);

    private static void PrintCost()
    {
        try
        {
            Console.WriteLine($"El costo de el tratamiento para el socio es de $ {_calculateFinalTreatmentCost(_readPartnerType(), _readTreatmentCost())}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}