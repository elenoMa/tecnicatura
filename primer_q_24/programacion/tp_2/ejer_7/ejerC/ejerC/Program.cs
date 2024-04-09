namespace ejerC;

class Program
{
    static void Main(string[] args)
    {
        float num1, num2;
        string inAux;
        bool validInput = false;
        
        Console.Write("Bienvenido, ingrese el primer numero: ");

        do
        {
            inAux = Console.ReadLine();

            if (float.TryParse(inAux, out num1))
            {
                validInput = true;
            }
            else
            {
                Console.Write("El valor ingresado no es un valor valido, por favor ingrese un nuevo valor: ");
            }
        } while (!validInput);

        validInput = false;
        Console.Write("Ingrese el siguiente numero: ");
        do
        {
            inAux = Console.ReadLine();
            if (float.TryParse(inAux, out num2))
            {
                validInput = true;
            }
            else
            {
                Console.Write("El valor ingresado no es un valor valido, por favor ingrese un nuevo valor: ");
            }
        } while (!validInput);

        if (num1 >= num2)
        {
            Console.Write("El numero 1: "+ num1+ " es mayor o igual que el segundo: "+ num2);
        }
        else
        {
            Console.WriteLine("El numero 2: "+num2+" es mayor que "+num1);
        }
        
    }
    
}