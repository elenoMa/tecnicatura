using System;
using System.Collections.Generic;

namespace EjercicioE
{
    class Program
    {
        static void Main(string[] args)
        {
            int costo, pago, vuelto;
            List<int> billetes = new List<int>() { 50, 25, 10, 5, 1 };
            List<int> cantidadBilletes = new List<int>();

            Console.WriteLine("Cálculo de vuelto");
            costo = SolicitarEntero("Ingrese el total a pagar: ");
            pago = SolicitarEntero("Ingrese el monto pagado por el cliente: ");

            vuelto = pago - costo;

            if (vuelto < 0)
            {
                Console.WriteLine("El pago es insuficiente.");
            }
            else
            {
                for (int i = 0; i < billetes.Count; i++)
                {
                    int billete = billetes[i];
                    cantidadBilletes.Add(vuelto / billete);
                    vuelto -= cantidadBilletes[i] * billete;
                }

                Console.WriteLine("El vuelto es: $" + (pago - costo) + " y debe entregar la siguiente cantidad de billetes:");
                Console.WriteLine("- $50  ->  " + cantidadBilletes[0]);
                Console.WriteLine("- $25  ->  " + cantidadBilletes[1]);
                Console.WriteLine("- $10  ->  " + cantidadBilletes[2]);
                Console.WriteLine("- $5   ->  " + cantidadBilletes[3]);
                Console.WriteLine("- $1   ->  " + cantidadBilletes[4]);
            }
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
}
