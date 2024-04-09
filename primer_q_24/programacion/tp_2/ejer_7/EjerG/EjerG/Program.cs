namespace EjerG;

class Program
{
    static void Main(string[] args)
    {
        int number = GetInteger("Ingrese el número: ");
        
        Console.Write("El valor absoluto del numero "+ number+ " es: "+ Math.Abs(number));
    }

    static int GetInteger(string message)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(message);
            isValid = int.TryParse(Console.ReadLine(), out value);

            if (!isValid)
            {
                Console.WriteLine("Entrada invalida, intente nuevamente... ");
            }
        } while (!isValid);

        return value;
    }
    
}