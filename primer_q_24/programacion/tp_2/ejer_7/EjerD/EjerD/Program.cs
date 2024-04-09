namespace EjerD;

class Program
{
    static void Main(string[] args)
    {
        const double INCH_FACTOR = 39.37;
        const double FEET_FACTOR = 12;
        double distanceInMeters, distanceInFeets;

        
        string inAux;
        Boolean validInput = false;
        
        Console.Write("Bienvenido, ingrese la distancia expresada en metros a convertir: ");

        do
        {
            inAux = Console.ReadLine();

            if (double.TryParse(inAux, out distanceInMeters))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("La distancia ingresada es invalida, ingrese el valor nuevamente: ");
            }

        } while (!validInput);

        distanceInFeets = distanceInMeters == 0 ? (distanceInMeters / INCH_FACTOR) * FEET_FACTOR : 0;
        
        Console.WriteLine("La distancia expresada en pies es: "+ (distanceInFeets != 0 ? distanceInFeets : 0));
    }
}