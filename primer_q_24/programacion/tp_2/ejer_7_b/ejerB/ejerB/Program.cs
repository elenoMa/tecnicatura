namespace ejerB;

class Program
{
    static void Main(string[] args)
    {
        Double value, thirtyPercentValue;
        string inAux;
        Boolean validInput = false;

        Console.Write("Bienvenido, ingrese el valor: ");
        do
        {
            inAux = Console.ReadLine();

            if (Double.TryParse(inAux, out value))
            {
                validInput = true;
            }
            else
            {
                Console.Write("El valor ingresado no es valido, por favor intenete nuevamente: ");
            }
        } while (!validInput);

        thirtyPercentValue = value * 0.3;
        
        Console.WriteLine("El 30% del valor "+ value + " ingresado es: "+ thirtyPercentValue);

    }
}