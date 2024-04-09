namespace EjerF;
/*
 * Una persona compra un objeto que cuesta “c” pesos pagando con “p” pesos (tal que “c” es menor o igual a “p”).
   El "vuelto" resultante será p-c pesos.
   Suponiendo que se dispone de una cantidad ilimitada de billetes de 50, 25, 10, 5 y 1 pesos, escriba un algoritmo que dados c y p,
   calcule la cantidad a dar de cada denominación de billete si se desea utilizar la menor cantidad de billetes posibles.

    Asumimos que “c” y “p” son números enteros (no hay vuelto en centavos).
 */

class Program
{
    private static readonly int[] Bills = new[] { 50, 25, 10, 5, 1 };

    static void Main(string[] args)
    {
        int pay, mount;
        List<int> turned;

        mount = _getInt("Ingrese el monto a pagar: ");
        pay = _getInt("Ingrese el total pagado por el cliente: ");

        turned = _getTurned(pay - mount);
        PrintBillsToReturn(turned);
        Console.WriteLine($"Vuelto total ${pay - mount}");
    }

    private static void PrintBillsToReturn(List<int> turned)
    {
        Console.WriteLine("Cantidad de billetes a devolver:");
        for (int i = 0; i < turned.Count; i++)
        {
            int billTotal = turned[i] * Bills[i];
            Console.WriteLine($"Billetes de {Bills[i]}: {turned[i]} billetes, total: {billTotal}");
        }
    }

    private static Func<string, int> _getInt = (speech) =>
    {
        //Vale la pena meter un terminador? ejem al intertar erroneamente 3 veces terminar el ciclo... qsy
        int number;

        Console.Write(speech);
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("La entrada es inválida, inténtelo nuevamente...");
            return _getInt(speech);
        }

        return number;
    };

    private static Func<int, List<int>> _getTurned = (change) =>
    {
        List<int> turned = new List<int>();

        foreach (var bill in Bills)
        {
            turned.Add(change / bill);
            change %= bill;
        }

        return turned;
    };
}