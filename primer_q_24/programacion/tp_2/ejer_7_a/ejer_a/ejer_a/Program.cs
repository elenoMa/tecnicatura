namespace ejer_a;

class Program
{
    static void Main(string[] args)
    {
        float number1, number2, result;
        string inAux;
        Boolean validNumber = false;
        
        
        Console.Write("Bienvenido, ingrese el primer numero a sumar: ");
        do
        {
            inAux = Console.ReadLine();
            if (float.TryParse(inAux, out number1)) 
            {
                validNumber = true;
            }
            else
            {
                Console.Write("El numero ingresado no es un numero valido, porfavor ingrese nuevamente el numero: ");
            }
        } while (!validNumber);

        validNumber = false;
        Console.Write("Ingrese el segundo numero a sumar: ");

        do
        {
            inAux = Console.ReadLine();
            if (float.TryParse(inAux, out number2))
            {
                validNumber = true;
            }
            else
            {
                Console.Write("El numero ingresado no es un numero valido, porfavor ingrese nuevamente el numero: ");
            }
        } while (!validNumber);
        
        result = number1 + number2;

        Console.WriteLine("El resultado de sumar " + number1 + " y " + number2 + " es: " + result);
        
    }
}