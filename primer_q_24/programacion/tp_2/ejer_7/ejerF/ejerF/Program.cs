using System.Diagnostics.SymbolStore;
namespace ejerF;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3;
        float resultado = 0;
        num1 = SolicitarEntero("Ingrese el primer numero: ");
        num2 = SolicitarEntero("Ingrese el segundo numero: ");
        num3 = SolicitarEntero("Ingrese el tercer numero: ");

        if (num1 - num2 > num3)
        {
            resultado = num1 * num2;
        }
        else
        {
            if (num2 == 0)
            {
                Console.WriteLine("No es posible realizar la operacion devido a que els egundo numero es 0 y no se puede dividir por 0.");
            }
            else
            {
                resultado = num1 / num2;
            }
        }
        Console.WriteLine("El resultado es: "+  resultado);
    }
    static int SolicitarEntero(string mensaje)
    {
        int valor;
        bool esValido;
        do
        {
            Console.Write(mensaje);
            esValido = int.TryParse(Console.ReadLine(), out valor);
            if (!esValido)
            {
                Console.WriteLine("Entrada no válida. Intente nuevamente.");
            }
        } while (!esValido);

        return valor;
    }
}